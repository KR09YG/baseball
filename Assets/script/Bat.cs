using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] float _batSpeed;
    //private Transform _transform = default;
    private float _rotateZ = 0f;
    bool _isSwing;
    float m_timer;
    [SerializeField] bool m_generateOnStart = true;
    private void Awake()
    {
        
        //_transform = GetComponent<Transform>();
    }

    private void Update()
    {
        
            
            if (Input.GetKey(KeyCode.Return))
        {
            

                if (_rotateZ < 220)
                {
                    _rotateZ += Time.deltaTime + _batSpeed;
                    transform.localEulerAngles = new(transform.localEulerAngles.x, transform.localEulerAngles.y, _rotateZ);
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
    }
}
