using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protect : MonoBehaviour
{
    Out protect;
    // Start is called before the first frame update
    void Start()
    {
        protect = GameObject.Find("Gamemanager").GetComponent<Out>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        protect._outcount += 1;
        Destroy(collision.gameObject);
    }
}
