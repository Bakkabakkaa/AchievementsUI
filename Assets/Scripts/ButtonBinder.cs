using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBinder : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AchievementPlaque _plaque;
    private AchievementAnimator _animator;

    private void Start()
    {
        _animator = FindFirstObjectByType<AchievementAnimator>();
        _button.onClick.AddListener(() => 
        {
            _animator.ButtonClicked(_plaque.GetSettings(), _plaque);
        });
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(() => 
        {
            _animator.ButtonClicked(_plaque.GetSettings(), _plaque);
        });
    }
}