using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSEArteries.GSEArteriesBoxComponent", "GSEArteries", UnrealModuleType.GamePlugin)]
public class UGSEArteriesBoxComponent : UBoxComponent
{
	private static bool GetSurfacePointsClockWise_IsValid;

	private static IntPtr GetSurfacePointsClockWise_FunctionAddress;

	private static int GetSurfacePointsClockWise_ParamsSize;

	private static bool GetSurfacePointsClockWise_bBottomSurface_IsValid;

	private static FFieldAddress GetSurfacePointsClockWise_bBottomSurface_PropertyAddress;

	private static int GetSurfacePointsClockWise_bBottomSurface_Offset;

	private static bool GetSurfacePointsClockWise_ReturnValue_IsValid;

	private static FFieldAddress GetSurfacePointsClockWise_ReturnValue_PropertyAddress;

	private static int GetSurfacePointsClockWise_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesBoxComponent:GetSurfacePointsClockWise")]
	public unsafe List<FVector> GetSurfacePointsClockWise(bool bBottomSurface = true)
	{
		CheckDestroyed();
		if (!GetSurfacePointsClockWise_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesBoxComponent:GetSurfacePointsClockWise");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSurfacePointsClockWise_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSurfacePointsClockWise_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSurfacePointsClockWise_bBottomSurface_Offset), 0, GetSurfacePointsClockWise_bBottomSurface_PropertyAddress.Address, bBottomSurface);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSurfacePointsClockWise_FunctionAddress, intPtr, GetSurfacePointsClockWise_ParamsSize);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetSurfacePointsClockWise_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSurfacePointsClockWise_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSurfacePointsClockWise_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSEArteriesBoxComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEArteriesBoxComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEArteriesBoxComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GSEArteries.GSEArteriesBoxComponent");
		GetSurfacePointsClockWise_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSurfacePointsClockWise");
		GetSurfacePointsClockWise_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSurfacePointsClockWise_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSurfacePointsClockWise_bBottomSurface_PropertyAddress, GetSurfacePointsClockWise_FunctionAddress, "bBottomSurface");
		GetSurfacePointsClockWise_bBottomSurface_Offset = NativeReflectionCached.GetPropertyOffset(GetSurfacePointsClockWise_FunctionAddress, "bBottomSurface");
		GetSurfacePointsClockWise_bBottomSurface_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSurfacePointsClockWise_FunctionAddress, "bBottomSurface", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSurfacePointsClockWise_ReturnValue_PropertyAddress, GetSurfacePointsClockWise_FunctionAddress, "ReturnValue");
		GetSurfacePointsClockWise_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSurfacePointsClockWise_FunctionAddress, "ReturnValue");
		GetSurfacePointsClockWise_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSurfacePointsClockWise_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSurfacePointsClockWise_IsValid = GetSurfacePointsClockWise_FunctionAddress != IntPtr.Zero && GetSurfacePointsClockWise_bBottomSurface_IsValid && GetSurfacePointsClockWise_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesBoxComponent:GetSurfacePointsClockWise", GetSurfacePointsClockWise_IsValid);
	}
}
