using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoulReferee : MonoBehaviour
{
    Out _out;
    // Start is called before the first frame update
    [SerializeField] Referee _referee;
    [SerializeField] Text _text;
    float timer = 0f;
    private void Start()
    {
        _out = GameObject.Find("Gamemanager").GetComponent<Out>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            _text.text = " ";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        timer = 0f;
        if (_out._strickcount < 2)
        {
            _out._strickcount += 1;
        }
        if(timer == 0f)
        {
            _text.text = "FOUL";
            _text.color = Color.yellow;
        }
        
        
        if (collision.gameObject.tag == "ball")
        {
            Destroy(collision.gameObject);
        }
    }
}
