using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCore.Entities.DO
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        public int ProductId { get; set; }

        public int InventoryQty { get; set; }
    }
}
