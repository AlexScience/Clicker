using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    [Header("Shops")]
    public Text[] lvlShopText;
    public Text[] costShopText;
    public Text[] bonysShopText;
    public double[] cost;
    public double[] bonysClick;
    public const double priceMultiplay = 1.07d;
    public Sprite[] foodIcon;
    public int[] lvlShopBonys;


    [Header("Panels")]
    public GameObject shopPanel;
    public GameObject GameMenuPanel;
    public GameObject SettingsPanel;

    [Header("Score")]
    public double score;
    public double scoreClick;
    public Text[] scoresText;



}
