//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Pac2002_data : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Pac2002_data(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Pac2002_data obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Pac2002_data() {
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
          vehiclePINVOKE.delete_Pac2002_data(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public model model {
    set {
      vehiclePINVOKE.Pac2002_data_model_set(swigCPtr, model.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_model_get(swigCPtr);
      model ret = (cPtr == global::System.IntPtr.Zero) ? null : new model(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public dimension dimension {
    set {
      vehiclePINVOKE.Pac2002_data_dimension_set(swigCPtr, dimension.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_dimension_get(swigCPtr);
      dimension ret = (cPtr == global::System.IntPtr.Zero) ? null : new dimension(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public shape shape {
    set {
      vehiclePINVOKE.Pac2002_data_shape_set(swigCPtr, shape.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_shape_get(swigCPtr);
      shape ret = (cPtr == global::System.IntPtr.Zero) ? null : new shape(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vertical vertical {
    set {
      vehiclePINVOKE.Pac2002_data_vertical_set(swigCPtr, vertical.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_vertical_get(swigCPtr);
      vertical ret = (cPtr == global::System.IntPtr.Zero) ? null : new vertical(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public long_slip_range long_slip_range {
    set {
      vehiclePINVOKE.Pac2002_data_long_slip_range_set(swigCPtr, long_slip_range.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_long_slip_range_get(swigCPtr);
      long_slip_range ret = (cPtr == global::System.IntPtr.Zero) ? null : new long_slip_range(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public slip_angle_range slip_angle_range {
    set {
      vehiclePINVOKE.Pac2002_data_slip_angle_range_set(swigCPtr, slip_angle_range.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_slip_angle_range_get(swigCPtr);
      slip_angle_range ret = (cPtr == global::System.IntPtr.Zero) ? null : new slip_angle_range(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public inclination_angle_range inclination_angle_range {
    set {
      vehiclePINVOKE.Pac2002_data_inclination_angle_range_set(swigCPtr, inclination_angle_range.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_inclination_angle_range_get(swigCPtr);
      inclination_angle_range ret = (cPtr == global::System.IntPtr.Zero) ? null : new inclination_angle_range(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vertical_force_range vertical_force_range {
    set {
      vehiclePINVOKE.Pac2002_data_vertical_force_range_set(swigCPtr, vertical_force_range.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_vertical_force_range_get(swigCPtr);
      vertical_force_range ret = (cPtr == global::System.IntPtr.Zero) ? null : new vertical_force_range(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public scaling_coefficients scaling {
    set {
      vehiclePINVOKE.Pac2002_data_scaling_set(swigCPtr, scaling_coefficients.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_scaling_get(swigCPtr);
      scaling_coefficients ret = (cPtr == global::System.IntPtr.Zero) ? null : new scaling_coefficients(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public longitudinal_coefficients longitudinal {
    set {
      vehiclePINVOKE.Pac2002_data_longitudinal_set(swigCPtr, longitudinal_coefficients.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_longitudinal_get(swigCPtr);
      longitudinal_coefficients ret = (cPtr == global::System.IntPtr.Zero) ? null : new longitudinal_coefficients(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public overturning_coefficients overturning {
    set {
      vehiclePINVOKE.Pac2002_data_overturning_set(swigCPtr, overturning_coefficients.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_overturning_get(swigCPtr);
      overturning_coefficients ret = (cPtr == global::System.IntPtr.Zero) ? null : new overturning_coefficients(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public lateral_coefficients lateral {
    set {
      vehiclePINVOKE.Pac2002_data_lateral_set(swigCPtr, lateral_coefficients.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_lateral_get(swigCPtr);
      lateral_coefficients ret = (cPtr == global::System.IntPtr.Zero) ? null : new lateral_coefficients(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public rolling_coefficients rolling {
    set {
      vehiclePINVOKE.Pac2002_data_rolling_set(swigCPtr, rolling_coefficients.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_rolling_get(swigCPtr);
      rolling_coefficients ret = (cPtr == global::System.IntPtr.Zero) ? null : new rolling_coefficients(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public aligning_coefficients aligning {
    set {
      vehiclePINVOKE.Pac2002_data_aligning_set(swigCPtr, aligning_coefficients.getCPtr(value));
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = vehiclePINVOKE.Pac2002_data_aligning_get(swigCPtr);
      aligning_coefficients ret = (cPtr == global::System.IntPtr.Zero) ? null : new aligning_coefficients(cPtr, false);
      if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Pac2002_data() : this(vehiclePINVOKE.new_Pac2002_data(), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
