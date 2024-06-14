using System;
using GameRewardsOfferWall;

namespace GameRewardsUnitySDK
{
    public static class GameRewardsOfw
    {
        public static Action<long> OnRewardEarned;

        public static void Init(string appKeyId, string placementId, string userId)
        {
            var gameRewardsCallbackListener =
                new GameRewardsCallbackListener(OnRewardEarned);
            GameRewards.Init(gameRewardsCallbackListener, appKeyId, placementId, userId);
        }

        public static void Show()
        {
            GameRewards.Show();
        }
    }
}