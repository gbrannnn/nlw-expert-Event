﻿using RocketseatAuction.API.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketseatAuction.API.Entities;

[Table("Items")]
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public Condition Condition { get; set; }
    public decimal BasePrice { get; set; }
    public int AuctionId { get; set; }
}
