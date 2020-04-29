//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChAparticle : ChParticleBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChAparticle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChAparticle_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChAparticle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChAparticle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChAparticle() : this(ChronoEngine_csharpPINVOKE.new_ChAparticle__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChAparticle(ChAparticle other) : this(ChronoEngine_csharpPINVOKE.new_ChAparticle__SWIG_1(ChAparticle.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override SWIGTYPE_p_ChVariables Variables() {
    SWIGTYPE_p_ChVariables ret = new SWIGTYPE_p_ChVariables(ChronoEngine_csharpPINVOKE.ChAparticle_Variables(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChParticlesClones GetContainer() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAparticle_GetContainer(swigCPtr);
    ChParticlesClones ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChParticlesClones(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetContainer(ChParticlesClones mc) {
    ChronoEngine_csharpPINVOKE.ChAparticle_SetContainer(swigCPtr, ChParticlesClones.getCPtr(mc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_ChContactable__eChContactableType GetContactableType() {
    SWIGTYPE_p_ChContactable__eChContactableType ret = new SWIGTYPE_p_ChContactable__eChContactableType(ChronoEngine_csharpPINVOKE.ChAparticle_GetContactableType(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_ChVariables GetVariables1() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAparticle_GetVariables1(swigCPtr);
    SWIGTYPE_p_ChVariables ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ChVariables(cPtr, false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool IsContactActive() {
    bool ret = ChronoEngine_csharpPINVOKE.ChAparticle_IsContactActive(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int ContactableGet_ndof_x() {
    int ret = ChronoEngine_csharpPINVOKE.ChAparticle_ContactableGet_ndof_x(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int ContactableGet_ndof_w() {
    int ret = ChronoEngine_csharpPINVOKE.ChAparticle_ContactableGet_ndof_w(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ContactableGetStateBlock_x(ChState x) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ContactableGetStateBlock_x(swigCPtr, ChState.getCPtr(x));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ContactableGetStateBlock_w(ChStateDelta w) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ContactableGetStateBlock_w(swigCPtr, ChStateDelta.getCPtr(w));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ContactableIncrementState(ChState x, ChStateDelta dw, ChState x_new) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ContactableIncrementState(swigCPtr, ChState.getCPtr(x), ChStateDelta.getCPtr(dw), ChState.getCPtr(x_new));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ChVectorD GetContactPoint(ChVectorD loc_point, ChState state_x) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChAparticle_GetContactPoint(swigCPtr, ChVectorD.getCPtr(loc_point), ChState.getCPtr(state_x)), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetContactPointSpeed(ChVectorD loc_point, ChState state_x, ChStateDelta state_w) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChAparticle_GetContactPointSpeed__SWIG_0(swigCPtr, ChVectorD.getCPtr(loc_point), ChState.getCPtr(state_x), ChStateDelta.getCPtr(state_w)), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetContactPointSpeed(ChVectorD abs_point) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChAparticle_GetContactPointSpeed__SWIG_1(swigCPtr, ChVectorD.getCPtr(abs_point)), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChCoordsysD GetCsysForCollisionModel() {
    ChCoordsysD ret = new ChCoordsysD(ChronoEngine_csharpPINVOKE.ChAparticle_GetCsysForCollisionModel(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ContactForceLoadResidual_F(ChVectorD F, ChVectorD abs_point, ChVectorDynamicD R) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ContactForceLoadResidual_F(swigCPtr, ChVectorD.getCPtr(F), ChVectorD.getCPtr(abs_point), ChVectorDynamicD.getCPtr(R));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ContactForceLoadQ(ChVectorD F, ChVectorD point, ChState state_x, ChVectorDynamicD Q, int offset) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ContactForceLoadQ(swigCPtr, ChVectorD.getCPtr(F), ChVectorD.getCPtr(point), ChState.getCPtr(state_x), ChVectorDynamicD.getCPtr(Q), offset);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ComputeJacobianForContactPart(ChVectorD abs_point, ChMatrix33D contact_plane, SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple jacobian_tuple_N, SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple jacobian_tuple_U, SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple jacobian_tuple_V, bool second) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ComputeJacobianForContactPart(swigCPtr, ChVectorD.getCPtr(abs_point), ChMatrix33D.getCPtr(contact_plane), SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple.getCPtr(jacobian_tuple_N), SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple.getCPtr(jacobian_tuple_U), SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple.getCPtr(jacobian_tuple_V), second);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ComputeJacobianForRollingContactPart(ChVectorD abs_point, ChMatrix33D contact_plane, SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple jacobian_tuple_N, SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple jacobian_tuple_U, SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple jacobian_tuple_V, bool second) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ComputeJacobianForRollingContactPart(swigCPtr, ChVectorD.getCPtr(abs_point), ChMatrix33D.getCPtr(contact_plane), SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple.getCPtr(jacobian_tuple_N), SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple.getCPtr(jacobian_tuple_U), SWIGTYPE_p_ChVariableTupleCarrier_1varsT_6_t__type_constraint_tuple.getCPtr(jacobian_tuple_V), second);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetContactableMass() {
    double ret = ChronoEngine_csharpPINVOKE.ChAparticle_GetContactableMass(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChPhysicsItem GetPhysicsItem() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAparticle_GetPhysicsItem(swigCPtr);
    ChPhysicsItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChPhysicsItem(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChAparticle_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChParticlesClones container {
    set {
      ChronoEngine_csharpPINVOKE.ChAparticle_container_set(swigCPtr, ChParticlesClones.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAparticle_container_get(swigCPtr);
      ChParticlesClones ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChParticlesClones(cPtr, true);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_ChVariablesBodySharedMass variables {
    set {
      ChronoEngine_csharpPINVOKE.ChAparticle_variables_set(swigCPtr, SWIGTYPE_p_ChVariablesBodySharedMass.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_ChVariablesBodySharedMass ret = new SWIGTYPE_p_ChVariablesBodySharedMass(ChronoEngine_csharpPINVOKE.ChAparticle_variables_get(swigCPtr), true);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChCollisionModel collision_model {
    set {
      ChronoEngine_csharpPINVOKE.ChAparticle_collision_model_set(swigCPtr, ChCollisionModel.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAparticle_collision_model_get(swigCPtr);
      ChCollisionModel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChCollisionModel(cPtr, true);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChVectorD UserForce {
    set {
      ChronoEngine_csharpPINVOKE.ChAparticle_UserForce_set(swigCPtr, ChVectorD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAparticle_UserForce_get(swigCPtr);
      ChVectorD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVectorD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChVectorD UserTorque {
    set {
      ChronoEngine_csharpPINVOKE.ChAparticle_UserTorque_set(swigCPtr, ChVectorD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAparticle_UserTorque_get(swigCPtr);
      ChVectorD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVectorD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
