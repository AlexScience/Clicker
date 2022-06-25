using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public GameData gameData;

    public void OpenSettingsPanel()
    {
        gameData.SettingsPanel .SetActive(true);
    }

    public void CloseShopPanel()
    {
        gameData.SettingsPanel.SetActive(false);

    }
}
