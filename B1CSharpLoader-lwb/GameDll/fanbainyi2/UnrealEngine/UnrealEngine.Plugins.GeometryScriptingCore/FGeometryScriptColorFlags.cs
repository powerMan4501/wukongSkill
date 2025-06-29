using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptColorFlags", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptColorFlags
{
	private static bool Red_IsValid;

	private static FFieldAddress Red_PropertyAddress;

	private static int Red_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptColorFlags:bRed")]
	public bool Red;

	private static bool Green_IsValid;

	private static FFieldAddress Green_PropertyAddress;

	private static int Green_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptColorFlags:bGreen")]
	public bool Green;

	private static bool Blue_IsValid;

	private static FFieldAddress Blue_PropertyAddress;

	private static int Blue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptColorFlags:bBlue")]
	public bool Blue;

	private static bool Alpha_IsValid;

	private static FFieldAddress Alpha_PropertyAddress;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptColorFlags:bAlpha")]
	public bool Alpha;

	private static bool FGeometryScriptColorFlags_IsValid;

	private static int FGeometryScriptColorFlags_StructSize;

	public FGeometryScriptColorFlags Copy()
	{
		return this;
	}

	public static FGeometryScriptColorFlags FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptColorFlags(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptColorFlags value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptColorFlags FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptColorFlags(nativeBuffer + arrayIndex * FGeometryScriptColorFlags_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptColorFlags value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptColorFlags_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptColorFlags_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptColorFlags");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Red_Offset), 0, Red_PropertyAddress.Address, Red);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Green_Offset), 0, Green_PropertyAddress.Address, Green);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Blue_Offset), 0, Blue_PropertyAddress.Address, Blue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), 0, Alpha_PropertyAddress.Address, Alpha);
	}

	public FGeometryScriptColorFlags(IntPtr nativeStruct)
	{
		if (!FGeometryScriptColorFlags_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptColorFlags");
			Red = false;
			Green = false;
			Blue = false;
			Alpha = false;
		}
		else
		{
			Red = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Red_Offset), 0, Red_PropertyAddress.Address);
			Green = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Green_Offset), 0, Green_PropertyAddress.Address);
			Blue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Blue_Offset), 0, Blue_PropertyAddress.Address);
			Alpha = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset), 0, Alpha_PropertyAddress.Address);
		}
	}

	static FGeometryScriptColorFlags()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptColorFlags)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptColorFlags));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptColorFlags");
		FGeometryScriptColorFlags_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Red_PropertyAddress, intPtr, "bRed");
		Red_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRed");
		Red_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Green_PropertyAddress, intPtr, "bGreen");
		Green_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGreen");
		Green_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGreen", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Blue_PropertyAddress, intPtr, "bBlue");
		Blue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBlue");
		Blue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBlue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Alpha_PropertyAddress, intPtr, "bAlpha");
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlpha", Classes.FBoolProperty);
		FGeometryScriptColorFlags_IsValid = intPtr != IntPtr.Zero && Red_IsValid && Green_IsValid && Blue_IsValid && Alpha_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptColorFlags", FGeometryScriptColorFlags_IsValid);
	}
}
