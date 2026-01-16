using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {

    }

    void Update()
    {
        float horizon = Input.GetAxis("Horizontal");
        float vertica = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizon, vertica) * speed * Time.deltaTime);
        
    }
}
