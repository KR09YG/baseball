using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    public void Title_button()//string_buttonという名前にします
    {
        SceneManager.LoadScene("Start");//secondを呼び出します
    }
}
