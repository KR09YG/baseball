using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    [SerializeField] Text stext;
    public int score = 0;
    public int runcount = 0;

      
    void Start()
    {
        
    }

    public void Update()
    {
        Debug.Log(runcount);
        stext = stext.GetComponent<Text>();
        stext.text = (score.ToString()+"“_");
        
    }
}
