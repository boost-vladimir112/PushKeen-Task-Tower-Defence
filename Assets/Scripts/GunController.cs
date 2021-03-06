using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    void Update()
    {
        TransformGun();
       
    }

    private void TransformGun()
    {
        var mousePosition = Input.mousePosition;
        mousePosition = _camera.ScreenToWorldPoint(mousePosition); 
        var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);
        transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle : -angle);
    }
}


