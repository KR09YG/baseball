using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    public void Title_button()//string_button‚Æ‚¢‚¤–¼‘O‚É‚µ‚Ü‚·
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Start");//second‚ğŒÄ‚Ño‚µ‚Ü‚·
    }
}
