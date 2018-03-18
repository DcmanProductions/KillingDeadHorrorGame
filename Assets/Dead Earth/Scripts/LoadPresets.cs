using UnityEngine;
using System.Collections;

public class LoadPresets : MonoBehaviour {

    [SerializeField]
    public GameObject player;
    void Start()
    {
        Load();
    }
	public void Load()
    {
        //Instantiate(player, new Vector3(PlayerPrefs.GetFloat("PositionX"), PlayerPrefs.GetFloat("PositionY"), PlayerPrefs.GetFloat("PositionZ")), Quaternion.identity);
    }
}
