﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandeirascript : MonoBehaviour
{
    public static bandeirascript b;
    private bool isready;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(espera());
    }

    // Update is called once per frame
    void Update()
    {
        if(isready == true)
        {
            if (final.f.isPlayer1 == true && final.f.flagV_captured == true)
            {
                GetComponent<Rigidbody>().MovePosition(final.f.transform.position);
                Debug.Log("reveillon");
            }
        }
       

        
       
       

    }

    IEnumerator espera()
    {
        yield return new WaitForSeconds(1f);
        isready = true;
    }




}