create database QUANLYTIECCUOI_NEW
USE QUANLYTIECCUOI_NEW
set dateformat dmy
--- Tạo bảng lưu thông tin Sảnh
create table SANH (
	MaSanh varchar(10) primary key,
	MaLoaiSanh varchar(10),
	TenSanh nvarchar(40),
	SoLuongBanToiDa int,
	GhiChu nvarchar(100),
)

--- Thêm dữ liệu
insert into SANH values ('MS001', 'MLS001', N'Kim cương', 100,'')
insert into SANH values ('MS002', 'MLS004', N'Bạch Kim', 60,'')
insert into SANH values ('MS003', 'MLS002', N'Đồng thau', 50,'')
insert into SANH values ('MS004', 'MLS003', N'Sắt Đá', 40,'')
insert into SANH values ('MS005', 'MLS005', N'Vàng kim', 30,'')
insert into SANH values ('MS006', 'MLS005', N'Vàng bạc', 25,'')
insert into SANH values ('MS007', 'MLS002', N'Ngọc bích', 70,'')
insert into SANH values ('MS008', 'MLS001', N'Đá quý', 75,'')
insert into SANH values ('MS009', 'MLS004', N'Lục bảo', 85,'')
insert into SANH values ('MS0010', 'MLS003', N'Pha lê', 55,'')

-- Tạo bảng lưu thông tin Loại Sảnh
create table LOAISANH (
	MaLoaiSanh varchar(10) primary key,
	TenLoaiSanh varchar(10),
	DonGiaBanToiThieu money,
)

--- Thêm dữ liệu
insert into LOAISANH values('MLS001', 'A', 1000000)
insert into LOAISANH values('MLS002', 'B', 1100000)
insert into LOAISANH values('MLS003', 'C', 1200000)
insert into LOAISANH values('MLS004', 'D', 1400000)
insert into LOAISANH values('MLS005', 'E', 1600000)

-- Tạo bảng lưu thông tin Ca
create table CA (
	MaCa int primary key,
	TenCa nvarchar(10),
)
--- Thêm dữ liệu
insert into CA values(1, N'Trưa')
insert into CA values(2, N'Tối')

--- Tạo bảng lưu thông tin Tiệc
create table TIEC (
	MaTiec varchar(10) primary key,
	TenKhachHang nvarchar(40),
	TenChuRe nvarchar(40),
	TenCoDau nvarchar(40),
	DienThoai varchar(10),
	NgayDatTiec smalldatetime,
	NgayDaiTiec smalldatetime,
	GioDaiTiec time(0),
	MaCa int foreign key references CA(MaCa),
	MaSanh varchar(10) foreign key references SANH(MaSanh),
	SoBanDuTru int,
	TienDatCoc money,
	SoLuongBan int,
	NgayThanhToan smalldatetime,
)

