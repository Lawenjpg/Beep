using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    GameObject PlayerObj;
    Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObj = GameObject.Find("RattleSnake");
        cameraOffset = new Vector3(0, 2, -3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerObj.transform.position + cameraOffset;
    }
}
