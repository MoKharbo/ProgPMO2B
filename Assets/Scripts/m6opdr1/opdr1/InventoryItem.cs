using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public string _items { get; protected set; }
}

public class KeyCard : InventoryItem
{
   public KeyCard()
    {
        _items = "KeyCard";
    }
}

public class Medipacks : InventoryItem
{
    public Medipacks()
    {
        _items = "Medipacks";
    }
}

public class Guns : InventoryItem
{   
    public Guns()
    {
        _items = "Guns";
    }
}
