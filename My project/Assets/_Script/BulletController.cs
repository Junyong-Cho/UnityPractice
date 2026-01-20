using UnityEngine;

public class BulletController : MonoBehaviour
{
    float speed = 2f;
    public GameObject effect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SoundManagerSingleton.instance.SoundDie();
            Destroy(Instantiate(effect, transform.position, Quaternion.identity), 2);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }



    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
