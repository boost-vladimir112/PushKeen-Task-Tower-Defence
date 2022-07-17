using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIHealthBar : MonoBehaviour
{
    [SerializeField] Tower _playerTower;
    [SerializeField] Tower _enemyTower;
    public ProgressBar playerFillHP;
    public ProgressBar enemyFillHP;
    private void SetMaxHealth()
    {
        playerFillHP.highValue = _playerTower.Health;
        playerFillHP.value = _playerTower.CurrentHealth;

        enemyFillHP.highValue = _enemyTower.Health;
        enemyFillHP.value = _enemyTower.CurrentHealth;
    }
    private void SetHealth()
    {
        playerFillHP.value = _playerTower.CurrentHealth;
        enemyFillHP.value= _enemyTower.CurrentHealth;
    }
    private void Start()
    {
        var _root = GetComponent<UIDocument>().rootVisualElement;
        playerFillHP = _root.Q<ProgressBar>("PlayerFillHp");
        enemyFillHP = _root.Q<ProgressBar>("EnemyFillHp");
        SetMaxHealth();
    }
    private void Update()
    {
        SetHealth();
    }


}
