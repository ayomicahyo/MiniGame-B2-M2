using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For be A ScriptableObject P2Attack State
    /// </summary>
    [CreateAssetMenu(menuName = "State/Set/Player2Attack", fileName = "Player2Attack")]
    public class P2Attack : State<GameManager>, IAttackP2
    {

        #region Main

        public override void OnStartState()
        {
            Debug.Log("Player2Attack");
            Attack();
            based.StartCoroutine(WaitToNextState(2));
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            Debug.Log("Player2AttackExit");
            base.OnStateExit(manager);
            
        }

        private IEnumerator WaitToNextState(float time)
        {
            yield return new WaitForSeconds(time);
            based.ChangeState();
        }

        #endregion

        #region IAttack2

        public void Attack()
        {
            Debug.Log("Make Copying of Dots");
            based.p2Copy.SetActive(true);
            based.p2Copy.transform.position = new Vector2(based.p2.transform.position.x * -1, based.p2.transform.position.y );
        }

        #endregion

    }
}

