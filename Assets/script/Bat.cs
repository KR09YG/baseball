using Unity.VisualScripting;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] float _batSpeed;
    //private Transform _transform = default;
    public float _rotateZ = 0f;
    bool _isSwing;
    [SerializeField] float _interval = 1f;
    float _timer;
    [SerializeField] bool m_generateOnStart = true;
    [SerializeField] GameObject gameObject1;
    private void Awake()
    {
        if (m_generateOnStart)
        {
            _timer = _interval;
        }
        //_transform = GetComponent<Transform>();
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if ( _rotateZ == 1f )
        {
            _timer = 0f;
        }
        if (Input.GetKey(KeyCode.Return))
        {
            if (_timer > _interval)
            {
                
                if (_rotateZ <= 220)
                {
                    _rotateZ += Time.deltaTime + _batSpeed;
                    transform.localEulerAngles = new(transform.localEulerAngles.x, transform.localEulerAngles.y, _rotateZ);
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.Return))
        {
            _isSwing = true;
        }
        if (_isSwing == true)
        {
            if (_rotateZ > 0)
            {
                _rotateZ -= Time.deltaTime + _batSpeed;
                transform.localEulerAngles
                    = new(transform.localEulerAngles.x, transform.localEulerAngles.y, _rotateZ);
            }
            else 
            { 
                _isSwing = false;
                
            }
           
        }
        if (_rotateZ > 220)
        {
            gameObject1.SetActive(false);
        }
        else if (_rotateZ < 220)
        {
            gameObject1.SetActive(true);
        }
    }
}
