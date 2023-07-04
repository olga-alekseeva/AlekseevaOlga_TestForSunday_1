using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class Starter : MonoBehaviour
{
    private IMenuUIView _menuUIView;

    public void Start()
    {
        InitMenuView();
        InitLevelInstantiator();
    }

    private void InitMenuView()
    {
        MenuUIView menuUIView = GameObject.FindObjectOfType<MenuUIView>();
    }

    private void InitLevelInstantiator()
    {
        ILevelPrefab levelPrefab = Resources.Load<LevelPrefab>(ResourcePathes.ScriptableObjects.MENU_LEVEL_PREFAB);
        ILevelInstantiator levelInstantiator = new LevelInstantiator(levelPrefab);
        levelInstantiator.Instantiate();
    }
}
