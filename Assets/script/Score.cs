using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    GameObject scoretext=default;
    [SerializeField] Text text;
    public int score = 0;
    void Start()
    {
        
    }

    public void Update()
    {
        
        text = scoretext.GetComponent<Text>();
        text.text = (score.ToString()+"“_");
    }
}
