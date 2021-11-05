using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitScale : MonoBehaviour
{
    public float size = 0.05f;

    void Update()
    {
        transform.localScale += new Vector3(size, size, 1) * Time.deltaTime;
    }

}
