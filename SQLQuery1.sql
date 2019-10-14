

create proc DS_Sach @TenTs nvarchar(100)
as
select *from CuonSach,TuaSach
where CuonSach.MaTS=TuaSach.MaTS
and CuonSach.MaCS not in(
select ChiTietMuon.MaCS from PhieuMuon,ChiTietMuon
where PhieuMuon.MaPM=ChiTietMuon.MaPM
)
and TuaSach.TenTS=@TenTs


DS_Sach N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh'


create proc MuonSach @TenSach nvarchar(100),@MaSach nvarchar(50),@MaDG nvarchar(50),@NgayMuon date,@MaPM nvarchar(50)
as
insert into PhieuMuon(MaDG,MaPM,NgayMuon) 
values(@MaDG,@MaPM,@NgayMuon)
insert into ChiTietMuon(MaPM,MaCS) values(@MaPM,@MaDG)



select *from PhieuMuon order by MaPM desc

MuonSach 'Tôi Thấy Hoa Vàng Trên Cỏ Xanh','TS001_001','13150001','2019-01-01','PM988'

