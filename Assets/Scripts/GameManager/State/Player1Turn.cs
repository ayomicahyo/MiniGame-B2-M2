using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For be A ScriptableObject Player 1 Turn State
    /// </summary>
    [CreateAssetMenu(menuName = "State/Turn/Player1", fileName = "Player1Turn")]
    public class Player1Turn : State<GameManager> , IP1Turn
    {

        #region Main

        public override void OnStartState()
        {
            based.p2.SetActive(false);
            based.p1Copy.SetActive(false);
            based.p2Copy.SetActive(false);

            Debug.Log("Player1Turn");
            based.ChangeState();
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            
            Debug.Log("Player1TurnExit");
            base.OnStateExit(manager);
            
        }

        #endregion

    }
}

