using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public Vector3 pos = new Vector3(0f, 0f, 0f);
    public Transform RattleSnake;
    public float tileamount = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            RattleSnake.position += new Vector3(-tileamount, 0f, 0f);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            RattleSnake.position += new Vector3(tileamount, 0f, 0f);



        }
        if (Input.GetKeyDown("s"))
        {
            RattleSnake.position -= new Vector3(0f, 0f, tileamount);

        }
        if (Input.GetKeyDown("w"))
        {
            RattleSnake.position -= new Vector3(0f, 0f, -tileamount);
        }

    }
}
