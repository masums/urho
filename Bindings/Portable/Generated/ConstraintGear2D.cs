// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// ConstraintGear2D.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Urho2D
{
	/// <summary>
	/// 2D gear constraint component.
	/// </summary>
	public unsafe partial class ConstraintGear2D : Constraint2D
	{
		public ConstraintGear2D (IntPtr handle) : base (handle)
		{
		}

		protected ConstraintGear2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ConstraintGear2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (ConstraintGear2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ConstraintGear2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ConstraintGear2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ConstraintGear2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(ConstraintGear2D));
			return new StringHash (ConstraintGear2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ConstraintGear2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(ConstraintGear2D));
			return Marshal.PtrToStringAnsi (ConstraintGear2D_GetTypeNameStatic ());
		}

		public ConstraintGear2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ConstraintGear2D_ConstraintGear2D (IntPtr context);

		public ConstraintGear2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(ConstraintGear2D));
			handle = ConstraintGear2D_ConstraintGear2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ConstraintGear2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(ConstraintGear2D));
			ConstraintGear2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ConstraintGear2D_SetOwnerConstraint (IntPtr handle, IntPtr constraint);

		/// <summary>
		/// Set owner constraint.
		/// </summary>
		private void SetOwnerConstraint (Constraint2D constraint)
		{
			Runtime.ValidateRefCounted (this);
			ConstraintGear2D_SetOwnerConstraint (handle, (object)constraint == null ? IntPtr.Zero : constraint.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ConstraintGear2D_SetOtherConstraint (IntPtr handle, IntPtr constraint);

		/// <summary>
		/// Set other constraint.
		/// </summary>
		private void SetOtherConstraint (Constraint2D constraint)
		{
			Runtime.ValidateRefCounted (this);
			ConstraintGear2D_SetOtherConstraint (handle, (object)constraint == null ? IntPtr.Zero : constraint.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ConstraintGear2D_SetRatio (IntPtr handle, float ratio);

		/// <summary>
		/// Set ratio.
		/// </summary>
		private void SetRatio (float ratio)
		{
			Runtime.ValidateRefCounted (this);
			ConstraintGear2D_SetRatio (handle, ratio);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ConstraintGear2D_GetOwnerConstraint (IntPtr handle);

		/// <summary>
		/// Return owner constraint.
		/// </summary>
		private Constraint2D GetOwnerConstraint ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Constraint2D> (ConstraintGear2D_GetOwnerConstraint (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ConstraintGear2D_GetOtherConstraint (IntPtr handle);

		/// <summary>
		/// Return other constraint.
		/// </summary>
		private Constraint2D GetOtherConstraint ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Constraint2D> (ConstraintGear2D_GetOtherConstraint (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float ConstraintGear2D_GetRatio (IntPtr handle);

		/// <summary>
		/// Return ratio.
		/// </summary>
		private float GetRatio ()
		{
			Runtime.ValidateRefCounted (this);
			return ConstraintGear2D_GetRatio (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return owner constraint.
		/// Or
		/// Set owner constraint.
		/// </summary>
		public Constraint2D OwnerConstraint {
			get {
				return GetOwnerConstraint ();
			}
			set {
				SetOwnerConstraint (value);
			}
		}

		/// <summary>
		/// Return other constraint.
		/// Or
		/// Set other constraint.
		/// </summary>
		public Constraint2D OtherConstraint {
			get {
				return GetOtherConstraint ();
			}
			set {
				SetOtherConstraint (value);
			}
		}

		/// <summary>
		/// Return ratio.
		/// Or
		/// Set ratio.
		/// </summary>
		public float Ratio {
			get {
				return GetRatio ();
			}
			set {
				SetRatio (value);
			}
		}
	}
}