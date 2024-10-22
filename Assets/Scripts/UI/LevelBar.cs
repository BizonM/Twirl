using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class LevelBar : MonoBehaviour
{
    [SerializeField] private PlayerStatsScriptableObject playerStats;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private float levelValue;
    [SerializeField] private Image levelImage;
    private void Start()
    {
        GameEvents.Current.OnUpdateExperienceBar += UpdateExperienceBar;
        UpdateExperienceBar();
    }

    private void UpdateExperienceBar()
    {
        levelValue = playerStats.CurrentExp / playerStats.MaxExp;
        levelImage.fillAmount = levelValue;
        levelText.text = playerStats.Level.ToString();
    }
}
