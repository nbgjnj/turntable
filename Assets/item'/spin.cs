using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    private bool isRotating = false;

    // 輪盤每秒旋轉的速度
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // 如果滑鼠左鍵被點擊
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
        }

        // 如果空白鍵被按下
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isRotating = false;
        }

        // 根據 isRotating 變數來旋轉輪盤
        if (isRotating)
        {
            // 以指定的速度旋轉輪盤
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }
}