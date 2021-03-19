//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkRevoluteSpherical : ChLink {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkRevoluteSpherical(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkRevoluteSpherical obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLinkRevoluteSpherical(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkRevoluteSpherical() : this(ChronoEngine_csharpPINVOKE.new_ChLinkRevoluteSpherical__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkRevoluteSpherical(ChLinkRevoluteSpherical other) : this(ChronoEngine_csharpPINVOKE.new_ChLinkRevoluteSpherical__SWIG_1(ChLinkRevoluteSpherical.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Clone(swigCPtr);
    ChLinkRevoluteSpherical ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkRevoluteSpherical(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC_c() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetDOC_c(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPoint1Rel() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetPoint1Rel(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetDir1Rel() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetDir1Rel(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPoint2Rel() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetPoint2Rel(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetImposedDistance() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetImposedDistance(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetCurrentDistance() {
    double ret = ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetCurrentDistance(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPoint1Abs() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetPoint1Abs(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetDir1Abs() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetDir1Abs(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPoint2Abs() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetPoint2Abs(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChCoordsysD GetLinkRelativeCoords() {
    ChCoordsysD ret = new ChCoordsysD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetLinkRelativeCoords(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_chrono__ChVectorNT_double_2_t GetC() {
    SWIGTYPE_p_chrono__ChVectorNT_double_2_t ret = new SWIGTYPE_p_chrono__ChVectorNT_double_2_t(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_GetC(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Initialize(ChBody body1, ChBody body2, ChCoordsysD csys, double distance) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Initialize__SWIG_0(swigCPtr, ChBody.getCPtr(body1), ChBody.getCPtr(body2), ChCoordsysD.getCPtr(csys), distance);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBody body1, ChBody body2, bool local, ChVectorD pos1, ChVectorD dir1, ChVectorD pos2, bool auto_distance, double distance) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Initialize__SWIG_1(swigCPtr, ChBody.getCPtr(body1), ChBody.getCPtr(body2), local, ChVectorD.getCPtr(pos1), ChVectorD.getCPtr(dir1), ChVectorD.getCPtr(pos2), auto_distance, distance);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBody body1, ChBody body2, bool local, ChVectorD pos1, ChVectorD dir1, ChVectorD pos2, bool auto_distance) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Initialize__SWIG_2(swigCPtr, ChBody.getCPtr(body1), ChBody.getCPtr(body2), local, ChVectorD.getCPtr(pos1), ChVectorD.getCPtr(dir1), ChVectorD.getCPtr(pos2), auto_distance);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBody body1, ChBody body2, bool local, ChVectorD pos1, ChVectorD dir1, ChVectorD pos2) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Initialize__SWIG_3(swigCPtr, ChBody.getCPtr(body1), ChBody.getCPtr(body2), local, ChVectorD.getCPtr(pos1), ChVectorD.getCPtr(dir1), ChVectorD.getCPtr(pos2));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double time, bool update_assets) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Update__SWIG_0(swigCPtr, time, update_assets);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double time) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Update__SWIG_1(swigCPtr, time);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGatherReactions(uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_IntStateGatherReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterReactions(uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_IntStateScatterReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_CqL(uint off_L, ChVectorDynamicD R, ChVectorDynamicD L, double c) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_IntLoadResidual_CqL(swigCPtr, off_L, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(L), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_C(uint off, ChVectorDynamicD Qc, double c, bool do_clamp, double recovery_clamp) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_IntLoadConstraint_C(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c, do_clamp, recovery_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntToDescriptor(uint off_v, ChStateDelta v, ChVectorDynamicD R, uint off_L, ChVectorDynamicD L, ChVectorDynamicD Qc) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_IntToDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), ChVectorDynamicD.getCPtr(R), off_L, ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(Qc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntFromDescriptor(uint off_v, ChStateDelta v, uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_IntFromDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectConstraints(SWIGTYPE_p_ChSystemDescriptor descriptor) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_InjectConstraints(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(descriptor));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiReset() {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ConstraintsBiReset(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp, bool do_clamp) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ConstraintsBiLoad_C__SWIG_0(swigCPtr, factor, recovery_clamp, do_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ConstraintsBiLoad_C__SWIG_1(swigCPtr, factor, recovery_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ConstraintsBiLoad_C__SWIG_2(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C() {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ConstraintsBiLoad_C__SWIG_3(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsLoadJacobians() {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ConstraintsLoadJacobians(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react(double factor) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ConstraintsFetch_react__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react() {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ConstraintsFetch_react__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD Get_react_force_body1() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Get_react_force_body1(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD Get_react_torque_body1() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Get_react_torque_body1(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD Get_react_force_body2() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Get_react_force_body2(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD Get_react_torque_body2() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_Get_react_torque_body2(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkRevoluteSpherical_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
