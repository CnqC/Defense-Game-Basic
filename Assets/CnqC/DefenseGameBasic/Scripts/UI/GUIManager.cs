using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnqC.DefenseBasic;
using UnityEngine.UI;
using TMPro;

public class GUIManager : MonoBehaviour
{
    
    public GameObject homeGUI;
    public GameObject gameGUI;
    public DiaLog gameOverDiaLog;
    public TextMeshProUGUI mainCoinTxt;
    public TextMeshProUGUI gamePlayCoinTxt;


    public void ShowGameGUI(bool isShow)
    {

        // khi mà game Gui hiện thì homegui off và ngược lại 
        if (gameGUI)
            gameGUI.SetActive(isShow);

        if (homeGUI)
            homeGUI.SetActive(!isShow);
    }

    public void UpdateMainCoins()
    {
        if (mainCoinTxt)
            mainCoinTxt.text = Pref.coins.ToString();// phải chuyển sang string để gán cho text

    }

    public void UpdateGamePlayCoins() 
    {
        if (gamePlayCoinTxt)
            gamePlayCoinTxt.text = Pref.coins.ToString();
    }
}
