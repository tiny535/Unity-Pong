using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private float VERTICAL_BOUNDARY = 3.5f;
    private float HORIZONTAL_BOUNDARY = 14;
    public Rigidbody2D ballRigidBody;
    public ScoreScript scoreScript;
    public float horizontalVelocity = 10;
    public float verticalVelocity = 10;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();
        StartCoroutine(DelayedSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > HORIZONTAL_BOUNDARY) {
            scoreScript.incrementP1Score();
            spawnBall();
        }

        if (transform.position.x < -HORIZONTAL_BOUNDARY) {
            scoreScript.incrementP2Score();
            spawnBall();
        }
    }

    private void spawnBall() {
        transform.position = new Vector3(0, Random.Range(-VERTICAL_BOUNDARY, VERTICAL_BOUNDARY), 0);
        ballRigidBody.velocity = new Vector2(horizontalVelocity, Random.Range(-verticalVelocity, verticalVelocity));
    }

    IEnumerator DelayedSpawner() {
        yield return new WaitForSeconds(0.5f);
        spawnBall();
    }
}
