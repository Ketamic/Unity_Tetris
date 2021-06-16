using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static float dropTime = 0.9f;
    public static float quickDropTikme = 0.05f;
    public static int width = 10;
    public static int height = 20;
    GameObject[] blocks;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBlock()
    {
        float guess = Random.Range(0, 1f);
        guess *= blocks.Length;
        Instantiate(blocks[Mathf.FloorToInt(guess)]);
    }
}
