
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentSceneIndex; 

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadStartScene()); 
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(3.0f); 
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }

    public void LoadGameOverScene()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Game Over");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
