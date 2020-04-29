//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinePoly : ChLine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinePoly(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLinePoly_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinePoly obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLinePoly(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinePoly(int mnumpoints) : this(ChronoEngine_csharpPINVOKE.new_ChLinePoly__SWIG_0(mnumpoints), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinePoly() : this(ChronoEngine_csharpPINVOKE.new_ChLinePoly__SWIG_1(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinePoly(ChLinePoly source) : this(ChronoEngine_csharpPINVOKE.new_ChLinePoly__SWIG_2(ChLinePoly.getCPtr(source)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChGeometry Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChLinePoly_Clone(swigCPtr);
    ChLinePoly ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinePoly(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChGeometry.GeometryType GetClassType() {
    ChGeometry.GeometryType ret = (ChGeometry.GeometryType)ChronoEngine_csharpPINVOKE.ChLinePoly_GetClassType(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int Get_complexity() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinePoly_Get_complexity(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Set_complexity(int mc) {
    ChronoEngine_csharpPINVOKE.ChLinePoly_Set_complexity(swigCPtr, mc);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Evaluate(ChVectorD pos, double parU) {
    ChronoEngine_csharpPINVOKE.ChLinePoly_Evaluate(swigCPtr, ChVectorD.getCPtr(pos), parU);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override double Length(int sampling) {
    double ret = ChronoEngine_csharpPINVOKE.ChLinePoly_Length(swigCPtr, sampling);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool DrawPostscript(SWIGTYPE_p_ChFile_ps mfle, int markpoints, int bezier_interpolate) {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinePoly_DrawPostscript(swigCPtr, SWIGTYPE_p_ChFile_ps.getCPtr(mfle), markpoints, bezier_interpolate);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint Get_numpoints() {
    uint ret = ChronoEngine_csharpPINVOKE.ChLinePoly_Get_numpoints(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Get_degree() {
    int ret = ChronoEngine_csharpPINVOKE.ChLinePoly_Get_degree(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD Get_point(uint mnum) {
    ChVectorD ret = new ChVectorD(ChronoEngine_csharpPINVOKE.ChLinePoly_Get_point(swigCPtr, mnum), true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Set_point(int mnum, ChVectorD mpoint) {
    bool ret = ChronoEngine_csharpPINVOKE.ChLinePoly_Set_point(swigCPtr, mnum, ChVectorD.getCPtr(mpoint));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChLinePoly_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChLinePoly_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
