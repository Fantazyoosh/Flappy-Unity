using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Parallax : MonoBehaviour

{
private MeshRenderer meshRenderer;
//[SerializeField]
public float animationSpeed = 0.2f;

    private void Awake() {
    meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Update() {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }

}



//pips 0.2*24 times faster 