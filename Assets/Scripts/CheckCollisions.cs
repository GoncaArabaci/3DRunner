using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CheckCollisions : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) {
            //Debug.Log("coin collected :D");
            AddCoin();
            Destroy(other.gameObject);
        }
    }
    public void AddCoin()
    {
        score++;
        CoinText.text = "Score:" + score.ToString();

    }
}
