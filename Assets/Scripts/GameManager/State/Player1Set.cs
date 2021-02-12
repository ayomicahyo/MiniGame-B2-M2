using StickInk.Interface;
using UnityEngine;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For be A ScriptableObject Player 1 Set State
    /// </summary>
    [CreateAssetMenu(menuName = "State/Set/Player1Set", fileName = "Player1Set")]
    public class Player1Set : State<GameManager>
    {

        #region Main

        public override void OnStartState()
        {
            Debug.Log("Player1Set");
            based.p1.SetActive(true);
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            Debug.Log("Player1SetExit");
            base.OnStateExit(manager);
            based.p1.SetActive(false);
        }

        #endregion

    }
}

