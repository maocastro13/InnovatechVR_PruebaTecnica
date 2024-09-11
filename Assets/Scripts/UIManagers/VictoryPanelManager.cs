using UnityEngine;
using UnityEngine.UI;

public class VictoryPanelManager : MonoBehaviour
{
    public Button exitButton;

    void Start()
    {
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitGame);
        }
    }

    void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}