using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleManager : MonoBehaviour
{
    PhysicsMaterial2D[] physicsMaterials;
    CircleCollider2D meshCollider;
    GameObject[] poles;
    public Color myColor;





    void Start()
    {

        Color[] poleColors = new Color[3] {
        new Color(0.7069721f, 0.8792453f, 0.1642363f, 1f),
        Color.magenta,
        myColor};

        poles = GameObject.FindGameObjectsWithTag("Pole");
        physicsMaterials = Resources.LoadAll<PhysicsMaterial2D>("Physics Materials");
        foreach (GameObject currentPole in poles)
        {
            int poleIndex = Random.Range(0, physicsMaterials.Length);
            currentPole.GetComponent<CircleCollider2D>().sharedMaterial = physicsMaterials[poleIndex];
            currentPole.GetComponent<SpriteRenderer>().color = poleColors[poleIndex];

        }
        Debug.Log("Started Pole " + poles.Length.ToString());
    }


    // Update is called once per frame
    void Update()
    {

    }
}
