using UnityEngine;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour
{
    #region Variables

    private readonly int _buildIndexSceneGame = 1;

    #endregion

    #region Public methods

    public void StartGame()
    {
        SceneManager.LoadScene(_buildIndexSceneGame);
    }

    #endregion
}