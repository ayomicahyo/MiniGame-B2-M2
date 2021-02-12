using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For be A ScriptableObject EndGame State
    /// </summary>
    /// 
    [CreateAssetMenu(menuName = "State/Set/EndGame", fileName = "Endgame")]
    public class EndGame : State<GameManager>, IEndTurn
    {

        #region Main

        public override void OnStartState()
        {
            Debug.Log("GameEnd");
            EndCondition();
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            base.OnStateExit(manager);
        }

        #endregion

        #region IEndTurn

        public void EndCondition()
        {
            based.gameEndPanel.SetActive(true);

            if (based.Player1score == 6 && based.Player2score == 6)
            {
                based.endPanel.text = "Draw";
            }
            else if (based.Player1score == 6)
            {
                based.endPanel.text = "Player 1 WIN";
            }
            else if (based.Player2score == 6)
            {
                based.endPanel.text = "Player 2 WIN";
            }
        }

        #endregion

    }
}
