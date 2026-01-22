using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour 
{
    [SerializeField] private int _gunCount = 1;
    [SerializeField] private int _medipackCount = 1;
    [SerializeField] private int _keyCardCount = 1;
    private List<InventoryItem> _inventory = new List<InventoryItem>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            PickupGun();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            PickupMedipack();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            PickupKeyCard();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            DropGun();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            DropMedipacks();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            DropKeyCard();
        }
    }
    public void PickupGun()
    {
        if (_gunCount > 0)
        {
            _gunCount--;
            _inventory.Add(new Guns());
            Debug.Log("Picked up a Gun.");
            ShowInventory();
        }
    }

    public void PickupMedipack()
    {
        if (_medipackCount > 0)
        {
            _medipackCount--;
            _inventory.Add(new Medipacks());
            Debug.Log("Picked up a Medipack.");
            ShowInventory();
        }
    }

    public void PickupKeyCard()
    {
        if (_keyCardCount > 0)
        {
            _keyCardCount--;
            _inventory.Add(new KeyCard());
            Debug.Log("Picked up a KeyCard.");
            ShowInventory();
        }
    }

    public void DropGun()
    {
        InventoryItem gun = _inventory.Find(item => item is Guns);
        if (gun != null)
        {
            _inventory.Remove(gun);
            _gunCount++;
            Debug.Log("Dropped a Gun.");
            ShowInventory();
        }
    }
    
    public void DropMedipacks()
    {
        InventoryItem medipack = _inventory.Find(item => item is Medipacks);
        if (medipack != null)
        {
            _inventory.Remove(medipack);
            _medipackCount++;
            Debug.Log("Dropped a Medipack.");
            ShowInventory();
        }
    }

    public void DropKeyCard()
    {
        InventoryItem keyCard = _inventory.Find(item => item is KeyCard);
        if (keyCard != null)
        {
            _inventory.Remove(keyCard);
            _keyCardCount++;
            Debug.Log("Dropped a KeyCard.");
            ShowInventory();
        }
    }

    private void ShowInventory()
    {

        int invMedipacks = 0;
        int invGuns = 0;
        int invKeycards = 0;

        foreach (InventoryItem item in _inventory)
        {
            if (item is Medipacks) invMedipacks++;
            if (item is Guns) invGuns++;
            if (item is KeyCard) invKeycards++;
        }

        Debug.Log("items in de wereld:");
        Debug.Log($"medipacks : {_medipackCount}");
        Debug.Log($"guns : {_gunCount}");
        Debug.Log($"keycards : {_keyCardCount}");
        Debug.Log("Items in inventory:");
        Debug.Log($"medipacks : {invMedipacks}");
        Debug.Log($"guns : {invGuns}");
        Debug.Log($"keycards : {invKeycards}");
    }
}

