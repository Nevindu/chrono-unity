//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoaderForceOnSurface : ChLoaderUVatomic {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoaderForceOnSurface(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLoaderForceOnSurface_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoaderForceOnSurface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLoaderForceOnSurface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoaderForceOnSurface(ChLoadableUV mloadable) : this(ChronoEngine_csharpPINVOKE.new_ChLoaderForceOnSurface(ChLoadableUV.getCPtr(mloadable)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeF(double U, double V, ChVectorDynamicD F, ChVectorDynamicD state_x, ChVectorDynamicD state_w) {
    ChronoEngine_csharpPINVOKE.ChLoaderForceOnSurface_ComputeF(swigCPtr, U, V, ChVectorDynamicD.getCPtr(F), ChVectorDynamicD.getCPtr(state_x), ChVectorDynamicD.getCPtr(state_w));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetForce(ChVectorD mforce) {
    ChronoEngine_csharpPINVOKE.ChLoaderForceOnSurface_SetForce(swigCPtr, ChVectorD.getCPtr(mforce));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetForce() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoaderForceOnSurface_GetForce(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsStiff() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLoaderForceOnSurface_IsStiff(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
