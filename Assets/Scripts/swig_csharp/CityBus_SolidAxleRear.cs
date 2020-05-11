//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CityBus_SolidAxleRear : ChSolidAxle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal CityBus_SolidAxleRear(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.CityBus_SolidAxleRear_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CityBus_SolidAxleRear obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_CityBus_SolidAxleRear(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CityBus_SolidAxleRear(string name) : this(vehiclePINVOKE.new_CityBus_SolidAxleRear(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double getAxleTubeMass() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getAxleTubeMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getSpindleMass() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getSpindleMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getULMass() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getULMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getLLMass() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getLLMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getKnuckleMass() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getKnuckleMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getTierodMass() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getTierodMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getDraglinkMass() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getDraglinkMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getBellCrankMass() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getBellCrankMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getAxleTubeRadius() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getAxleTubeRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double getSpindleRadius() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getSpindleRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double getSpindleWidth() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getSpindleWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getULRadius() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getULRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getLLRadius() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getLLRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getKnuckleRadius() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getKnuckleRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getTierodRadius() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getTierodRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getDraglinkRadius() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getDraglinkRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getBellCrankRadius() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getBellCrankRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getAxleTubeInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getAxleTubeInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getSpindleInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getSpindleInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getULInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getULInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getLLInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getLLInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getKnuckleInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getKnuckleInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getTierodInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getTierodInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getDraglinkInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getDraglinkInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getBellCrankInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getBellCrankInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getAxleInertia() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getAxleInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getSpringRestLength() {
    double ret = vehiclePINVOKE.CityBus_SolidAxleRear_getSpringRestLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor getSpringForceFunctor() {
    global::System.IntPtr cPtr = vehiclePINVOKE.CityBus_SolidAxleRear_getSpringForceFunctor(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor getShockForceFunctor() {
    global::System.IntPtr cPtr = vehiclePINVOKE.CityBus_SolidAxleRear_getShockForceFunctor(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getAxleTubeCOM() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.CityBus_SolidAxleRear_getAxleTubeCOM(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
