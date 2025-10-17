using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI scoreText;
    private float totalScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        Pickup.Score += UpdateScore;
    }

    private void OnDisable()
    {
        Pickup.Score -= UpdateScore;
    }

    private void UpdateScore(float scoreadd)
    {
        totalScore += scoreadd;
        scoreText.text = "Score: " + totalScore;
    }
}
