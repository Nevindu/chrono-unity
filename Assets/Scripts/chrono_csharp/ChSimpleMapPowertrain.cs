//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChSimpleMapPowertrain : ChPowertrain {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChSimpleMapPowertrain(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChSimpleMapPowertrain_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChSimpleMapPowertrain obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChSimpleMapPowertrain(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetMotorSpeed() {
    double ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetMotorSpeed(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetMotorTorque() {
    double ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetMotorTorque(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetTorqueConverterSlippage() {
    double ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetTorqueConverterSlippage(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetTorqueConverterInputTorque() {
    double ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetTorqueConverterInputTorque(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetTorqueConverterOutputTorque() {
    double ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetTorqueConverterOutputTorque(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetTorqueConverterOutputSpeed() {
    double ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetTorqueConverterOutputSpeed(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetCurrentTransmissionGear() {
    int ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetCurrentTransmissionGear(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetOutputTorque() {
    double ret = vehiclePINVOKE.ChSimpleMapPowertrain_GetOutputTorque(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SetDriveMode(ChPowertrain.DriveMode mode) {
    vehiclePINVOKE.ChSimpleMapPowertrain_SetDriveMode(swigCPtr, (int)mode);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void EnableAutomaticTransmission(bool automatic) {
    vehiclePINVOKE.ChSimpleMapPowertrain_EnableAutomaticTransmission(swigCPtr, automatic);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetForwardGear(int igear) {
    vehiclePINVOKE.ChSimpleMapPowertrain_SetForwardGear(swigCPtr, igear);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
