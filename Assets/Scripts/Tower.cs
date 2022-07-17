using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] private int _health;
    [SerializeField] private int _currentHealth;
   
    public UIHealthBar _healthBar;

    public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
    public int Health { get => _health; set => _health = value; }


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
        ChangeHealthBar();

    }
    private void Start()
    {
        CurrentHealth = Health;
        _healthBar.SetMaxHealth(Health);

    }
    private void Update()
    {
        DestroyBuild();
    }
    private void ChangeHealthBar()
    {
        _healthBar.SetHealth(CurrentHealth);
    }

}
