using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// For Managing A Scene
/// </summary>
public class SceneManagered : MonoBehaviour
{

    #region Main

    /// <summary>
    /// For Handle when game want to change scene by name
    /// </summary>
    /// <param name="namescene"></param>
    public void GoToscene(string namescene)
    {
        SceneManager.LoadScene(namescene);
    }

    #endregion

}
