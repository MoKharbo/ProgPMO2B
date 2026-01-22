using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI coinText;

    private void OnEnable()
    {
        CoinsManager.scoreUpdate += UpdateUI;
    }

    private void OnDisable()
    {
        CoinsManager.scoreUpdate -= UpdateUI;
    }

    private void UpdateUI(int newScore)
    {
        coinText.text = "Coins: " + newScore;
    }
}
