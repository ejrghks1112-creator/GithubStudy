using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int _loadSceneIndex;

    public void Start()
    {
        SceneManager.LoadScene(_loadSceneIndex);
    }
}
