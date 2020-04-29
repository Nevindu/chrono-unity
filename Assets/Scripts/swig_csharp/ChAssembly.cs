//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChAssembly : ChPhysicsItem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChAssembly(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChAssembly_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChAssembly obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChAssembly(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChAssembly() : this(ChronoEngine_csharpPINVOKE.new_ChAssembly__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChAssembly(ChAssembly other) : this(ChronoEngine_csharpPINVOKE.new_ChAssembly__SWIG_1(ChAssembly.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAssembly_Clone(swigCPtr);
    ChAssembly ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChAssembly(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    ChronoEngine_csharpPINVOKE.ChAssembly_Clear(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddBody(ChBody body) {
    ChronoEngine_csharpPINVOKE.ChAssembly_AddBody(swigCPtr, ChBody.getCPtr(body));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddLink(ChLinkBase link) {
    ChronoEngine_csharpPINVOKE.ChAssembly_AddLink(swigCPtr, ChLinkBase.getCPtr(link));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddMesh(SWIGTYPE_p_std__shared_ptrT_fea__ChMesh_t mesh) {
    ChronoEngine_csharpPINVOKE.ChAssembly_AddMesh(swigCPtr, SWIGTYPE_p_std__shared_ptrT_fea__ChMesh_t.getCPtr(mesh));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddOtherPhysicsItem(ChPhysicsItem item) {
    ChronoEngine_csharpPINVOKE.ChAssembly_AddOtherPhysicsItem(swigCPtr, ChPhysicsItem.getCPtr(item));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(ChPhysicsItem item) {
    ChronoEngine_csharpPINVOKE.ChAssembly_Add(swigCPtr, ChPhysicsItem.getCPtr(item));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddBatch(ChPhysicsItem item) {
    ChronoEngine_csharpPINVOKE.ChAssembly_AddBatch(swigCPtr, ChPhysicsItem.getCPtr(item));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void FlushBatch() {
    ChronoEngine_csharpPINVOKE.ChAssembly_FlushBatch(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveBody(ChBody body) {
    ChronoEngine_csharpPINVOKE.ChAssembly_RemoveBody(swigCPtr, ChBody.getCPtr(body));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveLink(ChLinkBase link) {
    ChronoEngine_csharpPINVOKE.ChAssembly_RemoveLink(swigCPtr, ChLinkBase.getCPtr(link));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveMesh(SWIGTYPE_p_std__shared_ptrT_fea__ChMesh_t mesh) {
    ChronoEngine_csharpPINVOKE.ChAssembly_RemoveMesh(swigCPtr, SWIGTYPE_p_std__shared_ptrT_fea__ChMesh_t.getCPtr(mesh));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveOtherPhysicsItem(ChPhysicsItem item) {
    ChronoEngine_csharpPINVOKE.ChAssembly_RemoveOtherPhysicsItem(swigCPtr, ChPhysicsItem.getCPtr(item));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Remove(ChPhysicsItem item) {
    ChronoEngine_csharpPINVOKE.ChAssembly_Remove(swigCPtr, ChPhysicsItem.getCPtr(item));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAllBodies() {
    ChronoEngine_csharpPINVOKE.ChAssembly_RemoveAllBodies(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAllLinks() {
    ChronoEngine_csharpPINVOKE.ChAssembly_RemoveAllLinks(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAllMeshes() {
    ChronoEngine_csharpPINVOKE.ChAssembly_RemoveAllMeshes(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAllOtherPhysicsItems() {
    ChronoEngine_csharpPINVOKE.ChAssembly_RemoveAllOtherPhysicsItems(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_ChBody Get_bodylist() {
    vector_ChBody ret = new vector_ChBody(ChronoEngine_csharpPINVOKE.ChAssembly_Get_bodylist(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_std__shared_ptrT_chrono__ChLinkBase_t_t Get_linklist() {
    SWIGTYPE_p_std__vectorT_std__shared_ptrT_chrono__ChLinkBase_t_t ret = new SWIGTYPE_p_std__vectorT_std__shared_ptrT_chrono__ChLinkBase_t_t(ChronoEngine_csharpPINVOKE.ChAssembly_Get_linklist(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_std__shared_ptrT_fea__ChMesh_t_t Get_meshlist() {
    SWIGTYPE_p_std__vectorT_std__shared_ptrT_fea__ChMesh_t_t ret = new SWIGTYPE_p_std__vectorT_std__shared_ptrT_fea__ChMesh_t_t(ChronoEngine_csharpPINVOKE.ChAssembly_Get_meshlist(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_ChPhysicsItem Get_otherphysicslist() {
    vector_ChPhysicsItem ret = new vector_ChPhysicsItem(ChronoEngine_csharpPINVOKE.ChAssembly_Get_otherphysicslist(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChBody SearchBody(string name) {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAssembly_SearchBody(swigCPtr, name);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLinkBase SearchLink(string name) {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAssembly_SearchLink(swigCPtr, name);
    ChLinkBase ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkBase(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__shared_ptrT_fea__ChMesh_t SearchMesh(string name) {
    SWIGTYPE_p_std__shared_ptrT_fea__ChMesh_t ret = new SWIGTYPE_p_std__shared_ptrT_fea__ChMesh_t(ChronoEngine_csharpPINVOKE.ChAssembly_SearchMesh(swigCPtr, name), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChPhysicsItem SearchOtherPhysicsItem(string name) {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAssembly_SearchOtherPhysicsItem(swigCPtr, name);
    ChPhysicsItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChPhysicsItem(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChMarker SearchMarker(string name) {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAssembly_SearchMarker__SWIG_0(swigCPtr, name);
    ChMarker ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMarker(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChPhysicsItem Search(string name) {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAssembly_Search(swigCPtr, name);
    ChPhysicsItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChPhysicsItem(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChBody SearchBodyID(int bodyID) {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAssembly_SearchBodyID(swigCPtr, bodyID);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChMarker SearchMarker(int markID) {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChAssembly_SearchMarker__SWIG_1(swigCPtr, markID);
    ChMarker ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMarker(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNbodies() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNbodies(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNbodiesSleeping() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNbodiesSleeping(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNbodiesFixed() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNbodiesFixed(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNbodiesTotal() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNbodiesTotal(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNlinks() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNlinks(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNmeshes() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNmeshes(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNphysicsItems() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNphysicsItems(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNcoords() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNcoords(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNdof() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNdof(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNdoc() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNdoc(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNsysvars() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNsysvars(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNcoords_w() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNcoords_w(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNdoc_w() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNdoc_w(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNdoc_w_C() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNdoc_w_C(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNdoc_w_D() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNdoc_w_D(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNsysvars_w() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetNsysvars_w(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SetSystem(ChSystem m_system) {
    ChronoEngine_csharpPINVOKE.ChAssembly_SetSystem(swigCPtr, ChSystem.getCPtr(m_system));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SyncCollisionModels() {
    ChronoEngine_csharpPINVOKE.ChAssembly_SyncCollisionModels(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Setup() {
    ChronoEngine_csharpPINVOKE.ChAssembly_Setup(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime, bool update_assets) {
    ChronoEngine_csharpPINVOKE.ChAssembly_Update__SWIG_0(swigCPtr, mytime, update_assets);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime) {
    ChronoEngine_csharpPINVOKE.ChAssembly_Update__SWIG_1(swigCPtr, mytime);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(bool update_assets) {
    ChronoEngine_csharpPINVOKE.ChAssembly_Update__SWIG_2(swigCPtr, update_assets);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update() {
    ChronoEngine_csharpPINVOKE.ChAssembly_Update__SWIG_3(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetNoSpeedNoAcceleration() {
    ChronoEngine_csharpPINVOKE.ChAssembly_SetNoSpeedNoAcceleration(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int GetDOF() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetDOF(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOF_w() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetDOF_w(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetDOC(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC_c() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetDOC_c(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC_d() {
    int ret = ChronoEngine_csharpPINVOKE.ChAssembly_GetDOC_d(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void IntStateGather(uint off_x, ChState x, uint off_v, ChStateDelta v, SWIGTYPE_p_double T) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntStateGather(swigCPtr, off_x, ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(v), SWIGTYPE_p_double.getCPtr(T));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatter(uint off_x, ChState x, uint off_v, ChStateDelta v, double T) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntStateScatter(swigCPtr, off_x, ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(v), T);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGatherAcceleration(uint off_a, ChStateDelta a) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntStateGatherAcceleration(swigCPtr, off_a, ChStateDelta.getCPtr(a));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterAcceleration(uint off_a, ChStateDelta a) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntStateScatterAcceleration(swigCPtr, off_a, ChStateDelta.getCPtr(a));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGatherReactions(uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntStateGatherReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterReactions(uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntStateScatterReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateIncrement(uint off_x, ChState x_new, ChState x, uint off_v, ChStateDelta Dv) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntStateIncrement(swigCPtr, off_x, ChState.getCPtr(x_new), ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(Dv));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_F(uint off, ChVectorDynamicD R, double c) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntLoadResidual_F(swigCPtr, off, ChVectorDynamicD.getCPtr(R), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_Mv(uint off, ChVectorDynamicD R, ChVectorDynamicD w, double c) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntLoadResidual_Mv(swigCPtr, off, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(w), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_CqL(uint off_L, ChVectorDynamicD R, ChVectorDynamicD L, double c) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntLoadResidual_CqL(swigCPtr, off_L, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(L), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_C(uint off, ChVectorDynamicD Qc, double c, bool do_clamp, double recovery_clamp) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntLoadConstraint_C(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c, do_clamp, recovery_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_Ct(uint off, ChVectorDynamicD Qc, double c) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntLoadConstraint_Ct(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntToDescriptor(uint off_v, ChStateDelta v, ChVectorDynamicD R, uint off_L, ChVectorDynamicD L, ChVectorDynamicD Qc) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntToDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), ChVectorDynamicD.getCPtr(R), off_L, ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(Qc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntFromDescriptor(uint off_v, ChStateDelta v, uint off_L, ChVectorDynamicD L) {
    ChronoEngine_csharpPINVOKE.ChAssembly_IntFromDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), off_L, ChVectorDynamicD.getCPtr(L));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectVariables(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_InjectVariables(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectConstraints(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_InjectConstraints(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsLoadJacobians() {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsLoadJacobians(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectKRMmatrices(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_InjectKRMmatrices(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void KRMmatricesLoad(double Kfactor, double Rfactor, double Mfactor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_KRMmatricesLoad(swigCPtr, Kfactor, Rfactor, Mfactor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbReset() {
    ChronoEngine_csharpPINVOKE.ChAssembly_VariablesFbReset(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbLoadForces(double factor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_VariablesFbLoadForces__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbLoadForces() {
    ChronoEngine_csharpPINVOKE.ChAssembly_VariablesFbLoadForces__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbLoadSpeed() {
    ChronoEngine_csharpPINVOKE.ChAssembly_VariablesQbLoadSpeed(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbIncrementMq() {
    ChronoEngine_csharpPINVOKE.ChAssembly_VariablesFbIncrementMq(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbSetSpeed(double step) {
    ChronoEngine_csharpPINVOKE.ChAssembly_VariablesQbSetSpeed__SWIG_0(swigCPtr, step);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbSetSpeed() {
    ChronoEngine_csharpPINVOKE.ChAssembly_VariablesQbSetSpeed__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbIncrementPosition(double step) {
    ChronoEngine_csharpPINVOKE.ChAssembly_VariablesQbIncrementPosition(swigCPtr, step);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiReset() {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiReset(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp, bool do_clamp) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiLoad_C__SWIG_0(swigCPtr, factor, recovery_clamp, do_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiLoad_C__SWIG_1(swigCPtr, factor, recovery_clamp);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiLoad_C__SWIG_2(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C() {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiLoad_C__SWIG_3(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct(double factor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiLoad_Ct__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct() {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiLoad_Ct__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Qc(double factor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiLoad_Qc__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Qc() {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsBiLoad_Qc__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFbLoadForces(double factor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsFbLoadForces__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFbLoadForces() {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsFbLoadForces__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react(double factor) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsFetch_react__SWIG_0(swigCPtr, factor);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react() {
    ChronoEngine_csharpPINVOKE.ChAssembly_ConstraintsFetch_react__SWIG_1(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ShowHierarchy(ChStreamOutAscii m_file, int level) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ShowHierarchy__SWIG_0(swigCPtr, ChStreamOutAscii.getCPtr(m_file), level);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ShowHierarchy(ChStreamOutAscii m_file) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ShowHierarchy__SWIG_1(swigCPtr, ChStreamOutAscii.getCPtr(m_file));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChAssembly_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
