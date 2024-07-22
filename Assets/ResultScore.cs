using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = $"{PlayerPrefs.GetInt("score").ToString()}“_";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
