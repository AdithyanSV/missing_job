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
            leftDoorAnimator.SetBool("DoorOpened", true);
            rightDoorAnimator.SetBool("DoorOpened", true);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.doorOpen);
            doorOpened = true;
            Debug.Log("Puzzle complete — door opened.");
        }
    }
}
