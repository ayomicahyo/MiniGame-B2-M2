using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For be A ScriptableObject Player 2 Set State
    /// </summary>
    [CreateAssetMenu(menuName = "State/Set/Player2Set", fileName = "Player2Set")]
    public class Player2Set : State<GameManager> , IP2Turn
    {

        #region Main

        public override void OnStartState()
        {
            Debug.Log("Player2Set");
            based.p2.SetActive(true);
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            Debug.Log("Player2SetExit");
            base.OnStateExit(manager);
            
        }

        public void SetDots()
        {
            based.p2.SetActive(false);
            based.ChangeState();
        }

        #endregion

    }
}

