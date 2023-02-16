using System;
using System.ComponentModel;
using EventDrivenFramework;
using EventDrivenFramework.Core;
using UnityEngine;

namespace _GameFiles.Scripts.Managers._HighLevelManagers
{
    public class GameManager : BaseManager
    {
        [SerializeField] private LevelManager levelManager;
        private GameModel _gameModel;
        public override void Receive(EventArgs eventArgs)
        {
        }

        protected void Awake()
        {
            IMediator mediator = new BaseMediator();
            levelManager.InjectMediator(mediator);
            levelManager.InjectManager(this);
            levelManager.InjectModel(_gameModel);
        }

        public void InjectModel(GameModel gameModel)
        {
            _gameModel = gameModel;
        }
    }
}