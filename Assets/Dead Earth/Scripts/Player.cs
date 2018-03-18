using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour
{
    public GameObject player;
    public Vector3 player_transform;
    public string level = "City";
    public GameObject settingsMenu;
    public GameObject pauseMenu;

    public int posX = 0, posY = 0, posZ = 0;


    void Update()
    {
        //player_transform = new Vector3(player.transform.localPosition.x, player.transform.localPosition.y, player.transform.localPosition.z);
        posX = player.transform.localPosition.x.GetHashCode();
        posY = player.transform.localPosition.y.GetHashCode();
        posZ = player.transform.localPosition.z.GetHashCode();

    }

    public void OpenSettings()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void CloseSettings()
    {
        pauseMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void Save()
    {
        PlayerPrefs.SetString("Level", level);
        PlayerPrefs.SetFloat("PositionX", player.transform.localPosition.x);
        PlayerPrefs.SetFloat("PositionY", player.transform.localPosition.y);
        PlayerPrefs.SetFloat("PositionZ", player.transform.localPosition.z);
        //SaveLoad.SavePlayer(this);
    }

    public void Load()
    {
        player_transform = new Vector3(PlayerPrefs.GetFloat("PositionX"), PlayerPrefs.GetFloat("PositionY"), PlayerPrefs.GetFloat("PositionZ"));
        player.transform.position = player_transform;

        /*
        int[] loadedStats = SaveLoad.LoadPlayer();

        level = loadedStats[0];
        posX = loadedStats[1];
        posY = loadedStats[2];
        posZ = loadedStats[3];*/
    }

    // Use this for initialization
    void Start()
    {
        settingsMenu.SetActive(false);
        Load();
    }
}
