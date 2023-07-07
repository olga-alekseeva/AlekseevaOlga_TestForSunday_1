using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

internal sealed class BackButtonView : MonoBehaviour
{
    [SerializeField] public GameObject backButtonObject;
    [SerializeField] public Button backButton;

    public void Start()
    {
        backButton.onClick.AddListener(BackScene);
    }

    private void BackScene()
    {
        SceneManager.LoadScene(0);
    }
}
