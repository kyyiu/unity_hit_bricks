using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, 0) * speed * Time.deltaTime);
    }
    // 每秒执行固定次数，默认50次， 可以在prject setting -》time中修改
    private void FixedUpdate()
    {
        
    }
}
