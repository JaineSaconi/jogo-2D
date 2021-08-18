using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCam : MonoBehaviour
{
    public GameObject pc;

    public float offset = 2;

    void Update()
    {
        Vector3 posicao = new Vector3(pc.transform.position.x, pc.transform.position.y+offset, -10);
        this.transform.position = posicao;
    }
}
