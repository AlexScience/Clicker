using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodShopControler : MonoBehaviour
{

    public GameData gameData;

    public void BuyFoodBonys(int id)
    {
        if (gameData.score >= gameData.cost[id])
        {
            gameData.score -= gameData.cost[id];
            gameData.lvlShopBonys[id] += 1;
            gameData.scoreClick += gameData.bonysClick[id];
            gameData.cost[id] *= GameData.priceMultiplay;
        }

    }
}
