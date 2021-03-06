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

public class SeparationConstraint : CompoundConstraint {
  private HandleRef swigCPtr;

  internal SeparationConstraint(IntPtr cPtr, bool cMemoryOwn) : base(colaPINVOKE.SeparationConstraintUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SeparationConstraint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SeparationConstraint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        colaPINVOKE.delete_SeparationConstraint(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SeparationConstraint(uint l, uint r, double g, bool equality) : this(colaPINVOKE.new_SeparationConstraint__SWIG_0(l, r, g, equality), true) {
  }

  public SeparationConstraint(uint l, uint r, double g) : this(colaPINVOKE.new_SeparationConstraint__SWIG_1(l, r, g), true) {
  }

  public SeparationConstraint(AlignmentConstraint l, AlignmentConstraint r, double g, bool equality) : this(colaPINVOKE.new_SeparationConstraint__SWIG_2(AlignmentConstraint.getCPtr(l), AlignmentConstraint.getCPtr(r), g, equality), true) {
  }

  public SeparationConstraint(AlignmentConstraint l, AlignmentConstraint r, double g) : this(colaPINVOKE.new_SeparationConstraint__SWIG_3(AlignmentConstraint.getCPtr(l), AlignmentConstraint.getCPtr(r), g), true) {
  }

  public uint left {
    set {
      colaPINVOKE.SeparationConstraint_left_set(swigCPtr, value);
    } 
    get {
      uint ret = colaPINVOKE.SeparationConstraint_left_get(swigCPtr);
      return ret;
    } 
  }

  public uint right {
    set {
      colaPINVOKE.SeparationConstraint_right_set(swigCPtr, value);
    } 
    get {
      uint ret = colaPINVOKE.SeparationConstraint_right_get(swigCPtr);
      return ret;
    } 
  }

  public AlignmentConstraint al {
    set {
      colaPINVOKE.SeparationConstraint_al_set(swigCPtr, AlignmentConstraint.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.SeparationConstraint_al_get(swigCPtr);
      AlignmentConstraint ret = (cPtr == IntPtr.Zero) ? null : new AlignmentConstraint(cPtr, false);
      return ret;
    } 
  }

  public AlignmentConstraint ar {
    set {
      colaPINVOKE.SeparationConstraint_ar_set(swigCPtr, AlignmentConstraint.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.SeparationConstraint_ar_get(swigCPtr);
      AlignmentConstraint ret = (cPtr == IntPtr.Zero) ? null : new AlignmentConstraint(cPtr, false);
      return ret;
    } 
  }

  public double gap {
    set {
      colaPINVOKE.SeparationConstraint_gap_set(swigCPtr, value);
    } 
    get {
      double ret = colaPINVOKE.SeparationConstraint_gap_get(swigCPtr);
      return ret;
    } 
  }

  public bool equality {
    set {
      colaPINVOKE.SeparationConstraint_equality_set(swigCPtr, value);
    } 
    get {
      bool ret = colaPINVOKE.SeparationConstraint_equality_get(swigCPtr);
      return ret;
    } 
  }

  public override void generateVariables(SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t vars) {
    colaPINVOKE.SeparationConstraint_generateVariables(swigCPtr, SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t.getCPtr(vars));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void generateSeparationConstraints(SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t vs, SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t cs) {
    colaPINVOKE.SeparationConstraint_generateSeparationConstraints(swigCPtr, SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t.getCPtr(vs), SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t.getCPtr(cs));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSeparation(double gap) {
    colaPINVOKE.SeparationConstraint_setSeparation(swigCPtr, gap);
  }

  public SWIGTYPE_p_vpsc__Constraint vpscConstraint {
    set {
      colaPINVOKE.SeparationConstraint_vpscConstraint_set(swigCPtr, SWIGTYPE_p_vpsc__Constraint.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.SeparationConstraint_vpscConstraint_get(swigCPtr);
      SWIGTYPE_p_vpsc__Constraint ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_vpsc__Constraint(cPtr, false);
      return ret;
    } 
  }

}

}
