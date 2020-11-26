using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callJS : MonoBehaviour
{
    static int value = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Move(int direction)
    {
        switch (direction)
        {
            case 1:
                transform.position = new Vector2(transform.position.x + 1, transform.position.y);
                break;
            case 2:
                transform.position = new Vector2(transform.position.x - 1, transform.position.y);
                break;
            case 3:
                transform.position = new Vector2(transform.position.x, transform.position.y + 1);
                break;
            case 4:
                transform.position = new Vector2(transform.position.x, transform.position.y - 1);
                break;
        }
    }
}
