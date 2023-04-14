using UnityEngine;

public class InteractScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private AudioSource buttonSound;
    public bool isReady;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isReady)
        {
            sprite.color = Color.green;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggering");
        if (isReady & other.CompareTag("Player"))
        {
            Debug.Log("Working");
            sprite.color = Color.grey;
        }
    }
}
