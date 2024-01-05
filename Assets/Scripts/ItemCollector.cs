using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] Text coinsText;
    [SerializeField] AudioSource collectionSound;

    private int coins = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins:" + coins.ToString();
            collectionSound.Play();
        }
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("HighestScore", coins);
    }

    public int GetScore()
    {
        return coins;
    }
}
