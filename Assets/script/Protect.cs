using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Protect : MonoBehaviour
{
    Out protect;
    [SerializeField] Text text;
    float _timer;
    GameObject gameobject;
    bool _isTimer;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        protect = GameObject.Find("Gamemanager").GetComponent<Out>();
        gameobject = GameObject.FindGameObjectWithTag("protect");
        audioSource = GetComponent<AudioSource>();
        
    }
    private void Update()
    {
        if (_isTimer)
        {
            _timer += Time.deltaTime;
            if (_timer > 2.5f)
            {
                _timer = 0;
                _isTimer = false;
                text.enabled = false;
            }
           
        }
    }
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            _isTimer = true;
            text.enabled = true;
            text.text = "OUT";
            text.color = Color.red;
            protect._outcount += 1;
            protect._strickcount = 0;
            protect._ballcount = 0;
            Destroy(collision.gameObject);
            audioSource.Play();
        }
        
    }
}
