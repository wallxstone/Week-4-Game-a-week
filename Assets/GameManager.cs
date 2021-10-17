using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton Instance
    public static GameManager current;
    void Awake() => current = this;
    #endregion

    public int currentWaves;
    public bool waveCleared;
    public List<GameObject> enemiesSpawned;
    void OnEnable(){
        currentWaves = 0;
        waveCleared = false;
    }
    void Update(){
        if(enemiesSpawned.Count <= 0) {
            waveCleared = true;
        }
        if(waveCleared = true) {
            currentWaves++;
            waveCleared = false;
        }
    }

    //creating scoring system soon;
}
