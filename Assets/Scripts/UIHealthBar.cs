using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIHealthBar : MonoBehaviour
{
    [SerializeField] Tower _playerTower;
    public ProgressBar playerFillHP;
    private void SetMaxHealth()
    {
        playerFillHP.highValue = _playerTower.Health;
        playerFillHP.value = _playerTower.CurrentHealth;
    }
    private void SetHealth()
    {
        playerFillHP.value = _playerTower.CurrentHealth;
    }
    private void Start()
    {
        var _root = GetComponent<UIDocument>().rootVisualElement;
        playerFillHP = _root.Q<ProgressBar>("PlayerFillHp");
        SetMaxHealth();
    }
    private void Update()
    {
        SetHealth();
    }


}
