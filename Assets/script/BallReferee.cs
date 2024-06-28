using UnityEngine;
using UnityEngine.UI;

public class BallReferee : MonoBehaviour
{
    Bat bat;
    Batcollison _bat;
    Out ball;
    float _timer;
    bool _isTimer;
    [SerializeField] Text text;
    private void Start()
    {
        bat = GameObject.Find("Circle").GetComponent<Bat>();
        _bat = GameObject.Find("baseball_bat").GetComponent<Batcollison>();
         ball = GameObject.Find("Gamemanager").GetComponent<Out>();
        text.text = " ";
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_bat.boolcollison ==true)
        {
            _isTimer = true;
            text.enabled = true;
            text.text = "FOUL";
            text.color = Color.yellow;
            _bat.boolcollison=false;
            if ( ball._strickcount < 2)
            {
                ball._strickcount += 1;
            }
        }
        else
        {          
            if (bat._rotateZ >= 220)
            {
                _isTimer = true;
                text.enabled = true;
                text.text = "BALL";
                text.color = Color.green;
                Destroy(collision.gameObject);
                ball._ballcount += 1;
            }
            else 
            {               
                _isTimer = true;
                text.enabled = true;
                text.text = "STRIKE";
                text.color = Color.yellow;
                ball._strickcount += 1;
            }
        }
       
            
        } 
    }

