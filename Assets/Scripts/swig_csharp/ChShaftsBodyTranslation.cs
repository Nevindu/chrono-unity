//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChShaftsBodyTranslation : ChPhysicsItem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChShaftsBodyTranslation(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChShaftsBodyTranslation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChShaftsBodyTranslation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChShaftsBodyTranslation() : this(ChronoEngine_csharpPINVOKE.new_ChShaftsBodyTranslation__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChShaftsBodyTranslation(ChShaftsBodyTranslation other) : this(ChronoEngine_csharpPINVOKE.new_ChShaftsBodyTranslation__SWIG_1(ChShaftsBodyTranslation.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_Clone(swigCPtr);
    ChShaftsBodyTranslation ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaftsBodyTranslation(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetNumCoords() {
    int ret = ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_GetNumCoords(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC_c() {
    int ret = ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_GetDOC_c(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void IntStateGatherReactions(uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_IntStateGatherReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterReactions(uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_IntStateScatterReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_CqL(uint off_L, ChVectorDynamicD R, ChVectorDynamicD L, double c) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_IntLoadResidual_CqL(swigCPtr, off_L, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(L), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_C(uint off, ChVectorDynamicD Qc, double c, bool do_clamp, double recovery_clamp) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_IntLoadConstraint_C(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c, do_clamp, recovery_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_Ct(uint off, ChVectorDynamicD Qc, double c) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_IntLoadConstraint_Ct(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntToDescriptor(uint off_v, ChStateDelta v, ChVectorDynamicD R, uint off_L, ChVectorDynamicD L, ChVectorDynamicD Qc) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_IntToDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), ChVectorDynamicD.getCPtr(R), off_L, ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(Qc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntFromDescriptor(uint off_v, ChStateDelta v, uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_IntFromDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectConstraints(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_InjectConstraints(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiReset() {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsBiReset(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp, bool do_clamp) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsBiLoad_C__SWIG_0(swigCPtr, factor, recovery_clamp, do_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsBiLoad_C__SWIG_1(swigCPtr, factor, recovery_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsBiLoad_C__SWIG_2(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C() {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsBiLoad_C__SWIG_3(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct(double factor) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsBiLoad_Ct__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct() {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsBiLoad_Ct__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsLoadJacobians() {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsLoadJacobians(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react(double factor) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsFetch_react__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react() {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ConstraintsFetch_react__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Initialize(ChShaft mshaft, ChBodyFrame mbody, ChVectorD mdir, ChVectorD mpos) {
    bool ret = ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_Initialize(swigCPtr, ChShaft.getCPtr(mshaft), ChBodyFrame.getCPtr(mbody), ChVectorD.getCPtr(mdir), ChVectorD.getCPtr(mpos));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChShaft GetShaft() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_GetShaft(swigCPtr);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChBodyFrame GetBody() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_GetBody(swigCPtr);
    ChBodyFrame ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBodyFrame(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetShaftDirection(ChVectorD md) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_SetShaftDirection(swigCPtr, ChVectorD.getCPtr(md));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetShaftDirection() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_GetShaftDirection(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetShaftPos(ChVectorD md) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_SetShaftPos(swigCPtr, ChVectorD.getCPtr(md));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetShaftPos() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_GetShaftPos(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetForceReactionOnShaft() {
    double ret = ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_GetForceReactionOnShaft(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetForceReactionOnBody() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_GetForceReactionOnBody(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Update(double mytime, bool update_assets) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_Update__SWIG_0(swigCPtr, mytime, update_assets);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_Update__SWIG_1(swigCPtr, mytime);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChShaftsBodyTranslation_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
