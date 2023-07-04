using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

internal sealed class MenuUIView : MonoBehaviour, IMenuUIView
{
    [SerializeField] private GameObject _loadingWindowObject;
    [SerializeField] private Slider _loadingSlider;
    [SerializeField] private TMP_Text _loadingPercentText;
    [SerializeField] private Button _loadGalleryButton;

}
