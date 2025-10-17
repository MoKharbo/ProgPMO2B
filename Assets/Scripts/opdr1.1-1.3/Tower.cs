using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnTower();
        }    
    }

    private void SpawnTower()
    {
        Vector3 ranPos = new Vector3(
            Random.Range(-5f, 5f),
            0f,
            Random.Range(-5f, 5f)
        );
        towerPrefab.transform.localScale = new Vector3(Random.Range(0.5f, 2f), Random.Range(1f, 5f), Random.Range(0.5f, 2f));
        Instantiate(towerPrefab, ranPos, Quaternion.identity);
    }
}
