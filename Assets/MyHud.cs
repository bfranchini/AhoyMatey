using UnityEngine;
using UnityEngine.Networking;

namespace Assets
{
    public class MyHud: MonoBehaviour
    {
        private NetworkManager networkManager;

        void Start()
        {
            networkManager = GetComponent<NetworkManager>();
        }

        public void MyStartHost()
        {
            Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
            networkManager.StartHost();
        }

        void OnStartHost()
        {
            Debug.Log("Host Started at " + Time.timeSinceLevelLoad);
        }
    }
}
