using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxXScale;

    private void Update()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f) * _speed;

        if (transform.localScale.x >= _maxXScale)
            _speed = -_speed;        
        if (transform.localScale.x <= 1)
            _speed = -_speed;
    }
}
