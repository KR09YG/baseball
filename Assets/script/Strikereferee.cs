using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Strikereferee : MonoBehaviour
{

   public GameObject _bat;
    Batcollison _bat1;
    Out strick;
    [SerializeField] Text text;
    float _timer;
    bool _isTimer;
    private void Start()
    {
        text = text.GetComponent<Text>();
        _bat1 = GameObject.Find("baseball_bat").GetComponent<Batcollison>();
        strick = GameObject.Find("Gamemanager").GetComponent<Out>();
        text.text = " ";
    }
    private void Update()
    {
        Debug.Log(_timer);
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (_bat1.boolcollison == true)
        {
            _isTimer = true;
            text.enabled = true;
            text.text = "FOUL";
            text.color = Color.yellow;
            _bat1.boolcollison = false;
            if ( strick._strickcount < 2)
            {
                strick._strickcount += 1;
            }
        }
        else
        {
            _isTimer = true;
            text.enabled = true;
            text.text = "STRIKE";
            text.color = Color.yellow;
            strick._strickcount += 1;
        }
            Destroy(collision.gameObject);
           
             
    }
    
}
