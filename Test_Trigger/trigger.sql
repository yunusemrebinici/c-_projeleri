create trigger yedek2
on tblkýtaplar
after delete
as
declare @kitapadý varchar(50)
declare @kitapyazar varchar(50)
declare @kitapsayfa char(3)
declare @yayýnevi varchar(50)
declare @Tur varchar(50)

select @kitapadý=AD,@kitapyazar=yazar,@kitapsayfa=sayfa, @yayýnevi=yayýnevý,@Tur=tur from deleted
insert into tblkýtapyedek (ad,yazar,sayfa,YAYINEVÝ,TUR) values (@kitapadý,@kitapyazar,@kitapsayfa,@yayýnevi,@Tur)