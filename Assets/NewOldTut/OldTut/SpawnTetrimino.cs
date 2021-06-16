using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTetrimino : MonoBehaviour
{
    public GameObject[] Tetrominoes;
    private int comingUp;

    // Start is called before the first frame update
    void Start()
    {
        comingUp = Random.Range(0, Tetrominoes.Length);
        Debug.Log(comingUp);
        newTetromino();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void newTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
        comingUp = Random.Range(0, Tetrominoes.Length);
    }
}
