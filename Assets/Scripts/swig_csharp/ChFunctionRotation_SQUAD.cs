//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunctionRotation_SQUAD : ChFunctionRotation {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChFunctionRotation_SQUAD(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunctionRotation_SQUAD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChFunctionRotation_SQUAD(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFunctionRotation_SQUAD() : this(ChronoEngine_csharpPINVOKE.new_ChFunctionRotation_SQUAD__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_SQUAD(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t mrotations, ChVectorDynamicD mknots) : this(ChronoEngine_csharpPINVOKE.new_ChFunctionRotation_SQUAD__SWIG_1(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t.getCPtr(mrotations), ChVectorDynamicD.getCPtr(mknots)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_SQUAD(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t mrotations) : this(ChronoEngine_csharpPINVOKE.new_ChFunctionRotation_SQUAD__SWIG_2(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t.getCPtr(mrotations)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_SQUAD(ChFunctionRotation_SQUAD other) : this(ChronoEngine_csharpPINVOKE.new_ChFunctionRotation_SQUAD__SWIG_3(ChFunctionRotation_SQUAD.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChFunctionRotation Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_Clone(swigCPtr);
    ChFunctionRotation_SQUAD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunctionRotation_SQUAD(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ComputeUfromKnotU(double u) {
    double ret = ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_ComputeUfromKnotU(swigCPtr, u);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ComputeKnotUfromU(double U) {
    double ret = ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_ComputeKnotUfromU(swigCPtr, U);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t Rotations() {
    SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t ret = new SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t(ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_Rotations(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD Knots() {
    ChVectorDynamicD ret = new ChVectorDynamicD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_Knots(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetOrder() {
    int ret = ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_GetOrder(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetupData(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t mrotations, ChVectorDynamicD mknots) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_SetupData__SWIG_0(swigCPtr, SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t.getCPtr(mrotations), ChVectorDynamicD.getCPtr(mknots));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetupData(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t mrotations) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_SetupData__SWIG_1(swigCPtr, SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t.getCPtr(mrotations));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction GetSpaceFunction() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_GetSpaceFunction(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSpaceFunction(ChFunction m_funct) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_SetSpaceFunction(swigCPtr, ChFunction.getCPtr(m_funct));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetClosed(bool mc) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_SetClosed(swigCPtr, mc);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetClosed() {
    bool ret = ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_GetClosed(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChQuaternionD Get_q(double s) {
    ChQuaternionD ret = new ChQuaternionD(ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_Get_q(swigCPtr, s), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChFunctionRotation_SQUAD_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
