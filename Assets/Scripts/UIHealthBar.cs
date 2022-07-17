using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIHealthBar : MonoBehaviour
{
    public ProgressBar playerFillHP;
    public void SetMaxHealth(int health)
    {
        playerFillHP.highValue = health;
        playerFillHP.value = health;
    }
    public void SetHealth(int health)
    {
        playerFillHP.value = health;
    }
    private void Start()
    {
        var _root = GetComponent<UIDocument>().rootVisualElement;
        playerFillHP = _root.Q<ProgressBar>("PlayerFillHp");
        
    }


}
