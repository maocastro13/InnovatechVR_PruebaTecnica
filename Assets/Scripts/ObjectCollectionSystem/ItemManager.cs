using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }

    public int totalItems = 5;
    public PlayerController playerController;

    private int collectedItems = 0;

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

    private void Start()
    {
        UIManager.Instance.UpdateCountText(collectedItems, totalItems);
    }

    public void CollectItem(int points)
    {
        collectedItems += points;
        UIManager.Instance.UpdateCountText(collectedItems, totalItems);
        CheckCompletion();
    }

    private void CheckCompletion()
    {
        if (collectedItems >= totalItems)
        {
            UIManager.Instance.ShowCompletionMessage();
            if (playerController != null)
            {
                playerController.DisableInput();
            }
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}