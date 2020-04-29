﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UChBodyConvexHull : UChBody
{
    public List<Vector3> points;
    public double density;

    private ChMaterialSurface mat;

    public UChBodyConvexHull()
    {
        density = 1000;
    }

    public override void Create()
    {
        if (points.Count == 0)
        {
            Debug.Log("No points in convex hull (" + gameObject.name + ")");
            return;
        }

        // Get a handle to the associated material component and create the Chrono material
        var mat_component = this.GetComponent<UChMaterialSurface>();
        ////mat_component.DumpInfo();
        mat = mat_component.mat_info.CreateMaterial(mat_component.contact_method);

        // Create the underlying Chrono body
        vector_ChVectorD p = new vector_ChVectorD();
        for (int i = 0; i < points.Count; i++) {
            p.Add(Utils.ToChrono(points[i]));
        }

        var bodyCH = new ChBodyEasyConvexHull(p, density, false, true, mat);
        body = bodyCH;

        // Create visualization mesh from the Chrono-generated mesh.
        // For proper rendering, we must create unique vertices for each face (the Chrono connected mesh will not do).
        var chrono_mesh = bodyCH.GetMesh();
        int chrono_nv = chrono_mesh.getCoordsVertices().Count;
        int chrono_nt = chrono_mesh.getNumTriangles();

        // First, move the points to new locations (which were shifted to make body COM coincide with convex hull center)
        for (int i = 0; i < chrono_nv; i++)
        {
            points[i] = Utils.FromChrono(chrono_mesh.getCoordsVertices()[i]);
        }

        // The Unity visualization mesh will have 3 distinct vertices per face.
        // For each face, assign the face normal to adjacent vertices.
        int unity_nv = 3 * chrono_nt;
        int unity_nt = 3 * chrono_nt;
        Vector3[] vertices = new Vector3[unity_nv];
        Vector3[] normals = new Vector3[unity_nv];
        int[] triangles = new int[unity_nt];

        for (int i = 0; i < chrono_nt; i++)
        {
            int v1 = chrono_mesh.getIndicesVertexes()[i].x;
            int v2 = chrono_mesh.getIndicesVertexes()[i].y;
            int v3 = chrono_mesh.getIndicesVertexes()[i].z;

            vertices[3 * i + 0] = Utils.FromChrono(chrono_mesh.getCoordsVertices()[v1]);
            vertices[3 * i + 1] = Utils.FromChrono(chrono_mesh.getCoordsVertices()[v2]);
            vertices[3 * i + 2] = Utils.FromChrono(chrono_mesh.getCoordsVertices()[v3]);

            Vector3 nrm = Vector3.Cross(vertices[3 * i + 1] - vertices[3 * i + 0], vertices[3 * i + 2] - vertices[3 * i + 1]);
            normals[3 * i + 0] = nrm;
            normals[3 * i + 1] = nrm;
            normals[3 * i + 2] = nrm;

            triangles[3 * i + 0] = 3 * i + 0;
            triangles[3 * i + 1] = 3 * i + 1;
            triangles[3 * i + 2] = 3 * i + 2;
        }

        // Create UV map: use spherical mapping.
        Vector2[] uv = new Vector2[unity_nv];
        for (int i = 0; i < unity_nv; i++)
        {
            Vector3 d = vertices[i].normalized;
            uv[i].x = 0.5f + Mathf.Atan2(d.z, d.x) / (2 * Mathf.PI);
            uv[i].y = 0.5f - Mathf.Asin(d.y) / Mathf.PI;
        }

        // Set the vertices, normals, UVs, and faces for the Unity mesh
        var mesh = GetComponent<MeshFilter>().mesh;
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.uv = uv;
        mesh.SetIndices(triangles, MeshTopology.Triangles, 0);
        mesh.RecalculateNormals();
    }

    public override void AddToSystem()
    {
        if (points.Count == 0)
        {
            Debug.Log("No points in convex hull (" + gameObject.name + ")");
        }

        base.AddToSystem();

        if (mat.GetContactMethod() != UChSystem.chrono_system.GetContactMethod())
            throw new Exception("Incompatible contact method (" + gameObject.name + ")");
    }

    public override void OnDrawGizmosExtra()
    {
        for (int i = 0; i < points.Count; i++)
        {
            Gizmos.color = Color.white;
            Gizmos.DrawSphere(points[i], 0.05f);
        }
    }
}