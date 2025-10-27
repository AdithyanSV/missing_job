using UnityEngine;
using TMPro; // if using TextMeshPro

public class LaptopTerminal2 : MonoBehaviour
{
    [Header("References")]
    public LaptopInteract1 laptopInteract1;
    public TMP_InputField answerField;
    public GameObject successMessage;
    [SerializeField] private SimpleDoorController doorController;

    public void CheckAnswer()
    {
        string input = answerField.text.Trim().ToUpper();
        Debug.Log($"Entered Answer: {input}");

        if (input == "ROWS") //Updated expected answer
        {
            successMessage.SetActive(true);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.puzzleSolved);
            Debug.Log("✅ Correct answer — closing terminal soon");
            Invoke(nameof(CloseTerminal), 2f);
        }
        else
        {
            Debug.Log("❌ Wrong answer");
            answerField.text = "";
        }
    }

    void CloseTerminal()
    {
        laptopInteract1.CloseLaptop();
        doorController.OpenDoor();
    }
}