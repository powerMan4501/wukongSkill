using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioMixer;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaSoundComponent", "MediaAssets", UnrealModuleType.Engine)]
public class UMediaSoundComponent : USynthComponent
{
	private static bool SetSpectralAnalysisSettings_IsValid;

	private static IntPtr SetSpectralAnalysisSettings_FunctionAddress;

	private static int SetSpectralAnalysisSettings_ParamsSize;

	private static bool SetSpectralAnalysisSettings_InFrequenciesToAnalyze_IsValid;

	private static FFieldAddress SetSpectralAnalysisSettings_InFrequenciesToAnalyze_PropertyAddress;

	private static int SetSpectralAnalysisSettings_InFrequenciesToAnalyze_Offset;

	private static bool SetSpectralAnalysisSettings_InFFTSize_IsValid;

	private static FFieldAddress SetSpectralAnalysisSettings_InFFTSize_PropertyAddress;

	private static int SetSpectralAnalysisSettings_InFFTSize_Offset;

	private static bool SetMediaPlayer_IsValid;

	private static IntPtr SetMediaPlayer_FunctionAddress;

	private static int SetMediaPlayer_ParamsSize;

	private static bool SetMediaPlayer_NewMediaPlayer_IsValid;

	private static FFieldAddress SetMediaPlayer_NewMediaPlayer_PropertyAddress;

	private static int SetMediaPlayer_NewMediaPlayer_Offset;

	private static bool SetEnvelopeFollowingsettings_IsValid;

	private static IntPtr SetEnvelopeFollowingsettings_FunctionAddress;

	private static int SetEnvelopeFollowingsettings_ParamsSize;

	private static bool SetEnvelopeFollowingsettings_AttackTimeMsec_IsValid;

	private static FFieldAddress SetEnvelopeFollowingsettings_AttackTimeMsec_PropertyAddress;

	private static int SetEnvelopeFollowingsettings_AttackTimeMsec_Offset;

	private static bool SetEnvelopeFollowingsettings_ReleaseTimeMsec_IsValid;

	private static FFieldAddress SetEnvelopeFollowingsettings_ReleaseTimeMsec_PropertyAddress;

	private static int SetEnvelopeFollowingsettings_ReleaseTimeMsec_Offset;

	private static bool SetEnableSpectralAnalysis_IsValid;

	private static IntPtr SetEnableSpectralAnalysis_FunctionAddress;

	private static int SetEnableSpectralAnalysis_ParamsSize;

	private static bool SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_IsValid;

	private static FFieldAddress SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_PropertyAddress;

	private static int SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_Offset;

	private static bool SetEnableEnvelopeFollowing_IsValid;

	private static IntPtr SetEnableEnvelopeFollowing_FunctionAddress;

	private static int SetEnableEnvelopeFollowing_ParamsSize;

	private static bool SetEnableEnvelopeFollowing_bInEnvelopeFollowing_IsValid;

	private static FFieldAddress SetEnableEnvelopeFollowing_bInEnvelopeFollowing_PropertyAddress;

	private static int SetEnableEnvelopeFollowing_bInEnvelopeFollowing_Offset;

	private static bool GetSpectralData_IsValid;

	private static IntPtr GetSpectralData_FunctionAddress;

	private static int GetSpectralData_ParamsSize;

	private static bool GetSpectralData_ReturnValue_IsValid;

	private static FFieldAddress GetSpectralData_ReturnValue_PropertyAddress;

	private static int GetSpectralData_ReturnValue_Offset;

	private static bool GetNormalizedSpectralData_IsValid;

	private static IntPtr GetNormalizedSpectralData_FunctionAddress;

	private static int GetNormalizedSpectralData_ParamsSize;

	private static bool GetNormalizedSpectralData_ReturnValue_IsValid;

	private static FFieldAddress GetNormalizedSpectralData_ReturnValue_PropertyAddress;

	private static int GetNormalizedSpectralData_ReturnValue_Offset;

	private static bool GetMediaPlayer_IsValid;

	private static IntPtr GetMediaPlayer_FunctionAddress;

	private static int GetMediaPlayer_ParamsSize;

	private static bool GetMediaPlayer_ReturnValue_IsValid;

	private static FFieldAddress GetMediaPlayer_ReturnValue_PropertyAddress;

