using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] protected int _health;
    [SerializeField] protected int _currentHealth;
    
    protected void DestroyBuild()
    {
        if(_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
    }
    private void Start()
    {
        _currentHealth = _health;
    }
    private void Update()
    {
        DestroyBuild();
    }

}
