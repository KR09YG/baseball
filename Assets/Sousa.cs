using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sousa : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject image;
    [SerializeField] GameObject button;
    [SerializeField] GameObject button2;
    // Start is called before the first frame update
    public void Bottun()
    {
        image.SetActive(true);
        text.SetActive(true);
        button.SetActive(true);
        button2.SetActive(true);
    }
}
