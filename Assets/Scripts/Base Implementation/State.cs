using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class is for be a base state of other Game State
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class State<T> : ScriptableObject, IState where T : IGameManager
    {

        #region Variable

        /// <summary>
        /// Generic type to get GameManager
        /// </summary>
        public T based = default;

        #endregion

        #region Main

        public virtual void OnStartState()
        {
            
        }

        public virtual void OnStateExit(IGameManager manager)
        {
           
        }

        public void OnStateInit(IGameManager manager)
        {
            this.based = (T)manager;
            OnStartState();
        }

        #endregion

    }
}

