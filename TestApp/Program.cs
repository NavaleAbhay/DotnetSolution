using CatalogLib;
using CRMLib;
using OrderProcessingLib;

Product p1=new Product();
p1.Id=12;
p1.Title="Samsung guru";
p1.Description="The cheepest mobile phone";
p1.UnitPrice=999;
p1.StockAvailable=20000;
p1.ImageUrl="https://www.vivo.com/in/products/x80pro?_ga=2.139308912.2108742531.1670485026-1397980863.1670485026";

Console.WriteLine(p1.Id+"___"+p1.Title+"___"+p1.Description+"___"+p1.UnitPrice+"___"+p1.StockAvailable+"___"+p1.ImageUrl);

Customer c1=new Customer();
Customer c2=new Customer(2,"Sahil","Mankar",9878767869,"sahilmankar12@gmail.com");
Console.WriteLine(c1);
Console.WriteLine(c2);

Order o1=new Order();
o1.OrderId=11;
o1.OrderDate=new DateTime(2022,05,09);
o1.Customer="Microsoft";
o1.TotalAmount=20000;
o1.Status="shipped";
Console.WriteLine(o1.OrderId+"***"+o1.OrderDate+"***"+o1.Customer+"***"+o1.TotalAmount+"***"+o1.Status);

