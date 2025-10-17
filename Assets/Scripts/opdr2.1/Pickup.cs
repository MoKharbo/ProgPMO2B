using System;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static Action<float> Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Score?.Invoke(50);
        }
    }
}
