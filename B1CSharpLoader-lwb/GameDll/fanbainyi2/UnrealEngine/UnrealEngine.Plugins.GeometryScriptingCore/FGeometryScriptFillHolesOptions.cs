using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptFillHolesOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptFillHolesOptions
{
	private static bool FillMethod_IsValid;

	private static FFieldAddress FillMethod_PropertyAddress;

	private static int FillMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptFillHolesOptions:FillMethod")]
	public EGeometryScriptFillHolesMethod FillMethod;

	private static bool FGeometryScriptFillHolesOptions_IsValid;

	private static int FGeometryScriptFillHolesOptions_StructSize;

	public FGeometryScriptFillHolesOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptFillHolesOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptFillHolesOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptFillHolesOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptFillHolesOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptFillHolesOptions(nativeBuffer + arrayIndex * FGeometryScriptFillHolesOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptFillHolesOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptFillHolesOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptFillHolesOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptFillHolesOptions");
		}
		else
		{
			EnumMarshaler<EGeometryScriptFillHolesMethod>.ToNative(IntPtr.Add(nativeStruct, FillMethod_Offset), 0, FillMethod_PropertyAddress.Address, FillMethod);
		}
	}

	public FGeometryScriptFillHolesOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptFillHolesOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptFillHolesOptions");
			FillMethod = EGeometryScriptFillHolesMethod.Automatic;
		}
		else
		{
			FillMethod = EnumMarshaler<EGeometryScriptFillHolesMethod>.FromNative(IntPtr.Add(nativeStruct, FillMethod_Offset), 0, FillMethod_PropertyAddress.Address);
		}
	}

	static FGeometryScriptFillHolesOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptFillHolesOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptFillHolesOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptFillHolesOptions");
		FGeometryScriptFillHolesOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FillMethod_PropertyAddress, intPtr, "FillMethod");
		FillMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FillMethod");
		FillMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FillMethod", Classes.FEnumProperty);
		FGeometryScriptFillHolesOptions_IsValid = intPtr != IntPtr.Zero && FillMethod_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptFillHolesOptions", FGeometryScriptFillHolesOptions_IsValid);
	}
}
