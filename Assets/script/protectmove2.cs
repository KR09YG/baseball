using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protectmove2 : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float _movespeed = 0.1f;
    bool a = false;
    float x;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector2.right * _movespeed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = Vector2.left * _movespeed;
        }

    }

}
