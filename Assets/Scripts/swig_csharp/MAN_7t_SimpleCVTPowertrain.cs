//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MAN_7t_SimpleCVTPowertrain : ChSimpleCVTPowertrain {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal MAN_7t_SimpleCVTPowertrain(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.MAN_7t_SimpleCVTPowertrain_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MAN_7t_SimpleCVTPowertrain obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_MAN_7t_SimpleCVTPowertrain(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public MAN_7t_SimpleCVTPowertrain(string name, double maxSpeed) : this(vehiclePINVOKE.new_MAN_7t_SimpleCVTPowertrain(name, maxSpeed), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetForwardGearRatio() {
    double ret = vehiclePINVOKE.MAN_7t_SimpleCVTPowertrain_GetForwardGearRatio(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetReverseGearRatio() {
    double ret = vehiclePINVOKE.MAN_7t_SimpleCVTPowertrain_GetReverseGearRatio(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetMaxTorque() {
    double ret = vehiclePINVOKE.MAN_7t_SimpleCVTPowertrain_GetMaxTorque(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetMaxPower() {
    double ret = vehiclePINVOKE.MAN_7t_SimpleCVTPowertrain_GetMaxPower(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetCriticalSpeed() {
    double ret = vehiclePINVOKE.MAN_7t_SimpleCVTPowertrain_GetCriticalSpeed(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
