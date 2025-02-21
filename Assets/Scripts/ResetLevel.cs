using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    void Update()
    {
        //Ceci vérifiera si la touche P est pressée
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Ceci rechargera la scène
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
