﻿namespace OrderProcessingLib;
public class Order
{
    public int OrderId{get;set;}
    public DateTime OrderDate{get;set;}
    public string Customer{get;set;}
    public double TotalAmount{get;set;}
    public string Status{get;set;}
}