--- Thêm dữ liệu
/*
insert into TIEC values('MT001', N'Nguyễn Văn Lâm', N'Lê Văn Thiện', N'Nguyễn Ngọc Thư', '0933435345', '13/05/2021','20/06/2021', '11:00:00', 1, 'MS002', 15, 25000000, 45, '20/06/2021')
insert into TIEC values('MT002', N'Nguyễn Thị Hạnh', N'Lê Tuấn Khang', N'Nguyễn Thị Ngọc', '0967859432', '22/04/2021', '12/05/2021', '19:00:00', 2, 'MS004', 5, 20000000, 30, '13/05/2021')
insert into TIEC values('MT003', N'Trần Văn Đông', N'Trần Anh Tuấn', N'Nguyễn Thị Như', '0923456789', '11/01/2021', '04/02/2021', '12:00:00', 1, 'MS003', 5, 20000000, 45, '06/02/2021')
insert into TIEC values('MT004', N'Nguyễn Thành Hiệp', N'Phạm Dương', N'Nguyễn Thị Pháp', '0967879823', '11/4/2021','10/05/2021', '18:00:00', 2, 'MS001', 10, 5000000, 90, '10/05/2021')
insert into TIEC values('MT005', N'Lý Đông Anh', N'Lý Thân', N'Lâm Thị Ngọc Thiện', '0962434567', '13/01/2021','04/02/2021', '19:00:00', 2, 'MS005', 0, 15000000, 30, '04/02/2021')
insert into TIEC values('MT006', N'Lê Văn Hoàng', N'Lê Văn Hoàng', N'Ngô Thị Hậu', '0979521432', '12/07/2021','10/08/2021', '11:00:00', 1, 'MS001', 10, 50000000, 90, '10/08/2021')
insert into TIEC values('MT007', N'Phạm Quang Hiếu', N'Phạm Quang Hiếu', N'Nguyễn Thị Thu Thảo', '0945472345', '19/06/2022','01/07/2021', '11:00:00', 1, 'MS002', 10, 30000000, 50, '01/07/2021')
insert into TIEC values('MT008', N'Đinh Nhân Văn', N'Đinh Nhân Văn', N'Lý Thị Hóa', '0909215345', '11/06/2021','01/07/2021', '19:00:00', 2, 'MS0010', 15, 45000000, 70, '02/07/2021')
insert into TIEC values('MT009', N'Lê Đức Thông', N'Lê Đức Thông', N'Nguyễn Phương Minh', '0973123898', '22/09/2021','06/10/2021', '11:00:00', 1, 'MS008', 15, 40000000, 60, '06/10/2021')
insert into TIEC values('MT010', N'Tạ Nhật Minh', N'Tạ Nhật Minh', N'Nguyễn Ngọc Hà My', '0934567943', '11/11/2021','30/11/2021', '18:00:00', 2, 'MS007', 10, 35000000, 60, '01/12/2021')
insert into TIEC values('MT011', N'Nguyễn Minh Tiến', N'Nguyễn Minh TIến', N'Nguyễn Thị Phúc', '0967438932', '13/09/2022','29/09/2021', '12:00:00', 1, 'MS009', 5, 45000000, 70, '29/09/2021')
insert into TIEC values('MT012', N'Nguyễn Hoàng Minh', N'Nguyễn Hoàng Minh', N'Đào Thị Mận', '0989643772', '10/09/2021','22/09/2021', '11:00:00', 1, 'MS006', 0, 5000000, 25, '22/09/2021')
insert into TIEC values('MT013', N'Phan Minh Quang', N'Phan Minh Quang', N'Nguyễn Thị Thu Hà', '0965489789', '07/01/2021','20/01/2021', '18:00:00', 2, 'MS0010', 15, 50000000, 60, '20/01/2021')
*/

-- Tạo bảng lưu thông tin món ăn

