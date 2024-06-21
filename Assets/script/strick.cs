using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class strick : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject = GetComponent<GameObject>();
        if (collision.gameObject.tag == "ball")
        {
            Instantiate(text,gameObject.transform);
            //Destroy(text,10f);
        }
    }
}
