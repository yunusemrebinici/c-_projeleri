create trigger yedek2
on tblk�taplar
after delete
as
declare @kitapad� varchar(50)
declare @kitapyazar varchar(50)
declare @kitapsayfa char(3)
declare @yay�nevi varchar(50)
declare @Tur varchar(50)

select @kitapad�=AD,@kitapyazar=yazar,@kitapsayfa=sayfa, @yay�nevi=yay�nev�,@Tur=tur from deleted
insert into tblk�tapyedek (ad,yazar,sayfa,YAYINEV�,TUR) values (@kitapad�,@kitapyazar,@kitapsayfa,@yay�nevi,@Tur)