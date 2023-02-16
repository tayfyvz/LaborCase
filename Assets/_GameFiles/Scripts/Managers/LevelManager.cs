using System;
using EventDrivenFramework;
using EventDrivenFramework.Core;

namespace _GameFiles.Scripts.Managers
{
    public class LevelManager : BaseManager
    {
        private GameModel _gameModel;
        public override void Receive(EventArgs eventArgs)
        {
            switch (eventArgs)
            {
                
            }
        }

        public void InjectModel(GameModel gameModel)
        {
            _gameModel = gameModel;
        }
    }
}