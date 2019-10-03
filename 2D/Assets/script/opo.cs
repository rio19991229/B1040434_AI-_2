using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opo : MonoBehaviour
{
    [Header("任務對話")]
    public string star = "嗨,能幫助我一個忙嗎?";
    public string not_complete = "任務尚未完成!還需要10顆寶石喔!!";
    public string complete = "恭喜你!!任務完成~謝謝你";
    [Header("對話速率")]
    public float talkspeed = 1.5f;
    [Header("任務")]
    public bool mission_complete=false;
    public int count_player = 0;
    public int finish = 10;


	void Start ()
    {
        Debug.Log(star);
	}
	
	
	void Update ()
    {
		
	}
}
