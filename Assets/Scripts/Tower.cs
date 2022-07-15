using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] protected int _health;
    
    protected void DestroyBuild()
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
        DestroyBuild();
    }

}
