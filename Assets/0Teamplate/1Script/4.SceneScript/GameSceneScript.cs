using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-10)]
public class GameSceneScript : MonoBehaviour
{
    void Start()
    {
        GameUIOpen();
    }

    void GameUIOpen()
    {
        UIManager.Instance.ShowUI(UITypeClass.EnumUIType.Game);
    }
}
