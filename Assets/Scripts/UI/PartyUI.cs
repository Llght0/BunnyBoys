using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PartyUI : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button p3Button;
    [SerializeField] private Button p4Button;
    [SerializeField] private GameObject P3;
    [SerializeField] private GameObject P4;

    private void Awake()
    {
        startButton.onClick.AddListener(() => {
            SceneManager.LoadScene("Level01");
        });

        // Third Player
        p3Button.onClick.AddListener(() => {
            p3Button.gameObject.SetActive(false);
            P3.SetActive(true);
            GameManager.player3 = true;
        });

        // Fourth Player
        p4Button.onClick.AddListener(() => {
            p4Button.gameObject.SetActive(false);
            P4.SetActive(true);
            GameManager.player4 = true;
        });
    }
}
