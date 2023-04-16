using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button tutorialButton;
    [SerializeField] private Button creditsButton;

    private void Awake()
    {
        playButton.onClick.AddListener(() => {
            SceneManager.LoadSceneAsync("Party", LoadSceneMode.Single);
        });

        tutorialButton.onClick.AddListener(() => {
            Debug.Log("Not yet implemented.");
            //SceneManager.LoadScene("Tutorial");
        });

        creditsButton.onClick.AddListener(() => {
            Debug.Log("Not yet implemented.");
            //SceneManager.LoadScene("Credits");
        });
    }
}
