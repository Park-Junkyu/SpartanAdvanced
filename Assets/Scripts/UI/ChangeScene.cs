using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public void SceneChange()
    {
        MySceneManager.Instance.ChangeScene("MainScene");
    }
}
