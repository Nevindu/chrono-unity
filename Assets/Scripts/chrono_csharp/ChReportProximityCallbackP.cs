//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChReportProximityCallbackP : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChReportProximityCallbackP(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChReportProximityCallbackP obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChReportProximityCallbackP() {
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
          ChronoEngine_csharpPINVOKE.delete_ChReportProximityCallbackP(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual bool OnReportProximity(ChCollisionModel modA, ChCollisionModel modB) {
    bool ret = (SwigDerivedClassHasMethod("OnReportProximity", swigMethodTypes0) ? ChronoEngine_csharpPINVOKE.ChReportProximityCallbackP_OnReportProximitySwigExplicitChReportProximityCallbackP(swigCPtr, ChCollisionModel.getCPtr(modA), ChCollisionModel.getCPtr(modB)) : ChronoEngine_csharpPINVOKE.ChReportProximityCallbackP_OnReportProximity(swigCPtr, ChCollisionModel.getCPtr(modA), ChCollisionModel.getCPtr(modB)));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChReportProximityCallbackP() : this(ChronoEngine_csharpPINVOKE.new_ChReportProximityCallbackP(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnReportProximity", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateChReportProximityCallbackP_0(SwigDirectorMethodOnReportProximity);
    ChronoEngine_csharpPINVOKE.ChReportProximityCallbackP_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ChReportProximityCallbackP));
    return hasDerivedMethod;
  }

  private bool SwigDirectorMethodOnReportProximity(global::System.IntPtr modA, global::System.IntPtr modB) {
    return OnReportProximity((modA == global::System.IntPtr.Zero) ? null : new ChCollisionModel(modA, true), (modB == global::System.IntPtr.Zero) ? null : new ChCollisionModel(modB, true));
  }

  public delegate bool SwigDelegateChReportProximityCallbackP_0(global::System.IntPtr modA, global::System.IntPtr modB);

  private SwigDelegateChReportProximityCallbackP_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(ChCollisionModel), typeof(ChCollisionModel) };
}
