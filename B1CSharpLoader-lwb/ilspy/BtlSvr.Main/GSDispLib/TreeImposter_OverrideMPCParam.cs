using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMPCParam")]
public struct TreeImposter_OverrideMPCParam
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMPCParam:MPC")]
	public UMaterialParameterCollection MPC;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMPCParam:ScalarParam")]
	public List<TreeImposter_OverrideMatScalarParam> ScalarParam;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMPCParam:LinearColorParam")]
	public List<TreeImposter_OverrideMatLinearColorParam> LinearColorParam;

	private static int TreeImposter_OverrideMPCParam_StructSize;

	private static int TreeImposter_OverrideMPCParam_IsValid;

	private static bool MPC_IsValid;

	private static int MPC_Offset;

	private static bool ScalarParam_IsValid;

	private static int ScalarParam_Offset;

	private static FFieldAddress ScalarParam_PropertyAddress;

	private static bool LinearColorParam_IsValid;

	private static int LinearColorParam_Offset;

	private static FFieldAddress LinearColorParam_PropertyAddress;

	public TreeImposter_OverrideMPCParam Copy()
	{
		TreeImposter_OverrideMPCParam result = this;
		if (ScalarParam != null)
		{
			result.ScalarParam = new List<TreeImposter_OverrideMatScalarParam>(ScalarParam);
		}
		if (LinearColorParam != null)
		{
			result.LinearColorParam = new List<TreeImposter_OverrideMatLinearColorParam>(LinearColorParam);
		}
		return result;
	}

	public static TreeImposter_OverrideMPCParam FromNative(IntPtr nativeBuffer)
	{
		return new TreeImposter_OverrideMPCParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, TreeImposter_OverrideMPCParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static TreeImposter_OverrideMPCParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TreeImposter_OverrideMPCParam(IntPtr.Add(nativeBuffer, arrayIndex * TreeImposter_OverrideMPCParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TreeImposter_OverrideMPCParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TreeImposter_OverrideMPCParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TreeImposter_OverrideMPCParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TreeImposter_OverrideMPCParam");
			return;
		}
		UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(nativeStruct, MPC_Offset), MPC);
		new TArrayCopyMarshaler<TreeImposter_OverrideMatScalarParam>(1, ScalarParam_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideMatScalarParam, BlittableTypeMarshaler<TreeImposter_OverrideMatScalarParam>>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideMatScalarParam, BlittableTypeMarshaler<TreeImposter_OverrideMatScalarParam>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ScalarParam_Offset), ScalarParam);
		new TArrayCopyMarshaler<TreeImposter_OverrideMatLinearColorParam>(1, LinearColorParam_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideMatLinearColorParam, BlittableTypeMarshaler<TreeImposter_OverrideMatLinearColorParam>>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideMatLinearColorParam, BlittableTypeMarshaler<TreeImposter_OverrideMatLinearColorParam>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LinearColorParam_Offset), LinearColorParam);
	}

	public TreeImposter_OverrideMPCParam(IntPtr nativeStruct)
	{
		if (TreeImposter_OverrideMPCParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TreeImposter_OverrideMPCParam");
			MPC = null;
			ScalarParam = null;
			LinearColorParam = null;
		}
		else
		{
			MPC = UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(nativeStruct, MPC_Offset));
			ScalarParam = new TArrayCopyMarshaler<TreeImposter_OverrideMatScalarParam>(1, ScalarParam_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideMatScalarParam, BlittableTypeMarshaler<TreeImposter_OverrideMatScalarParam>>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideMatScalarParam, BlittableTypeMarshaler<TreeImposter_OverrideMatScalarParam>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ScalarParam_Offset));
			LinearColorParam = new TArrayCopyMarshaler<TreeImposter_OverrideMatLinearColorParam>(1, LinearColorParam_PropertyAddress, CachedMarshalingDelegates<TreeImposter_OverrideMatLinearColorParam, BlittableTypeMarshaler<TreeImposter_OverrideMatLinearColorParam>>.FromNative, CachedMarshalingDelegates<TreeImposter_OverrideMatLinearColorParam, BlittableTypeMarshaler<TreeImposter_OverrideMatLinearColorParam>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LinearColorParam_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TreeImposter_OverrideMPCParam");
		TreeImposter_OverrideMPCParam_StructSize = NativeReflection.GetStructSize(intPtr);
		MPC_Offset = NativeReflection.GetPropertyOffset(intPtr, "MPC");
		MPC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MPC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ScalarParam_PropertyAddress, intPtr, "ScalarParam");
		ScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalarParam");
		ScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LinearColorParam_PropertyAddress, intPtr, "LinearColorParam");
		LinearColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "LinearColorParam");
		LinearColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LinearColorParam", Classes.FArrayProperty);
		TreeImposter_OverrideMPCParam_IsValid = ((intPtr != IntPtr.Zero && MPC_IsValid && ScalarParam_IsValid && LinearColorParam_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TreeImposter_OverrideMPCParam", (byte)TreeImposter_OverrideMPCParam_IsValid != 0);
	}

	static TreeImposter_OverrideMPCParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TreeImposter_OverrideMPCParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TreeImposter_OverrideMPCParam));
	}
}
