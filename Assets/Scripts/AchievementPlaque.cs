using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievementPlaque : MonoBehaviour
{
    [SerializeField] private Image _achievementIcon; 
    [SerializeField] private Image _awardIcon;
    [SerializeField] private Image _doneMark;
    [SerializeField] private Image _background;
    [SerializeField] private TextMeshProUGUI _amountOfReward;
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Button _claimButton;

    private AchievementSettings _settings;

    public void Initialize(AchievementSettings achievementSettings)
    {
        _achievementIcon.sprite = achievementSettings.AchievementIcon;
        _awardIcon.sprite = achievementSettings.AwardIcon;
        _amountOfReward.text = achievementSettings.AmountOfReward.ToString();
        _title.text = achievementSettings.Title;
        _description.text = achievementSettings.Description;
        _settings = achievementSettings;

        switch (achievementSettings.Type)
        {
            case AchievementType.LevelUp or AchievementType.Technician:
                _amountOfReward.gameObject.SetActive(false);
                SetupIcon();
                break;
        }
    }

    private void SetupIcon()
    {
        var rect = _awardIcon.rectTransform;

        rect.localScale = new Vector3(1, 1, 1);
        rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, 0f);
    }

    public AchievementSettings GetSettings()
    {
        return _settings;
    }

    public void MarkAsClaimed()
    {
        _claimButton.gameObject.SetActive(false);
        _doneMark.gameObject.SetActive(true);
        _background.gameObject.SetActive(true);
    }
}