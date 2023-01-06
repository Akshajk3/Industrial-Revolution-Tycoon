using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(PlayerMovement player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.sus";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.sus";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Bozo save file could not be found in " + path);
            return null;
        }
    }

    public static void SaveMoney(MachineManager machineManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/money.sus";
        FileStream stream = new FileStream(path, FileMode.Create);

        MoneyData data = new MoneyData(machineManager);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static MoneyData LoadMoney()
    {
        string path = Application.persistentDataPath + "/money.sus";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            MoneyData data = formatter.Deserialize(stream) as MoneyData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Bozo save file could not be found in " + path);
            return null;
        }
    }
}
