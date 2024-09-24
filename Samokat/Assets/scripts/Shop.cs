using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    public GameObject LoadGameScene;
    private void Start()
    {
        int coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString();
    }

    public void GoShop()
    {
        LoadGameScene.SetActive(true);
        SceneManager.LoadScene(2);
    }
}
