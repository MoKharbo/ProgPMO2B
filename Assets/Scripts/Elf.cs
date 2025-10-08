using UnityEngine;

public class Elf : EnemyParent
{
    private bool isVisible = true;
    private float timer = 1f;
    Renderer renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        ToggleVisibility();
    }

    void OnCollisionEnter(Collision collision)
    {
        DamageTaken(collision);
    }

    private void ToggleVisibility()
    {
        timer -= Time.deltaTime;
        if (!isVisible && timer <= 0f)
        {
            renderer.enabled = false;
            isVisible = true;
            timer = 0.5f;
        }
        else if (isVisible && timer <= 0f)
        {
            renderer.enabled = true;
            isVisible = false;
            timer = 3f;
        }
    }
}
