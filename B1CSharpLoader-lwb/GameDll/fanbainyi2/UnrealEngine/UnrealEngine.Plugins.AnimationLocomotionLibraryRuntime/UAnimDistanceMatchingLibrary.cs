using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationLocomotionLibraryRuntime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary", "AnimationLocomotionLibraryRuntime", UnrealModuleType.EnginePlugin)]
public class UAnimDistanceMatchingLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetPlayrateToMatchSpeed_IsValid;

	private static IntPtr SetPlayrateToMatchSpeed_FunctionAddress;

	private static int SetPlayrateToMatchSpeed_ParamsSize;

	private static bool SetPlayrateToMatchSpeed_SequencePlayer_IsValid;

	private static FFieldAddress SetPlayrateToMatchSpeed_SequencePlayer_PropertyAddress;

	private static int SetPlayrateToMatchSpeed_SequencePlayer_Offset;

	private static bool SetPlayrateToMatchSpeed_SpeedToMatch_IsValid;

	private static FFieldAddress SetPlayrateToMatchSpeed_SpeedToMatch_PropertyAddress;

	private static int SetPlayrateToMatchSpeed_SpeedToMatch_Offset;

	private static bool SetPlayrateToMatchSpeed_PlayRateClamp_IsValid;

	private static FFieldAddress SetPlayrateToMatchSpeed_PlayRateClamp_PropertyAddress;

	private static int SetPlayrateToMatchSpeed_PlayRateClamp_Offset;

	private static bool SetPlayrateToMatchSpeed_ReturnValue_IsValid;

	private static FFieldAddress SetPlayrateToMatchSpeed_ReturnValue_PropertyAddress;

	private static int SetPlayrateToMatchSpeed_ReturnValue_Offset;

	private static bool DistanceMatchToTarget_IsValid;

	private static IntPtr DistanceMatchToTarget_FunctionAddress;

	private static int DistanceMatchToTarget_ParamsSize;

	private static bool DistanceMatchToTarget_SequenceEvaluator_IsValid;

	private static FFieldAddress DistanceMatchToTarget_SequenceEvaluator_PropertyAddress;

	private static int DistanceMatchToTarget_SequenceEvaluator_Offset;

	private static bool DistanceMatchToTarget_DistanceToTarget_IsValid;

	private static FFieldAddress DistanceMatchToTarget_DistanceToTarget_PropertyAddress;

	private static int DistanceMatchToTarget_DistanceToTarget_Offset;

	private static bool DistanceMatchToTarget_DistanceCurveName_IsValid;

	private static FFieldAddress DistanceMatchToTarget_DistanceCurveName_PropertyAddress;

	private static int DistanceMatchToTarget_DistanceCurveName_Offset;

	private static bool DistanceMatchToTarget_ReturnValue_IsValid;

	private static FFieldAddress DistanceMatchToTarget_ReturnValue_PropertyAddress;

	private static int DistanceMatchToTarget_ReturnValue_Offset;

	private static bool AdvanceTimeByDistanceMatching_IsValid;

	private static IntPtr AdvanceTimeByDistanceMatching_FunctionAddress;

	private static int AdvanceTimeByDistanceMatching_ParamsSize;

	private static bool AdvanceTimeByDistanceMatching_UpdateContext_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatching_UpdateContext_PropertyAddress;

	private static int AdvanceTimeByDistanceMatching_UpdateContext_Offset;

	private static bool AdvanceTimeByDistanceMatching_SequenceEvaluator_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatching_SequenceEvaluator_PropertyAddress;

	private static int AdvanceTimeByDistanceMatching_SequenceEvaluator_Offset;

	private static bool AdvanceTimeByDistanceMatching_DistanceTraveled_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatching_DistanceTraveled_PropertyAddress;

	private static int AdvanceTimeByDistanceMatching_DistanceTraveled_Offset;

	private static bool AdvanceTimeByDistanceMatching_DistanceCurveName_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatching_DistanceCurveName_PropertyAddress;

	private static int AdvanceTimeByDistanceMatching_DistanceCurveName_Offset;

	private static bool AdvanceTimeByDistanceMatching_PlayRateClamp_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatching_PlayRateClamp_PropertyAddress;

	private static int AdvanceTimeByDistanceMatching_PlayRateClamp_Offset;

	private static bool AdvanceTimeByDistanceMatching_ReturnValue_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatching_ReturnValue_PropertyAddress;

	private static int AdvanceTimeByDistanceMatching_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:SetPlayrateToMatchSpeed")]
	public unsafe static FSequencePlayerReference SetPlayrateToMatchSpeed(FSequencePlayerReference SequencePlayer, float SpeedToMatch, FVector2D PlayRateClamp)
	{
		if (!SetPlayrateToMatchSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:SetPlayrateToMatchSpeed");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayrateToMatchSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayrateToMatchSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPlayrateToMatchSpeed_SequencePlayer_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequencePlayerReference>.ToNative(IntPtr.Add(intPtr, SetPlayrateToMatchSpeed_SequencePlayer_Offset), 0, SetPlayrateToMatchSpeed_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayrateToMatchSpeed_SpeedToMatch_Offset), 0, SetPlayrateToMatchSpeed_SpeedToMatch_PropertyAddress.Address, SpeedToMatch);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetPlayrateToMatchSpeed_PlayRateClamp_Offset), 0, SetPlayrateToMatchSpeed_PlayRateClamp_PropertyAddress.Address, PlayRateClamp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPlayrateToMatchSpeed_FunctionAddress, intPtr, SetPlayrateToMatchSpeed_ParamsSize);
		return StructAsClassMarshaler<FSequencePlayerReference>.FromNative(IntPtr.Add(intPtr, SetPlayrateToMatchSpeed_ReturnValue_Offset), 0, SetPlayrateToMatchSpeed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:DistanceMatchToTarget")]
	public unsafe static FSequenceEvaluatorReference DistanceMatchToTarget(FSequenceEvaluatorReference SequenceEvaluator, float DistanceToTarget, FName DistanceCurveName)
	{
		if (!DistanceMatchToTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:DistanceMatchToTarget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DistanceMatchToTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DistanceMatchToTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DistanceMatchToTarget_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, DistanceMatchToTarget_SequenceEvaluator_Offset), 0, DistanceMatchToTarget_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DistanceMatchToTarget_DistanceToTarget_Offset), 0, DistanceMatchToTarget_DistanceToTarget_PropertyAddress.Address, DistanceToTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DistanceMatchToTarget_DistanceCurveName_Offset), 0, DistanceMatchToTarget_DistanceCurveName_PropertyAddress.Address, DistanceCurveName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DistanceMatchToTarget_FunctionAddress, intPtr, DistanceMatchToTarget_ParamsSize);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, DistanceMatchToTarget_ReturnValue_Offset), 0, DistanceMatchToTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:AdvanceTimeByDistanceMatching")]
	public unsafe static FSequenceEvaluatorReference AdvanceTimeByDistanceMatching(FAnimUpdateContext UpdateContext, FSequenceEvaluatorReference SequenceEvaluator, float DistanceTraveled, FName DistanceCurveName, FVector2D PlayRateClamp)
	{
		if (!AdvanceTimeByDistanceMatching_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:AdvanceTimeByDistanceMatching");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdvanceTimeByDistanceMatching_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdvanceTimeByDistanceMatching_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AdvanceTimeByDistanceMatching_UpdateContext_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatching_UpdateContext_Offset), 0, AdvanceTimeByDistanceMatching_UpdateContext_PropertyAddress.Address, UpdateContext);
		NativeReflection.InitializeValue_InContainer(AdvanceTimeByDistanceMatching_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatching_SequenceEvaluator_Offset), 0, AdvanceTimeByDistanceMatching_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatching_DistanceTraveled_Offset), 0, AdvanceTimeByDistanceMatching_DistanceTraveled_PropertyAddress.Address, DistanceTraveled);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatching_DistanceCurveName_Offset), 0, AdvanceTimeByDistanceMatching_DistanceCurveName_PropertyAddress.Address, DistanceCurveName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatching_PlayRateClamp_Offset), 0, AdvanceTimeByDistanceMatching_PlayRateClamp_PropertyAddress.Address, PlayRateClamp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AdvanceTimeByDistanceMatching_FunctionAddress, intPtr, AdvanceTimeByDistanceMatching_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AdvanceTimeByDistanceMatching_UpdateContext_PropertyAddress.Address, intPtr);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatching_ReturnValue_Offset), 0, AdvanceTimeByDistanceMatching_ReturnValue_PropertyAddress.Address);
	}

	static UAnimDistanceMatchingLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimDistanceMatchingLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimDistanceMatchingLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary");
		SetPlayrateToMatchSpeed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPlayrateToMatchSpeed");
		SetPlayrateToMatchSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayrateToMatchSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayrateToMatchSpeed_SequencePlayer_PropertyAddress, SetPlayrateToMatchSpeed_FunctionAddress, "SequencePlayer");
		SetPlayrateToMatchSpeed_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayrateToMatchSpeed_FunctionAddress, "SequencePlayer");
		SetPlayrateToMatchSpeed_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayrateToMatchSpeed_FunctionAddress, "SequencePlayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlayrateToMatchSpeed_SpeedToMatch_PropertyAddress, SetPlayrateToMatchSpeed_FunctionAddress, "SpeedToMatch");
		SetPlayrateToMatchSpeed_SpeedToMatch_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayrateToMatchSpeed_FunctionAddress, "SpeedToMatch");
		SetPlayrateToMatchSpeed_SpeedToMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayrateToMatchSpeed_FunctionAddress, "SpeedToMatch", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlayrateToMatchSpeed_PlayRateClamp_PropertyAddress, SetPlayrateToMatchSpeed_FunctionAddress, "PlayRateClamp");
		SetPlayrateToMatchSpeed_PlayRateClamp_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayrateToMatchSpeed_FunctionAddress, "PlayRateClamp");
		SetPlayrateToMatchSpeed_PlayRateClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayrateToMatchSpeed_FunctionAddress, "PlayRateClamp", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlayrateToMatchSpeed_ReturnValue_PropertyAddress, SetPlayrateToMatchSpeed_FunctionAddress, "ReturnValue");
		SetPlayrateToMatchSpeed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayrateToMatchSpeed_FunctionAddress, "ReturnValue");
		SetPlayrateToMatchSpeed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayrateToMatchSpeed_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetPlayrateToMatchSpeed_IsValid = SetPlayrateToMatchSpeed_FunctionAddress != IntPtr.Zero && SetPlayrateToMatchSpeed_SequencePlayer_IsValid && SetPlayrateToMatchSpeed_SpeedToMatch_IsValid && SetPlayrateToMatchSpeed_PlayRateClamp_IsValid && SetPlayrateToMatchSpeed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:SetPlayrateToMatchSpeed", SetPlayrateToMatchSpeed_IsValid);
		DistanceMatchToTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DistanceMatchToTarget");
		DistanceMatchToTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(DistanceMatchToTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DistanceMatchToTarget_SequenceEvaluator_PropertyAddress, DistanceMatchToTarget_FunctionAddress, "SequenceEvaluator");
		DistanceMatchToTarget_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(DistanceMatchToTarget_FunctionAddress, "SequenceEvaluator");
		DistanceMatchToTarget_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceMatchToTarget_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceMatchToTarget_DistanceToTarget_PropertyAddress, DistanceMatchToTarget_FunctionAddress, "DistanceToTarget");
		DistanceMatchToTarget_DistanceToTarget_Offset = NativeReflectionCached.GetPropertyOffset(DistanceMatchToTarget_FunctionAddress, "DistanceToTarget");
		DistanceMatchToTarget_DistanceToTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceMatchToTarget_FunctionAddress, "DistanceToTarget", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceMatchToTarget_DistanceCurveName_PropertyAddress, DistanceMatchToTarget_FunctionAddress, "DistanceCurveName");
		DistanceMatchToTarget_DistanceCurveName_Offset = NativeReflectionCached.GetPropertyOffset(DistanceMatchToTarget_FunctionAddress, "DistanceCurveName");
		DistanceMatchToTarget_DistanceCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceMatchToTarget_FunctionAddress, "DistanceCurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceMatchToTarget_ReturnValue_PropertyAddress, DistanceMatchToTarget_FunctionAddress, "ReturnValue");
		DistanceMatchToTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DistanceMatchToTarget_FunctionAddress, "ReturnValue");
		DistanceMatchToTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceMatchToTarget_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		DistanceMatchToTarget_IsValid = DistanceMatchToTarget_FunctionAddress != IntPtr.Zero && DistanceMatchToTarget_SequenceEvaluator_IsValid && DistanceMatchToTarget_DistanceToTarget_IsValid && DistanceMatchToTarget_DistanceCurveName_IsValid && DistanceMatchToTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:DistanceMatchToTarget", DistanceMatchToTarget_IsValid);
		AdvanceTimeByDistanceMatching_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AdvanceTimeByDistanceMatching");
		AdvanceTimeByDistanceMatching_ParamsSize = NativeReflection.GetFunctionParamsSize(AdvanceTimeByDistanceMatching_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatching_UpdateContext_PropertyAddress, AdvanceTimeByDistanceMatching_FunctionAddress, "UpdateContext");
		AdvanceTimeByDistanceMatching_UpdateContext_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatching_FunctionAddress, "UpdateContext");
		AdvanceTimeByDistanceMatching_UpdateContext_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatching_FunctionAddress, "UpdateContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatching_SequenceEvaluator_PropertyAddress, AdvanceTimeByDistanceMatching_FunctionAddress, "SequenceEvaluator");
		AdvanceTimeByDistanceMatching_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatching_FunctionAddress, "SequenceEvaluator");
		AdvanceTimeByDistanceMatching_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatching_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatching_DistanceTraveled_PropertyAddress, AdvanceTimeByDistanceMatching_FunctionAddress, "DistanceTraveled");
		AdvanceTimeByDistanceMatching_DistanceTraveled_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatching_FunctionAddress, "DistanceTraveled");
		AdvanceTimeByDistanceMatching_DistanceTraveled_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatching_FunctionAddress, "DistanceTraveled", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatching_DistanceCurveName_PropertyAddress, AdvanceTimeByDistanceMatching_FunctionAddress, "DistanceCurveName");
		AdvanceTimeByDistanceMatching_DistanceCurveName_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatching_FunctionAddress, "DistanceCurveName");
		AdvanceTimeByDistanceMatching_DistanceCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatching_FunctionAddress, "DistanceCurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatching_PlayRateClamp_PropertyAddress, AdvanceTimeByDistanceMatching_FunctionAddress, "PlayRateClamp");
		AdvanceTimeByDistanceMatching_PlayRateClamp_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatching_FunctionAddress, "PlayRateClamp");
		AdvanceTimeByDistanceMatching_PlayRateClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatching_FunctionAddress, "PlayRateClamp", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatching_ReturnValue_PropertyAddress, AdvanceTimeByDistanceMatching_FunctionAddress, "ReturnValue");
		AdvanceTimeByDistanceMatching_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatching_FunctionAddress, "ReturnValue");
		AdvanceTimeByDistanceMatching_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatching_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AdvanceTimeByDistanceMatching_IsValid = AdvanceTimeByDistanceMatching_FunctionAddress != IntPtr.Zero && AdvanceTimeByDistanceMatching_UpdateContext_IsValid && AdvanceTimeByDistanceMatching_SequenceEvaluator_IsValid && AdvanceTimeByDistanceMatching_DistanceTraveled_IsValid && AdvanceTimeByDistanceMatching_DistanceCurveName_IsValid && AdvanceTimeByDistanceMatching_PlayRateClamp_IsValid && AdvanceTimeByDistanceMatching_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationLocomotionLibraryRuntime.AnimDistanceMatchingLibrary:AdvanceTimeByDistanceMatching", AdvanceTimeByDistanceMatching_IsValid);
	}
}
