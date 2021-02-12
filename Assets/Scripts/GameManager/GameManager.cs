using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class Is For Managing A Game
    /// </summary>
    public class GameManager : StateController
    {

        
        #region SingleTone
        
        private static GameManager _instance;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType<GameManager>();
                }

                return _instance;
            }
        }

        #endregion

        #region Variable

        /// <summary>
        /// Player 1 Char in Array
        /// </summary>
        [SerializeField]
        private GameObject[] player1Char = new GameObject[6];

        /// <summary>
        /// Player2  2 Char in Array
        /// </summary>
        [SerializeField]
        private GameObject[] player2Char = new GameObject[6];

        /// <summary>
        /// Player 1 Controller Object
        /// </summary>
        public GameObject p1 = null;

        /// <summary>
        /// Player  2 Controller Object
        /// </summary>
        public GameObject p2 = null;

        /// <summary>
        /// Player 1 Copy Object
        /// </summary>
        public GameObject p1Copy = null;

        /// <summary>
        /// Player 2 Copy Object
        /// </summary>
        public GameObject p2Copy = null;

        /// <summary>
        /// Game End Panel
        /// </summary>
        public GameObject gameEndPanel = null;

        /// <summary>
        /// Text in End Game Panel
        /// </summary>
        public Text endPanel = null;

        /// <summary>
        /// State Text
        /// </summary>
        public Text stateText = null;

        /// <summary>
        /// To Declare Game BG ANimator
        /// </summary>
        public Animator bgAnimator = null;

        #endregion

        #region Mono

        protected override void Awake()
        {
            InitializePosChar();
            base.Awake();
        }

        #endregion

        #region Main

        public override void ChangeState()
        {
            base.ChangeState();
            stateText.text = StateActive;
        }

        public override void Initialize()
        {
            base.Initialize();
            stateText.text = StateActive;
        }


        private void InitializePosChar()
        {
            for(int i = 0; i < player1Char.Length; i++)
            {
                RanPos(player1Char[i], true);
                RanPos(player2Char[i], false);
            }
        }

        private void RanPos(GameObject obj , bool isP1)
        {
            float y = 0;
            float x = 0;

            y = Random.Range((float)-3.5 , (float)3.5);

            if (isP1)
            {
                x = Random.Range((float)-7, -1);
                obj.transform.position = new Vector2(x,y);
            }
            else
            {
                x = Random.Range(1, (float)7);
                obj.transform.position = new Vector2(x, y);
            }
        }

        public void AddScore(IPlayerCharacter player)
        {
            if(player is P1Character)
            {
                player2Score += 1;
            }
            else
            {
                player1Score += 1;
            }
        }

        #endregion

    }
}

