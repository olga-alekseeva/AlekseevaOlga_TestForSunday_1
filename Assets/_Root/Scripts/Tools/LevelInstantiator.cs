using UnityEngine;

internal sealed class LevelInstantiator : ILevelInstantiator
{
    private ILevelPrefab _levelPrefab;

    public LevelInstantiator(ILevelPrefab levelPrefab)
    {
        _levelPrefab = levelPrefab;
    }
    public void Instantiate()
    {
        GameObject levelPrefabObject = _levelPrefab.LevelPrefabObject;
        GameObject.Instantiate(levelPrefabObject);
    }
}
