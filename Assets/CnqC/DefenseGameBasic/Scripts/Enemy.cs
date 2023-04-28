using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CnqC.DefenseBasic
{

    public class Enemy : MonoBehaviour, IComponnetChecking
    {
        public float speed;
        public float atkDistance;
        public int minCoinBonus;
        public int maxCoinBonus;

        private Animator m_amin;
        private Rigidbody2D m_rb;
        private Player m_player;

        private bool m_isDead; // ktr xem enemy da chet chua

        private GameManager m_gm;

        public bool IsComponentNull()
        {
            return m_amin == null || m_player == null || m_rb == null || m_gm == null;
        }

        private void Awake()
        {
            m_amin = GetComponent<Animator>();
            m_rb = GetComponent<Rigidbody2D>();
            m_player = FindObjectOfType<Player>();
            m_gm = FindObjectOfType<GameManager>();
        }
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            // if (m_rb == null || m_player == null) return; // nếu 2 cái đó rỗng ==> tắt hết câu lệnh ở dưới

            if (IsComponentNull()) return; // check trên file trên nếu mà  hàm iscomponent null thì tất cả câu lệnh dưới sẽ null

            float distoPlayer = Vector2.Distance(m_player.transform.position, transform.position);

            if (distoPlayer <= atkDistance){

              
                m_amin.SetBool(Const.ATTACK_ANIM, true);// khi con yêu quái gần player, nó sẽ chuyển sang trạng thái tấn công

                m_rb.velocity = Vector2.zero; // (0.0) 
            }       
            else
            {
         
                    m_rb.velocity = new Vector2(-speed, m_rb.velocity.y);
            }
        }


            
        public void Die()
        {
            if (IsComponentNull() || m_isDead) return;

            m_isDead = true;
            m_amin.SetTrigger(Const.DEAD_ANIM);
            m_rb.velocity = Vector2.zero; // dừng vận tốc

            gameObject.layer = LayerMask.NameToLayer(Const.DEAD_ANIM);

           // tăng score lên 1
                m_gm.Score++;

            // khi quai chet se nhan dc 1 khoang vang ngau nhien

            int coinbonus = Random.Range(minCoinBonus, maxCoinBonus);
            Pref.coins += coinbonus;

            // người chơi giết dc quỷ -> cập nhap655 cái coins trên gameplayGUi
            if (m_gm.guiMng)
                m_gm.guiMng.UpdateGamePlayCoins();

            Destroy(gameObject, 2f); // huy con quái chết trong 2s, biến gameObject là nó nhận dc từ lớp Monobihavior


        }
    }
}
