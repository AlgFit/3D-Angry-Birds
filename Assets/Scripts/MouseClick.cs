﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Explosion explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetMouseButtonDown(0))
        { 
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                    
                    Explosion explosion = hit.transform.GetComponent<Explosion>();
                    explosion.explode();
                    //explosion = new Explosion(hit.transform.gameObject);
                    //explosion.explode();
                    
                }
            }
        }*/
    }
    /*private void PrintName(GameObject go)
    {
            print(go.name);
    }*/
}
