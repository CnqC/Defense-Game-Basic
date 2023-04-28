using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Tu dong tao ra quai
namespace CnqC.DefenseBasic
{
    public class GameManager : MonoBehaviour
    {

        public float spawnTime; // thoi gian tao ra quai

        public Enemy[] enemyPrefabs;

        private bool m_isGameOver; // check xem la game da done hay chua

        private int m_score;

        public int Score { get => m_score; set => m_score = value; }





        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawmEnemy());
        }

<<<<<<< HEAD
        public bool IsComponentNull()
        {
            return guiMng == null;
        }
       
        public void GameOver()
=======
        // Update is called once per frame 
        void Update()
>>>>>>> parent of 8e9c6fb (Update GamePlay, UI)
        {
            if (m_isGameOver) return; // nếu game kết thúc thì k làm lệnh dưới
            m_isGameOver = true;

            Pref.bestScore = m_score;

            // hiển thị hộp thoại gameover

            if(guiMng.gameOverDiaLog) // nếu gameOverDiaLog != null thì show cái game over ra
                guiMng.gameOverDiaLog.Show(true);
        }

        IEnumerator SpawmEnemy()
        {
            while (!m_isGameOver)
            {
                if (enemyPrefabs != null && enemyPrefabs.Length > 0)
                {
                    int randIdx = Random.Range(0, enemyPrefabs.Length);  // lay ngau nhien lay chi sao trong mang ememiprefab

                    Enemy enemyPrefab = enemyPrefabs[randIdx];
                    if (enemyPrefab)
                    {
                        Instantiate(enemyPrefab, new Vector3(8, 0, 0), Quaternion.identity);
                    }
                }

                yield return new WaitForSeconds(spawnTime);
            }
        }
    }
}
