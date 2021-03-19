//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TrackAssemblyBandBushing : ChTrackAssemblyBandBushing {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal TrackAssemblyBandBushing(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.TrackAssemblyBandBushing_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TrackAssemblyBandBushing obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_TrackAssemblyBandBushing(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public TrackAssemblyBandBushing(string filename) : this(vehiclePINVOKE.new_TrackAssemblyBandBushing__SWIG_0(filename), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public TrackAssemblyBandBushing(SWIGTYPE_p_rapidjson__Document d) : this(vehiclePINVOKE.new_TrackAssemblyBandBushing__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChVectorD GetSprocketLocation() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackAssemblyBandBushing_GetSprocketLocation(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD GetIdlerLocation() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackAssemblyBandBushing_GetIdlerLocation(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD GetRoadWhelAssemblyLocation(int which) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackAssemblyBandBushing_GetRoadWhelAssemblyLocation(swigCPtr, which), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD GetRollerLocation(int which) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackAssemblyBandBushing_GetRollerLocation(swigCPtr, which), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
