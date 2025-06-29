using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_ConvertComponentToLocalSpace", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_ConvertComponentToLocalSpace
{
	private static bool ComponentPose_IsValid;

	private static int ComponentPose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_ConvertComponentToLocalSpace:ComponentPose")]
	public FComponentSpacePoseLink ComponentPose;

	private static bool FAnimNode_ConvertComponentToLocalSpace_IsValid;

	private static int FAnimNode_ConvertComponentToLocalSpace_StructSize;

	public FAnimNode_ConvertComponentToLocalSpace Copy()
	{
		return this;
	}

	public static FAnimNode_ConvertComponentToLocalSpace FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_ConvertComponentToLocalSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_ConvertComponentToLocalSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_ConvertComponentToLocalSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_ConvertComponentToLocalSpace(nativeBuffer + arrayIndex * FAnimNode_ConvertComponentToLocalSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_ConvertComponentToLocalSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_ConvertComponentToLocalSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_ConvertComponentToLocalSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_ConvertComponentToLocalSpace");
		}
		else
		{
			FComponentSpacePoseLink.ToNative(IntPtr.Add(nativeStruct, ComponentPose_Offset), ComponentPose);
		}
	}

	public FAnimNode_ConvertComponentToLocalSpace(IntPtr nativeStruct)
	{
		if (!FAnimNode_ConvertComponentToLocalSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_ConvertComponentToLocalSpace");
			ComponentPose = default(FComponentSpacePoseLink);
		}
		else
		{
			ComponentPose = FComponentSpacePoseLink.FromNative(IntPtr.Add(nativeStruct, ComponentPose_Offset));
		}
	}

	static FAnimNode_ConvertComponentToLocalSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_ConvertComponentToLocalSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_ConvertComponentToLocalSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_ConvertComponentToLocalSpace");
		FAnimNode_ConvertComponentToLocalSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		ComponentPose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentPose");
		ComponentPose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentPose", Classes.FStructProperty);
		FAnimNode_ConvertComponentToLocalSpace_IsValid = intPtr != IntPtr.Zero && ComponentPose_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_ConvertComponentToLocalSpace", FAnimNode_ConvertComponentToLocalSpace_IsValid);
	}
}
