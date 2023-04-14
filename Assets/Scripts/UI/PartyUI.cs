using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PartyUI : MonoBehaviour
{
    [SerializeField] private Button readyButton;
    [SerializeField] private Button p3Button;
    [SerializeField] private Button p4Button;

    private void Awake()
    {
        readyButton.onClick.AddListener(() => {
            SceneManager.LoadScene("Level01");
        });

        p3Button.onClick.AddListener(() => {
            Debug.Log("Not yet implemented.");
            // Third Player
        });

        p4Button.onClick.AddListener(() => {
            Debug.Log("Not yet implemented.");
            // Fourth Player
        });
    }
}
