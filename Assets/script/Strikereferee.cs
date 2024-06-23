using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strikereferee : MonoBehaviour
{
    [SerializeField] Referee _referee;

   public GameObject _bat;
    Batcollison _bat1;
    Out strick;
    private void Start()
    {
        _bat1 = GameObject.Find("baseball_bat").GetComponent<Batcollison>();
        strick = GameObject.Find("Gamemanager").GetComponent<Out>();
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
            _referee.ImageChange(0);
            Destroy(collision.gameObject);
            strick._strickcount += 1;
        }       
    }
    
}
