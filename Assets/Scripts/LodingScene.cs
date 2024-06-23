using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LodingScene : MonoBehaviour
{
    static string nextScene;

    [SerializeField]
    Image Bar;

    public static void LodingScenes(string sceneName) {
        nextScene = sceneName;
        SceneManager.LoadScene("Loding Scene");
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene(){
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;

        while(!op.isDone){
            yield return null;
        }
    }
}
