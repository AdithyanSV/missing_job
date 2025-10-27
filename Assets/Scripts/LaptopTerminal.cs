using UnityEngine;
using TMPro; // if using TextMeshPro

public class LaptopTerminal : MonoBehaviour
{
    [Header("References")]
    public LaptopInteract laptopInteract;
    public TMP_InputField answerField;
    public GameObject successMessage;
    [SerializeField] private PuzzleRoomDoorController doorController;

    public void CheckAnswer()
    {
        string input = answerField.text.Trim().ToUpper();

        if (input == "11")
        {
            successMessage.SetActive(true);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.puzzleSolved);
            Invoke(nameof(CloseTerminal), 2f); // wait 2 seconds
        }
        else
        {
            answerField.text = "";
        }
    }

    void CloseTerminal()
    {
        laptopInteract.CloseLaptop();
        doorController.UnlockDoors();
    }
}
