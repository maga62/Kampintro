--Select 

--Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers 

--Select * from Customers where City='Berlin'

select * from Products
--select * from Products where CategoryID=1 or CategoryID=3
select * from Products where CategoryID=1 and UnitPrice>=8

select * from Products order by CategoryID,ProductName

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products

select count(*) Adet from Products where CategoryID=1



--hangi categoride kaç farklı fiyatı 20 den az olan urunumuz var?

select categoryID, count(*) azolanlar from Products where UnitPrice>20 group by CategoryID having count(*)<10

-- Join demek tabloları birleştirmek demek(prodocut ve Categoriler) tabloları birleştime ibi
-- *  demek heosi demek
-- inner join sadece tabloda eşleşenleri getirir
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryID
from Products inner join Categories on Products.CategoryID=Categories.CategoryID 
where products.UnitPrice<20 

--hic satıs yapamadığımız ürünler hangileri (left join ) solda olupda sagda olmayanları getir yani producta olub siparişte olmayanlaridan 
select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
--2 den fazla tabloyu Join yapmak istersek kodun devamına 
inner join Orders o 
on o.OrderID=od.OrderID


-- solda olupda siparişlerde yani orderde olmayanlarıdda getirir
-- sana özel  indirimleri göndeririken seni listeden bu sorgu ile buluyoor 
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null -- bu sorgunun sonunda bizden hiç ürün almıyanları listeledi 