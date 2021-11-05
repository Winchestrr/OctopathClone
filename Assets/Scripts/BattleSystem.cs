using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
    public BattleState currentState;

    public GameObject[] playerPrefabs;
    public GameObject[] enemyPrefabs;

    public Transform[] playerBattleStations;
    public Transform[] enemyBattleStations;

    public void Start()
    {
        currentState = BattleState.START;

        SetupBattle();
    }

    public void SetupBattle()
    {
        for(int i = 0; i < playerPrefabs.Length; i++)
        {
            Instantiate(playerPrefabs[i], playerBattleStations[i]);
        }
        for (int i = 0; i < enemyPrefabs.Length; i++)
        {
            Instantiate(enemyPrefabs[i], enemyBattleStations[i]);
        }
    }    
}
