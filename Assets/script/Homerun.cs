using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Purchasing;
using UnityEngine;

public class Homerun : MonoBehaviour
{
    [SerializeField] Referee _referee;
    [SerializeField] GameObject _score;
    public int _scoreIndex;

    private void Start()
    {
        _scoreIndex = 0;
        
        //_scoreIndex = Gamemanager.GetComponent<Score>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _referee.ImageChange(2);
        _scoreIndex += 1;
    }
}
