using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource playerAudioSource;

    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    public ForceMode jumpForceMode;
    public Animator playerAnim;
    public ParticleSystem explosion;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;


    // Start is called before the first frame update
    void Start()
    {
        //Sets the Player Animator
        playerAnim = GetComponent<Animator>();
        playerAnim.SetFloat("Speed_f", 1.0f);

        //Sets reference to the RidgidBody on the Player
        rb = GetComponent<Rigidbody>();

        //Sets a Reference to audio source
        playerAudioSource = GetComponent<AudioSource>();

        //Modify gravity
        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;

        }
    }

    // Update is called once per frame
    void Update()
    {
        //Press Space bar to jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            isOnGround = false;

            //Set the Trigger to play the jump animation
            playerAnim.SetTrigger("Jump_trig");

            //Stop playing dirt particle on jump
            dirtParticle.Stop();

            //Play Jump sound effect
            playerAudioSource.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            //Play Dirt partcle on collsion with the ground
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;

            //Play Death Animation
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);

            //Plays Particle system
            explosion.Play();

            //Stops dirt Particle on death
            dirtParticle.Stop();

            //Play Audio source for death
            playerAudioSource.PlayOneShot(crashSound, 1.0f);
        }
    }
}
