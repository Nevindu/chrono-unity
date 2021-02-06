//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTrackDrivelineBDS : ChDrivelineTV {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTrackDrivelineBDS(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChTrackDrivelineBDS_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTrackDrivelineBDS obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChTrackDrivelineBDS(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChTrackDrivelineBDS_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMotorBlockDirection(ChVectorD dir) {
    vehiclePINVOKE.ChTrackDrivelineBDS_SetMotorBlockDirection(swigCPtr, ChVectorD.getCPtr(dir));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAxleDirection(ChVectorD dir) {
    vehiclePINVOKE.ChTrackDrivelineBDS_SetAxleDirection(swigCPtr, ChVectorD.getCPtr(dir));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, ChTrackAssembly track_left, ChTrackAssembly track_right) {
    vehiclePINVOKE.ChTrackDrivelineBDS_Initialize(swigCPtr, ChChassis.getCPtr(chassis), ChTrackAssembly.getCPtr(track_left), ChTrackAssembly.getCPtr(track_right));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Synchronize(double steering, double torque) {
    vehiclePINVOKE.ChTrackDrivelineBDS_Synchronize(swigCPtr, steering, torque);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetSprocketTorque(VehicleSide side) {
    double ret = vehiclePINVOKE.ChTrackDrivelineBDS_GetSprocketTorque(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetSprocketSpeed(VehicleSide side) {
    double ret = vehiclePINVOKE.ChTrackDrivelineBDS_GetSprocketSpeed(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
