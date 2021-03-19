//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTexture : ChAsset {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTexture(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChTexture_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTexture obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChTexture(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChTexture() : this(ChronoEngine_csharpPINVOKE.new_ChTexture__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChTexture(string mfilename) : this(ChronoEngine_csharpPINVOKE.new_ChTexture__SWIG_1(mfilename), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetTextureFilename() {
    string ret = ChronoEngine_csharpPINVOKE.ChTexture_GetTextureFilename(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTextureFilename(string mfile) {
    ChronoEngine_csharpPINVOKE.ChTexture_SetTextureFilename(swigCPtr, mfile);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTextureScale(float sx, float sy) {
    ChronoEngine_csharpPINVOKE.ChTexture_SetTextureScale(swigCPtr, sx, sy);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetTextureScaleX() {
    float ret = ChronoEngine_csharpPINVOKE.ChTexture_GetTextureScaleX(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetTextureScaleY() {
    float ret = ChronoEngine_csharpPINVOKE.ChTexture_GetTextureScaleY(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChTexture_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChTexture_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}
