using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : Tower
{
    void OffField()
    {
        if(CurrentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
  
    void Update()
    {
       OffField();
    }
    private void Start()
    {
        CurrentHealth = Health;
    }
}
