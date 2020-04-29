//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class LoadLoaderForceOnSurface : ChLoadBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal LoadLoaderForceOnSurface(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LoadLoaderForceOnSurface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_LoadLoaderForceOnSurface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoaderForceOnSurface loader {
    set {
      ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_loader_set(swigCPtr, ChLoaderForceOnSurface.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ChLoaderForceOnSurface ret = new ChLoaderForceOnSurface(ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_loader_get(swigCPtr), true);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public LoadLoaderForceOnSurface(ChLoadableUV mloadable) : this(ChronoEngine_csharpPINVOKE.new_LoadLoaderForceOnSurface(ChLoadableUV.getCPtr(mloadable)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_Clone(swigCPtr);
    LoadLoaderForceOnSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new LoadLoaderForceOnSurface(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int LoadGet_ndof_x() {
    int ret = ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_LoadGet_ndof_x(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int LoadGet_ndof_w() {
    int ret = ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_LoadGet_ndof_w(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void LoadGetStateBlock_x(ChState mD) {
    ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_LoadGetStateBlock_x(swigCPtr, ChState.getCPtr(mD));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadGetStateBlock_w(ChStateDelta mD) {
    ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_LoadGetStateBlock_w(swigCPtr, ChStateDelta.getCPtr(mD));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadStateIncrement(ChState x, ChStateDelta dw, ChState x_new) {
    ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_LoadStateIncrement(swigCPtr, ChState.getCPtr(x), ChStateDelta.getCPtr(dw), ChState.getCPtr(x_new));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int LoadGet_field_ncoords() {
    int ret = ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_LoadGet_field_ncoords(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ComputeQ(ChState state_x, ChStateDelta state_w) {
    ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_ComputeQ(swigCPtr, ChState.getCPtr(state_x), ChStateDelta.getCPtr(state_w));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadIntLoadResidual_F(ChVectorDynamicD R, double c) {
    ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_LoadIntLoadResidual_F(swigCPtr, ChVectorDynamicD.getCPtr(R), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool IsStiff() {
    bool ret = ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_IsStiff(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void CreateJacobianMatrices() {
    ChronoEngine_csharpPINVOKE.LoadLoaderForceOnSurface_CreateJacobianMatrices(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}