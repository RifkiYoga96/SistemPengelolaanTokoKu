CREATE TABLE produk (
    id_produk INT IDENTITY(1,1) PRIMARY KEY,
    nama_produk VARCHAR(30),
    harga INT
);

CREATE TABLE komponen (
    id_komponen INT IDENTITY(1,1) PRIMARY KEY,
    nama_komponen VARCHAR(30),
    harga INT,
    stok INT
);

CREATE TABLE komponen_produk (
    id_produk INT,
    id_komponen INT,
    jumlah INT
);

CREATE TABLE pengeluaran (
	id_pengeluaran INT IDENTITY(1,1) PRIMARY KEY,
	nama_pengeluaran VARCHAR(30),
	jumlah_pengeluaran DECIMAL(10,2)
);

CREATE TABLE transaksi (
    id_transaksi INT IDENTITY(1,1) PRIMARY KEY,
    nama_transaksi VARCHAR(50),
    tanggal_input DATE,
    pendapatan_kotor INT,
    modal INT,
    pendapatan_bersih INT,
    pengeluaran INT,
    jumlah INT,
    tipe BIT
);

DROP TABLE pengeluaran;

DROP TABLE transaksi;

