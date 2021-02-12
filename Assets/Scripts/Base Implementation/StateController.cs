using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{
    /// <summary>
    /// To Handle A GameManager State
    /// </summary>
    public class StateController : MonoBehaviour, IGameManager
    {
        #region Variable

        /// <summary>
        /// For Get A State Active
        /// </summary>
        [SerializeField]
        private static string stateActive = string.Empty;

        /// <summary>
        /// For Get and Set A Player 1 Score
        /// </summary>
        [SerializeField]
        protected int player1Score = 0;

        /// <summary>
        /// For Get and Set A Player 2 Score
        /// </summary>
        [SerializeField]
        protected int player2Score = 0;

        /// <summary>
        /// Array to collect a state Scriptable
        /// </summary>
        [SerializeField]
        private ScriptableObject[] state = null;

        /// <summary>
        /// Dictionary for get a state
        /// </summary>
        private Dictionary<string, IState> stateName = new Dictionary<string, IState>();

        #endregion

        #region Property

        public static string StateActive { get { return stateActive; } set { } }
        public int Player1score { get { return player1Score; } set { } }
        public int Player2score { get { return player2Score; } set { } }

        public ScriptableObject[] State
        {
            get
            {
                return state;
            }
            set
            {
            }
        }

        protected virtual void Awake()
        {
            stateActive = state[0].GetType().Name;

            Initialize();

            stateName[stateActive].OnStateInit(this);
        }
        public virtual void EndGame()
        {
            stateName["EndGame"].OnStateInit(this);
        }

        public virtual void ChangeState()
        {
            stateName[stateActive].OnStateExit(this);

            if(stateActive == state[0].GetType().Name)
            {
                stateActive = state[1].GetType().Name;
            }
            else
            {
                for (int j = 1; j < state.Length - 1; j++)
                {
                    if (stateActive == state[j].GetType().Name)
                    {
                        if (j != state.Length - 2)
                        {
                            stateActive = state[j + 1].GetType().Name;
                        }
                        else
                        {
                            stateActive = state[1].GetType().Name;
                        }
                        break;

                    }
                }
            }
            

            stateName[stateActive].OnStateInit(this);
        }

        public virtual void Initialize()
        {
            for (int i = 0; i < state.Length; i++)
            {
                stateName.Add(state[i].GetType().Name, (IState)state[i]);
            }
        }

        #endregion
    }
}

