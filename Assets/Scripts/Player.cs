using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float xSpeed;
    public float yJump;
    public GameObject gopanel;
    public bool isGround = false;
    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(1f, 0f, 0f);
        transform.position += move * Time.deltaTime * xSpeed;

        if(Input.GetButtonDown("Jump") && isGround)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, yJump), ForceMode2D.Impulse);
        }

        if(transform.position.y < -15)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0f;
        gopanel.SetActive(true);

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
