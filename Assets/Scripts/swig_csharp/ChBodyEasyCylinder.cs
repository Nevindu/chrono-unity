//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChBodyEasyCylinder : ChBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChBodyEasyCylinder(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChBodyEasyCylinder_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChBodyEasyCylinder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChBodyEasyCylinder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChBodyEasyCylinder(double radius, double height, double mdensity, bool visualize, bool collide, ChMaterialSurface material, ChCollisionModel collision_model) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyCylinder__SWIG_0(radius, height, mdensity, visualize, collide, ChMaterialSurface.getCPtr(material), ChCollisionModel.getCPtr(collision_model)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(double radius, double height, double mdensity, bool visualize, bool collide, ChMaterialSurface material) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyCylinder__SWIG_1(radius, height, mdensity, visualize, collide, ChMaterialSurface.getCPtr(material)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(double radius, double height, double mdensity, bool visualize, bool collide) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyCylinder__SWIG_2(radius, height, mdensity, visualize, collide), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(double radius, double height, double mdensity, bool visualize) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyCylinder__SWIG_3(radius, height, mdensity, visualize), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(double radius, double height, double mdensity) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasyCylinder__SWIG_4(radius, height, mdensity), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}