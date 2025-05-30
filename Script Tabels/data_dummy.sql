INSERT INTO produk (nama_produk, harga) VALUES
('Meja Belajar', 500000),
('Kursi Kantor', 350000),
('Rak Buku', 400000);

INSERT INTO komponen (nama_komponen, satuan, harga, stok, stok_minimum) VALUES
('Kayu Jati', 'Lembar', 100000, 50, 10),
('Skrup', 'Pcs', 500, 1000, 100),
('Cat Kayu', 'Liter', 25000, 20, 5),
('Kaca', 'Lembar', 75000, 10, 2);

-- Asumsi id_produk dimulai dari 1 dan id_komponen juga dari 1
INSERT INTO komponen_produk (id_produk, id_komponen, jumlah) VALUES
(1, 1, 3), -- Meja Belajar pakai 3 Kayu Jati
(1, 2, 20), -- Meja Belajar pakai 20 Skrup
(1, 3, 1),  -- Meja Belajar pakai 1 Liter Cat Kayu

(2, 1, 2),  -- Kursi Kantor pakai 2 Kayu Jati
(2, 2, 15), -- Kursi Kantor pakai 15 Skrup

(3, 1, 2),  -- Rak Buku pakai 2 Kayu Jati
(3, 4, 1);  -- Rak Buku pakai 1 Kaca

INSERT INTO transaksi (tanggal, status, tipe, admin, nominal_diskon) VALUES
('2024-05-30', 'selesai', 1, 0.88, 8000),
('2024-05-29', 'proses', 1,  0.88, 0),
('2024-05-28', 'batal', 1,  0.88, 0);

INSERT INTO transaksi_detail (id_transaksi, id_produk, nama_transaksi, harga, jumlah) VALUES
(1, 1, 'Meja Belajar', 50000, 1), -- 2 meja
(1, 2, 'Kursi Kantor', 50000, 1), -- 1 kursi
(2, 3, 'Rak Buku', 40000, 1);     -- 1 rak

-- Transaksi_detail_id = 1 (Meja Belajar, qty 2) → total komponen dikali 2
INSERT INTO transaksi_komponen_detail (id_transaksi_detail, id_komponen, nama_komponen, satuan, jumlah, harga) VALUES
(1, 1, 'Kayu Jati', 'Lembar', 6, 400),
(1, 2, 'Skrup', 'Pcs', 40, 500),
(1, 3, 'Cat Kayu', 'Liter', 2, 450);

-- Transaksi_detail_id = 2 (Kursi Kantor, qty 1)
INSERT INTO transaksi_komponen_detail (id_transaksi_detail, id_komponen, nama_komponen, satuan, jumlah, harga) VALUES
(2, 1, 'Kayu Jati', 'Lembar', 2, 1000),
(2, 2, 'Skrup', 'Pcs', 15, 500);

