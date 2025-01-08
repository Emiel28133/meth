using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessBackground : MonoBehaviour
{
    [SerializeField] private Renderer bgRenderer;
    [SerializeField] private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}