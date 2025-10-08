using UnityEngine;

public class Brute : EnemyParent
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    void OnCollisionEnter(Collision collision)
    {
        DamageTaken(collision);
        Debug.Log("Brute hit");
    }
}
