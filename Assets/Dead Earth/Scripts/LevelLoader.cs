using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{

    public GameObject loadingScreen;
    public Slider slider;
    public Text text;

    public void LoadLevel(string sceneName)
    {
        StartCoroutine(LoadAsyncchronously(sceneName));
        //StartCoroutine(LoadAsyncchronously(PlayerPrefs.GetString("Level")));
    }

    public void NewGame()
    {
        PlayerPrefs.SetFloat("PositionX", 53.0f);
        PlayerPrefs.SetFloat("PositionY", 1.2f);
        PlayerPrefs.SetFloat("PositionZ", -24.0f);
        LoadLevel("City");
    }

    IEnumerator LoadAsyncchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            text.text = progress * 100f+"%";
            Debug.Log(operation.progress);
            yield return null;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
