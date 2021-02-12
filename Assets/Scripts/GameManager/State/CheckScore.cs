using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{
    /// <summary>
    /// This Class Is For be A ScriptableObject CheckScore State
    /// </summary>
    [CreateAssetMenu(menuName = "State/Set/CheckScore", fileName = "CheckScore")]
    public class CheckScore : State<GameManager>, ICheckCalCulated
    {

        #region Main

        public override void OnStartState()
        {
            Debug.Log("CheckScore");
            CheckCalculate(based.Player1score,based.Player2score);
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            base.OnStateExit(manager);
        }

        #endregion

        #region ICheckCalCulated

        public void CheckCalculate(int scoreP1, int scoreP2)
        {
            if(scoreP1 == 6)
            {
                based.EndGame();
            }
            else if(scoreP2 == 6)
            {
                based.EndGame();
            }
            else
            {
                Debug.Log("GameStillRun");
                based.ChangeState();
            }
        }

        #endregion

    }
}