using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public sealed class GameEnviroment : MonoBehaviour
{
    private static GameEnviroment instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }
    // Start is called before the first frame update
   
    public static GameEnviroment Singleton
    {
        get
        {
            if(instance == null)
            {
                instance = new GameEnviroment();
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));

                instance.checkpoints = instance.checkpoints.OrderBy(waypoint => waypoint.name).ToList();   
            }
            return instance;
        }
    }
}
