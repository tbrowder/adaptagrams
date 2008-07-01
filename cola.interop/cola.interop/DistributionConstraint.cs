/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.adaptagrams.cola {

using System;
using System.Runtime.InteropServices;

public class DistributionConstraint : CompoundConstraint {
  private HandleRef swigCPtr;

  internal DistributionConstraint(IntPtr cPtr, bool cMemoryOwn) : base(colaPINVOKE.DistributionConstraintUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DistributionConstraint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DistributionConstraint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        colaPINVOKE.delete_DistributionConstraint(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DistributionConstraint() : this(colaPINVOKE.new_DistributionConstraint(), true) {
  }

  public override void generateVariables(SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t vars) {
    colaPINVOKE.DistributionConstraint_generateVariables(swigCPtr, SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t.getCPtr(vars));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void generateSeparationConstraints(SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t vars, SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t gcs) {
    colaPINVOKE.DistributionConstraint_generateSeparationConstraints(swigCPtr, SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t.getCPtr(vars), SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t.getCPtr(gcs));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSeparation(double sep) {
    colaPINVOKE.DistributionConstraint_setSeparation(swigCPtr, sep);
  }

  public SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t cs {
    set {
      colaPINVOKE.DistributionConstraint_cs_set(swigCPtr, SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.DistributionConstraint_cs_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_std__pairT_cola__AlignmentConstraint_p_cola__AlignmentConstraint_p_t_t acs {
    set {
      colaPINVOKE.DistributionConstraint_acs_set(swigCPtr, SWIGTYPE_p_std__vectorT_std__pairT_cola__AlignmentConstraint_p_cola__AlignmentConstraint_p_t_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.DistributionConstraint_acs_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_std__pairT_cola__AlignmentConstraint_p_cola__AlignmentConstraint_p_t_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_std__pairT_cola__AlignmentConstraint_p_cola__AlignmentConstraint_p_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void indicator {
    set {
      colaPINVOKE.DistributionConstraint_indicator_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.DistributionConstraint_indicator_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public double sep {
    set {
      colaPINVOKE.DistributionConstraint_sep_set(swigCPtr, value);
    } 
    get {
      double ret = colaPINVOKE.DistributionConstraint_sep_get(swigCPtr);
      return ret;
    } 
  }

}

}
