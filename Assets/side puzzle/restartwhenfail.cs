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
    private new Collider2D collider;
    [SerializeField]
    private freezeoncollide collide;
    [SerializeField]
    private Transform arrows;
    [SerializeField]
    private GameObject victoryscreen;
    [SerializeField]
    private GameObject seed;
    [SerializeField]
    private bool hasSeed = true;


    private void OnValidate()
    {
        body = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    private void Start()
    {
        arrows.position = transform.position + Vector3.up;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D[] hit = Physics2D.RaycastAll(transform.position, Vector2.right);
            LeanTween.moveX(gameObject, transform.position.x + 1, 0.25f).setOnComplete(() =>
            {
                arrows.position = transform.position + Vector3.up;
            });
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("You won!");
            Time.timeScale = 0;
            victoryscreen.SetActive(true);
            return;
        }
        if (collision.gameObject.tag == "Respawn")
        {
            if (hasSeed)
            {
                hasSeed = false;
                seed.SetActive(false);
                var item = collision.gameObject.GetComponentInParent<freezeoncollide>();
                item.growZone.SetActive(false);
                item.child.SetActive(true);
            }
            return;
        }
        body.velocity = Vector2.zero;
        transform.position = start.position;
        collide?.child.SetActive(true);
        arrows.position = transform.position + Vector3.up;
        hasSeed = true;
        seed.SetActive(true);
    }
}
