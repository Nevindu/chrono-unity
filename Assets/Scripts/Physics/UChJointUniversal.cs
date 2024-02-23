﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UChJointUniversal : MonoBehaviour
{
    public UChBody body1;
    public UChBody body2;

    private ChLinkUniversal joint;

    void Start()
    {
        joint = new ChLinkUniversal();
        ChFramed frame = new ChFramed(Utils.ToChrono(transform.position), Utils.ToChrono(transform.rotation));
        joint.Initialize(body1.GetChBody(), body2.GetChBody(), frame);

        UChSystem.chrono_system.AddLink(joint);
    }

    void Update()
    {
        var frame1 = joint.GetFrame1Abs();
        var frame2 = joint.GetFrame2Abs();

        ChVector3d x = frame1.GetRotMat().GetAxisX();
        ChVector3d y = frame2.GetRotMat().GetAxisY();
        ChVector3d z = x.Cross(y);

        ChMatrix33D R = new ChMatrix33D();
        R.SetFromDirectionAxes(x, y, z);

        transform.position = Utils.FromChrono(frame1.GetPos());
        transform.rotation = Utils.FromChrono(R.GetQuaternion());
    }
}
