using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField]
    protected string Name = "Enemy";
    [SerializeField]
    protected int Health = 100;
    [SerializeField]
    protected List<string> Loot;

    public virtual void Init()
    {
        Loot = new List<string>();
    }

    public virtual void AddLoot(string Item)
    {
        Loot.Add(Item);
    }

    public virtual List<string> GetLoot()
    {
        return Loot;
    }

    public virtual string GetName()
    {
        return Name;
    }

    public virtual int GetHealth()
    {
        return Health;
    }
}
