using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneSelector : MonoBehaviour
{
    public SceneSelectorEnum sceneSelect;
    Button btn;

    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate { LoadSceneScene(sceneSelect); });
    }

    public enum SceneSelectorEnum
    {
        Old = 0,
        New = 1,
    }

    public void LoadSceneScene(SceneSelectorEnum scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}