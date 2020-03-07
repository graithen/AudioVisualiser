using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamSphere : MonoBehaviour
{
    public int _band;
    public int _band2;
    public float _startScale, _scaleMultiplier;
    float displacementAmount;
    float bandVal;

    public bool useBuffer;

    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (useBuffer)
            bandVal = AudioControl.audioBandBuffer[_band] + AudioControl.audioBandBuffer[_band2];
        if (!useBuffer)
            bandVal = AudioControl.audioBand[_band] + AudioControl.audioBand[_band2];

        displacementAmount = (bandVal) * _scaleMultiplier;

        meshRenderer.material.SetFloat("_Amount", displacementAmount);
    }
}
