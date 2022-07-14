using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private float _offset;
    [SerializeField] private Camera _camera;

    BulletInstantiate _bulletInstantiate;




    void Update()
    {
        TransformGun();
        PressToShoot();
    }

   
    private void PressToShoot()
    {
        if (Input.anyKeyDown)
        {
            _bulletInstantiate = GetComponent<BulletInstantiate>();
        }
    }

    private void TransformGun()
    {
        Vector3 difference = _camera.ScreenToWorldPoint(Input.mousePosition + transform.position);
        float _rotationZ = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, _rotationZ + _offset);
    }
}

