using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 10;

    private void Update()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}
