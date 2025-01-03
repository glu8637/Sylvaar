using UnityEngine;
using UnityEngine.Video; // Import Video namespace

namespace Core
{
    public class GameEndVideoPlayer : MonoBehaviour
    {
        private VideoPlayer videoPlayer;

        // Start is called before the first frame update
        void Start()
        {
            // Get the VideoPlayer component attached to the GameObject
            videoPlayer = GetComponent<VideoPlayer>();
            videoPlayer.targetCamera = UnityEngine.Camera.main; // Fix the namespace issue

            if (videoPlayer == null)
            {
                Debug.LogError("No VideoPlayer component found on this GameObject.");
            }
        }

        // Method to play the video based on the 'isGoodEnd' flag
        public void Play(bool isGoodEnd)
        {
            // Load the video clip based on the 'isGoodEnd' parameter
            string videoPath = isGoodEnd ? "Video/GoodEnding_v2" : "Video/BadEnding_v2";

            // Load the video clip from Resources
            VideoClip videoClip = Resources.Load<VideoClip>(videoPath);

            if (videoClip != null)
            {
                Debug.Log($"Playing video clip: {videoClip.name}");
                // Assign the video clip to the VideoPlayer and play the video
                videoPlayer.clip = videoClip;
                videoPlayer.Play(); // Play the video
            }
            else
            {
                Debug.LogError($"Video clip not found at Resources/{videoPath}");
            }
        }
    }
}