using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHOP3
{
    class sqltestclass
    {
//        --select* from Products where CategoryID=1 or UnitPrice>=10
//--select* from Products order by CategoryID, ProductName
//--select* from Products order by UnitPrice desc
//--select* from Products where CategoryID=1 order by UnitPrice desc
//--select count(*) sayı from Products where CategoryID=2
//--select CategoryID, count(*) from Products group by CategoryID
//--select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10
//--SELECT* from Products inner join Categories on Products.CategoryID=Categories.CategoryID
//--SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID= Categories.CategoryID
//--SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID= Categories.CategoryID where Products.UnitPrice>10
//--select* from Categories
//--select* from [Order Details]
//--select* from Products p inner join [Order Details] od on p.ProductID= od.ProductID
//--iiner sadece birleşenleri getiriyor ama left solda olup sağ tableda olmayanlarıda getirir.right da aynı mantık sağa getirir

//--select count (*) musterı from Customers co left join Orders o on co.CustomerID= o.CustomerID
//--select* from Customers co left join Orders o on co.CustomerID= o.CustomerID
//--select* from Customers
//--select count (*) from Orders
//--select count (*)[toplam sıparıs] from Orders
//--select* from Customers co left join Orders o on co.CustomerID= o.CustomerID where o.CustomerID is null
//--select* from Customers co left join Orders o on co.CustomerID= o.CustomerID

//--birdençok tablo birleştirme
//--select* from Products p inner join [Order Details] od on p.ProductID= od.ProductID inner join Orders o on o.OrderID= od.OrderID


//select p.ProductName as Urunler, sum (od.Quantity* od.UnitPrice) Total from Products p
//inner join[Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.OrderID=od.OrderID
//group by p.ProductName order by p.ProductName

//SELECT p.ProductName urunAdi, SUM(od.Quantity* od.UnitPrice) kazanc FROM Products p
//INNER JOIN[Order Details] od ON od.ProductID = p.ProductID
//GROUP BY p.ProductName order by p.ProductName

    }
}
