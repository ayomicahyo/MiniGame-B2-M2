using UnityEngine;
using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// This Class is Use to handle Player Controller in Stage
    /// </summary>
    public class Player1 : MonoBehaviour, IController , IPlayer1Set
    {

        #region Variable

        /// <summary>
        /// Get WorldPosition
        /// </summary>
        private Vector3 worldPosition = default;

        /// <summary>
        /// To Get Manager
        /// </summary>
        [SerializeField]
        private GameManager manager = null;

        /// <summary>
        /// Dots Object from Player
        /// </summary>
        [SerializeField]
        private GameObject dots = null;

        #endregion

        #region Mono

        private void OnDisable()
        {
            if (dots != null)
                dots.SetActive(true);
        }

        private void OnEnable()
        {
            if (dots != null)
                dots.SetActive(false);
        }
        private void Update()
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

            transform.position = new Vector2(worldPosition.x, worldPosition.y);
        }

        private void OnMouseDown()
        {
            SetDots();
        }

        #endregion

        #region IController

        public void OnClick()
        {
            dots.SetActive(true);
            dots.transform.position = this.transform.position;
        }

        public void SetDots()
        {
            if (GameManager.StateActive == "Player1Set")
            {
                OnClick();
                manager.ChangeState();
            }
            
        }

        #endregion

    }
}
