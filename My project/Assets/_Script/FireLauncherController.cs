using Unity.VisualScripting;
using UnityEngine;

public class FireLauncherController : MonoBehaviour
{
    public GameObject fire;

    void Start()
    {
        InvokeRepeating(nameof(Fire), 0, 0.7f);
    }

    void Fire()
    {
        SoundSingleton.instance.ShootFire();
        Instantiate(fire, transform.position, Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}
