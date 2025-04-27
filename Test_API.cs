using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopee
{
    public partial class Test_API : Form
    {
        private const long PartnerId = 1279103; // Dari gambar yang Anda bagikan
        private const string PartnerKey = "655153554a6f7071674365457253666c786e43526f53646a4f61644d4e715759"; // API Key Anda
        private const long ShopId = 123456; // ID Toko Anda

        private readonly HttpClient _httpClient;
        public Test_API()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Buat timestamp (UNIX time dalam detik)
                long timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();

                // Base URL untuk Shopee Open Platform API (ganti dengan URL yang benar sesuai region)
                string baseUrl = "https://partner.test-stable.shopeemobile.com";

                // Path untuk endpoint order list
                string apiPath = "/api/v2/order/get_order_list";

                // Parameter untuk query
                var queryParams = new Dictionary<string, string>
                {
                    { "partner_id", PartnerId.ToString() },
                    { "timestamp", timestamp.ToString() },
                    { "shop_id", ShopId.ToString() },
                    // Parameter tambahan sesuai kebutuhan
                    { "time_range_field", "create_time" },
                    { "time_from", (timestamp - 604800).ToString() }, // 7 hari yang lalu
                    { "time_to", timestamp.ToString() },
                    { "page_size", "10" }
                };

                // Buat signature untuk autentikasi
                string signature = GenerateSignature(apiPath, PartnerId, PartnerKey, timestamp);
                queryParams.Add("sign", signature);

                // Bangun URL lengkap dengan query parameters
                string url = baseUrl + apiPath + "?" + string.Join("&", queryParams.Select(p => $"{p.Key}={p.Value}"));

                // Buat request
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();

                    // Parse JSON response
                    using (JsonDocument doc = JsonDocument.Parse(jsonString))
                    {
                        var root = doc.RootElement;

                        // Periksa error
                        if (root.TryGetProperty("error", out var errorElement) &&
                            errorElement.ToString() != "0")
                        {
                            MessageBox.Show($"API Error: {root.GetProperty("message").ToString()}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Ambil data order dari response jika berhasil
                        if (root.TryGetProperty("response", out var responseElement) &&
                            responseElement.TryGetProperty("order_list", out var orderListElement))
                        {
                            var orders = new List<OrderDetails>();

                            // Loop melalui array order
                            foreach (var order in orderListElement.EnumerateArray())
                            {
                                var orderDetails = new OrderDetails
                                {
                                    OrderSn = order.GetProperty("order_sn").ToString(),
                                    OrderStatus = order.GetProperty("order_status").ToString(),
                                    PaymentMethod = order.TryGetProperty("payment_method", out var paymentMethod) ?
                                        paymentMethod.ToString() : "Unknown",
                                    TotalAmount = order.TryGetProperty("total_amount", out var totalAmount) ?
                                        totalAmount.GetDecimal() : 0
                                };

                                orders.Add(orderDetails);
                            }

                            // Bind data ke DataGridView
                            dataGridViewOrders.DataSource = orders;
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"HTTP Error: {response.StatusCode} - {response.ReasonPhrase}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateSignature(string apiPath, long partnerId, string partnerKey, long timestamp)
        {
            // Format untuk signature adalah: {PARTNER_ID}{API_PATH}{TIMESTAMP}{PARTNER_KEY}
            string stringToSign = $"{partnerId}{apiPath}{timestamp}{partnerKey}";

            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(partnerKey)))
            {
                byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));

                // Konversi hash bytes ke hexadecimal string
                StringBuilder hex = new StringBuilder(hashBytes.Length * 2);
                foreach (byte b in hashBytes)
                {
                    hex.AppendFormat("{0:x2}", b);
                }

                return hex.ToString();
            }
        }
    }
}

public class OrderDetails
{
    public string OrderSn { get; set; }
    public string OrderStatus { get; set; }
    public string PaymentMethod { get; set; }
    public decimal TotalAmount { get; set; }
}
