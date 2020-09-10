//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class DoubleIdler : ChDoubleIdler {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal DoubleIdler(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.DoubleIdler_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DoubleIdler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_DoubleIdler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public DoubleIdler(string filename) : this(vehiclePINVOKE.new_DoubleIdler__SWIG_0(filename), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public DoubleIdler(SWIGTYPE_p_rapidjson__Document d) : this(vehiclePINVOKE.new_DoubleIdler__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetWheelRadius() {
    double ret = vehiclePINVOKE.DoubleIdler_GetWheelRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWheelWidth() {
    double ret = vehiclePINVOKE.DoubleIdler_GetWheelWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWheelGap() {
    double ret = vehiclePINVOKE.DoubleIdler_GetWheelGap(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWheelMass() {
    double ret = vehiclePINVOKE.DoubleIdler_GetWheelMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetWheelInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.DoubleIdler_GetWheelInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetCarrierMass() {
    double ret = vehiclePINVOKE.DoubleIdler_GetCarrierMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetCarrierInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.DoubleIdler_GetCarrierInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetCarrierVisRadius() {
    double ret = vehiclePINVOKE.DoubleIdler_GetCarrierVisRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetPrismaticPitchAngle() {
    double ret = vehiclePINVOKE.DoubleIdler_GetPrismaticPitchAngle(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor GetTensionerForceCallback() {
    global::System.IntPtr cPtr = vehiclePINVOKE.DoubleIdler_GetTensionerForceCallback(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTensionerFreeLength() {
    double ret = vehiclePINVOKE.DoubleIdler_GetTensionerFreeLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
