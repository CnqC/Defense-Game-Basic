using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnqC.DefenseBasic;

public class ShopManager : MonoBehaviour
{
    public ShopItem[] items;

    // Start is called before the first frame update
    void Start()
    {
        Init(); 
    }

    private void Init() // khởi tạo dữ liệu ban đầu khi lưu dưới máy ng dùng cho shop
    {
        if (items == null || items.Length <= 0) return;

        for (int i = 0; i < items.Length; i++)
        {
            var item = items[i];
            string dataKey = Const.PLAYER_PREFIX_PREF + i; //Player 0,player1 ( skin của nhân vật)

            if (item != null)
            {
                if (i == 0) // skin mặc định
                    Pref.setBool(dataKey, true);
                else
                {
                    if (PlayerPrefs.HasKey(dataKey)) // ktra xem dưới máy ng dùng đã có datakey chua ( dữ liệu chưa)
                        Pref.setBool(dataKey, false); // các player khác chưa dc mở khóa ra
                }
            }
        }
    }
}   
