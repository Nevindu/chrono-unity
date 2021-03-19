//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadableUVW : ChLoadable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadableUVW(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChLoadableUVW_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadableUVW obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChLoadableUVW(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void ComputeNF(double U, double V, double W, ChVectorDynamicD Qi, SWIGTYPE_p_double detJ, ChVectorDynamicD F, ChVectorDynamicD state_x, ChVectorDynamicD state_w) {
    ChronoEngine_csharpPINVOKE.ChLoadableUVW_ComputeNF(swigCPtr, U, V, W, ChVectorDynamicD.getCPtr(Qi), SWIGTYPE_p_double.getCPtr(detJ), ChVectorDynamicD.getCPtr(F), ChVectorDynamicD.getCPtr(state_x), ChVectorDynamicD.getCPtr(state_w));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetDensity() {
    double ret = ChronoEngine_csharpPINVOKE.ChLoadableUVW_GetDensity(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool IsTetrahedronIntegrationNeeded() {
    bool ret = (SwigDerivedClassHasMethod("IsTetrahedronIntegrationNeeded", swigMethodTypes12) ? ChronoEngine_csharpPINVOKE.ChLoadableUVW_IsTetrahedronIntegrationNeededSwigExplicitChLoadableUVW(swigCPtr) : ChronoEngine_csharpPINVOKE.ChLoadableUVW_IsTetrahedronIntegrationNeeded(swigCPtr));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool IsTrianglePrismIntegrationNeeded() {
    bool ret = (SwigDerivedClassHasMethod("IsTrianglePrismIntegrationNeeded", swigMethodTypes13) ? ChronoEngine_csharpPINVOKE.ChLoadableUVW_IsTrianglePrismIntegrationNeededSwigExplicitChLoadableUVW(swigCPtr) : ChronoEngine_csharpPINVOKE.ChLoadableUVW_IsTrianglePrismIntegrationNeeded(swigCPtr));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLoadableUVW() : this(ChronoEngine_csharpPINVOKE.new_ChLoadableUVW(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("LoadableGet_ndof_x", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateChLoadableUVW_0(SwigDirectorMethodLoadableGet_ndof_x);
    if (SwigDerivedClassHasMethod("LoadableGet_ndof_w", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateChLoadableUVW_1(SwigDirectorMethodLoadableGet_ndof_w);
    if (SwigDerivedClassHasMethod("LoadableGetStateBlock_x", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateChLoadableUVW_2(SwigDirectorMethodLoadableGetStateBlock_x);
    if (SwigDerivedClassHasMethod("LoadableGetStateBlock_w", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateChLoadableUVW_3(SwigDirectorMethodLoadableGetStateBlock_w);
    if (SwigDerivedClassHasMethod("LoadableStateIncrement", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateChLoadableUVW_4(SwigDirectorMethodLoadableStateIncrement);
    if (SwigDerivedClassHasMethod("Get_field_ncoords", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateChLoadableUVW_5(SwigDirectorMethodGet_field_ncoords);
    if (SwigDerivedClassHasMethod("GetSubBlocks", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateChLoadableUVW_6(SwigDirectorMethodGetSubBlocks);
    if (SwigDerivedClassHasMethod("GetSubBlockOffset", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateChLoadableUVW_7(SwigDirectorMethodGetSubBlockOffset);
    if (SwigDerivedClassHasMethod("GetSubBlockSize", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateChLoadableUVW_8(SwigDirectorMethodGetSubBlockSize);
    if (SwigDerivedClassHasMethod("LoadableGetVariables", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateChLoadableUVW_9(SwigDirectorMethodLoadableGetVariables);
    if (SwigDerivedClassHasMethod("ComputeNF", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateChLoadableUVW_10(SwigDirectorMethodComputeNF);
    if (SwigDerivedClassHasMethod("GetDensity", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateChLoadableUVW_11(SwigDirectorMethodGetDensity);
    if (SwigDerivedClassHasMethod("IsTetrahedronIntegrationNeeded", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateChLoadableUVW_12(SwigDirectorMethodIsTetrahedronIntegrationNeeded);
    if (SwigDerivedClassHasMethod("IsTrianglePrismIntegrationNeeded", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateChLoadableUVW_13(SwigDirectorMethodIsTrianglePrismIntegrationNeeded);
    ChronoEngine_csharpPINVOKE.ChLoadableUVW_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ChLoadableUVW));
    return hasDerivedMethod;
  }

  private int SwigDirectorMethodLoadableGet_ndof_x() {
    return LoadableGet_ndof_x();
  }

  private int SwigDirectorMethodLoadableGet_ndof_w() {
    return LoadableGet_ndof_w();
  }

  private void SwigDirectorMethodLoadableGetStateBlock_x(int block_offset, global::System.IntPtr mD) {
    LoadableGetStateBlock_x(block_offset, new ChState(mD, false));
  }

  private void SwigDirectorMethodLoadableGetStateBlock_w(int block_offset, global::System.IntPtr mD) {
    LoadableGetStateBlock_w(block_offset, new ChStateDelta(mD, false));
  }

  private void SwigDirectorMethodLoadableStateIncrement(uint off_x, global::System.IntPtr x_new, global::System.IntPtr x, uint off_v, global::System.IntPtr Dv) {
    LoadableStateIncrement(off_x, new ChState(x_new, false), new ChState(x, false), off_v, new ChStateDelta(Dv, false));
  }

  private int SwigDirectorMethodGet_field_ncoords() {
    return Get_field_ncoords();
  }

  private int SwigDirectorMethodGetSubBlocks() {
    return GetSubBlocks();
  }

  private uint SwigDirectorMethodGetSubBlockOffset(int nblock) {
    return GetSubBlockOffset(nblock);
  }

  private uint SwigDirectorMethodGetSubBlockSize(int nblock) {
    return GetSubBlockSize(nblock);
  }

  private void SwigDirectorMethodLoadableGetVariables(global::System.IntPtr mvars) {
    LoadableGetVariables(new SWIGTYPE_p_std__vectorT_ChVariables_p_t(mvars, false));
  }

  private void SwigDirectorMethodComputeNF(double U, double V, double W, global::System.IntPtr Qi, global::System.IntPtr detJ, global::System.IntPtr F, global::System.IntPtr state_x, global::System.IntPtr state_w) {
    ComputeNF(U, V, W, new ChVectorDynamicD(Qi, false), new SWIGTYPE_p_double(detJ, false), new ChVectorDynamicD(F, false), (state_x == global::System.IntPtr.Zero) ? null : new ChVectorDynamicD(state_x, false), (state_w == global::System.IntPtr.Zero) ? null : new ChVectorDynamicD(state_w, false));
  }

  private double SwigDirectorMethodGetDensity() {
    return GetDensity();
  }

  private bool SwigDirectorMethodIsTetrahedronIntegrationNeeded() {
    return IsTetrahedronIntegrationNeeded();
  }

  private bool SwigDirectorMethodIsTrianglePrismIntegrationNeeded() {
    return IsTrianglePrismIntegrationNeeded();
  }

  public delegate int SwigDelegateChLoadableUVW_0();
  public delegate int SwigDelegateChLoadableUVW_1();
  public delegate void SwigDelegateChLoadableUVW_2(int block_offset, global::System.IntPtr mD);
  public delegate void SwigDelegateChLoadableUVW_3(int block_offset, global::System.IntPtr mD);
  public delegate void SwigDelegateChLoadableUVW_4(uint off_x, global::System.IntPtr x_new, global::System.IntPtr x, uint off_v, global::System.IntPtr Dv);
  public delegate int SwigDelegateChLoadableUVW_5();
  public delegate int SwigDelegateChLoadableUVW_6();
  public delegate uint SwigDelegateChLoadableUVW_7(int nblock);
  public delegate uint SwigDelegateChLoadableUVW_8(int nblock);
  public delegate void SwigDelegateChLoadableUVW_9(global::System.IntPtr mvars);
  public delegate void SwigDelegateChLoadableUVW_10(double U, double V, double W, global::System.IntPtr Qi, global::System.IntPtr detJ, global::System.IntPtr F, global::System.IntPtr state_x, global::System.IntPtr state_w);
  public delegate double SwigDelegateChLoadableUVW_11();
  public delegate bool SwigDelegateChLoadableUVW_12();
  public delegate bool SwigDelegateChLoadableUVW_13();

  private SwigDelegateChLoadableUVW_0 swigDelegate0;
  private SwigDelegateChLoadableUVW_1 swigDelegate1;
  private SwigDelegateChLoadableUVW_2 swigDelegate2;
  private SwigDelegateChLoadableUVW_3 swigDelegate3;
  private SwigDelegateChLoadableUVW_4 swigDelegate4;
  private SwigDelegateChLoadableUVW_5 swigDelegate5;
  private SwigDelegateChLoadableUVW_6 swigDelegate6;
  private SwigDelegateChLoadableUVW_7 swigDelegate7;
  private SwigDelegateChLoadableUVW_8 swigDelegate8;
  private SwigDelegateChLoadableUVW_9 swigDelegate9;
  private SwigDelegateChLoadableUVW_10 swigDelegate10;
  private SwigDelegateChLoadableUVW_11 swigDelegate11;
  private SwigDelegateChLoadableUVW_12 swigDelegate12;
  private SwigDelegateChLoadableUVW_13 swigDelegate13;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(int), typeof(ChState) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(int), typeof(ChStateDelta) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(uint), typeof(ChState), typeof(ChState), typeof(uint), typeof(ChStateDelta) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(SWIGTYPE_p_std__vectorT_ChVariables_p_t) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(double), typeof(double), typeof(double), typeof(ChVectorDynamicD), typeof(SWIGTYPE_p_double), typeof(ChVectorDynamicD), typeof(ChVectorDynamicD), typeof(ChVectorDynamicD) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] {  };
}
