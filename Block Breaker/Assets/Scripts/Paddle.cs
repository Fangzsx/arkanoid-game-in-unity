using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    //configuration parameters
    [SerializeField] float ScreenWidthUnit =16f;
    [SerializeField] float PaddleMinPos = 1f;
    [SerializeField] float PaddleMaxPos = 15f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXpos = Input.mousePosition.x / Screen.width * ScreenWidthUnit;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mouseXpos, PaddleMinPos, PaddleMaxPos);

        transform.position = paddlePos;
    }
}
