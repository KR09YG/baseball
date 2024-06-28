using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sousa : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject image;
    [SerializeField] GameObject button;
    // Start is called before the first frame update
    public void Bottun()
    {
        image.SetActive(true);
        text.SetActive(true);
        button.SetActive(true);
    }
}
