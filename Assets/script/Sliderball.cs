using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderball : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] Vector2 _pos;
    [SerializeField] float m_speed;
    [SerializeField] float _changeY;
    bool _isCurve;
    Out protect;
   
    // Start is called before the first frame update
    void Start()
    {
        protect = GameObject.Find("Gamemanager").GetComponent<Out>();
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = Vector2.down * m_speed;
      
    }

    // Update is called once per frame
    void Update()
    {
            
            if (transform.position.y < _changeY)
        {
            _isCurve = true;
        }
        if (_isCurve)
        {
           _rb.AddForce(new Vector2(-20f * Time.deltaTime * 2, -0.02f) / 100, ForceMode2D.Force);  
           _isCurve=false;
        }
    }
   
}
