using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 0.0f;

    private Animator _controller = null;
    void Start()
    {
        _controller = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _controller.SetFloat("Speed", Speed);
    }
}
