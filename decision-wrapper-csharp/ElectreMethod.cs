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

public class ElectreMethod : MultiStepMethod {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ElectreMethod(global::System.IntPtr cPtr, bool cMemoryOwn) : base(libdesPINVOKE.ElectreMethod_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ElectreMethod obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ElectreMethod obj) {
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
          libdesPINVOKE.delete_ElectreMethod(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ElectreMethod() : this(libdesPINVOKE.new_ElectreMethod__SWIG_0(), true) {
  }

  public ElectreMethod(MathModel mathModel, CriteriaRelation relation) : this(libdesPINVOKE.new_ElectreMethod__SWIG_1(MathModel.getCPtr(mathModel), CriteriaRelation.getCPtr(relation)), true) {
    if (libdesPINVOKE.SWIGPendingException.Pending) throw libdesPINVOKE.SWIGPendingException.Retrieve();
  }

  public override SolveStatus solve() {
    SolveStatus ret = new SolveStatus(libdesPINVOKE.ElectreMethod_solve(swigCPtr), true);
    return ret;
  }

  public override SolveStatus makeIteration(DecisionMakerInfo decisionMakingInfo) {
    SolveStatus ret = new SolveStatus(libdesPINVOKE.ElectreMethod_makeIteration(swigCPtr, DecisionMakerInfo.getCPtr(decisionMakingInfo)), true);
    return ret;
  }

  public override IntermediateMethodData getIntermediateMethodData() {
    global::System.IntPtr cPtr = libdesPINVOKE.ElectreMethod_getIntermediateMethodData(swigCPtr);
    IntermediateMethodData ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntermediateMethodData(cPtr, false);
    return ret;
  }

  public override EstimateVector getBestEstimateVector() {
    EstimateVector ret = new EstimateVector(libdesPINVOKE.ElectreMethod_getBestEstimateVector(swigCPtr), true);
    return ret;
  }

}

}
