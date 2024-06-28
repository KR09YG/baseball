using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    [SerializeField] float m_speed = 3f;
    GameObject m_gameObject;
    Out protect;
    [SerializeField] Text text;
    float _timer;
    GameObject gameobject;
    bool _isTimer;
    // Start is called before the first frame update
    void Start()
    {
        m_gameObject = GameObject.FindGameObjectWithTag("protect");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * m_speed;
        protect = GameObject.Find("Gamemanager").GetComponent<Out>();
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
            Debug.Log(_timer);

        }
    }
   
}
