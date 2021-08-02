using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollBackground : MonoBehaviour
{
    public float scroll_Speed = 0.1f;

    private MeshRenderer mesh_Renderer;
    
    void Start()
    {
       mesh_Renderer = GetComponent<MeshRenderer>(); 
    }

 
    void Update()
    {
        float y = Time.time * scroll_Speed;

        Vector2 offset = new Vector2(0, y);

        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
