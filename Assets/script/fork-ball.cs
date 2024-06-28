using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class forkball : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float m_speed = 3f;
    [SerializeField] float m_speedup = 1f;
    private Rigidbody2D rBody;
    [SerializeField] float _changeY;
    bool _isFork;
    GameObject _gameObject;
    Out _protect;
    [SerializeField] Text text;
    float _timer;
    GameObject gameobject;
    bool _isTimer;
    GameObject ball;
    // Use this for initialization
    private void Start()
    {
        _protect = GameObject.Find("Gamemanager").GetComponent<Out>();
        rBody = this.GetComponent<Rigidbody2D>();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 Forkballpos = this.transform.position;
        _gameObject = GameObject.FindGameObjectWithTag("protect");
            rb.velocity = Vector2.down * m_speed;
        ball = GameObject.FindGameObjectWithTag("ball");
    }

    private void Update()
    {

        if (_isTimer)
        {
            _timer += Time.deltaTime;
            if (_timer > 2.5f)
            {
                _timer = 0;
                _isTimer = false;
                text.enabled = false;
            }

        }
        if (transform.position.y < _changeY)
        {
            _isFork = true;
        }
        if (_isFork)
        {
            rBody.AddForce(new Vector2(0, -m_speedup*0.02f)/100,ForceMode2D.Force);
            _isFork = false;
        }
        
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
       Destroy(gameObject); 
    }
}

