using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("들어간 물체는 other");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("나간 물체는 other");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("안에 있는 물체는 other");
    }
}
