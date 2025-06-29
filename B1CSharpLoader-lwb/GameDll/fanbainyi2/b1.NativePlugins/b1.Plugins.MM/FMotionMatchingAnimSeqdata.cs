using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.MotionMatchingAnimSeqdata", "MM", UnrealModuleType.GamePlugin)]
public struct FMotionMatchingAnimSeqdata
{
	private static bool AnimationInMemory_IsValid;

	private static int AnimationInMemory_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimSeqdata:AnimationInMemory")]
	public UAnimSequence AnimationInMemory;

	private static bool AnimationSoftPath_IsValid;

	private static int AnimationSoftPath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimSeqdata:AnimationSoftPath")]
	public FSoftObjectPath AnimationSoftPath;

	private static bool AnimationsAssetLoadStat_IsValid;

	private static FFieldAddress AnimationsAssetLoadStat_PropertyAddress;

	private static int AnimationsAssetLoadStat_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimSeqdata:AnimationsAssetLoadStat")]
	public EAnimSeqAssetLoadStatType AnimationsAssetLoadStat;

	private static bool FMotionMatchingAnimSeqdata_IsValid;

	private static int FMotionMatchingAnimSeqdata_StructSize;

	public FMotionMatchingAnimSeqdata Copy()
	{
		return this;
	}

	public static FMotionMatchingAnimSeqdata FromNative(IntPtr nativeBuffer)
	{
		return new FMotionMatchingAnimSeqdata(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMotionMatchingAnimSeqdata value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMotionMatchingAnimSeqdata FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMotionMatchingAnimSeqdata(nativeBuffer + arrayIndex * FMotionMatchingAnimSeqdata_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMotionMatchingAnimSeqdata value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMotionMatchingAnimSeqdata_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMotionMatchingAnimSeqdata_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchingAnimSeqdata");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimationInMemory_Offset), AnimationInMemory);
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, AnimationSoftPath_Offset), AnimationSoftPath);
		EnumMarshaler<EAnimSeqAssetLoadStatType>.ToNative(IntPtr.Add(nativeStruct, AnimationsAssetLoadStat_Offset), 0, AnimationsAssetLoadStat_PropertyAddress.Address, AnimationsAssetLoadStat);
	}

	public FMotionMatchingAnimSeqdata(IntPtr nativeStruct)
	{
		if (!FMotionMatchingAnimSeqdata_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchingAnimSeqdata");
			AnimationInMemory = null;
			AnimationSoftPath = default(FSoftObjectPath);
			AnimationsAssetLoadStat = EAnimSeqAssetLoadStatType.INVALID;
		}
		else
		{
			AnimationInMemory = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimationInMemory_Offset));
			AnimationSoftPath = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, AnimationSoftPath_Offset));
			AnimationsAssetLoadStat = EnumMarshaler<EAnimSeqAssetLoadStatType>.FromNative(IntPtr.Add(nativeStruct, AnimationsAssetLoadStat_Offset), 0, AnimationsAssetLoadStat_PropertyAddress.Address);
		}
	}

	static FMotionMatchingAnimSeqdata()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMotionMatchingAnimSeqdata)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMotionMatchingAnimSeqdata));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MotionMatchingAnimSeqdata");
		FMotionMatchingAnimSeqdata_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimationInMemory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationInMemory");
		AnimationInMemory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationInMemory", Classes.FObjectProperty);
		AnimationSoftPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationSoftPath");
		AnimationSoftPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationSoftPath", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationsAssetLoadStat_PropertyAddress, intPtr, "AnimationsAssetLoadStat");
		AnimationsAssetLoadStat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationsAssetLoadStat");
		AnimationsAssetLoadStat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationsAssetLoadStat", Classes.FEnumProperty);
		FMotionMatchingAnimSeqdata_IsValid = intPtr != IntPtr.Zero && AnimationInMemory_IsValid && AnimationSoftPath_IsValid && AnimationsAssetLoadStat_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.MotionMatchingAnimSeqdata", FMotionMatchingAnimSeqdata_IsValid);
	}
}
