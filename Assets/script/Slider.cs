using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float m_speed = 3f;
    [SerializeField] float m_speedup = 1f;
    private Rigidbody2D rBody;
    

    // Use this for initialization
    private void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 Sliderballpos = this.transform.position;
        if (Sliderballpos.x > -0.1)
        {
            rb.velocity = Vector2.down * m_speed;
            
        }
    }

    private void Update()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector2 Sliderballpos = this.transform.position; 
        if(Sliderballpos.y <= -0.1)
        {
            rb.velocity = Vector2.down * m_speed * m_speedup;
            
        }
    }

   
}

