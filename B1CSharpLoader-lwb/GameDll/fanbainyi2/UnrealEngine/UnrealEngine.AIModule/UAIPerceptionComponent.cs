using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/AIModule.AIPerceptionComponent", "AIModule", UnrealModuleType.Engine)]
public class UAIPerceptionComponent : UActorComponent
{
	private static bool OnPerceptionUpdated_IsValid;

	private static int OnPerceptionUpdated_Offset;

	private FPerceptionUpdatedDelegate OnPerceptionUpdated_DelegateCached;

	private static bool OnTargetPerceptionUpdated_IsValid;

	private static int OnTargetPerceptionUpdated_Offset;

	private FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated_DelegateCached;

	private static bool OnTargetPerceptionInfoUpdated_IsValid;

	private static int OnTargetPerceptionInfoUpdated_Offset;

	private FActorPerceptionInfoUpdatedDelegate OnTargetPerceptionInfoUpdated_DelegateCached;

	private static bool SetSenseEnabled_IsValid;

	private static IntPtr SetSenseEnabled_FunctionAddress;

	private static int SetSenseEnabled_ParamsSize;

	private static bool SetSenseEnabled_SenseClass_IsValid;

	private static FFieldAddress SetSenseEnabled_SenseClass_PropertyAddress;

	private static int SetSenseEnabled_SenseClass_Offset;

	private static bool SetSenseEnabled_bEnable_IsValid;

	private static FFieldAddress SetSenseEnabled_bEnable_PropertyAddress;

	private static int SetSenseEnabled_bEnable_Offset;

	private static bool RequestStimuliListenerUpdate_IsValid;

	private static IntPtr RequestStimuliListenerUpdate_FunctionAddress;

	private static int RequestStimuliListenerUpdate_ParamsSize;

	private static bool GetPerceivedHostileActorsBySense_IsValid;

	private static IntPtr GetPerceivedHostileActorsBySense_FunctionAddress;

	private static int GetPerceivedHostileActorsBySense_ParamsSize;

	private static bool GetPerceivedHostileActorsBySense_SenseToUse_IsValid;

	private static FFieldAddress GetPerceivedHostileActorsBySense_SenseToUse_PropertyAddress;

	private static int GetPerceivedHostileActorsBySense_SenseToUse_Offset;

	private static bool GetPerceivedHostileActorsBySense_OutActors_IsValid;

	private static FFieldAddress GetPerceivedHostileActorsBySense_OutActors_PropertyAddress;

	private static int GetPerceivedHostileActorsBySense_OutActors_Offset;

	private static bool GetPerceivedHostileActors_IsValid;

	private static IntPtr GetPerceivedHostileActors_FunctionAddress;

	private static int GetPerceivedHostileActors_ParamsSize;

	private static bool GetPerceivedHostileActors_OutActors_IsValid;

	private static FFieldAddress GetPerceivedHostileActors_OutActors_PropertyAddress;

	private static int GetPerceivedHostileActors_OutActors_Offset;

	private static bool GetPerceivedActors_IsValid;

	private static IntPtr GetPerceivedActors_FunctionAddress;

	private static int GetPerceivedActors_ParamsSize;

	private static bool GetPerceivedActors_SenseToUse_IsValid;

	private static FFieldAddress GetPerceivedActors_SenseToUse_PropertyAddress;

	private static int GetPerceivedActors_SenseToUse_Offset;

	private static bool GetPerceivedActors_OutActors_IsValid;

	private static FFieldAddress GetPerceivedActors_OutActors_PropertyAddress;

	private static int GetPerceivedActors_OutActors_Offset;

	private static bool GetKnownPerceivedActors_IsValid;

	private static IntPtr GetKnownPerceivedActors_FunctionAddress;

	private static int GetKnownPerceivedActors_ParamsSize;

	private static bool GetKnownPerceivedActors_SenseToUse_IsValid;

	private static FFieldAddress GetKnownPerceivedActors_SenseToUse_PropertyAddress;

	private static int GetKnownPerceivedActors_SenseToUse_Offset;

	private static bool GetKnownPerceivedActors_OutActors_IsValid;

	private static FFieldAddress GetKnownPerceivedActors_OutActors_PropertyAddress;

	private static int GetKnownPerceivedActors_OutActors_Offset;

	private static bool GetCurrentlyPerceivedActors_IsValid;

	private static IntPtr GetCurrentlyPerceivedActors_FunctionAddress;

	private static int GetCurrentlyPerceivedActors_ParamsSize;

	private static bool GetCurrentlyPerceivedActors_SenseToUse_IsValid;