create table MONAN (
	MaMonAn varchar(10) primary key,
	TenMonAn nvarchar(100),
	DonGia money,
)
--- Thêm dữ liệu
insert into MONAN values('MA001', N'Gỏi tôm thịt','121000')
insert into MONAN values('MA002', N'Tôm sú sốt Thượng Hải','178000')
insert into MONAN values('MA003', N'Gà ta hấp lá chanh','122000')
insert into MONAN values('MA004', N'Bò xào thiên lý','220000')
insert into MONAN values('MA005', N'Lẩu hải sản','197000')
insert into MONAN values('MA006', N'rau câu 3 màu','146000')
insert into MONAN values('MA007', N'Súp hải sản','326000')
insert into MONAN values('MA008', N'Gỏi tai heo hoa chuối','251000')
insert into MONAN values('MA009', N'Gà bó xôi','310000')
insert into MONAN values('MA010', N'Cá diêu hồng chiên xù','288000')
insert into MONAN values('MA011', N'Bò sốt tiêu đen bánh bao','119000')
insert into MONAN values('MA012', N'Tôm sú hấp bia','316000')
insert into MONAN values('MA013', N'Lẩu thái','256000')
insert into MONAN values('MA014', N'trái cây','108000')
insert into MONAN values('MA015', N'Gỏi ngó sen','217000')
insert into MONAN values('MA016', N'Gà ta quay mật ong','405000')
insert into MONAN values('MA017', N'Cá quả chiên xù','271000')
insert into MONAN values('MA018', N'Tôm sú nướng phô mai','257000')
insert into MONAN values('MA019', N'Bò xào bông cải xanh','166000')
insert into MONAN values('MA020', N'Xôi','293000')
insert into MONAN values('MA021', N'bưởi da xanh','136000')
insert into MONAN values('MA022', N'Súp bí đỏ kem nấm','108000')
insert into MONAN values('MA023', N'Tôm hấp trái dừa','485000')
insert into MONAN values('MA024', N'Cá tầm nướng','248000')
insert into MONAN values('MA025', N'Thịt bò lúc lắc','474000')
insert into MONAN values('MA026', N'Chim câu sốt nước','402000')
insert into MONAN values('MA027', N'Gà luộc lá chanh','368000')
insert into MONAN values('MA028', N'Xôi vò hạt sen','106000')
insert into MONAN values('MA029', N'Lẩu cá bớp','394000')
insert into MONAN values('MA030', N'chè nhãn nhục','243000')
insert into MONAN values('MA031', N'Bánh mặn khai vị đầu giờ','399000')
insert into MONAN values('MA032', N'Gỏi bò đồng quê','109000')
insert into MONAN values('MA033', N'Súp tuyết nhĩ thịt gà xé','375000')
insert into MONAN values('MA034', N'Ba chỉ quay giòn bánh hỏi','341000')
insert into MONAN values('MA035', N'Vịt nấu tiêu xanh – bánh mì','418000')
insert into MONAN values('MA036', N'Lẩu gà sa tế','183000')
insert into MONAN values('MA037', N'Chè đông sương tuyết nhĩ','110000')
insert into MONAN values('MA038', N'Bánh Mặn Khai Vị Đầu Giờ','128000')
insert into MONAN values('MA039', N'Gỏi vịt Phương Đông','463000')
insert into MONAN values('MA040', N'Súp Sò Điệp Tam Tơ','166000')
insert into MONAN values('MA041', N'Gà Cuộn Đút Lò Phô Mai','268000')
insert into MONAN values('MA042', N'Sườn Non Hầm Rượu Vang – Bánh Mì','132000')
insert into MONAN values('MA043', N'Nấm Bào Ngư Xào Dầu Hào','279000')
insert into MONAN values('MA044', N'Cơm Chiên Cua','479000')
insert into MONAN values('MA045', N'Chè nha đam ngũ sắc','235000')
insert into MONAN values('MA046', N'Mực Xiên Xốt Thái','301000')
insert into MONAN values('MA047', N'Gỏi Cá Pattaya','231000')
insert into MONAN values('MA048', N'Tàu Hũ Ki Cuộn Tôm','295000')
insert into MONAN values('MA049', N'Súp Cua Trúc Xanh','371000')
insert into MONAN values('MA050', N'Tôm Sú Rang Muối Hong Kong','260000')
insert into MONAN values('MA051', N'Bò Nấu Rượu Vang Pháp – Bánh Mì','197000')
insert into MONAN values('MA052', N'Cơm Chiên Hạt Sen Thịt Cua','157000')
insert into MONAN values('MA053', N'Chè Bách Niên Hảo Hợp','392000')
insert into MONAN values('MA054', N'Càng Cua Xốt Kewpie Vị Tiêu','168000')
insert into MONAN values('MA055', N'Bò Xiên Nướng Cajun','445000')
insert into MONAN values('MA056', N'Chả Cua Bể Bắc Hà','299000')
insert into MONAN values('MA057', N'Gà Nướng Nam Hàn','202000')
insert into MONAN values('MA058', N'Súp Bào Ngư Thịt Cua','234000')
insert into MONAN values('MA059', N'Heo Sữa Quay (1/2 con) – Bánh Bao','422000')
insert into MONAN values('MA060', N'Cá Mú Hấp Tàu Xì Rượu Shaoxing','318000')
insert into MONAN values('MA061', N'Đậu Hũ Tỳ Bà','321000')
insert into MONAN values('MA062', N'Lẩu Hải Sản Pattaya – Bún Tươi','353000')
insert into MONAN values('MA063', N'Nho Đen','249000')
insert into MONAN values('MA064', N'Chem Chép New Zealand Nướng Tiêu','267000')
insert into MONAN values('MA065', N'Gỏi Hải Sản Tam Dương','323000')
insert into MONAN values('MA066', N'Heo Sữa Quay Sứa Biển','441000')
insert into MONAN values('MA067', N'Chả Mực Hạ Long','285000')
insert into MONAN values('MA068', N'Súp Bào Ngư Vi Cá','163000')
insert into MONAN values('MA069', N'Cua Lột Chiên Giòn Xốt Giấm Balsamic','305000')
insert into MONAN values('MA070', N'Bò Mỹ Xốt Nấm Rượu Vang Chile','162000')
insert into MONAN values('MA071', N'Sò Điệp Hầm Gân Nai Đông Cô','284000')
insert into MONAN values('MA072', N'Lẩu Hải Sản Nam Dương – Mì Soba','306000')
insert into MONAN values('MA073', N'Yến Tiềm Hạt Sen','460000')
insert into MONAN values('MA074', N'Súp hải sản măng tây','371000')
insert into MONAN values('MA075', N'Tôm chiên ngự thiện','227000')
insert into MONAN values('MA076', N'Gà hấp lá chanh','355000')
insert into MONAN values('MA077', N'Bò cuộn nấm bỏ lò sốt hạt tiêu xanh','299000')
insert into MONAN values('MA078', N'Cải ngồng trần nấm','372000')
insert into MONAN values('MA079', N'Canh măng nấu giả bào ngư','306000')
insert into MONAN values('MA080', N'Cơm tám thái lan','372000')
insert into MONAN values('MA081', N'Xôi gấc','360000')
insert into MONAN values('MA082', N'chè hạt sen','499000')
insert into MONAN values('MA083', N'Súp hải sâm nấu gà','247000')
insert into MONAN values('MA084', N'Salad rau càng cua bắp bò','378000')
insert into MONAN values('MA085', N'Tôm chiên trứng muối','161000')
insert into MONAN values('MA086', N'Cá hồi áp chảo sốt chanh','386000')
insert into MONAN values('MA087', N'Gà đông tảo hấp hành gừng','189000')
insert into MONAN values('MA088', N'Bò áp chảo sốt tiêu xanh','232000')
insert into MONAN values('MA089', N'Cải làn xào nấm đông cô','356000')
insert into MONAN values('MA090', N'Canh mọc tôm cua','112000')
insert into MONAN values('MA091', N'Xôi nếp','167000')
insert into MONAN values('MA092', N'rau câu','181000')
insert into MONAN values('MA093', N'Salad dầu giấm','205000')
insert into MONAN values('MA094', N'Khăn ướt','9000')
insert into MONAN values('MA095', N'Nước suối','10000')
insert into MONAN values('MA096', N'7 up','16000')
insert into MONAN values('MA097', N'Pepsi','20000')
insert into MONAN values('MA098', N'Coca','25000')
insert into MONAN values('MA099', N'Bia Tiger','327000')
insert into MONAN values('MA100', N'Rượu vang','252000')

