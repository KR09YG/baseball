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
    float _timer =0f;
    private void Start()
    {
        text = text.GetComponent<Text>();
        _bat1 = GameObject.Find("baseball_bat").GetComponent<Batcollison>();
        strick = GameObject.Find("Gamemanager").GetComponent<Out>();
        
    }
    private void Update()
    {
        Debug.Log(_timer);
        _timer += Time.deltaTime;
        if (_timer > 4f)
        {
            text.text = " ";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _timer = 0f;
        if (_bat1.boolcollison == true)
        {
            if (_timer == 0f)
            {
                Debug.Log("aaa");
                text.text = "FOUL";
                text.color = Color.yellow;
                _bat1.boolcollison = false;
            }
        }
        
                Debug.Log(_timer);
                text.text = "STRIKE";
                text.color = Color.yellow;
            
            Destroy(collision.gameObject);
            strick._strickcount += 1;
             
    }
    
}
