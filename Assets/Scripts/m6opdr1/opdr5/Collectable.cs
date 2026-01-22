using System;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    public abstract void OnCollect();
    public static Action<Collectable> collectableCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollect();
            collectableCollected?.Invoke(this);
        }
    }
}