using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;

    void Start()
    {

    }

    void Update()
    {
        float horizon = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizon, vertical) * Time.deltaTime * speed);
    }
}
