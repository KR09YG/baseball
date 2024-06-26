using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strikereferee : MonoBehaviour
{
    [SerializeField] Referee _referee;

   public GameObject _bat;
    Batcollison _bat1;
    Out strick;
    [SerializeField] Text text;
    float _timer;
    private void Start()
    {
        text = text.GetComponent<Text>();
        _bat1 = GameObject.Find("baseball_bat").GetComponent<Batcollison>();
        strick = GameObject.Find("Gamemanager").GetComponent<Out>();
        
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        Debug.Log(_timer);
        if (_timer > 2)
        {
            text.text = " ";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_bat1.boolcollison == true)
        {
            Debug.Log("aaa");
            _referee.ImageChange(3);
            _bat1.boolcollison = false;
        }
        else
        {
            _timer = 0;
            if(_timer == 0f)
            {
                Debug.Log(_timer);
                text.text = "STRIKE";
            }
            Destroy(collision.gameObject);
            strick._strickcount += 1;
        }       
    }
    
}
