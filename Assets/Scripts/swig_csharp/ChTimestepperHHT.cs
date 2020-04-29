//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTimestepperHHT : ChTimestepperIIorder {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTimestepperHHT(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTimestepperHHT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChTimestepperHHT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChTimestepperHHT(ChIntegrableIIorder intgr) : this(ChronoEngine_csharpPINVOKE.new_ChTimestepperHHT__SWIG_0(ChIntegrableIIorder.getCPtr(intgr)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChTimestepperHHT() : this(ChronoEngine_csharpPINVOKE.new_ChTimestepperHHT__SWIG_1(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChTimestepper.Type GetType() {
    ChTimestepper.Type ret = (ChTimestepper.Type)ChronoEngine_csharpPINVOKE.ChTimestepperHHT_GetType(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAlpha(double malpha) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetAlpha(swigCPtr, malpha);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetAlpha() {
    double ret = ChronoEngine_csharpPINVOKE.ChTimestepperHHT_GetAlpha(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMode(ChTimestepperHHT.HHT_Mode mmode) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetMode(swigCPtr, (int)mmode);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetScaling(bool mscaling) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetScaling(swigCPtr, mscaling);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStepControl(bool val) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetStepControl(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMinStepSize(double min_step) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetMinStepSize(swigCPtr, min_step);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxItersSuccess(int iters) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetMaxItersSuccess(swigCPtr, iters);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRequiredSuccessfulSteps(int num_steps) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetRequiredSuccessfulSteps(swigCPtr, num_steps);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStepIncreaseFactor(double factor) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetStepIncreaseFactor(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStepDecreaseFactor(double factor) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetStepDecreaseFactor(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetModifiedNewton(bool val) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_SetModifiedNewton(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Advance(double dt) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_Advance(swigCPtr, dt);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut archive) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(archive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn archive) {
    ChronoEngine_csharpPINVOKE.ChTimestepperHHT_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum HHT_Mode {
    ACCELERATION,
    POSITION
  }

}
