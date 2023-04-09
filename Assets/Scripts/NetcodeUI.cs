using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetcodeUI : MonoBehaviour
{
    [SerializeField] private Button startHostButton;
    [SerializeField] private Button startClientButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        startHostButton.onClick.AddListener(() => {
            Debug.Log("Host Process Started.");
            NetworkManager.Singleton.StartHost();
            ScenesManager.Instance.LoadNextScene();
        });

        startClientButton.onClick.AddListener(() => {
            Debug.Log("Client Process Started.");
            NetworkManager.Singleton.StartClient();
            ScenesManager.Instance.LoadNextScene();
        });

        quitButton.onClick.AddListener(() => {
            Application.Quit();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
