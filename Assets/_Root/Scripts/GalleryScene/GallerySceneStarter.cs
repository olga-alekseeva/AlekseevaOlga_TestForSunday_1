using Tools;
using UnityEngine;

public class GallerySceneStarter : MonoBehaviour
{


    void Start()
    {
        ScreenOrientationSetter screenOrientationSetter = new ScreenOrientationSetter();
        screenOrientationSetter.PortraitScreenOrientation();
    }


}
