using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(GoToMainScene());
    }
    public IEnumerator GoToMainScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Damian");
    }
}
