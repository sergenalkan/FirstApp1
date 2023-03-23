--Select
--ANSII standardına göre her yerde çalışır/farklı dblerde
select ContactName Adi, CompanyName SirketAd, City Sehir from Customers

select * from Customers where City='Berlin'

--case insensitive/harf büyük veya küçük
select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10
Select * from Products order by UnitPrice asc    --ascending/artan - default olan asc
Select * from Products where categoryId=1 order by UnitPrice desc   --descending
Select count(*) Adet from Products where CategoryID=2

select CategoryID, count(*) from Products where UnitPrice>20 --group by her grup için bir tablo olur
group by CategoryID having count(*)<10 -- group by dersem select yamımda sadece o şart veya count gibi ifadeler olur

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object  
-- boşuk olduğu için köşeli parantez var, tablo olduğunu belli etmesi

Select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID inner join Orders o
on o.OrderID=od.OrderID
--Solda olup sağda olmayanları da getir - left join
--ürünlerde olup satışı olmayanürün için
Select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null