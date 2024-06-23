using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Out : MonoBehaviour
{
    public int _outcount = 0;
    public int _strickcount = 0;
    public int _ballcount = 0;
    SpriteRenderer _strickimage;
    SpriteRenderer _strickimage2;
    // Start is called before the first frame update
    void Start()
    {
        _strickimage = GameObject.Find("strick1").GetComponent<SpriteRenderer>();
        _strickimage2 = GameObject.Find("strick2").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_strickcount >= 1)
        {
            _strickimage.color = new Color(255, 100, 0);
        }
        else
        {
            _strickimage.color = Color.white;
        }
        Debug.Log(_strickcount);
        if(_outcount > 2 )
        {
            
        }
        if(_ballcount > 3 )
        {

        }
        if(_strickcount > 2)
        {
            _outcount += 1;
            _strickcount = 0;
        }
    }
}
