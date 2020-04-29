//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChBodyEasySphere : ChBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChBodyEasySphere(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChBodyEasySphere_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChBodyEasySphere obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChBodyEasySphere(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChBodyEasySphere(double radius, double mdensity, bool visualize, bool collide, ChMaterialSurface material, ChCollisionModel collision_model) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasySphere__SWIG_0(radius, mdensity, visualize, collide, ChMaterialSurface.getCPtr(material), ChCollisionModel.getCPtr(collision_model)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasySphere(double radius, double mdensity, bool visualize, bool collide, ChMaterialSurface material) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasySphere__SWIG_1(radius, mdensity, visualize, collide, ChMaterialSurface.getCPtr(material)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasySphere(double radius, double mdensity, bool visualize, bool collide) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasySphere__SWIG_2(radius, mdensity, visualize, collide), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasySphere(double radius, double mdensity, bool visualize) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasySphere__SWIG_3(radius, mdensity, visualize), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasySphere(double radius, double mdensity) : this(ChronoEngine_csharpPINVOKE.new_ChBodyEasySphere__SWIG_4(radius, mdensity), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}