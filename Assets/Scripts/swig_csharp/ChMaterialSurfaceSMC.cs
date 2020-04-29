//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChMaterialSurfaceSMC : ChMaterialSurface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChMaterialSurfaceSMC(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChMaterialSurfaceSMC obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChMaterialSurfaceSMC(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChMaterialSurfaceSMC() : this(ChronoEngine_csharpPINVOKE.new_ChMaterialSurfaceSMC__SWIG_0(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChMaterialSurfaceSMC(ChMaterialSurfaceSMC other) : this(ChronoEngine_csharpPINVOKE.new_ChMaterialSurfaceSMC__SWIG_1(ChMaterialSurfaceSMC.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChMaterialSurface Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_Clone(swigCPtr);
    ChMaterialSurfaceSMC ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMaterialSurfaceSMC(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChContactMethod GetContactMethod() {
    ChContactMethod ret = (ChContactMethod)ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetContactMethod(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetYoungModulus(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetYoungModulus(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetYoungModulus() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetYoungModulus(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPoissonRatio(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetPoissonRatio(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetPoissonRatio() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetPoissonRatio(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAdhesion(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetAdhesion(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetAdhesion() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetAdhesion(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAdhesionMultDMT(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetAdhesionMultDMT(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetAdhesionMultDMT() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetAdhesionMultDMT(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAdhesionSPerko(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetAdhesionSPerko(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetAdhesionSPerko() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetAdhesionSPerko(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetKn(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetKn(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetKt(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetKt(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetGn(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetGn(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetGt(float val) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_SetGt(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetKn() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetKn(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetKt() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetKt(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetGn() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetGn(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetGt() {
    float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_GetGt(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void StreamOUT(ChStreamOutAscii mstream) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_StreamOUT(swigCPtr, ChStreamOutAscii.getCPtr(mstream));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public float young_modulus {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_young_modulus_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_young_modulus_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float poisson_ratio {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_poisson_ratio_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_poisson_ratio_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float constant_adhesion {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_constant_adhesion_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_constant_adhesion_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float adhesionMultDMT {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_adhesionMultDMT_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_adhesionMultDMT_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float adhesionSPerko {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_adhesionSPerko_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_adhesionSPerko_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float kn {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_kn_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_kn_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float kt {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_kt_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_kt_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float gn {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_gn_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_gn_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float gt {
    set {
      ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_gt_set(swigCPtr, value);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = ChronoEngine_csharpPINVOKE.ChMaterialSurfaceSMC_gt_get(swigCPtr);
      if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}