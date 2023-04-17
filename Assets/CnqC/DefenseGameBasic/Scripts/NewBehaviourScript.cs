using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewBehaviourScript : MonoBehaviour
{

    float score;

    private void Awake()
    {
        //Debug.Log("Awake");

        
    }
    private void OnEnable()
    {
        //Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    void Start()
    {

        //Debug.Log("Start");

        //StartCoroutine(DemoCo());

        //score += 10;
        //PlayerPrefs.SetFloat("Score", score);
        //float scoreCopy = PlayerPrefs.GetFloat("Score",0);
        //Debug.Log(scoreCopy); 

        score = PlayerPrefs.GetFloat("Score", 0);
        score += 10;
        PlayerPrefs.SetFloat("Score", score);
        Debug.Log(score);
        
        
        
    }

    /*private IEnumerator DemoCo()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Dang xu ly cong viec 1");
        yield return new WaitForSeconds(2);
        Debug.Log(" Dang xu ly cong viec so 2");
    }*/
     /*private void work()
    {
        Debug.Log("Cong viec duoc thuc hien");
    }*/

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        //Debug.Log(Time.deltaTime);

     
    }

    private void OnDisable()
    {
        //Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        //Debug.Log("OnDestroy");
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        Debug.Log("Da va cham voi nhau"); 
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("2 doi tuong game dang va cham voi nhau");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Hai doi tuong game k con va cham voi nhau");
    } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Da va cham voi nhau");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("2 doi tuong dang va cham voi nhau");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("2 doi tuong game k con va cham voi nhau");
    }*/
}
