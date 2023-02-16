using System;
using DG.Tweening;
using EventDrivenFramework.Core;
using UnityEngine;

// using ElephantSDK;
// using GameAnalyticsSDK;
namespace _GameFiles.Scripts.Managers._HighLevelManagers
{
    public class AppManager : BaseManager
    {
        public override void Receive(EventArgs eventArgs)
        {
        }

        protected void Awake()
        {
            DOTween.SetTweensCapacity(1000, 1000);
            Application.targetFrameRate = 60;
        }
        /*protected override void Start()
        {
            base.Start();
            GameAnalytics.Initialize(); 
            LevelStartGA(PlayerPrefs.GetInt("Level"));
        }
        public void LevelCompleteGA(int level)
        {
            GameAnalytics.NewDesignEvent("LevelComplete:Level" + level.ToString("D5"));
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Level " + level.ToString("D5"));
            // Elephant.LevelCompleted(level);
    
        }
        public void LevelStartGA(int level)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Level " + level.ToString("D5"));
            // Elephant.LevelStarted(level);
        }
        public void LevelFailGA(int level)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, "Level " + level.ToString("D5"));
            //Elephant.LevelFailed(level);
        }*/
    }
}