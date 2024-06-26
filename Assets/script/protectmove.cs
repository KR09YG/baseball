using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protectmove : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float _movespeed =0.1f;
    
    float x;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = this.transform.position;
        x = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.right * _movespeed;
        
    }
}
