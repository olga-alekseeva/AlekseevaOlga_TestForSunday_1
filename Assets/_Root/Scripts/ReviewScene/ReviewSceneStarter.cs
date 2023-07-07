using System.Collections;
using System.Collections.Generic;
using Tools;
using UnityEngine;

public class ReviewSceneStarter : MonoBehaviour
{
    void Start()
    {
        ScreenOrientationSetter screenOrientationSetter = new ScreenOrientationSetter();
        screenOrientationSetter.AnyScreenOrientation();

    }
}
