using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class CollectibleManager : MonoBehaviour
{
    
    private List<Collectable> pickups = new List<Collectable>();

    private void Start()
    {
        var collectables = FindObjectsOfType<Collectable>();
        pickups.AddRange(collectables);
        Debug.Log(collectables.Length + " found");
    }

    private void OnEnable()
    {
        Collectable.collectableCollected += Collecting;
    }

    private void OnDisable()
    {
        Collectable.collectableCollected -= Collecting;
    }

    public void Collecting(Collectable item)
    {

        if (pickups.Contains(item))
        {
            pickups.Remove(item);
            Debug.Log("remaining: " + pickups.Count);
        }
    }
}
