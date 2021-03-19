//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChPathSteeringController : ChSteeringController {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChPathSteeringController(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChPathSteeringController_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChPathSteeringController obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vehiclePINVOKE.delete_ChPathSteeringController(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChPathSteeringController(ChBezierCurve path, bool isClosedPath) : this(vehiclePINVOKE.new_ChPathSteeringController__SWIG_0(ChBezierCurve.getCPtr(path), isClosedPath), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathSteeringController(ChBezierCurve path) : this(vehiclePINVOKE.new_ChPathSteeringController__SWIG_1(ChBezierCurve.getCPtr(path)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathSteeringController(string filename, ChBezierCurve path, bool isClosedPath) : this(vehiclePINVOKE.new_ChPathSteeringController__SWIG_2(filename, ChBezierCurve.getCPtr(path), isClosedPath), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathSteeringController(string filename, ChBezierCurve path) : this(vehiclePINVOKE.new_ChPathSteeringController__SWIG_3(filename, ChBezierCurve.getCPtr(path)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBezierCurve GetPath() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChPathSteeringController_GetPath(swigCPtr);
    ChBezierCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBezierCurve(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Reset(ChVehicle vehicle) {
    vehiclePINVOKE.ChPathSteeringController_Reset(swigCPtr, ChVehicle.getCPtr(vehicle));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void CalcTargetLocation() {
    vehiclePINVOKE.ChPathSteeringController_CalcTargetLocation(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
