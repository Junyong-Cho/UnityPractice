using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public float pSpeed;

    void Start()
    {
        Debug.Log(player.GetComponent<PlayerController>().speed);
    }

    void Update()
    {
        
    }
}
