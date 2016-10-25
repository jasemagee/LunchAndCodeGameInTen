using UnityEngine;

public class Ball : MonoBehaviour
{
    private readonly float jumpAmount = 12f;
    private readonly float moveAmount = 6f;

    private Rigidbody rigidbody;
    private AudioSource audioSource;

    // Use this for initialization
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (rigidbody.position.y > .55f)
            return;


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, jumpAmount, 0), ForceMode.VelocityChange);
            audioSource.Play();
        }

        var movement = Vector3.zero;
        movement.y = rigidbody.velocity.y;


        if (Input.GetKey(KeyCode.LeftArrow))
            movement += new Vector3(moveAmount, 0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
            movement -= new Vector3(moveAmount, 0, 0);

        rigidbody.velocity = movement;
    }
}