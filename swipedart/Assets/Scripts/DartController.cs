using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartController : MonoBehaviour
{
    // ������ �ӵ�, ȸ�� �ӵ� ����
    public float throwingSpeed;
    public float rotateSpeed;
    // ��ư ����������, ��ư �ö����� ��ǥ ���� �� ��ǥ ������ �Ÿ� ����
    public Vector3 leftButtonPosition;
    public Vector3 rightButtonPosition;
    public Vector3 swipeDistance;

    void Start()
    {
        
    }

    void Update()
    {
        // ��ư ���������� Ȯ��
        bool isDown= Input.GetMouseButtonDown(0);
        // ��ư �ö����� Ȯ��
        bool isUp = Input.GetMouseButtonUp(0);
        // ��ư ���������� ���콺 ��ǥ ����
        if (isDown)
        {
            leftButtonPosition = Input.mousePosition;
        }
        // ��ư�� �ö����� ���콺 ��ǥ ���� �� ȸ��,�̵� �ӵ� ���
        else if (isUp)
        {
            rightButtonPosition = Input.mousePosition;
            swipeDistance = rightButtonPosition - leftButtonPosition;
            rotateSpeed = 30f;
            throwingSpeed = swipeDistance.y * 0.002f;
        }
            // ���� ��ǥ�踦 �������� �̵�
            this.transform.Translate(0, throwingSpeed, 0, Space.World);
            Debug.Log(this.transform.position);
            // ���ӿ�����Ʈ ��ǥ�踦 �������� ȸ��
            this.transform.Rotate(0, 0, rotateSpeed, Space.Self);
            Debug.Log(this.transform.position);
            throwingSpeed *= 0.96f;
            rotateSpeed *= 0.96f;

    }
}
