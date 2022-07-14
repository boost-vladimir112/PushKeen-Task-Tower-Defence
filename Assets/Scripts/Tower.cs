using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private int _health = 6;


    Bullet bullet;
    
    
    private void EndGame()
    {
        if(_health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
    private void Update()
    {
        EndGame();
    }

}
