using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espadas : MonoBehaviour
{
    public Sprite icon;
    public Rarity rarity;
    public Enchantment enchantment;
    public string Name;
    public int Damage;
    public int Durability;
    
    
    
    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = icon;
    }

    public virtual void SetUp(string _name, int _damage, int _durability)
    {
        Name = name;
        Damage = _damage;
        Durability = _durability;
        GetComponent<SpriteRenderer>().sprite = icon;
    }
    public virtual int GetAttack()
    {
        return 0;
    }
    public enum Rarity
    {
        WOOD = 1,
        STONE = 2,
        IRON = 3,
        GOLD = 4,
        DIAMOND = 5,
        NEDERITHE = 6
    }
    public enum Enchantment
    {
        NONE = 0,
        FIRE = 1,
        THROW = 2
    }
}
