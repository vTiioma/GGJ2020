using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class restartwhenfail : MonoBehaviour
{
    [SerializeField]
    private Transform start;
    [SerializeField]
    private Rigidbody2D body;
    [SerializeField]
    private freezeoncollide collide;
    [SerializeField]
    private Transform arrows;
    [SerializeField]
    private GameObject victoryscreen;
    [SerializeField]
    private GameObject seed;
    [SerializeField]
    private GameObject pointer;
    [SerializeField]
    private bool hasSeed = true;
    [SerializeField]
    private AudioSource audio;
    [SerializeField]
    private AudioClip[] walking;
    [SerializeField]
    private AudioClip restart;
    [SerializeField]
    private AudioClip grow;
    [SerializeField]
    private AudioClip win;
    [SerializeField]
    private ParticleSystem[] walkParticles;
    [SerializeField]
    private ParticleSystem[] dealthParticles;
    [SerializeField]
    private float dragThreshold = 30;
    [SerializeField]
    private crossfademusic music;
    private bool canMove = true;

    private Vector2 downPosition = Vector2.zero;

    private void OnValidate()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        arrows.position = transform.position + Vector3.up;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            downPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            float delta = Input.mousePosition.x - downPosition.x;
            if (delta > 0 && delta >= dragThreshold)
            {
                TryMoveRight();
            }
        }
        if (Input.anyKeyDown && !Input.GetMouseButtonDown(0))
        {
            TryMoveRight();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (canMove == false)
        {
            canMove = true;
            ResetArrowPosition();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("You won!");
            Time.timeScale = 0;
            victoryscreen.SetActive(true);
            audio.PlayOneShot(win);
            music.Crossfade();
            return;
        }
        if (collision.gameObject.tag == "Respawn")
        {
            if (hasSeed)
            {
                hasSeed = false;
                seed.SetActive(false);
                var item = collision.gameObject.GetComponentInParent<freezeoncollide>();
                item.growZone?.SetActive(false);
                item.child?.SetActive(true);
                audio.PlayOneShot(grow);
            }
            return;
        }
        PlayDeathParticles();
        collide?.child.SetActive(true);
        audio.PlayOneShot(restart);
        LeanTween.value(0, 1, 0.5f).setOnComplete(ResetPlayer);
    }

    private void PlayWalkParticles()
    {
        for (int i = 0; i < walkParticles.Length; i++)
        {
            walkParticles[i].Play();
        }
    }

    private void PlayDeathParticles()
    {
        for (int i = 0; i < dealthParticles.Length; i++)
        {
            dealthParticles[i].transform.position = transform.position;
            dealthParticles[i].Play();
        }
    }

    private void ResetPlayer()
    {
        body.velocity = Vector2.zero;
        transform.position = start.position;
        arrows.position = transform.position + Vector3.up;
        hasSeed = true;
        seed.SetActive(true);
    }

    private void ResetArrowPosition()
    {
        arrows.position = transform.position;
    }

    private void TryMoveRight()
    {
        if (canMove == false)
        {
            Debug.Log("can't move yet");
            return;
        }
        canMove = false;
        PlayWalkParticles();
        audio.PlayOneShot(walking[Random.Range(0, 3)]);
        LeanTween.moveX(gameObject, transform.position.x + 1, 0.25f).setOnComplete(ResetArrowPosition);
        if (pointer.activeSelf == true)
        {
            pointer.SetActive(false);
        }
    }
}
