using StickInk.Interface;

namespace StickInk.GamePlay
{

    /// <summary>
    /// Base Of Any State
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// When State is RUning
        /// </summary>
        /// <param name="manager"></param>
        void OnStateInit(IGameManager manager);

        /// <summary>
        /// When State Exit
        /// </summary>
        /// <param name="manager"></param>
        void OnStateExit(IGameManager manager);
    }
}
