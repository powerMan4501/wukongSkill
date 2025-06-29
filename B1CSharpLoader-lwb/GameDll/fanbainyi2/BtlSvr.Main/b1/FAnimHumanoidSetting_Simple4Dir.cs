using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir")]
public struct FAnimHumanoidSetting_Simple4Dir
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSStart")]
	public UBlendSpace BSStart;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSEnd")]
	public UBlendSpace BSEnd;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:CardinalDirectionBlendTime")]
	public float CardinalDirectionBlendTime;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSWalkFwd")]
	public UBlendSpace BSWalkFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSWalkBwd")]
	public UBlendSpace BSWalkBwd;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSWalkLeft")]
	public UBlendSpace BSWalkLeft;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSWalkRight")]
	public UBlendSpace BSWalkRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSRunFwd")]
	public UBlendSpace BSRunFwd;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSRunBwd")]
	public UBlendSpace BSRunBwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSRunLeft")]
	public UBlendSpace BSRunLeft;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSRunRight")]
	public UBlendSpace BSRunRight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir:BSSprint")]
	public UBlendSpace BSSprint;

	private static int AnimHumanoidSetting_Simple4Dir_StructSize;

	private static int AnimHumanoidSetting_Simple4Dir_IsValid;

	private static bool BSStart_IsValid;

	private static int BSStart_Offset;

	private static bool BSEnd_IsValid;

	private static int BSEnd_Offset;

	private static bool CardinalDirectionBlendTime_IsValid;

	private static int CardinalDirectionBlendTime_Offset;

	private static bool BSWalkFwd_IsValid;

	private static int BSWalkFwd_Offset;

	private static bool BSWalkBwd_IsValid;

	private static int BSWalkBwd_Offset;

	private static bool BSWalkLeft_IsValid;

	private static int BSWalkLeft_Offset;

	private static bool BSWalkRight_IsValid;

	private static int BSWalkRight_Offset;

	private static bool BSRunFwd_IsValid;

	private static int BSRunFwd_Offset;

	private static bool BSRunBwd_IsValid;

	private static int BSRunBwd_Offset;

	private static bool BSRunLeft_IsValid;

	private static int BSRunLeft_Offset;

	private static bool BSRunRight_IsValid;

	private static int BSRunRight_Offset;

	private static bool BSSprint_IsValid;

	private static int BSSprint_Offset;

	public FAnimHumanoidSetting_Simple4Dir Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_Simple4Dir FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_Simple4Dir(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_Simple4Dir value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_Simple4Dir FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_Simple4Dir(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Simple4Dir_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_Simple4Dir value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Simple4Dir_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Simple4Dir_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir");
			return;
		}
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSStart_Offset), BSStart);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSEnd_Offset), BSEnd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CardinalDirectionBlendTime_Offset), CardinalDirectionBlendTime);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkFwd_Offset), BSWalkFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkBwd_Offset), BSWalkBwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkLeft_Offset), BSWalkLeft);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkRight_Offset), BSWalkRight);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunFwd_Offset), BSRunFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunBwd_Offset), BSRunBwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunLeft_Offset), BSRunLeft);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunRight_Offset), BSRunRight);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSSprint_Offset), BSSprint);
	}

	public FAnimHumanoidSetting_Simple4Dir(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Simple4Dir_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir");
			BSStart = null;
			BSEnd = null;
			CardinalDirectionBlendTime = 0f;
			BSWalkFwd = null;
			BSWalkBwd = null;
			BSWalkLeft = null;
			BSWalkRight = null;
			BSRunFwd = null;
			BSRunBwd = null;
			BSRunLeft = null;
			BSRunRight = null;
			BSSprint = null;
		}
		else
		{
			BSStart = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSStart_Offset));
			BSEnd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSEnd_Offset));
			CardinalDirectionBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CardinalDirectionBlendTime_Offset));
			BSWalkFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkFwd_Offset));
			BSWalkBwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkBwd_Offset));
			BSWalkLeft = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkLeft_Offset));
			BSWalkRight = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkRight_Offset));
			BSRunFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunFwd_Offset));
			BSRunBwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunBwd_Offset));
			BSRunLeft = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunLeft_Offset));
			BSRunRight = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunRight_Offset));
			BSSprint = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSSprint_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir");
		AnimHumanoidSetting_Simple4Dir_StructSize = NativeReflection.GetStructSize(intPtr);
		BSStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSStart");
		BSStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSStart", Classes.FObjectProperty);
		BSEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSEnd");
		BSEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSEnd", Classes.FObjectProperty);
		CardinalDirectionBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "CardinalDirectionBlendTime");
		CardinalDirectionBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CardinalDirectionBlendTime", Classes.FFloatProperty);
		BSWalkFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkFwd");
		BSWalkFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkFwd", Classes.FObjectProperty);
		BSWalkBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkBwd");
		BSWalkBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkBwd", Classes.FObjectProperty);
		BSWalkLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkLeft");
		BSWalkLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkLeft", Classes.FObjectProperty);
		BSWalkRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkRight");
		BSWalkRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkRight", Classes.FObjectProperty);
		BSRunFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunFwd");
		BSRunFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunFwd", Classes.FObjectProperty);
		BSRunBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunBwd");
		BSRunBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunBwd", Classes.FObjectProperty);
		BSRunLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLeft");
		BSRunLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLeft", Classes.FObjectProperty);
		BSRunRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunRight");
		BSRunRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunRight", Classes.FObjectProperty);
		BSSprint_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSSprint");
		BSSprint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSSprint", Classes.FObjectProperty);
		AnimHumanoidSetting_Simple4Dir_IsValid = ((intPtr != IntPtr.Zero && BSStart_IsValid && BSEnd_IsValid && CardinalDirectionBlendTime_IsValid && BSWalkFwd_IsValid && BSWalkBwd_IsValid && BSWalkLeft_IsValid && BSWalkRight_IsValid && BSRunFwd_IsValid && BSRunBwd_IsValid && BSRunLeft_IsValid && BSRunRight_IsValid && BSSprint_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_Simple4Dir", (byte)AnimHumanoidSetting_Simple4Dir_IsValid != 0);
	}

	static FAnimHumanoidSetting_Simple4Dir()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Simple4Dir)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Simple4Dir));
	}
}
