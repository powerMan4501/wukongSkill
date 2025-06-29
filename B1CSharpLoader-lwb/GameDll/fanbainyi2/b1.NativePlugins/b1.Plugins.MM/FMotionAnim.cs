using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.MotionAnim", "MM", UnrealModuleType.GamePlugin)]
public struct FMotionAnim
{
	private static bool AnimationAnalyzer_IsValid;

	private static int AnimationAnalyzer_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionAnim:AnimationAnalyzer")]
	public UAnimationAnalyzer AnimationAnalyzer;

	private static bool AnimIndex_IsValid;

	private static int AnimIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionAnim:AnimIndex")]
	public int AnimIndex;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionAnim:Position")]
	public float Position;

	private static bool AllowedMotionTransitionTime_IsValid;

	private static int AllowedMotionTransitionTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionAnim:AllowedMotionTransitionTime")]
	public float AllowedMotionTransitionTime;

	private static bool Limit_IsValid;

	private static int Limit_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionAnim:Limit")]
	public float Limit;

	private static bool LimitOfOperation_IsValid;

	private static FFieldAddress LimitOfOperation_PropertyAddress;

	private static int LimitOfOperation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionAnim:LimitOfOperation")]
	public bool LimitOfOperation;

	private static bool FMotionAnim_IsValid;

	private static int FMotionAnim_StructSize;

	public FMotionAnim Copy()
	{
		return this;
	}

	public static FMotionAnim FromNative(IntPtr nativeBuffer)
	{
		return new FMotionAnim(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMotionAnim value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMotionAnim FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMotionAnim(nativeBuffer + arrayIndex * FMotionAnim_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMotionAnim value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMotionAnim_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMotionAnim_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionAnim");
			return;
		}
		UObjectMarshaler<UAnimationAnalyzer>.ToNative(IntPtr.Add(nativeStruct, AnimationAnalyzer_Offset), AnimationAnalyzer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AnimIndex_Offset), AnimIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AllowedMotionTransitionTime_Offset), AllowedMotionTransitionTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Limit_Offset), Limit);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LimitOfOperation_Offset), 0, LimitOfOperation_PropertyAddress.Address, LimitOfOperation);
	}

	public FMotionAnim(IntPtr nativeStruct)
	{
		if (!FMotionAnim_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionAnim");
			AnimationAnalyzer = null;
			AnimIndex = 0;
			Position = 0f;
			AllowedMotionTransitionTime = 0f;
			Limit = 0f;
			LimitOfOperation = false;
		}
		else
		{
			AnimationAnalyzer = UObjectMarshaler<UAnimationAnalyzer>.FromNative(IntPtr.Add(nativeStruct, AnimationAnalyzer_Offset));
			AnimIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AnimIndex_Offset));
			Position = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			AllowedMotionTransitionTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AllowedMotionTransitionTime_Offset));
			Limit = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Limit_Offset));
			LimitOfOperation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LimitOfOperation_Offset), 0, LimitOfOperation_PropertyAddress.Address);
		}
	}

	static FMotionAnim()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMotionAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMotionAnim));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MotionAnim");
		FMotionAnim_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimationAnalyzer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationAnalyzer");
		AnimationAnalyzer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationAnalyzer", Classes.FObjectProperty);
		AnimIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimIndex");
		AnimIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimIndex", Classes.FIntProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FFloatProperty);
		AllowedMotionTransitionTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AllowedMotionTransitionTime");
		AllowedMotionTransitionTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AllowedMotionTransitionTime", Classes.FFloatProperty);
		Limit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Limit");
		Limit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Limit", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LimitOfOperation_PropertyAddress, intPtr, "LimitOfOperation");
		LimitOfOperation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LimitOfOperation");
		LimitOfOperation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LimitOfOperation", Classes.FBoolProperty);
		FMotionAnim_IsValid = intPtr != IntPtr.Zero && AnimationAnalyzer_IsValid && AnimIndex_IsValid && Position_IsValid && AllowedMotionTransitionTime_IsValid && Limit_IsValid && LimitOfOperation_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.MotionAnim", FMotionAnim_IsValid);
	}
}
