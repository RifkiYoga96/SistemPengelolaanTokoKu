
CREATE TABLE produk (
  id_produk INT IDENTITY(1,1) PRIMARY KEY,
  nama_produk VARCHAR(50) NOT NULL,
  harga INT NOT NULL
);

CREATE TABLE komponen (
  id_komponen INT IDENTITY(1,1) PRIMARY KEY,
  nama_komponen VARCHAR(50) NOT NULL,
  satuan VARCHAR(10) NOT NULL,
  harga INT NOT NULL,
  stok INT NOT NULL,
  stok_minimum INT NOT NULL
);

CREATE TABLE komponen_produk (
  id_produk INT NOT NULL,
  id_komponen INT NOT NULL,
  jumlah INT NOT NULL,
  FOREIGN KEY (id_produk) REFERENCES produk(id_produk)
	ON DELETE NO ACTION
	ON UPDATE CASCADE,
  FOREIGN KEY (id_komponen) REFERENCES komponen(id_komponen)
	ON DELETE NO ACTION
	ON UPDATE CASCADE
);

CREATE TABLE transaksi (
  id_transaksi INT IDENTITY(1,1) PRIMARY KEY,
  tanggal DATE NOT NULL,
  status VARCHAR(20) NOT NULL,  -- contoh: 'proses', 'selesai', 'batal'
  tipe BIT NOT NULL,
  admin DECIMAL(18,2),
  nominal_diskon INT
);

CREATE TABLE transaksi_detail (
  id_transaksi_detail INT IDENTITY(1,1) PRIMARY KEY,
  id_transaksi INT NOT NULL,
  id_produk INT,
  nama_transaksi VARCHAR(50) NOT NULL,
  harga INT NOT NULL,
  jumlah INT NOT NULL,
  FOREIGN KEY (id_transaksi) REFERENCES transaksi(id_transaksi)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE transaksi_komponen_detail (
  id_transaksi_detail INT NOT NULL,
  id_komponen INT NOT NULL,
  nama_komponen VARCHAR(50) NOT NULL,
  satuan VARCHAR(10) NOT NULL,
  jumlah INT NOT NULL,
  harga INT NOT NULL,
  FOREIGN KEY (id_transaksi_detail) REFERENCES transaksi_detail(id_transaksi_detail)
  ON DELETE CASCADE
  ON UPDATE CASCADE,
);


CREATE TABLE operasional (
  id_pengeluaran INT IDENTITY(1,1) PRIMARY KEY,
  nama_pengeluaran VARCHAR(30) NOT NULL,
  jumlah_pengeluaran DECIMAL(10,2) NOT NULL,
);

