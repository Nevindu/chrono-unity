//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChSuspension : ChPart {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChSuspension(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChSuspension_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChSuspension obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChSuspension(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual bool IsSteerable() {
    bool ret = vehiclePINVOKE.ChSuspension_IsSteerable(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool IsIndependent() {
    bool ret = vehiclePINVOKE.ChSuspension_IsIndependent(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetLocation() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChSuspension_GetLocation(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChBody GetSpindle(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChSuspension_GetSpindle(swigCPtr, (int)side);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChShaft GetAxle(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChSuspension_GetAxle(swigCPtr, (int)side);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLinkLockRevolute GetRevolute(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChSuspension_GetRevolute(swigCPtr, (int)side);
    ChLinkLockRevolute ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkLockRevolute(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetSpindlePos(VehicleSide side) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChSuspension_GetSpindlePos(swigCPtr, (int)side), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChQuaternionD GetSpindleRot(VehicleSide side) {
    ChQuaternionD ret = new ChQuaternionD(vehiclePINVOKE.ChSuspension_GetSpindleRot(swigCPtr, (int)side), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetSpindleLinVel(VehicleSide side) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChSuspension_GetSpindleLinVel(swigCPtr, (int)side), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetSpindleAngVel(VehicleSide side) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChSuspension_GetSpindleAngVel(swigCPtr, (int)side), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetAxleSpeed(VehicleSide side) {
    double ret = vehiclePINVOKE.ChSuspension_GetAxleSpeed(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Synchronize() {
    vehiclePINVOKE.ChSuspension_Synchronize(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void ApplyAxleTorque(VehicleSide side, double torque) {
    vehiclePINVOKE.ChSuspension_ApplyAxleTorque(swigCPtr, (int)side, torque);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_ChSteering_t steering, ChVectorD location, double left_ang_vel, double right_ang_vel) {
    vehiclePINVOKE.ChSuspension_Initialize__SWIG_0(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel, right_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_ChSteering_t steering, ChVectorD location, double left_ang_vel) {
    vehiclePINVOKE.ChSuspension_Initialize__SWIG_1(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_ChSteering_t steering, ChVectorD location) {
    vehiclePINVOKE.ChSuspension_Initialize__SWIG_2(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double getSpindleRadius() {
    double ret = vehiclePINVOKE.ChSuspension_getSpindleRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getSpindleWidth() {
    double ret = vehiclePINVOKE.ChSuspension_getSpindleWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    vehiclePINVOKE.ChSuspension_AddVisualizationAssets(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    vehiclePINVOKE.ChSuspension_RemoveVisualizationAssets(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ChBody GetLeftBody() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChSuspension_GetLeftBody(swigCPtr);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChBody GetRightBody() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChSuspension_GetRightBody(swigCPtr);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetMass() {
    double ret = vehiclePINVOKE.ChSuspension_GetMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetCOMPos() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChSuspension_GetCOMPos(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTrack() {
    double ret = vehiclePINVOKE.ChSuspension_GetTrack(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Force ReportSuspensionForce(VehicleSide side) {
    Force ret = new Force(vehiclePINVOKE.ChSuspension_ReportSuspensionForce(swigCPtr, (int)side), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void LogConstraintViolations(VehicleSide side) {
    vehiclePINVOKE.ChSuspension_LogConstraintViolations(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void ApplyParkingBrake(bool brake) {
    vehiclePINVOKE.ChSuspension_ApplyParkingBrake(swigCPtr, brake);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
