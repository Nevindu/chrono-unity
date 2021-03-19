//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ODE : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ODE(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ODE obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ODE() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ChronoEngine_csharpPINVOKE.delete_ODE(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual int GetNumStates() {
    int ret = ChronoEngine_csharpPINVOKE.ODE_GetNumStates(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetInitialConditions(ChVectorDynamicD states, ChLinkTSDA link) {
    ChronoEngine_csharpPINVOKE.ODE_SetInitialConditions(swigCPtr, ChVectorDynamicD.getCPtr(states), ChLinkTSDA.getCPtr(link));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void CalculateRHS(double time, ChVectorDynamicD states, ChVectorDynamicD rhs, ChLinkTSDA link) {
    ChronoEngine_csharpPINVOKE.ODE_CalculateRHS(swigCPtr, time, ChVectorDynamicD.getCPtr(states), ChVectorDynamicD.getCPtr(rhs), ChLinkTSDA.getCPtr(link));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool CalculateJac(double time, ChVectorDynamicD states, ChVectorDynamicD rhs, ChMatrixDynamicD jac, ChLinkTSDA link) {
    bool ret = ChronoEngine_csharpPINVOKE.ODE_CalculateJac(swigCPtr, time, ChVectorDynamicD.getCPtr(states), ChVectorDynamicD.getCPtr(rhs), ChMatrixDynamicD.getCPtr(jac), ChLinkTSDA.getCPtr(link));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
