using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : MonoBehaviour
{
    [Header("Assign the object that kills the player")]
    public GameObject deadlyObject; // Drag and drop in Inspector

    [Header("Restart delay after death (seconds)")]
    public float restartDelay = 2f;

    private bool isDead = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isDead && deadlyObject != null && collision.gameObject == deadlyObject)
        {
            Die();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isDead && deadlyObject != null && other.gameObject == deadlyObject)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;
        Debug.Log($"Player died after colliding with {deadlyObject.name}!");

        // Disable player controls, play animation, etc. (optional)
        Invoke(nameof(RestartGame), restartDelay);
    }

    private void RestartGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}

