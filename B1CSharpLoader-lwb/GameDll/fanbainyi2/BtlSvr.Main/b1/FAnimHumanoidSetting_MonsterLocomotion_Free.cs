using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free")]
public struct FAnimHumanoidSetting_MonsterLocomotion_Free
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:ASFreeRunFwd")]
	public UAnimSequence ASFreeRunFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:ASFreeRunStartFwd")]
	public UAnimSequence ASFreeRunStartFwd;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:ASFreeRunStartFR")]
	public UAnimSequence ASFreeRunStartFR;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:ASFreeRunStartBR")]
	public UAnimSequence ASFreeRunStartBR;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:ASFreeRunStartFL")]
	public UAnimSequence ASFreeRunStartFL;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:ASFreeRunStartBL")]
	public UAnimSequence ASFreeRunStartBL;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:BSFreeLeanAdditive")]
	public UBlendSpace BSFreeLeanAdditive;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:BSFreeRotAdditive")]
	public UBlendSpace BSFreeRotAdditive;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:ASFreeRunStopLeftFoot")]
	public UAnimSequence ASFreeRunStopLeftFoot;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free:ASFreeRunStopRightFoot")]
	public UAnimSequence ASFreeRunStopRightFoot;

	private static int AnimHumanoidSetting_MonsterLocomotion_Free_StructSize;

	private static int AnimHumanoidSetting_MonsterLocomotion_Free_IsValid;

	private static bool ASFreeRunFwd_IsValid;

	private static int ASFreeRunFwd_Offset;

	private static bool ASFreeRunStartFwd_IsValid;

	private static int ASFreeRunStartFwd_Offset;

	private static bool ASFreeRunStartFR_IsValid;

	private static int ASFreeRunStartFR_Offset;

	private static bool ASFreeRunStartBR_IsValid;

	private static int ASFreeRunStartBR_Offset;

	private static bool ASFreeRunStartFL_IsValid;

	private static int ASFreeRunStartFL_Offset;

	private static bool ASFreeRunStartBL_IsValid;

	private static int ASFreeRunStartBL_Offset;

	private static bool BSFreeLeanAdditive_IsValid;

	private static int BSFreeLeanAdditive_Offset;

	private static bool BSFreeRotAdditive_IsValid;

	private static int BSFreeRotAdditive_Offset;

	private static bool ASFreeRunStopLeftFoot_IsValid;

	private static int ASFreeRunStopLeftFoot_Offset;

	private static bool ASFreeRunStopRightFoot_IsValid;

	private static int ASFreeRunStopRightFoot_Offset;

	public FAnimHumanoidSetting_MonsterLocomotion_Free Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_MonsterLocomotion_Free FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_MonsterLocomotion_Free(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_MonsterLocomotion_Free value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_MonsterLocomotion_Free FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_MonsterLocomotion_Free(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MonsterLocomotion_Free_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_MonsterLocomotion_Free value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MonsterLocomotion_Free_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MonsterLocomotion_Free_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunFwd_Offset), ASFreeRunFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunStartFwd_Offset), ASFreeRunStartFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunStartFR_Offset), ASFreeRunStartFR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunStartBR_Offset), ASFreeRunStartBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunStartFL_Offset), ASFreeRunStartFL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunStartBL_Offset), ASFreeRunStartBL);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSFreeLeanAdditive_Offset), BSFreeLeanAdditive);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSFreeRotAdditive_Offset), BSFreeRotAdditive);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunStopLeftFoot_Offset), ASFreeRunStopLeftFoot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFreeRunStopRightFoot_Offset), ASFreeRunStopRightFoot);
	}

	public FAnimHumanoidSetting_MonsterLocomotion_Free(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MonsterLocomotion_Free_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free");
			ASFreeRunFwd = null;
			ASFreeRunStartFwd = null;
			ASFreeRunStartFR = null;
			ASFreeRunStartBR = null;
			ASFreeRunStartFL = null;
			ASFreeRunStartBL = null;
			BSFreeLeanAdditive = null;
			BSFreeRotAdditive = null;
			ASFreeRunStopLeftFoot = null;
			ASFreeRunStopRightFoot = null;
		}
		else
		{
			ASFreeRunFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunFwd_Offset));
			ASFreeRunStartFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunStartFwd_Offset));
			ASFreeRunStartFR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunStartFR_Offset));
			ASFreeRunStartBR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunStartBR_Offset));
			ASFreeRunStartFL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunStartFL_Offset));
			ASFreeRunStartBL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunStartBL_Offset));
			BSFreeLeanAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSFreeLeanAdditive_Offset));
			BSFreeRotAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSFreeRotAdditive_Offset));
			ASFreeRunStopLeftFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunStopLeftFoot_Offset));
			ASFreeRunStopRightFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFreeRunStopRightFoot_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free");
		AnimHumanoidSetting_MonsterLocomotion_Free_StructSize = NativeReflection.GetStructSize(intPtr);
		ASFreeRunFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunFwd");
		ASFreeRunFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunFwd", Classes.FObjectProperty);
		ASFreeRunStartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStartFwd");
		ASFreeRunStartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStartFwd", Classes.FObjectProperty);
		ASFreeRunStartFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStartFR");
		ASFreeRunStartFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStartFR", Classes.FObjectProperty);
		ASFreeRunStartBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStartBR");
		ASFreeRunStartBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStartBR", Classes.FObjectProperty);
		ASFreeRunStartFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStartFL");
		ASFreeRunStartFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStartFL", Classes.FObjectProperty);
		ASFreeRunStartBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStartBL");
		ASFreeRunStartBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStartBL", Classes.FObjectProperty);
		BSFreeLeanAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSFreeLeanAdditive");
		BSFreeLeanAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSFreeLeanAdditive", Classes.FObjectProperty);
		BSFreeRotAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSFreeRotAdditive");
		BSFreeRotAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSFreeRotAdditive", Classes.FObjectProperty);
		ASFreeRunStopLeftFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStopLeftFoot");
		ASFreeRunStopLeftFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStopLeftFoot", Classes.FObjectProperty);
		ASFreeRunStopRightFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFreeRunStopRightFoot");
		ASFreeRunStopRightFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFreeRunStopRightFoot", Classes.FObjectProperty);
		AnimHumanoidSetting_MonsterLocomotion_Free_IsValid = ((intPtr != IntPtr.Zero && ASFreeRunFwd_IsValid && ASFreeRunStartFwd_IsValid && ASFreeRunStartFR_IsValid && ASFreeRunStartBR_IsValid && ASFreeRunStartFL_IsValid && ASFreeRunStartBL_IsValid && BSFreeLeanAdditive_IsValid && BSFreeRotAdditive_IsValid && ASFreeRunStopLeftFoot_IsValid && ASFreeRunStopRightFoot_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Free", (byte)AnimHumanoidSetting_MonsterLocomotion_Free_IsValid != 0);
	}

	static FAnimHumanoidSetting_MonsterLocomotion_Free()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_MonsterLocomotion_Free)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_MonsterLocomotion_Free));
	}
}
