using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BACK : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject image;
    [SerializeField] GameObject button;
    [SerializeField] GameObject button2;
    // Start is called before the first frame update
    public void Back()
    {
        text.SetActive(false);
        image.SetActive(false);
        button.SetActive(false);
        button2.SetActive(false);
    }
}
