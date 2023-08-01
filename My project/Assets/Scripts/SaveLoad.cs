using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    SaveData SaveData;
    PlayerCollectorData playerCollectorData;

    public void Awake()
    {
        playerCollectorData = GetComponent<PlayerCollectorData>();
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/savedGames.gd");
        bf.Serialize(file, playerCollectorData.saveData); //SaveData
        file.Close();
       // print(playerCollectorData.saveData.speed);
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd") == false) 
            return;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
        SaveData = (SaveData)bf.Deserialize(file);
        file.Close();
        playerCollectorData.LoadPlayerData(SaveData);
        //print(SaveData.speed);
    }

    public void Clear()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
            File.Delete(Application.persistentDataPath + "/savedGames.gd");
    }
}
