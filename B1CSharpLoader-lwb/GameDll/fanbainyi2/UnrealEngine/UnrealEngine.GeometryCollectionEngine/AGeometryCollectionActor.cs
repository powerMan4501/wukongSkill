using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionActor", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public class AGeometryCollectionActor : AActor
{
	private static bool GeometryCollectionComponent_IsValid;

	private static int GeometryCollectionComponent_Offset;

	private static bool RaycastSingle_IsValid;

	private static IntPtr RaycastSingle_FunctionAddress;

	private static int RaycastSingle_ParamsSize;

	private static bool RaycastSingle_Start_IsValid;

	private static FFieldAddress RaycastSingle_Start_PropertyAddress;

	private static int RaycastSingle_Start_Offset;

	private static bool RaycastSingle_End_IsValid;

	private static FFieldAddress RaycastSingle_End_PropertyAddress;

	private static int RaycastSingle_End_Offset;

	private static bool RaycastSingle_OutHit_IsValid;

	private static FFieldAddress RaycastSingle_OutHit_PropertyAddress;

	private static int RaycastSingle_OutHit_Offset;

	private static bool RaycastSingle_ReturnValue_IsValid;

	private static FFieldAddress RaycastSingle_ReturnValue_PropertyAddress;

	private static int RaycastSingle_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionActor:GeometryCollectionComponent")]
	public UGeometryCollectionComponent GeometryCollectionComponent
	{
		get
		{
			CheckDestroyed();
			if (!GeometryCollectionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionActor:GeometryCollectionComponent");
				return null;
			}
			return UObjectMarshaler<UGeometryCollectionComponent>.FromNative(IntPtr.Add(base.Address, GeometryCollectionComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GeometryCollectionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionActor:GeometryCollectionComponent");
			}
			else
			{
				UObjectMarshaler<UGeometryCollectionComponent>.ToNative(IntPtr.Add(base.Address, GeometryCollectionComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionActor:RaycastSingle")]
	public unsafe bool RaycastSingle(FVector Start, FVector End, out FHitResult OutHit)
	{
		CheckDestroyed();
		if (!RaycastSingle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionActor:RaycastSingle");
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RaycastSingle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RaycastSingle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RaycastSingle_Start_Offset), 0, RaycastSingle_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RaycastSingle_End_Offset), 0, RaycastSingle_End_PropertyAddress.Address, End);
		NativeReflection.InitializeValue_InContainer(RaycastSingle_OutHit_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, RaycastSingle_FunctionAddress, intPtr, RaycastSingle_ParamsSize);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, RaycastSingle_OutHit_Offset), 0, RaycastSingle_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RaycastSingle_ReturnValue_Offset), 0, RaycastSingle_ReturnValue_PropertyAddress.Address);
	}

	static AGeometryCollectionActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGeometryCollectionActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGeometryCollectionActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryCollectionEngine.GeometryCollectionActor");
		GeometryCollectionComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GeometryCollectionComponent");
		GeometryCollectionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GeometryCollectionComponent", Classes.FObjectProperty);
		RaycastSingle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RaycastSingle");
		RaycastSingle_ParamsSize = NativeReflection.GetFunctionParamsSize(RaycastSingle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RaycastSingle_Start_PropertyAddress, RaycastSingle_FunctionAddress, "Start");
		RaycastSingle_Start_Offset = NativeReflectionCached.GetPropertyOffset(RaycastSingle_FunctionAddress, "Start");
		RaycastSingle_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(RaycastSingle_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RaycastSingle_End_PropertyAddress, RaycastSingle_FunctionAddress, "End");
		RaycastSingle_End_Offset = NativeReflectionCached.GetPropertyOffset(RaycastSingle_FunctionAddress, "End");
		RaycastSingle_End_IsValid = NativeReflectionCached.ValidatePropertyClass(RaycastSingle_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RaycastSingle_OutHit_PropertyAddress, RaycastSingle_FunctionAddress, "OutHit");
		RaycastSingle_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(RaycastSingle_FunctionAddress, "OutHit");
		RaycastSingle_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(RaycastSingle_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RaycastSingle_ReturnValue_PropertyAddress, RaycastSingle_FunctionAddress, "ReturnValue");
		RaycastSingle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RaycastSingle_FunctionAddress, "ReturnValue");
		RaycastSingle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RaycastSingle_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RaycastSingle_IsValid = RaycastSingle_FunctionAddress != IntPtr.Zero && RaycastSingle_Start_IsValid && RaycastSingle_End_IsValid && RaycastSingle_OutHit_IsValid && RaycastSingle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.GeometryCollectionActor:RaycastSingle", RaycastSingle_IsValid);
	}
}
