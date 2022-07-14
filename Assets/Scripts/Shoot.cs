using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _shootPosition;
    [SerializeField] private GameObject _bullet;

  


    private void InstantiateBullet()
    {
        Instantiate(_bullet, _shootPosition.position, transform.rotation);
    }
    private void PressToShoot()
    {
        if (Input.anyKeyDown)
        {
            InstantiateBullet();
        }
    }
    private void Update()
    {
        PressToShoot();
        Shot();
    }
    private void Shot()
    {
        
    }
}
