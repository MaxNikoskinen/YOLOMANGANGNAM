﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private SpriteRenderer theSR;
    //public GameObject player;

    private void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        theSR.flipX = true;
    }

    private void LateUpdate()
    {
        transform.LookAt(PlayerMovement.instance.transform.position, -Vector3.forward);
        //transform.LookAt(player.transform.position);
        //transform.forward = Camera.main.transform.forward;
    }
}
