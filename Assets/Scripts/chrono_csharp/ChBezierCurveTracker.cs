//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChBezierCurveTracker : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChBezierCurveTracker(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChBezierCurveTracker obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChBezierCurveTracker() {
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
          ChronoEngine_csharpPINVOKE.delete_ChBezierCurveTracker(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChBezierCurveTracker(ChBezierCurve path, bool isClosedPath) : this(ChronoEngine_csharpPINVOKE.new_ChBezierCurveTracker__SWIG_0(ChBezierCurve.getCPtr(path), isClosedPath), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBezierCurveTracker(ChBezierCurve path) : this(ChronoEngine_csharpPINVOKE.new_ChBezierCurveTracker__SWIG_1(ChBezierCurve.getCPtr(path)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset(ChVectorD loc) {
    ChronoEngine_csharpPINVOKE.ChBezierCurveTracker_reset(swigCPtr, ChVectorD.getCPtr(loc));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public int calcClosestPoint(ChVectorD loc, ChVectorD point) {
    int ret = ChronoEngine_csharpPINVOKE.ChBezierCurveTracker_calcClosestPoint__SWIG_0(swigCPtr, ChVectorD.getCPtr(loc), ChVectorD.getCPtr(point));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int calcClosestPoint(ChVectorD loc, SWIGTYPE_p_ChFrameT_t tnb, SWIGTYPE_p_double curvature) {
    int ret = ChronoEngine_csharpPINVOKE.ChBezierCurveTracker_calcClosestPoint__SWIG_1(swigCPtr, ChVectorD.getCPtr(loc), SWIGTYPE_p_ChFrameT_t.getCPtr(tnb), SWIGTYPE_p_double.getCPtr(curvature));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setIsClosedPath(bool isClosedPath) {
    ChronoEngine_csharpPINVOKE.ChBezierCurveTracker_setIsClosedPath(swigCPtr, isClosedPath);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
