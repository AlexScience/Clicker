using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuButton : MonoBehaviour
{
    public GameData gameData;

    public void OpenMenuPanel()
    {
        gameData.GameMenuPanel.SetActive(true);
    }

    public void CloseMenuPanel()
    {
        gameData.GameMenuPanel .SetActive(false);

    }
}
