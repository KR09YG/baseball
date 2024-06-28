using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Out : MonoBehaviour
{
    public int _outcount = 0;
    public int _strickcount = 0;
    public int _ballcount = 0;
    SpriteRenderer _strickimage;
    SpriteRenderer _strickimage2;
    SpriteRenderer _outimage;
    SpriteRenderer _outimage2;
    SpriteRenderer _ballimage;
    SpriteRenderer _ballimage2;
    SpriteRenderer _ballimage3;
    [SerializeField] Text text;
    float _timer;
    bool _isTimer;
    [SerializeField]  GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        text.text = " ";
        _strickimage = GameObject.Find("strick1").GetComponent<SpriteRenderer>();
        _strickimage2 = GameObject.Find("strick2").GetComponent<SpriteRenderer>();
        _outimage = GameObject.Find("out").GetComponent<SpriteRenderer>();
        _outimage2 = GameObject.Find("out2").GetComponent<SpriteRenderer>();
        _ballimage = GameObject.Find("ball").GetComponent<SpriteRenderer>();
        _ballimage2 = GameObject.Find("ball2").GetComponent<SpriteRenderer>();
        _ballimage3 = GameObject.Find("ball3").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
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
        if (_strickcount >= 1)
        {
            _strickimage.color = new Color(255, 100, 0);
        }
        else
        {
            _strickimage.color = Color.white;
        }
        if (_strickcount >= 2)
        {
            _strickimage2.color = new Color(255, 100, 0);
        }
        else
        {
            _strickimage2.color = Color.white;
        }
        if (_outcount >= 1)
        {
            _outimage.color = new Color(255, 0, 0);
        }
        else
        {
            _outimage.color = Color.white;
        }
        if (_outcount >= 2)
        {
            _outimage2.color = new Color(255, 0, 0);
        }
        else
        {
            _outimage2.color = Color.white;
        }
        if (_ballcount >= 1)
        {
            _ballimage.color = new Color(0, 255, 0);
        }
        else
        {
            _ballimage.color = Color.white;
        }
        if (_ballcount >= 2)
        {
            _ballimage2.color = new Color(0, 255, 0);
        }
        else
        {
            _ballimage2.color = Color.white;
        }
        if (_ballcount >= 3)
        {
            _ballimage3.color = new Color(0, 255, 0);
        }
        else
        {
            _ballimage3.color = Color.white;
        }

        
        if(_outcount > 2 )
        {
            button.SetActive(true);
            text.text = "GAMESET";
            Time.timeScale = 0;
        }     
        if(_strickcount > 2)
        {
            _isTimer = true;
            text.enabled = true;
            text.text = "OUT";
            text.color = Color.red;
            _outcount += 1;
            _strickcount = 0;
            _ballcount = 0;
        }
        if ( _ballcount > 3 )
        {
            _ballcount = 0;
            _strickcount = 0;
        }
    }
}
