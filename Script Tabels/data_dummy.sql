INSERT INTO produk (nama_produk, harga) VALUES
('Alarm', 20000),
('Alarm Saklar', 15000);

INSERT INTO komponen (nama_komponen, harga, stok) VALUES
('Buzzer', 5000, 100),
('Resistor', 2000, 100),
('Transistor', 3000, 100),
('Saklar', 10000, 100),
('LED', 5000, 100);

INSERT INTO komponen_produk (id_produk, id_komponen, jumlah) VALUES
(1, 1, 1),
(1, 2, 2),
(1, 3, 1),
(2, 4, 1),
(2, 5, 2);

INSERT INTO pengeluaran (nama_pengeluaran, jumlah_pengeluaran) VALUES
('Biaya Iklan', 8000.00),
('Biaya Admin',0.12);

INSERT INTO transaksi (nama_transaksi, tanggal_input, pendapatan_kotor, modal, pendapatan_bersih, pengeluaran, jumlah) VALUES
('Penjualan Alarm Basic', '2025-05-11', 150000, 80000, 70000, 0, 1),
('Penjualan Alarm Pro', '2025-05-11', 300000, 160000, 140000, 0, 2),
('Pengeluaran: Beli Solder', '2025-05-11', NULL, NULL, NULL, 50000, 1),
('Pengeluaran: Beli Kabel', '2025-05-11', NULL, NULL, NULL, 20000, 1);



--Query Tambaahan--
DELETE FROM pengeluaran;