//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class LoadLoaderPressure : ChLoadBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal LoadLoaderPressure(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.LoadLoaderPressure_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LoadLoaderPressure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_LoadLoaderPressure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoaderPressure loader {
    set {
      ChronoEngine_csharpPINVOKE.LoadLoaderPressure_loader_set(swigCPtr, ChLoaderPressure.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ChLoaderPressure ret = new ChLoaderPressure(ChronoEngine_csharpPINVOKE.LoadLoaderPressure_loader_get(swigCPtr), true);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public LoadLoaderPressure(ChLoadableUV mloadable) : this(ChronoEngine_csharpPINVOKE.new_LoadLoaderPressure(ChLoadableUV.getCPtr(mloadable)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChObj Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.LoadLoaderPressure_Clone(swigCPtr);
    LoadLoaderPressure ret = (cPtr == global::System.IntPtr.Zero) ? null : new LoadLoaderPressure(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int LoadGet_ndof_x() {
    int ret = ChronoEngine_csharpPINVOKE.LoadLoaderPressure_LoadGet_ndof_x(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int LoadGet_ndof_w() {
    int ret = ChronoEngine_csharpPINVOKE.LoadLoaderPressure_LoadGet_ndof_w(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void LoadGetStateBlock_x(ChState mD) {
    ChronoEngine_csharpPINVOKE.LoadLoaderPressure_LoadGetStateBlock_x(swigCPtr, ChState.getCPtr(mD));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadGetStateBlock_w(ChStateDelta mD) {
    ChronoEngine_csharpPINVOKE.LoadLoaderPressure_LoadGetStateBlock_w(swigCPtr, ChStateDelta.getCPtr(mD));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadStateIncrement(ChState x, ChStateDelta dw, ChState x_new) {
    ChronoEngine_csharpPINVOKE.LoadLoaderPressure_LoadStateIncrement(swigCPtr, ChState.getCPtr(x), ChStateDelta.getCPtr(dw), ChState.getCPtr(x_new));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int LoadGet_field_ncoords() {
    int ret = ChronoEngine_csharpPINVOKE.LoadLoaderPressure_LoadGet_field_ncoords(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ComputeQ(ChState state_x, ChStateDelta state_w) {
    ChronoEngine_csharpPINVOKE.LoadLoaderPressure_ComputeQ(swigCPtr, ChState.getCPtr(state_x), ChStateDelta.getCPtr(state_w));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadIntLoadResidual_F(ChVectorDynamicD R, double c) {
    ChronoEngine_csharpPINVOKE.LoadLoaderPressure_LoadIntLoadResidual_F(swigCPtr, ChVectorDynamicD.getCPtr(R), c);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool IsStiff() {
    bool ret = ChronoEngine_csharpPINVOKE.LoadLoaderPressure_IsStiff(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void CreateJacobianMatrices() {
    ChronoEngine_csharpPINVOKE.LoadLoaderPressure_CreateJacobianMatrices(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
