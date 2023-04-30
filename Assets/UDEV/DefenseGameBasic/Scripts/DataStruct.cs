using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// giữ những định nghĩa cấu trúc trong game

namespace CnqC.DefenseBasic
{ // để hiện những dữ liệu trong 1 class xuất nằm ở ngoài inspector thì phải bất 1 tiến ích như sau: 
    [System.Serializable]
    public class ShopItem
    {
        public Player palyerPrefab;
        public int price; // giá mua nhân vật
        public Sprite previewImg; // skin
        
    }
  
}