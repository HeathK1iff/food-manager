﻿namespace FoodSupplier.WebAPI.Models;

public class PriceModel
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ShopId { get; set; }
    public DateTimeOffset Date { get; set; }
    public decimal Price { get; set; }
}