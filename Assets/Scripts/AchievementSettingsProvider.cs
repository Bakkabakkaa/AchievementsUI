using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AchievementSettingsProvider", menuName = "ScriptableObjects/AchievementSettingsProvider", order = 50)]
public class AchievementSettingsProvider : ScriptableObject
{
    [SerializeField] private List<AchievementSettings> _achievementSettings = new List<AchievementSettings>();

    public List<AchievementSettings> GetSettingsList()
    {
        return _achievementSettings;
    }
}