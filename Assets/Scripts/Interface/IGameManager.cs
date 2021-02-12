using UnityEngine;

namespace StickInk.Interface
{

    /// <summary>
    /// Interface for handle base of GameManager
    /// </summary>
    public interface IGameManager
    {

        /// <summary>
        /// For Collecting a State
        /// </summary>
        ScriptableObject[] State { get; set; }

        /// <summary>
        /// Do Set A Player 1 Score
        /// </summary>
        int Player1score { get; set; }

        /// <summary>
        /// To Set A Player 2 Score
        /// </summary>
        int Player2score { get; set; }

        /// <summary>
        /// To Set Initialize of class
        /// </summary>
        void Initialize();

        /// <summary>
        /// To Handle Logic When State Want To Change
        /// </summary>
        void ChangeState();
    }
}

