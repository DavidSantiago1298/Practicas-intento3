using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [Header("Configuration")]
    public List<GameObject> Prefabs;
    public float TimeBetweenSpawns = 3f;
    public float SpawnArea = 5f;

    [Header("Debug")]
    public Vector3 SpawnerPosition;
    public Color color;

    void Start()
    {
        InvokeRepeating("InstantiteRandomObject", 0f, TimeBetweenSpawns);
    }

    public void InstantiateRandomObject()
    {
        // 1.
        Vector3 RandomPosition = Random.insideUnitCircle * SpawnArea;
        RandomPosition.z = 0f;

        // 2.
        GameObject RandomObj = Prefabs[Random.Range(0, Prefabs.Count)];
        GameObject NewObject = Instantiate(RandomObj, SpawnerPosition +
RandomPosition, Quaternion.identity);

        // 3.
        SpriteRenderer spriteRenderer =
NewObject.GetComponent<SpriteRenderer>(); if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color(Random.value, Random.value,
Random.value);
        }

        // 4. 
        NewObject.transform.parent = transform;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(SpawnerPosition, SpawnArea);
    }
}