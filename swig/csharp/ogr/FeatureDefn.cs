/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.24
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OGR {

using System;

public class FeatureDefn : IDisposable {
  private IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal FeatureDefn(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(FeatureDefn obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  protected FeatureDefn() : this(IntPtr.Zero, false) {
  }

  public virtual void Dispose() {
    if(swigCPtr != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      throw new MethodAccessException("C++ destructor does not have public access");
    }
    swigCPtr = IntPtr.Zero;
    GC.SuppressFinalize(this);
  }

  public void Destroy() {
    ogrPINVOKE.FeatureDefn_Destroy(swigCPtr);
  }

  public string GetName() {
    return ogrPINVOKE.FeatureDefn_GetName(swigCPtr);
  }

  public int GetFieldCount() {
    return ogrPINVOKE.FeatureDefn_GetFieldCount(swigCPtr);
  }

  public FieldDefn GetFieldDefn(int i) {
    IntPtr cPtr = ogrPINVOKE.FeatureDefn_GetFieldDefn(swigCPtr, i);
    return (cPtr == IntPtr.Zero) ? null : new FieldDefn(cPtr, true);
  }

  public int GetFieldIndex(string name) {
    return ogrPINVOKE.FeatureDefn_GetFieldIndex(swigCPtr, name);
  }

  public void AddFieldDefn(FieldDefn defn) {
    ogrPINVOKE.FeatureDefn_AddFieldDefn(swigCPtr, FieldDefn.getCPtr(defn));
  }

  public int GetGeomType() {
    return ogrPINVOKE.FeatureDefn_GetGeomType(swigCPtr);
  }

  public void SetGeomType(int geom_type) {
    ogrPINVOKE.FeatureDefn_SetGeomType(swigCPtr, geom_type);
  }

  public int Reference() {
    return ogrPINVOKE.FeatureDefn_Reference(swigCPtr);
  }

  public int Dereference() {
    return ogrPINVOKE.FeatureDefn_Dereference(swigCPtr);
  }

  public int GetReferenceCount() {
    return ogrPINVOKE.FeatureDefn_GetReferenceCount(swigCPtr);
  }

}

}
