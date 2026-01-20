using UnityEngine;

public class EnemySmallController : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, -1f * Time.deltaTime, 0);
    }


    void OnBecameInvisible()
    {
        Destroy(gameObject);   
    }
}
