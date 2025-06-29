using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_AnimDistanceMatchingLibrary", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_AnimDistanceMatchingLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool AdvanceTimeBySpeedMatching_IsValid;

	private static IntPtr AdvanceTimeBySpeedMatching_FunctionAddress;

	private static int AdvanceTimeBySpeedMatching_ParamsSize;

	private static bool AdvanceTimeBySpeedMatching_UpdateContext_IsValid;

	private static FFieldAddress AdvanceTimeBySpeedMatching_UpdateContext_PropertyAddress;

	private static int AdvanceTimeBySpeedMatching_UpdateContext_Offset;

	private static bool AdvanceTimeBySpeedMatching_SequenceEvaluator_IsValid;

	private static FFieldAddress AdvanceTimeBySpeedMatching_SequenceEvaluator_PropertyAddress;

	private static int AdvanceTimeBySpeedMatching_SequenceEvaluator_Offset;

	private static bool AdvanceTimeBySpeedMatching_SpeedToMatch_IsValid;

	private static FFieldAddress AdvanceTimeBySpeedMatching_SpeedToMatch_PropertyAddress;

	private static int AdvanceTimeBySpeedMatching_SpeedToMatch_Offset;

	private static bool AdvanceTimeBySpeedMatching_PlayRateClamp_IsValid;

	private static FFieldAddress AdvanceTimeBySpeedMatching_PlayRateClamp_PropertyAddress;

	private static int AdvanceTimeBySpeedMatching_PlayRateClamp_Offset;

	private static bool AdvanceTimeBySpeedMatching_ReturnValue_IsValid;

	private static FFieldAddress AdvanceTimeBySpeedMatching_ReturnValue_PropertyAddress;

	private static int AdvanceTimeBySpeedMatching_ReturnValue_Offset;

	private static bool AdvanceTimeByDistanceMatchToTarget_IsValid;

	private static IntPtr AdvanceTimeByDistanceMatchToTarget_FunctionAddress;

	private static int AdvanceTimeByDistanceMatchToTarget_ParamsSize;

	private static bool AdvanceTimeByDistanceMatchToTarget_UpdateContext_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatchToTarget_UpdateContext_PropertyAddress;

	private static int AdvanceTimeByDistanceMatchToTarget_UpdateContext_Offset;

	private static bool AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_PropertyAddress;

	private static int AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_Offset;

	private static bool AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_PropertyAddress;

	private static int AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_Offset;

	private static bool AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_PropertyAddress;

	private static int AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_Offset;

	private static bool AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_PropertyAddress;

	private static int AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_Offset;

	private static bool AdvanceTimeByDistanceMatchToTarget_ReturnValue_IsValid;

	private static FFieldAddress AdvanceTimeByDistanceMatchToTarget_ReturnValue_PropertyAddress;

	private static int AdvanceTimeByDistanceMatchToTarget_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimDistanceMatchingLibrary:AdvanceTimeBySpeedMatching")]
	public unsafe static FSequenceEvaluatorReference AdvanceTimeBySpeedMatching(FAnimUpdateContext UpdateContext, FSequenceEvaluatorReference SequenceEvaluator, float SpeedToMatch, FVector2D PlayRateClamp)
	{
		if (!AdvanceTimeBySpeedMatching_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimDistanceMatchingLibrary:AdvanceTimeBySpeedMatching");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdvanceTimeBySpeedMatching_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdvanceTimeBySpeedMatching_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AdvanceTimeBySpeedMatching_UpdateContext_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, AdvanceTimeBySpeedMatching_UpdateContext_Offset), 0, AdvanceTimeBySpeedMatching_UpdateContext_PropertyAddress.Address, UpdateContext);
		NativeReflection.InitializeValue_InContainer(AdvanceTimeBySpeedMatching_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, AdvanceTimeBySpeedMatching_SequenceEvaluator_Offset), 0, AdvanceTimeBySpeedMatching_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdvanceTimeBySpeedMatching_SpeedToMatch_Offset), 0, AdvanceTimeBySpeedMatching_SpeedToMatch_PropertyAddress.Address, SpeedToMatch);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AdvanceTimeBySpeedMatching_PlayRateClamp_Offset), 0, AdvanceTimeBySpeedMatching_PlayRateClamp_PropertyAddress.Address, PlayRateClamp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AdvanceTimeBySpeedMatching_FunctionAddress, intPtr, AdvanceTimeBySpeedMatching_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AdvanceTimeBySpeedMatching_UpdateContext_PropertyAddress.Address, intPtr);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, AdvanceTimeBySpeedMatching_ReturnValue_Offset), 0, AdvanceTimeBySpeedMatching_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimDistanceMatchingLibrary:AdvanceTimeByDistanceMatchToTarget")]
	public unsafe static FSequenceEvaluatorReference AdvanceTimeByDistanceMatchToTarget(FAnimUpdateContext UpdateContext, FSequenceEvaluatorReference SequenceEvaluator, float DistanceToTarget, FName DistanceCurveName, FVector2D PlayRateClamp)
	{
		if (!AdvanceTimeByDistanceMatchToTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimDistanceMatchingLibrary:AdvanceTimeByDistanceMatchToTarget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdvanceTimeByDistanceMatchToTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdvanceTimeByDistanceMatchToTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AdvanceTimeByDistanceMatchToTarget_UpdateContext_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatchToTarget_UpdateContext_Offset), 0, AdvanceTimeByDistanceMatchToTarget_UpdateContext_PropertyAddress.Address, UpdateContext);
		NativeReflection.InitializeValue_InContainer(AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_Offset), 0, AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_Offset), 0, AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_PropertyAddress.Address, DistanceToTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_Offset), 0, AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_PropertyAddress.Address, DistanceCurveName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_Offset), 0, AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_PropertyAddress.Address, PlayRateClamp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AdvanceTimeByDistanceMatchToTarget_FunctionAddress, intPtr, AdvanceTimeByDistanceMatchToTarget_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AdvanceTimeByDistanceMatchToTarget_UpdateContext_PropertyAddress.Address, intPtr);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, AdvanceTimeByDistanceMatchToTarget_ReturnValue_Offset), 0, AdvanceTimeByDistanceMatchToTarget_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_AnimDistanceMatchingLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_AnimDistanceMatchingLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_AnimDistanceMatchingLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_AnimDistanceMatchingLibrary");
		AdvanceTimeBySpeedMatching_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AdvanceTimeBySpeedMatching");
		AdvanceTimeBySpeedMatching_ParamsSize = NativeReflection.GetFunctionParamsSize(AdvanceTimeBySpeedMatching_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeBySpeedMatching_UpdateContext_PropertyAddress, AdvanceTimeBySpeedMatching_FunctionAddress, "UpdateContext");
		AdvanceTimeBySpeedMatching_UpdateContext_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeBySpeedMatching_FunctionAddress, "UpdateContext");
		AdvanceTimeBySpeedMatching_UpdateContext_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeBySpeedMatching_FunctionAddress, "UpdateContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeBySpeedMatching_SequenceEvaluator_PropertyAddress, AdvanceTimeBySpeedMatching_FunctionAddress, "SequenceEvaluator");
		AdvanceTimeBySpeedMatching_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeBySpeedMatching_FunctionAddress, "SequenceEvaluator");
		AdvanceTimeBySpeedMatching_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeBySpeedMatching_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeBySpeedMatching_SpeedToMatch_PropertyAddress, AdvanceTimeBySpeedMatching_FunctionAddress, "SpeedToMatch");
		AdvanceTimeBySpeedMatching_SpeedToMatch_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeBySpeedMatching_FunctionAddress, "SpeedToMatch");
		AdvanceTimeBySpeedMatching_SpeedToMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeBySpeedMatching_FunctionAddress, "SpeedToMatch", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeBySpeedMatching_PlayRateClamp_PropertyAddress, AdvanceTimeBySpeedMatching_FunctionAddress, "PlayRateClamp");
		AdvanceTimeBySpeedMatching_PlayRateClamp_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeBySpeedMatching_FunctionAddress, "PlayRateClamp");
		AdvanceTimeBySpeedMatching_PlayRateClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeBySpeedMatching_FunctionAddress, "PlayRateClamp", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeBySpeedMatching_ReturnValue_PropertyAddress, AdvanceTimeBySpeedMatching_FunctionAddress, "ReturnValue");
		AdvanceTimeBySpeedMatching_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeBySpeedMatching_FunctionAddress, "ReturnValue");
		AdvanceTimeBySpeedMatching_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeBySpeedMatching_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AdvanceTimeBySpeedMatching_IsValid = AdvanceTimeBySpeedMatching_FunctionAddress != IntPtr.Zero && AdvanceTimeBySpeedMatching_UpdateContext_IsValid && AdvanceTimeBySpeedMatching_SequenceEvaluator_IsValid && AdvanceTimeBySpeedMatching_SpeedToMatch_IsValid && AdvanceTimeBySpeedMatching_PlayRateClamp_IsValid && AdvanceTimeBySpeedMatching_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimDistanceMatchingLibrary:AdvanceTimeBySpeedMatching", AdvanceTimeBySpeedMatching_IsValid);
		AdvanceTimeByDistanceMatchToTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AdvanceTimeByDistanceMatchToTarget");
		AdvanceTimeByDistanceMatchToTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(AdvanceTimeByDistanceMatchToTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatchToTarget_UpdateContext_PropertyAddress, AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "UpdateContext");
		AdvanceTimeByDistanceMatchToTarget_UpdateContext_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "UpdateContext");
		AdvanceTimeByDistanceMatchToTarget_UpdateContext_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "UpdateContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_PropertyAddress, AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "SequenceEvaluator");
		AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "SequenceEvaluator");
		AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_PropertyAddress, AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "DistanceToTarget");
		AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "DistanceToTarget");
		AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "DistanceToTarget", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_PropertyAddress, AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "DistanceCurveName");
		AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "DistanceCurveName");
		AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "DistanceCurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_PropertyAddress, AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "PlayRateClamp");
		AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "PlayRateClamp");
		AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "PlayRateClamp", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTimeByDistanceMatchToTarget_ReturnValue_PropertyAddress, AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "ReturnValue");
		AdvanceTimeByDistanceMatchToTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "ReturnValue");
		AdvanceTimeByDistanceMatchToTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTimeByDistanceMatchToTarget_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AdvanceTimeByDistanceMatchToTarget_IsValid = AdvanceTimeByDistanceMatchToTarget_FunctionAddress != IntPtr.Zero && AdvanceTimeByDistanceMatchToTarget_UpdateContext_IsValid && AdvanceTimeByDistanceMatchToTarget_SequenceEvaluator_IsValid && AdvanceTimeByDistanceMatchToTarget_DistanceToTarget_IsValid && AdvanceTimeByDistanceMatchToTarget_DistanceCurveName_IsValid && AdvanceTimeByDistanceMatchToTarget_PlayRateClamp_IsValid && AdvanceTimeByDistanceMatchToTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimDistanceMatchingLibrary:AdvanceTimeByDistanceMatchToTarget", AdvanceTimeByDistanceMatchToTarget_IsValid);
	}
}
