//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkLinActuator : ChLinkLockLock {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkLinActuator(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLinkLinActuator_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkLinActuator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLinkLinActuator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkLinActuator() : this(ChronoEngine_csharpPINVOKE.new_ChLinkLinActuator__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkLinActuator(ChLinkLinActuator other) : this(ChronoEngine_csharpPINVOKE.new_ChLinkLinActuator__SWIG_1(ChLinkLinActuator.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Clone(swigCPtr);
    ChLinkLinActuator ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkLinActuator(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void UpdateTime(double mytime) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_UpdateTime(swigCPtr, mytime);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction Get_dist_funct() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_dist_funct(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFunction Get_motrot_funct() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_motrot_funct(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFunction Get_mottorque_funct() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_mottorque_funct(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_dist_funct(ChFunction mf) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_dist_funct(swigCPtr, ChFunction.getCPtr(mf));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set_motrot_funct(ChFunction mf) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_motrot_funct(swigCPtr, ChFunction.getCPtr(mf));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set_mottorque_funct(ChFunction mf) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_mottorque_funct(swigCPtr, ChFunction.getCPtr(mf));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Get_learn() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_learn(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_learn(bool mset) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_learn(swigCPtr, mset);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Get_learn_torque_rotaton() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_learn_torque_rotaton(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_learn_torque_rotaton(bool mset) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_learn_torque_rotaton(swigCPtr, mset);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_lin_offset() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_lin_offset(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_lin_offset(double mset) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_lin_offset(swigCPtr, mset);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set_mot_tau(double mtau) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_mot_tau(swigCPtr, mtau);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_mot_tau() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_mot_tau(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_mot_eta(double meta) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_mot_eta(swigCPtr, meta);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_mot_eta() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_mot_eta(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_mot_inertia(double min) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Set_mot_inertia(swigCPtr, min);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get_mot_inertia() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_mot_inertia(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get_mot_rerot() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_mot_rerot(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get_mot_rerot_dt() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_mot_rerot_dt(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get_mot_rerot_dtdt() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_mot_rerot_dtdt(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get_mot_retorque() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkLinActuator_Get_mot_retorque(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkLinActuator_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}