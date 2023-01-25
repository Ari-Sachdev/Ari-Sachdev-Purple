using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [Header("Spawn Cube Object")]
    public GameObject spawnCube;
    [Header("Default Difficulty")]
    public float diffculty = 40f;
    float spawn;
    
    void Update()
    {
        spawn = diffculty * Time.deltaTime;
        diffculty = Time.deltaTime * 4f;
        while (spawn > 0)
        {
            spawn -= 1;
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40f - 20f, 0, Random.value * 40f - 20f);
            Quaternion qRotation = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
            GameObject createObject = Instantiate(spawnCube, v3Pos, qRotation);
        }
    }
}
