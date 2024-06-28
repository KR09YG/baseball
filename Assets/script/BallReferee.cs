using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BallReferee : MonoBehaviour
{
    Bat bat;
    Batcollison _bat;
    Out ball;
    float _timer;
    bool _isTimer;
    [SerializeField] Text text;
    bool foul = false;
    private void Start()
    {
        bat = GameObject.Find("Circle").GetComponent<Bat>();
        _bat = GameObject.Find("Square (5)").GetComponent<Batcollison>();
         ball = GameObject.Find("Gamemanager").GetComponent<Out>();
        text.text = " ";
    }
    private void Update()
    {
        if (bat._rotateZ > 220)
        {
            foul = false;
            _bat.boolcollison = false;
        }
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
            foul = true;
            _isTimer = true;
            text.enabled = true;
            text.text = "FOUL";
            text.color = Color.yellow;
            Destroy(collision.gameObject);
            if ( ball._strickcount < 2)
            {
                ball._strickcount += 1;
            }
        }
        else if (_bat.boolcollison ==false)
        {          
            if (bat._rotateZ > 220)
            {
                _isTimer = true;
                text.enabled = true;
                text.text = "BALL";
                text.color = Color.green;
                ball._ballcount += 1;
                Destroy(collision.gameObject);
                
            }
            else if (bat._rotateZ < 220)
            {       
                if(foul == false)
                {
                    _isTimer = true;
                    text.enabled = true;
                    text.text = "STRIKE";
                    text.color = Color.yellow;
                    ball._strickcount += 1;
                    Destroy (collision.gameObject);
                }
                
            }
        }
       
            
    } 
}

