using UnityEngine;

namespace GameRewards
{
    public class OfferWallController : MonoBehaviour
    {
        [SerializeField] private string appKeyId;
        [SerializeField] private string placementId;

        public void Init()
        {
            if (string.IsNullOrEmpty(appKeyId) || string.IsNullOrEmpty(placementId))
            {
                Debug.LogError("[GameRewards.gg] Initialize failed, appKeyId or placementId is empty.");
                return;
            }

            GameRewardsOfw.OnRewardEarned += OnRewardEarned;
            GameRewardsOfw.Init(appKeyId, placementId);
        }

        public void ShowOfferWall()
        {
            GameRewardsOfw.Show();
        }

        private void OnRewardEarned(int amount)
        {
            Debug.Log($"[GameRewards.gg] OnRewardEarned amount: {amount}");
        }
    }
}