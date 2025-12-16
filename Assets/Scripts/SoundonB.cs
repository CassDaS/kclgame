using UnityEngine;

public class PlaySoundOnM : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}
