using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public bool stop = false;
    // Start is called before the first frame update
    public void Stpp()
    {
        stop = true;
        if (stop)
        {
            Time.timeScale = 0;
        }
    }
    public void Starttime()
    {
        stop = false;
        if (stop == false)
        {
            Time.timeScale = 1;
        }
    }
}
