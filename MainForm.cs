
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Shopee;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ShopeeApiWinForms
{
    public partial class MainForm : Form
    {
       public MainForm()
        {
            InitializeComponent();
            TesAPI();
        }


        public static class ShopeeSignatureHelper
        {
            public static string GenerateSignature(string partnerKey, string apiPath, long timestamp)
            {
                string baseString = $"{1279103}{apiPath}{timestamp}"; // Ganti 1279103 dengan partner_id
                byte[] keyBytes = Encoding.UTF8.GetBytes(partnerKey);
                byte[] messageBytes = Encoding.UTF8.GetBytes(baseString);

                using (var hmac = new HMACSHA256(keyBytes))
                {
                    byte[] hashBytes = hmac.ComputeHash(messageBytes);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }

            public static long GetCurrentTimestamp()
            {
                return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            }
        }

        public async void TesAPI()
        {
            string partnerKey = "655153554a6f7071674365457253666c786e43526f53646a4f61644d4e715759";
            string apiPath = "/api/v2/shop/get_shop_info"; // Contoh API endpoint
            long timestamp = ShopeeSignatureHelper.GetCurrentTimestamp();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    // Generate Signature
                    string signature = ShopeeSignatureHelper.GenerateSignature(
                        partnerKey,
                        apiPath,
                        timestamp
                    );

                    // Build Request URL
                    string sandboxUrl = $"https://partner.test-stable.shopeemobile.com{apiPath}?shop_id=1047450585";

                    // Set Headers
                    //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
                    MessageBox.Show(sandboxUrl);
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"SHA256 {signature}");


                    // Send Request
                    HttpResponseMessage response = await httpClient.GetAsync(sandboxUrl);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Process Response
                    if (response.IsSuccessStatusCode)
                    {
                        dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);
                        textBox1.Text = JsonConvert.SerializeObject(jsonResponse, Formatting.Indented);
                    }
                    else
                    {
                        textBox1.Text = $"Error: {response.StatusCode}\n{responseContent}";
                    }
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = $"Exception: {ex.Message}";
            }
        }
    }
}

public class ShopeeAPITest
{
    private static readonly HttpClient client = new HttpClient();
    private const int PartnerId = 1279103;
    private const string PartnerKey = "655153554a6f7071674365457253666c786e43526f53646a4f61644d4e715759";
    private const string BaseUrl = "https://partner.test-stable.shopee.co.id"; // Sesuaikan region

    public static async Task TestShopeeAPI()
    {
        try
        {
            // 1. Generate Timestamp (Unix time dalam detik)
            long timestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;

            // 2. Tentukan endpoint (contoh: /api/v2/shop/get_shop_info)
            string path = "/api/v2/shop/get_shop_info";

            // 3. Generate Signature
            string signature = GenerateSignature(PartnerId, PartnerKey, timestamp, path);

            // 4. Setup Request URL dengan parameter
            string requestUrl = $"{BaseUrl}{path}?partner_id={PartnerId}&timestamp={timestamp}&signature={signature}";

            // 5. Setup Header
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", $"sha256 {signature}");

            // 6. Kirim GET Request
            HttpResponseMessage response = await client.GetAsync(requestUrl);
            string responseBody = await response.Content.ReadAsStringAsync();

            MessageBox.Show($"Status Code: {response.StatusCode}");
            MessageBox.Show($"Response: {responseBody}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }

    private static string GenerateSignature(int partnerId, string partnerKey, long timestamp, string path)
    {
        // Format: partner_id + path + timestamp
        string baseString = $"{partnerId}{path}{timestamp}";
        string key = partnerKey;

        // Hitung SHA-256
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] baseStringBytes = Encoding.UTF8.GetBytes(baseString + key);
            byte[] hashBytes = sha256.ComputeHash(baseStringBytes);

            // Konversi ke hexadecimal lowercase
            StringBuilder signature = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                signature.Append(b.ToString("x2")); // "x2" untuk hex lowercase
            }

            return signature.ToString();
        }
    }
}

