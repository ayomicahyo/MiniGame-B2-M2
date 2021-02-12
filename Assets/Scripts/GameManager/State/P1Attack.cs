using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For be A ScriptableObject P1Attack State
    /// </summary>
    [CreateAssetMenu(menuName = "State/Set/Player1Attack", fileName = "Player1Attack")]
    public class P1Attack : State<GameManager>, IAttackP1
    {

        #region Main

        public override void OnStartState()
        {
            Debug.Log("Player1Attack");
            Attack();
            based.ChangeState();
            base.OnStartState();
        }

        public override void OnStateExit(IGameManager manager)
        {
            Debug.Log("Player1AttackExit");
            base.OnStateExit(manager);
            
        }

        private IEnumerator Wait()
        {
            yield return new WaitForSeconds(2);
            based.p1Copy.SetActive(true);
            based.p1Copy.transform.position = new Vector2(based.p1.transform.position.x * -1, based.p1.transform.position.y);
            
        }

        #endregion

        #region IAttackP1

        public void Attack()
        {
            Debug.Log("Make Copying of Dots");
            //based.bgAnimator.SetTrigger("Fold");
            based.p1Copy.SetActive(true);
            based.p1Copy.transform.position = new Vector2(based.p1.transform.position.x * -1, based.p1.transform.position.y);
            //based.StartCoroutine(Wait());
        }

        #endregion

    }
}

