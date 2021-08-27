using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoves : MonoBehaviour
{
    public Transform target;

    //player'ýn goruntusune gore kamera konumunu degistirdim
    public Vector3 offset=new Vector3 (0,-3,14);

    private void Update()
    {
        transform.position = target.position + offset;
    }

}
