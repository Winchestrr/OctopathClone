using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControler : MonoBehaviour
{
    public Text currentBattleStateText;

    public BattleSystem battleSystem;

    public void Update()
    {
        currentBattleStateText.text = battleSystem.currentState.ToString();
    }

    public void SetUI()
    {

    }
}
