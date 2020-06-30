//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLeafspringAxle : ChSuspension {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLeafspringAxle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChLeafspringAxle_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLeafspringAxle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChLeafspringAxle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChLeafspringAxle_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsSteerable() {
    bool ret = vehiclePINVOKE.ChLeafspringAxle_IsSteerable(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsIndependent() {
    bool ret = vehiclePINVOKE.ChLeafspringAxle_IsIndependent(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_ChSteering_t steering, ChVectorD location, double left_ang_vel, double right_ang_vel) {
    vehiclePINVOKE.ChLeafspringAxle_Initialize__SWIG_0(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel, right_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_ChSteering_t steering, ChVectorD location, double left_ang_vel) {
    vehiclePINVOKE.ChLeafspringAxle_Initialize__SWIG_1(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_ChSteering_t steering, ChVectorD location) {
    vehiclePINVOKE.ChLeafspringAxle_Initialize__SWIG_2(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    vehiclePINVOKE.ChLeafspringAxle_AddVisualizationAssets(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    vehiclePINVOKE.ChLeafspringAxle_RemoveVisualizationAssets(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetMass() {
    double ret = vehiclePINVOKE.ChLeafspringAxle_GetMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD GetCOMPos() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChLeafspringAxle_GetCOMPos(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetTrack() {
    double ret = vehiclePINVOKE.ChLeafspringAxle_GetTrack(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLinkTSDA GetSpring(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChLeafspringAxle_GetSpring(swigCPtr, (int)side);
    ChLinkTSDA ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkTSDA(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLinkTSDA GetShock(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChLeafspringAxle_GetShock(swigCPtr, (int)side);
    ChLinkTSDA ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkTSDA(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Force ReportSuspensionForce(VehicleSide side) {
    Force ret = new Force(vehiclePINVOKE.ChLeafspringAxle_ReportSuspensionForce(swigCPtr, (int)side), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringForce(VehicleSide side) {
    double ret = vehiclePINVOKE.ChLeafspringAxle_GetSpringForce(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringLength(VehicleSide side) {
    double ret = vehiclePINVOKE.ChLeafspringAxle_GetSpringLength(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringDeformation(VehicleSide side) {
    double ret = vehiclePINVOKE.ChLeafspringAxle_GetSpringDeformation(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockForce(VehicleSide side) {
    double ret = vehiclePINVOKE.ChLeafspringAxle_GetShockForce(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockLength(VehicleSide side) {
    double ret = vehiclePINVOKE.ChLeafspringAxle_GetShockLength(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockVelocity(VehicleSide side) {
    double ret = vehiclePINVOKE.ChLeafspringAxle_GetShockVelocity(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void LogConstraintViolations(VehicleSide side) {
    vehiclePINVOKE.ChLeafspringAxle_LogConstraintViolations(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LogHardpointLocations(ChVectorD ref_, bool inches) {
    vehiclePINVOKE.ChLeafspringAxle_LogHardpointLocations__SWIG_0(swigCPtr, ChVectorD.getCPtr(ref_), inches);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LogHardpointLocations(ChVectorD ref_) {
    vehiclePINVOKE.ChLeafspringAxle_LogHardpointLocations__SWIG_1(swigCPtr, ChVectorD.getCPtr(ref_));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
