using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(LevelPrefab), menuName = "ScriptableObject/" + nameof(LevelPrefab))]

internal sealed class LevelPrefab : ScriptableObject, ILevelPrefab
{
    [SerializeField] private GameObject _levelPrefabObject;  
   public  GameObject LevelPrefabObject => _levelPrefabObject;
}
