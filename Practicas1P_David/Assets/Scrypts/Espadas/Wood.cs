using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : Espadas
{
    // Start is called before the first frame update
    void Start()
    {
        SetUp("Madera", 4, 59); 
    }

    public override int GetAttack()
    {
        int attackResult = 0;
        switch (enchantment)
        {
            case Enchantment.NONE:
                break;
            case Enchantment.FIRE:
                attackResult = 2;
                break;
            case Enchantment.THROW:
                attackResult = 4;
                break;
            default:
                break;
        }
        Damage *= attackResult;
        return Damage;
    }
}
