using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;

    private void CreateBall()
    {
        Color randColor = new Color(Random.value, Random.value, Random.value, 1f);

        Vector3 randPos = new Vector3(
            Random.Range(-5f, 5f),
            Random.Range(5f, 10f),
            Random.Range(-5f, 5f)
        );

        GameObject ball = Instantiate(prefab, randPos, Quaternion.identity);

        Material mat = ball.GetComponent<MeshRenderer>().material;
        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", randColor);
        }

        Destroy(ball, 1f);
    }

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            CreateBall();
        }
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= 1f)
        {
            elapsedTime = 0f;
            CreateBall();
        }
    }
}
