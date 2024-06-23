using UnityEngine;

public class BallReferee : MonoBehaviour
{
    [SerializeField] Referee _referee;

    Batcollison _bat;
    Out ball;
    private void Start()
    {
        _bat = GameObject.Find("baseball_bat").GetComponent<Batcollison>();
         ball = GameObject.Find("Gamemanager").GetComponent<Out>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_bat.boolcollison ==true)
        {
            Debug.Log("aaa");
            _referee.ImageChange(3);
            _bat.boolcollison=false;
            
        }
        else
        {
            _referee.ImageChange(1);
            Destroy(collision.gameObject);
            ball._ballcount +=1;
        }
        
    }
}
