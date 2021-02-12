using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;
namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For be A ScriptableObject Game Start State
    /// </summary>
    [CreateAssetMenu(menuName = "State/Turn/StartGame", fileName = "StartGame")]
    public class StartGame : State<GameManager>, IStartGame
    {

        #region Main

        public override void OnStartState()
        {
            Debug.Log("GameStart");
            based.ChangeState();
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            base.OnStateExit(manager);

        }

        public void SetCondition()
        { 
            
        }

        #endregion
    }
}

