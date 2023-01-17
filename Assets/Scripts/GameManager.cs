using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ting;
    [SerializeField] TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBall();
        Ball b = ting.GetComponent<Ball>();

    }

    void SpawnBall()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -7.88f;       // we want 2m away from the camera position
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            //Debug.Log(worldPos);
            //Debug.Log(mousePos);
            worldPos.z = -7.88f;
            Instantiate(ting, worldPos, Quaternion.identity);
        }
    }

    
}
