//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLog : ChStreamOutAscii {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChLog(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLog_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLog obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ChronoEngine_csharpPINVOKE.delete_ChLog(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void Flush() {
    ChronoEngine_csharpPINVOKE.ChLog_Flush(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDefaultLevel(ChLog.eChLogLevel mlev) {
    ChronoEngine_csharpPINVOKE.ChLog_SetDefaultLevel(swigCPtr, (int)mlev);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCurrentLevel(ChLog.eChLogLevel mlev) {
    ChronoEngine_csharpPINVOKE.ChLog_SetCurrentLevel(swigCPtr, (int)mlev);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLog.eChLogLevel GetCurrentLevel() {
    ChLog.eChLogLevel ret = (ChLog.eChLogLevel)ChronoEngine_csharpPINVOKE.ChLog_GetCurrentLevel(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RestoreDefaultLevel() {
    ChronoEngine_csharpPINVOKE.ChLog_RestoreDefaultLevel(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum eChLogLevel {
    CHERROR = 0,
    CHWARNING,
    CHMESSAGE,
    CHSTATUS,
    CHQUIET
  }

}
