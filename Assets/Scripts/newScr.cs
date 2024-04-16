using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScr : MonoBehaviour
{
    public int hp;
    public int str;

    public MeshRenderer plMesh;

    public Color plColor;
    // Start is called before the first frame update
    void Start()
    {
        hp = str * 100;

        plMesh.material.color = plColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
