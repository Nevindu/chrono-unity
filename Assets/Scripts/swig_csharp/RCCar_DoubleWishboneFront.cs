//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class RCCar_DoubleWishboneFront : ChDoubleWishbone {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal RCCar_DoubleWishboneFront(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.RCCar_DoubleWishboneFront_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RCCar_DoubleWishboneFront obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_RCCar_DoubleWishboneFront(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public RCCar_DoubleWishboneFront(string name) : this(vehiclePINVOKE.new_RCCar_DoubleWishboneFront(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double getSpindleMass() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getSpindleMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getUCAMass() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getUCAMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getLCAMass() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getLCAMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getUprightMass() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getUprightMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double getSpindleRadius() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getSpindleRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double getSpindleWidth() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getSpindleWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getUCARadius() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getUCARadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getLCARadius() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getLCARadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getUprightRadius() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getUprightRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getSpindleInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.RCCar_DoubleWishboneFront_getSpindleInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getUCAInertiaMoments() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.RCCar_DoubleWishboneFront_getUCAInertiaMoments(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getUCAInertiaProducts() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.RCCar_DoubleWishboneFront_getUCAInertiaProducts(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getLCAInertiaMoments() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.RCCar_DoubleWishboneFront_getLCAInertiaMoments(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getLCAInertiaProducts() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.RCCar_DoubleWishboneFront_getLCAInertiaProducts(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getUprightInertiaMoments() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.RCCar_DoubleWishboneFront_getUprightInertiaMoments(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getUprightInertiaProducts() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.RCCar_DoubleWishboneFront_getUprightInertiaProducts(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getAxleInertia() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getAxleInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getSpringRestLength() {
    double ret = vehiclePINVOKE.RCCar_DoubleWishboneFront_getSpringRestLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor getSpringForceFunctor() {
    global::System.IntPtr cPtr = vehiclePINVOKE.RCCar_DoubleWishboneFront_getSpringForceFunctor(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor getShockForceFunctor() {
    global::System.IntPtr cPtr = vehiclePINVOKE.RCCar_DoubleWishboneFront_getShockForceFunctor(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
