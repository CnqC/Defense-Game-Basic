using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CnqC.DefenseBasic;

public class DiaLog : MonoBehaviour
{
    [SerializeField]
    public Text titleTxt; 
    public Text contentTxt;

    public virtual void Show(bool isShow)
    {
        gameObject.SetActive(isShow); // setActive dung de ẩn cái tham số truyền vào --> phụ thuộc vào isShow


    }

    public virtual void UpdateDiaLog(string title, string content)
    {
        if (titleTxt)
            titleTxt.text = content;

        if (contentTxt)
            contentTxt.text = content;

    }

    public virtual void UpdateDiaLog()
    {

    }

    public virtual void Close()
    {
        gameObject.SetActive(false); // ẩn cái đối tượng nào nếu set chung vs hàm này
    }

}
    
