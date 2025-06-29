using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/Engine.FindFloorResult", "Engine", UnrealModuleType.Engine)]
public struct FFindFloorResult
{
	private static bool BlockingHit_IsValid;

	private static FFieldAddress BlockingHit_PropertyAddress;

	private static int BlockingHit_Offset;

	[UProperty(Flags = (PropFlags)6755468160665621uL)]
	[UMetaPath("/Script/Engine.FindFloorResult:bBlockingHit")]
	public bool BlockingHit;

	private static bool WalkableFloor_IsValid;

	private static FFieldAddress WalkableFloor_PropertyAddress;

	private static int WalkableFloor_Offset;

	[UProperty(Flags = (PropFlags)6755468160665621uL)]
	[UMetaPath("/Script/Engine.FindFloorResult:bWalkableFloor")]
	public bool WalkableFloor;

	private static bool LineTrace_IsValid;

	private static FFieldAddress LineTrace_PropertyAddress;

	private static int LineTrace_Offset;

	[UProperty(Flags = (PropFlags)6755468160665621uL)]
	[UMetaPath("/Script/Engine.FindFloorResult:bLineTrace")]
	public bool LineTrace;

	private static bool FloorDist_IsValid;

	private static int FloorDist_Offset;

	[UProperty(Flags = (PropFlags)6755469234407957uL)]
	[UMetaPath("/Script/Engine.FindFloorResult:FloorDist")]
	public float FloorDist;

	private static bool LineDist_IsValid;

	private static int LineDist_Offset;

	[UProperty(Flags = (PropFlags)6755469234407957uL)]
	[UMetaPath("/Script/Engine.FindFloorResult:LineDist")]
	public float LineDist;

	private static bool HitResult_IsValid;

	private static int HitResult_Offset;

	[UProperty(Flags = (PropFlags)4504219176536085uL)]
	[UMetaPath("/Script/Engine.FindFloorResult:HitResult")]
	public FHitResult HitResult;

	private static bool FFindFloorResult_IsValid;

	private static int FFindFloorResult_StructSize;

	public FFindFloorResult Copy()
	{
		return this;
	}

	public static FFindFloorResult FromNative(IntPtr nativeBuffer)
	{
		return new FFindFloorResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFindFloorResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFindFloorResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFindFloorResult(nativeBuffer + arrayIndex * FFindFloorResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFindFloorResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFindFloorResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFindFloorResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FindFloorResult");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BlockingHit_Offset), 0, BlockingHit_PropertyAddress.Address, BlockingHit);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WalkableFloor_Offset), 0, WalkableFloor_PropertyAddress.Address, WalkableFloor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LineTrace_Offset), 0, LineTrace_PropertyAddress.Address, LineTrace);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FloorDist_Offset), FloorDist);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LineDist_Offset), LineDist);
		FHitResult.ToNative(IntPtr.Add(nativeStruct, HitResult_Offset), HitResult);
	}

	public FFindFloorResult(IntPtr nativeStruct)
	{
		if (!FFindFloorResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FindFloorResult");
			BlockingHit = false;
			WalkableFloor = false;
			LineTrace = false;
			FloorDist = 0f;
			LineDist = 0f;
			HitResult = default(FHitResult);
		}
		else
		{
			BlockingHit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BlockingHit_Offset), 0, BlockingHit_PropertyAddress.Address);
			WalkableFloor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WalkableFloor_Offset), 0, WalkableFloor_PropertyAddress.Address);
			LineTrace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LineTrace_Offset), 0, LineTrace_PropertyAddress.Address);
			FloorDist = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FloorDist_Offset));
			LineDist = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LineDist_Offset));
			HitResult = FHitResult.FromNative(IntPtr.Add(nativeStruct, HitResult_Offset));
		}
	}

	static FFindFloorResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFindFloorResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFindFloorResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FindFloorResult");
		FFindFloorResult_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BlockingHit_PropertyAddress, intPtr, "bBlockingHit");
		BlockingHit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBlockingHit");
		BlockingHit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBlockingHit", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WalkableFloor_PropertyAddress, intPtr, "bWalkableFloor");
		WalkableFloor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWalkableFloor");
		WalkableFloor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWalkableFloor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTrace_PropertyAddress, intPtr, "bLineTrace");
		LineTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLineTrace");
		LineTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLineTrace", Classes.FBoolProperty);
		FloorDist_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloorDist");
		FloorDist_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloorDist", Classes.FFloatProperty);
		LineDist_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LineDist");
		LineDist_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LineDist", Classes.FFloatProperty);
		HitResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitResult");
		HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitResult", Classes.FStructProperty);
		FFindFloorResult_IsValid = intPtr != IntPtr.Zero && BlockingHit_IsValid && WalkableFloor_IsValid && LineTrace_IsValid && FloorDist_IsValid && LineDist_IsValid && HitResult_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.FindFloorResult", FFindFloorResult_IsValid);
	}
}