-- Tạo bảng lưu thông tin dịch vụ
create table DICHVU (
	MaDichVu varchar(10) primary key,
	TenDichVu nvarchar(100),
	DonGia money,
)
--- Thêm dữ liệu
insert into DICHVU values('MDV001', N'MC dẫn nghi thức lễ','1462000')
insert into DICHVU values('MDV002', N'Màn hình LED (chiếu video kỉ niệm của cô dâu – chú rể và hình ảnh liên quan trong suốt buổi tiệc)','1739000')
insert into DICHVU values('MDV003', N'Pháo kim tuyến','1138000')
insert into DICHVU values('MDV004', N'Ban nhạc trình diễn','1639000')
insert into DICHVU values('MDV005', N'Trang trí backdrop','1424000')
insert into DICHVU values('MDV006', N'Trang trí bàn Gallery','1014000')
insert into DICHVU values('MDV007', N'Bố trí hoa trụ ở lối đi','1093000')
insert into DICHVU values('MDV008', N'Bố trí hoa quanh bàn bánh, tháp ly','1424000')
insert into DICHVU values('MDV009', N'Hoa để bàn tiệc','1710000')
insert into DICHVU values('MDV010', N'Thiết kế và in ấn thiệp cưới','1607000')
insert into DICHVU values('MDV011', N'Thuê trang phục/lễ phục cưới','1294000')
insert into DICHVU values('MDV012', N'Trang điểm ngày cưới','1720000')
insert into DICHVU values('MDV013', N'Wedding Planner','1319000')
insert into DICHVU values('MDV014', N'Phim ảnh cưới','1492000')
insert into DICHVU values('MDV015', N'Điều phối chương trình lễ cưới','1742000')
insert into DICHVU values('MDV016', N'Hệ thống ánh sáng ngày cưới','1626000')
insert into DICHVU values('MDV017', N'Phụ kiện cưới','1185000')
insert into DICHVU values('MDV018', N'Thuê xe cưới','1758000')
insert into DICHVU values('MDV019', N'Rược champage, tháp ly, đá khói','1866000')
insert into DICHVU values('MDV020', N'Bánh kem','1282000')

