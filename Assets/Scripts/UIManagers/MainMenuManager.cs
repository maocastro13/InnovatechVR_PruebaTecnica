using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public PlayerController playerController;
    public GameObject mainMenuPanel;
    public Button startMissionButton;
    public Vector3 playerStartPosition = new Vector3(0, 1, 0);

    private void Start()
    {
        if (playerController != null)
        {
            playerController.DisableInput();
        }

        // Aseguramos que el cursor esté visible y desbloqueado al inicio
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (startMissionButton != null)
        {
            startMissionButton.onClick.AddListener(StartMission);
        }
    }

    private void StartMission()
    {
        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false);
        }

        if (playerController != null)
        {
            playerController.transform.position = playerStartPosition;
            playerController.EnableInput();
        }

        // Desactivamos este script para evitar llamadas accidentales
        this.enabled = false;
    }
}