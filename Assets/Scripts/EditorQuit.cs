using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class EditorQuit : MonoBehaviour
{
    public void Quit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();  // Quitte le mode Play dans l'éditeur
        #else
        Application.Quit();  // Ferme l'application
        #endif
    }
}
