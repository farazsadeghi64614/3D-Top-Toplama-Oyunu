
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public int levelNumber = 1;
    public int targetScore = 30;

    public TMP_Text scoreText;
    public TMP_Text messageText;

    private Rigidbody rb;
    private int score = 0;
    private int remainingGreenBalls = 0;
    private bool gameEnded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        remainingGreenBalls =
            GameObject.FindGameObjectsWithTag("Green").Length;

        UpdateScore();

        if (messageText != null)
            messageText.text = "";
    }

    void Update()
    {
        if (gameEnded && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex
            );
        }
    }

    void FixedUpdate()
    {
        if (gameEnded) return;

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (gameEnded) return;

        if (other.CompareTag("Green"))
        {
            score += 10;
            remainingGreenBalls--;

            Destroy(other.gameObject);
            UpdateScore();
            CheckPossibleScore();
        }
        else if (other.CompareTag("Red"))
        {
            score -= 5;

            Destroy(other.gameObject);
            UpdateScore();
            CheckPossibleScore();
        }
        else if (other.CompareTag("Exit"))
        {
            if (score >= targetScore)
            {
                FinishLevel();
            }
            else if (messageText != null)
            {
                messageText.text =
                    "NOT ENOUGH POINTS!\nCollect more green balls!";
            }
        }
    }

    void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text =
                "Score: " + score + " / " + targetScore;
        }
    }

    void CheckPossibleScore()
    {
        int maximumPossibleScore =
            score + remainingGreenBalls * 10;

        if (maximumPossibleScore < targetScore)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameEnded = true;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.constraints = RigidbodyConstraints.FreezeAll;

        if (messageText != null)
        {
            messageText.text =
                "GAME OVER!\nYou cannot reach the target!\n\nPRESS R TO RESTART";
        }
    }

    void FinishLevel()
    {
        int currentIndex =
            SceneManager.GetActiveScene().buildIndex;

        if (levelNumber < 3)
        {
            int nextIndex = currentIndex + 1;

            if (nextIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextIndex);
            }
            else
            {
                if (messageText != null)
                {
                    messageText.text =
                        "NEXT LEVEL NOT FOUND!\nCheck Build Profiles.";
                }
            }
        }
        else
        {
            gameEnded = true;

            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.constraints = RigidbodyConstraints.FreezeAll;

            if (messageText != null)
            {
                messageText.text =
                    "CONGRATULATIONS!\nYOU COMPLETED ALL 3 LEVELS!";
            }
        }
    }
}
