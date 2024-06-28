using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batcollison : MonoBehaviour
{
    AudioSource audiosouce;
  public bool boolcollison = false;
    private void Start()
    {
        audiosouce = GetComponent<AudioSource>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            //Debug.Log("ttt");
            boolcollison = true;
            audiosouce.Play();
        }
        
    }
    private void Update()
    {
        if(boolcollison == true)
        {
            //Debug.Log("true");
        }
    }
}
