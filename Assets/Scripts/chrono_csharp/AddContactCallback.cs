//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AddContactCallback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal AddContactCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AddContactCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AddContactCallback() {
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
          ChronoEngine_csharpPINVOKE.delete_AddContactCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual void OnAddContact(ChCollisionInfo contactinfo, ChMaterialComposite material) {
    ChronoEngine_csharpPINVOKE.AddContactCallback_OnAddContact(swigCPtr, ChCollisionInfo.getCPtr(contactinfo), ChMaterialComposite.getCPtr(material));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public AddContactCallback() : this(ChronoEngine_csharpPINVOKE.new_AddContactCallback(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnAddContact", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateAddContactCallback_0(SwigDirectorMethodOnAddContact);
    ChronoEngine_csharpPINVOKE.AddContactCallback_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(AddContactCallback));
    return hasDerivedMethod;
  }

  private void SwigDirectorMethodOnAddContact(global::System.IntPtr contactinfo, global::System.IntPtr material) {
    OnAddContact(new ChCollisionInfo(contactinfo, false), (material == global::System.IntPtr.Zero) ? null : new ChMaterialComposite(material, true));
  }

  public delegate void SwigDelegateAddContactCallback_0(global::System.IntPtr contactinfo, global::System.IntPtr material);

  private SwigDelegateAddContactCallback_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(ChCollisionInfo), typeof(ChMaterialComposite) };
}
