﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CnqC.DefenseBasic
{

    public class Enemy : MonoBehaviour
    {
        public float speed;
        public float atkDistance;

        private Animator m_amin;
        private Rigidbody2D m_rb;
        private Player m_player;
        

        private void Awake()
        {
            m_amin = GetComponent<Animator>();
            m_rb = GetComponent<Rigidbody2D>();
            m_player = FindObjectOfType<Player>();
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (m_rb == null || m_player == null) return; // nếu 2 cái đó rỗng ==> tắt hết câu lệnh ở dưới

            if (Vector2.Distance(m_player.transform.position, transform.position)<= atkDistance){

              
                    m_amin.SetBool(Const.ATTACK_ANIM, true);// khi con yêu quái gần player, nó sẽ chuyển sang trạng thái tấn công

                m_rb.velocity = Vector2.zero; // (0.0) 
            }
            else
            {
         
                    m_rb.velocity = new Vector2(-speed, m_rb.velocity.y);
            }
        }


            

    }
}
