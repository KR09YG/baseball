using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoulReferee : MonoBehaviour
{
   
    // Start is called before the first frame update
    [SerializeField] Referee _referee;
    private void OnTriggerEnter2D(Collider2D collision)
    {
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
