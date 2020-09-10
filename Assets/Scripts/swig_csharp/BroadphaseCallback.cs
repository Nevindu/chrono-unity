//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class BroadphaseCallback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal BroadphaseCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BroadphaseCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BroadphaseCallback() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          vehiclePINVOKE.delete_BroadphaseCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual bool OnBroadphase(ChCollisionModel modelA, ChCollisionModel modelB) {
    bool ret = vehiclePINVOKE.BroadphaseCallback_OnBroadphase(swigCPtr, ChCollisionModel.getCPtr(modelA), ChCollisionModel.getCPtr(modelB));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BroadphaseCallback() : this(vehiclePINVOKE.new_BroadphaseCallback(), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnBroadphase", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateBroadphaseCallback_0(SwigDirectorMethodOnBroadphase);
    vehiclePINVOKE.BroadphaseCallback_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(BroadphaseCallback));
    return hasDerivedMethod;
  }

  private bool SwigDirectorMethodOnBroadphase(global::System.IntPtr modelA, global::System.IntPtr modelB) {
    return OnBroadphase((modelA == global::System.IntPtr.Zero) ? null : new ChCollisionModel(modelA, true), (modelB == global::System.IntPtr.Zero) ? null : new ChCollisionModel(modelB, true));
  }

  public delegate bool SwigDelegateBroadphaseCallback_0(global::System.IntPtr modelA, global::System.IntPtr modelB);

  private SwigDelegateBroadphaseCallback_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(ChCollisionModel), typeof(ChCollisionModel) };
}
