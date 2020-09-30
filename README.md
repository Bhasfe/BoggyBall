# BoggyBall

## Description
Boggy Ball is a simple mobile game developed by using Unity (2018.3.1f1). It has been published on GooglePlay (2018-2019).

## Contributors
- [Bhasfe](https://github.com/bhasfe)
- [braty-xd](https://github.com/braty-xd)

## In-game Screenshots

![](https://github.com/Bhasfe/BoggyBall/blob/master/Images/ss1.png)
![](https://github.com/Bhasfe/BoggyBall/blob/master/Images/ss2.png)
![](https://github.com/Bhasfe/BoggyBall/blob/master/Images/ss3.png)
![](https://github.com/Bhasfe/BoggyBall/blob/master/Images/ss4.png)
![](https://github.com/Bhasfe/BoggyBall/blob/master/Images/ss5.png)
![](https://github.com/Bhasfe/BoggyBall/blob/master/Images/ss6.png)

## Details

To activate GooglePlay services, you need to replace **GPGSID** with your **GPGSId**

BoggyBall\Assets\GPGSIds.cs
```
public static class GPGSIds
{
        public const string leaderboard_testscores = "GPGSID"; // <GPGSID>
        public const string achievement_incremental_achievement = "GPGSID"; // <GPGSID>
        public const string achievement_standard_achievement = "GPGSID"; // <GPGSID>

}
```

BoggyBall\Assets\LeaderBoard.cs
```
public static class LeaderBoard
{
        public const string leaderboard_best_scores = "GPGSID"; // <GPGSID>

}
```
