using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]
    public AudioSource sfxSource; // for sound effects
    public AudioSource musicSource; // optional background music

    [Header("Sound Effects")]
    public AudioClip doorOpen;
    public AudioClip doorClose;
    public AudioClip laptopOpen;
    public AudioClip puzzleSolved;
    public AudioClip playerFootstep;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void PlaySFX(AudioClip clip)
    {
        if (clip != null)
            sfxSource.PlayOneShot(clip);
    }
}
