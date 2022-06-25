using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameData gameData;

    public void OpenShopPanel()
    {
        gameData.shopPanel.SetActive(true);
    }

    public void CloseShopPanel()
    {
        gameData.shopPanel.SetActive(false);

    }
}
