using UnityEngine;
using System;

public class CoinsManager : MonoBehaviour
{
    private static int score;
    public static Action<int> scoreUpdate;

    public static void AddScore(int amount)
    {
        score += amount;
        scoreUpdate?.Invoke(score);
    }
}
