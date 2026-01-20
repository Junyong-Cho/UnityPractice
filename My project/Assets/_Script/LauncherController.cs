using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        InvokeRepeating(nameof(Shoot), 0.5f, 1f);
    }

    void Shoot()
    {
        SoundManagerSingleton.instance.SoundBullet();
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
