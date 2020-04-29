//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkTSDA : ChLink {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkTSDA(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLinkTSDA_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkTSDA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLinkTSDA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkTSDA() : this(ChronoEngine_csharpPINVOKE.new_ChLinkTSDA__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkTSDA(ChLinkTSDA other) : this(ChronoEngine_csharpPINVOKE.new_ChLinkTSDA__SWIG_1(ChLinkTSDA.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkTSDA_Clone(swigCPtr);
    ChLinkTSDA ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkTSDA(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRestLength(double len) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_SetRestLength(swigCPtr, len);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSpringCoefficient(double k) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_SetSpringCoefficient(swigCPtr, k);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDampingCoefficient(double r) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_SetDampingCoefficient(swigCPtr, r);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetActuatorForce(double f) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_SetActuatorForce(swigCPtr, f);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void IsStiff(bool val) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_IsStiff(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorDynamicD GetStates() {
    ChVectorDynamicD ret = new ChVectorDynamicD(ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetStates(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRestLength() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetRestLength(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetLength() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetLength(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetDeformation() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetDeformation(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetVelocity() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetVelocity(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetForce() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetForce(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPoint1Rel() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetPoint1Rel(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPoint1Abs() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetPoint1Abs(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPoint2Rel() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetPoint2Rel(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPoint2Abs() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetPoint2Abs(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringCoefficient() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetSpringCoefficient(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetDampingCoefficient() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetDampingCoefficient(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetActuatorForce() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkTSDA_GetActuatorForce(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RegisterForceFunctor(ForceFunctor functor) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_RegisterForceFunctor(swigCPtr, ForceFunctor.getCPtr(functor));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterODE(ODE functor) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_RegisterODE(swigCPtr, ODE.getCPtr(functor));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBody body1, ChBody body2, bool pos_are_relative, ChVectorD loc1, ChVectorD loc2, bool auto_rest_length, double rest_length) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_Initialize__SWIG_0(swigCPtr, ChBody.getCPtr(body1), ChBody.getCPtr(body2), pos_are_relative, ChVectorD.getCPtr(loc1), ChVectorD.getCPtr(loc2), auto_rest_length, rest_length);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBody body1, ChBody body2, bool pos_are_relative, ChVectorD loc1, ChVectorD loc2, bool auto_rest_length) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_Initialize__SWIG_1(swigCPtr, ChBody.getCPtr(body1), ChBody.getCPtr(body2), pos_are_relative, ChVectorD.getCPtr(loc1), ChVectorD.getCPtr(loc2), auto_rest_length);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBody body1, ChBody body2, bool pos_are_relative, ChVectorD loc1, ChVectorD loc2) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_Initialize__SWIG_2(swigCPtr, ChBody.getCPtr(body1), ChBody.getCPtr(body2), pos_are_relative, ChVectorD.getCPtr(loc1), ChVectorD.getCPtr(loc2));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkTSDA_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}