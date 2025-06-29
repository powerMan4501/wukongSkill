using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_BodyBlend")]
public struct FAnimHumanoidSetting_BodyBlend
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_BodyBlend:BSUpperBodyBlendAdditive")]
	public UBlendSpace BSUpperBodyBlendAdditive;

	private static int AnimHumanoidSetting_BodyBlend_StructSize;

	private static int AnimHumanoidSetting_BodyBlend_IsValid;

	private static bool BSUpperBodyBlendAdditive_IsValid;

	private static int BSUpperBodyBlendAdditive_Offset;

	public FAnimHumanoidSetting_BodyBlend Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_BodyBlend FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_BodyBlend(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_BodyBlend value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_BodyBlend FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_BodyBlend(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_BodyBlend_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_BodyBlend value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_BodyBlend_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_BodyBlend_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_BodyBlend");
		}
		else
		{
			UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSUpperBodyBlendAdditive_Offset), BSUpperBodyBlendAdditive);
		}
	}

	public FAnimHumanoidSetting_BodyBlend(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_BodyBlend_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_BodyBlend");
			BSUpperBodyBlendAdditive = null;
		}
		else
		{
			BSUpperBodyBlendAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSUpperBodyBlendAdditive_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_BodyBlend");
		AnimHumanoidSetting_BodyBlend_StructSize = NativeReflection.GetStructSize(intPtr);
		BSUpperBodyBlendAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSUpperBodyBlendAdditive");
		BSUpperBodyBlendAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSUpperBodyBlendAdditive", Classes.FObjectProperty);
		AnimHumanoidSetting_BodyBlend_IsValid = ((intPtr != IntPtr.Zero && BSUpperBodyBlendAdditive_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_BodyBlend", (byte)AnimHumanoidSetting_BodyBlend_IsValid != 0);
	}

	static FAnimHumanoidSetting_BodyBlend()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_BodyBlend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_BodyBlend));
	}
}
