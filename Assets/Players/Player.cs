using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Players
{
    public class Player : NetworkBehaviour
    {
        private Vector3 inputValue;

        // Use this for initialization
        void Start () {
		
        }

        public override void OnStartLocalPlayer()
        {
            var localCamera = GetComponentInChildren<Camera>();
            localCamera.enabled = true;
        }
        

        // Update is called once per frame
        void Update ()
        {
            if (!isLocalPlayer)
                return;

            inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
            //inputValue.y = CrossPlatformInputManager.GetAxis("Vertical");
            inputValue.y = 0f;
            inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");
            transform.Translate(inputValue);
        }
    }
}
