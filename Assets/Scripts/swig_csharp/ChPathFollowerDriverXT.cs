//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChPathFollowerDriverXT : ChDriver {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChPathFollowerDriverXT(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChPathFollowerDriverXT_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChPathFollowerDriverXT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vehiclePINVOKE.delete_ChPathFollowerDriverXT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChPathFollowerDriverXT(ChVehicle vehicle, ChBezierCurve path, string path_name, double target_speed, bool isClosedPath, double maxWheelTurnAngle) : this(vehiclePINVOKE.new_ChPathFollowerDriverXT__SWIG_0(ChVehicle.getCPtr(vehicle), ChBezierCurve.getCPtr(path), path_name, target_speed, isClosedPath, maxWheelTurnAngle), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathFollowerDriverXT(ChVehicle vehicle, ChBezierCurve path, string path_name, double target_speed, bool isClosedPath) : this(vehiclePINVOKE.new_ChPathFollowerDriverXT__SWIG_1(ChVehicle.getCPtr(vehicle), ChBezierCurve.getCPtr(path), path_name, target_speed, isClosedPath), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathFollowerDriverXT(ChVehicle vehicle, ChBezierCurve path, string path_name, double target_speed) : this(vehiclePINVOKE.new_ChPathFollowerDriverXT__SWIG_2(ChVehicle.getCPtr(vehicle), ChBezierCurve.getCPtr(path), path_name, target_speed), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathFollowerDriverXT(ChVehicle vehicle, string steering_filename, string speed_filename, ChBezierCurve path, string path_name, double target_speed, bool isClosedPath, double maxWheelTurnAngle) : this(vehiclePINVOKE.new_ChPathFollowerDriverXT__SWIG_3(ChVehicle.getCPtr(vehicle), steering_filename, speed_filename, ChBezierCurve.getCPtr(path), path_name, target_speed, isClosedPath, maxWheelTurnAngle), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathFollowerDriverXT(ChVehicle vehicle, string steering_filename, string speed_filename, ChBezierCurve path, string path_name, double target_speed, bool isClosedPath) : this(vehiclePINVOKE.new_ChPathFollowerDriverXT__SWIG_4(ChVehicle.getCPtr(vehicle), steering_filename, speed_filename, ChBezierCurve.getCPtr(path), path_name, target_speed, isClosedPath), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathFollowerDriverXT(ChVehicle vehicle, string steering_filename, string speed_filename, ChBezierCurve path, string path_name, double target_speed) : this(vehiclePINVOKE.new_ChPathFollowerDriverXT__SWIG_5(ChVehicle.getCPtr(vehicle), steering_filename, speed_filename, ChBezierCurve.getCPtr(path), path_name, target_speed), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDesiredSpeed(double val) {
    vehiclePINVOKE.ChPathFollowerDriverXT_SetDesiredSpeed(swigCPtr, val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetThreshholdThrottle(double val) {
    vehiclePINVOKE.ChPathFollowerDriverXT_SetThreshholdThrottle(swigCPtr, val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathSteeringControllerXT GetSteeringController() {
    ChPathSteeringControllerXT ret = new ChPathSteeringControllerXT(vehiclePINVOKE.ChPathFollowerDriverXT_GetSteeringController(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChSpeedController GetSpeedController() {
    ChSpeedController ret = new ChSpeedController(vehiclePINVOKE.ChPathFollowerDriverXT_GetSpeedController(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reset() {
    vehiclePINVOKE.ChPathFollowerDriverXT_Reset(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Advance(double step) {
    vehiclePINVOKE.ChPathFollowerDriverXT_Advance(swigCPtr, step);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void ExportPathPovray(string out_dir) {
    vehiclePINVOKE.ChPathFollowerDriverXT_ExportPathPovray(swigCPtr, out_dir);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
