using System.Collections;
using System.Collections.Generic;
using KinematicCharacterController.Examples;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class JumpPad : MonoBehaviour
{
    Collider _col;
    [Header("Settings")]
    public float JumpMultiplier = 2f;
    // Start is called before the first frame update
    void Start()
    {
        _col = this.GetComponent<Collider>();
        _col.isTrigger=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<ExampleCharacterController>())
        {
            other.GetComponent<ExampleCharacterController>().SuperJumpSpeed = JumpMultiplier;
            other.GetComponent<ExampleCharacterController>()._superJumpRequested = true;
        }
    }


}

