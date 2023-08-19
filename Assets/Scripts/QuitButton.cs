using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        // Quit the game if in the Unity Editor
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Quitting game in Unity Editor.");
#else
        // Quit the game in a built executable
        Application.Quit();
        Debug.Log("Quitting game in standalone build.");
#endif
    }
}
