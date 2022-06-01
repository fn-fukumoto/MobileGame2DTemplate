using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    // 1フレームに1回呼ばれる
    void Update()
    {
#if UNITY_EDITOR
        // Unity上で画面をクリックした時
        if (Input.GetMouseButtonDown(0))
        {
            // Main.unityに遷移する
            SceneManager.LoadSceneAsync("Main");
        }
#else
        // 実機上で画面をタップした時
        if (0 < Input.touchCount)
        {
            // Main.unityに遷移する
            SceneManager.LoadSceneAsync("Main");
        }
#endif
    }
}
