using UnityEngine;


public class EnemyMove : MonoBehaviour {
    public int EnemySpeed;
    public int XMoveDirection;

    public float DistanceToSide = 1.0f;
    // Update is called once per frame
    void Update ()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2 (XMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection,0) * EnemySpeed;
Debug.Log(hit.distance);
        if (hit.collider != null && hit.distance < DistanceToSide && hit.collider.tag != "Enemy")
        {
            Flip();
            Debug.Log("Collider hit" + hit.collider.tag.ToString());
            if (hit.collider.tag == "Player")
            {
                Destroy(hit.collider.gameObject);
            }
        }

    }

    private void Flip()
    {
        XMoveDirection *= -1;
    }
}
