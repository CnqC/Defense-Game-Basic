using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnqC.DefenseBasic;

public  static class Pref // xử lý dữ liệu xuống máy người chơi 
{
  public static int bestScore // lưu điểm số cao nhất ng cơi
    {
        set
        {
            int oldBestScore = PlayerPrefs.GetInt(Const.BEST_SCORE_PREF,0);// 0 là giá trị bắt đầu

            if (oldBestScore < value) // nhỏ hơn giá trị mà ta đã truyền vào thằng bestscore
                PlayerPrefs.SetInt(Const.BEST_SCORE_PREF, value);
         }

        get => PlayerPrefs.GetInt(Const.BEST_SCORE_PREF,0); // lấy điểm số cao nhất trong máy ng dùng

    }
        public static int curPlayerId // sẽ lưu nhiều Id của nhiều ng chơi
    {
        set => PlayerPrefs.SetInt(Const.CUR_PLAYER_ID_PREF, value);

        get => PlayerPrefs.GetInt(Const.CUR_PLAYER_ID_PREF, 0);
    }

    public static int coins // lấy ra coins
    {
        set => PlayerPrefs.SetInt(Const.COIN_PREF, value);
        get => PlayerPrefs.GetInt(Const.COIN_PREF, 0);
    }

    public static float musicVol // lưu âm lương nhạc xuống máy ng dùng
    {
        set => PlayerPrefs.SetFloat(Const.MUSIC_VOL_PREF, value);
        get => PlayerPrefs.GetFloat(Const.MUSIC_VOL_PREF, 0);
    }

    public static float soundVol // lưu âm lương chính xuống máy ng dùng
    {
        set => PlayerPrefs.SetFloat(Const.SOUND_VOL_PREF, value);
        get => PlayerPrefs.GetFloat(Const.SOUND_VOL_PREF, 0);
    }

    public static void setBool(string key, bool value) // phương thức để thằng Playerpref làm với lại các gái trị true/false
    {
        if (value) // value == true
            PlayerPrefs.SetInt(key, 1);
        else
            PlayerPrefs.SetInt(key, 0);
    }

    public static bool GetBool(string key)
    {
        int check = PlayerPrefs.GetInt(key);
        if (check == 0)
            return false;
        if (check == 1)
            return true;

        return false;
    }
}
