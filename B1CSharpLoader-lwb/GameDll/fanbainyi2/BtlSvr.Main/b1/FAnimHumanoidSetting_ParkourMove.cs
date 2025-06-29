using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove")]
public struct FAnimHumanoidSetting_ParkourMove
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:bEnableParkourAnim")]
	public bool bEnableParkourAnim;

	[EditAnywhere]
	[UProperty]
	[DisplayName("左脚在前跨上动画0.5m")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpLeftFootLow")]
	public UAnimSequence ASStrideUpLeftFootLow;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("右脚在前跨上动画0.5m")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpRightFootLow")]
	public UAnimSequence ASStrideUpRightFootLow;

	[UProperty]
	[EditAnywhere]
	[DisplayName("左脚在前跨上动画1.0m")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpLeftFootHigh")]
	public UAnimSequence ASStrideUpLeftFootHigh;

	[DisplayName("右脚在前跨上动画1.0m")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpRightFootHigh")]
	public UAnimSequence ASStrideUpRightFootHigh;

	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("左脚在前跨上掉落循环动画")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpLeftFootFall")]
	public UAnimSequence ASStrideUpLeftFootFall;

	[DisplayName("右脚在前跨上掉落循环动画")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpRightFootFall")]
	public UAnimSequence ASStrideUpRightFootFall;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[DisplayName("左脚在前跨上落地动画")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpLeftFootEnd")]
	public UAnimSequence ASStrideUpLeftFootEnd;

	[EditAnywhere]
	[UProperty]
	[DisplayName("右脚脚在前跨上落地动画")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpRightFootEnd")]
	public UAnimSequence ASStrideUpRightFootEnd;

	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("左脚在前跨上落地移动动画")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpLeftFootLandMove")]
	public UAnimSequence ASStrideUpLeftFootLandMove;

	[DisplayName("右脚在前跨上落地移动动画")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideUpRightFootLandMove")]
	public UAnimSequence ASStrideUpRightFootLandMove;

	[DisplayName("左脚在前跨下动画")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideDownLeftFoot")]
	public UAnimSequence ASStrideDownLeftFoot;

	[EditAnywhere]
	[UProperty]
	[DisplayName("右脚在前跨下动画")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideDownRightFoot")]
	public UAnimSequence ASStrideDownRightFoot;

	[DisplayName("左脚在前跨下掉落循环动画")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideDownLeftFootFall")]
	public UAnimSequence ASStrideDownLeftFootFall;

	[UProperty]
	[DisplayName("右脚在前跨下掉落循环动画")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideDownRightFootFall")]
	public UAnimSequence ASStrideDownRightFootFall;

	[DisplayName("左脚在前跨下落地动画")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideDownLeftFootEnd")]
	public UAnimSequence ASStrideDownLeftFootEnd;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[DisplayName("右脚在前跨下落地动画")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideDownRightFootEnd")]
	public UAnimSequence ASStrideDownRightFootEnd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("左脚在前跨下落地移动动画")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideDownLeftFootLandMove")]
	public UAnimSequence ASStrideDownLeftFootLandMove;

	[DisplayName("右脚在前跨下落地移动动画")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove:ASStrideDownRightFootLandMove")]
	public UAnimSequence ASStrideDownRightFootLandMove;

	private static int AnimHumanoidSetting_ParkourMove_StructSize;

	private static int AnimHumanoidSetting_ParkourMove_IsValid;

	private static bool bEnableParkourAnim_IsValid;

	private static int bEnableParkourAnim_Offset;

	private static FFieldAddress bEnableParkourAnim_PropertyAddress;

	private static bool ASStrideUpLeftFootLow_IsValid;

	private static int ASStrideUpLeftFootLow_Offset;

	private static bool ASStrideUpRightFootLow_IsValid;

	private static int ASStrideUpRightFootLow_Offset;

	private static bool ASStrideUpLeftFootHigh_IsValid;

	private static int ASStrideUpLeftFootHigh_Offset;

	private static bool ASStrideUpRightFootHigh_IsValid;

	private static int ASStrideUpRightFootHigh_Offset;

	private static bool ASStrideUpLeftFootFall_IsValid;

	private static int ASStrideUpLeftFootFall_Offset;

	private static bool ASStrideUpRightFootFall_IsValid;

	private static int ASStrideUpRightFootFall_Offset;

	private static bool ASStrideUpLeftFootEnd_IsValid;

	private static int ASStrideUpLeftFootEnd_Offset;

	private static bool ASStrideUpRightFootEnd_IsValid;

	private static int ASStrideUpRightFootEnd_Offset;

	private static bool ASStrideUpLeftFootLandMove_IsValid;

	private static int ASStrideUpLeftFootLandMove_Offset;

	private static bool ASStrideUpRightFootLandMove_IsValid;

	private static int ASStrideUpRightFootLandMove_Offset;

	private static bool ASStrideDownLeftFoot_IsValid;

	private static int ASStrideDownLeftFoot_Offset;

	private static bool ASStrideDownRightFoot_IsValid;

	private static int ASStrideDownRightFoot_Offset;

	private static bool ASStrideDownLeftFootFall_IsValid;

	private static int ASStrideDownLeftFootFall_Offset;

	private static bool ASStrideDownRightFootFall_IsValid;

	private static int ASStrideDownRightFootFall_Offset;

	private static bool ASStrideDownLeftFootEnd_IsValid;

	private static int ASStrideDownLeftFootEnd_Offset;

	private static bool ASStrideDownRightFootEnd_IsValid;

	private static int ASStrideDownRightFootEnd_Offset;

	private static bool ASStrideDownLeftFootLandMove_IsValid;

	private static int ASStrideDownLeftFootLandMove_Offset;

	private static bool ASStrideDownRightFootLandMove_IsValid;

	private static int ASStrideDownRightFootLandMove_Offset;

	public FAnimHumanoidSetting_ParkourMove Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_ParkourMove FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_ParkourMove(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_ParkourMove value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_ParkourMove FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_ParkourMove(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_ParkourMove value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_ParkourMove_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableParkourAnim_Offset), 0, bEnableParkourAnim_PropertyAddress.Address, bEnableParkourAnim);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootLow_Offset), ASStrideUpLeftFootLow);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootLow_Offset), ASStrideUpRightFootLow);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootHigh_Offset), ASStrideUpLeftFootHigh);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootHigh_Offset), ASStrideUpRightFootHigh);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootFall_Offset), ASStrideUpLeftFootFall);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootFall_Offset), ASStrideUpRightFootFall);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootEnd_Offset), ASStrideUpLeftFootEnd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootEnd_Offset), ASStrideUpRightFootEnd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootLandMove_Offset), ASStrideUpLeftFootLandMove);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootLandMove_Offset), ASStrideUpRightFootLandMove);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideDownLeftFoot_Offset), ASStrideDownLeftFoot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideDownRightFoot_Offset), ASStrideDownRightFoot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideDownLeftFootFall_Offset), ASStrideDownLeftFootFall);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideDownRightFootFall_Offset), ASStrideDownRightFootFall);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideDownLeftFootEnd_Offset), ASStrideDownLeftFootEnd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideDownRightFootEnd_Offset), ASStrideDownRightFootEnd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideDownLeftFootLandMove_Offset), ASStrideDownLeftFootLandMove);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStrideDownRightFootLandMove_Offset), ASStrideDownRightFootLandMove);
	}

	public FAnimHumanoidSetting_ParkourMove(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_ParkourMove_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove");
			bEnableParkourAnim = false;
			ASStrideUpLeftFootLow = null;
			ASStrideUpRightFootLow = null;
			ASStrideUpLeftFootHigh = null;
			ASStrideUpRightFootHigh = null;
			ASStrideUpLeftFootFall = null;
			ASStrideUpRightFootFall = null;
			ASStrideUpLeftFootEnd = null;
			ASStrideUpRightFootEnd = null;
			ASStrideUpLeftFootLandMove = null;
			ASStrideUpRightFootLandMove = null;
			ASStrideDownLeftFoot = null;
			ASStrideDownRightFoot = null;
			ASStrideDownLeftFootFall = null;
			ASStrideDownRightFootFall = null;
			ASStrideDownLeftFootEnd = null;
			ASStrideDownRightFootEnd = null;
			ASStrideDownLeftFootLandMove = null;
			ASStrideDownRightFootLandMove = null;
		}
		else
		{
			bEnableParkourAnim = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableParkourAnim_Offset), 0, bEnableParkourAnim_PropertyAddress.Address);
			ASStrideUpLeftFootLow = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootLow_Offset));
			ASStrideUpRightFootLow = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootLow_Offset));
			ASStrideUpLeftFootHigh = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootHigh_Offset));
			ASStrideUpRightFootHigh = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootHigh_Offset));
			ASStrideUpLeftFootFall = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootFall_Offset));
			ASStrideUpRightFootFall = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootFall_Offset));
			ASStrideUpLeftFootEnd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootEnd_Offset));
			ASStrideUpRightFootEnd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootEnd_Offset));
			ASStrideUpLeftFootLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpLeftFootLandMove_Offset));
			ASStrideUpRightFootLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideUpRightFootLandMove_Offset));
			ASStrideDownLeftFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideDownLeftFoot_Offset));
			ASStrideDownRightFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideDownRightFoot_Offset));
			ASStrideDownLeftFootFall = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideDownLeftFootFall_Offset));
			ASStrideDownRightFootFall = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideDownRightFootFall_Offset));
			ASStrideDownLeftFootEnd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideDownLeftFootEnd_Offset));
			ASStrideDownRightFootEnd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideDownRightFootEnd_Offset));
			ASStrideDownLeftFootLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideDownLeftFootLandMove_Offset));
			ASStrideDownRightFootLandMove = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStrideDownRightFootLandMove_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove");
		AnimHumanoidSetting_ParkourMove_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bEnableParkourAnim_PropertyAddress, intPtr, "bEnableParkourAnim");
		bEnableParkourAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableParkourAnim");
		bEnableParkourAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableParkourAnim", Classes.FBoolProperty);
		ASStrideUpLeftFootLow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootLow");
		ASStrideUpLeftFootLow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootLow", Classes.FObjectProperty);
		ASStrideUpRightFootLow_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootLow");
		ASStrideUpRightFootLow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootLow", Classes.FObjectProperty);
		ASStrideUpLeftFootHigh_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootHigh");
		ASStrideUpLeftFootHigh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootHigh", Classes.FObjectProperty);
		ASStrideUpRightFootHigh_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootHigh");
		ASStrideUpRightFootHigh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootHigh", Classes.FObjectProperty);
		ASStrideUpLeftFootFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootFall");
		ASStrideUpLeftFootFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootFall", Classes.FObjectProperty);
		ASStrideUpRightFootFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootFall");
		ASStrideUpRightFootFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootFall", Classes.FObjectProperty);
		ASStrideUpLeftFootEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootEnd");
		ASStrideUpLeftFootEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootEnd", Classes.FObjectProperty);
		ASStrideUpRightFootEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootEnd");
		ASStrideUpRightFootEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootEnd", Classes.FObjectProperty);
		ASStrideUpLeftFootLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpLeftFootLandMove");
		ASStrideUpLeftFootLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpLeftFootLandMove", Classes.FObjectProperty);
		ASStrideUpRightFootLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideUpRightFootLandMove");
		ASStrideUpRightFootLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideUpRightFootLandMove", Classes.FObjectProperty);
		ASStrideDownLeftFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownLeftFoot");
		ASStrideDownLeftFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownLeftFoot", Classes.FObjectProperty);
		ASStrideDownRightFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownRightFoot");
		ASStrideDownRightFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownRightFoot", Classes.FObjectProperty);
		ASStrideDownLeftFootFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownLeftFootFall");
		ASStrideDownLeftFootFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownLeftFootFall", Classes.FObjectProperty);
		ASStrideDownRightFootFall_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownRightFootFall");
		ASStrideDownRightFootFall_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownRightFootFall", Classes.FObjectProperty);
		ASStrideDownLeftFootEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownLeftFootEnd");
		ASStrideDownLeftFootEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownLeftFootEnd", Classes.FObjectProperty);
		ASStrideDownRightFootEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownRightFootEnd");
		ASStrideDownRightFootEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownRightFootEnd", Classes.FObjectProperty);
		ASStrideDownLeftFootLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownLeftFootLandMove");
		ASStrideDownLeftFootLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownLeftFootLandMove", Classes.FObjectProperty);
		ASStrideDownRightFootLandMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStrideDownRightFootLandMove");
		ASStrideDownRightFootLandMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStrideDownRightFootLandMove", Classes.FObjectProperty);
		AnimHumanoidSetting_ParkourMove_IsValid = ((intPtr != IntPtr.Zero && bEnableParkourAnim_IsValid && ASStrideUpLeftFootLow_IsValid && ASStrideUpRightFootLow_IsValid && ASStrideUpLeftFootHigh_IsValid && ASStrideUpRightFootHigh_IsValid && ASStrideUpLeftFootFall_IsValid && ASStrideUpRightFootFall_IsValid && ASStrideUpLeftFootEnd_IsValid && ASStrideUpRightFootEnd_IsValid && ASStrideUpLeftFootLandMove_IsValid && ASStrideUpRightFootLandMove_IsValid && ASStrideDownLeftFoot_IsValid && ASStrideDownRightFoot_IsValid && ASStrideDownLeftFootFall_IsValid && ASStrideDownRightFootFall_IsValid && ASStrideDownLeftFootEnd_IsValid && ASStrideDownRightFootEnd_IsValid && ASStrideDownLeftFootLandMove_IsValid && ASStrideDownRightFootLandMove_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_ParkourMove", (byte)AnimHumanoidSetting_ParkourMove_IsValid != 0);
	}

	static FAnimHumanoidSetting_ParkourMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_ParkourMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_ParkourMove));
	}
}
