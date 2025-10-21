using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;

    [Header("Puntuación")]
    public int score = 0;
    private int progressScore = 0;

    public TextMeshProUGUI scoreText;
    public int targetScore = 100;
    public GameObject rewardMessageObject;
    public float rewardDisplayTime = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (scoreText != null)
        {
            scoreText.text = "Puntuación: " + score;
        }
        if (rewardMessageObject != null)
        {
            rewardMessageObject.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        // --- Lógica de Movimiento ---
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        if (moveDirection != Vector3.zero)
        {
            rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);

            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            rb.rotation = Quaternion.Slerp(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }

    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
        progressScore += pointsToAdd;
        if (scoreText != null)
        {
            scoreText.text = "Puntuación: " + score;
        }
        if (progressScore >= targetScore)
        {
            progressScore = 0;
            // Si hemos alcanzado la meta, activa el objeto del mensaje.
            if (rewardMessageObject != null)
            {
                StartCoroutine(ShowRewardTemporarily());
            }
        }
    }
    private IEnumerator ShowRewardTemporarily()
    {
        if (rewardMessageObject != null)
        {
            rewardMessageObject.SetActive(true);
        }

        yield return new WaitForSeconds(rewardDisplayTime);

        if (rewardMessageObject != null)
        {
            rewardMessageObject.SetActive(false);
        }
    }
}