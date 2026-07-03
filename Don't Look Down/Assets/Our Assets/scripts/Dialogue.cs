using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [Header("Dialogue")]
    public GameObject dialoguePrefab;
    public Transform canvas;

    [Header("Controls")]
    public KeyCode interactKey = KeyCode.E;

    private bool playerInRange;
    private GameObject dialogueInstance;

    void Update()
    {
        if (!playerInRange)
            return;

        // Open dialogue
        if (dialogueInstance == null && Input.GetKeyDown(interactKey))
        {
            dialogueInstance = Instantiate(dialoguePrefab, canvas);

            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        // Close dialogue
        else if (dialogueInstance != null && Input.GetKeyDown(interactKey))
        {
            CloseDialogue();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Press E to Talk");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;

            if (dialogueInstance != null)
                CloseDialogue();
        }
    }

    void CloseDialogue()
    {
        Destroy(dialogueInstance);

        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}


