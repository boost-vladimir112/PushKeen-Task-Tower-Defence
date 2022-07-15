using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : Tower
{
    void OffField()
    {
        if(_currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void OnField()
    {
        _currentHealth = _health;
        gameObject.SetActive(true);
    }
    void Update()
    {
       OffField();
    }
    private void Start()
    {
        _currentHealth = _health;
    }
}
