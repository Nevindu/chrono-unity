//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTrackShoeDoublePin : ChTrackShoeSegmented {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTrackShoeDoublePin(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChTrackShoeDoublePin_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTrackShoeDoublePin obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChTrackShoeDoublePin(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChTrackShoeDoublePin_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetMass() {
    double ret = vehiclePINVOKE.ChTrackShoeDoublePin_GetMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetPitch() {
    double ret = vehiclePINVOKE.ChTrackShoeDoublePin_GetPitch(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChBodyAuxRef chassis, ChVectorD location, ChQuaternionD rotation) {
    vehiclePINVOKE.ChTrackShoeDoublePin_Initialize__SWIG_0(swigCPtr, ChBodyAuxRef.getCPtr(chassis), ChVectorD.getCPtr(location), ChQuaternionD.getCPtr(rotation));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBodyAuxRef chassis, ChVectorD loc_shoe, ChQuaternionD rot_shoe, ChVectorD loc_connector_L, ChVectorD loc_connector_R, ChQuaternionD rot_connector) {
    vehiclePINVOKE.ChTrackShoeDoublePin_Initialize__SWIG_1(swigCPtr, ChBodyAuxRef.getCPtr(chassis), ChVectorD.getCPtr(loc_shoe), ChQuaternionD.getCPtr(rot_shoe), ChVectorD.getCPtr(loc_connector_L), ChVectorD.getCPtr(loc_connector_R), ChQuaternionD.getCPtr(rot_connector));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    vehiclePINVOKE.ChTrackShoeDoublePin_AddVisualizationAssets(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    vehiclePINVOKE.ChTrackShoeDoublePin_RemoveVisualizationAssets(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
