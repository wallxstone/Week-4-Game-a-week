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
    public bool spawnNewWave = true;
    public bool spawnBoss = false;
    public Vector2 origin;

    public GameObject sprite;
    public GameObject boss;
    GameObject clone;

    void Update(){
        if(GameManager.current.enemiesSpawned.Count <= 0) {spawnNewWave = true;}

        if(spawnNewWave){
            SpawnGrid();
            spawnNewWave = false;
        }
        if(GameManager.current.currentWaves == 4)
        {
            spawnBoss  = true;
        }
        if(spawnBoss){ SpawnBoss();}
        
    }

    void SpawnGrid()
    {
        for(int x = 0; x < rows; x++){
            for(int y = 0; y < cols; y++){
                //Spawn the grid
                Vector2 spawnPosition = new Vector2(x * offset, y * offset / 2) + origin;
                clone = Instantiate(sprite,spawnPosition, Quaternion.identity);
                GameManager.current.enemiesSpawned.Add(clone);
            }
        }
    }

    void SpawnBoss()
    {
        Vector2 spawnPosition = new Vector2(offset, offset) + origin;
        Instantiate(boss, spawnPosition, Quaternion.identity);
        spawnBoss = false;
    }
}
