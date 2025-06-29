using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BUS_UtilComm", "b1", UnrealModuleType.Game)]
public class UBUS_UtilComm : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetCurActiveMontagePos_IsValid;

	private static IntPtr SetCurActiveMontagePos_FunctionAddress;

	private static int SetCurActiveMontagePos_ParamsSize;

	private static bool SetCurActiveMontagePos_CurCharacter_IsValid;

	private static FFieldAddress SetCurActiveMontagePos_CurCharacter_PropertyAddress;

	private static int SetCurActiveMontagePos_CurCharacter_Offset;

	private static bool SetCurActiveMontagePos_TargetPos_IsValid;

	private static FFieldAddress SetCurActiveMontagePos_TargetPos_PropertyAddress;

	private static int SetCurActiveMontagePos_TargetPos_Offset;

	private static bool SafeSetCharacterMontagePlayingRate_IsValid;

	private static IntPtr SafeSetCharacterMontagePlayingRate_FunctionAddress;

	private static int SafeSetCharacterMontagePlayingRate_ParamsSize;

	private static bool SafeSetCharacterMontagePlayingRate_CurCharacter_IsValid;

	private static FFieldAddress SafeSetCharacterMontagePlayingRate_CurCharacter_PropertyAddress;

	private static int SafeSetCharacterMontagePlayingRate_CurCharacter_Offset;

	private static bool SafeSetCharacterMontagePlayingRate_PlayRate_IsValid;

	private static FFieldAddress SafeSetCharacterMontagePlayingRate_PlayRate_PropertyAddress;

	private static int SafeSetCharacterMontagePlayingRate_PlayRate_Offset;

	private static bool SafeSetCharacterMontagePlayingRate_ReturnValue_IsValid;

	private static FFieldAddress SafeSetCharacterMontagePlayingRate_ReturnValue_PropertyAddress;

	private static int SafeSetCharacterMontagePlayingRate_ReturnValue_Offset;

	private static bool SafeSetCharacterMontagePlaying_IsValid;

	private static IntPtr SafeSetCharacterMontagePlaying_FunctionAddress;

	private static int SafeSetCharacterMontagePlaying_ParamsSize;

	private static bool SafeSetCharacterMontagePlaying_CurCharacter_IsValid;

	private static FFieldAddress SafeSetCharacterMontagePlaying_CurCharacter_PropertyAddress;

	private static int SafeSetCharacterMontagePlaying_CurCharacter_Offset;

	private static bool SafeSetCharacterMontagePlaying_IsPlaying_IsValid;

	private static FFieldAddress SafeSetCharacterMontagePlaying_IsPlaying_PropertyAddress;

	private static int SafeSetCharacterMontagePlaying_IsPlaying_Offset;

	private static bool SafeSetCharacterMontagePlaying_ReturnValue_IsValid;

	private static FFieldAddress SafeSetCharacterMontagePlaying_ReturnValue_PropertyAddress;

	private static int SafeSetCharacterMontagePlaying_ReturnValue_Offset;

	private static bool PlayMontage_IsValid;

	private static IntPtr PlayMontage_FunctionAddress;

	private static int PlayMontage_ParamsSize;

	private static bool PlayMontage_CurCharacter_IsValid;

	private static FFieldAddress PlayMontage_CurCharacter_PropertyAddress;

	private static int PlayMontage_CurCharacter_Offset;

	private static bool PlayMontage_AnimMontage_IsValid;

	private static FFieldAddress PlayMontage_AnimMontage_PropertyAddress;

	private static int PlayMontage_AnimMontage_Offset;

	private static bool PlayMontage_ReturnValue_IsValid;

	private static FFieldAddress PlayMontage_ReturnValue_PropertyAddress;

	private static int PlayMontage_ReturnValue_Offset;

	private static bool PlayCameraShakeByClass_IsValid;

	private static IntPtr PlayCameraShakeByClass_FunctionAddress;

	private static int PlayCameraShakeByClass_ParamsSize;

	private static bool PlayCameraShakeByClass_Caster_IsValid;

	private static FFieldAddress PlayCameraShakeByClass_Caster_PropertyAddress;

	private static int PlayCameraShakeByClass_Caster_Offset;

	private static bool PlayCameraShakeByClass_CameraShakeCls_IsValid;

	private static FFieldAddress PlayCameraShakeByClass_CameraShakeCls_PropertyAddress;

	private static int PlayCameraShakeByClass_CameraShakeCls_Offset;

	private static bool PlayCameraShakeByClass_ReturnValue_IsValid;

	private static FFieldAddress PlayCameraShakeByClass_ReturnValue_PropertyAddress;

	private static int PlayCameraShakeByClass_ReturnValue_Offset;

	private static bool ParticleSystemComponentTrailSetTimeRate_IsValid;

	private static IntPtr ParticleSystemComponentTrailSetTimeRate_FunctionAddress;

	private static int ParticleSystemComponentTrailSetTimeRate_ParamsSize;

	private static bool ParticleSystemComponentTrailSetTimeRate_CurCharacter_IsValid;

	private static FFieldAddress ParticleSystemComponentTrailSetTimeRate_CurCharacter_PropertyAddress;

	private static int ParticleSystemComponentTrailSetTimeRate_CurCharacter_Offset;

	private static bool ParticleSystemComponentTrailSetTimeRate_TimeRate_IsValid;

	private static FFieldAddress ParticleSystemComponentTrailSetTimeRate_TimeRate_PropertyAddress;

	private static int ParticleSystemComponentTrailSetTimeRate_TimeRate_Offset;

	private static bool LoadParticleSystemFromString_IsValid;

	private static IntPtr LoadParticleSystemFromString_FunctionAddress;

	private static int LoadParticleSystemFromString_ParamsSize;

	private static bool LoadParticleSystemFromString_ResPath_IsValid;

	private static FFieldAddress LoadParticleSystemFromString_ResPath_PropertyAddress;

	private static int LoadParticleSystemFromString_ResPath_Offset;

	private static bool LoadParticleSystemFromString_DefaultDelayTime_IsValid;

	private static FFieldAddress LoadParticleSystemFromString_DefaultDelayTime_PropertyAddress;

	private static int LoadParticleSystemFromString_DefaultDelayTime_Offset;

	private static bool LoadParticleSystemFromString_ReturnValue_IsValid;

	private static FFieldAddress LoadParticleSystemFromString_ReturnValue_PropertyAddress;

	private static int LoadParticleSystemFromString_ReturnValue_Offset;

	private static bool LoadLevelSequenceFromString_IsValid;

	private static IntPtr LoadLevelSequenceFromString_FunctionAddress;

	private static int LoadLevelSequenceFromString_ParamsSize;

	private static bool LoadLevelSequenceFromString_ResPath_IsValid;

	private static FFieldAddress LoadLevelSequenceFromString_ResPath_PropertyAddress;

	private static int LoadLevelSequenceFromString_ResPath_Offset;

	private static bool LoadLevelSequenceFromString_ReturnValue_IsValid;

	private static FFieldAddress LoadLevelSequenceFromString_ReturnValue_PropertyAddress;

	private static int LoadLevelSequenceFromString_ReturnValue_Offset;

	private static bool LoadCurveFloatFromString_IsValid;

	private static IntPtr LoadCurveFloatFromString_FunctionAddress;

	private static int LoadCurveFloatFromString_ParamsSize;

	private static bool LoadCurveFloatFromString_ResPath_IsValid;

	private static FFieldAddress LoadCurveFloatFromString_ResPath_PropertyAddress;

	private static int LoadCurveFloatFromString_ResPath_Offset;

	private static bool LoadCurveFloatFromString_ReturnValue_IsValid;

	private static FFieldAddress LoadCurveFloatFromString_ReturnValue_PropertyAddress;

	private static int LoadCurveFloatFromString_ReturnValue_Offset;

	private static bool LoadCameraShakeFromString_IsValid;

	private static IntPtr LoadCameraShakeFromString_FunctionAddress;

	private static int LoadCameraShakeFromString_ParamsSize;

	private static bool LoadCameraShakeFromString_ResPath_IsValid;

	private static FFieldAddress LoadCameraShakeFromString_ResPath_PropertyAddress;

	private static int LoadCameraShakeFromString_ResPath_Offset;

	private static bool LoadCameraShakeFromString_ReturnValue_IsValid;

	private static FFieldAddress LoadCameraShakeFromString_ReturnValue_PropertyAddress;

	private static int LoadCameraShakeFromString_ReturnValue_Offset;

	private static bool LoadAnimMontageFromString_IsValid;

	private static IntPtr LoadAnimMontageFromString_FunctionAddress;

	private static int LoadAnimMontageFromString_ParamsSize;

	private static bool LoadAnimMontageFromString_ResPath_IsValid;

	private static FFieldAddress LoadAnimMontageFromString_ResPath_PropertyAddress;

	private static int LoadAnimMontageFromString_ResPath_Offset;

	private static bool LoadAnimMontageFromString_ReturnValue_IsValid;

	private static FFieldAddress LoadAnimMontageFromString_ReturnValue_PropertyAddress;

	private static int LoadAnimMontageFromString_ReturnValue_Offset;

	private static bool LoadAKEventFromString_IsValid;

	private static IntPtr LoadAKEventFromString_FunctionAddress;

	private static int LoadAKEventFromString_ParamsSize;

	private static bool LoadAKEventFromString_ResPath_IsValid;

	private static FFieldAddress LoadAKEventFromString_ResPath_PropertyAddress;

	private static int LoadAKEventFromString_ResPath_Offset;

	private static bool LoadAKEventFromString_ReturnValue_IsValid;

	private static FFieldAddress LoadAKEventFromString_ReturnValue_PropertyAddress;

	private static int LoadAKEventFromString_ReturnValue_Offset;

	private static bool IsCharacterStoped_IsValid;

	private static IntPtr IsCharacterStoped_FunctionAddress;

	private static int IsCharacterStoped_ParamsSize;

	private static bool IsCharacterStoped_CurCharacter_IsValid;

	private static FFieldAddress IsCharacterStoped_CurCharacter_PropertyAddress;

	private static int IsCharacterStoped_CurCharacter_Offset;

	private static bool IsCharacterStoped_ReturnValue_IsValid;

	private static FFieldAddress IsCharacterStoped_ReturnValue_PropertyAddress;

	private static int IsCharacterStoped_ReturnValue_Offset;

	private static bool GSEaseRotator_IsValid;

	private static IntPtr GSEaseRotator_FunctionAddress;

	private static int GSEaseRotator_ParamsSize;

	private static bool GSEaseRotator_Start_IsValid;

	private static FFieldAddress GSEaseRotator_Start_PropertyAddress;

	private static int GSEaseRotator_Start_Offset;

	private static bool GSEaseRotator_End_IsValid;

	private static FFieldAddress GSEaseRotator_End_PropertyAddress;

	private static int GSEaseRotator_End_Offset;

	private static bool GSEaseRotator_Alpha_IsValid;

	private static FFieldAddress GSEaseRotator_Alpha_PropertyAddress;

	private static int GSEaseRotator_Alpha_Offset;

	private static bool GSEaseRotator_GSBlendTypeG_IsValid;

	private static FFieldAddress GSEaseRotator_GSBlendTypeG_PropertyAddress;

	private static int GSEaseRotator_GSBlendTypeG_Offset;

	private static bool GSEaseRotator_EaseExp_IsValid;

	private static FFieldAddress GSEaseRotator_EaseExp_PropertyAddress;

	private static int GSEaseRotator_EaseExp_Offset;

	private static bool GSEaseRotator_IsShortestPath_IsValid;

	private static FFieldAddress GSEaseRotator_IsShortestPath_PropertyAddress;

	private static int GSEaseRotator_IsShortestPath_Offset;

	private static bool GSEaseRotator_ReturnValue_IsValid;

	private static FFieldAddress GSEaseRotator_ReturnValue_PropertyAddress;

	private static int GSEaseRotator_ReturnValue_Offset;

	private static bool GSEase_IsValid;

	private static IntPtr GSEase_FunctionAddress;

	private static int GSEase_ParamsSize;

	private static bool GSEase_Start_IsValid;

	private static FFieldAddress GSEase_Start_PropertyAddress;

	private static int GSEase_Start_Offset;

	private static bool GSEase_End_IsValid;

	private static FFieldAddress GSEase_End_PropertyAddress;

	private static int GSEase_End_Offset;

	private static bool GSEase_Alpha_IsValid;

	private static FFieldAddress GSEase_Alpha_PropertyAddress;

	private static int GSEase_Alpha_Offset;

	private static bool GSEase_GSBlendTypeG_IsValid;

	private static FFieldAddress GSEase_GSBlendTypeG_PropertyAddress;

	private static int GSEase_GSBlendTypeG_Offset;

	private static bool GSEase_EaseExp_IsValid;

	private static FFieldAddress GSEase_EaseExp_PropertyAddress;

	private static int GSEase_EaseExp_Offset;

	private static bool GSEase_ReturnValue_IsValid;

	private static FFieldAddress GSEase_ReturnValue_PropertyAddress;

	private static int GSEase_ReturnValue_Offset;

	private static bool GetUMatineeCameraShakeBlendOutTime_IsValid;

	private static IntPtr GetUMatineeCameraShakeBlendOutTime_FunctionAddress;

	private static int GetUMatineeCameraShakeBlendOutTime_ParamsSize;

	private static bool GetUMatineeCameraShakeBlendOutTime_CameraShake_IsValid;

	private static FFieldAddress GetUMatineeCameraShakeBlendOutTime_CameraShake_PropertyAddress;

	private static int GetUMatineeCameraShakeBlendOutTime_CameraShake_Offset;

	private static bool GetUMatineeCameraShakeBlendOutTime_ReturnValue_IsValid;

	private static FFieldAddress GetUMatineeCameraShakeBlendOutTime_ReturnValue_PropertyAddress;

	private static int GetUMatineeCameraShakeBlendOutTime_ReturnValue_Offset;

	private static bool GetEasingFuncType_IsValid;

	private static IntPtr GetEasingFuncType_FunctionAddress;

	private static int GetEasingFuncType_ParamsSize;

	private static bool GetEasingFuncType_GSBlengTypeG_IsValid;

	private static FFieldAddress GetEasingFuncType_GSBlengTypeG_PropertyAddress;

	private static int GetEasingFuncType_GSBlengTypeG_Offset;

	private static bool GetEasingFuncType_ReturnValue_IsValid;

	private static FFieldAddress GetEasingFuncType_ReturnValue_PropertyAddress;

	private static int GetEasingFuncType_ReturnValue_Offset;

	private static bool GetCurActiveMontagePos_IsValid;

	private static IntPtr GetCurActiveMontagePos_FunctionAddress;

	private static int GetCurActiveMontagePos_ParamsSize;

	private static bool GetCurActiveMontagePos_CurCharacter_IsValid;

	private static FFieldAddress GetCurActiveMontagePos_CurCharacter_PropertyAddress;

	private static int GetCurActiveMontagePos_CurCharacter_Offset;

	private static bool GetCurActiveMontagePos_ReturnValue_IsValid;

	private static FFieldAddress GetCurActiveMontagePos_ReturnValue_PropertyAddress;

	private static int GetCurActiveMontagePos_ReturnValue_Offset;

	private static bool CalcYawRotator_IsValid;

	private static IntPtr CalcYawRotator_FunctionAddress;

	private static int CalcYawRotator_ParamsSize;

	private static bool CalcYawRotator_TargetLocation_IsValid;

	private static FFieldAddress CalcYawRotator_TargetLocation_PropertyAddress;

	private static int CalcYawRotator_TargetLocation_Offset;

	private static bool CalcYawRotator_FromLocation_IsValid;

	private static FFieldAddress CalcYawRotator_FromLocation_PropertyAddress;

	private static int CalcYawRotator_FromLocation_Offset;

	private static bool CalcYawRotator_ReturnValue_IsValid;

	private static FFieldAddress CalcYawRotator_ReturnValue_PropertyAddress;

	private static int CalcYawRotator_ReturnValue_Offset;

	private static bool CalcDirWithInput_IsValid;

	private static IntPtr CalcDirWithInput_FunctionAddress;

	private static int CalcDirWithInput_ParamsSize;

	private static bool CalcDirWithInput_CurCharacter_IsValid;

	private static FFieldAddress CalcDirWithInput_CurCharacter_PropertyAddress;

	private static int CalcDirWithInput_CurCharacter_Offset;

	private static bool CalcDirWithInput_ForwardVal_IsValid;

	private static FFieldAddress CalcDirWithInput_ForwardVal_PropertyAddress;

	private static int CalcDirWithInput_ForwardVal_Offset;

	private static bool CalcDirWithInput_RightVal_IsValid;

	private static FFieldAddress CalcDirWithInput_RightVal_PropertyAddress;

	private static int CalcDirWithInput_RightVal_Offset;

	private static bool CalcDirWithInput_ReturnValue_IsValid;

	private static FFieldAddress CalcDirWithInput_ReturnValue_PropertyAddress;

	private static int CalcDirWithInput_ReturnValue_Offset;

	private static bool CalcDegreeFromVectorsProjectInXYPlane_IsValid;

	private static IntPtr CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress;

	private static int CalcDegreeFromVectorsProjectInXYPlane_ParamsSize;

	private static bool CalcDegreeFromVectorsProjectInXYPlane_AVector_IsValid;

	private static FFieldAddress CalcDegreeFromVectorsProjectInXYPlane_AVector_PropertyAddress;

	private static int CalcDegreeFromVectorsProjectInXYPlane_AVector_Offset;

	private static bool CalcDegreeFromVectorsProjectInXYPlane_BVector_IsValid;

	private static FFieldAddress CalcDegreeFromVectorsProjectInXYPlane_BVector_PropertyAddress;

	private static int CalcDegreeFromVectorsProjectInXYPlane_BVector_Offset;

	private static bool CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_IsValid;

	private static FFieldAddress CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_PropertyAddress;

	private static int CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_Offset;

	private static bool CalcDegreeFromRotatorsInYaw_IsValid;

	private static IntPtr CalcDegreeFromRotatorsInYaw_FunctionAddress;

	private static int CalcDegreeFromRotatorsInYaw_ParamsSize;

	private static bool CalcDegreeFromRotatorsInYaw_ARotator_IsValid;

	private static FFieldAddress CalcDegreeFromRotatorsInYaw_ARotator_PropertyAddress;

	private static int CalcDegreeFromRotatorsInYaw_ARotator_Offset;

	private static bool CalcDegreeFromRotatorsInYaw_BRotator_IsValid;

	private static FFieldAddress CalcDegreeFromRotatorsInYaw_BRotator_PropertyAddress;

	private static int CalcDegreeFromRotatorsInYaw_BRotator_Offset;

	private static bool CalcDegreeFromRotatorsInYaw_ReturnValue_IsValid;

	private static FFieldAddress CalcDegreeFromRotatorsInYaw_ReturnValue_PropertyAddress;

	private static int CalcDegreeFromRotatorsInYaw_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:SetCurActiveMontagePos")]
	public unsafe static void SetCurActiveMontagePos(ACharacter CurCharacter, float TargetPos)
	{
		if (!SetCurActiveMontagePos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:SetCurActiveMontagePos");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurActiveMontagePos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurActiveMontagePos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, SetCurActiveMontagePos_CurCharacter_Offset), 0, SetCurActiveMontagePos_CurCharacter_PropertyAddress.Address, CurCharacter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCurActiveMontagePos_TargetPos_Offset), 0, SetCurActiveMontagePos_TargetPos_PropertyAddress.Address, TargetPos);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurActiveMontagePos_FunctionAddress, intPtr, SetCurActiveMontagePos_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:SafeSetCharacterMontagePlayingRate")]
	public unsafe static bool SafeSetCharacterMontagePlayingRate(ACharacter CurCharacter, float PlayRate)
	{
		if (!SafeSetCharacterMontagePlayingRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:SafeSetCharacterMontagePlayingRate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SafeSetCharacterMontagePlayingRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SafeSetCharacterMontagePlayingRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, SafeSetCharacterMontagePlayingRate_CurCharacter_Offset), 0, SafeSetCharacterMontagePlayingRate_CurCharacter_PropertyAddress.Address, CurCharacter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SafeSetCharacterMontagePlayingRate_PlayRate_Offset), 0, SafeSetCharacterMontagePlayingRate_PlayRate_PropertyAddress.Address, PlayRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SafeSetCharacterMontagePlayingRate_FunctionAddress, intPtr, SafeSetCharacterMontagePlayingRate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SafeSetCharacterMontagePlayingRate_ReturnValue_Offset), 0, SafeSetCharacterMontagePlayingRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:SafeSetCharacterMontagePlaying")]
	public unsafe static bool SafeSetCharacterMontagePlaying(ACharacter CurCharacter, bool IsPlaying)
	{
		if (!SafeSetCharacterMontagePlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:SafeSetCharacterMontagePlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SafeSetCharacterMontagePlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SafeSetCharacterMontagePlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, SafeSetCharacterMontagePlaying_CurCharacter_Offset), 0, SafeSetCharacterMontagePlaying_CurCharacter_PropertyAddress.Address, CurCharacter);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SafeSetCharacterMontagePlaying_IsPlaying_Offset), 0, SafeSetCharacterMontagePlaying_IsPlaying_PropertyAddress.Address, IsPlaying);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SafeSetCharacterMontagePlaying_FunctionAddress, intPtr, SafeSetCharacterMontagePlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SafeSetCharacterMontagePlaying_ReturnValue_Offset), 0, SafeSetCharacterMontagePlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:PlayMontage")]
	public unsafe static bool PlayMontage(ACharacter CurCharacter, UAnimMontage AnimMontage)
	{
		if (!PlayMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:PlayMontage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, PlayMontage_CurCharacter_Offset), 0, PlayMontage_CurCharacter_PropertyAddress.Address, CurCharacter);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, PlayMontage_AnimMontage_Offset), 0, PlayMontage_AnimMontage_PropertyAddress.Address, AnimMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PlayMontage_FunctionAddress, intPtr, PlayMontage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PlayMontage_ReturnValue_Offset), 0, PlayMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:PlayCameraShakeByClass")]
	public unsafe static UMatineeCameraShake PlayCameraShakeByClass(AActor Caster, TSubclassOf<UObject> CameraShakeCls)
	{
		if (!PlayCameraShakeByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:PlayCameraShakeByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayCameraShakeByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayCameraShakeByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PlayCameraShakeByClass_Caster_Offset), 0, PlayCameraShakeByClass_Caster_PropertyAddress.Address, Caster);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PlayCameraShakeByClass_CameraShakeCls_Offset), 0, PlayCameraShakeByClass_CameraShakeCls_PropertyAddress.Address, CameraShakeCls);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PlayCameraShakeByClass_FunctionAddress, intPtr, PlayCameraShakeByClass_ParamsSize);
		return UObjectMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(intPtr, PlayCameraShakeByClass_ReturnValue_Offset), 0, PlayCameraShakeByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:ParticleSystemComponentTrailSetTimeRate")]
	public unsafe static void ParticleSystemComponentTrailSetTimeRate(ACharacter CurCharacter, float TimeRate)
	{
		if (!ParticleSystemComponentTrailSetTimeRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:ParticleSystemComponentTrailSetTimeRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ParticleSystemComponentTrailSetTimeRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ParticleSystemComponentTrailSetTimeRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, ParticleSystemComponentTrailSetTimeRate_CurCharacter_Offset), 0, ParticleSystemComponentTrailSetTimeRate_CurCharacter_PropertyAddress.Address, CurCharacter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ParticleSystemComponentTrailSetTimeRate_TimeRate_Offset), 0, ParticleSystemComponentTrailSetTimeRate_TimeRate_PropertyAddress.Address, TimeRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ParticleSystemComponentTrailSetTimeRate_FunctionAddress, intPtr, ParticleSystemComponentTrailSetTimeRate_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:LoadParticleSystemFromString")]
	public unsafe static UParticleSystem LoadParticleSystemFromString(string ResPath, float DefaultDelayTime = 0f)
	{
		if (!LoadParticleSystemFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:LoadParticleSystemFromString");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadParticleSystemFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadParticleSystemFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadParticleSystemFromString_ResPath_Offset), 0, LoadParticleSystemFromString_ResPath_PropertyAddress.Address, ResPath);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LoadParticleSystemFromString_DefaultDelayTime_Offset), 0, LoadParticleSystemFromString_DefaultDelayTime_PropertyAddress.Address, DefaultDelayTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadParticleSystemFromString_FunctionAddress, intPtr, LoadParticleSystemFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadParticleSystemFromString_ResPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(intPtr, LoadParticleSystemFromString_ReturnValue_Offset), 0, LoadParticleSystemFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:LoadLevelSequenceFromString")]
	public unsafe static ULevelSequence LoadLevelSequenceFromString(string ResPath)
	{
		if (!LoadLevelSequenceFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:LoadLevelSequenceFromString");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadLevelSequenceFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadLevelSequenceFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevelSequenceFromString_ResPath_Offset), 0, LoadLevelSequenceFromString_ResPath_PropertyAddress.Address, ResPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadLevelSequenceFromString_FunctionAddress, intPtr, LoadLevelSequenceFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadLevelSequenceFromString_ResPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(intPtr, LoadLevelSequenceFromString_ReturnValue_Offset), 0, LoadLevelSequenceFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:LoadCurveFloatFromString")]
	public unsafe static UCurveFloat LoadCurveFloatFromString(string ResPath)
	{
		if (!LoadCurveFloatFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:LoadCurveFloatFromString");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadCurveFloatFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadCurveFloatFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadCurveFloatFromString_ResPath_Offset), 0, LoadCurveFloatFromString_ResPath_PropertyAddress.Address, ResPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadCurveFloatFromString_FunctionAddress, intPtr, LoadCurveFloatFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadCurveFloatFromString_ResPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(intPtr, LoadCurveFloatFromString_ReturnValue_Offset), 0, LoadCurveFloatFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:LoadCameraShakeFromString")]
	public unsafe static TSubclassOf<UObject> LoadCameraShakeFromString(string ResPath)
	{
		if (!LoadCameraShakeFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:LoadCameraShakeFromString");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadCameraShakeFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadCameraShakeFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadCameraShakeFromString_ResPath_Offset), 0, LoadCameraShakeFromString_ResPath_PropertyAddress.Address, ResPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadCameraShakeFromString_FunctionAddress, intPtr, LoadCameraShakeFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadCameraShakeFromString_ResPath_PropertyAddress.Address, intPtr);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, LoadCameraShakeFromString_ReturnValue_Offset), 0, LoadCameraShakeFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:LoadAnimMontageFromString")]
	public unsafe static UAnimMontage LoadAnimMontageFromString(string ResPath)
	{
		if (!LoadAnimMontageFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:LoadAnimMontageFromString");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadAnimMontageFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadAnimMontageFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadAnimMontageFromString_ResPath_Offset), 0, LoadAnimMontageFromString_ResPath_PropertyAddress.Address, ResPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadAnimMontageFromString_FunctionAddress, intPtr, LoadAnimMontageFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadAnimMontageFromString_ResPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(intPtr, LoadAnimMontageFromString_ReturnValue_Offset), 0, LoadAnimMontageFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:LoadAKEventFromString")]
	public unsafe static UObject LoadAKEventFromString(string ResPath)
	{
		if (!LoadAKEventFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:LoadAKEventFromString");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadAKEventFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadAKEventFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadAKEventFromString_ResPath_Offset), 0, LoadAKEventFromString_ResPath_PropertyAddress.Address, ResPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadAKEventFromString_FunctionAddress, intPtr, LoadAKEventFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadAKEventFromString_ResPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, LoadAKEventFromString_ReturnValue_Offset), 0, LoadAKEventFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:IsCharacterStoped")]
	public unsafe static bool IsCharacterStoped(ACharacter CurCharacter)
	{
		if (!IsCharacterStoped_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:IsCharacterStoped");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCharacterStoped_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCharacterStoped_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, IsCharacterStoped_CurCharacter_Offset), 0, IsCharacterStoped_CurCharacter_PropertyAddress.Address, CurCharacter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCharacterStoped_FunctionAddress, intPtr, IsCharacterStoped_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCharacterStoped_ReturnValue_Offset), 0, IsCharacterStoped_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:GSEaseRotator")]
	public unsafe static FRotator GSEaseRotator(FRotator Start, FRotator End, float Alpha, EGSBlendTypeG GSBlendTypeG, float EaseExp, bool IsShortestPath = true)
	{
		if (!GSEaseRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:GSEaseRotator");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSEaseRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSEaseRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, GSEaseRotator_Start_Offset), 0, GSEaseRotator_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, GSEaseRotator_End_Offset), 0, GSEaseRotator_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSEaseRotator_Alpha_Offset), 0, GSEaseRotator_Alpha_PropertyAddress.Address, Alpha);
		EnumMarshaler<EGSBlendTypeG>.ToNative(IntPtr.Add(intPtr, GSEaseRotator_GSBlendTypeG_Offset), 0, GSEaseRotator_GSBlendTypeG_PropertyAddress.Address, GSBlendTypeG);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSEaseRotator_EaseExp_Offset), 0, GSEaseRotator_EaseExp_PropertyAddress.Address, EaseExp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSEaseRotator_IsShortestPath_Offset), 0, GSEaseRotator_IsShortestPath_PropertyAddress.Address, IsShortestPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSEaseRotator_FunctionAddress, intPtr, GSEaseRotator_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GSEaseRotator_ReturnValue_Offset), 0, GSEaseRotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:GSEase")]
	public unsafe static float GSEase(float Start, float End, float Alpha, EGSBlendTypeG GSBlendTypeG, float EaseExp)
	{
		if (!GSEase_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:GSEase");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSEase_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSEase_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSEase_Start_Offset), 0, GSEase_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSEase_End_Offset), 0, GSEase_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSEase_Alpha_Offset), 0, GSEase_Alpha_PropertyAddress.Address, Alpha);
		EnumMarshaler<EGSBlendTypeG>.ToNative(IntPtr.Add(intPtr, GSEase_GSBlendTypeG_Offset), 0, GSEase_GSBlendTypeG_PropertyAddress.Address, GSBlendTypeG);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSEase_EaseExp_Offset), 0, GSEase_EaseExp_PropertyAddress.Address, EaseExp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSEase_FunctionAddress, intPtr, GSEase_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GSEase_ReturnValue_Offset), 0, GSEase_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:GetUMatineeCameraShakeBlendOutTime")]
	public unsafe static float GetUMatineeCameraShakeBlendOutTime(UMatineeCameraShake CameraShake)
	{
		if (!GetUMatineeCameraShakeBlendOutTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:GetUMatineeCameraShakeBlendOutTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUMatineeCameraShakeBlendOutTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUMatineeCameraShakeBlendOutTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(intPtr, GetUMatineeCameraShakeBlendOutTime_CameraShake_Offset), 0, GetUMatineeCameraShakeBlendOutTime_CameraShake_PropertyAddress.Address, CameraShake);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUMatineeCameraShakeBlendOutTime_FunctionAddress, intPtr, GetUMatineeCameraShakeBlendOutTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUMatineeCameraShakeBlendOutTime_ReturnValue_Offset), 0, GetUMatineeCameraShakeBlendOutTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:GetEasingFuncType")]
	public unsafe static int GetEasingFuncType(EGSBlendTypeG GSBlengTypeG)
	{
		if (!GetEasingFuncType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:GetEasingFuncType");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEasingFuncType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEasingFuncType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSBlendTypeG>.ToNative(IntPtr.Add(intPtr, GetEasingFuncType_GSBlengTypeG_Offset), 0, GetEasingFuncType_GSBlengTypeG_PropertyAddress.Address, GSBlengTypeG);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEasingFuncType_FunctionAddress, intPtr, GetEasingFuncType_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetEasingFuncType_ReturnValue_Offset), 0, GetEasingFuncType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:GetCurActiveMontagePos")]
	public unsafe static float GetCurActiveMontagePos(ACharacter CurCharacter)
	{
		if (!GetCurActiveMontagePos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:GetCurActiveMontagePos");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurActiveMontagePos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurActiveMontagePos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, GetCurActiveMontagePos_CurCharacter_Offset), 0, GetCurActiveMontagePos_CurCharacter_PropertyAddress.Address, CurCharacter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurActiveMontagePos_FunctionAddress, intPtr, GetCurActiveMontagePos_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurActiveMontagePos_ReturnValue_Offset), 0, GetCurActiveMontagePos_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:CalcYawRotator")]
	public unsafe static FRotator CalcYawRotator(FVector TargetLocation, FVector FromLocation)
	{
		if (!CalcYawRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:CalcYawRotator");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcYawRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcYawRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcYawRotator_TargetLocation_Offset), 0, CalcYawRotator_TargetLocation_PropertyAddress.Address, TargetLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcYawRotator_FromLocation_Offset), 0, CalcYawRotator_FromLocation_PropertyAddress.Address, FromLocation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcYawRotator_FunctionAddress, intPtr, CalcYawRotator_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, CalcYawRotator_ReturnValue_Offset), 0, CalcYawRotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:CalcDirWithInput")]
	public unsafe static FRotator CalcDirWithInput(ACharacter CurCharacter, float ForwardVal, float RightVal)
	{
		if (!CalcDirWithInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:CalcDirWithInput");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcDirWithInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcDirWithInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, CalcDirWithInput_CurCharacter_Offset), 0, CalcDirWithInput_CurCharacter_PropertyAddress.Address, CurCharacter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalcDirWithInput_ForwardVal_Offset), 0, CalcDirWithInput_ForwardVal_PropertyAddress.Address, ForwardVal);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalcDirWithInput_RightVal_Offset), 0, CalcDirWithInput_RightVal_PropertyAddress.Address, RightVal);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcDirWithInput_FunctionAddress, intPtr, CalcDirWithInput_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, CalcDirWithInput_ReturnValue_Offset), 0, CalcDirWithInput_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:CalcDegreeFromVectorsProjectInXYPlane")]
	public unsafe static float CalcDegreeFromVectorsProjectInXYPlane(FVector AVector, FVector BVector)
	{
		if (!CalcDegreeFromVectorsProjectInXYPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:CalcDegreeFromVectorsProjectInXYPlane");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcDegreeFromVectorsProjectInXYPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcDegreeFromVectorsProjectInXYPlane_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcDegreeFromVectorsProjectInXYPlane_AVector_Offset), 0, CalcDegreeFromVectorsProjectInXYPlane_AVector_PropertyAddress.Address, AVector);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcDegreeFromVectorsProjectInXYPlane_BVector_Offset), 0, CalcDegreeFromVectorsProjectInXYPlane_BVector_PropertyAddress.Address, BVector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, intPtr, CalcDegreeFromVectorsProjectInXYPlane_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_Offset), 0, CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/b1.BUS_UtilComm:CalcDegreeFromRotatorsInYaw")]
	public unsafe static float CalcDegreeFromRotatorsInYaw(FRotator ARotator, FRotator BRotator)
	{
		if (!CalcDegreeFromRotatorsInYaw_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUS_UtilComm:CalcDegreeFromRotatorsInYaw");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcDegreeFromRotatorsInYaw_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcDegreeFromRotatorsInYaw_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, CalcDegreeFromRotatorsInYaw_ARotator_Offset), 0, CalcDegreeFromRotatorsInYaw_ARotator_PropertyAddress.Address, ARotator);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, CalcDegreeFromRotatorsInYaw_BRotator_Offset), 0, CalcDegreeFromRotatorsInYaw_BRotator_PropertyAddress.Address, BRotator);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcDegreeFromRotatorsInYaw_FunctionAddress, intPtr, CalcDegreeFromRotatorsInYaw_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcDegreeFromRotatorsInYaw_ReturnValue_Offset), 0, CalcDegreeFromRotatorsInYaw_ReturnValue_PropertyAddress.Address);
	}

	static UBUS_UtilComm()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBUS_UtilComm)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBUS_UtilComm));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BUS_UtilComm");
		SetCurActiveMontagePos_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurActiveMontagePos");
		SetCurActiveMontagePos_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurActiveMontagePos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurActiveMontagePos_CurCharacter_PropertyAddress, SetCurActiveMontagePos_FunctionAddress, "CurCharacter");
		SetCurActiveMontagePos_CurCharacter_Offset = NativeReflectionCached.GetPropertyOffset(SetCurActiveMontagePos_FunctionAddress, "CurCharacter");
		SetCurActiveMontagePos_CurCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurActiveMontagePos_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurActiveMontagePos_TargetPos_PropertyAddress, SetCurActiveMontagePos_FunctionAddress, "TargetPos");
		SetCurActiveMontagePos_TargetPos_Offset = NativeReflectionCached.GetPropertyOffset(SetCurActiveMontagePos_FunctionAddress, "TargetPos");
		SetCurActiveMontagePos_TargetPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurActiveMontagePos_FunctionAddress, "TargetPos", Classes.FFloatProperty);
		SetCurActiveMontagePos_IsValid = SetCurActiveMontagePos_FunctionAddress != IntPtr.Zero && SetCurActiveMontagePos_CurCharacter_IsValid && SetCurActiveMontagePos_TargetPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:SetCurActiveMontagePos", SetCurActiveMontagePos_IsValid);
		SafeSetCharacterMontagePlayingRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SafeSetCharacterMontagePlayingRate");
		SafeSetCharacterMontagePlayingRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SafeSetCharacterMontagePlayingRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SafeSetCharacterMontagePlayingRate_CurCharacter_PropertyAddress, SafeSetCharacterMontagePlayingRate_FunctionAddress, "CurCharacter");
		SafeSetCharacterMontagePlayingRate_CurCharacter_Offset = NativeReflectionCached.GetPropertyOffset(SafeSetCharacterMontagePlayingRate_FunctionAddress, "CurCharacter");
		SafeSetCharacterMontagePlayingRate_CurCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(SafeSetCharacterMontagePlayingRate_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SafeSetCharacterMontagePlayingRate_PlayRate_PropertyAddress, SafeSetCharacterMontagePlayingRate_FunctionAddress, "PlayRate");
		SafeSetCharacterMontagePlayingRate_PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(SafeSetCharacterMontagePlayingRate_FunctionAddress, "PlayRate");
		SafeSetCharacterMontagePlayingRate_PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SafeSetCharacterMontagePlayingRate_FunctionAddress, "PlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SafeSetCharacterMontagePlayingRate_ReturnValue_PropertyAddress, SafeSetCharacterMontagePlayingRate_FunctionAddress, "ReturnValue");
		SafeSetCharacterMontagePlayingRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SafeSetCharacterMontagePlayingRate_FunctionAddress, "ReturnValue");
		SafeSetCharacterMontagePlayingRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SafeSetCharacterMontagePlayingRate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SafeSetCharacterMontagePlayingRate_IsValid = SafeSetCharacterMontagePlayingRate_FunctionAddress != IntPtr.Zero && SafeSetCharacterMontagePlayingRate_CurCharacter_IsValid && SafeSetCharacterMontagePlayingRate_PlayRate_IsValid && SafeSetCharacterMontagePlayingRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:SafeSetCharacterMontagePlayingRate", SafeSetCharacterMontagePlayingRate_IsValid);
		SafeSetCharacterMontagePlaying_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SafeSetCharacterMontagePlaying");
		SafeSetCharacterMontagePlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(SafeSetCharacterMontagePlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SafeSetCharacterMontagePlaying_CurCharacter_PropertyAddress, SafeSetCharacterMontagePlaying_FunctionAddress, "CurCharacter");
		SafeSetCharacterMontagePlaying_CurCharacter_Offset = NativeReflectionCached.GetPropertyOffset(SafeSetCharacterMontagePlaying_FunctionAddress, "CurCharacter");
		SafeSetCharacterMontagePlaying_CurCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(SafeSetCharacterMontagePlaying_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SafeSetCharacterMontagePlaying_IsPlaying_PropertyAddress, SafeSetCharacterMontagePlaying_FunctionAddress, "IsPlaying");
		SafeSetCharacterMontagePlaying_IsPlaying_Offset = NativeReflectionCached.GetPropertyOffset(SafeSetCharacterMontagePlaying_FunctionAddress, "IsPlaying");
		SafeSetCharacterMontagePlaying_IsPlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(SafeSetCharacterMontagePlaying_FunctionAddress, "IsPlaying", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SafeSetCharacterMontagePlaying_ReturnValue_PropertyAddress, SafeSetCharacterMontagePlaying_FunctionAddress, "ReturnValue");
		SafeSetCharacterMontagePlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SafeSetCharacterMontagePlaying_FunctionAddress, "ReturnValue");
		SafeSetCharacterMontagePlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SafeSetCharacterMontagePlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SafeSetCharacterMontagePlaying_IsValid = SafeSetCharacterMontagePlaying_FunctionAddress != IntPtr.Zero && SafeSetCharacterMontagePlaying_CurCharacter_IsValid && SafeSetCharacterMontagePlaying_IsPlaying_IsValid && SafeSetCharacterMontagePlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:SafeSetCharacterMontagePlaying", SafeSetCharacterMontagePlaying_IsValid);
		PlayMontage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayMontage");
		PlayMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_CurCharacter_PropertyAddress, PlayMontage_FunctionAddress, "CurCharacter");
		PlayMontage_CurCharacter_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "CurCharacter");
		PlayMontage_CurCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_AnimMontage_PropertyAddress, PlayMontage_FunctionAddress, "AnimMontage");
		PlayMontage_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "AnimMontage");
		PlayMontage_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_ReturnValue_PropertyAddress, PlayMontage_FunctionAddress, "ReturnValue");
		PlayMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "ReturnValue");
		PlayMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PlayMontage_IsValid = PlayMontage_FunctionAddress != IntPtr.Zero && PlayMontage_CurCharacter_IsValid && PlayMontage_AnimMontage_IsValid && PlayMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:PlayMontage", PlayMontage_IsValid);
		PlayCameraShakeByClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayCameraShakeByClass");
		PlayCameraShakeByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayCameraShakeByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraShakeByClass_Caster_PropertyAddress, PlayCameraShakeByClass_FunctionAddress, "Caster");
		PlayCameraShakeByClass_Caster_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraShakeByClass_FunctionAddress, "Caster");
		PlayCameraShakeByClass_Caster_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraShakeByClass_FunctionAddress, "Caster", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraShakeByClass_CameraShakeCls_PropertyAddress, PlayCameraShakeByClass_FunctionAddress, "CameraShakeCls");
		PlayCameraShakeByClass_CameraShakeCls_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraShakeByClass_FunctionAddress, "CameraShakeCls");
		PlayCameraShakeByClass_CameraShakeCls_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraShakeByClass_FunctionAddress, "CameraShakeCls", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraShakeByClass_ReturnValue_PropertyAddress, PlayCameraShakeByClass_FunctionAddress, "ReturnValue");
		PlayCameraShakeByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraShakeByClass_FunctionAddress, "ReturnValue");
		PlayCameraShakeByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraShakeByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PlayCameraShakeByClass_IsValid = PlayCameraShakeByClass_FunctionAddress != IntPtr.Zero && PlayCameraShakeByClass_Caster_IsValid && PlayCameraShakeByClass_CameraShakeCls_IsValid && PlayCameraShakeByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:PlayCameraShakeByClass", PlayCameraShakeByClass_IsValid);
		ParticleSystemComponentTrailSetTimeRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ParticleSystemComponentTrailSetTimeRate");
		ParticleSystemComponentTrailSetTimeRate_ParamsSize = NativeReflection.GetFunctionParamsSize(ParticleSystemComponentTrailSetTimeRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ParticleSystemComponentTrailSetTimeRate_CurCharacter_PropertyAddress, ParticleSystemComponentTrailSetTimeRate_FunctionAddress, "CurCharacter");
		ParticleSystemComponentTrailSetTimeRate_CurCharacter_Offset = NativeReflectionCached.GetPropertyOffset(ParticleSystemComponentTrailSetTimeRate_FunctionAddress, "CurCharacter");
		ParticleSystemComponentTrailSetTimeRate_CurCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleSystemComponentTrailSetTimeRate_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleSystemComponentTrailSetTimeRate_TimeRate_PropertyAddress, ParticleSystemComponentTrailSetTimeRate_FunctionAddress, "TimeRate");
		ParticleSystemComponentTrailSetTimeRate_TimeRate_Offset = NativeReflectionCached.GetPropertyOffset(ParticleSystemComponentTrailSetTimeRate_FunctionAddress, "TimeRate");
		ParticleSystemComponentTrailSetTimeRate_TimeRate_IsValid = NativeReflectionCached.ValidatePropertyClass(ParticleSystemComponentTrailSetTimeRate_FunctionAddress, "TimeRate", Classes.FFloatProperty);
		ParticleSystemComponentTrailSetTimeRate_IsValid = ParticleSystemComponentTrailSetTimeRate_FunctionAddress != IntPtr.Zero && ParticleSystemComponentTrailSetTimeRate_CurCharacter_IsValid && ParticleSystemComponentTrailSetTimeRate_TimeRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:ParticleSystemComponentTrailSetTimeRate", ParticleSystemComponentTrailSetTimeRate_IsValid);
		LoadParticleSystemFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadParticleSystemFromString");
		LoadParticleSystemFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadParticleSystemFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadParticleSystemFromString_ResPath_PropertyAddress, LoadParticleSystemFromString_FunctionAddress, "ResPath");
		LoadParticleSystemFromString_ResPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadParticleSystemFromString_FunctionAddress, "ResPath");
		LoadParticleSystemFromString_ResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadParticleSystemFromString_FunctionAddress, "ResPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadParticleSystemFromString_DefaultDelayTime_PropertyAddress, LoadParticleSystemFromString_FunctionAddress, "DefaultDelayTime");
		LoadParticleSystemFromString_DefaultDelayTime_Offset = NativeReflectionCached.GetPropertyOffset(LoadParticleSystemFromString_FunctionAddress, "DefaultDelayTime");
		LoadParticleSystemFromString_DefaultDelayTime_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadParticleSystemFromString_FunctionAddress, "DefaultDelayTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadParticleSystemFromString_ReturnValue_PropertyAddress, LoadParticleSystemFromString_FunctionAddress, "ReturnValue");
		LoadParticleSystemFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadParticleSystemFromString_FunctionAddress, "ReturnValue");
		LoadParticleSystemFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadParticleSystemFromString_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadParticleSystemFromString_IsValid = LoadParticleSystemFromString_FunctionAddress != IntPtr.Zero && LoadParticleSystemFromString_ResPath_IsValid && LoadParticleSystemFromString_DefaultDelayTime_IsValid && LoadParticleSystemFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:LoadParticleSystemFromString", LoadParticleSystemFromString_IsValid);
		LoadLevelSequenceFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadLevelSequenceFromString");
		LoadLevelSequenceFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadLevelSequenceFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelSequenceFromString_ResPath_PropertyAddress, LoadLevelSequenceFromString_FunctionAddress, "ResPath");
		LoadLevelSequenceFromString_ResPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelSequenceFromString_FunctionAddress, "ResPath");
		LoadLevelSequenceFromString_ResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelSequenceFromString_FunctionAddress, "ResPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadLevelSequenceFromString_ReturnValue_PropertyAddress, LoadLevelSequenceFromString_FunctionAddress, "ReturnValue");
		LoadLevelSequenceFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevelSequenceFromString_FunctionAddress, "ReturnValue");
		LoadLevelSequenceFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevelSequenceFromString_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadLevelSequenceFromString_IsValid = LoadLevelSequenceFromString_FunctionAddress != IntPtr.Zero && LoadLevelSequenceFromString_ResPath_IsValid && LoadLevelSequenceFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:LoadLevelSequenceFromString", LoadLevelSequenceFromString_IsValid);
		LoadCurveFloatFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadCurveFloatFromString");
		LoadCurveFloatFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadCurveFloatFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadCurveFloatFromString_ResPath_PropertyAddress, LoadCurveFloatFromString_FunctionAddress, "ResPath");
		LoadCurveFloatFromString_ResPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadCurveFloatFromString_FunctionAddress, "ResPath");
		LoadCurveFloatFromString_ResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadCurveFloatFromString_FunctionAddress, "ResPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadCurveFloatFromString_ReturnValue_PropertyAddress, LoadCurveFloatFromString_FunctionAddress, "ReturnValue");
		LoadCurveFloatFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadCurveFloatFromString_FunctionAddress, "ReturnValue");
		LoadCurveFloatFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadCurveFloatFromString_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadCurveFloatFromString_IsValid = LoadCurveFloatFromString_FunctionAddress != IntPtr.Zero && LoadCurveFloatFromString_ResPath_IsValid && LoadCurveFloatFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:LoadCurveFloatFromString", LoadCurveFloatFromString_IsValid);
		LoadCameraShakeFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadCameraShakeFromString");
		LoadCameraShakeFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadCameraShakeFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadCameraShakeFromString_ResPath_PropertyAddress, LoadCameraShakeFromString_FunctionAddress, "ResPath");
		LoadCameraShakeFromString_ResPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadCameraShakeFromString_FunctionAddress, "ResPath");
		LoadCameraShakeFromString_ResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadCameraShakeFromString_FunctionAddress, "ResPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadCameraShakeFromString_ReturnValue_PropertyAddress, LoadCameraShakeFromString_FunctionAddress, "ReturnValue");
		LoadCameraShakeFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadCameraShakeFromString_FunctionAddress, "ReturnValue");
		LoadCameraShakeFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadCameraShakeFromString_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		LoadCameraShakeFromString_IsValid = LoadCameraShakeFromString_FunctionAddress != IntPtr.Zero && LoadCameraShakeFromString_ResPath_IsValid && LoadCameraShakeFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:LoadCameraShakeFromString", LoadCameraShakeFromString_IsValid);
		LoadAnimMontageFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadAnimMontageFromString");
		LoadAnimMontageFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadAnimMontageFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadAnimMontageFromString_ResPath_PropertyAddress, LoadAnimMontageFromString_FunctionAddress, "ResPath");
		LoadAnimMontageFromString_ResPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadAnimMontageFromString_FunctionAddress, "ResPath");
		LoadAnimMontageFromString_ResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAnimMontageFromString_FunctionAddress, "ResPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadAnimMontageFromString_ReturnValue_PropertyAddress, LoadAnimMontageFromString_FunctionAddress, "ReturnValue");
		LoadAnimMontageFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadAnimMontageFromString_FunctionAddress, "ReturnValue");
		LoadAnimMontageFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAnimMontageFromString_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadAnimMontageFromString_IsValid = LoadAnimMontageFromString_FunctionAddress != IntPtr.Zero && LoadAnimMontageFromString_ResPath_IsValid && LoadAnimMontageFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:LoadAnimMontageFromString", LoadAnimMontageFromString_IsValid);
		LoadAKEventFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadAKEventFromString");
		LoadAKEventFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadAKEventFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadAKEventFromString_ResPath_PropertyAddress, LoadAKEventFromString_FunctionAddress, "ResPath");
		LoadAKEventFromString_ResPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadAKEventFromString_FunctionAddress, "ResPath");
		LoadAKEventFromString_ResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAKEventFromString_FunctionAddress, "ResPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadAKEventFromString_ReturnValue_PropertyAddress, LoadAKEventFromString_FunctionAddress, "ReturnValue");
		LoadAKEventFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadAKEventFromString_FunctionAddress, "ReturnValue");
		LoadAKEventFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAKEventFromString_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadAKEventFromString_IsValid = LoadAKEventFromString_FunctionAddress != IntPtr.Zero && LoadAKEventFromString_ResPath_IsValid && LoadAKEventFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:LoadAKEventFromString", LoadAKEventFromString_IsValid);
		IsCharacterStoped_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCharacterStoped");
		IsCharacterStoped_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCharacterStoped_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCharacterStoped_CurCharacter_PropertyAddress, IsCharacterStoped_FunctionAddress, "CurCharacter");
		IsCharacterStoped_CurCharacter_Offset = NativeReflectionCached.GetPropertyOffset(IsCharacterStoped_FunctionAddress, "CurCharacter");
		IsCharacterStoped_CurCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCharacterStoped_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCharacterStoped_ReturnValue_PropertyAddress, IsCharacterStoped_FunctionAddress, "ReturnValue");
		IsCharacterStoped_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCharacterStoped_FunctionAddress, "ReturnValue");
		IsCharacterStoped_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCharacterStoped_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCharacterStoped_IsValid = IsCharacterStoped_FunctionAddress != IntPtr.Zero && IsCharacterStoped_CurCharacter_IsValid && IsCharacterStoped_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:IsCharacterStoped", IsCharacterStoped_IsValid);
		GSEaseRotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSEaseRotator");
		GSEaseRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(GSEaseRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSEaseRotator_Start_PropertyAddress, GSEaseRotator_FunctionAddress, "Start");
		GSEaseRotator_Start_Offset = NativeReflectionCached.GetPropertyOffset(GSEaseRotator_FunctionAddress, "Start");
		GSEaseRotator_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEaseRotator_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEaseRotator_End_PropertyAddress, GSEaseRotator_FunctionAddress, "End");
		GSEaseRotator_End_Offset = NativeReflectionCached.GetPropertyOffset(GSEaseRotator_FunctionAddress, "End");
		GSEaseRotator_End_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEaseRotator_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEaseRotator_Alpha_PropertyAddress, GSEaseRotator_FunctionAddress, "Alpha");
		GSEaseRotator_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(GSEaseRotator_FunctionAddress, "Alpha");
		GSEaseRotator_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEaseRotator_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEaseRotator_GSBlendTypeG_PropertyAddress, GSEaseRotator_FunctionAddress, "GSBlendTypeG");
		GSEaseRotator_GSBlendTypeG_Offset = NativeReflectionCached.GetPropertyOffset(GSEaseRotator_FunctionAddress, "GSBlendTypeG");
		GSEaseRotator_GSBlendTypeG_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEaseRotator_FunctionAddress, "GSBlendTypeG", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEaseRotator_EaseExp_PropertyAddress, GSEaseRotator_FunctionAddress, "EaseExp");
		GSEaseRotator_EaseExp_Offset = NativeReflectionCached.GetPropertyOffset(GSEaseRotator_FunctionAddress, "EaseExp");
		GSEaseRotator_EaseExp_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEaseRotator_FunctionAddress, "EaseExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEaseRotator_IsShortestPath_PropertyAddress, GSEaseRotator_FunctionAddress, "IsShortestPath");
		GSEaseRotator_IsShortestPath_Offset = NativeReflectionCached.GetPropertyOffset(GSEaseRotator_FunctionAddress, "IsShortestPath");
		GSEaseRotator_IsShortestPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEaseRotator_FunctionAddress, "IsShortestPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEaseRotator_ReturnValue_PropertyAddress, GSEaseRotator_FunctionAddress, "ReturnValue");
		GSEaseRotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSEaseRotator_FunctionAddress, "ReturnValue");
		GSEaseRotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEaseRotator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GSEaseRotator_IsValid = GSEaseRotator_FunctionAddress != IntPtr.Zero && GSEaseRotator_Start_IsValid && GSEaseRotator_End_IsValid && GSEaseRotator_Alpha_IsValid && GSEaseRotator_GSBlendTypeG_IsValid && GSEaseRotator_EaseExp_IsValid && GSEaseRotator_IsShortestPath_IsValid && GSEaseRotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:GSEaseRotator", GSEaseRotator_IsValid);
		GSEase_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSEase");
		GSEase_ParamsSize = NativeReflection.GetFunctionParamsSize(GSEase_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSEase_Start_PropertyAddress, GSEase_FunctionAddress, "Start");
		GSEase_Start_Offset = NativeReflectionCached.GetPropertyOffset(GSEase_FunctionAddress, "Start");
		GSEase_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEase_FunctionAddress, "Start", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEase_End_PropertyAddress, GSEase_FunctionAddress, "End");
		GSEase_End_Offset = NativeReflectionCached.GetPropertyOffset(GSEase_FunctionAddress, "End");
		GSEase_End_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEase_FunctionAddress, "End", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEase_Alpha_PropertyAddress, GSEase_FunctionAddress, "Alpha");
		GSEase_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(GSEase_FunctionAddress, "Alpha");
		GSEase_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEase_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEase_GSBlendTypeG_PropertyAddress, GSEase_FunctionAddress, "GSBlendTypeG");
		GSEase_GSBlendTypeG_Offset = NativeReflectionCached.GetPropertyOffset(GSEase_FunctionAddress, "GSBlendTypeG");
		GSEase_GSBlendTypeG_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEase_FunctionAddress, "GSBlendTypeG", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEase_EaseExp_PropertyAddress, GSEase_FunctionAddress, "EaseExp");
		GSEase_EaseExp_Offset = NativeReflectionCached.GetPropertyOffset(GSEase_FunctionAddress, "EaseExp");
		GSEase_EaseExp_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEase_FunctionAddress, "EaseExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GSEase_ReturnValue_PropertyAddress, GSEase_FunctionAddress, "ReturnValue");
		GSEase_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSEase_FunctionAddress, "ReturnValue");
		GSEase_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSEase_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GSEase_IsValid = GSEase_FunctionAddress != IntPtr.Zero && GSEase_Start_IsValid && GSEase_End_IsValid && GSEase_Alpha_IsValid && GSEase_GSBlendTypeG_IsValid && GSEase_EaseExp_IsValid && GSEase_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:GSEase", GSEase_IsValid);
		GetUMatineeCameraShakeBlendOutTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUMatineeCameraShakeBlendOutTime");
		GetUMatineeCameraShakeBlendOutTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUMatineeCameraShakeBlendOutTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUMatineeCameraShakeBlendOutTime_CameraShake_PropertyAddress, GetUMatineeCameraShakeBlendOutTime_FunctionAddress, "CameraShake");
		GetUMatineeCameraShakeBlendOutTime_CameraShake_Offset = NativeReflectionCached.GetPropertyOffset(GetUMatineeCameraShakeBlendOutTime_FunctionAddress, "CameraShake");
		GetUMatineeCameraShakeBlendOutTime_CameraShake_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUMatineeCameraShakeBlendOutTime_FunctionAddress, "CameraShake", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUMatineeCameraShakeBlendOutTime_ReturnValue_PropertyAddress, GetUMatineeCameraShakeBlendOutTime_FunctionAddress, "ReturnValue");
		GetUMatineeCameraShakeBlendOutTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUMatineeCameraShakeBlendOutTime_FunctionAddress, "ReturnValue");
		GetUMatineeCameraShakeBlendOutTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUMatineeCameraShakeBlendOutTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUMatineeCameraShakeBlendOutTime_IsValid = GetUMatineeCameraShakeBlendOutTime_FunctionAddress != IntPtr.Zero && GetUMatineeCameraShakeBlendOutTime_CameraShake_IsValid && GetUMatineeCameraShakeBlendOutTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:GetUMatineeCameraShakeBlendOutTime", GetUMatineeCameraShakeBlendOutTime_IsValid);
		GetEasingFuncType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEasingFuncType");
		GetEasingFuncType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEasingFuncType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEasingFuncType_GSBlengTypeG_PropertyAddress, GetEasingFuncType_FunctionAddress, "GSBlengTypeG");
		GetEasingFuncType_GSBlengTypeG_Offset = NativeReflectionCached.GetPropertyOffset(GetEasingFuncType_FunctionAddress, "GSBlengTypeG");
		GetEasingFuncType_GSBlengTypeG_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEasingFuncType_FunctionAddress, "GSBlengTypeG", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEasingFuncType_ReturnValue_PropertyAddress, GetEasingFuncType_FunctionAddress, "ReturnValue");
		GetEasingFuncType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEasingFuncType_FunctionAddress, "ReturnValue");
		GetEasingFuncType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEasingFuncType_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetEasingFuncType_IsValid = GetEasingFuncType_FunctionAddress != IntPtr.Zero && GetEasingFuncType_GSBlengTypeG_IsValid && GetEasingFuncType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:GetEasingFuncType", GetEasingFuncType_IsValid);
		GetCurActiveMontagePos_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurActiveMontagePos");
		GetCurActiveMontagePos_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurActiveMontagePos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurActiveMontagePos_CurCharacter_PropertyAddress, GetCurActiveMontagePos_FunctionAddress, "CurCharacter");
		GetCurActiveMontagePos_CurCharacter_Offset = NativeReflectionCached.GetPropertyOffset(GetCurActiveMontagePos_FunctionAddress, "CurCharacter");
		GetCurActiveMontagePos_CurCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurActiveMontagePos_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurActiveMontagePos_ReturnValue_PropertyAddress, GetCurActiveMontagePos_FunctionAddress, "ReturnValue");
		GetCurActiveMontagePos_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurActiveMontagePos_FunctionAddress, "ReturnValue");
		GetCurActiveMontagePos_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurActiveMontagePos_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurActiveMontagePos_IsValid = GetCurActiveMontagePos_FunctionAddress != IntPtr.Zero && GetCurActiveMontagePos_CurCharacter_IsValid && GetCurActiveMontagePos_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:GetCurActiveMontagePos", GetCurActiveMontagePos_IsValid);
		CalcYawRotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcYawRotator");
		CalcYawRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcYawRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcYawRotator_TargetLocation_PropertyAddress, CalcYawRotator_FunctionAddress, "TargetLocation");
		CalcYawRotator_TargetLocation_Offset = NativeReflectionCached.GetPropertyOffset(CalcYawRotator_FunctionAddress, "TargetLocation");
		CalcYawRotator_TargetLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcYawRotator_FunctionAddress, "TargetLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcYawRotator_FromLocation_PropertyAddress, CalcYawRotator_FunctionAddress, "FromLocation");
		CalcYawRotator_FromLocation_Offset = NativeReflectionCached.GetPropertyOffset(CalcYawRotator_FunctionAddress, "FromLocation");
		CalcYawRotator_FromLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcYawRotator_FunctionAddress, "FromLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcYawRotator_ReturnValue_PropertyAddress, CalcYawRotator_FunctionAddress, "ReturnValue");
		CalcYawRotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalcYawRotator_FunctionAddress, "ReturnValue");
		CalcYawRotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcYawRotator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CalcYawRotator_IsValid = CalcYawRotator_FunctionAddress != IntPtr.Zero && CalcYawRotator_TargetLocation_IsValid && CalcYawRotator_FromLocation_IsValid && CalcYawRotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:CalcYawRotator", CalcYawRotator_IsValid);
		CalcDirWithInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcDirWithInput");
		CalcDirWithInput_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcDirWithInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcDirWithInput_CurCharacter_PropertyAddress, CalcDirWithInput_FunctionAddress, "CurCharacter");
		CalcDirWithInput_CurCharacter_Offset = NativeReflectionCached.GetPropertyOffset(CalcDirWithInput_FunctionAddress, "CurCharacter");
		CalcDirWithInput_CurCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDirWithInput_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcDirWithInput_ForwardVal_PropertyAddress, CalcDirWithInput_FunctionAddress, "ForwardVal");
		CalcDirWithInput_ForwardVal_Offset = NativeReflectionCached.GetPropertyOffset(CalcDirWithInput_FunctionAddress, "ForwardVal");
		CalcDirWithInput_ForwardVal_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDirWithInput_FunctionAddress, "ForwardVal", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcDirWithInput_RightVal_PropertyAddress, CalcDirWithInput_FunctionAddress, "RightVal");
		CalcDirWithInput_RightVal_Offset = NativeReflectionCached.GetPropertyOffset(CalcDirWithInput_FunctionAddress, "RightVal");
		CalcDirWithInput_RightVal_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDirWithInput_FunctionAddress, "RightVal", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcDirWithInput_ReturnValue_PropertyAddress, CalcDirWithInput_FunctionAddress, "ReturnValue");
		CalcDirWithInput_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalcDirWithInput_FunctionAddress, "ReturnValue");
		CalcDirWithInput_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDirWithInput_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CalcDirWithInput_IsValid = CalcDirWithInput_FunctionAddress != IntPtr.Zero && CalcDirWithInput_CurCharacter_IsValid && CalcDirWithInput_ForwardVal_IsValid && CalcDirWithInput_RightVal_IsValid && CalcDirWithInput_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:CalcDirWithInput", CalcDirWithInput_IsValid);
		CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcDegreeFromVectorsProjectInXYPlane");
		CalcDegreeFromVectorsProjectInXYPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcDegreeFromVectorsProjectInXYPlane_AVector_PropertyAddress, CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "AVector");
		CalcDegreeFromVectorsProjectInXYPlane_AVector_Offset = NativeReflectionCached.GetPropertyOffset(CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "AVector");
		CalcDegreeFromVectorsProjectInXYPlane_AVector_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "AVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcDegreeFromVectorsProjectInXYPlane_BVector_PropertyAddress, CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "BVector");
		CalcDegreeFromVectorsProjectInXYPlane_BVector_Offset = NativeReflectionCached.GetPropertyOffset(CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "BVector");
		CalcDegreeFromVectorsProjectInXYPlane_BVector_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "BVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_PropertyAddress, CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "ReturnValue");
		CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "ReturnValue");
		CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalcDegreeFromVectorsProjectInXYPlane_IsValid = CalcDegreeFromVectorsProjectInXYPlane_FunctionAddress != IntPtr.Zero && CalcDegreeFromVectorsProjectInXYPlane_AVector_IsValid && CalcDegreeFromVectorsProjectInXYPlane_BVector_IsValid && CalcDegreeFromVectorsProjectInXYPlane_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:CalcDegreeFromVectorsProjectInXYPlane", CalcDegreeFromVectorsProjectInXYPlane_IsValid);
		CalcDegreeFromRotatorsInYaw_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcDegreeFromRotatorsInYaw");
		CalcDegreeFromRotatorsInYaw_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcDegreeFromRotatorsInYaw_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcDegreeFromRotatorsInYaw_ARotator_PropertyAddress, CalcDegreeFromRotatorsInYaw_FunctionAddress, "ARotator");
		CalcDegreeFromRotatorsInYaw_ARotator_Offset = NativeReflectionCached.GetPropertyOffset(CalcDegreeFromRotatorsInYaw_FunctionAddress, "ARotator");
		CalcDegreeFromRotatorsInYaw_ARotator_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDegreeFromRotatorsInYaw_FunctionAddress, "ARotator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcDegreeFromRotatorsInYaw_BRotator_PropertyAddress, CalcDegreeFromRotatorsInYaw_FunctionAddress, "BRotator");
		CalcDegreeFromRotatorsInYaw_BRotator_Offset = NativeReflectionCached.GetPropertyOffset(CalcDegreeFromRotatorsInYaw_FunctionAddress, "BRotator");
		CalcDegreeFromRotatorsInYaw_BRotator_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDegreeFromRotatorsInYaw_FunctionAddress, "BRotator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcDegreeFromRotatorsInYaw_ReturnValue_PropertyAddress, CalcDegreeFromRotatorsInYaw_FunctionAddress, "ReturnValue");
		CalcDegreeFromRotatorsInYaw_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalcDegreeFromRotatorsInYaw_FunctionAddress, "ReturnValue");
		CalcDegreeFromRotatorsInYaw_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcDegreeFromRotatorsInYaw_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalcDegreeFromRotatorsInYaw_IsValid = CalcDegreeFromRotatorsInYaw_FunctionAddress != IntPtr.Zero && CalcDegreeFromRotatorsInYaw_ARotator_IsValid && CalcDegreeFromRotatorsInYaw_BRotator_IsValid && CalcDegreeFromRotatorsInYaw_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUS_UtilComm:CalcDegreeFromRotatorsInYaw", CalcDegreeFromRotatorsInYaw_IsValid);
	}
}
