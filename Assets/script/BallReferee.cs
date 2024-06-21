using UnityEngine;

public class BallReferee : MonoBehaviour
{
    [SerializeField] Referee _referee;

    GameObject _bat;
    bool collisonbat;
    private void Start()
    {
        _bat = GameObject.FindGameObjectWithTag("bat");
        var bat = _bat.GetComponent<Batcollison>();
        collisonbat = bat.m_boolcollison;
    }

    private void Update()
    {
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collisonbat ==true)
        {
            Debug.Log("aaa");
            _referee.ImageChange(3);
            collisonbat=false;
        }
        else
        {
            _referee.ImageChange(1);
            Destroy(collision.gameObject);
        }
        
    }
}
