using System;

public class InventoryFullException : InventoryException
{
    public int Capacity;
    public string ItemName;

    public InventoryFullException(int capacity, string itemName)
        : base($"인벤토리가 가득 찼습니다.")
    {
        Capacity = capacity;
        ItemName = itemName;
    }
}

public class ItemNotFoundException : InventoryException
{
    public string ItemName;

    public ItemNotFoundException(string itemName)
        : base($"아이템을 찾을 수 없습니다.")
    {
        ItemName = itemName;
    }
}

public class InventoryException : Exception
{
    public InventoryException(string message)
        : base($"[인벤토리 오류] {message}") { }
}