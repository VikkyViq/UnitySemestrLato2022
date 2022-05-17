using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
       MoveDuck();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Ducky Duck game");
        Debug.Log("Move your player with WSAD or arrow keys");
        Debug.Log("Dont hit annything and get to the bread");
    }
    
    void MoveDuck()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
