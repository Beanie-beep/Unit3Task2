using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
//using Rod;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    [SerializeField] TextMeshProUGUI text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //OnTriggerEnter;
    }

    private void Awake()
    {
        
    }

     void OnTriggerEnter (Collider other)
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        Rod r = other.gameObject.GetComponent<Rod>();
        score += r.value;
        Debug.Log(score);

        text.text = "Score: " + score;
    }
}
