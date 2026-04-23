using UnityEngine;

public class Deathzone : MonoBehaviour
{
    [SerializeField] private int _year = 1000;
    private float _seconds = 0;
    void Awake()
    {
        _year += 1026;
        Debug.Log($"I'm awake! It's the year {_year}");
    }
    void Start()
    {
        Debug.Log($"Let's get started! It's finally the year {_year}");
    }

    // Update is called once per frame
    void Update()
    {
        _seconds += Time.deltaTime;
        // Debug.Log($"This scene has been running for {_seconds:f2} seconds.");
    }

    // so this is called when two objects touch
    // and these objects have colliders
    // at least one has the "is trigger" checked
    // at least one has rigidbody2d
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Boom they hit");
        // collider represents the collider of the game object that bumped into this (the deathzone)
        // collider.transform.position.y += 5
    }
}
