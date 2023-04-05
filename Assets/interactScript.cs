using UnityEngine;

public class interactScript : MonoBehaviour
{
    [SerializeField] private AudioSource buttonSound;

    public bool isReady = false;

    Renderer ren;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        if (isReady)
        {
            ren.material.color = Color.green;
        }
    }
}
