using System;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.LevelSequenceConfig")]
public struct FLevelSequenceConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LevelSequenceConfig:Sequence")]
	public TSoftObject<ULevelSequence> Sequence;

	[DisplayName("初始镜头位置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LevelSequenceConfig:CameraStartTransform")]
	public FTransform CameraStartTransform;

	[DisplayName("摄像机标记")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LevelSequenceConfig:CameraTag")]
	public FName CameraTag;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("滑轨标记")]
	[USharpPath("/Script/b1-Managed.LevelSequenceConfig:RailTag")]
	public FName RailTag;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("起重机标记")]
	[USharpPath("/Script/b1-Managed.LevelSequenceConfig:CraneTag")]
	public FName CraneTag;

	private static int LevelSequenceConfig_StructSize;

	private static int LevelSequenceConfig_IsValid;

	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	private static bool CameraStartTransform_IsValid;

	private static int CameraStartTransform_Offset;

	private static bool CameraTag_IsValid;

	private static int CameraTag_Offset;

	private static bool RailTag_IsValid;

	private static int RailTag_Offset;

	private static bool CraneTag_IsValid;

	private static int CraneTag_Offset;

	public FLevelSequenceConfig Copy()
	{
		return this;
	}

	public static FLevelSequenceConfig FromNative(IntPtr nativeBuffer)
	{
		return new FLevelSequenceConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLevelSequenceConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLevelSequenceConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLevelSequenceConfig(IntPtr.Add(nativeBuffer, arrayIndex * LevelSequenceConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLevelSequenceConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LevelSequenceConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LevelSequenceConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelSequenceConfig");
			return;
		}
		TSoftObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(nativeStruct, Sequence_Offset), Sequence);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, CameraStartTransform_Offset), CameraStartTransform);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CameraTag_Offset), CameraTag);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, RailTag_Offset), RailTag);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CraneTag_Offset), CraneTag);
	}

	public FLevelSequenceConfig(IntPtr nativeStruct)
	{
		if (LevelSequenceConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelSequenceConfig");
			Sequence = default(TSoftObject<ULevelSequence>);
			CameraStartTransform = default(FTransform);
			CameraTag = default(FName);
			RailTag = default(FName);
			CraneTag = default(FName);
		}
		else
		{
			Sequence = TSoftObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(nativeStruct, Sequence_Offset));
			CameraStartTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, CameraStartTransform_Offset));
			CameraTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CameraTag_Offset));
			RailTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, RailTag_Offset));
			CraneTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CraneTag_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LevelSequenceConfig");
		LevelSequenceConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Sequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Sequence", Classes.FSoftObjectProperty);
		CameraStartTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraStartTransform");
		CameraStartTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraStartTransform", Classes.FStructProperty);
		CameraTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraTag");
		CameraTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraTag", Classes.FNameProperty);
		RailTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "RailTag");
		RailTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RailTag", Classes.FNameProperty);
		CraneTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CraneTag");
		CraneTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CraneTag", Classes.FNameProperty);
		LevelSequenceConfig_IsValid = ((intPtr != IntPtr.Zero && Sequence_IsValid && CameraStartTransform_IsValid && CameraTag_IsValid && RailTag_IsValid && CraneTag_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LevelSequenceConfig", (byte)LevelSequenceConfig_IsValid != 0);
	}

	static FLevelSequenceConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FLevelSequenceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevelSequenceConfig));
	}
}
