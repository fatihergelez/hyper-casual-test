using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    [SerializeField] private GameObject _playerGun;
    [SerializeField] private GameObject _gunBullet;
    [SerializeField] private Transform _bulletSpawn;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gate"))
        {        
            _playerGun.SetActive(true);
            InvokeRepeating("bullet", 0.2f, 0.5f);
        }
    }
    void bullet()
    {
       Instantiate(_gunBullet, new Vector3(_bulletSpawn.transform.position.x, 0.001f, _bulletSpawn.transform.position.z), Quaternion.Euler(-6.538f, 94.054f, 86.933f));             
    }


}  
