//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChBodyEasyMesh : ChBodyAuxRef {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChBodyEasyMesh(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChBodyEasyMesh_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChBodyEasyMesh obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChBodyEasyMesh(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChBodyEasyMesh(string filename, double mdensity, bool compute_mass, bool visualize, bool collide, ChMaterialSurface material, double sphere_swept, ChCollisionModel collision_model) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_0(filename, mdensity, compute_mass, visualize, collide, ChMaterialSurface.getCPtr(material), sphere_swept, ChCollisionModel.getCPtr(collision_model)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(string filename, double mdensity, bool compute_mass, bool visualize, bool collide, ChMaterialSurface material, double sphere_swept) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_1(filename, mdensity, compute_mass, visualize, collide, ChMaterialSurface.getCPtr(material), sphere_swept), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(string filename, double mdensity, bool compute_mass, bool visualize, bool collide, ChMaterialSurface material) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_2(filename, mdensity, compute_mass, visualize, collide, ChMaterialSurface.getCPtr(material)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(string filename, double mdensity, bool compute_mass, bool visualize, bool collide) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_3(filename, mdensity, compute_mass, visualize, collide), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(string filename, double mdensity, bool compute_mass, bool visualize) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_4(filename, mdensity, compute_mass, visualize), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(string filename, double mdensity, bool compute_mass) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_5(filename, mdensity, compute_mass), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(string filename, double mdensity) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_6(filename, mdensity), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(ChTriangleMeshConnected mesh, double mdensity, bool compute_mass, bool visualize, bool collide, ChMaterialSurface material, double sphere_swept, ChCollisionModel collision_model) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_7(ChTriangleMeshConnected.getCPtr(mesh), mdensity, compute_mass, visualize, collide, ChMaterialSurface.getCPtr(material), sphere_swept, ChCollisionModel.getCPtr(collision_model)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(ChTriangleMeshConnected mesh, double mdensity, bool compute_mass, bool visualize, bool collide, ChMaterialSurface material, double sphere_swept) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_8(ChTriangleMeshConnected.getCPtr(mesh), mdensity, compute_mass, visualize, collide, ChMaterialSurface.getCPtr(material), sphere_swept), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(ChTriangleMeshConnected mesh, double mdensity, bool compute_mass, bool visualize, bool collide, ChMaterialSurface material) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_9(ChTriangleMeshConnected.getCPtr(mesh), mdensity, compute_mass, visualize, collide, ChMaterialSurface.getCPtr(material)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(ChTriangleMeshConnected mesh, double mdensity, bool compute_mass, bool visualize, bool collide) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_10(ChTriangleMeshConnected.getCPtr(mesh), mdensity, compute_mass, visualize, collide), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(ChTriangleMeshConnected mesh, double mdensity, bool compute_mass, bool visualize) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_11(ChTriangleMeshConnected.getCPtr(mesh), mdensity, compute_mass, visualize), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(ChTriangleMeshConnected mesh, double mdensity, bool compute_mass) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_12(ChTriangleMeshConnected.getCPtr(mesh), mdensity, compute_mass), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyMesh(ChTriangleMeshConnected mesh, double mdensity) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyMesh__SWIG_13(ChTriangleMeshConnected.getCPtr(mesh), mdensity), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetupBody(ChTriangleMeshConnected trimesh, string name, double mdensity, bool compute_mass, bool visualize, bool collide, ChMaterialSurface material, double sphere_swept, ChCollisionModel collision_model) {
    ChronoEngine_csharpPINVOKE.ChBodyEasyMesh_SetupBody(swigCPtr, ChTriangleMeshConnected.getCPtr(trimesh), name, mdensity, compute_mass, visualize, collide, ChMaterialSurface.getCPtr(material), sphere_swept, ChCollisionModel.getCPtr(collision_model));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
