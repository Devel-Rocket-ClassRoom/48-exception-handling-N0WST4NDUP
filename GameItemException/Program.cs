using System;
using System.Collections.Generic;

Console.WriteLine("=== 인벤토리 테스트 ===");

Inventory inventory = new Inventory(3);

try
{
    inventory.AddItem("검");
    inventory.AddItem("방패");
    inventory.AddItem("포션");
    inventory.AddItem("활");
}
catch (InventoryFullException ife)
{
    Console.WriteLine($"{ife.Message} (용량: {ife.Capacity}, 아이템: {ife.ItemName})");
}

inventory.ShowItems();

try
{
    inventory.RemoveItem("포션");
    inventory.RemoveItem("도끼");
}
catch (ItemNotFoundException ife)
{
    Console.WriteLine($"{ife.Message} (아이템: {ife.ItemName})");
}

inventory.ShowItems();