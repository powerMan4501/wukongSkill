using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_ConvertLocalToComponentSpace", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_ConvertLocalToComponentSpace
{
	private static bool LocalPose_IsValid;

	private static int LocalPose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_ConvertLocalToComponentSpace:LocalPose")]
	public FPoseLink LocalPose;

	private static bool FAnimNode_ConvertLocalToComponentSpace_IsValid;

	private static int FAnimNode_ConvertLocalToComponentSpace_StructSize;

	public FAnimNode_ConvertLocalToComponentSpace Copy()
	{
		return this;
	}

	public static FAnimNode_ConvertLocalToComponentSpace FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_ConvertLocalToComponentSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_ConvertLocalToComponentSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_ConvertLocalToComponentSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_ConvertLocalToComponentSpace(nativeBuffer + arrayIndex * FAnimNode_ConvertLocalToComponentSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_ConvertLocalToComponentSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_ConvertLocalToComponentSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_ConvertLocalToComponentSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_ConvertLocalToComponentSpace");
		}
		else
		{
			FPoseLink.ToNative(IntPtr.Add(nativeStruct, LocalPose_Offset), LocalPose);
		}
	}

	public FAnimNode_ConvertLocalToComponentSpace(IntPtr nativeStruct)
	{
		if (!FAnimNode_ConvertLocalToComponentSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_ConvertLocalToComponentSpace");
			LocalPose = default(FPoseLink);
		}
		else
		{
			LocalPose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, LocalPose_Offset));
		}
	}

	static FAnimNode_ConvertLocalToComponentSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_ConvertLocalToComponentSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_ConvertLocalToComponentSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_ConvertLocalToComponentSpace");
		FAnimNode_ConvertLocalToComponentSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		LocalPose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalPose");
		LocalPose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalPose", Classes.FStructProperty);
		FAnimNode_ConvertLocalToComponentSpace_IsValid = intPtr != IntPtr.Zero && LocalPose_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_ConvertLocalToComponentSpace", FAnimNode_ConvertLocalToComponentSpace_IsValid);
	}
}