	private static FFieldAddress GetCurrentlyPerceivedActors_SenseToUse_PropertyAddress;

	private static int GetCurrentlyPerceivedActors_SenseToUse_Offset;

	private static bool GetCurrentlyPerceivedActors_OutActors_IsValid;

	private static FFieldAddress GetCurrentlyPerceivedActors_OutActors_PropertyAddress;

	private static int GetCurrentlyPerceivedActors_OutActors_Offset;

	private static bool GetActorsPerception_IsValid;

	private static IntPtr GetActorsPerception_FunctionAddress;

	private static int GetActorsPerception_ParamsSize;

	private static bool GetActorsPerception_Actor_IsValid;

	private static FFieldAddress GetActorsPerception_Actor_PropertyAddress;

	private static int GetActorsPerception_Actor_Offset;

	private static bool GetActorsPerception_Info_IsValid;

	private static FFieldAddress GetActorsPerception_Info_PropertyAddress;

	private static int GetActorsPerception_Info_Offset;

	private static bool GetActorsPerception_ReturnValue_IsValid;

	private static FFieldAddress GetActorsPerception_ReturnValue_PropertyAddress;

	private static int GetActorsPerception_ReturnValue_Offset;

	private static bool ForgetAll_IsValid;

	private static IntPtr ForgetAll_FunctionAddress;

