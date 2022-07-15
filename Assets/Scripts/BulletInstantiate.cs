using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInstantiate : MonoBehaviour
{
    [SerializeField] private Transform _shootPosition;
    [SerializeField] private GameObject _bullet;
    private void InstantiateBullet()
    {
        Instantiate(_bullet, _shootPosition.position, transform.rotation);
    }
    private void Update()
    {
        if(Input.anyKeyDown)
        {
            InstantiateBullet();

        }
    }
    


}
