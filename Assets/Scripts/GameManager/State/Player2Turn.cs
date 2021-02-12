using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For be A ScriptableObject Player 2 Turn State
    /// </summary>
    [CreateAssetMenu(menuName = "State/Turn/Player2", fileName = "Player2Turn")]
    public class Player2Turn : State<GameManager>
    {

        #region Main

        public override void OnStartState()
        {
            Debug.Log("Player2Turn");
            based.ChangeState();
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            Debug.Log("Player2TurnExit");
            base.OnStateExit(manager);
            
        }

        #endregion

    }
}


