using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] private int health;
    [SerializeField] private int currentHealth;

    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    public int Health { get => health; set => health = value; }

    protected void DestroyBuild()
    {
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
    }
    private void Start()
    {
        CurrentHealth = Health;
    }
    private void Update()
    {
        DestroyBuild();
    }

}
