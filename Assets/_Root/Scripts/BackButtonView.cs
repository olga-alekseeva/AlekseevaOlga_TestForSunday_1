using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

internal sealed class BackButtonView : MonoBehaviour
{
    [SerializeField] public GameObject backButtonObject;
    [SerializeField] public Button backButton;
    [SerializeField] public GameObject loadingWindowObject;
    [SerializeField] public Slider loadingSlider;
    [SerializeField] public TMP_Text loadingPercentText;

    public void Start()
    {
        backButton.onClick.AddListener(BackScene);
    }

    private void BackScene()
    {
        SceneManager.LoadScene(0);
    }
}
