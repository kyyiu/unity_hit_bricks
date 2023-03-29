using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        // ͨ��Ԥ���崴����Ϸ����
        GameObject.Instantiate(ball, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        // �������
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Instantiate(ball, transform.position, transform.rotation)
                .GetComponent<Rigidbody>()
                .velocity = Vector3.forward*30;
        }
    }
}
