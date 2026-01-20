using UnityEngine;

public class SoundManagerSingleton : MonoBehaviour
{

    public static SoundManagerSingleton instance;
    AudioSource audio;
    public AudioClip soundBullet;
    public AudioClip soundDie;

    void Start()
    {
        instance = this;
        audio = GetComponent<AudioSource>();
    }

    public void SoundDie()
    {
        audio.PlayOneShot(soundDie);
    }

    public void SoundBullet()
    {
        audio.PlayOneShot(soundBullet);
    }

    void Update()
    {
        
    }
}
