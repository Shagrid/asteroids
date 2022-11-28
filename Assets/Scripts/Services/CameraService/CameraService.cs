using UnityEngine;

namespace Asteroids
{
    public class CameraServices : Service
    {
        
        public Camera CameraMain { get; private set; }

        public CameraServices()
        {
            CameraMain = Camera.main;
        }

        
        public void SetCamera(Camera camera)
        {
            CameraMain.gameObject.SetActive(false);
            CameraMain = camera;
            CameraMain.gameObject.SetActive(true);
        }
        
        
    }
}