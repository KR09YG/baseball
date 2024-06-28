using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitcher : MonoBehaviour
{
    
    Vector3 pitchingpoint;

    [SerializeField] GameObject m_ball1 = default;
    [SerializeField] GameObject m_ball2 = default;
    [SerializeField] GameObject m_ball3 = default;
    [SerializeField] GameObject m_ball4 = default;
    [SerializeField] GameObject _hand = default;
    [SerializeField] bool m_generateOnStart = true;
    [SerializeField] float _interval = 3f;
    float _timer ;
    // Start is called before the first frame update
    Vector3 bulletpoint;
    void Start()
    {
        if (m_generateOnStart)
        {
            _timer = _interval;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        //Debug.Log(_timer);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if ( _timer > _interval )
            {
                _timer = 0;
                bulletpoint = _hand.transform.position;
                Instantiate(m_ball1, _hand.transform.position, Quaternion.identity);
            }           
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (_timer > _interval)
            {
                _timer = 0;
                bulletpoint = _hand.transform.position;
                Instantiate(m_ball2, _hand.transform.position, Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (_timer > _interval)
            {                
                _timer = 0;
                bulletpoint = _hand.transform.position;
                Instantiate(m_ball3, _hand.transform.position, Quaternion.identity);
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            if (_timer > _interval)
            {          
                _timer = 0;
                bulletpoint = _hand.transform.position;
                Instantiate(m_ball4, _hand.transform.position, Quaternion.identity);
            }
        }

    }
}
