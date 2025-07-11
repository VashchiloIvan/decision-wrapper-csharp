//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace MultiCriteriaCsharpApi {

public class TaskStep : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TaskStep(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TaskStep obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TaskStep obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~TaskStep() {
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
          libdesPINVOKE.delete_TaskStep(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TaskStep(string type, string step) : this(libdesPINVOKE.new_TaskStep__SWIG_0(type, step), true) {
    if (libdesPINVOKE.SWIGPendingException.Pending) throw libdesPINVOKE.SWIGPendingException.Retrieve();
  }

  public TaskStep(string type, StringList row) : this(libdesPINVOKE.new_TaskStep__SWIG_1(type, StringList.getCPtr(row)), true) {
    if (libdesPINVOKE.SWIGPendingException.Pending) throw libdesPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TaskStep TextType(string step) {
    global::System.IntPtr cPtr = libdesPINVOKE.TaskStep_TextType(step);
    TaskStep ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaskStep(cPtr, false);
    if (libdesPINVOKE.SWIGPendingException.Pending) throw libdesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TaskStep BoldTextType(string step) {
    global::System.IntPtr cPtr = libdesPINVOKE.TaskStep_BoldTextType(step);
    TaskStep ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaskStep(cPtr, false);
    if (libdesPINVOKE.SWIGPendingException.Pending) throw libdesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TaskStep TablePartType(string type, StringList row) {
    global::System.IntPtr cPtr = libdesPINVOKE.TaskStep_TablePartType(type, StringList.getCPtr(row));
    TaskStep ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaskStep(cPtr, false);
    if (libdesPINVOKE.SWIGPendingException.Pending) throw libdesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TaskStep EndTableType() {
    global::System.IntPtr cPtr = libdesPINVOKE.TaskStep_EndTableType();
    TaskStep ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaskStep(cPtr, false);
    return ret;
  }

  public string StepType() {
    string ret = libdesPINVOKE.TaskStep_StepType(swigCPtr);
    return ret;
  }

  public string AsString() {
    string ret = libdesPINVOKE.TaskStep_AsString(swigCPtr);
    return ret;
  }

}

}
