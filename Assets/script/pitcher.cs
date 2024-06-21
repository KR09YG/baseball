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
    // Start is called before the first frame update
    Vector3 bulletpoint;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            bulletpoint = _hand.transform.position;
            Instantiate(m_ball1,_hand.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            bulletpoint = _hand.transform.position;
            Instantiate(m_ball2, _hand.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            bulletpoint = _hand.transform.position;
            Instantiate(m_ball3, _hand.transform.position, Quaternion.identity);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            bulletpoint = _hand.transform.position;
            Instantiate(m_ball4, _hand.transform.position, Quaternion.identity);
        }

    }
}
