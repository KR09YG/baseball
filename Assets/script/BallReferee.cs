using UnityEngine;

public class BallReferee : MonoBehaviour
{
    [SerializeField] Referee _referee;

    Batcollison _bat;
    private void Start()
    {
        _bat = GameObject.Find("baseball_bat").GetComponent<Batcollison>();
;       
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
        }
        
    }
}
