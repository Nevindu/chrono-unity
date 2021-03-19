//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChHendricksonPRIMAXX : ChSuspension {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChHendricksonPRIMAXX(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChHendricksonPRIMAXX_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChHendricksonPRIMAXX obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChHendricksonPRIMAXX(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsSteerable() {
    bool ret = vehiclePINVOKE.ChHendricksonPRIMAXX_IsSteerable(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsIndependent() {
    bool ret = vehiclePINVOKE.ChHendricksonPRIMAXX_IsIndependent(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChSteering_t steering, ChVectorD location, double left_ang_vel, double right_ang_vel) {
    vehiclePINVOKE.ChHendricksonPRIMAXX_Initialize__SWIG_0(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel, right_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChSteering_t steering, ChVectorD location, double left_ang_vel) {
    vehiclePINVOKE.ChHendricksonPRIMAXX_Initialize__SWIG_1(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t subchassis, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChSteering_t steering, ChVectorD location) {
    vehiclePINVOKE.ChHendricksonPRIMAXX_Initialize__SWIG_2(swigCPtr, ChChassis.getCPtr(chassis), SWIGTYPE_p_std__shared_ptrT_ChSubchassis_t.getCPtr(subchassis), SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChSteering_t.getCPtr(steering), ChVectorD.getCPtr(location));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    vehiclePINVOKE.ChHendricksonPRIMAXX_AddVisualizationAssets(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    vehiclePINVOKE.ChHendricksonPRIMAXX_RemoveVisualizationAssets(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetMass() {
    double ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD GetCOMPos() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChHendricksonPRIMAXX_GetCOMPos(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetTrack() {
    double ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetTrack(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Force ReportSuspensionForce(VehicleSide side) {
    Force ret = new Force(vehiclePINVOKE.ChHendricksonPRIMAXX_ReportSuspensionForce(swigCPtr, (int)side), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockLBForce(VehicleSide side) {
    double ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetShockLBForce(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockLBLength(VehicleSide side) {
    double ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetShockLBLength(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockLBVelocity(VehicleSide side) {
    double ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetShockLBVelocity(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockAHForce(VehicleSide side) {
    double ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetShockAHForce(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockAHLength(VehicleSide side) {
    double ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetShockAHLength(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockAHVelocity(VehicleSide side) {
    double ret = vehiclePINVOKE.ChHendricksonPRIMAXX_GetShockAHVelocity(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void LogConstraintViolations(VehicleSide side) {
    vehiclePINVOKE.ChHendricksonPRIMAXX_LogConstraintViolations(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LogHardpointLocations(ChVectorD ref_, bool inches) {
    vehiclePINVOKE.ChHendricksonPRIMAXX_LogHardpointLocations__SWIG_0(swigCPtr, ChVectorD.getCPtr(ref_), inches);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LogHardpointLocations(ChVectorD ref_) {
    vehiclePINVOKE.ChHendricksonPRIMAXX_LogHardpointLocations__SWIG_1(swigCPtr, ChVectorD.getCPtr(ref_));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
