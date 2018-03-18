using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[Serializable]
public static class SaveLoad
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/payer_data.sav", FileMode.Create);

        PlayerData data = new PlayerData(player);

        bf.Serialize(stream, data);
        stream.Close();
    }

    public static int[] LoadPlayer()
    {
        if (File.Exists(Application.persistentDataPath + "/payer_data.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/payer_data.sav", FileMode.Open);
            PlayerData data = bf.Deserialize(stream) as PlayerData;
            stream.Close();
        return data.stats;
        }else
        {
            Debug.LogError("File Dosn't Exist");
            return new int[4];
        }
    }

}

[Serializable]
public class PlayerData
{
    public int[] stats;
    public Vector3 player_pos;
    public PlayerData(Player player)
    {
        stats = new int[4];
        //stats[0] = player.level;
        stats[1] = player.posX;
        stats[2] = player.posY;
        stats[3] = player.posZ;

    }
}