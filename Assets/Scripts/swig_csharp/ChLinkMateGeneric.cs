//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkMateGeneric : ChLinkMate {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkMateGeneric(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkMateGeneric obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLinkMateGeneric(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkMateGeneric(bool mc_x, bool mc_y, bool mc_z, bool mc_rx, bool mc_ry, bool mc_rz) : this(ChronoEngine_csharpPINVOKE.new_ChLinkMateGeneric__SWIG_0(mc_x, mc_y, mc_z, mc_rx, mc_ry, mc_rz), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateGeneric(bool mc_x, bool mc_y, bool mc_z, bool mc_rx, bool mc_ry) : this(ChronoEngine_csharpPINVOKE.new_ChLinkMateGeneric__SWIG_1(mc_x, mc_y, mc_z, mc_rx, mc_ry), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateGeneric(bool mc_x, bool mc_y, bool mc_z, bool mc_rx) : this(ChronoEngine_csharpPINVOKE.new_ChLinkMateGeneric__SWIG_2(mc_x, mc_y, mc_z, mc_rx), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateGeneric(bool mc_x, bool mc_y, bool mc_z) : this(ChronoEngine_csharpPINVOKE.new_ChLinkMateGeneric__SWIG_3(mc_x, mc_y, mc_z), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateGeneric(bool mc_x, bool mc_y) : this(ChronoEngine_csharpPINVOKE.new_ChLinkMateGeneric__SWIG_4(mc_x, mc_y), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateGeneric(bool mc_x) : this(ChronoEngine_csharpPINVOKE.new_ChLinkMateGeneric__SWIG_5(mc_x), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateGeneric() : this(ChronoEngine_csharpPINVOKE.new_ChLinkMateGeneric__SWIG_6(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMateGeneric(ChLinkMateGeneric other) : this(ChronoEngine_csharpPINVOKE.new_ChLinkMateGeneric__SWIG_7(ChLinkMateGeneric.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_Clone(swigCPtr);
    ChLinkMateGeneric ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkMateGeneric(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChCoordsysD GetLinkRelativeCoords() {
    ChCoordsysD ret = new ChCoordsysD(ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetLinkRelativeCoords(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChFrameD GetAssetsFrame(uint nclone) {
    ChFrameD ret = new ChFrameD(ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetAssetsFrame__SWIG_0(swigCPtr, nclone), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChFrameD GetAssetsFrame() {
    ChFrameD ret = new ChFrameD(ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetAssetsFrame__SWIG_1(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFrameD GetFrame1() {
    ChFrameD ret = new ChFrameD(ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetFrame1(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFrameD GetFrame2() {
    ChFrameD ret = new ChFrameD(ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetFrame2(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsConstrainedX() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IsConstrainedX(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsConstrainedY() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IsConstrainedY(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsConstrainedZ() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IsConstrainedZ(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsConstrainedRx() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IsConstrainedRx(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsConstrainedRy() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IsConstrainedRy(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsConstrainedRz() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IsConstrainedRz(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetConstrainedCoords(bool mc_x, bool mc_y, bool mc_z, bool mc_rx, bool mc_ry, bool mc_rz) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_SetConstrainedCoords(swigCPtr, mc_x, mc_y, mc_z, mc_rx, mc_ry, mc_rz);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, ChFrameD mabsframe) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_Initialize__SWIG_0(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), ChFrameD.getCPtr(mabsframe));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, bool pos_are_relative, ChFrameD mframe1, ChFrameD mframe2) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_Initialize__SWIG_1(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), pos_are_relative, ChFrameD.getCPtr(mframe1), ChFrameD.getCPtr(mframe2));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, bool pos_are_relative, ChVectorD mpt1, ChVectorD mpt2, ChVectorD mnorm1, ChVectorD mnorm2) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_Initialize__SWIG_2(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), pos_are_relative, ChVectorD.getCPtr(mpt1), ChVectorD.getCPtr(mpt2), ChVectorD.getCPtr(mnorm1), ChVectorD.getCPtr(mnorm2));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mtime, bool update_assets) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_Update__SWIG_0(swigCPtr, mtime, update_assets);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mtime) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_Update__SWIG_1(swigCPtr, mtime);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int RestoreRedundant() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_RestoreRedundant(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SetDisabled(bool mdis) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_SetDisabled(swigCPtr, mdis);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBroken(bool mon) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_SetBroken(swigCPtr, mon);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int GetDOC() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetDOC(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC_c() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetDOC_c(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC_d() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetDOC_d(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Eigen__MatrixT_double_Eigen__Dynamic_1_Eigen__ColMajor_6_1_t GetC() {
    SWIGTYPE_p_Eigen__MatrixT_double_Eigen__Dynamic_1_Eigen__ColMajor_6_1_t ret = new SWIGTYPE_p_Eigen__MatrixT_double_Eigen__Dynamic_1_Eigen__ColMajor_6_1_t(ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_GetC(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void IntStateGatherReactions(uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IntStateGatherReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterReactions(uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IntStateScatterReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_CqL(uint off_L, ChVectorDynamicD R, ChVectorDynamicD L, double c) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IntLoadResidual_CqL(swigCPtr, off_L, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(L), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_C(uint off, ChVectorDynamicD Qc, double c, bool do_clamp, double recovery_clamp) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IntLoadConstraint_C(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c, do_clamp, recovery_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_Ct(uint off, ChVectorDynamicD Qc, double c) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IntLoadConstraint_Ct(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntToDescriptor(uint off_v, ChStateDelta v, ChVectorDynamicD R, uint off_L, ChVectorDynamicD L, ChVectorDynamicD Qc) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IntToDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), ChVectorDynamicD.getCPtr(R), off_L, ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(Qc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntFromDescriptor(uint off_v, ChStateDelta v, uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_IntFromDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectConstraints(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_InjectConstraints(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiReset() {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsBiReset(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp, bool do_clamp) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsBiLoad_C__SWIG_0(swigCPtr, factor, recovery_clamp, do_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsBiLoad_C__SWIG_1(swigCPtr, factor, recovery_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsBiLoad_C__SWIG_2(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C() {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsBiLoad_C__SWIG_3(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct(double factor) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsBiLoad_Ct__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct() {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsBiLoad_Ct__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsLoadJacobians() {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsLoadJacobians(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react(double factor) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsFetch_react__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react() {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ConstraintsFetch_react__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLinkMateGeneric_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}