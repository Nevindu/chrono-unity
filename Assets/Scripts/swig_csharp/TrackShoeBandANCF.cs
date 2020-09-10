//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TrackShoeBandANCF : ChTrackShoeBandANCF {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal TrackShoeBandANCF(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.TrackShoeBandANCF_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TrackShoeBandANCF obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_TrackShoeBandANCF(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public TrackShoeBandANCF(string filename) : this(vehiclePINVOKE.new_TrackShoeBandANCF__SWIG_0(filename), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public TrackShoeBandANCF(SWIGTYPE_p_rapidjson__Document d) : this(vehiclePINVOKE.new_TrackShoeBandANCF__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override GuidePinType GetType() {
    GuidePinType ret = (GuidePinType)vehiclePINVOKE.TrackShoeBandANCF_GetType(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetHeight() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetHeight(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTreadMass() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetTreadMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWebMass() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetWebMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetTreadInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackShoeBandANCF_GetTreadInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetWebInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackShoeBandANCF_GetWebInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetGuideBoxDimensions() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackShoeBandANCF_GetGuideBoxDimensions(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetGuideBoxOffsetX() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetGuideBoxOffsetX(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetBeltWidth() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetBeltWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothTipLength() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetToothTipLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothBaseLength() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetToothBaseLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothWidth() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetToothWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothHeight() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetToothHeight(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothArcRadius() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetToothArcRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWebLength() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetWebLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWebThickness() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetWebThickness(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetNumElementsLength() {
    int ret = vehiclePINVOKE.TrackShoeBandANCF_GetNumElementsLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetNumElementsWidth() {
    int ret = vehiclePINVOKE.TrackShoeBandANCF_GetNumElementsWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetSteelLayerThickness() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetSteelLayerThickness(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTreadLength() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetTreadLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTreadThickness() {
    double ret = vehiclePINVOKE.TrackShoeBandANCF_GetTreadThickness(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string GetTreadVisualizationMeshName() {
    string ret = vehiclePINVOKE.TrackShoeBandANCF_GetTreadVisualizationMeshName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
