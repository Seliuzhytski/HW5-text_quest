using UnityEngine;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour
{
    private int _buildIndexSceneGame = 1;

    public void StartGame()
    {
        SceneManager.LoadScene(_buildIndexSceneGame);
    }
}
