using System;
using TMPro;
using UnityEngine;

public class StatusBarManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _golds;
    [SerializeField] private TextMeshProUGUI _gems;

    public void UpdateGolds()
    {
        _golds.text = (Convert.ToInt32(_golds.text) + 500).ToString();
    }

    public void UpdateGems()
    {
        _gems.text = (Convert.ToInt32(_gems.text) + 5).ToString();
    }
}