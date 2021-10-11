using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{

    [Range(0,12)]
    public int rows;
    [Range(0,12)]
    public int cols;
    public float offset;
    public Vector2 origin;

    public GameObject sprite;
    void Start(){
        SpawnGrid();
    }

    void SpawnGrid()
    {
        for(int x = 0; x < rows; x++){
            for(int y = 0; y < cols; y++){
                //Spawn the grid
                Vector2 spawnPosition = new Vector2(x * offset, y * offset / 2) + origin;
                Instantiate(sprite,spawnPosition, Quaternion.identity);
            }
        }
    }

    void MoveGrid()
    {
        // Move it to the right => when it hits the end of the screen invert movement vice versa; on each iteration add 1 the y offset;

    }
}
