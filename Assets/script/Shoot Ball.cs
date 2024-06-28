using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] Vector2 _pos;
    [SerializeField] float m_speed;
    [SerializeField] float _changeY;
    bool _isCurve;
    // Start is called before the first frame update
    void Start()
    {
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
            _rb.AddForce((Vector2.right.normalized + Vector2.down.normalized)/1000);
            _isCurve = false;
        }
    }
}
