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
            if (hit.Where(x => x.collider.isTrigger == false).ToArray().Length > 1)
            {
                for (int i = 0; i < hit.Length; i++)
                {
                    if (hit[i].collider == collider || hit[i].collider.gameObject.tag == "Finish")
                    {
                        continue;
                    }
                    collide = hit[i].collider.gameObject.GetComponent<freezeoncollide>();
                    hit[i].transform.Translate(Vector2.down * 2);
                }
            }
            else
            {
                LeanTween.moveX(gameObject, transform.position.x + 1, 0.25f).setOnComplete(() =>
                {
                    arrows.position = transform.position + Vector3.up;
                });
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("You won!");
            return;
        }
        body.velocity = Vector2.zero;
        transform.position = start.position;
        collide?.child.SetActive(true);
        arrows.position = transform.position + Vector3.up;
    }
}
