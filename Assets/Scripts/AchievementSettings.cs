using UnityEngine;

[CreateAssetMenu(fileName = "AchievementSettings", menuName = "ScriptableObjects/AchievementSettings", order = 50)]
public class AchievementSettings : ScriptableObject
{
    [field: SerializeField] public Sprite AchievementIcon { get; private set; }
    [field:SerializeField] public Sprite AwardIcon { get; private set; }
    [field:SerializeField] public int AmountOfReward { get; private set; }
    [field:SerializeField] public string Title { get; private set; }
    [field:SerializeField] public string Description { get; private set; }
    [field:SerializeField] public AchievementType Type { get; private set; }
}