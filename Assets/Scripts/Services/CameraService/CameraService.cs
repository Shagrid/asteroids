using UnityEngine;

namespace Asteroids
{
    public class CameraService : Service
    {
        
        public Camera CameraMain { get; private set; }

        public CameraService()
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