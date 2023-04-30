using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnqC.DefenseBasic;
using UnityEngine.UI;
using TMPro;


public class GameOverDiaLog : DiaLog
{
    public TextMeshProUGUI BestScoreText;

    public override void Show(bool isShow)
    {
        base.Show(isShow);

        if (BestScoreText)
            BestScoreText.text = Pref.bestScore.ToString("0000");
    }
}
