using UnityEngine;

namespace Tools
{
    public class ScreenOrientationSetter
    {
        public void PortraitScreenOrientation()
        {
            Screen.orientation = UnityEngine.ScreenOrientation.Portrait;
            Screen.orientation = UnityEngine.ScreenOrientation.AutoRotation;

            Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = true;
            Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = false;

        }
        public void AnyScreenOrientation()
        {
            Screen.orientation = UnityEngine.ScreenOrientation.AutoRotation;

            Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = true;
            Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = true;
        }
    }
}
