//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChWheelList : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChWheelList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChWheelList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChWheelList() {
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
          vehiclePINVOKE.delete_ChWheelList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChWheelList(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t element in c) {
      this.Add(element);
    }
  }

  public ChWheelList(global::System.Collections.Generic.IEnumerable<SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t element in c) {
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

  public SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t this[int index]  {
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

  public void CopyTo(SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t[] array, int arrayIndex, int count)
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

  public SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t[] ToArray() {
    SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t[] array = new SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t> global::System.Collections.Generic.IEnumerable<SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t>.GetEnumerator() {
    return new ChWheelListEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new ChWheelListEnumerator(this);
  }

  public ChWheelListEnumerator GetEnumerator() {
    return new ChWheelListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class ChWheelListEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t>
  {
    private ChWheelList collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ChWheelListEnumerator(ChWheelList collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t)currentObject;
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
    vehiclePINVOKE.ChWheelList_Clear(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t x) {
    vehiclePINVOKE.ChWheelList_Add(swigCPtr, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t.getCPtr(x));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = vehiclePINVOKE.ChWheelList_size(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = vehiclePINVOKE.ChWheelList_capacity(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    vehiclePINVOKE.ChWheelList_reserve(swigCPtr, n);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChWheelList() : this(vehiclePINVOKE.new_ChWheelList__SWIG_0(), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChWheelList(ChWheelList other) : this(vehiclePINVOKE.new_ChWheelList__SWIG_1(ChWheelList.getCPtr(other)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChWheelList(int capacity) : this(vehiclePINVOKE.new_ChWheelList__SWIG_2(capacity), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t getitemcopy(int index) {
    SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t ret = new SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t(vehiclePINVOKE.ChWheelList_getitemcopy(swigCPtr, index), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t getitem(int index) {
    SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t ret = new SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t(vehiclePINVOKE.ChWheelList_getitem(swigCPtr, index), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t val) {
    vehiclePINVOKE.ChWheelList_setitem(swigCPtr, index, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t.getCPtr(val));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(ChWheelList values) {
    vehiclePINVOKE.ChWheelList_AddRange(swigCPtr, ChWheelList.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChWheelList GetRange(int index, int count) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChWheelList_GetRange(swigCPtr, index, count);
    ChWheelList ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChWheelList(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t x) {
    vehiclePINVOKE.ChWheelList_Insert(swigCPtr, index, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t.getCPtr(x));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, ChWheelList values) {
    vehiclePINVOKE.ChWheelList_InsertRange(swigCPtr, index, ChWheelList.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    vehiclePINVOKE.ChWheelList_RemoveAt(swigCPtr, index);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    vehiclePINVOKE.ChWheelList_RemoveRange(swigCPtr, index, count);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ChWheelList Repeat(SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t value, int count) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChWheelList_Repeat(SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChWheel_t.getCPtr(value), count);
    ChWheelList ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChWheelList(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    vehiclePINVOKE.ChWheelList_Reverse__SWIG_0(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    vehiclePINVOKE.ChWheelList_Reverse__SWIG_1(swigCPtr, index, count);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, ChWheelList values) {
    vehiclePINVOKE.ChWheelList_SetRange(swigCPtr, index, ChWheelList.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}