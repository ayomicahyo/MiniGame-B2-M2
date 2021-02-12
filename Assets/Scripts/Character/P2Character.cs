using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class is Use to handle Player Character in Stage
    /// </summary>
    public class P2Character : MonoBehaviour , IPlayerCharacter
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Destroyer")
            {
                gameObject.SetActive(false);
                GameManager.Instance.AddScore(this);
            }
        }
    }

}
