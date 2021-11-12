using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResPosition : MonoBehaviour
{
    Vector3 startingPos;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.localPosition;
    }

    private void OnTriggerEnter(Collider other){
        transform.localPosition = startingPos;
    }

}
