create trigger yedek
on tblk�taplar
after delete
as
declare @kitapad varchar(50) 
declare @kitapyazar varchar(50)

select @kitapad=Ad,@kitapyazar=yazar from deleted
insert into TBLKITAPYEDEK(ad,yazar) values (@kitapad,@kitapyazar)

