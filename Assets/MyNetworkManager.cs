﻿using UnityEngine;
using UnityEngine.Networking;

namespace Assets
{
    public class MyNetworkManager: NetworkManager
    {
        public void MyStartHost()
        {
            Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
            StartHost();
        }

        public override void OnStartHost()
        {
            Debug.Log("Host Started at " + Time.timeSinceLevelLoad);
        }
    }
}
