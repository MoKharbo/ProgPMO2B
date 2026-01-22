using UnityEngine;

public class JoshuaVisser : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Joshua Visser";
        health = 150f;
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        health += 5f; // Joshua herstelt 5 HP bij elke aanval door zijn grote mes want het heeft vamprische krachten blijkbaar 😭😭😭
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log("Joshua Visser attackt met zijn grote mes!");
    }
}
