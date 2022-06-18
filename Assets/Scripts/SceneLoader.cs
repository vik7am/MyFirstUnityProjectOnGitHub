using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Button button;
    public string sceneName;

    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    void OnButtonClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