	private static int GetMediaPlayer_ReturnValue_Offset;

	private static bool GetEnvelopeValue_IsValid;

	private static IntPtr GetEnvelopeValue_FunctionAddress;

	private static int GetEnvelopeValue_ParamsSize;

	private static bool GetEnvelopeValue_ReturnValue_IsValid;

	private static FFieldAddress GetEnvelopeValue_ReturnValue_PropertyAddress;

	private static int GetEnvelopeValue_ReturnValue_Offset;

	private static bool GetAttenuationSettingsToApply_IsValid;

	private static IntPtr GetAttenuationSettingsToApply_FunctionAddress;

	private static int GetAttenuationSettingsToApply_ParamsSize;

	private static bool GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid;

	private static FFieldAddress GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress;

	private static int GetAttenuationSettingsToApply_OutAttenuationSettings_Offset;

	private static bool GetAttenuationSettingsToApply_ReturnValue_IsValid;

	private static FFieldAddress GetAttenuationSettingsToApply_ReturnValue_PropertyAddress;

	private static int GetAttenuationSettingsToApply_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:SetSpectralAnalysisSettings")]
	public unsafe void SetSpectralAnalysisSettings(List<float> InFrequenciesToAnalyze, EMediaSoundComponentFFTSize InFFTSize = EMediaSoundComponentFFTSize.Medium_512)
	{
		CheckDestroyed();
		if (!SetSpectralAnalysisSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:SetSpectralAnalysisSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpectralAnalysisSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpectralAnalysisSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<float>(1, SetSpectralAnalysisSettings_InFrequenciesToAnalyze_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSpectralAnalysisSettings_InFrequenciesToAnalyze_Offset), InFrequenciesToAnalyze);
		EnumMarshaler<EMediaSoundComponentFFTSize>.ToNative(IntPtr.Add(intPtr, SetSpectralAnalysisSettings_InFFTSize_Offset), 0, SetSpectralAnalysisSettings_InFFTSize_PropertyAddress.Address, InFFTSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpectralAnalysisSettings_FunctionAddress, intPtr, SetSpectralAnalysisSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSpectralAnalysisSettings_InFrequenciesToAnalyze_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:SetMediaPlayer")]
	public unsafe void SetMediaPlayer(UMediaPlayer NewMediaPlayer)
	{
		CheckDestroyed();
		if (!SetMediaPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:SetMediaPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMediaPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMediaPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(intPtr, SetMediaPlayer_NewMediaPlayer_Offset), 0, SetMediaPlayer_NewMediaPlayer_PropertyAddress.Address, NewMediaPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMediaPlayer_FunctionAddress, intPtr, SetMediaPlayer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:SetEnvelopeFollowingsettings")]
	public unsafe void SetEnvelopeFollowingsettings(int AttackTimeMsec, int ReleaseTimeMsec)
	{
		CheckDestroyed();
		if (!SetEnvelopeFollowingsettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:SetEnvelopeFollowingsettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnvelopeFollowingsettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnvelopeFollowingsettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetEnvelopeFollowingsettings_AttackTimeMsec_Offset), 0, SetEnvelopeFollowingsettings_AttackTimeMsec_PropertyAddress.Address, AttackTimeMsec);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetEnvelopeFollowingsettings_ReleaseTimeMsec_Offset), 0, SetEnvelopeFollowingsettings_ReleaseTimeMsec_PropertyAddress.Address, ReleaseTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnvelopeFollowingsettings_FunctionAddress, intPtr, SetEnvelopeFollowingsettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:SetEnableSpectralAnalysis")]
	public unsafe void SetEnableSpectralAnalysis(bool bInSpectralAnalysisEnabled)
	{
		CheckDestroyed();
		if (!SetEnableSpectralAnalysis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:SetEnableSpectralAnalysis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableSpectralAnalysis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableSpectralAnalysis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_Offset), 0, SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_PropertyAddress.Address, bInSpectralAnalysisEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableSpectralAnalysis_FunctionAddress, intPtr, SetEnableSpectralAnalysis_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:SetEnableEnvelopeFollowing")]
	public unsafe void SetEnableEnvelopeFollowing(bool bInEnvelopeFollowing)
	{
		CheckDestroyed();
		if (!SetEnableEnvelopeFollowing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:SetEnableEnvelopeFollowing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableEnvelopeFollowing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableEnvelopeFollowing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableEnvelopeFollowing_bInEnvelopeFollowing_Offset), 0, SetEnableEnvelopeFollowing_bInEnvelopeFollowing_PropertyAddress.Address, bInEnvelopeFollowing);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableEnvelopeFollowing_FunctionAddress, intPtr, SetEnableEnvelopeFollowing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:GetSpectralData")]
	public unsafe List<FMediaSoundComponentSpectralData> GetSpectralData()
	{
		CheckDestroyed();
		if (!GetSpectralData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:GetSpectralData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpectralData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpectralData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpectralData_FunctionAddress, intPtr, GetSpectralData_ParamsSize);
		List<FMediaSoundComponentSpectralData> result = new TArrayCopyMarshaler<FMediaSoundComponentSpectralData>(1, GetSpectralData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FMediaSoundComponentSpectralData, FMediaSoundComponentSpectralData>.FromNative, CachedMarshalingDelegates<FMediaSoundComponentSpectralData, FMediaSoundComponentSpectralData>.ToNative).FromNative(IntPtr.Add(intPtr, GetSpectralData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSpectralData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:GetNormalizedSpectralData")]
	public unsafe List<FMediaSoundComponentSpectralData> GetNormalizedSpectralData()
	{
		CheckDestroyed();
		if (!GetNormalizedSpectralData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:GetNormalizedSpectralData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNormalizedSpectralData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNormalizedSpectralData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNormalizedSpectralData_FunctionAddress, intPtr, GetNormalizedSpectralData_ParamsSize);
		List<FMediaSoundComponentSpectralData> result = new TArrayCopyMarshaler<FMediaSoundComponentSpectralData>(1, GetNormalizedSpectralData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FMediaSoundComponentSpectralData, FMediaSoundComponentSpectralData>.FromNative, CachedMarshalingDelegates<FMediaSoundComponentSpectralData, FMediaSoundComponentSpectralData>.ToNative).FromNative(IntPtr.Add(intPtr, GetNormalizedSpectralData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNormalizedSpectralData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:GetMediaPlayer")]
	public unsafe UMediaPlayer GetMediaPlayer()
	{
		CheckDestroyed();
		if (!GetMediaPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:GetMediaPlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMediaPlayer_FunctionAddress, intPtr, GetMediaPlayer_ParamsSize);
		return UObjectMarshaler<UMediaPlayer>.FromNative(IntPtr.Add(intPtr, GetMediaPlayer_ReturnValue_Offset), 0, GetMediaPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:GetEnvelopeValue")]
	public unsafe float GetEnvelopeValue()
	{
		CheckDestroyed();
		if (!GetEnvelopeValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:GetEnvelopeValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEnvelopeValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEnvelopeValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEnvelopeValue_FunctionAddress, intPtr, GetEnvelopeValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEnvelopeValue_ReturnValue_Offset), 0, GetEnvelopeValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u, OriginalName = "BP_GetAttenuationSettingsToApply")]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponent:BP_GetAttenuationSettingsToApply")]
	public unsafe bool GetAttenuationSettingsToApply(out FSoundAttenuationSettings OutAttenuationSettings)
	{
		CheckDestroyed();
		if (!GetAttenuationSettingsToApply_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSoundComponent:BP_GetAttenuationSettingsToApply");
			OutAttenuationSettings = default(FSoundAttenuationSettings);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttenuationSettingsToApply_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttenuationSettingsToApply_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttenuationSettingsToApply_FunctionAddress, intPtr, GetAttenuationSettingsToApply_ParamsSize);
		OutAttenuationSettings = FSoundAttenuationSettings.FromNative(IntPtr.Add(intPtr, GetAttenuationSettingsToApply_OutAttenuationSettings_Offset), 0, GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAttenuationSettingsToApply_ReturnValue_Offset), 0, GetAttenuationSettingsToApply_ReturnValue_PropertyAddress.Address);
	}

	static UMediaSoundComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaSoundComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaSoundComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MediaAssets.MediaSoundComponent");
		SetSpectralAnalysisSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSpectralAnalysisSettings");
		SetSpectralAnalysisSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpectralAnalysisSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpectralAnalysisSettings_InFrequenciesToAnalyze_PropertyAddress, SetSpectralAnalysisSettings_FunctionAddress, "InFrequenciesToAnalyze");
		SetSpectralAnalysisSettings_InFrequenciesToAnalyze_Offset = NativeReflectionCached.GetPropertyOffset(SetSpectralAnalysisSettings_FunctionAddress, "InFrequenciesToAnalyze");
		SetSpectralAnalysisSettings_InFrequenciesToAnalyze_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpectralAnalysisSettings_FunctionAddress, "InFrequenciesToAnalyze", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSpectralAnalysisSettings_InFFTSize_PropertyAddress, SetSpectralAnalysisSettings_FunctionAddress, "InFFTSize");
		SetSpectralAnalysisSettings_InFFTSize_Offset = NativeReflectionCached.GetPropertyOffset(SetSpectralAnalysisSettings_FunctionAddress, "InFFTSize");
		SetSpectralAnalysisSettings_InFFTSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpectralAnalysisSettings_FunctionAddress, "InFFTSize", Classes.FEnumProperty);
		SetSpectralAnalysisSettings_IsValid = SetSpectralAnalysisSettings_FunctionAddress != IntPtr.Zero && SetSpectralAnalysisSettings_InFrequenciesToAnalyze_IsValid && SetSpectralAnalysisSettings_InFFTSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:SetSpectralAnalysisSettings", SetSpectralAnalysisSettings_IsValid);
		SetMediaPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMediaPlayer");
		SetMediaPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMediaPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMediaPlayer_NewMediaPlayer_PropertyAddress, SetMediaPlayer_FunctionAddress, "NewMediaPlayer");
		SetMediaPlayer_NewMediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaPlayer_FunctionAddress, "NewMediaPlayer");
		SetMediaPlayer_NewMediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaPlayer_FunctionAddress, "NewMediaPlayer", Classes.FObjectProperty);
		SetMediaPlayer_IsValid = SetMediaPlayer_FunctionAddress != IntPtr.Zero && SetMediaPlayer_NewMediaPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:SetMediaPlayer", SetMediaPlayer_IsValid);
		SetEnvelopeFollowingsettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEnvelopeFollowingsettings");
		SetEnvelopeFollowingsettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnvelopeFollowingsettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnvelopeFollowingsettings_AttackTimeMsec_PropertyAddress, SetEnvelopeFollowingsettings_FunctionAddress, "AttackTimeMsec");
		SetEnvelopeFollowingsettings_AttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetEnvelopeFollowingsettings_FunctionAddress, "AttackTimeMsec");
		SetEnvelopeFollowingsettings_AttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnvelopeFollowingsettings_FunctionAddress, "AttackTimeMsec", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnvelopeFollowingsettings_ReleaseTimeMsec_PropertyAddress, SetEnvelopeFollowingsettings_FunctionAddress, "ReleaseTimeMsec");
		SetEnvelopeFollowingsettings_ReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetEnvelopeFollowingsettings_FunctionAddress, "ReleaseTimeMsec");
		SetEnvelopeFollowingsettings_ReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnvelopeFollowingsettings_FunctionAddress, "ReleaseTimeMsec", Classes.FIntProperty);
		SetEnvelopeFollowingsettings_IsValid = SetEnvelopeFollowingsettings_FunctionAddress != IntPtr.Zero && SetEnvelopeFollowingsettings_AttackTimeMsec_IsValid && SetEnvelopeFollowingsettings_ReleaseTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:SetEnvelopeFollowingsettings", SetEnvelopeFollowingsettings_IsValid);
		SetEnableSpectralAnalysis_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEnableSpectralAnalysis");
		SetEnableSpectralAnalysis_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableSpectralAnalysis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_PropertyAddress, SetEnableSpectralAnalysis_FunctionAddress, "bInSpectralAnalysisEnabled");
		SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableSpectralAnalysis_FunctionAddress, "bInSpectralAnalysisEnabled");
		SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableSpectralAnalysis_FunctionAddress, "bInSpectralAnalysisEnabled", Classes.FBoolProperty);
		SetEnableSpectralAnalysis_IsValid = SetEnableSpectralAnalysis_FunctionAddress != IntPtr.Zero && SetEnableSpectralAnalysis_bInSpectralAnalysisEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:SetEnableSpectralAnalysis", SetEnableSpectralAnalysis_IsValid);
		SetEnableEnvelopeFollowing_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEnableEnvelopeFollowing");
		SetEnableEnvelopeFollowing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableEnvelopeFollowing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableEnvelopeFollowing_bInEnvelopeFollowing_PropertyAddress, SetEnableEnvelopeFollowing_FunctionAddress, "bInEnvelopeFollowing");
		SetEnableEnvelopeFollowing_bInEnvelopeFollowing_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableEnvelopeFollowing_FunctionAddress, "bInEnvelopeFollowing");
		SetEnableEnvelopeFollowing_bInEnvelopeFollowing_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableEnvelopeFollowing_FunctionAddress, "bInEnvelopeFollowing", Classes.FBoolProperty);
		SetEnableEnvelopeFollowing_IsValid = SetEnableEnvelopeFollowing_FunctionAddress != IntPtr.Zero && SetEnableEnvelopeFollowing_bInEnvelopeFollowing_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:SetEnableEnvelopeFollowing", SetEnableEnvelopeFollowing_IsValid);
		GetSpectralData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSpectralData");
		GetSpectralData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpectralData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpectralData_ReturnValue_PropertyAddress, GetSpectralData_FunctionAddress, "ReturnValue");
		GetSpectralData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpectralData_FunctionAddress, "ReturnValue");
		GetSpectralData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpectralData_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSpectralData_IsValid = GetSpectralData_FunctionAddress != IntPtr.Zero && GetSpectralData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:GetSpectralData", GetSpectralData_IsValid);
		GetNormalizedSpectralData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNormalizedSpectralData");
		GetNormalizedSpectralData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNormalizedSpectralData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedSpectralData_ReturnValue_PropertyAddress, GetNormalizedSpectralData_FunctionAddress, "ReturnValue");
		GetNormalizedSpectralData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedSpectralData_FunctionAddress, "ReturnValue");
		GetNormalizedSpectralData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedSpectralData_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNormalizedSpectralData_IsValid = GetNormalizedSpectralData_FunctionAddress != IntPtr.Zero && GetNormalizedSpectralData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:GetNormalizedSpectralData", GetNormalizedSpectralData_IsValid);
		GetMediaPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMediaPlayer");
		GetMediaPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayer_ReturnValue_PropertyAddress, GetMediaPlayer_FunctionAddress, "ReturnValue");
		GetMediaPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayer_FunctionAddress, "ReturnValue");
		GetMediaPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMediaPlayer_IsValid = GetMediaPlayer_FunctionAddress != IntPtr.Zero && GetMediaPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:GetMediaPlayer", GetMediaPlayer_IsValid);
		GetEnvelopeValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEnvelopeValue");
		GetEnvelopeValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEnvelopeValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEnvelopeValue_ReturnValue_PropertyAddress, GetEnvelopeValue_FunctionAddress, "ReturnValue");
		GetEnvelopeValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEnvelopeValue_FunctionAddress, "ReturnValue");
		GetEnvelopeValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnvelopeValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEnvelopeValue_IsValid = GetEnvelopeValue_FunctionAddress != IntPtr.Zero && GetEnvelopeValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:GetEnvelopeValue", GetEnvelopeValue_IsValid);
		GetAttenuationSettingsToApply_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BP_GetAttenuationSettingsToApply");
		GetAttenuationSettingsToApply_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttenuationSettingsToApply_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress, GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings");
		GetAttenuationSettingsToApply_OutAttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings");
		GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationSettingsToApply_ReturnValue_PropertyAddress, GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue");
		GetAttenuationSettingsToApply_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue");
		GetAttenuationSettingsToApply_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAttenuationSettingsToApply_IsValid = GetAttenuationSettingsToApply_FunctionAddress != IntPtr.Zero && GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid && GetAttenuationSettingsToApply_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSoundComponent:BP_GetAttenuationSettingsToApply", GetAttenuationSettingsToApply_IsValid);
	}
}
