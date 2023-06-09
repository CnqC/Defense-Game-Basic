﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CnqC.DefenseBasic
{
    public class Const
    {
        // LƯU TAG
        public const string PLAYER_TAG = "Player";
        public const string ENEMY_TAG = "Enemy";
        public const string ENEMY_WEAPON_TAG = "EnemyWeapon";


        // phải giống với hệ thống thay đổi trạng thái " Animator"
        public const string ATTACK_ANIM = "Attacking";
        public const string DEAD_ANIM = "Dead";

        // lưu lại hàng số layer
        public const string DEAD_LAYER = "Dead";
        public const string BEST_SCORE_PREF = "best_score";
        public const string PLAYER_PREFIX_PREF = "Player_";
        public const string CUR_PLAYER_ID_PREF = "cur_player_id";
        public const string COIN_PREF = "coins";

        // tạo key lưu music and sound
        public const string MUSIC_VOL_PREF = "music_vol";
        public const string SOUND_VOL_PREF = "sound_vol";
    }
}
