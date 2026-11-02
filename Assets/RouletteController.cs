
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    AudioSource audioSource;

    void Start()
    {
        // 將畫面更新率設定為 60 FPS
        Application.targetFrameRate = 60;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 按下滑鼠左鍵設定旋轉速度
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 25;
            audioSource.Play();
        }

        // 讓輪盤依照設定的速度旋轉
        transform.Rotate(0, 0, this.rotSpeed);

        // 讓輪盤逐漸減速
        this.rotSpeed *= 0.98f;

    if (this.rotSpeed < 0.05f)
    {
        this.rotSpeed = 0;
        audioSource.Stop();
    }
    }
}