using UnityEngine;

public class BackgroundAudioEffects : MonoBehaviour
{
    private AudioSource _audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayMusic();
    }
    
    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void StopMusic()
    {
        if (audioSource.isPlaying)
        {
            _audioSource.Stop();
        }
    }
}
