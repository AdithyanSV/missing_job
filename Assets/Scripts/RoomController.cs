using UnityEngine;

public class PuzzleRoomDoorController : MonoBehaviour
{
    [Header("Door Animators")]
    public Animator leftDoorAnimator;
    public Animator rightDoorAnimator;

    private bool doorClosed = false;
    private bool puzzleCompleted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !doorClosed)
        {
            // Close both doors when the player enters the trigger for the first time
            leftDoorAnimator.SetBool("CloseDoor", true);
            rightDoorAnimator.SetBool("CloseDoor", true);

            AudioManager.Instance.PlaySFX(AudioManager.Instance.doorClose);

            doorClosed = true;
            Debug.Log("Doors closed — puzzle started.");
        }
    }

    // Called externally when the puzzle is solved
    public void UnlockDoors()
    {
        if (!puzzleCompleted)
        {
            puzzleCompleted = true;
            doorClosed = false;

            AudioManager.Instance.PlaySFX(AudioManager.Instance.doorOpen);

            leftDoorAnimator.SetBool("CloseDoor", false);
            rightDoorAnimator.SetBool("CloseDoor", false);


            Debug.Log("Puzzle complete — doors opened.");
        }
    }
}
