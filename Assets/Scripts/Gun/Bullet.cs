using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _bulletSpeed = 15f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GreenArea"))
        {
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        transform.Translate(Vector3.up * _bulletSpeed * Time.deltaTime);
        Destroy(gameObject, 0.5f);
    }
}
