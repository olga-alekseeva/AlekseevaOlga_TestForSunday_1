using System.Collections;
using System.Collections.Generic;
using Tools;
using UnityEngine;

internal sealed class ReviewSceneStarter : MonoBehaviour
{
    void Start()
    {
        ScreenOrientationSetter screenOrientationSetter = new ScreenOrientationSetter();
        screenOrientationSetter.AnyScreenOrientation();

    }
}
