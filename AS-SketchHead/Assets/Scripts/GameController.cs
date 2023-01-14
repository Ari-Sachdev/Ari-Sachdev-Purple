using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;
    [Header("Platform Object")]
    public GameObject platform;
    float pos = 0;
    // Start is called before the first frame update

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }
    void Start()
    {
        for (int i = 0; i< 1000; i++)
        {
            SpawnPlatforms();
        }
    }

    void SpawnPlatforms()
    {
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 1.5f), Quaternion.identity);
        pos += 2.5f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
