using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protectmove : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float _movespeed =0.1f;
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
       
        x = this.transform.position.x;
        Debug.Log(x);
        if ( Input.GetKeyDown(KeyCode.W) ) 
        {
            rb.velocity = Vector2.right * _movespeed;
        }
        if ( Input.GetKeyDown(KeyCode.Q) )
        {
            rb.velocity = Vector2.left * _movespeed;
        }
       
    }

}
