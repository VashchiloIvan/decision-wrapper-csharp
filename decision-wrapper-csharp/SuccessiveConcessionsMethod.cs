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

public class SuccessiveConcessionsMethod : MultiStepMethod {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SuccessiveConcessionsMethod(global::System.IntPtr cPtr, bool cMemoryOwn) : base(libdesPINVOKE.SuccessiveConcessionsMethod_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SuccessiveConcessionsMethod obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(SuccessiveConcessionsMethod obj) {
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

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libdesPINVOKE.delete_SuccessiveConcessionsMethod(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public SuccessiveConcessionsMethod() : this(libdesPINVOKE.new_SuccessiveConcessionsMethod__SWIG_0(), true) {
  }

  public SuccessiveConcessionsMethod(MathModel mathModel, CriteriaRelation relation) : this(libdesPINVOKE.new_SuccessiveConcessionsMethod__SWIG_1(MathModel.getCPtr(mathModel), CriteriaRelation.getCPtr(relation)), true) {
    if (libdesPINVOKE.SWIGPendingException.Pending) throw libdesPINVOKE.SWIGPendingException.Retrieve();
  }

  public override SolveStatus solve() {
    SolveStatus ret = new SolveStatus(libdesPINVOKE.SuccessiveConcessionsMethod_solve(swigCPtr), true);
    return ret;
  }

  public override SolveStatus makeIteration(DecisionMakerInfo decisionMakingInfo) {
    SolveStatus ret = new SolveStatus(libdesPINVOKE.SuccessiveConcessionsMethod_makeIteration(swigCPtr, DecisionMakerInfo.getCPtr(decisionMakingInfo)), true);
    return ret;
  }

  public override IntermediateMethodData getIntermediateMethodData() {
    global::System.IntPtr cPtr = libdesPINVOKE.SuccessiveConcessionsMethod_getIntermediateMethodData(swigCPtr);
    IntermediateMethodData ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntermediateMethodData(cPtr, false);
    return ret;
  }

  public override EstimateVector getBestEstimateVector() {
    EstimateVector ret = new EstimateVector(libdesPINVOKE.SuccessiveConcessionsMethod_getBestEstimateVector(swigCPtr), true);
    return ret;
  }

}

}
