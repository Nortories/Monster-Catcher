using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public LevelLoader(){}
    public Animator transition;
    public float transitionTime = 1f;

    public void sceneChange(string scene)
    {
        StartCoroutine(LoadLevel(scene));
    }
    IEnumerator LoadLevel(string scene)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(scene);
    }
}
