using System;
using UnityEngine;

public class AchievementScrollViewController : MonoBehaviour
{
    [SerializeField] private AchievementSettingsProvider _achievementSettingsProvider;
    [SerializeField] private AchievementPlaque _achievementPrefab;
    [SerializeField] private RectTransform _scrollView;

    private void Awake()
    {
        var plaques = _achievementSettingsProvider.GetSettingsList();

        foreach (var achievementSetting in plaques)
        {
            var plaque = Instantiate(_achievementPrefab, _scrollView);
            plaque.Initialize(achievementSetting);
        }
    }
}