using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSetSimpleCollisionOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptSetSimpleCollisionOptions
{
	private static bool EmitTransaction_IsValid;

	private static FFieldAddress EmitTransaction_PropertyAddress;

	private static int EmitTransaction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSetSimpleCollisionOptions:bEmitTransaction")]
	public bool EmitTransaction;

	private static bool FGeometryScriptSetSimpleCollisionOptions_IsValid;

	private static int FGeometryScriptSetSimpleCollisionOptions_StructSize;

	public FGeometryScriptSetSimpleCollisionOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptSetSimpleCollisionOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptSetSimpleCollisionOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptSetSimpleCollisionOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptSetSimpleCollisionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptSetSimpleCollisionOptions(nativeBuffer + arrayIndex * FGeometryScriptSetSimpleCollisionOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptSetSimpleCollisionOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptSetSimpleCollisionOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSetSimpleCollisionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSetSimpleCollisionOptions");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EmitTransaction_Offset), 0, EmitTransaction_PropertyAddress.Address, EmitTransaction);
		}
	}

	public FGeometryScriptSetSimpleCollisionOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSetSimpleCollisionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSetSimpleCollisionOptions");
			EmitTransaction = false;
		}
		else
		{
			EmitTransaction = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EmitTransaction_Offset), 0, EmitTransaction_PropertyAddress.Address);
		}
	}

	static FGeometryScriptSetSimpleCollisionOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptSetSimpleCollisionOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptSetSimpleCollisionOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptSetSimpleCollisionOptions");
		FGeometryScriptSetSimpleCollisionOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EmitTransaction_PropertyAddress, intPtr, "bEmitTransaction");
		EmitTransaction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEmitTransaction");
		EmitTransaction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEmitTransaction", Classes.FBoolProperty);
		FGeometryScriptSetSimpleCollisionOptions_IsValid = intPtr != IntPtr.Zero && EmitTransaction_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptSetSimpleCollisionOptions", FGeometryScriptSetSimpleCollisionOptions_IsValid);
	}
}
