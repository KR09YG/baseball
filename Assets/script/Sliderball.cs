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
    GameObject _gameObject;
    Out protect;
    [SerializeField] Text text;
    float _timer;
    GameObject gameobject;
    bool _isTimer;
    // Start is called before the first frame update
    void Start()
    {
        protect = GameObject.Find("Gamemanager").GetComponent<Out>();
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = Vector2.down * m_speed;
        _gameObject = GameObject.FindGameObjectWithTag("protect");
    }

    // Update is called once per frame
    void Update()
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
