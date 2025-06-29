using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ProceduralMeshComponent;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshTangent", "ProceduralMeshComponent", UnrealModuleType.EnginePlugin)]
public struct FProcMeshTangent
{
	private static bool TangentX_IsValid;

	private static int TangentX_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshTangent:TangentX")]
	public FVector TangentX;

	private static bool FlipTangentY_IsValid;

	private static FFieldAddress FlipTangentY_PropertyAddress;

	private static int FlipTangentY_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ProceduralMeshComponent.ProcMeshTangent:bFlipTangentY")]
	public bool FlipTangentY;

	private static bool FProcMeshTangent_IsValid;

	private static int FProcMeshTangent_StructSize;

	public FProcMeshTangent Copy()
	{
		return this;
	}

	public static FProcMeshTangent FromNative(IntPtr nativeBuffer)
	{
		return new FProcMeshTangent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FProcMeshTangent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FProcMeshTangent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FProcMeshTangent(nativeBuffer + arrayIndex * FProcMeshTangent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FProcMeshTangent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FProcMeshTangent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FProcMeshTangent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ProceduralMeshComponent.ProcMeshTangent");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, TangentX_Offset), TangentX);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlipTangentY_Offset), 0, FlipTangentY_PropertyAddress.Address, FlipTangentY);
	}

	public FProcMeshTangent(IntPtr nativeStruct)
	{
		if (!FProcMeshTangent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ProceduralMeshComponent.ProcMeshTangent");
			TangentX = default(FVector);
			FlipTangentY = false;
		}
		else
		{
			TangentX = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, TangentX_Offset));
			FlipTangentY = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlipTangentY_Offset), 0, FlipTangentY_PropertyAddress.Address);
		}
	}

	static FProcMeshTangent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FProcMeshTangent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProcMeshTangent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ProceduralMeshComponent.ProcMeshTangent");
		FProcMeshTangent_StructSize = NativeReflection.GetStructSize(intPtr);
		TangentX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TangentX");
		TangentX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TangentX", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipTangentY_PropertyAddress, intPtr, "bFlipTangentY");
		FlipTangentY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlipTangentY");
		FlipTangentY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlipTangentY", Classes.FBoolProperty);
		FProcMeshTangent_IsValid = intPtr != IntPtr.Zero && TangentX_IsValid && FlipTangentY_IsValid;
		NativeReflection.LogStructIsValid("/Script/ProceduralMeshComponent.ProcMeshTangent", FProcMeshTangent_IsValid);
	}
}
