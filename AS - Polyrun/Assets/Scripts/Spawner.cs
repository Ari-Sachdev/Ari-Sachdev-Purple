using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("ChallengeObj Game Object1")]
    public GameObject challengObject1;

    [Header("Default spawn delay time")]
    public float spawnDelay = 1f;
    [Header("Default spawn time")]
    public float spawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }
 
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, -2.75f, 0);
    }

    void InstantiateObjects()
    {
        Instantiate(challengObject1, transform.position, transform.rotation);
        
    }
}
