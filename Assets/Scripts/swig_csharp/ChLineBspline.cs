//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLineBspline : ChLine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLineBspline(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLineBspline_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLineBspline obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLineBspline(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public vector_ChVectorD points {
    set {
      ChronoEngine_csharpPINVOKE.ChLineBspline_points_set(swigCPtr, vector_ChVectorD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLineBspline_points_get(swigCPtr);
      vector_ChVectorD ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_ChVectorD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChVectorDynamicD knots {
    set {
      ChronoEngine_csharpPINVOKE.ChLineBspline_knots_set(swigCPtr, ChVectorDynamicD.getCPtr(value));
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLineBspline_knots_get(swigCPtr);
      ChVectorDynamicD ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVectorDynamicD(cPtr, false);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int p {
    set {
      ChronoEngine_csharpPINVOKE.ChLineBspline_p_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = ChronoEngine_csharpPINVOKE.ChLineBspline_p_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool closed {
    set {
      ChronoEngine_csharpPINVOKE.ChLineBspline_closed_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ChronoEngine_csharpPINVOKE.ChLineBspline_closed_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ChLineBspline() : this(ChronoEngine_csharpPINVOKE.new_ChLineBspline__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineBspline(int morder, vector_ChVectorD mpoints, ChVectorDynamicD mknots) : this(ChronoEngine_csharpPINVOKE.new_ChLineBspline__SWIG_1(morder, vector_ChVectorD.getCPtr(mpoints), ChVectorDynamicD.getCPtr(mknots)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineBspline(int morder, vector_ChVectorD mpoints) : this(ChronoEngine_csharpPINVOKE.new_ChLineBspline__SWIG_2(morder, vector_ChVectorD.getCPtr(mpoints)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLineBspline(ChLineBspline source) : this(ChronoEngine_csharpPINVOKE.new_ChLineBspline__SWIG_3(ChLineBspline.getCPtr(source)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChGeometry Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLineBspline_Clone(swigCPtr);
    ChLineBspline ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLineBspline(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int Get_complexity() {
    int ret = ChronoEngine_csharpPINVOKE.ChLineBspline_Get_complexity(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Evaluate(ChVectorD pos, double parU) {
    ChronoEngine_csharpPINVOKE.ChLineBspline_Evaluate(swigCPtr, ChVectorD.getCPtr(pos), parU);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Derive(ChVectorD dir, double parU) {
    ChronoEngine_csharpPINVOKE.ChLineBspline_Derive(swigCPtr, ChVectorD.getCPtr(dir), parU);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double ComputeUfromKnotU(double u) {
    double ret = ChronoEngine_csharpPINVOKE.ChLineBspline_ComputeUfromKnotU(swigCPtr, u);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ComputeKnotUfromU(double U) {
    double ret = ChronoEngine_csharpPINVOKE.ChLineBspline_ComputeKnotUfromU(swigCPtr, U);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_ChVectorD Points() {
    vector_ChVectorD ret = new vector_ChVectorD(ChronoEngine_csharpPINVOKE.ChLineBspline_Points(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD Knots() {
    ChVectorDynamicD ret = new ChVectorDynamicD(ChronoEngine_csharpPINVOKE.ChLineBspline_Knots(swigCPtr), false);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetOrder() {
    int ret = ChronoEngine_csharpPINVOKE.ChLineBspline_GetOrder(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetupData(int morder, vector_ChVectorD mpoints, ChVectorDynamicD mknots) {
    ChronoEngine_csharpPINVOKE.ChLineBspline_SetupData__SWIG_0(swigCPtr, morder, vector_ChVectorD.getCPtr(mpoints), ChVectorDynamicD.getCPtr(mknots));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetupData(int morder, vector_ChVectorD mpoints) {
    ChronoEngine_csharpPINVOKE.ChLineBspline_SetupData__SWIG_1(swigCPtr, morder, vector_ChVectorD.getCPtr(mpoints));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetClosed(bool mc) {
    ChronoEngine_csharpPINVOKE.ChLineBspline_SetClosed(swigCPtr, mc);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetClosed() {
    bool ret = ChronoEngine_csharpPINVOKE.ChLineBspline_GetClosed(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLineBspline_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLineBspline_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}