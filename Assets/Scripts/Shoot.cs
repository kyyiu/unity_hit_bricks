using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        // 通过预制体创建游戏物体
        GameObject.Instantiate(ball, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        // 按下左键
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Instantiate(ball, transform.position, transform.rotation)
                .GetComponent<Rigidbody>()
                .velocity = Vector3.forward*30;
        }
    }
}
