--Select
--ANSII
Select ContactName,CompanyName,City from Customers  --Müşterilerin istenilen verilerini getir(ContactName...vb.)

Select * from Customers where City = 'London' --Şehri London olan Bütün müşterileri getir.

Select * from Products where CategoryID=1 or CategoryID=3  -- Kategori Id 1 olanları getir.

Select * from Products order by UnitPrice asc -- ascending , artan 
Select * from Products where CategoryID=1 order by UnitPrice desc   --descending , azalan

Select COUNT (*)Adet  from Products where CategoryID=2  --Tüm satırları say
Select COUNT (*) from Products where CategoryID=2 

select count(*) from products group by CategoryID
select CategoryId, count(*) from products group by CategoryID --Kategorilerdeki ürün sayısı

select CategoryId, count(*) from products group by CategoryID having count(*)<10 --sayısı 10'dan az ürün sayılar

select CategoryId, count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10 --Datayı filtrelemek için.

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
-- on = koşul,durumunda

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID  --inner join 2 datada eşleşenleri getirir.
where Products.UnitPrice <10 

select * from Products p inner join [Order Details] od  --tablo ismi alsın diye köşeli parantez  kullandık.
on p.ProductID = od.ProductID

select * from Products p left join [Order Details] od  --solda olup sağda olmayan ürünleri getir.
on p.ProductID = od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null


--DTO Data Transformation Object