using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GPUParticles;

public class PositionCollector : MonoBehaviour
{
    [SerializeField]
    GPUParticleEmitter guiParticleEmitter;

    public Transform[] trans;

    public bool applyInUpdate = true;

    private Vector3[] positions;

    public void Awake()
    {
        FillPosition();
    }

    public void Update()
    {
        if (!applyInUpdate) { return; }

        FillPosition();
    }

    void FillPosition()
    {
        if (trans != null)
        {
            if (positions == null || positions.Length != trans.Length)
                positions = new Vector3[trans.Length];

            for(var i = 0; i < trans.Length; i++)
                positions[i] = trans[i].position;

            guiParticleEmitter.ApplyMultiInheritedPositions(positions);
        }
    }
}
