using UnityEngine;

public class SimpleDoorController : MonoBehaviour
{
    [Header("Door Animators")]
    public Animator leftDoorAnimator;
    public Animator rightDoorAnimator;

    private bool doorOpened = false;

    // Called externally when the puzzle is solved
    public void OpenDoor()
    {
        if (!doorOpened)
        {
            leftDoorAnimator.SetBool("OpenDoor", true);
            rightDoorAnimator.SetBool("OpenDoor", true);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.doorOpen);
            doorOpened = true;
            Debug.Log("Puzzle complete — door opened.");
        }
    }
}
