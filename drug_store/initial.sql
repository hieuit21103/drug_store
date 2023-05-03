CREATE TABLE IF NOT EXISTS taikhoan (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  tenhienthi VARCHAR(100),
  taikhoan VARCHAR(100) NOT NULL,
  matkhau VARCHAR(100) NOT NULL,
  loai INTEGER NOT NULL
);

CREATE TABLE IF NOT EXISTS khachhang (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  hoten VARCHAR(100) NOT NULL,
  tuoi INTEGER NOT NULL,
  sdt INTEGER CHECK (sdt BETWEEN 100000000 AND 9999999999) NOT NULL, 
  diachi VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS nhanvien (
  id INTEGER PRIMARY KEY NOT NULL,
  ten VARCHAR(50),
  gioitinh INTEGER NOT NULL,
  diachi VARCHAR(150),
  sdt INTEGER CHECK (sdt BETWEEN 100000000 AND 9999999999),
  email VARCHAR(255) NOT NULL CHECK (email LIKE '%@%.%'),
  luong FLOAT NOT NULL,
  ngaylam DATE
);

CREATE TABLE IF NOT EXISTS nhomthuoc (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  tennhom VARCHAR(100) NOT NULL,
  ghichu VARCHAR(100)
);

CREATE TABLE IF NOT EXISTS nhaphanphoi (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  tennpp VARCHAR(100) NOT NULL,
  diachi VARCHAR(100) NOT NULL,
  masothue VARCHAR(50) NOT NULL,
  ghichu VARCHAR(200) NOT NULL
);

CREATE TABLE IF NOT EXISTS nhasanxuat (
  id INTEGER PRIMARY KEY AUTOINCREMENT,
  tennsx VARCHAR(100) NOT NULL,
  diachi VARCHAR(200) NOT NULL,
  sdt INTEGER CHECK (sdt BETWEEN 1000000000 AND 9999999999) NOT NULL,
  ghichu VARCHAR(100)
);


create table if not exists donvitinh
(
	id integer not null primary key AUTOINCREMENT,
	tendvt varchar(50) not null
);
create table if not exists thuoc
(
	id integer not null primary key AUTOINCREMENT,
	idnhom int not null,
	idnsx int not null,
	iddvt int not null,
	soluong int not null,
	giaban decimal(15,2) not null,
	tenthuoc varchar(50) not null,
	nguongoc varchar(100) not null,
	ghichu varchar(200),
    foreign key (idnhom) references nhomthuoc(id),
    foreign key (idnsx) references nhasanxuat(id),
    foreign key (iddvt) references donvitinh(id)
);
create table if not exists hoadonnhap
(
	id integer not null primary key AUTOINCREMENT,
	idnpp int not null,
	nguoigiao varchar(50) not null,
	nguoinhan varchar(50) not null,
	tongtienthuoc decimal(15,2) not null,
	tongthue float,
	foreign key (idnpp) references nhaphanphoi(id)
);
create table if not exists chitiethoadonnhap
(
	id integer not null primary key AUTOINCREMENT,
	idhdn int not null,
	idthuoc int not null,
	soluong int not null,
	gianhap int not null,
    foreign key (idhdn) references hoadonnhap(id),
    foreign key (idthuoc) references thuoc(id)
);
create table if not exists hoadonxuat
(
	id integer not null primary key AUTOINCREMENT,
	idbn int not null,
	masbn varchar(50) not null,
	ngaylap date not null,
	tongthue float not null,
	tongtienthuoc decimal(15,2) not null,
    foreign key (idbn) references khachhang(id)
);

create table if not exists chitiethoadonxuat
(
	id integer not null primary key AUTOINCREMENT,
	idhdx int not null,
	idthuoc int not null,
	soluong int not null,
	giaban decimal(15,2) not null,
	thue float not null,
    foreign key (idhdx) references hoadonxuat(id),
    foreign key (idthuoc) references thuoc(id)
);
create table if not exists khohang 
(
	id int not null primary key,
	idthuoc int not null,
	ngaynhap date not null,
	luongton int not null,
	thongtinsanpham varchar(100) not null,
	solohang int not null,
	foreign key (idthuoc) references thuoc(id)
);
create table if not exists lichsugiaodich
(
	id int primary key not null,
	idbn int not null,
	ngaygd date not null,
	soluong int not null,
	tongthanhtien float not null,
    foreign key (idbn) references khachhang(id)
);

create table if not exists baocaothongke
(
	id int not null primary key,
	idtonkho int not null references khohang(id),
	idthuoc int not null references thuoc(id),
	thoigianthongke datetime not null,
	doanhthu float not null,
	soluongbanra int not null,
	topsanpham varchar(100),
    foreign key (idtonkho) references khohang(id),
    foreign key (idthuoc) references thuoc(id)
);

create table if not exists giohang(
	id int not null,
    soluong int not null,
    foreign key (id) references thuoc(id)
);



