﻿using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

    Vector3 position;

    public float minPosX;
    public float maxPosX;
    public float speed;

    bool currentPlatformAndroid = false;

    void Awake()
    {

#if UNITY_ANDROID
        currentPlatformAndroid = true;
#else
        currentPlatformAndroid = false;
#endif
    }

    void Start()
    {
        position = transform.position;

        if (currentPlatformAndroid == true)
        {
            Debug.Log("Android");
        }
        else
        {
            Debug.Log("Windows");
        }
    }

    void Update()
    {
        if (currentPlatformAndroid == false)
        {
            if (Input.GetKeyDown("d"))
            {
                position.x += 0.5f * Time.timeScale;
            }

            if (Input.GetKeyDown("a"))
            {
                position.x -= 0.5f * Time.timeScale;
            }

            position.x = Mathf.Clamp(position.x, minPosX, maxPosX);

            transform.position = position;
        }
    }
}
