using System.Collections;
using UnityEngine;

public enum gameStage{


    gameStart,
    sea1step,
    sea2step,
    sea3step,
    sea4step



    };


public class MapManager : MonoBehaviour {


    public GameObject[] mapList = null;
    float interval = 0;
    void Start()
    {
        gameStage.gameStart;

    }

    
    void Update()
    {
        interval += Time.deltaTime;
        if (interval > 6.6f)
        {
            GameObject obj = Instantiate(mapList[Random.Range(0, 2)]);
            obj.transform.position = new Vector3(-4, 0, 0);
            interval = 0;
        }
    }


}
