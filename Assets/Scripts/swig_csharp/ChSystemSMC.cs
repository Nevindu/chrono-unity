//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChSystemSMC : ChSystem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChSystemSMC(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ChronoEngine_csharpPINVOKE.ChSystemSMC_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChSystemSMC obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ChronoEngine_csharpPINVOKE.delete_ChSystemSMC(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChSystemSMC(bool use_material_properties, uint max_objects, double scene_size) : this(ChronoEngine_csharpPINVOKE.new_ChSystemSMC__SWIG_0(use_material_properties, max_objects, scene_size), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSystemSMC(bool use_material_properties, uint max_objects) : this(ChronoEngine_csharpPINVOKE.new_ChSystemSMC__SWIG_1(use_material_properties, max_objects), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSystemSMC(bool use_material_properties) : this(ChronoEngine_csharpPINVOKE.new_ChSystemSMC__SWIG_2(use_material_properties), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSystemSMC() : this(ChronoEngine_csharpPINVOKE.new_ChSystemSMC__SWIG_3(), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSystemSMC(ChSystemSMC other) : this(ChronoEngine_csharpPINVOKE.new_ChSystemSMC__SWIG_4(ChSystemSMC.getCPtr(other)), true) {
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChSystem Clone() {
    global::System.IntPtr cPtr = ChronoEngine_csharpPINVOKE.ChSystemSMC_Clone(swigCPtr);
    ChSystemSMC ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChSystemSMC(cPtr, true);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChContactMethod GetContactMethod() {
    ChContactMethod ret = (ChContactMethod)ChronoEngine_csharpPINVOKE.ChSystemSMC_GetContactMethod(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SetContactContainer(ChContactContainer container) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_SetContactContainer(swigCPtr, ChContactContainer.getCPtr(container));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UseMaterialProperties(bool val) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_UseMaterialProperties(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool UsingMaterialProperties() {
    bool ret = ChronoEngine_csharpPINVOKE.ChSystemSMC_UsingMaterialProperties(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetContactForceModel(ChSystemSMC.ContactForceModel model) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_SetContactForceModel(swigCPtr, (int)model);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSystemSMC.ContactForceModel GetContactForceModel() {
    ChSystemSMC.ContactForceModel ret = (ChSystemSMC.ContactForceModel)ChronoEngine_csharpPINVOKE.ChSystemSMC_GetContactForceModel(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAdhesionForceModel(ChSystemSMC.AdhesionForceModel model) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_SetAdhesionForceModel(swigCPtr, (int)model);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSystemSMC.AdhesionForceModel GetAdhesionForceModel() {
    ChSystemSMC.AdhesionForceModel ret = (ChSystemSMC.AdhesionForceModel)ChronoEngine_csharpPINVOKE.ChSystemSMC_GetAdhesionForceModel(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTangentialDisplacementModel(ChSystemSMC.TangentialDisplacementModel model) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_SetTangentialDisplacementModel(swigCPtr, (int)model);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSystemSMC.TangentialDisplacementModel GetTangentialDisplacementModel() {
    ChSystemSMC.TangentialDisplacementModel ret = (ChSystemSMC.TangentialDisplacementModel)ChronoEngine_csharpPINVOKE.ChSystemSMC_GetTangentialDisplacementModel(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetStiffContact(bool val) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_SetStiffContact(swigCPtr, val);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetStiffContact() {
    bool ret = ChronoEngine_csharpPINVOKE.ChSystemSMC_GetStiffContact(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSlipVelocityThreshold(double vel) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_SetSlipVelocityThreshold(swigCPtr, vel);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetSlipVelocityThreshold() {
    double ret = ChronoEngine_csharpPINVOKE.ChSystemSMC_GetSlipVelocityThreshold(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCharacteristicImpactVelocity(double vel) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_SetCharacteristicImpactVelocity(swigCPtr, vel);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetCharacteristicImpactVelocity() {
    double ret = ChronoEngine_csharpPINVOKE.ChSystemSMC_GetCharacteristicImpactVelocity(swigCPtr);
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOUT(SWIGTYPE_p_ChArchiveOut marchive) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_ArchiveOUT(swigCPtr, SWIGTYPE_p_ChArchiveOut.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIN(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    ChronoEngine_csharpPINVOKE.ChSystemSMC_ArchiveIN(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (ChronoEngine_csharpPINVOKE.SWIGPendingException.Pending) throw ChronoEngine_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum ContactForceModel {
    Hooke,
    Hertz,
    PlainCoulomb,
    Flores
  }

  public enum AdhesionForceModel {
    Constant,
    DMT,
    Perko
  }

  public enum TangentialDisplacementModel {
    None,
    OneStep,
    MultiStep
  }

}
