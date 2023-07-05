using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

internal sealed class MenuUIView : MonoBehaviour, IMenuUIView
{
    [SerializeField] public GameObject _loadingWindowObject;
    [SerializeField] public Slider _loadingSlider;
    [SerializeField] public TMP_Text _loadingPercentText;
    [SerializeField] public Button _loadGalleryButton;

     
}