--Tạo bảng lưu thông tin Tiệc - Dịch vụ
create table TIEC_DICHVU
(
	MaTiec varchar(10) foreign key references TIEC(MaTiec) ,
	MaDichVu varchar(10) ,
	SoLuong int,
	DonGia money,
	GhiChu nvarchar(100),
	primary key (MaTiec, MaDichVu),
)
--- Thêm dữ liệu
/*
insert into TIEC_DICHVU values ('MT001', 'MDV001', 1, 1300000, '')
insert into TIEC_DICHVU values ('MT001', 'MDV004', 1, 1600000, '')
insert into TIEC_DICHVU values ('MT001', 'MDV002', 10, 1500000, '')
insert into TIEC_DICHVU values ('MT001', 'MDV014', 1, 1450000, '')
insert into TIEC_DICHVU values ('MT002', 'MDV001', 1, 1350000, '')
insert into TIEC_DICHVU values ('MT002', 'MDV013', 1, 1300000, '')
insert into TIEC_DICHVU values ('MT002', 'MDV011', 5, 1250000, '')
insert into TIEC_DICHVU values ('MT003', 'MDV008', 6, 1380000, '')
insert into TIEC_DICHVU values ('MT003', 'MDV010', 1, 1600000, '')
insert into TIEC_DICHVU values ('MT003', 'MDV018', 5, 1700000, '')
insert into TIEC_DICHVU values ('MT003', 'MDV019', 1, 1850000, '')
insert into TIEC_DICHVU values ('MT004', 'MDV020', 1, 1280000, '')
insert into TIEC_DICHVU values ('MT004', 'MDV012', 4, 1700000, '')
insert into TIEC_DICHVU values ('MT004', 'MDV002', 1, 1720000, '')
insert into TIEC_DICHVU values ('MT005', 'MDV004', 1, 1620000, '')
insert into TIEC_DICHVU values ('MT005', 'MDV008', 1, 1400000, '')
insert into TIEC_DICHVU values ('MT005', 'MDV005', 1, 1420000, '')
insert into TIEC_DICHVU values ('MT006', 'MDV001', 2, 1390000, '')
insert into TIEC_DICHVU values ('MT006', 'MDV009', 3, 1680000, '')
insert into TIEC_DICHVU values ('MT006', 'MDV007', 5, 1070000, '')
insert into TIEC_DICHVU values ('MT007', 'MDV003', 8, 1050000, '')
insert into TIEC_DICHVU values ('MT007', 'MDV005', 4, 1350000, '')
insert into TIEC_DICHVU values ('MT007', 'MDV020', 1, 1280000, '')
insert into TIEC_DICHVU values ('MT008', 'MDV002', 3, 1670000, '')
insert into TIEC_DICHVU values ('MT008', 'MDV006', 4, 980000, '')
insert into TIEC_DICHVU values ('MT008', 'MDV011', 2, 1800000, '')
insert into TIEC_DICHVU values ('MT009', 'MDV015', 2, 1690000, '')
insert into TIEC_DICHVU values ('MT009', 'MDV016', 2, 16200000, '')
insert into TIEC_DICHVU values ('MT010', 'MDV017', 15, 1050000, '')
insert into TIEC_DICHVU values ('MT010', 'MDV012', 2, 1700000, '')
insert into TIEC_DICHVU values ('MT010', 'MDV001', 1, 1460000, '')
insert into TIEC_DICHVU values ('MT011', 'MDV004', 2, 1620000, '')
insert into TIEC_DICHVU values ('MT011', 'MDV009', 8, 1670000, '')
insert into TIEC_DICHVU values ('MT012', 'MDV019', 1, 1860000, '')
insert into TIEC_DICHVU values ('MT012', 'MDV013', 4, 1300000, '')
insert into TIEC_DICHVU values ('MT012', 'MDV010', 5, 1580000, '')
insert into TIEC_DICHVU values ('MT013', 'MDV001', 1, 1460000, '')
*/
--- Tạo bảng lưu thông tin Tiệc - Món ăn
create table TIEC_MONAN (
	MaTiec varchar(10) foreign key references TIEC(MaTiec),
	MaMonAn varchar(6) ,
	SoLuong int,
	DonGia money,
	primary key (MaTiec, MaMonAn),
)
--- Thêm dữ liệu
/*
insert into TIEC_MONAN values ('MT001', 'MA001', 50, 120000)
insert into TIEC_MONAN values ('MT001', 'MA004', 25, 220000)
insert into TIEC_MONAN values ('MT001', 'MA006', 35, 150000)
insert into TIEC_MONAN values ('MT001', 'MA009', 30, 300000)
insert into TIEC_MONAN values ('MT001', 'MA005', 35, 195000)
insert into TIEC_MONAN values ('MT001', 'MA019', 55, 165000)
insert into TIEC_MONAN values ('MT001', 'MA096', 50, 16000)
insert into TIEC_MONAN values ('MT002', 'MA029', 20, 390000)
insert into TIEC_MONAN values ('MT002', 'MA030', 10, 240000)
insert into TIEC_MONAN values ('MT002', 'MA099', 100, 300000)
insert into TIEC_MONAN values ('MT002', 'MA069', 70, 2850000)
insert into TIEC_MONAN values ('MT002', 'MA020', 50, 280000)
insert into TIEC_MONAN values ('MT002', 'MA025', 35, 470000)
insert into TIEC_MONAN values ('MT002', 'MA016', 65, 390000)
insert into TIEC_MONAN values ('MT003', 'MA021', 50, 120000)
insert into TIEC_MONAN values ('MT003', 'MA024', 45, 245000)
insert into TIEC_MONAN values ('MT003', 'MA036', 30, 180000)
insert into TIEC_MONAN values ('MT003', 'MA037', 70, 100000)
insert into TIEC_MONAN values ('MT003', 'MA040', 50, 165000)
insert into TIEC_MONAN values ('MT003', 'MA044', 65, 450000)
insert into TIEC_MONAN values ('MT003', 'MA100', 20, 250000)
insert into TIEC_MONAN values ('MT004', 'MA097', 60, 20000)
insert into TIEC_MONAN values ('MT004', 'MA093', 45, 190000)
insert into TIEC_MONAN values ('MT004', 'MA081', 60, 280000)
insert into TIEC_MONAN values ('MT004', 'MA072', 30, 300000)
insert into TIEC_MONAN values ('MT004', 'MA049', 55, 370000)
insert into TIEC_MONAN values ('MT005', 'MA098', 30, 25000)
insert into TIEC_MONAN values ('MT005', 'MA045', 50, 225000)
insert into TIEC_MONAN values ('MT005', 'MA044', 30, 470000)
insert into TIEC_MONAN values ('MT005', 'MA034', 45, 335000)
insert into TIEC_MONAN values ('MT005', 'MA038', 50, 125000)
insert into TIEC_MONAN values ('MT005', 'MA012', 40, 300000)
insert into TIEC_MONAN values ('MT005', 'MA003', 35, 120000)
insert into TIEC_MONAN values ('MT006', 'MA098', 40, 25000)
insert into TIEC_MONAN values ('MT006', 'MA023', 20, 485000)
insert into TIEC_MONAN values ('MT006', 'MA008', 35, 250000)
insert into TIEC_MONAN values ('MT006', 'MA052', 25, 150000)
insert into TIEC_MONAN values ('MT006', 'MA055', 20, 440000)
insert into TIEC_MONAN values ('MT007', 'MA097', 50, 20000)
insert into TIEC_MONAN values ('MT007', 'MA089', 35, 350000)
insert into TIEC_MONAN values ('MT007', 'MA060', 20, 310000)
insert into TIEC_MONAN values ('MT007', 'MA044', 40, 470000)
insert into TIEC_MONAN values ('MT007', 'MA035', 25, 410000)
insert into TIEC_MONAN values ('MT007', 'MA022', 35, 100000)
insert into TIEC_MONAN values ('MT008', 'MA095', 70, 10000)
insert into TIEC_MONAN values ('MT008', 'MA095', 70, 10000)
insert into TIEC_MONAN values ('MT008', 'MA028', 70, 100000)
insert into TIEC_MONAN values ('MT008', 'MA048', 55, 290000)
insert into TIEC_MONAN values ('MT008', 'MA059', 55, 415000)
insert into TIEC_MONAN values ('MT008', 'MA091', 60, 160000)
insert into TIEC_MONAN values ('MT009', 'MA096', 65, 16000)
insert into TIEC_MONAN values ('MT009', 'MA068', 55, 160000)
insert into TIEC_MONAN values ('MT009', 'MA054', 60, 168000)
insert into TIEC_MONAN values ('MT009', 'MA033', 45, 375000)
insert into TIEC_MONAN values ('MT009', 'MA072', 40, 300000)
insert into TIEC_MONAN values ('MT009', 'MA045', 65, 230000)
insert into TIEC_MONAN values ('MT009', 'MA081', 70, 340000)
insert into TIEC_MONAN values ('MT010', 'MA096', 50, 16000)
insert into TIEC_MONAN values ('MT010', 'MA085', 50, 160000)
insert into TIEC_MONAN values ('MT010', 'MA036', 35, 180000)
insert into TIEC_MONAN values ('MT010', 'MA091', 50, 165000)
insert into TIEC_MONAN values ('MT010', 'MA004', 50, 215000)
insert into TIEC_MONAN values ('MT011', 'MA075', 45, 225000)
insert into TIEC_MONAN values ('MT011', 'MA057', 30, 200000)
insert into TIEC_MONAN values ('MT011', 'MA096', 65, 16000)
insert into TIEC_MONAN values ('MT011', 'MA020', 65, 270000)
insert into TIEC_MONAN values ('MT011', 'MA049', 40, 370000)
insert into TIEC_MONAN values ('MT011', 'MA063', 35, 245000)
insert into TIEC_MONAN values ('MT011', 'MA030', 35, 240000)
insert into TIEC_MONAN values ('MT011', 'MA096', 65, 16000)
insert into TIEC_MONAN values ('MT012', 'MA095', 75, 10000)
insert into TIEC_MONAN values ('MT012', 'MA006', 75, 145000)
insert into TIEC_MONAN values ('MT012', 'MA010', 35, 285000)
insert into TIEC_MONAN values ('MT012', 'MA016', 35, 400000)
insert into TIEC_MONAN values ('MT012', 'MA029', 40, 390000)
insert into TIEC_MONAN values ('MT013', 'MA095', 75, 10000)
insert into TIEC_MONAN values ('MT013', 'MA100', 35, 250000)
insert into TIEC_MONAN values ('MT013', 'MA075', 45, 220000)
insert into TIEC_MONAN values ('MT013', 'MA046', 30, 300000)
insert into TIEC_MONAN values ('MT013', 'MA033', 35, 375000)
insert into TIEC_MONAN values ('MT013', 'MA038', 75, 120000)
insert into TIEC_MONAN values ('MT013', 'MA028', 65, 100000)
insert into TIEC_MONAN values ('MT013', 'MA013', 35, 255000)
insert into TIEC_MONAN values ('MT013', 'MA014', 55, 100000)
insert into TIEC_MONAN values ('MT013', 'MA022', 45, 105000)
insert into TIEC_MONAN values ('MT013', 'MA030', 50, 240000)
*/
--- Tạo bảng lưu thông tin Hóa Đơn
create table HOADON (
	MaHD varchar(10) primary key,
	MaTiec varchar(10) foreign key references TIEC(MaTiec),
	TongTienBan money,
	TongTienDV money,
	NgayThanhToan smalldatetime,
	TongTienHD money,
)
--- Thêm dữ liệu

