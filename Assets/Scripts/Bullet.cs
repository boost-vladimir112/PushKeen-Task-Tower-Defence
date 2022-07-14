using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 10f;

    [SerializeField] private float bulletSpeed = 60f;

    
    Rigidbody2D rb;

    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        BulletLifeTime();
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
    public float BulletSpeed { get => bulletSpeed; set => bulletSpeed = value; }





}
