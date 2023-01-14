using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeGameController : MonoBehaviour
{
    [Header("Fake Platform Object")]
    public GameObject FakePlatform;
    float pos = 0;
    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            SpawnFakePlatforms();
        }
    }

    void SpawnFakePlatforms()
    {
        Instantiate(FakePlatform, new Vector3(Random.value * 10 - 5f, pos, 1.5f), Quaternion.identity);
        pos += 2.5f;
    }

}