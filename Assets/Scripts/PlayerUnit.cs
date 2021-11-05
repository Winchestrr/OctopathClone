using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public string unitName;
    public string unitType;
    public int unitLevel;

    public int attackDamage;
    public int abilityPower;
    public int speed;
    public int attackDefense;
    public int abilityDefense;

    public int critChance;
    public int missChance;

    public int maxHP;
    public int currentHP;

    public void Attack()
    {
        int tempRandom = Random.Range(1, 100);
        if(tempRandom < missChance)
        {

        }
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if(currentHP <= 0)
        {
            currentHP = 0;
        }
        else
        {
            
        }
    }
}
