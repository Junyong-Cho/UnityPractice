using UnityEngine;

public class FireController : MonoBehaviour
{
    public float speed = 3f;
    public GameObject effect;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("만났다");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(Instantiate(effect, transform.position, Quaternion.identity), 2);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