--- Tạo bảng lưu thông tin Báo Cáo Doanh Số
create table BAOCAODS (
	MaBC varchar(10) primary key,
	Thang int, 
	Nam int,
	TongDoanhThu money,
)
--- Tạo bảng lưu thông tin chi tiết của báo cáo doanh số
create table CT_BAOCAODS (
	MaBC varchar(10) foreign key references BAOCAODS(MaBC),
	Ngay int, 
	Thang int , 
	Nam int,
	SoLuongTiecCuoi int,
	DoanhThu money,
	TiLe dec,
	primary key (MaBC),
)
--- Tạo bảng lưu các tham số

create table THAMSO (
	KiemTraPhat bit,
	TiLePhat dec (2,2),
)
insert into THAMSO values (0, 0.01)

--- Tạo khóa ngoại cho bảng sảnh
alter table SANH  add constraint FK_SANH  foreign key (MaLoaiSanh) references LOAISANH(MaLoaiSanh)

alter table TIEC_MONAN add constraint FK_TIEC_MONAN foreign key (MaMonAn) references DICHVU(MaMonAn)
---Tạo bảng lưu thông tin Người dùng

create table TAIKHOAN(
	TenTK varchar(50) primary key,
	MatKhau varchar(50),
	HoTen nvarchar(100),
	LoaiTK nvarchar(40),
)
---Thêm dữ liệu
insert into TAIKHOAN values ('huynt', '12345678', N'Nguyễn Thái Huy', 'quanly')
insert into TAIKHOAN values ('datnvt', '87654321', N'Nguyễn Văn Thành Đạt', 'khach_dadangnhap')
insert into TAIKHOAN values ('nhannlt', '98765432', N'Nguyễn Lê Trọng Nhân', 'nhanvien')
insert into TAIKHOAN values ('thienlv', '23456789', N'Lê Văn Thiện', 'nhanvien')
insert into TAIKHOAN values ('minhln', '0', N'Lê Nhật Minh', 'khach_dadangnhap')
insert into TAIKHOAN values ('tiennm', 'tien1234', N'Nguyễn Minh Tiến', 'khach_dadangnhap')
insert into TAIKHOAN values ('quangml', 'quang123', N'Phan Minh Quang', 'khach_dadangnhap')