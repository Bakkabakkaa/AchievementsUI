using UnityEngine;

public class RewardAnimationReceiver : MonoBehaviour
{
    [SerializeField] private StatusBarManager statusBar;

    public void OnGoldAnimationEnd()
    {
        statusBar.UpdateGolds();
    }

    public void OnGemsAnimationEnd()
    {
        statusBar.UpdateGems();
    }
}