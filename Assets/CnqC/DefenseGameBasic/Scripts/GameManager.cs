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


        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawmEnemy());
        }

        // Update is called once per frame 
        void Update()
        {

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
