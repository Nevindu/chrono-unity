﻿// =============================================================================
// PROJECT CHRONO - http://projectchrono.org
//
// Copyright (c) 2024 projectchrono.org
// All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found
// in the LICENSE file at the top level of the distribution and at
// http://projectchrono.org/license-chrono.txt.
//
// =============================================================================
// Authors: Radu Serban
// =============================================================================

using UnityEngine;
using UnityEditor;

//// TODO: take into account object scale!!!

[CustomEditor(typeof(UChBodyMesh))]
public class UChBodyMeshEditor : UChBodyEditor
{
    public override void OnInspectorGUI()
    {
        UChBodyMesh body = (UChBodyMesh)target;

        base.OnInspectorGUI();
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

        body.collisionMesh = EditorGUILayout.Toggle("OBJ File", body.collisionMesh);

        if (body.collisionMesh)
            body.collisionMeshOBJFile = EditorGUILayout.TextField("File Name", body.collisionMeshOBJFile);

        body.sweptSphereRadius = EditorGUILayout.DoubleField("Swept Sphere Radius", body.sweptSphereRadius);

        if (GUI.changed)
        {
            EditorUtility.SetDirty(body);
        }
    }
}
