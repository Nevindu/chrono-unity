//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChCylinder : ChGeometry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChCylinder(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChCylinder_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChCylinder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChCylinder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChVectorD p1 {
    set {
      ChronoEngine_csharpPINVOKE.ChCylinder_p1_set(swigCPtr, ChVectorD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChCylinder_p1_get(swigCPtr);
      ChVectorD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVectorD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChVectorD p2 {
    set {
      ChronoEngine_csharpPINVOKE.ChCylinder_p2_set(swigCPtr, ChVectorD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChCylinder_p2_get(swigCPtr);
      ChVectorD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVectorD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double rad {
    set {
      ChronoEngine_csharpPINVOKE.ChCylinder_rad_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = ChronoEngine_csharpPINVOKE.ChCylinder_rad_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChCylinder() : this(ChronoEngine_csharpPINVOKE.new_ChCylinder__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChCylinder(ChVectorD mp1, ChVectorD mp2, double mrad) : this(ChronoEngine_csharpPINVOKE.new_ChCylinder__SWIG_1(ChVectorD.getCPtr(mp1), ChVectorD.getCPtr(mp2), mrad), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChCylinder(ChCylinder source) : this(ChronoEngine_csharpPINVOKE.new_ChCylinder__SWIG_2(ChCylinder.getCPtr(source)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChGeometry Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChCylinder_Clone(swigCPtr);
    ChCylinder ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChCylinder(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChGeometry.GeometryType GetClassType() {
    ChGeometry.GeometryType ret = (ChGeometry.GeometryType)ChronoEngine_csharpPINVOKE.ChCylinder_GetClassType(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void GetBoundingBox(SWIGTYPE_p_double xmin, SWIGTYPE_p_double xmax, SWIGTYPE_p_double ymin, SWIGTYPE_p_double ymax, SWIGTYPE_p_double zmin, SWIGTYPE_p_double zmax, ChMatrix33D Rot) {
    ChronoEngine_csharpPINVOKE.ChCylinder_GetBoundingBox__SWIG_0(swigCPtr, SWIGTYPE_p_double.getCPtr(xmin), SWIGTYPE_p_double.getCPtr(xmax), SWIGTYPE_p_double.getCPtr(ymin), SWIGTYPE_p_double.getCPtr(ymax), SWIGTYPE_p_double.getCPtr(zmin), SWIGTYPE_p_double.getCPtr(zmax), ChMatrix33D.getCPtr(Rot));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void GetBoundingBox(SWIGTYPE_p_double xmin, SWIGTYPE_p_double xmax, SWIGTYPE_p_double ymin, SWIGTYPE_p_double ymax, SWIGTYPE_p_double zmin, SWIGTYPE_p_double zmax) {
    ChronoEngine_csharpPINVOKE.ChCylinder_GetBoundingBox__SWIG_1(swigCPtr, SWIGTYPE_p_double.getCPtr(xmin), SWIGTYPE_p_double.getCPtr(xmax), SWIGTYPE_p_double.getCPtr(ymin), SWIGTYPE_p_double.getCPtr(ymax), SWIGTYPE_p_double.getCPtr(zmin), SWIGTYPE_p_double.getCPtr(zmax));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChVectorD Baricenter() {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChCylinder_Baricenter(swigCPtr), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void CovarianceMatrix(ChMatrix33D C) {
    ChronoEngine_csharpPINVOKE.ChCylinder_CovarianceMatrix(swigCPtr, ChMatrix33D.getCPtr(C));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int GetManifoldDimension() {
    int ret = ChronoEngine_csharpPINVOKE.ChCylinder_GetManifoldDimension(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChCylinder_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChCylinder_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
