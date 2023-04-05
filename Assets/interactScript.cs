using UnityEngine;

public class interactScript : MonoBehaviour
{
    public SpriteRenderer sprite;
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
        print("triggering");
        if (isReady & other.CompareTag("Player"))
        {
            print("Working");
            sprite.color = Color.grey;
        }
    }
}
