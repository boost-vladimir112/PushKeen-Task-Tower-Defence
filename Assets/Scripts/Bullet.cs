using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 8f;

    [SerializeField] private float _bulletSpeed = 60f;

    [SerializeField] private int _damage = 2;

    Rigidbody2D rb;

    public int Damage { get => _damage; set => _damage = value; }

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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Tower"))
        {
            other.gameObject.GetComponent<Tower>().TakeDamage(_damage);
        }
    }
    void BulletLifeTime()
    {
        _lifeTime -= Time.deltaTime;
        if(_lifeTime <= 0f)
        {
            Destroy(gameObject);
        }
    }
  
    private void Shot()
    {
        transform.Translate(Vector2.right * _bulletSpeed * Time.deltaTime);
    }




}
