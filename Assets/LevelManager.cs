using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject P3;
    [SerializeField] private GameObject P4;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.player3)
        {
            P3.SetActive(true);
        }
        if (GameManager.player4)
        {
            P4.SetActive(true);
        }
    }
}
