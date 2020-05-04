//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunctionRotation_axis : ChFunctionRotation {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChFunctionRotation_axis(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunctionRotation_axis obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChFunctionRotation_axis(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFunctionRotation_axis() : this(ChronoEngine_csharpPINVOKE.new_ChFunctionRotation_axis__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_axis(ChFunctionRotation_axis other) : this(ChronoEngine_csharpPINVOKE.new_ChFunctionRotation_axis__SWIG_1(ChFunctionRotation_axis.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChFunctionRotation Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_Clone(swigCPtr);
    ChFunctionRotation_axis ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunctionRotation_axis(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFunctionAngle(ChFunction mx) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_SetFunctionAngle(swigCPtr, ChFunction.getCPtr(mx));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction GetFunctionAngle() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_GetFunctionAngle(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAxis(ChVectorD mv) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_SetAxis(swigCPtr, ChVectorD.getCPtr(mv));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetAxis() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_GetAxis(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChQuaternionD Get_q(double s) {
    ChQuaternionD ret = new ChQuaternionD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_Get_q(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD Get_w_loc(double s) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_Get_w_loc(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD Get_a_loc(double s) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_Get_a_loc(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_axis_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
