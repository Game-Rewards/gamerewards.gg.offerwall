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

            GameRewardsOfferWall.OnRewardEarned += OnRewardEarned;
            GameRewardsOfferWall.Init(appKeyId, placementId);
        }

        public void ShowOfferWall()
        {
            GameRewardsOfferWall.Show();
        }

        private void OnRewardEarned(int amount)
        {
            Debug.Log($"[GameRewards.gg] OnRewardEarned amount: {amount}");
        }
    }
}