using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Coin", menuName = "MyTools/Variables/Coin", order = 1)]
public class BilletData : ScriptableObject
{
    public int damage;
    
    public void AddDamage()
    {
        damage++;
    }
}
