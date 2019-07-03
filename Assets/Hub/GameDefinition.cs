using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "_OUR_GAME/GameDefinition")]
public class GameDefinition : ScriptableObject
{
    [SerializeField]
    public SceneAsset gameScene;
}
