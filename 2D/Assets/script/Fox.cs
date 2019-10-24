﻿using UnityEngine;                  // 引用 Unity API - API 倉庫 功能、工具

public class Fox : MonoBehaviour    // 類別 類別名稱
{
    // 成員：欄位、屬性、方法、事件
    // 修飾詞 類型 名稱 指定 值；
    public int speed = 50;                  // 整數
    public float jump = 2.5f;               // 浮點數
    public string foxName = "狐狸";         // 字串
    public bool pass = false;               // 布林值 - true/false

    private Rigidbody2D r2d;
    private Transform tra;

    // 事件：在特定時間點會以指定頻率執行的方法
    // 開始事件：遊戲開始時執行一次
    private void Start()
    {
        // 泛型 <T>
        r2d = GetComponent<Rigidbody2D>();
        tra = GetComponent<Transform>();
    }
    //Debug.Log(Input.GetAxis("Horizontal"));
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) tra.eulerAngles = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.A)) tra.eulerAngles = new Vector3(0, 180, 0);
    }
    private void FixedUpdate()
    {
        r2d.AddForce(new Vector2(speed * (Input.GetAxis("Horizontal")), 0));
        
    }
}
