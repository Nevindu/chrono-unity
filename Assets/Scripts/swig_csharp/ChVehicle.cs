//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChVehicle : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChVehicle(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChVehicle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChVehicle() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          vehiclePINVOKE.delete_ChVehicle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string GetName() {
    string ret = vehiclePINVOKE.ChVehicle_GetName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetName(string name) {
    vehiclePINVOKE.ChVehicle_SetName(swigCPtr, name);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetTemplateName() {
    string ret = vehiclePINVOKE.ChVehicle_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChSystem GetSystem() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChVehicle_GetSystem(swigCPtr);
    ChSystem ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChSystem(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetChTime() {
    double ret = vehiclePINVOKE.ChVehicle_GetChTime(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChChassis GetChassis() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChVehicle_GetChassis(swigCPtr);
    ChChassis ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChChassis(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChBodyAuxRef GetChassisBody() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChVehicle_GetChassisBody(swigCPtr);
    ChBodyAuxRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBodyAuxRef(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChPowertrain GetPowertrain() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChVehicle_GetPowertrain(swigCPtr);
    ChPowertrain ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChPowertrain(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetVehicleMass() {
    double ret = vehiclePINVOKE.ChVehicle_GetVehicleMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetVehicleCOMPos() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChVehicle_GetVehicleCOMPos(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetVehiclePos() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChVehicle_GetVehiclePos(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChQuaternionD GetVehicleRot() {
    ChQuaternionD ret = new ChQuaternionD(vehiclePINVOKE.ChVehicle_GetVehicleRot(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetVehicleSpeed() {
    double ret = vehiclePINVOKE.ChVehicle_GetVehicleSpeed(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetVehicleSpeedCOM() {
    double ret = vehiclePINVOKE.ChVehicle_GetVehicleSpeedCOM(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetVehiclePointLocation(ChVectorD locpos) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChVehicle_GetVehiclePointLocation(swigCPtr, ChVectorD.getCPtr(locpos)), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetVehiclePointVelocity(ChVectorD locpos) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChVehicle_GetVehiclePointVelocity(swigCPtr, ChVectorD.getCPtr(locpos)), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetVehicleAcceleration(ChVectorD locpos) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChVehicle_GetVehicleAcceleration(swigCPtr, ChVectorD.getCPtr(locpos)), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChShaft GetDriveshaft() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChVehicle_GetDriveshaft(swigCPtr);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetDriveshaftSpeed() {
    double ret = vehiclePINVOKE.ChVehicle_GetDriveshaftSpeed(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetDriverPos() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChVehicle_GetDriverPos(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetOutput(ChVehicleOutput.Type type, string out_dir, string out_name, double output_step) {
    vehiclePINVOKE.ChVehicle_SetOutput(swigCPtr, (int)type, out_dir, out_name, output_step);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChCoordsysD chassisPos, double chassisFwdVel) {
    vehiclePINVOKE.ChVehicle_Initialize__SWIG_0(swigCPtr, ChCoordsysD.getCPtr(chassisPos), chassisFwdVel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChCoordsysD chassisPos) {
    vehiclePINVOKE.ChVehicle_Initialize__SWIG_1(swigCPtr, ChCoordsysD.getCPtr(chassisPos));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetChassisVisualizationType(VisualizationType vis) {
    vehiclePINVOKE.ChVehicle_SetChassisVisualizationType(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetChassisCollide(bool state) {
    vehiclePINVOKE.ChVehicle_SetChassisCollide(swigCPtr, state);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetChassisVehicleCollide(bool state) {
    vehiclePINVOKE.ChVehicle_SetChassisVehicleCollide(swigCPtr, state);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetChassisOutput(bool state) {
    vehiclePINVOKE.ChVehicle_SetChassisOutput(swigCPtr, state);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Advance(double step) {
    vehiclePINVOKE.ChVehicle_Advance(swigCPtr, step);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LogConstraintViolations() {
    vehiclePINVOKE.ChVehicle_LogConstraintViolations(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string ExportComponentList() {
    string ret = vehiclePINVOKE.ChVehicle_ExportComponentList__SWIG_0(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ExportComponentList(string filename) {
    vehiclePINVOKE.ChVehicle_ExportComponentList__SWIG_1(swigCPtr, filename);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Output(int frame, ChVehicleOutput database) {
    vehiclePINVOKE.ChVehicle_Output(swigCPtr, frame, ChVehicleOutput.getCPtr(database));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
