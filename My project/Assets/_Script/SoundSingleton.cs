using UnityEngine;

public class SoundSingleton : MonoBehaviour
{
    public static SoundSingleton instance;
    
    AudioSource audioSource;
    public AudioClip dieDragon;
    public AudioClip shootFire;

    void Start()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void DieDragon()
    {
        audioSource.PlayOneShot(dieDragon);    
    }

    public void ShootFire()
    {
        audioSource.PlayOneShot(shootFire);
    }
}
