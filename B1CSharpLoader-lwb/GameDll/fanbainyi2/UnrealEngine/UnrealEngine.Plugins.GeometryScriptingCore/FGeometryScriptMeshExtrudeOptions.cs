using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshExtrudeOptions
{
	private static bool ExtrudeDistance_IsValid;

	private static int ExtrudeDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions:ExtrudeDistance")]
	public float ExtrudeDistance;

	private static bool ExtrudeDirection_IsValid;

	private static int ExtrudeDirection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions:ExtrudeDirection")]
	public FVector ExtrudeDirection;

	private static bool UVScale_IsValid;

	private static int UVScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions:UVScale")]
	public float UVScale;

	private static bool SolidsToShells_IsValid;

	private static FFieldAddress SolidsToShells_PropertyAddress;

	private static int SolidsToShells_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions:bSolidsToShells")]
	public bool SolidsToShells;

	private static bool FGeometryScriptMeshExtrudeOptions_IsValid;

	private static int FGeometryScriptMeshExtrudeOptions_StructSize;

	public FGeometryScriptMeshExtrudeOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshExtrudeOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshExtrudeOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshExtrudeOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshExtrudeOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshExtrudeOptions(nativeBuffer + arrayIndex * FGeometryScriptMeshExtrudeOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshExtrudeOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshExtrudeOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshExtrudeOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExtrudeDistance_Offset), ExtrudeDistance);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ExtrudeDirection_Offset), ExtrudeDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, UVScale_Offset), UVScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SolidsToShells_Offset), 0, SolidsToShells_PropertyAddress.Address, SolidsToShells);
	}

	public FGeometryScriptMeshExtrudeOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshExtrudeOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions");
			ExtrudeDistance = 0f;
			ExtrudeDirection = default(FVector);
			UVScale = 0f;
			SolidsToShells = false;
		}
		else
		{
			ExtrudeDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExtrudeDistance_Offset));
			ExtrudeDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ExtrudeDirection_Offset));
			UVScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, UVScale_Offset));
			SolidsToShells = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SolidsToShells_Offset), 0, SolidsToShells_PropertyAddress.Address);
		}
	}

	static FGeometryScriptMeshExtrudeOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshExtrudeOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshExtrudeOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions");
		FGeometryScriptMeshExtrudeOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		ExtrudeDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExtrudeDistance");
		ExtrudeDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExtrudeDistance", Classes.FFloatProperty);
		ExtrudeDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExtrudeDirection");
		ExtrudeDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExtrudeDirection", Classes.FStructProperty);
		UVScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVScale");
		UVScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SolidsToShells_PropertyAddress, intPtr, "bSolidsToShells");
		SolidsToShells_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSolidsToShells");
		SolidsToShells_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSolidsToShells", Classes.FBoolProperty);
		FGeometryScriptMeshExtrudeOptions_IsValid = intPtr != IntPtr.Zero && ExtrudeDistance_IsValid && ExtrudeDirection_IsValid && UVScale_IsValid && SolidsToShells_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshExtrudeOptions", FGeometryScriptMeshExtrudeOptions_IsValid);
	}
}
