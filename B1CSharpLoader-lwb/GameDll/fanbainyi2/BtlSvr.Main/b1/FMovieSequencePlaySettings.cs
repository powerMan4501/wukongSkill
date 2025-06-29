using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings")]
public struct FMovieSequencePlaySettings
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("镜头列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:Sequences")]
	public List<ULevelSequence> Sequences;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("镜头初始位置列表")]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:CameraTransforms")]
	public List<FTransform> CameraTransforms;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("摄像机标记")]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:CameraTags")]
	public List<string> CameraTags;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("滑轨标记")]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:RailTags")]
	public List<string> RailTags;

	[DisplayName("起重机标记")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:CraneTags")]
	public List<string> CraneTags;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("使用电影级摄像机")]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:bUseCinematicCamera")]
	public bool bUseCinematicCamera;

	[DisplayName("使用滑轨")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:bUseRail")]
	public bool bUseRail;

	[BlueprintReadWrite]
	[DisplayName("使用起重机")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:bUseCrane")]
	public bool bUseCrane;

	[BlueprintReadWrite]
	[DisplayName("开始时间")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:StartTimeSeconds")]
	public float StartTimeSeconds;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("Blend In时间")]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:InCameraBlendTime")]
	public float InCameraBlendTime;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("Blend In函数")]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:InCameraBlendFunction")]
	public EViewTargetBlendFunction InCameraBlendFunction;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Blend In加速系数")]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:InCameraBlendFactor")]
	public float InCameraBlendFactor;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否循环播放")]
	[USharpPath("/Script/b1-Managed.MovieSequencePlaySettings:bLoopPlay")]
	public bool bLoopPlay;

	private static int MovieSequencePlaySettings_StructSize;

	private static int MovieSequencePlaySettings_IsValid;

	private static bool Sequences_IsValid;

	private static int Sequences_Offset;

	private static FFieldAddress Sequences_PropertyAddress;

	private static bool CameraTransforms_IsValid;

	private static int CameraTransforms_Offset;

	private static FFieldAddress CameraTransforms_PropertyAddress;

	private static bool CameraTags_IsValid;

	private static int CameraTags_Offset;

	private static FFieldAddress CameraTags_PropertyAddress;

	private static bool RailTags_IsValid;

	private static int RailTags_Offset;

	private static FFieldAddress RailTags_PropertyAddress;

	private static bool CraneTags_IsValid;

	private static int CraneTags_Offset;

	private static FFieldAddress CraneTags_PropertyAddress;

	private static bool bUseCinematicCamera_IsValid;

	private static int bUseCinematicCamera_Offset;

	private static FFieldAddress bUseCinematicCamera_PropertyAddress;

	private static bool bUseRail_IsValid;

	private static int bUseRail_Offset;

	private static FFieldAddress bUseRail_PropertyAddress;

	private static bool bUseCrane_IsValid;

	private static int bUseCrane_Offset;

	private static FFieldAddress bUseCrane_PropertyAddress;

	private static bool StartTimeSeconds_IsValid;

	private static int StartTimeSeconds_Offset;

	private static bool InCameraBlendTime_IsValid;

	private static int InCameraBlendTime_Offset;

	private static bool InCameraBlendFunction_IsValid;

	private static int InCameraBlendFunction_Offset;

	private static FFieldAddress InCameraBlendFunction_PropertyAddress;

	private static bool InCameraBlendFactor_IsValid;

	private static int InCameraBlendFactor_Offset;

	private static bool bLoopPlay_IsValid;

	private static int bLoopPlay_Offset;

	private static FFieldAddress bLoopPlay_PropertyAddress;

	public FMovieSequencePlaySettings Copy()
	{
		FMovieSequencePlaySettings result = this;
		if (Sequences != null)
		{
			result.Sequences = new List<ULevelSequence>(Sequences);
		}
		if (CameraTransforms != null)
		{
			result.CameraTransforms = new List<FTransform>(CameraTransforms);
		}
		if (CameraTags != null)
		{
			result.CameraTags = new List<string>(CameraTags);
		}
		if (RailTags != null)
		{
			result.RailTags = new List<string>(RailTags);
		}
		if (CraneTags != null)
		{
			result.CraneTags = new List<string>(CraneTags);
		}
		return result;
	}

	public static FMovieSequencePlaySettings FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSequencePlaySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSequencePlaySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSequencePlaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSequencePlaySettings(IntPtr.Add(nativeBuffer, arrayIndex * MovieSequencePlaySettings_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSequencePlaySettings value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MovieSequencePlaySettings_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MovieSequencePlaySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieSequencePlaySettings");
			return;
		}
		new TArrayCopyMarshaler<ULevelSequence>(1, Sequences_PropertyAddress, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.FromNative, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Sequences_Offset), Sequences);
		new TArrayCopyMarshaler<FTransform>(1, CameraTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CameraTransforms_Offset), CameraTransforms);
		new TArrayCopyMarshaler<string>(1, CameraTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, CameraTags_Offset), CameraTags);
		new TArrayCopyMarshaler<string>(1, RailTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, RailTags_Offset), RailTags);
		new TArrayCopyMarshaler<string>(1, CraneTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, CraneTags_Offset), CraneTags);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address, bUseCinematicCamera);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address, bUseRail);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address, bUseCrane);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StartTimeSeconds_Offset), StartTimeSeconds);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendTime_Offset), InCameraBlendTime);
		EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendFunction_Offset), 0, InCameraBlendFunction_PropertyAddress.Address, InCameraBlendFunction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendFactor_Offset), InCameraBlendFactor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bLoopPlay_Offset), 0, bLoopPlay_PropertyAddress.Address, bLoopPlay);
	}

	public FMovieSequencePlaySettings(IntPtr nativeStruct)
	{
		if (MovieSequencePlaySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieSequencePlaySettings");
			Sequences = null;
			CameraTransforms = null;
			CameraTags = null;
			RailTags = null;
			CraneTags = null;
			bUseCinematicCamera = false;
			bUseRail = false;
			bUseCrane = false;
			StartTimeSeconds = 0f;
			InCameraBlendTime = 0f;
			InCameraBlendFunction = EViewTargetBlendFunction.VTBlend_Linear;
			InCameraBlendFactor = 0f;
			bLoopPlay = false;
		}
		else
		{
			Sequences = new TArrayCopyMarshaler<ULevelSequence>(1, Sequences_PropertyAddress, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.FromNative, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Sequences_Offset));
			CameraTransforms = new TArrayCopyMarshaler<FTransform>(1, CameraTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CameraTransforms_Offset));
			CameraTags = new TArrayCopyMarshaler<string>(1, CameraTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, CameraTags_Offset));
			RailTags = new TArrayCopyMarshaler<string>(1, RailTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, RailTags_Offset));
			CraneTags = new TArrayCopyMarshaler<string>(1, CraneTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, CraneTags_Offset));
			bUseCinematicCamera = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseCinematicCamera_Offset), 0, bUseCinematicCamera_PropertyAddress.Address);
			bUseRail = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address);
			bUseCrane = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address);
			StartTimeSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StartTimeSeconds_Offset));
			InCameraBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendTime_Offset));
			InCameraBlendFunction = EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendFunction_Offset), 0, InCameraBlendFunction_PropertyAddress.Address);
			InCameraBlendFactor = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendFactor_Offset));
			bLoopPlay = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bLoopPlay_Offset), 0, bLoopPlay_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MovieSequencePlaySettings");
		MovieSequencePlaySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Sequences_PropertyAddress, intPtr, "Sequences");
		Sequences_Offset = NativeReflection.GetPropertyOffset(intPtr, "Sequences");
		Sequences_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Sequences", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CameraTransforms_PropertyAddress, intPtr, "CameraTransforms");
		CameraTransforms_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraTransforms");
		CameraTransforms_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraTransforms", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CameraTags_PropertyAddress, intPtr, "CameraTags");
		CameraTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraTags");
		CameraTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraTags", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RailTags_PropertyAddress, intPtr, "RailTags");
		RailTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "RailTags");
		RailTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RailTags", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CraneTags_PropertyAddress, intPtr, "CraneTags");
		CraneTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "CraneTags");
		CraneTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CraneTags", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bUseCinematicCamera_PropertyAddress, intPtr, "bUseCinematicCamera");
		bUseCinematicCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCinematicCamera");
		bUseCinematicCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCinematicCamera", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseRail_PropertyAddress, intPtr, "bUseRail");
		bUseRail_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseRail");
		bUseRail_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseRail", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseCrane_PropertyAddress, intPtr, "bUseCrane");
		bUseCrane_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCrane");
		bUseCrane_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCrane", Classes.FBoolProperty);
		StartTimeSeconds_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartTimeSeconds");
		StartTimeSeconds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartTimeSeconds", Classes.FFloatProperty);
		InCameraBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendTime");
		InCameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref InCameraBlendFunction_PropertyAddress, intPtr, "InCameraBlendFunction");
		InCameraBlendFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendFunction");
		InCameraBlendFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendFunction", Classes.FEnumProperty);
		InCameraBlendFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendFactor");
		InCameraBlendFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendFactor", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bLoopPlay_PropertyAddress, intPtr, "bLoopPlay");
		bLoopPlay_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLoopPlay");
		bLoopPlay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLoopPlay", Classes.FBoolProperty);
		MovieSequencePlaySettings_IsValid = ((intPtr != IntPtr.Zero && Sequences_IsValid && CameraTransforms_IsValid && CameraTags_IsValid && RailTags_IsValid && CraneTags_IsValid && bUseCinematicCamera_IsValid && bUseRail_IsValid && bUseCrane_IsValid && StartTimeSeconds_IsValid && InCameraBlendTime_IsValid && InCameraBlendFunction_IsValid && InCameraBlendFactor_IsValid && bLoopPlay_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MovieSequencePlaySettings", (byte)MovieSequencePlaySettings_IsValid != 0);
	}

	static FMovieSequencePlaySettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMovieSequencePlaySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSequencePlaySettings));
	}
}
