using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batcollison : MonoBehaviour
{
  public bool m_boolcollison = false;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            m_boolcollison = true;
        }
        
    }
    private void Update()
    {
        if(m_boolcollison == true)
        {
            Debug.Log("true");
        }
    }
}
