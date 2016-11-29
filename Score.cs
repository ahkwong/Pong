using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "WallRight")
        {            
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            transform.position = new Vector3(-3.4f, 0, 0);
            StartCoroutine("Wait1secRight");
        }
        if (col.gameObject.name == "WallLeft")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            transform.position = new Vector3(3.4f, 0, 0);
            StartCoroutine("Wait1secLeft");
        }
    }

    IEnumerator Wait1secRight()
    {
        ScoreManager.scoreLeft += 1;
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody2D>().velocity = Vector2.right * 20f;
    }
    IEnumerator Wait1secLeft()
    {
        ScoreManager.scoreRight += 1;
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody2D>().velocity = -Vector2.right * 20f;
    }
}
