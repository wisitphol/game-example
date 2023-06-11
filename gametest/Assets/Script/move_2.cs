using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_2 : MonoBehaviour
{
    float dirX , moveSpeed2 = 4f;
    bool moveRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 29f)
            moveRight = false;
        if(transform.position.x < 26f)
            moveRight = true;

        if(moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed2 * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed2 * Time.deltaTime, transform.position.y);
    }
}
