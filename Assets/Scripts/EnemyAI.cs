using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : GunController

{
    [SerializeField] private GameObject _field;
    [SerializeField] private Field field;
    private int randomCount;
    private void Update()
    {
        PressToShoot();
        if (Input.anyKeyDown)
        {
            RandomField();
        }
        
    }
    private void RandomField()
    {
        randomCount = Random.Range(0, 10);
        if(randomCount >= 8)
        {
            ActiveField();
        }
    }
    private void ActiveField()
    {
        _field.SetActive(true);
        field.CurrentHealth = field.Health;
    }


}
