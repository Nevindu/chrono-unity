//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTrackAssemblyBandANCF : ChTrackAssemblyBand {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTrackAssemblyBandANCF(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChTrackAssemblyBandANCF_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTrackAssemblyBandANCF obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChTrackAssemblyBandANCF(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChTrackAssemblyBandANCF_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetContactSurfaceType(ChTrackAssemblyBandANCF.ContactSurfaceType type) {
    vehiclePINVOKE.ChTrackAssemblyBandANCF_SetContactSurfaceType(swigCPtr, (int)type);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override uint GetNumTrackShoes() {
    uint ret = vehiclePINVOKE.ChTrackAssemblyBandANCF_GetNumTrackShoes(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChTrackShoe GetTrackShoe(uint id) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChTrackAssemblyBandANCF_GetTrackShoe(swigCPtr, id);
    ChTrackShoe ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChTrackShoe(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum ContactSurfaceType {
    NONE,
    NODE_CLOUD,
    TRIANGLE_MESH
  }

}
