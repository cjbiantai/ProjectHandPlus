﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NetworkManager.CreateInstance();
        MyFacade.GetInstance().SendNotification(MyFacade.StartUp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}