//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChDriver : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChDriver(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChDriver obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChDriver() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vehiclePINVOKE.delete_ChDriver(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChDriver(ChVehicle vehicle) : this(vehiclePINVOKE.new_ChDriver(ChVehicle.getCPtr(vehicle)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetThrottle() {
    double ret = vehiclePINVOKE.ChDriver_GetThrottle(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSteering() {
    double ret = vehiclePINVOKE.ChDriver_GetSteering(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetBraking() {
    double ret = vehiclePINVOKE.ChDriver_GetBraking(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DriverInputs GetInputs() {
    DriverInputs ret = new DriverInputs(vehiclePINVOKE.ChDriver_GetInputs(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Initialize() {
    vehiclePINVOKE.ChDriver_Initialize(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Synchronize(double time) {
    vehiclePINVOKE.ChDriver_Synchronize(swigCPtr, time);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Advance(double step) {
    vehiclePINVOKE.ChDriver_Advance(swigCPtr, step);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool LogInit(string filename) {
    bool ret = vehiclePINVOKE.ChDriver_LogInit(swigCPtr, filename);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Log(double time) {
    bool ret = vehiclePINVOKE.ChDriver_Log(swigCPtr, time);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSteering(double val, double min_val, double max_val) {
    vehiclePINVOKE.ChDriver_SetSteering__SWIG_0(swigCPtr, val, min_val, max_val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSteering(double val, double min_val) {
    vehiclePINVOKE.ChDriver_SetSteering__SWIG_1(swigCPtr, val, min_val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSteering(double val) {
    vehiclePINVOKE.ChDriver_SetSteering__SWIG_2(swigCPtr, val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetThrottle(double val, double min_val, double max_val) {
    vehiclePINVOKE.ChDriver_SetThrottle__SWIG_0(swigCPtr, val, min_val, max_val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetThrottle(double val, double min_val) {
    vehiclePINVOKE.ChDriver_SetThrottle__SWIG_1(swigCPtr, val, min_val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetThrottle(double val) {
    vehiclePINVOKE.ChDriver_SetThrottle__SWIG_2(swigCPtr, val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBraking(double val, double min_val, double max_val) {
    vehiclePINVOKE.ChDriver_SetBraking__SWIG_0(swigCPtr, val, min_val, max_val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBraking(double val, double min_val) {
    vehiclePINVOKE.ChDriver_SetBraking__SWIG_1(swigCPtr, val, min_val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBraking(double val) {
    vehiclePINVOKE.ChDriver_SetBraking__SWIG_2(swigCPtr, val);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}