using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoulReferee : MonoBehaviour
{
    Out _out;
    // Start is called before the first frame update
    [SerializeField] Referee _referee;
    private void Start()
    {
        _out = GameObject.Find("Gamemanager").GetComponent<Out>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_out._strickcount > 2)
        {
            _out._strickcount += 1;
        }
       
        _referee.ImageChange(2);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Destroy(collision.gameObject);
        }
    }
}
