using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopHandler : MonoBehaviour
{
    public GameData gameData;

    public void BuyBonys1()
    {
        if (gameData.score >= gameData.cost[0])
        {
            gameData.score -= gameData.cost[0];
            gameData.scoreClick += gameData.bonysClick[0];
            gameData.cost[0] *= GameData.priceMultiplay;
        }

    }
    public void BuyBonys2()
    {
        if (gameData.score >= gameData.cost[1])
        {
            gameData.score -= gameData.cost[1];
            gameData.scoreClick += gameData.bonysClick[1];
            gameData.cost[1] *= GameData.priceMultiplay;
        }

    }
    public void BuyBonys3()
    {
        if (gameData.score >= gameData.cost[2])
        {
            gameData.score -= gameData.cost[2];
            gameData.scoreClick += gameData.bonysClick[2];
            gameData.cost[2] *= GameData.priceMultiplay;
        }

    }
    public void BuyBonys(int id)
    {
        if (gameData.score >= gameData.cost[id])
        {
            gameData.score -= gameData.cost[id];
            gameData.scoreClick += gameData.bonysClick[id];
            gameData.cost[id] *= GameData.priceMultiplay;
        }

    }
}

