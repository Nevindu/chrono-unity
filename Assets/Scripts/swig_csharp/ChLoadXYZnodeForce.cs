//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadXYZnodeForce : ChLoadCustom {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadXYZnodeForce(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForce_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadXYZnodeForce obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLoadXYZnodeForce(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void ComputeForce(ChVectorD abs_pos, ChVectorD abs_vel, ChVectorD abs_force) {
    ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForce_ComputeForce(swigCPtr, ChVectorD.getCPtr(abs_pos), ChVectorD.getCPtr(abs_vel), ChVectorD.getCPtr(abs_force));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeQ(ChState state_x, ChStateDelta state_w) {
    ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForce_ComputeQ(swigCPtr, ChState.getCPtr(state_x), ChStateDelta.getCPtr(state_w));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetForce() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLoadXYZnodeForce_GetForce(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}