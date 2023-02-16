using System;
using EventDrivenFramework;
using EventDrivenFramework.Core;
using UnityEngine;

namespace _GameFiles.Scripts.Managers._HighLevelManagers
{
    public class UIManager : BaseManager
    {
        [SerializeField] private GameViewPresenter gameViewPresenter;
    
        private GameModel _gameModel;
        public override void Receive(EventArgs eventArgs)
        {
       
        }
        protected void Awake()
        {
            gameViewPresenter.InjectManager(this);
        }

        public void InjectModel(GameModel gameModel)
        {
            this._gameModel = gameModel;
        }

    }
}