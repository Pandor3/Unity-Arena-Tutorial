using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadSceneAsync("Arène 1");
    }
}
