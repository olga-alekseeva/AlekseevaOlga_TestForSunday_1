using System.Collections;
using Tools;
using UnityEngine;
using UnityEngine.SceneManagement;

internal sealed class MenuSceneStarter : MonoBehaviour
{
    private MenuUIView _menuUIView;
    private AsyncOperation _loadingProgress;


    public void Start()
    {
        InitLevelInstantiator();
        //InitMenuView();
        MenuUIView menuUIView = GameObject.FindObjectOfType<MenuUIView>();
        _menuUIView = menuUIView;
        //_menuUIView._loadingWindowObject.SetActive(false);
        _menuUIView._loadGalleryButton.onClick.AddListener(LoadGalleryScene);
    }
    //private MenuUIView LoadView()
    //{
    //    GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
    //    GameObject objectView = GameObject.Instantiate(prefab);
    //    return objectView.GetComponent<MainMenuView>();
    //}
    private void InitMenuView()
    {
    }
    private void Test()
    {
        Debug.Log("test is done");
    }

    public void LoadGalleryScene()
    {
        StartCoroutine("AsyncLoadingCorutine");
    }


    private void InitLevelInstantiator()
    {
        ILevelPrefab levelPrefab = Resources.Load<LevelPrefab>(ResourcePathes.ScriptableObjects.MENU_LEVEL_PREFAB);
        ILevelInstantiator levelInstantiator = new LevelInstantiator(levelPrefab);
        levelInstantiator.Instantiate();
    }
  
    IEnumerator AsyncLoadingCorutine()
    {
        float loadingProgressCounter;
        _loadingProgress = SceneManager.LoadSceneAsync(ResourcePathes.ConstantNames.GALLERY_SCENE_NAME);
        _menuUIView._loadingWindowObject.SetActive(true);
        while (!_loadingProgress.isDone)
        {
            loadingProgressCounter = Mathf.Clamp01(_loadingProgress.progress / 0.9f);
            _menuUIView._loadingPercentText.text = $"Loading... {(loadingProgressCounter * 100).ToString("0")}%";
            _menuUIView._loadingSlider.value = loadingProgressCounter;
            yield return null;
        }
    }


}
