using UnityEngine;

public class DamageTrap : Collectable
{
    public override void OnCollect()
    {
        Debug.Log("Damage Trap Activated");
        Destroy(gameObject);
    }
}
