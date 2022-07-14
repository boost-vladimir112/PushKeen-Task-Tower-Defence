using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 3f;

    [SerializeField] private float bulletSpeed = 60f;

    [SerializeField] private GameObject _bullet;

    Rigidbody2D rb;

    

    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        BulletLifeTime();
        Shot();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void BulletLifeTime()
    {
        if(_lifeTime <= 0f)
        {
            Destroy(gameObject);
        }
    }
  
    private void Shot()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
    }




}
