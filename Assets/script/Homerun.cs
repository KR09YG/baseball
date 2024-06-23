using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Purchasing;
using UnityEngine;

public class Homerun : MonoBehaviour
{
    [SerializeField] Referee _referee;
    Score _score;

    private void Start()
    {
        _score = GameObject.Find("Gamemanager").GetComponent<Score>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _referee.ImageChange(2);
        _score.score += 1;
    }
}
