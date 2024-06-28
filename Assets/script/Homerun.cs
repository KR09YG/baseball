using UnityEngine;
using UnityEngine.UI;

public class Homerun : MonoBehaviour
{
    [SerializeField] Referee _referee;
    [SerializeField] Text text;
    Score _score;
    Out _out;
    float _timer;
    bool _isTimer;
    AudioSource _audioSource;
    private void Start()
    {
        _out = GameObject.Find("Gamemanager").GetComponent<Out>();
        _score = GameObject.Find("Gamemanager").GetComponent<Score>();
        text.text = " ";
        _audioSource = GetComponent<AudioSource>();
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
            Debug.Log(_timer);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( _out._outcount < 3 )
        {
            _isTimer = true;
            text.enabled = true;
            text.text = "HOMERUN";
            text.color = Color.red;
            _score.score += 1;
            _out._strickcount = 0;
            _out._ballcount = 0;
            _audioSource.Play();
        }
       
    }
}
