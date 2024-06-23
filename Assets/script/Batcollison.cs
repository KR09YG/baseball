using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batcollison : MonoBehaviour
{
  public bool boolcollison = false;
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            Debug.Log("ttt");
            boolcollison = true;
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
