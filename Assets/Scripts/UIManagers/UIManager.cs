using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    public TextMeshProUGUI countText;
    public GameObject completionPanel;
    public TextMeshProUGUI completionText;
    public Animation completionPanelAnimation; // Para animar el panel de finalización

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateCountText(int collected, int total)
    {
        countText.text = $"Estabilizadores: {collected} / {total}";
    }

    public void ShowCompletionMessage()
    {
        completionPanel.SetActive(true);
        if (completionPanelAnimation != null)
        {
            completionPanelAnimation.Play();
        }
    }
}