	private static int ForgetAll_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:OnPerceptionUpdated")]
	public FPerceptionUpdatedDelegate OnPerceptionUpdated
	{
		get
		{
			CheckDestroyed();
			if (!OnPerceptionUpdated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIPerceptionComponent:OnPerceptionUpdated");
				return new FPerceptionUpdatedDelegate();
			}
			if (OnPerceptionUpdated_DelegateCached == null)
			{
				OnPerceptionUpdated_DelegateCached = new FPerceptionUpdatedDelegate();
				OnPerceptionUpdated_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPerceptionUpdated_Offset));
			}
			return OnPerceptionUpdated_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:OnTargetPerceptionUpdated")]
	public FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated
	{
		get
		{
			CheckDestroyed();
			if (!OnTargetPerceptionUpdated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIPerceptionComponent:OnTargetPerceptionUpdated");
				return new FActorPerceptionUpdatedDelegate();
			}
			if (OnTargetPerceptionUpdated_DelegateCached == null)
			{
				OnTargetPerceptionUpdated_DelegateCached = new FActorPerceptionUpdatedDelegate();
				OnTargetPerceptionUpdated_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTargetPerceptionUpdated_Offset));
			}
			return OnTargetPerceptionUpdated_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:OnTargetPerceptionInfoUpdated")]
	public FActorPerceptionInfoUpdatedDelegate OnTargetPerceptionInfoUpdated
	{
		get
		{
			CheckDestroyed();
			if (!OnTargetPerceptionInfoUpdated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIPerceptionComponent:OnTargetPerceptionInfoUpdated");
				return new FActorPerceptionInfoUpdatedDelegate();
			}
			if (OnTargetPerceptionInfoUpdated_DelegateCached == null)
			{
				OnTargetPerceptionInfoUpdated_DelegateCached = new FActorPerceptionInfoUpdatedDelegate();
				OnTargetPerceptionInfoUpdated_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTargetPerceptionInfoUpdated_Offset));
			}
			return OnTargetPerceptionInfoUpdated_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:SetSenseEnabled")]
	public unsafe void SetSenseEnabled(TSubclassOf<UAISense> SenseClass, bool bEnable)
	{
		CheckDestroyed();
		if (!SetSenseEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:SetSenseEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSenseEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSenseEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UAISense>.ToNative(IntPtr.Add(intPtr, SetSenseEnabled_SenseClass_Offset), 0, SetSenseEnabled_SenseClass_PropertyAddress.Address, SenseClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSenseEnabled_bEnable_Offset), 0, SetSenseEnabled_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSenseEnabled_FunctionAddress, intPtr, SetSenseEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:RequestStimuliListenerUpdate")]
	public unsafe void RequestStimuliListenerUpdate()
	{
		CheckDestroyed();
		if (!RequestStimuliListenerUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:RequestStimuliListenerUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestStimuliListenerUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestStimuliListenerUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestStimuliListenerUpdate_FunctionAddress, argsSize: RequestStimuliListenerUpdate_ParamsSize);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:GetPerceivedHostileActorsBySense")]
	public unsafe void GetPerceivedHostileActorsBySense(TSubclassOf<UAISense> SenseToUse, out List<AActor> OutActors)
	{
		CheckDestroyed();
		if (!GetPerceivedHostileActorsBySense_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:GetPerceivedHostileActorsBySense");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPerceivedHostileActorsBySense_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPerceivedHostileActorsBySense_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UAISense>.ToNative(IntPtr.Add(intPtr, GetPerceivedHostileActorsBySense_SenseToUse_Offset), 0, GetPerceivedHostileActorsBySense_SenseToUse_PropertyAddress.Address, SenseToUse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPerceivedHostileActorsBySense_FunctionAddress, intPtr, GetPerceivedHostileActorsBySense_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetPerceivedHostileActorsBySense_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPerceivedHostileActorsBySense_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetPerceivedHostileActorsBySense_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:GetPerceivedHostileActors")]
	public unsafe void GetPerceivedHostileActors(out List<AActor> OutActors)
	{
		CheckDestroyed();
		if (!GetPerceivedHostileActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:GetPerceivedHostileActors");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPerceivedHostileActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPerceivedHostileActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPerceivedHostileActors_FunctionAddress, intPtr, GetPerceivedHostileActors_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetPerceivedHostileActors_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPerceivedHostileActors_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetPerceivedHostileActors_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:GetPerceivedActors")]
	public unsafe void GetPerceivedActors(TSubclassOf<UAISense> SenseToUse, out List<AActor> OutActors)
	{
		CheckDestroyed();
		if (!GetPerceivedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:GetPerceivedActors");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPerceivedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPerceivedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UAISense>.ToNative(IntPtr.Add(intPtr, GetPerceivedActors_SenseToUse_Offset), 0, GetPerceivedActors_SenseToUse_PropertyAddress.Address, SenseToUse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPerceivedActors_FunctionAddress, intPtr, GetPerceivedActors_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetPerceivedActors_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPerceivedActors_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetPerceivedActors_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:GetKnownPerceivedActors")]
	public unsafe void GetKnownPerceivedActors(TSubclassOf<UAISense> SenseToUse, out List<AActor> OutActors)
	{
		CheckDestroyed();
		if (!GetKnownPerceivedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:GetKnownPerceivedActors");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKnownPerceivedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKnownPerceivedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UAISense>.ToNative(IntPtr.Add(intPtr, GetKnownPerceivedActors_SenseToUse_Offset), 0, GetKnownPerceivedActors_SenseToUse_PropertyAddress.Address, SenseToUse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetKnownPerceivedActors_FunctionAddress, intPtr, GetKnownPerceivedActors_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetKnownPerceivedActors_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetKnownPerceivedActors_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetKnownPerceivedActors_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:GetCurrentlyPerceivedActors")]
	public unsafe void GetCurrentlyPerceivedActors(TSubclassOf<UAISense> SenseToUse, out List<AActor> OutActors)
	{
		CheckDestroyed();
		if (!GetCurrentlyPerceivedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:GetCurrentlyPerceivedActors");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentlyPerceivedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentlyPerceivedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UAISense>.ToNative(IntPtr.Add(intPtr, GetCurrentlyPerceivedActors_SenseToUse_Offset), 0, GetCurrentlyPerceivedActors_SenseToUse_PropertyAddress.Address, SenseToUse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentlyPerceivedActors_FunctionAddress, intPtr, GetCurrentlyPerceivedActors_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetCurrentlyPerceivedActors_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurrentlyPerceivedActors_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurrentlyPerceivedActors_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:GetActorsPerception")]
	public unsafe bool GetActorsPerception(AActor Actor, out FActorPerceptionBlueprintInfo Info)
	{
		CheckDestroyed();
		if (!GetActorsPerception_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:GetActorsPerception");
			Info = default(FActorPerceptionBlueprintInfo);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorsPerception_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorsPerception_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorsPerception_Actor_Offset), 0, GetActorsPerception_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InitializeValue_InContainer(GetActorsPerception_Info_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorsPerception_FunctionAddress, intPtr, GetActorsPerception_ParamsSize);
		Info = FActorPerceptionBlueprintInfo.FromNative(IntPtr.Add(intPtr, GetActorsPerception_Info_Offset), 0, GetActorsPerception_Info_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorsPerception_Info_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorsPerception_ReturnValue_Offset), 0, GetActorsPerception_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIPerceptionComponent:ForgetAll")]
	public unsafe void ForgetAll()
	{
		CheckDestroyed();
		if (!ForgetAll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionComponent:ForgetAll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForgetAll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForgetAll_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForgetAll_FunctionAddress, argsSize: ForgetAll_ParamsSize);
	}

	static UAIPerceptionComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAIPerceptionComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAIPerceptionComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.AIPerceptionComponent");
		OnPerceptionUpdated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPerceptionUpdated");
		OnPerceptionUpdated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPerceptionUpdated", Classes.FMulticastDelegateProperty);
		OnTargetPerceptionUpdated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTargetPerceptionUpdated");
		OnTargetPerceptionUpdated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTargetPerceptionUpdated", Classes.FMulticastDelegateProperty);
		OnTargetPerceptionInfoUpdated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTargetPerceptionInfoUpdated");
		OnTargetPerceptionInfoUpdated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTargetPerceptionInfoUpdated", Classes.FMulticastDelegateProperty);
		SetSenseEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSenseEnabled");
		SetSenseEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSenseEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSenseEnabled_SenseClass_PropertyAddress, SetSenseEnabled_FunctionAddress, "SenseClass");
		SetSenseEnabled_SenseClass_Offset = NativeReflectionCached.GetPropertyOffset(SetSenseEnabled_FunctionAddress, "SenseClass");
		SetSenseEnabled_SenseClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSenseEnabled_FunctionAddress, "SenseClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSenseEnabled_bEnable_PropertyAddress, SetSenseEnabled_FunctionAddress, "bEnable");
		SetSenseEnabled_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetSenseEnabled_FunctionAddress, "bEnable");
		SetSenseEnabled_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSenseEnabled_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetSenseEnabled_IsValid = SetSenseEnabled_FunctionAddress != IntPtr.Zero && SetSenseEnabled_SenseClass_IsValid && SetSenseEnabled_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:SetSenseEnabled", SetSenseEnabled_IsValid);
		RequestStimuliListenerUpdate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequestStimuliListenerUpdate");
		RequestStimuliListenerUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestStimuliListenerUpdate_FunctionAddress);
		RequestStimuliListenerUpdate_IsValid = RequestStimuliListenerUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:RequestStimuliListenerUpdate", RequestStimuliListenerUpdate_IsValid);
		GetPerceivedHostileActorsBySense_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPerceivedHostileActorsBySense");
		GetPerceivedHostileActorsBySense_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPerceivedHostileActorsBySense_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPerceivedHostileActorsBySense_SenseToUse_PropertyAddress, GetPerceivedHostileActorsBySense_FunctionAddress, "SenseToUse");
		GetPerceivedHostileActorsBySense_SenseToUse_Offset = NativeReflectionCached.GetPropertyOffset(GetPerceivedHostileActorsBySense_FunctionAddress, "SenseToUse");
		GetPerceivedHostileActorsBySense_SenseToUse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPerceivedHostileActorsBySense_FunctionAddress, "SenseToUse", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPerceivedHostileActorsBySense_OutActors_PropertyAddress, GetPerceivedHostileActorsBySense_FunctionAddress, "OutActors");
		GetPerceivedHostileActorsBySense_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetPerceivedHostileActorsBySense_FunctionAddress, "OutActors");
		GetPerceivedHostileActorsBySense_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPerceivedHostileActorsBySense_FunctionAddress, "OutActors", Classes.FArrayProperty);
		GetPerceivedHostileActorsBySense_IsValid = GetPerceivedHostileActorsBySense_FunctionAddress != IntPtr.Zero && GetPerceivedHostileActorsBySense_SenseToUse_IsValid && GetPerceivedHostileActorsBySense_OutActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:GetPerceivedHostileActorsBySense", GetPerceivedHostileActorsBySense_IsValid);
		GetPerceivedHostileActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPerceivedHostileActors");
		GetPerceivedHostileActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPerceivedHostileActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPerceivedHostileActors_OutActors_PropertyAddress, GetPerceivedHostileActors_FunctionAddress, "OutActors");
		GetPerceivedHostileActors_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetPerceivedHostileActors_FunctionAddress, "OutActors");
		GetPerceivedHostileActors_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPerceivedHostileActors_FunctionAddress, "OutActors", Classes.FArrayProperty);
		GetPerceivedHostileActors_IsValid = GetPerceivedHostileActors_FunctionAddress != IntPtr.Zero && GetPerceivedHostileActors_OutActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:GetPerceivedHostileActors", GetPerceivedHostileActors_IsValid);
		GetPerceivedActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPerceivedActors");
		GetPerceivedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPerceivedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPerceivedActors_SenseToUse_PropertyAddress, GetPerceivedActors_FunctionAddress, "SenseToUse");
		GetPerceivedActors_SenseToUse_Offset = NativeReflectionCached.GetPropertyOffset(GetPerceivedActors_FunctionAddress, "SenseToUse");
		GetPerceivedActors_SenseToUse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPerceivedActors_FunctionAddress, "SenseToUse", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPerceivedActors_OutActors_PropertyAddress, GetPerceivedActors_FunctionAddress, "OutActors");
		GetPerceivedActors_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetPerceivedActors_FunctionAddress, "OutActors");
		GetPerceivedActors_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPerceivedActors_FunctionAddress, "OutActors", Classes.FArrayProperty);
		GetPerceivedActors_IsValid = GetPerceivedActors_FunctionAddress != IntPtr.Zero && GetPerceivedActors_SenseToUse_IsValid && GetPerceivedActors_OutActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:GetPerceivedActors", GetPerceivedActors_IsValid);
		GetKnownPerceivedActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetKnownPerceivedActors");
		GetKnownPerceivedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKnownPerceivedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKnownPerceivedActors_SenseToUse_PropertyAddress, GetKnownPerceivedActors_FunctionAddress, "SenseToUse");
		GetKnownPerceivedActors_SenseToUse_Offset = NativeReflectionCached.GetPropertyOffset(GetKnownPerceivedActors_FunctionAddress, "SenseToUse");
		GetKnownPerceivedActors_SenseToUse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKnownPerceivedActors_FunctionAddress, "SenseToUse", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKnownPerceivedActors_OutActors_PropertyAddress, GetKnownPerceivedActors_FunctionAddress, "OutActors");
		GetKnownPerceivedActors_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetKnownPerceivedActors_FunctionAddress, "OutActors");
		GetKnownPerceivedActors_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKnownPerceivedActors_FunctionAddress, "OutActors", Classes.FArrayProperty);
		GetKnownPerceivedActors_IsValid = GetKnownPerceivedActors_FunctionAddress != IntPtr.Zero && GetKnownPerceivedActors_SenseToUse_IsValid && GetKnownPerceivedActors_OutActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:GetKnownPerceivedActors", GetKnownPerceivedActors_IsValid);
		GetCurrentlyPerceivedActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentlyPerceivedActors");
		GetCurrentlyPerceivedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentlyPerceivedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentlyPerceivedActors_SenseToUse_PropertyAddress, GetCurrentlyPerceivedActors_FunctionAddress, "SenseToUse");
		GetCurrentlyPerceivedActors_SenseToUse_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentlyPerceivedActors_FunctionAddress, "SenseToUse");
		GetCurrentlyPerceivedActors_SenseToUse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentlyPerceivedActors_FunctionAddress, "SenseToUse", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentlyPerceivedActors_OutActors_PropertyAddress, GetCurrentlyPerceivedActors_FunctionAddress, "OutActors");
		GetCurrentlyPerceivedActors_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentlyPerceivedActors_FunctionAddress, "OutActors");
		GetCurrentlyPerceivedActors_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentlyPerceivedActors_FunctionAddress, "OutActors", Classes.FArrayProperty);
		GetCurrentlyPerceivedActors_IsValid = GetCurrentlyPerceivedActors_FunctionAddress != IntPtr.Zero && GetCurrentlyPerceivedActors_SenseToUse_IsValid && GetCurrentlyPerceivedActors_OutActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:GetCurrentlyPerceivedActors", GetCurrentlyPerceivedActors_IsValid);
		GetActorsPerception_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorsPerception");
		GetActorsPerception_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorsPerception_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorsPerception_Actor_PropertyAddress, GetActorsPerception_FunctionAddress, "Actor");
		GetActorsPerception_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsPerception_FunctionAddress, "Actor");
		GetActorsPerception_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsPerception_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorsPerception_Info_PropertyAddress, GetActorsPerception_FunctionAddress, "Info");
		GetActorsPerception_Info_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsPerception_FunctionAddress, "Info");
		GetActorsPerception_Info_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsPerception_FunctionAddress, "Info", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorsPerception_ReturnValue_PropertyAddress, GetActorsPerception_FunctionAddress, "ReturnValue");
		GetActorsPerception_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsPerception_FunctionAddress, "ReturnValue");
		GetActorsPerception_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsPerception_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorsPerception_IsValid = GetActorsPerception_FunctionAddress != IntPtr.Zero && GetActorsPerception_Actor_IsValid && GetActorsPerception_Info_IsValid && GetActorsPerception_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:GetActorsPerception", GetActorsPerception_IsValid);
		ForgetAll_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForgetAll");
		ForgetAll_ParamsSize = NativeReflection.GetFunctionParamsSize(ForgetAll_FunctionAddress);
		ForgetAll_IsValid = ForgetAll_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionComponent:ForgetAll", ForgetAll_IsValid);
	}
}
