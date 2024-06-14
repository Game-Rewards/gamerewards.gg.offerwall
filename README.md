# Game Rewards OfferWall

## Overview
The `OfferWallController` class is designed to manage and interact with the Game Rewards OfferWall system. It initializes the offer wall, displays it, and handles the event when a reward is earned.

## Integration

**Required min Unity version: 2022.3 (LTS)**

You can integrate the offerwall SDK by either pulling it from the GitHub repository using the following link in your `manifest.json` file:

```json
"gamerewards.gg.offerwall": "git@github.com:megafortunagames/gamerewards.gg.offerwall.git#v1.0.25"
```

or by downloading the Unity package from the following link:

[Unity Package](https://github.com/megafortunagames/gamerewards.gg.offerwall/releases)


## ProGuard Configuration

To ensure proper functioning of the gg.gamerewards SDK, please add the following lines to your ProGuard configuration file:

```proguard
-keep class gg.gamerewards.** { *; }
-keep class gg.gamerewards.GameRewards { *; }
-keep class gg.gamerewards.builder.** { *; }
-keep class gg.gamerewards.interfaces.GameRewardsInitializationListener { *; }
-keep class gg.gamerewards.GameRewards$Options { *; }
-keep class gg.gamerewards.interfaces.GameRewardsRewardCallback { *; }
-keep class gg.gamerewards.data.model.response.Claim { *; }
-keepnames class androidx.navigation.fragment.NavHostFragment
-keep class * extends androidx.fragment.app.Fragment{}
-keepclassmembers,allowobfuscation class * {
    @com.google.gson.annotations.SerializedName <fields>;
}
-keepnames class * extends android.os.Parcelable
-keepnames class * extends java.io.Serializable
-keep class gg.gamerewards.data.model.** { *; }
```

## Class: OfferWallController

### Methods:

1. **Init()**
    - **Description:** Initializes the offer wall and sets up the event listener for reward earnings.
    - **Usage:** Call this method to initialize the offer wall when the game starts or when the offer wall needs to be prepared.
    - **Implementation:**
      ```csharp
      public void Init()
      {
          GameRewardsOfferWall.OnRewardEarned += OnRewardEarned;
          GameRewardsOfferWall.Init();
      }
      ```

2. **ShowOfferWall()**
    - **Description:** Displays the offer wall to the user.
    - **Usage:** Call this method to show the offer wall when the user chooses to view available offers.
    - **Implementation:**
      ```csharp
      public void ShowOfferWall()
      {
          GameRewardsOfferWall.Show();
      }
      ```

3. **OnRewardEarned(int amount)**
    - **Description:** Handles the event when a reward is earned through the offer wall.
    - **Parameters:**
      - `amount` (int): The amount of the reward earned.
    - **Usage:** This method is automatically called when the `OnRewardEarned` event is triggered by the `GameRewardsOfferWall`.
    - **Implementation:**
      ```csharp
      private void OnRewardEarned(int amount)
      {
          Debug.Log($"[OfferWallController] OnRewardEarned amount: {amount}");
      }
      ```

## Example Usage:

```csharp
public class OfferWallController : MonoBehaviour
{
    [SerializeField] private string userId;
    [SerializeField] private string appKeyId;
    [SerializeField] private string placementId;


    public void Init()
    {
        GameRewardsOfferWall.OnRewardEarned += OnRewardEarned;
        GameRewardsOfferWall.Init(appKeyId, placementId, userId);
    }

    public void ShowOfferWall()
    {
        GameRewardsOfferWall.Show();
    }

    private void OnRewardEarned(int amount)
    {
        Debug.Log($"[OfferWallController] OnRewardEarned amount: {amount}");
    }
}
```
