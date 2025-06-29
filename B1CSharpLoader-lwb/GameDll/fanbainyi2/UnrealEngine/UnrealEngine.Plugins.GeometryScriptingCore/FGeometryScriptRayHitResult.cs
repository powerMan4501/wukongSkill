using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRayHitResult", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptRayHitResult
{
	private static bool Hit_IsValid;

	private static FFieldAddress Hit_PropertyAddress;

	private static int Hit_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRayHitResult:bHit")]
	public bool Hit;

	private static bool RayParameter_IsValid;

	private static int RayParameter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRayHitResult:RayParameter")]
	public float RayParameter;

	private static bool HitTriangleID_IsValid;

	private static int HitTriangleID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRayHitResult:HitTriangleID")]
	public int HitTriangleID;

	private static bool HitPosition_IsValid;

	private static int HitPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRayHitResult:HitPosition")]
	public FVector HitPosition;

	private static bool HitBaryCoords_IsValid;

	private static int HitBaryCoords_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRayHitResult:HitBaryCoords")]
	public FVector HitBaryCoords;

	private static bool FGeometryScriptRayHitResult_IsValid;

	private static int FGeometryScriptRayHitResult_StructSize;

	public FGeometryScriptRayHitResult Copy()
	{
		return this;
	}

	public static FGeometryScriptRayHitResult FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptRayHitResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptRayHitResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptRayHitResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptRayHitResult(nativeBuffer + arrayIndex * FGeometryScriptRayHitResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptRayHitResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptRayHitResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRayHitResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRayHitResult");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Hit_Offset), 0, Hit_PropertyAddress.Address, Hit);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RayParameter_Offset), RayParameter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HitTriangleID_Offset), HitTriangleID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, HitPosition_Offset), HitPosition);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, HitBaryCoords_Offset), HitBaryCoords);
	}

	public FGeometryScriptRayHitResult(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRayHitResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRayHitResult");
			Hit = false;
			RayParameter = 0f;
			HitTriangleID = 0;
			HitPosition = default(FVector);
			HitBaryCoords = default(FVector);
		}
		else
		{
			Hit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Hit_Offset), 0, Hit_PropertyAddress.Address);
			RayParameter = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RayParameter_Offset));
			HitTriangleID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HitTriangleID_Offset));
			HitPosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, HitPosition_Offset));
			HitBaryCoords = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, HitBaryCoords_Offset));
		}
	}

	static FGeometryScriptRayHitResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptRayHitResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptRayHitResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptRayHitResult");
		FGeometryScriptRayHitResult_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Hit_PropertyAddress, intPtr, "bHit");
		Hit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHit");
		Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHit", Classes.FBoolProperty);
		RayParameter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayParameter");
		RayParameter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayParameter", Classes.FFloatProperty);
		HitTriangleID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitTriangleID");
		HitTriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitTriangleID", Classes.FIntProperty);
		HitPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitPosition");
		HitPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitPosition", Classes.FStructProperty);
		HitBaryCoords_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitBaryCoords");
		HitBaryCoords_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitBaryCoords", Classes.FStructProperty);
		FGeometryScriptRayHitResult_IsValid = intPtr != IntPtr.Zero && Hit_IsValid && RayParameter_IsValid && HitTriangleID_IsValid && HitPosition_IsValid && HitBaryCoords_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptRayHitResult", FGeometryScriptRayHitResult_IsValid);
	}
}
