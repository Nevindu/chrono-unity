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

[CustomEditor(typeof(UChBodyGround))]
public class UChBodyGroundEditor : Editor
{
    override public void OnInspectorGUI()
    {
        UChBodyGround ground = (UChBodyGround)target;

        ground.showFrameGizmo = EditorGUILayout.Toggle("Show Frame Gizmo", ground.showFrameGizmo);

        if (GUI.changed)
        {
            EditorUtility.SetDirty(ground);
        }
    }
}
