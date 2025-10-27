using UnityEngine;
using TMPro; // if using TextMeshPro

public class LaptopTerminal : MonoBehaviour
{
    [Header("References")]
    public LaptopInteract laptopInteract;
    public TMP_InputField answerField;
    public GameObject successMessage;

    public void CheckAnswer()
    {
        string input = answerField.text.Trim().ToUpper();

        if (input == "11")
        {
            successMessage.SetActive(true);
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
    }
}
