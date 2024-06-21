using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strikereferee : MonoBehaviour
{
    [SerializeField] Referee _referee;

   public GameObject _bat;
   public bool _batcollison;
    
    private void Start()
    {
        _bat = GameObject.FindGameObjectWithTag("bat"); 
        var bat = _bat.GetComponent<Batcollison>();
        _batcollison = bat.m_boolcollison;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_batcollison == true)
        {
            Debug.Log("isijfdsas;");
            _referee.ImageChange(3);
            _batcollison = false;
            Destroy(collision.gameObject);

        }
        else
        {
            _referee.ImageChange(0);
            Destroy(collision.gameObject);
        }       
    }
    
}
