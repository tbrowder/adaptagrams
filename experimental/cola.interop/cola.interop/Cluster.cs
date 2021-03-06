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

public class Cluster : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Cluster(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Cluster obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Cluster() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        colaPINVOKE.delete_Cluster(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public double varWeight {
    set {
      colaPINVOKE.Cluster_varWeight_set(swigCPtr, value);
    } 
    get {
      double ret = colaPINVOKE.Cluster_varWeight_get(swigCPtr);
      return ret;
    } 
  }

  public double internalEdgeWeightFactor {
    set {
      colaPINVOKE.Cluster_internalEdgeWeightFactor_set(swigCPtr, value);
    } 
    get {
      double ret = colaPINVOKE.Cluster_internalEdgeWeightFactor_get(swigCPtr);
      return ret;
    } 
  }

  public UnsignedVector nodes {
    set {
      colaPINVOKE.Cluster_nodes_set(swigCPtr, UnsignedVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.Cluster_nodes_get(swigCPtr);
      UnsignedVector ret = (cPtr == IntPtr.Zero) ? null : new UnsignedVector(cPtr, false);
      return ret;
    } 
  }

  public ClusterVector clusters {
    set {
      colaPINVOKE.Cluster_clusters_set(swigCPtr, ClusterVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.Cluster_clusters_get(swigCPtr);
      ClusterVector ret = (cPtr == IntPtr.Zero) ? null : new ClusterVector(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__valarrayT_double_t hullX {
    set {
      colaPINVOKE.Cluster_hullX_set(swigCPtr, SWIGTYPE_p_std__valarrayT_double_t.getCPtr(value));
      if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__valarrayT_double_t ret = new SWIGTYPE_p_std__valarrayT_double_t(colaPINVOKE.Cluster_hullX_get(swigCPtr), true);
      if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__valarrayT_double_t hullY {
    set {
      colaPINVOKE.Cluster_hullY_set(swigCPtr, SWIGTYPE_p_std__valarrayT_double_t.getCPtr(value));
      if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__valarrayT_double_t ret = new SWIGTYPE_p_std__valarrayT_double_t(colaPINVOKE.Cluster_hullY_get(swigCPtr), true);
      if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public virtual void computeBoundary(RectPtrVector rs) {
    colaPINVOKE.Cluster_computeBoundary(swigCPtr, RectPtrVector.getCPtr(rs));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void computeBoundingRect(RectPtrVector rs) {
    colaPINVOKE.Cluster_computeBoundingRect(swigCPtr, RectPtrVector.getCPtr(rs));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rectangle bounds {
    set {
      colaPINVOKE.Cluster_bounds_set(swigCPtr, Rectangle.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.Cluster_bounds_get(swigCPtr);
      Rectangle ret = (cPtr == IntPtr.Zero) ? null : new Rectangle(cPtr, false);
      return ret;
    } 
  }

  public void setDesiredBounds(Rectangle bounds) {
    colaPINVOKE.Cluster_setDesiredBounds(swigCPtr, Rectangle.getCPtr(bounds));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void unsetDesiredBounds() {
    colaPINVOKE.Cluster_unsetDesiredBounds(swigCPtr);
  }

  public void createVars(Dim dim, RectPtrVector rs, SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t vars) {
    colaPINVOKE.Cluster_createVars(swigCPtr, (int)dim, RectPtrVector.getCPtr(rs), SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t.getCPtr(vars));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_vpsc__Variable vXMin {
    set {
      colaPINVOKE.Cluster_vXMin_set(swigCPtr, SWIGTYPE_p_vpsc__Variable.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.Cluster_vXMin_get(swigCPtr);
      SWIGTYPE_p_vpsc__Variable ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_vpsc__Variable(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_vpsc__Variable vXMax {
    set {
      colaPINVOKE.Cluster_vXMax_set(swigCPtr, SWIGTYPE_p_vpsc__Variable.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.Cluster_vXMax_get(swigCPtr);
      SWIGTYPE_p_vpsc__Variable ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_vpsc__Variable(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_vpsc__Variable vYMin {
    set {
      colaPINVOKE.Cluster_vYMin_set(swigCPtr, SWIGTYPE_p_vpsc__Variable.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.Cluster_vYMin_get(swigCPtr);
      SWIGTYPE_p_vpsc__Variable ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_vpsc__Variable(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_vpsc__Variable vYMax {
    set {
      colaPINVOKE.Cluster_vYMax_set(swigCPtr, SWIGTYPE_p_vpsc__Variable.getCPtr(value));
    } 
    get {
      IntPtr cPtr = colaPINVOKE.Cluster_vYMax_get(swigCPtr);
      SWIGTYPE_p_vpsc__Variable ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_vpsc__Variable(cPtr, false);
      return ret;
    } 
  }

  public void generateNonOverlapConstraints(Dim dim, SWIGTYPE_p_NonOverlapConstraints nonOverlapConstraints, RectPtrVector rs, SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t vars, SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t cs) {
    colaPINVOKE.Cluster_generateNonOverlapConstraints(swigCPtr, (int)dim, SWIGTYPE_p_NonOverlapConstraints.getCPtr(nonOverlapConstraints), RectPtrVector.getCPtr(rs), SWIGTYPE_p_std__vectorT_vpsc__Variable_p_t.getCPtr(vars), SWIGTYPE_p_std__vectorT_vpsc__Constraint_p_t.getCPtr(cs));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    colaPINVOKE.Cluster_clear(swigCPtr);
  }

  public double area(RectPtrVector rs) {
    double ret = colaPINVOKE.Cluster_area(swigCPtr, RectPtrVector.getCPtr(rs));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void updateBounds(Dim dim) {
    colaPINVOKE.Cluster_updateBounds(swigCPtr, (int)dim);
  }

}

}
