using UnityEngine;
using UnityEngine.Networking;

namespace Assets
{
    public class MyNetworkManager: NetworkManager
    {
        public void MyStartHost()
        {
            Debug.Log(Time.timeSinceLevelLoad + " Starting Host");
            StartHost();
        }

        public override void OnStartHost()
        {
            Debug.Log(Time.timeSinceLevelLoad + " Host Started");
        }

        public override void OnStartClient(NetworkClient myCLient)
        {
            Debug.Log(Time.timeSinceLevelLoad +  " Client Start Requested");
            InvokeRepeating("printDots", 0f, 1);
        }

        public override void OnClientConnect(NetworkConnection myConn)
        {
            Debug.Log(Time.timeSinceLevelLoad + " client is now connected to IP: " + myConn.address);
            CancelInvoke();
        }

        void printDots()
        {
            Debug.Log(".");
        }
    }
}
