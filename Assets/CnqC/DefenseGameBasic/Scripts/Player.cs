using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CnqC.DefenseBasic
{
    public class Player : MonoBehaviour, IComponnetChecking
    {
        public float atkRate;

        private float m_curAtkRate; // lưu lại giá trị của biến atkRate trên và giảm dần theo tgian

        private bool m_isAttacked; // kiểm tra ng choi bấm nút tấn công hay chưa
                                   //tạo animator
        private Animator m_anim;

        private bool m_isDead;


        private void Awake()
        {
            m_anim = GetComponent<Animator>();


            m_curAtkRate = atkRate;// lưu lại giá trị của biến atkRate
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (IsComponentNull()) return;
            if (Input.GetMouseButtonDown(0) && !m_isAttacked)
            {
                m_anim.SetBool(Const.ATTACK_ANIM, true);
                m_isAttacked = true; // ng chơi đã bấm nút tấn công
            }

            if (m_isAttacked) // nếu true --> sẽ giảm curAtkRate giảm 1 lượng thời gian giữa 2 fame trong amnation
            {
                m_curAtkRate -= Time.deltaTime;

                if (m_curAtkRate <= 0)
                {
                    m_isAttacked = false;
                    m_curAtkRate = atkRate;
                }
            }
        }

        public void ResetAttackAnim()
        {
            if (IsComponentNull()) return;
             m_anim.SetBool(Const.ATTACK_ANIM, false);
        }

        public bool IsComponentNull()
        {
            return m_anim == null;
        }

        // chuyển trạng thái của player nếu như mà bị con quái đánh dính ---> chết

        // va chạm trigger

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (IsComponentNull()) return;
            if (collision.CompareTag(Const.ENEMY_WEAPON_TAG) && (m_isDead = false))
            {   // ktra con hero chạm phải cái tag tên là Eneny weapon và kèm theo đk là hero chưa chết
                m_anim.SetTrigger(Const.DEAD_ANIM);
                m_isDead = true;
            }
        }
    }  
}
