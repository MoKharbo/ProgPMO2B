using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotateSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Move = Input.GetAxis("Vertical");
        float Rotate = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Move * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Rotate * rotateSpeed * Time.deltaTime);
    }
}
