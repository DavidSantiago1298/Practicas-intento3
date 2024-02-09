using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeBase : MonoBehaviour
{
    public bool isDead = false;
    protected float health = 100f;
    public float getHealth()
    {
        return health;
    }
}
public struct Quest
{
    public int id;
    public string name;
    public string description;
    public string title;
}
public class Heroe : PersonajeBase
{
    private Quest quest;
    public void setQuest(string _name, string _description, string _title)
    {
        quest.id = Random.Range(0, 10);
        quest.name = _name;
        quest.description = _description;
        quest.title = _title;
    }
    public Quest getQuest()
    {
        return quest;
    }
}
public class EnemigoBase : PersonajeBase
{
    protected float damage = 450;
    public float getDamage()
    {
        return damage;
    }
}
public class Caballero : EnemigoBase
{
    private float powerUp = Random.Range(10, 450);
    public float getPowerUp()
    {
        return damage + powerUp;
    }
}
public class HeroeFuerte : Heroe
{
    public float hability = 300f;
    public float getHability()
    {
        if (getQuest().id == 2)
        {
            return hability - 20.0f;
        }
        return hability;
    }
}
class Accesos : MonoBehaviour
{
    public HeroeFuerte heroeFuerte;
    public Caballero caballero;
    private void Start()
    {
        heroeFuerte = new HeroeFuerte();
        caballero = new Caballero();
        heroeFuerte.setQuest("Quest 1", "El uso de atributos en clases",
       "Clasificacion de atributos, e gran desfio");
        if (!heroeFuerte.isDead && !caballero.isDead)
        {
            if (heroeFuerte.getHealth() >= 51)
            {
                float combatResult = heroeFuerte.getHability() -
               caballero.getDamage();
                Debug.Log("El resultado del combate es: " + combatResult);
            }
            else
            {
                Debug.Log("El heroe tiene muy poca vida, regresa a la base: .Vida:" + heroeFuerte.getHealth());
            }
        }
    }
}

