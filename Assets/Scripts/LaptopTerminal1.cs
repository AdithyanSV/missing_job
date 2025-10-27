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

        if (input == "printPyramid(rows)")
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
        laptopInteract1.CloseLaptop();
        doorController.OpenDoor();
    }
}