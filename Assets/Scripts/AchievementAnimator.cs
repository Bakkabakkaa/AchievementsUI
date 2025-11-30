using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AchievementAnimator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Image _image;
    
    [SerializeField] private Sprite _dunkSprite;
    [SerializeField] private Sprite _hummerSprite;
    [SerializeField] private Animator _goldAnimator;
    [SerializeField] private Animator _gemAnimator;

    private static readonly int ShowCard = Animator.StringToHash("showCard");
    private static readonly int Hide = Animator.StringToHash("hideCard");
    private static readonly int Gold = Animator.StringToHash("gold");
    private static readonly int Ranks = Animator.StringToHash("ranks");
    private Animator _cardAnimator;


    private void Awake()
    {
        _cardAnimator = GetComponent<Animator>();
    }

    public void ButtonClicked(AchievementSettings settings, AchievementPlaque achievementPlaque)
    {
        if (settings.Type == AchievementType.Golds)
        {
            _goldAnimator.SetTrigger(Gold);
        }

        if (settings.Type == AchievementType.Ranks)
        {
            _gemAnimator.SetTrigger(Ranks);
        }

        if (settings.Type == AchievementType.LevelUp)
        {
            _cardAnimator.SetTrigger(ShowCard);
            _name.text = "Dunk";
            _description.text = "New Character!";
            _image.sprite = _dunkSprite;
        }

        if (settings.Type == AchievementType.Technician)
        {
            _cardAnimator.SetTrigger(ShowCard);
            _name.text = "Hummer";
            _description.text = "New Inventory!";
            _image.sprite = _hummerSprite;
        }

        achievementPlaque.MarkAsClaimed();
    }

    public void HideCard()
    {
        _cardAnimator.SetTrigger(Hide);
    }
}