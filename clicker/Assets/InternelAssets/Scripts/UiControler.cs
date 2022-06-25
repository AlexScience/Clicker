using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UiControler : MonoBehaviour
{
    public GameData gameData;

    private void Update()
    {
        for (int i = 0; i < gameData.scoresText.Length; i++)
        {
            gameData.scoresText[i].text = $"Score: {gameData.score}\nSec/{gameData.scoreClick}";
        }

        for (int i = 0; i < 5; i++)
        {
            gameData.lvlShopText[i].text = $"Level: {gameData.lvlShopBonys[i]}";
            gameData.costShopText[i].text = $"Cost:{gameData.cost[i]}";
            gameData.bonysShopText[i].text = $"Bonys:{gameData.bonysClick[i]}";
        }
    }
}
