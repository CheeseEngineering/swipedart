using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartController : MonoBehaviour
{
    // 던지는 속도, 회전 속도 변수
    public float throwingSpeed;
    public float rotateSpeed;
    // 버튼 내려갔을때, 버튼 올라갔을때 좌표 변수 및 좌표 사이의 거리 변수
    public Vector3 leftButtonPosition;
    public Vector3 rightButtonPosition;
    public Vector3 swipeDistance;

    void Start()
    {
        
    }

    void Update()
    {
        // 버튼 내려갔을때 확인
        bool isDown= Input.GetMouseButtonDown(0);
        // 버튼 올라갔을때 확인
        bool isUp = Input.GetMouseButtonUp(0);
        // 버튼 내려갔을때 마우스 좌표 저장
        if (isDown)
        {
            leftButtonPosition = Input.mousePosition;
        }
        // 버튼이 올라갔을때 마우스 좌표 저장 및 회전,이동 속도 계산
        else if (isUp)
        {
            rightButtonPosition = Input.mousePosition;
            swipeDistance = rightButtonPosition - leftButtonPosition;
            rotateSpeed = 30f;
            throwingSpeed = swipeDistance.y * 0.002f;
        }
            // 월드 좌표계를 기준으로 이동
            this.transform.Translate(0, throwingSpeed, 0, Space.World);
            Debug.Log(this.transform.position);
            // 게임오브젝트 좌표계를 기준으로 회전
            this.transform.Rotate(0, 0, rotateSpeed, Space.Self);
            Debug.Log(this.transform.position);
            throwingSpeed *= 0.96f;
            rotateSpeed *= 0.96f;

    }
}
