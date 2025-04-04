using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 4f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public Animator anim;

    private static Vector3 savedPosition = Vector3.zero;


    private AudioSource walkingAudio;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        walkingAudio = GetComponent<AudioSource>();

        if (savedPosition != Vector3.zero)
        {
            transform.position = savedPosition;
        }
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        bool isMoving = movement != Vector2.zero;
        anim.SetBool("moving", isMoving);

        if (isMoving)
        {
            if (!walkingAudio.isPlaying)
            {
                walkingAudio.Play();
            }
        }
        else
        {
            walkingAudio.Stop(); 
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }

    void OnDestroy()
    {
        savedPosition = transform.position;
    }
}