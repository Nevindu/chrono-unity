//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class WheelStates : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<WheelState>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal WheelStates(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(WheelStates obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~WheelStates() {
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
          vehiclePINVOKE.delete_WheelStates(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public WheelStates(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (WheelState element in c) {
      this.Add(element);
    }
  }

  public WheelStates(global::System.Collections.Generic.IEnumerable<WheelState> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (WheelState element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public WheelState this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(WheelState[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(WheelState[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, WheelState[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public WheelState[] ToArray() {
    WheelState[] array = new WheelState[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<WheelState> global::System.Collections.Generic.IEnumerable<WheelState>.GetEnumerator() {
    return new WheelStatesEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new WheelStatesEnumerator(this);
  }

  public WheelStatesEnumerator GetEnumerator() {
    return new WheelStatesEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class WheelStatesEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<WheelState>
  {
    private WheelStates collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public WheelStatesEnumerator(WheelStates collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public WheelState Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (WheelState)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    vehiclePINVOKE.WheelStates_Clear(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(WheelState x) {
    vehiclePINVOKE.WheelStates_Add(swigCPtr, WheelState.getCPtr(x));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = vehiclePINVOKE.WheelStates_size(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = vehiclePINVOKE.WheelStates_capacity(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    vehiclePINVOKE.WheelStates_reserve(swigCPtr, n);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public WheelStates() : this(vehiclePINVOKE.new_WheelStates__SWIG_0(), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public WheelStates(WheelStates other) : this(vehiclePINVOKE.new_WheelStates__SWIG_1(WheelStates.getCPtr(other)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public WheelStates(int capacity) : this(vehiclePINVOKE.new_WheelStates__SWIG_2(capacity), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private WheelState getitemcopy(int index) {
    WheelState ret = new WheelState(vehiclePINVOKE.WheelStates_getitemcopy(swigCPtr, index), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private WheelState getitem(int index) {
    WheelState ret = new WheelState(vehiclePINVOKE.WheelStates_getitem(swigCPtr, index), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, WheelState val) {
    vehiclePINVOKE.WheelStates_setitem(swigCPtr, index, WheelState.getCPtr(val));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(WheelStates values) {
    vehiclePINVOKE.WheelStates_AddRange(swigCPtr, WheelStates.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public WheelStates GetRange(int index, int count) {
    global::System.IntPtr cPtr = vehiclePINVOKE.WheelStates_GetRange(swigCPtr, index, count);
    WheelStates ret = (cPtr == global::System.IntPtr.Zero) ? null : new WheelStates(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, WheelState x) {
    vehiclePINVOKE.WheelStates_Insert(swigCPtr, index, WheelState.getCPtr(x));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, WheelStates values) {
    vehiclePINVOKE.WheelStates_InsertRange(swigCPtr, index, WheelStates.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    vehiclePINVOKE.WheelStates_RemoveAt(swigCPtr, index);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    vehiclePINVOKE.WheelStates_RemoveRange(swigCPtr, index, count);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public static WheelStates Repeat(WheelState value, int count) {
    global::System.IntPtr cPtr = vehiclePINVOKE.WheelStates_Repeat(WheelState.getCPtr(value), count);
    WheelStates ret = (cPtr == global::System.IntPtr.Zero) ? null : new WheelStates(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    vehiclePINVOKE.WheelStates_Reverse__SWIG_0(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    vehiclePINVOKE.WheelStates_Reverse__SWIG_1(swigCPtr, index, count);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, WheelStates values) {
    vehiclePINVOKE.WheelStates_SetRange(swigCPtr, index, WheelStates.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
