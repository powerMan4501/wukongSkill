using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_AIFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_AIFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SinglePerceptionSetEnable_IsValid;

	private static IntPtr SinglePerceptionSetEnable_FunctionAddress;

	private static int SinglePerceptionSetEnable_ParamsSize;

	private static bool SinglePerceptionSetEnable_PerceptionComp_IsValid;

	private static FFieldAddress SinglePerceptionSetEnable_PerceptionComp_PropertyAddress;

	private static int SinglePerceptionSetEnable_PerceptionComp_Offset;

	private static bool SinglePerceptionSetEnable_IsHearing_IsValid;

	private static FFieldAddress SinglePerceptionSetEnable_IsHearing_PropertyAddress;

	private static int SinglePerceptionSetEnable_IsHearing_Offset;

	private static bool SinglePerceptionSetEnable_bEnable_IsValid;

	private static FFieldAddress SinglePerceptionSetEnable_bEnable_PropertyAddress;

	private static int SinglePerceptionSetEnable_bEnable_Offset;

	private static bool SetPerceptionForgetAll_IsValid;

	private static IntPtr SetPerceptionForgetAll_FunctionAddress;

	private static int SetPerceptionForgetAll_ParamsSize;

	private static bool SetPerceptionForgetAll_PerceptionComp_IsValid;

	private static FFieldAddress SetPerceptionForgetAll_PerceptionComp_PropertyAddress;

	private static int SetPerceptionForgetAll_PerceptionComp_Offset;

	private static bool SetAISenseConfig_IsValid;

	private static IntPtr SetAISenseConfig_FunctionAddress;

	private static int SetAISenseConfig_ParamsSize;

	private static bool SetAISenseConfig_PerceptionComp_IsValid;

	private static FFieldAddress SetAISenseConfig_PerceptionComp_PropertyAddress;

	private static int SetAISenseConfig_PerceptionComp_Offset;

	private static bool SetAISenseConfig_HearRange_IsValid;

	private static FFieldAddress SetAISenseConfig_HearRange_PropertyAddress;

	private static int SetAISenseConfig_HearRange_Offset;

	private static bool SetAISenseConfig_SightRange_IsValid;

	private static FFieldAddress SetAISenseConfig_SightRange_PropertyAddress;

	private static int SetAISenseConfig_SightRange_Offset;

	private static bool SetAISenseConfig_LoseSightRange_IsValid;

	private static FFieldAddress SetAISenseConfig_LoseSightRange_PropertyAddress;

	private static int SetAISenseConfig_LoseSightRange_Offset;

	private static bool SetAISenseConfig_VisionAngleDegrees_IsValid;

	private static FFieldAddress SetAISenseConfig_VisionAngleDegrees_PropertyAddress;

	private static int SetAISenseConfig_VisionAngleDegrees_Offset;

	private static bool SetAISenseConfig_ASRangeFromLastSeenLoc_IsValid;

	private static FFieldAddress SetAISenseConfig_ASRangeFromLastSeenLoc_PropertyAddress;

	private static int SetAISenseConfig_ASRangeFromLastSeenLoc_Offset;

	private static bool SetAISenseConfig_IsSightDominantSense_IsValid;

	private static FFieldAddress SetAISenseConfig_IsSightDominantSense_PropertyAddress;

	private static int SetAISenseConfig_IsSightDominantSense_Offset;

	private static bool SetAISenseConfig_IsHearingSet_IsValid;

	private static FFieldAddress SetAISenseConfig_IsHearingSet_PropertyAddress;

	private static int SetAISenseConfig_IsHearingSet_Offset;

	private static bool SetAISenseConfig_IsSightSet_IsValid;

	private static FFieldAddress SetAISenseConfig_IsSightSet_PropertyAddress;

	private static int SetAISenseConfig_IsSightSet_Offset;

	private static bool SetAIBTStop_IsValid;

	private static IntPtr SetAIBTStop_FunctionAddress;

	private static int SetAIBTStop_ParamsSize;

	private static bool SetAIBTStop_BTComp_IsValid;

	private static FFieldAddress SetAIBTStop_BTComp_PropertyAddress;

	private static int SetAIBTStop_BTComp_Offset;

	private static bool SetAIBTPause_IsValid;

	private static IntPtr SetAIBTPause_FunctionAddress;

	private static int SetAIBTPause_ParamsSize;

	private static bool SetAIBTPause_BrainComponent_IsValid;

	private static FFieldAddress SetAIBTPause_BrainComponent_PropertyAddress;

	private static int SetAIBTPause_BrainComponent_Offset;

	private static bool SetAIBTPause_bEnable_IsValid;

	private static FFieldAddress SetAIBTPause_bEnable_PropertyAddress;

	private static int SetAIBTPause_bEnable_Offset;

	private static bool ListenerForgetsActor_IsValid;

	private static IntPtr ListenerForgetsActor_FunctionAddress;

	private static int ListenerForgetsActor_ParamsSize;

	private static bool ListenerForgetsActor_PerceptionComp_IsValid;

	private static FFieldAddress ListenerForgetsActor_PerceptionComp_PropertyAddress;

	private static int ListenerForgetsActor_PerceptionComp_Offset;

	private static bool ListenerForgetsActor_ActorToForget_IsValid;

	private static FFieldAddress ListenerForgetsActor_ActorToForget_PropertyAddress;

	private static int ListenerForgetsActor_ActorToForget_Offset;

	private static bool AISetBT_IsValid;

	private static IntPtr AISetBT_FunctionAddress;

	private static int AISetBT_ParamsSize;

	private static bool AISetBT_Actor_IsValid;

	private static FFieldAddress AISetBT_Actor_PropertyAddress;

	private static int AISetBT_Actor_Offset;

	private static bool AISetBT_BTAsset_IsValid;

	private static FFieldAddress AISetBT_BTAsset_PropertyAddress;

	private static int AISetBT_BTAsset_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AIFuncLib:SinglePerceptionSetEnable")]
	public unsafe static void SinglePerceptionSetEnable(UAIPerceptionComponent PerceptionComp, bool IsHearing, bool bEnable)
	{
		if (!SinglePerceptionSetEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AIFuncLib:SinglePerceptionSetEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SinglePerceptionSetEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SinglePerceptionSetEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, SinglePerceptionSetEnable_PerceptionComp_Offset), 0, SinglePerceptionSetEnable_PerceptionComp_PropertyAddress.Address, PerceptionComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SinglePerceptionSetEnable_IsHearing_Offset), 0, SinglePerceptionSetEnable_IsHearing_PropertyAddress.Address, IsHearing);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SinglePerceptionSetEnable_bEnable_Offset), 0, SinglePerceptionSetEnable_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SinglePerceptionSetEnable_FunctionAddress, intPtr, SinglePerceptionSetEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AIFuncLib:SetPerceptionForgetAll")]
	public unsafe static void SetPerceptionForgetAll(UAIPerceptionComponent PerceptionComp)
	{
		if (!SetPerceptionForgetAll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AIFuncLib:SetPerceptionForgetAll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPerceptionForgetAll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPerceptionForgetAll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, SetPerceptionForgetAll_PerceptionComp_Offset), 0, SetPerceptionForgetAll_PerceptionComp_PropertyAddress.Address, PerceptionComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPerceptionForgetAll_FunctionAddress, intPtr, SetPerceptionForgetAll_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AIFuncLib:SetAISenseConfig")]
	public unsafe static void SetAISenseConfig(UAIPerceptionComponent PerceptionComp, float HearRange, float SightRange, float LoseSightRange, float VisionAngleDegrees, float ASRangeFromLastSeenLoc, bool IsSightDominantSense, out bool IsHearingSet, out bool IsSightSet)
	{
		if (!SetAISenseConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AIFuncLib:SetAISenseConfig");
			IsHearingSet = false;
			IsSightSet = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAISenseConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAISenseConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, SetAISenseConfig_PerceptionComp_Offset), 0, SetAISenseConfig_PerceptionComp_PropertyAddress.Address, PerceptionComp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAISenseConfig_HearRange_Offset), 0, SetAISenseConfig_HearRange_PropertyAddress.Address, HearRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAISenseConfig_SightRange_Offset), 0, SetAISenseConfig_SightRange_PropertyAddress.Address, SightRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAISenseConfig_LoseSightRange_Offset), 0, SetAISenseConfig_LoseSightRange_PropertyAddress.Address, LoseSightRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAISenseConfig_VisionAngleDegrees_Offset), 0, SetAISenseConfig_VisionAngleDegrees_PropertyAddress.Address, VisionAngleDegrees);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAISenseConfig_ASRangeFromLastSeenLoc_Offset), 0, SetAISenseConfig_ASRangeFromLastSeenLoc_PropertyAddress.Address, ASRangeFromLastSeenLoc);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAISenseConfig_IsSightDominantSense_Offset), 0, SetAISenseConfig_IsSightDominantSense_PropertyAddress.Address, IsSightDominantSense);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAISenseConfig_FunctionAddress, intPtr, SetAISenseConfig_ParamsSize);
		IsHearingSet = BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAISenseConfig_IsHearingSet_Offset), 0, SetAISenseConfig_IsHearingSet_PropertyAddress.Address);
		IsSightSet = BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAISenseConfig_IsSightSet_Offset), 0, SetAISenseConfig_IsSightSet_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AIFuncLib:SetAIBTStop")]
	public unsafe static void SetAIBTStop(UBehaviorTreeComponent BTComp)
	{
		if (!SetAIBTStop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AIFuncLib:SetAIBTStop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAIBTStop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAIBTStop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBehaviorTreeComponent>.ToNative(IntPtr.Add(intPtr, SetAIBTStop_BTComp_Offset), 0, SetAIBTStop_BTComp_PropertyAddress.Address, BTComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAIBTStop_FunctionAddress, intPtr, SetAIBTStop_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AIFuncLib:SetAIBTPause")]
	public unsafe static void SetAIBTPause(UBrainComponent BrainComponent, bool bEnable)
	{
		if (!SetAIBTPause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AIFuncLib:SetAIBTPause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAIBTPause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAIBTPause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBrainComponent>.ToNative(IntPtr.Add(intPtr, SetAIBTPause_BrainComponent_Offset), 0, SetAIBTPause_BrainComponent_PropertyAddress.Address, BrainComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAIBTPause_bEnable_Offset), 0, SetAIBTPause_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAIBTPause_FunctionAddress, intPtr, SetAIBTPause_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AIFuncLib:ListenerForgetsActor")]
	public unsafe static void ListenerForgetsActor(UAIPerceptionComponent PerceptionComp, AActor ActorToForget)
	{
		if (!ListenerForgetsActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AIFuncLib:ListenerForgetsActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ListenerForgetsActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ListenerForgetsActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, ListenerForgetsActor_PerceptionComp_Offset), 0, ListenerForgetsActor_PerceptionComp_PropertyAddress.Address, PerceptionComp);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ListenerForgetsActor_ActorToForget_Offset), 0, ListenerForgetsActor_ActorToForget_PropertyAddress.Address, ActorToForget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ListenerForgetsActor_FunctionAddress, intPtr, ListenerForgetsActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AIFuncLib:AISetBT")]
	public unsafe static void AISetBT(AActor Actor, UBehaviorTree BTAsset)
	{
		if (!AISetBT_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AIFuncLib:AISetBT");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AISetBT_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AISetBT_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AISetBT_Actor_Offset), 0, AISetBT_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(intPtr, AISetBT_BTAsset_Offset), 0, AISetBT_BTAsset_PropertyAddress.Address, BTAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AISetBT_FunctionAddress, intPtr, AISetBT_ParamsSize);
	}

	static UGSE_AIFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_AIFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_AIFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_AIFuncLib");
		SinglePerceptionSetEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SinglePerceptionSetEnable");
		SinglePerceptionSetEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SinglePerceptionSetEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SinglePerceptionSetEnable_PerceptionComp_PropertyAddress, SinglePerceptionSetEnable_FunctionAddress, "PerceptionComp");
		SinglePerceptionSetEnable_PerceptionComp_Offset = NativeReflectionCached.GetPropertyOffset(SinglePerceptionSetEnable_FunctionAddress, "PerceptionComp");
		SinglePerceptionSetEnable_PerceptionComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SinglePerceptionSetEnable_FunctionAddress, "PerceptionComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SinglePerceptionSetEnable_IsHearing_PropertyAddress, SinglePerceptionSetEnable_FunctionAddress, "IsHearing");
		SinglePerceptionSetEnable_IsHearing_Offset = NativeReflectionCached.GetPropertyOffset(SinglePerceptionSetEnable_FunctionAddress, "IsHearing");
		SinglePerceptionSetEnable_IsHearing_IsValid = NativeReflectionCached.ValidatePropertyClass(SinglePerceptionSetEnable_FunctionAddress, "IsHearing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SinglePerceptionSetEnable_bEnable_PropertyAddress, SinglePerceptionSetEnable_FunctionAddress, "bEnable");
		SinglePerceptionSetEnable_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SinglePerceptionSetEnable_FunctionAddress, "bEnable");
		SinglePerceptionSetEnable_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SinglePerceptionSetEnable_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SinglePerceptionSetEnable_IsValid = SinglePerceptionSetEnable_FunctionAddress != IntPtr.Zero && SinglePerceptionSetEnable_PerceptionComp_IsValid && SinglePerceptionSetEnable_IsHearing_IsValid && SinglePerceptionSetEnable_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AIFuncLib:SinglePerceptionSetEnable", SinglePerceptionSetEnable_IsValid);
		SetPerceptionForgetAll_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPerceptionForgetAll");
		SetPerceptionForgetAll_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPerceptionForgetAll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPerceptionForgetAll_PerceptionComp_PropertyAddress, SetPerceptionForgetAll_FunctionAddress, "PerceptionComp");
		SetPerceptionForgetAll_PerceptionComp_Offset = NativeReflectionCached.GetPropertyOffset(SetPerceptionForgetAll_FunctionAddress, "PerceptionComp");
		SetPerceptionForgetAll_PerceptionComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPerceptionForgetAll_FunctionAddress, "PerceptionComp", Classes.FObjectProperty);
		SetPerceptionForgetAll_IsValid = SetPerceptionForgetAll_FunctionAddress != IntPtr.Zero && SetPerceptionForgetAll_PerceptionComp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AIFuncLib:SetPerceptionForgetAll", SetPerceptionForgetAll_IsValid);
		SetAISenseConfig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAISenseConfig");
		SetAISenseConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAISenseConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_PerceptionComp_PropertyAddress, SetAISenseConfig_FunctionAddress, "PerceptionComp");
		SetAISenseConfig_PerceptionComp_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "PerceptionComp");
		SetAISenseConfig_PerceptionComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "PerceptionComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_HearRange_PropertyAddress, SetAISenseConfig_FunctionAddress, "HearRange");
		SetAISenseConfig_HearRange_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "HearRange");
		SetAISenseConfig_HearRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "HearRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_SightRange_PropertyAddress, SetAISenseConfig_FunctionAddress, "SightRange");
		SetAISenseConfig_SightRange_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "SightRange");
		SetAISenseConfig_SightRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "SightRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_LoseSightRange_PropertyAddress, SetAISenseConfig_FunctionAddress, "LoseSightRange");
		SetAISenseConfig_LoseSightRange_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "LoseSightRange");
		SetAISenseConfig_LoseSightRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "LoseSightRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_VisionAngleDegrees_PropertyAddress, SetAISenseConfig_FunctionAddress, "VisionAngleDegrees");
		SetAISenseConfig_VisionAngleDegrees_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "VisionAngleDegrees");
		SetAISenseConfig_VisionAngleDegrees_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "VisionAngleDegrees", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_ASRangeFromLastSeenLoc_PropertyAddress, SetAISenseConfig_FunctionAddress, "ASRangeFromLastSeenLoc");
		SetAISenseConfig_ASRangeFromLastSeenLoc_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "ASRangeFromLastSeenLoc");
		SetAISenseConfig_ASRangeFromLastSeenLoc_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "ASRangeFromLastSeenLoc", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_IsSightDominantSense_PropertyAddress, SetAISenseConfig_FunctionAddress, "IsSightDominantSense");
		SetAISenseConfig_IsSightDominantSense_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "IsSightDominantSense");
		SetAISenseConfig_IsSightDominantSense_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "IsSightDominantSense", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_IsHearingSet_PropertyAddress, SetAISenseConfig_FunctionAddress, "IsHearingSet");
		SetAISenseConfig_IsHearingSet_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "IsHearingSet");
		SetAISenseConfig_IsHearingSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "IsHearingSet", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAISenseConfig_IsSightSet_PropertyAddress, SetAISenseConfig_FunctionAddress, "IsSightSet");
		SetAISenseConfig_IsSightSet_Offset = NativeReflectionCached.GetPropertyOffset(SetAISenseConfig_FunctionAddress, "IsSightSet");
		SetAISenseConfig_IsSightSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAISenseConfig_FunctionAddress, "IsSightSet", Classes.FBoolProperty);
		SetAISenseConfig_IsValid = SetAISenseConfig_FunctionAddress != IntPtr.Zero && SetAISenseConfig_PerceptionComp_IsValid && SetAISenseConfig_HearRange_IsValid && SetAISenseConfig_SightRange_IsValid && SetAISenseConfig_LoseSightRange_IsValid && SetAISenseConfig_VisionAngleDegrees_IsValid && SetAISenseConfig_ASRangeFromLastSeenLoc_IsValid && SetAISenseConfig_IsSightDominantSense_IsValid && SetAISenseConfig_IsHearingSet_IsValid && SetAISenseConfig_IsSightSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AIFuncLib:SetAISenseConfig", SetAISenseConfig_IsValid);
		SetAIBTStop_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAIBTStop");
		SetAIBTStop_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAIBTStop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAIBTStop_BTComp_PropertyAddress, SetAIBTStop_FunctionAddress, "BTComp");
		SetAIBTStop_BTComp_Offset = NativeReflectionCached.GetPropertyOffset(SetAIBTStop_FunctionAddress, "BTComp");
		SetAIBTStop_BTComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAIBTStop_FunctionAddress, "BTComp", Classes.FObjectProperty);
		SetAIBTStop_IsValid = SetAIBTStop_FunctionAddress != IntPtr.Zero && SetAIBTStop_BTComp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AIFuncLib:SetAIBTStop", SetAIBTStop_IsValid);
		SetAIBTPause_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAIBTPause");
		SetAIBTPause_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAIBTPause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAIBTPause_BrainComponent_PropertyAddress, SetAIBTPause_FunctionAddress, "BrainComponent");
		SetAIBTPause_BrainComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetAIBTPause_FunctionAddress, "BrainComponent");
		SetAIBTPause_BrainComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAIBTPause_FunctionAddress, "BrainComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAIBTPause_bEnable_PropertyAddress, SetAIBTPause_FunctionAddress, "bEnable");
		SetAIBTPause_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetAIBTPause_FunctionAddress, "bEnable");
		SetAIBTPause_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAIBTPause_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetAIBTPause_IsValid = SetAIBTPause_FunctionAddress != IntPtr.Zero && SetAIBTPause_BrainComponent_IsValid && SetAIBTPause_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AIFuncLib:SetAIBTPause", SetAIBTPause_IsValid);
		ListenerForgetsActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ListenerForgetsActor");
		ListenerForgetsActor_ParamsSize = NativeReflection.GetFunctionParamsSize(ListenerForgetsActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ListenerForgetsActor_PerceptionComp_PropertyAddress, ListenerForgetsActor_FunctionAddress, "PerceptionComp");
		ListenerForgetsActor_PerceptionComp_Offset = NativeReflectionCached.GetPropertyOffset(ListenerForgetsActor_FunctionAddress, "PerceptionComp");
		ListenerForgetsActor_PerceptionComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ListenerForgetsActor_FunctionAddress, "PerceptionComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ListenerForgetsActor_ActorToForget_PropertyAddress, ListenerForgetsActor_FunctionAddress, "ActorToForget");
		ListenerForgetsActor_ActorToForget_Offset = NativeReflectionCached.GetPropertyOffset(ListenerForgetsActor_FunctionAddress, "ActorToForget");
		ListenerForgetsActor_ActorToForget_IsValid = NativeReflectionCached.ValidatePropertyClass(ListenerForgetsActor_FunctionAddress, "ActorToForget", Classes.FObjectProperty);
		ListenerForgetsActor_IsValid = ListenerForgetsActor_FunctionAddress != IntPtr.Zero && ListenerForgetsActor_PerceptionComp_IsValid && ListenerForgetsActor_ActorToForget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AIFuncLib:ListenerForgetsActor", ListenerForgetsActor_IsValid);
		AISetBT_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AISetBT");
		AISetBT_ParamsSize = NativeReflection.GetFunctionParamsSize(AISetBT_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AISetBT_Actor_PropertyAddress, AISetBT_FunctionAddress, "Actor");
		AISetBT_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AISetBT_FunctionAddress, "Actor");
		AISetBT_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AISetBT_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AISetBT_BTAsset_PropertyAddress, AISetBT_FunctionAddress, "BTAsset");
		AISetBT_BTAsset_Offset = NativeReflectionCached.GetPropertyOffset(AISetBT_FunctionAddress, "BTAsset");
		AISetBT_BTAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AISetBT_FunctionAddress, "BTAsset", Classes.FObjectProperty);
		AISetBT_IsValid = AISetBT_FunctionAddress != IntPtr.Zero && AISetBT_Actor_IsValid && AISetBT_BTAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AIFuncLib:AISetBT", AISetBT_IsValid);
	}
}
