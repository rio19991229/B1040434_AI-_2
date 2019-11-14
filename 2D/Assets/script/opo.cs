using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opo : MonoBehaviour
{
    #region
    // 定義列舉
    // 修飾詞 列舉 列舉名稱 { 列舉內容, .... }
    public enum state
    {
                      // 一般、尚未完成、完成
        normal, notComplete, complete
    }
                      // 使用列舉
                      // 修飾詞 類型 名稱
    public state _state;



    [Header("任務對話")]
    public string sayStart = "嗨,幫我蒐集十顆寶石!";
    public string not_complete = "任務尚未完成!還需要10顆寶石喔!!";
    public string complete = "恭喜你!!任務完成~謝謝你";
    [Header("對話速率")]
    public float talkspeed = 1.5f;
    [Header("任務")]
    public bool mission_complete = false;
    public int count_player = 0;
    public int finish = 10;
    [Header("UI")]
    public GameObject objCanvas;
    public Text textSay;
#endregion

    // 2D 觸發事件
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 如果碰到物件為"狐狸"
        if (collision.name == "狐狸")
        {
            // 畫布.顯示
            //objCanvas.SetActive(true);
            // 文字介面.文字 = 對話1
            //textSay.text = sayStart;
            Say();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Sayout();
    }

    ///<summary>
    ///對話
    ///</summary>
    void Say()
    {
        objCanvas.SetActive(true);
        textSay.text = sayStart;

    }
    ///<summary>
    ///關閉對話
    ///</summary>
    void Sayout()
    {
        objCanvas.SetActive(false);
    }




}