using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Purchasing;
using UnityEngine;
using UnityEngine.UI;

public class Homerun : MonoBehaviour
{
    [SerializeField] Referee _referee;
    [SerializeField] Text text;
    Score _score;
    Out _out;
    float timer;

    private void Start()
    {
        _out = GameObject.Find("Gamemanager").GetComponent<Out>();
        _score = GameObject.Find("Gamemanager").GetComponent<Score>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if ( timer > 2 )
        {
            text.text = " ";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        timer = 0;
        if ( timer ==0 )
        {
            text.text = "HOMERUN";
            text.color = Color.red;
        }
        
        _score.score += 1;
        _out._strickcount = 0;
        _out._ballcount = 0;
    }
}
