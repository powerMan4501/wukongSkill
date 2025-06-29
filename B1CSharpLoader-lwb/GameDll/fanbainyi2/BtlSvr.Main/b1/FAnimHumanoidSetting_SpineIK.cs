using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK")]
public struct FAnimHumanoidSetting_SpineIK
{
	[UProperty]
	[DisplayName("开启脊椎坡面IK")]
	[UMeta(MDProp.DisplayAfter, "开启后务必打开Glide Anim")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:bEnableSpineIK")]
	public bool bEnableSpineIK;

	[BlueprintReadOnly]
	[DisplayName("开启坡面IK Debug 信息")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:bEnableSpineIKDebug")]
	public bool bEnableSpineIKDebug;

	[UProperty]
	[BlueprintReadOnly]
	[UMeta(MDProp.ClampMin, "5")]
	[EditAnywhere]
	[DisplayName("坡面IK向上检测距离")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:SpineIKTraceUpDistance")]
	public float SpineIKTraceUpDistance;

	[UProperty]
	[DisplayName("坡面IK向下检测距离")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UMeta(MDProp.ClampMin, "15")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:SpineIKTraceDownDistance")]
	public float SpineIKTraceDownDistance;

	[DisplayName("Pitch变化范围")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:OffsetPitch")]
	public float OffsetPitch;

	[BlueprintReadOnly]
	[DisplayName("Roll变化范围")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:OffsetRoll")]
	public float OffsetRoll;

	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("插值速度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:LerpSpeed")]
	public float LerpSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("关闭后处理四肢IK")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:DisableLimbIKAlpha")]
	public bool DisableLimbIKAlpha;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("忽略检测高度")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:IgnoreDistance")]
	public float IgnoreDistance;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("四足精细IK配置")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpineIK:LimbIKDataList")]
	public List<LimbIKData> LimbIKDataList;

	private static int AnimHumanoidSetting_SpineIK_StructSize;

	private static int AnimHumanoidSetting_SpineIK_IsValid;

	private static bool bEnableSpineIK_IsValid;

	private static int bEnableSpineIK_Offset;

	private static FFieldAddress bEnableSpineIK_PropertyAddress;

	private static bool bEnableSpineIKDebug_IsValid;

	private static int bEnableSpineIKDebug_Offset;

	private static FFieldAddress bEnableSpineIKDebug_PropertyAddress;

	private static bool SpineIKTraceUpDistance_IsValid;

	private static int SpineIKTraceUpDistance_Offset;

	private static bool SpineIKTraceDownDistance_IsValid;

	private static int SpineIKTraceDownDistance_Offset;

	private static bool OffsetPitch_IsValid;

	private static int OffsetPitch_Offset;

	private static bool OffsetRoll_IsValid;

	private static int OffsetRoll_Offset;

	private static bool LerpSpeed_IsValid;

	private static int LerpSpeed_Offset;

	private static bool DisableLimbIKAlpha_IsValid;

	private static int DisableLimbIKAlpha_Offset;

	private static FFieldAddress DisableLimbIKAlpha_PropertyAddress;

	private static bool IgnoreDistance_IsValid;

	private static int IgnoreDistance_Offset;

	private static bool LimbIKDataList_IsValid;

	private static int LimbIKDataList_Offset;

	private static FFieldAddress LimbIKDataList_PropertyAddress;

	public FAnimHumanoidSetting_SpineIK Copy()
	{
		FAnimHumanoidSetting_SpineIK result = this;
		if (LimbIKDataList != null)
		{
			result.LimbIKDataList = new List<LimbIKData>(LimbIKDataList);
		}
		return result;
	}

	public static FAnimHumanoidSetting_SpineIK FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_SpineIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_SpineIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_SpineIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_SpineIK(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_SpineIK_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_SpineIK value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_SpineIK_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_SpineIK_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_SpineIK");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableSpineIK_Offset), 0, bEnableSpineIK_PropertyAddress.Address, bEnableSpineIK);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableSpineIKDebug_Offset), 0, bEnableSpineIKDebug_PropertyAddress.Address, bEnableSpineIKDebug);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpineIKTraceUpDistance_Offset), SpineIKTraceUpDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpineIKTraceDownDistance_Offset), SpineIKTraceDownDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OffsetPitch_Offset), OffsetPitch);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OffsetRoll_Offset), OffsetRoll);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LerpSpeed_Offset), LerpSpeed);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableLimbIKAlpha_Offset), 0, DisableLimbIKAlpha_PropertyAddress.Address, DisableLimbIKAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IgnoreDistance_Offset), IgnoreDistance);
		new TArrayCopyMarshaler<LimbIKData>(1, LimbIKDataList_PropertyAddress, CachedMarshalingDelegates<LimbIKData, LimbIKData>.FromNative, CachedMarshalingDelegates<LimbIKData, LimbIKData>.ToNative).ToNative(IntPtr.Add(nativeStruct, LimbIKDataList_Offset), LimbIKDataList);
	}

	public FAnimHumanoidSetting_SpineIK(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_SpineIK_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_SpineIK");
			bEnableSpineIK = false;
			bEnableSpineIKDebug = false;
			SpineIKTraceUpDistance = 0f;
			SpineIKTraceDownDistance = 0f;
			OffsetPitch = 0f;
			OffsetRoll = 0f;
			LerpSpeed = 0f;
			DisableLimbIKAlpha = false;
			IgnoreDistance = 0f;
			LimbIKDataList = null;
		}
		else
		{
			bEnableSpineIK = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableSpineIK_Offset), 0, bEnableSpineIK_PropertyAddress.Address);
			bEnableSpineIKDebug = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableSpineIKDebug_Offset), 0, bEnableSpineIKDebug_PropertyAddress.Address);
			SpineIKTraceUpDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpineIKTraceUpDistance_Offset));
			SpineIKTraceDownDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpineIKTraceDownDistance_Offset));
			OffsetPitch = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OffsetPitch_Offset));
			OffsetRoll = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OffsetRoll_Offset));
			LerpSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LerpSpeed_Offset));
			DisableLimbIKAlpha = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableLimbIKAlpha_Offset), 0, DisableLimbIKAlpha_PropertyAddress.Address);
			IgnoreDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IgnoreDistance_Offset));
			LimbIKDataList = new TArrayCopyMarshaler<LimbIKData>(1, LimbIKDataList_PropertyAddress, CachedMarshalingDelegates<LimbIKData, LimbIKData>.FromNative, CachedMarshalingDelegates<LimbIKData, LimbIKData>.ToNative).FromNative(IntPtr.Add(nativeStruct, LimbIKDataList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_SpineIK");
		AnimHumanoidSetting_SpineIK_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bEnableSpineIK_PropertyAddress, intPtr, "bEnableSpineIK");
		bEnableSpineIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableSpineIK");
		bEnableSpineIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableSpineIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableSpineIKDebug_PropertyAddress, intPtr, "bEnableSpineIKDebug");
		bEnableSpineIKDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableSpineIKDebug");
		bEnableSpineIKDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableSpineIKDebug", Classes.FBoolProperty);
		SpineIKTraceUpDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpineIKTraceUpDistance");
		SpineIKTraceUpDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpineIKTraceUpDistance", Classes.FFloatProperty);
		SpineIKTraceDownDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpineIKTraceDownDistance");
		SpineIKTraceDownDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpineIKTraceDownDistance", Classes.FFloatProperty);
		OffsetPitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetPitch");
		OffsetPitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetPitch", Classes.FFloatProperty);
		OffsetRoll_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetRoll");
		OffsetRoll_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetRoll", Classes.FFloatProperty);
		LerpSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "LerpSpeed");
		LerpSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LerpSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DisableLimbIKAlpha_PropertyAddress, intPtr, "DisableLimbIKAlpha");
		DisableLimbIKAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisableLimbIKAlpha");
		DisableLimbIKAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisableLimbIKAlpha", Classes.FBoolProperty);
		IgnoreDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnoreDistance");
		IgnoreDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnoreDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref LimbIKDataList_PropertyAddress, intPtr, "LimbIKDataList");
		LimbIKDataList_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimbIKDataList");
		LimbIKDataList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimbIKDataList", Classes.FArrayProperty);
		AnimHumanoidSetting_SpineIK_IsValid = ((intPtr != IntPtr.Zero && bEnableSpineIK_IsValid && bEnableSpineIKDebug_IsValid && SpineIKTraceUpDistance_IsValid && SpineIKTraceDownDistance_IsValid && OffsetPitch_IsValid && OffsetRoll_IsValid && LerpSpeed_IsValid && DisableLimbIKAlpha_IsValid && IgnoreDistance_IsValid && LimbIKDataList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_SpineIK", (byte)AnimHumanoidSetting_SpineIK_IsValid != 0);
	}

	static FAnimHumanoidSetting_SpineIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_SpineIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_SpineIK));
	}
}
