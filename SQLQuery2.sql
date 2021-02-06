-- Select 
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'London'

Select * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 order by UnitPrice desc --ascending -descending

Select count(*) Adet from Products where CategoryID= 2 

Select CategoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

-- innter join sadece eşleşen tabloları getirir
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

-- DTO Data Transformation object

-- Sol da olup sağda olmayanları da getir,, (producsta olup order detailde olmayan)
Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID 

Select * from Customers c left join Orders o
on c.CustomerId = o.CustomerID
where o.CustomerID is null