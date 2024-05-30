using System;
using GameRewardsOfferWall;

namespace GameRewards
{
    public static class GameRewardsOfw
    {
        public static Action<long> OnRewardEarned;

        public static void Init(string appKeyId, string placementId)
        {
            var richieRewardCallbackListener =
                new RichieRewardCallbackListener(OnRewardEarned);
            RichieOfferWall.Init(richieRewardCallbackListener, appKeyId, placementId);
        }

        public static void Show()
        {
            RichieOfferWall.Show();
        }
    }
}