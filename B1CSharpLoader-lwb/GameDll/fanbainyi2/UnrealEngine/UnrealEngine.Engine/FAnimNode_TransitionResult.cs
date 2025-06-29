using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_TransitionResult", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_TransitionResult
{
	private static bool CanEnterTransition_IsValid;

	private static FFieldAddress CanEnterTransition_PropertyAddress;

	private static int CanEnterTransition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNode_TransitionResult:bCanEnterTransition")]
	public bool CanEnterTransition;

	private static bool FAnimNode_TransitionResult_IsValid;

	private static int FAnimNode_TransitionResult_StructSize;

	public FAnimNode_TransitionResult Copy()
	{
		return this;
	}

	public static FAnimNode_TransitionResult FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_TransitionResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_TransitionResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_TransitionResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_TransitionResult(nativeBuffer + arrayIndex * FAnimNode_TransitionResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_TransitionResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_TransitionResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_TransitionResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_TransitionResult");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanEnterTransition_Offset), 0, CanEnterTransition_PropertyAddress.Address, CanEnterTransition);
		}
	}

	public FAnimNode_TransitionResult(IntPtr nativeStruct)
	{
		if (!FAnimNode_TransitionResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_TransitionResult");
			CanEnterTransition = false;
		}
		else
		{
			CanEnterTransition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanEnterTransition_Offset), 0, CanEnterTransition_PropertyAddress.Address);
		}
	}

	static FAnimNode_TransitionResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_TransitionResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_TransitionResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_TransitionResult");
		FAnimNode_TransitionResult_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CanEnterTransition_PropertyAddress, intPtr, "bCanEnterTransition");
		CanEnterTransition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanEnterTransition");
		CanEnterTransition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanEnterTransition", Classes.FBoolProperty);
		FAnimNode_TransitionResult_IsValid = intPtr != IntPtr.Zero && CanEnterTransition_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_TransitionResult", FAnimNode_TransitionResult_IsValid);
	}
}
