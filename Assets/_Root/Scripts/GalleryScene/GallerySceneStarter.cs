using System;
using System.Collections;
using Tools;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

internal sealed class GallerySceneStarter : MonoBehaviour
{
    private BackButtonView _backButtonView;
    private GallerySceneUIView _gallerySceneUIView;
    private AsyncOperation _loadingProgress;
    void Start()
    {
        InitLevelInstantiator();
        BackButtonView backButtonView = GameObject.FindObjectOfType<BackButtonView>();
        _backButtonView = backButtonView;
        _backButtonView.loadingWindowObject.SetActive(false);
        _backButtonView.backButton.onClick.AddListener(LoadMenuScene);
        GallerySceneUIView gallerySceneUIView = GameObject.FindObjectOfType<GallerySceneUIView>();
        _gallerySceneUIView = gallerySceneUIView;
        //_gallerySceneUIView.imageButton.onClick.AddListener(LoadImage);
        ScreenOrientationSetter screenOrientationSetter = new ScreenOrientationSetter();
        screenOrientationSetter.PortraitScreenOrientation();
    }

    

    public void LoadMenuScene()
    {
        StartCoroutine("AsyncLoadingCorutine");
    }
    private void InitLevelInstantiator()
    {
        ILevelPrefab levelPrefab = Resources.Load<LevelPrefab>(ResourcePathes.ScriptableObjects.GALLERY_LEVEL_PREFAB);
        ILevelInstantiator levelInstantiator = new LevelInstantiator(levelPrefab);
        levelInstantiator.Instantiate();
    }

    IEnumerator AsyncLoadingCorutine()
    {
        float loadingProgressCounter;
        _loadingProgress = SceneManager.LoadSceneAsync(ResourcePathes.ConstantNames.MENU_SCENE_NAME);
        _backButtonView.loadingWindowObject.SetActive(true);
        _loadingProgress.allowSceneActivation = false;
        while (!_loadingProgress.isDone)
        {
            loadingProgressCounter = Mathf.Clamp01(_loadingProgress.progress / 0.9f);
            _backButtonView.loadingPercentText.text = $"Loading... {(loadingProgressCounter * 100).ToString("0")}%";
            _backButtonView.loadingSlider.value = loadingProgressCounter;
            yield return null;
            _loadingProgress.allowSceneActivation = true;
        }
    }
    
}

