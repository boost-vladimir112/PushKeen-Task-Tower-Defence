using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private int health = 10;
    [SerializeField]
    private GameObject TowerBase;

    public int Health { get => health; set => health = value; }

}
