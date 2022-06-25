using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerHendler : MonoBehaviour
{
    public GameData gameData;
    public void OnClick()
    {
        gameData.score += gameData.scoreClick;
     
    }

}
