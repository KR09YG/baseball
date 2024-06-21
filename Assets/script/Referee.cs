using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Referee : MonoBehaviour
{
    [SerializeField] Sprite[] _images;
    [SerializeField] Image _refereeImage;
    float _timer;
    bool _isTimer;
    private void Start()
    {
        ImageChange(0);
    }

    private void Update()
    {
        if (_isTimer)
        {
            _timer += Time.deltaTime;
            if (_timer > 1)
            {
                _timer = 0;
                _isTimer = false;
                _refereeImage.enabled = false;
            }
        }
    }

    public void ImageChange(int imageIndex)
    {
        _isTimer = true;
        _refereeImage.enabled = true;
        _refereeImage.sprite = _images[imageIndex];
    }
}
