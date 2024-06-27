using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoulReferee : MonoBehaviour
{
    Out _out;
    // Start is called before the first frame update
    [SerializeField] Text _text;
    float _timer;
    bool _isTimer;
    private void Start()
    {
        _out = GameObject.Find("Gamemanager").GetComponent<Out>();
        _text.text = " ";
    }
    private void Update()
    {
        //timer += Time.deltaTime;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (_out._strickcount < 2)
        {
            _out._strickcount += 1;
        }
        if(_timer == 0f)
        {
            _text.text = "FOUL";
            _text.color = Color.yellow;
        }
        
        
        if (collision.gameObject.tag == "ball")
        {
            Destroy(collision.gameObject);
        }
    }
}
