using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)886046885uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.AISense_Blueprint", "AIModule", UnrealModuleType.Engine)]
public class UAISense_Blueprint : UAISense
{
	private static bool ListenerDataType_IsValid;

	private static int ListenerDataType_Offset;

	private static bool ListenerContainer_IsValid;

	private static FFieldAddress ListenerContainer_PropertyAddress;

	private static int ListenerContainer_Offset;

	private TArrayReadOnlyMarshaler<UAIPerceptionComponent> ListenerContainer_MarshalerCached;

	private static bool OnUpdate_IsValid;

	private IntPtr OnUpdate_InstanceFunctionAddress;

	private static IntPtr OnUpdate_FunctionAddress;

	private static int OnUpdate_ParamsSize;

	private static bool OnUpdate_EventsToProcess_IsValid;

	private static FFieldAddress OnUpdate_EventsToProcess_PropertyAddress;

	private static int OnUpdate_EventsToProcess_Offset;

	private static bool OnUpdate_ReturnValue_IsValid;

	private static FFieldAddress OnUpdate_ReturnValue_PropertyAddress;

	private static int OnUpdate_ReturnValue_Offset;

	private static bool OnListenerUpdated_IsValid;

	private IntPtr OnListenerUpdated_InstanceFunctionAddress;

	private static IntPtr OnListenerUpdated_FunctionAddress;

	private static int OnListenerUpdated_ParamsSize;

	private static bool OnListenerUpdated_ActorListener_IsValid;

	private static FFieldAddress OnListenerUpdated_ActorListener_PropertyAddress;

	private static int OnListenerUpdated_ActorListener_Offset;

	private static bool OnListenerUpdated_PerceptionComponent_IsValid;

	private static FFieldAddress OnListenerUpdated_PerceptionComponent_PropertyAddress;

	private static int OnListenerUpdated_PerceptionComponent_Offset;

	private static bool OnListenerUnregistered_IsValid;

	private IntPtr OnListenerUnregistered_InstanceFunctionAddress;

	private static IntPtr OnListenerUnregistered_FunctionAddress;

	private static int OnListenerUnregistered_ParamsSize;

	private static bool OnListenerUnregistered_ActorListener_IsValid;

	private static FFieldAddress OnListenerUnregistered_ActorListener_PropertyAddress;

	private static int OnListenerUnregistered_ActorListener_Offset;

	private static bool OnListenerUnregistered_PerceptionComponent_IsValid;

	private static FFieldAddress OnListenerUnregistered_PerceptionComponent_PropertyAddress;

	private static int OnListenerUnregistered_PerceptionComponent_Offset;

	private static bool OnListenerRegistered_IsValid;

	private IntPtr OnListenerRegistered_InstanceFunctionAddress;

	private static IntPtr OnListenerRegistered_FunctionAddress;

	private static int OnListenerRegistered_ParamsSize;

	private static bool OnListenerRegistered_ActorListener_IsValid;

	private static FFieldAddress OnListenerRegistered_ActorListener_PropertyAddress;

	private static int OnListenerRegistered_ActorListener_Offset;

	private static bool OnListenerRegistered_PerceptionComponent_IsValid;

	private static FFieldAddress OnListenerRegistered_PerceptionComponent_PropertyAddress;

	private static int OnListenerRegistered_PerceptionComponent_Offset;

	private static bool OnNewPawn_IsValid;

	private IntPtr OnNewPawn_InstanceFunctionAddress;

	private static IntPtr OnNewPawn_FunctionAddress;

	private static int OnNewPawn_ParamsSize;

	private static bool OnNewPawn_NewPawn_IsValid;

	private static FFieldAddress OnNewPawn_NewPawn_PropertyAddress;

	private static int OnNewPawn_NewPawn_Offset;

	private static bool GetAllListenerComponents_IsValid;

	private static IntPtr GetAllListenerComponents_FunctionAddress;

	private static int GetAllListenerComponents_ParamsSize;

	private static bool GetAllListenerComponents_ListenerComponents_IsValid;

	private static FFieldAddress GetAllListenerComponents_ListenerComponents_PropertyAddress;

	private static int GetAllListenerComponents_ListenerComponents_Offset;

	private static bool GetAllListenerActors_IsValid;

	private static IntPtr GetAllListenerActors_FunctionAddress;

	private static int GetAllListenerActors_ParamsSize;

	private static bool GetAllListenerActors_ListenerActors_IsValid;

	private static FFieldAddress GetAllListenerActors_ListenerActors_PropertyAddress;

	private static int GetAllListenerActors_ListenerActors_Offset;

	[UProperty(Flags = (PropFlags)12393764861510149uL)]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:ListenerDataType")]
	protected TSubclassOf<UUserDefinedStruct> ListenerDataType
	{
		get
		{
			CheckDestroyed();
			if (!ListenerDataType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense_Blueprint:ListenerDataType");
				return default(TSubclassOf<UUserDefinedStruct>);
			}
			return TSubclassOfMarshaler<UUserDefinedStruct>.FromNative(IntPtr.Add(base.Address, ListenerDataType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ListenerDataType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense_Blueprint:ListenerDataType");
			}
			else
			{
				TSubclassOfMarshaler<UUserDefinedStruct>.ToNative(IntPtr.Add(base.Address, ListenerDataType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)10142445010420252uL)]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:ListenerContainer")]
	protected TArrayReadOnly<UAIPerceptionComponent> ListenerContainer
	{
		get
		{
			CheckDestroyed();
			if (!ListenerContainer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense_Blueprint:ListenerContainer");
				return null;
			}
			if (ListenerContainer_MarshalerCached == null)
			{
				ListenerContainer_MarshalerCached = new TArrayReadOnlyMarshaler<UAIPerceptionComponent>(1, ListenerContainer_PropertyAddress, CachedMarshalingDelegates<UAIPerceptionComponent, UObjectMarshaler<UAIPerceptionComponent>>.FromNative, CachedMarshalingDelegates<UAIPerceptionComponent, UObjectMarshaler<UAIPerceptionComponent>>.ToNative);
			}
			return ListenerContainer_MarshalerCached.FromNative(IntPtr.Add(base.Address, ListenerContainer_Offset));
		}
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:OnUpdate")]
	public unsafe float OnUpdate(List<UAISenseEvent> EventsToProcess)
	{
		CheckDestroyed();
		if (!OnUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:OnUpdate");
			return 0f;
		}
		if (OnUpdate_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnUpdate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnUpdate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUpdate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAISenseEvent>(1, OnUpdate_EventsToProcess_PropertyAddress, CachedMarshalingDelegates<UAISenseEvent, UObjectMarshaler<UAISenseEvent>>.FromNative, CachedMarshalingDelegates<UAISenseEvent, UObjectMarshaler<UAISenseEvent>>.ToNative).ToNative(IntPtr.Add(intPtr, OnUpdate_EventsToProcess_Offset), EventsToProcess);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnUpdate_InstanceFunctionAddress, intPtr, OnUpdate_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnUpdate_EventsToProcess_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, OnUpdate_ReturnValue_Offset), 0, OnUpdate_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual float OnUpdate_Implementation(List<UAISenseEvent> EventsToProcess)
	{
		CheckDestroyed();
		if (!OnUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:OnUpdate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUpdate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAISenseEvent>(1, OnUpdate_EventsToProcess_PropertyAddress, CachedMarshalingDelegates<UAISenseEvent, UObjectMarshaler<UAISenseEvent>>.FromNative, CachedMarshalingDelegates<UAISenseEvent, UObjectMarshaler<UAISenseEvent>>.ToNative).ToNative(IntPtr.Add(intPtr, OnUpdate_EventsToProcess_Offset), EventsToProcess);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnUpdate_FunctionAddress, intPtr, OnUpdate_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnUpdate_EventsToProcess_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, OnUpdate_ReturnValue_Offset), 0, OnUpdate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:OnListenerUpdated")]
	public unsafe void OnListenerUpdated(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
	{
		CheckDestroyed();
		if (!OnListenerUpdated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:OnListenerUpdated");
			return;
		}
		if (OnListenerUpdated_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnListenerUpdated_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnListenerUpdated");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListenerUpdated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListenerUpdated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnListenerUpdated_ActorListener_Offset), 0, OnListenerUpdated_ActorListener_PropertyAddress.Address, ActorListener);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, OnListenerUpdated_PerceptionComponent_Offset), 0, OnListenerUpdated_PerceptionComponent_PropertyAddress.Address, PerceptionComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListenerUpdated_InstanceFunctionAddress, intPtr, OnListenerUpdated_ParamsSize);
	}

	protected unsafe virtual void OnListenerUpdated_Implementation(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
	{
		CheckDestroyed();
		if (!OnListenerUpdated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:OnListenerUpdated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListenerUpdated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListenerUpdated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnListenerUpdated_ActorListener_Offset), 0, OnListenerUpdated_ActorListener_PropertyAddress.Address, ActorListener);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, OnListenerUpdated_PerceptionComponent_Offset), 0, OnListenerUpdated_PerceptionComponent_PropertyAddress.Address, PerceptionComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListenerUpdated_FunctionAddress, intPtr, OnListenerUpdated_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:OnListenerUnregistered")]
	public unsafe void OnListenerUnregistered(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
	{
		CheckDestroyed();
		if (!OnListenerUnregistered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:OnListenerUnregistered");
			return;
		}
		if (OnListenerUnregistered_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnListenerUnregistered_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnListenerUnregistered");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListenerUnregistered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListenerUnregistered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnListenerUnregistered_ActorListener_Offset), 0, OnListenerUnregistered_ActorListener_PropertyAddress.Address, ActorListener);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, OnListenerUnregistered_PerceptionComponent_Offset), 0, OnListenerUnregistered_PerceptionComponent_PropertyAddress.Address, PerceptionComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListenerUnregistered_InstanceFunctionAddress, intPtr, OnListenerUnregistered_ParamsSize);
	}

	protected unsafe virtual void OnListenerUnregistered_Implementation(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
	{
		CheckDestroyed();
		if (!OnListenerUnregistered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:OnListenerUnregistered");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListenerUnregistered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListenerUnregistered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnListenerUnregistered_ActorListener_Offset), 0, OnListenerUnregistered_ActorListener_PropertyAddress.Address, ActorListener);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, OnListenerUnregistered_PerceptionComponent_Offset), 0, OnListenerUnregistered_PerceptionComponent_PropertyAddress.Address, PerceptionComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListenerUnregistered_FunctionAddress, intPtr, OnListenerUnregistered_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:OnListenerRegistered")]
	public unsafe void OnListenerRegistered(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
	{
		CheckDestroyed();
		if (!OnListenerRegistered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:OnListenerRegistered");
			return;
		}
		if (OnListenerRegistered_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnListenerRegistered_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnListenerRegistered");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListenerRegistered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListenerRegistered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnListenerRegistered_ActorListener_Offset), 0, OnListenerRegistered_ActorListener_PropertyAddress.Address, ActorListener);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, OnListenerRegistered_PerceptionComponent_Offset), 0, OnListenerRegistered_PerceptionComponent_PropertyAddress.Address, PerceptionComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListenerRegistered_InstanceFunctionAddress, intPtr, OnListenerRegistered_ParamsSize);
	}

	protected unsafe virtual void OnListenerRegistered_Implementation(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
	{
		CheckDestroyed();
		if (!OnListenerRegistered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:OnListenerRegistered");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListenerRegistered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListenerRegistered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnListenerRegistered_ActorListener_Offset), 0, OnListenerRegistered_ActorListener_PropertyAddress.Address, ActorListener);
		UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(intPtr, OnListenerRegistered_PerceptionComponent_Offset), 0, OnListenerRegistered_PerceptionComponent_PropertyAddress.Address, PerceptionComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListenerRegistered_FunctionAddress, intPtr, OnListenerRegistered_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnNewPawn")]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:K2_OnNewPawn")]
	public unsafe void OnNewPawn(APawn NewPawn)
	{
		CheckDestroyed();
		if (!OnNewPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:K2_OnNewPawn");
			return;
		}
		if (OnNewPawn_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNewPawn_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnNewPawn");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNewPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNewPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, OnNewPawn_NewPawn_Offset), 0, OnNewPawn_NewPawn_PropertyAddress.Address, NewPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNewPawn_InstanceFunctionAddress, intPtr, OnNewPawn_ParamsSize);
	}

	protected unsafe virtual void OnNewPawn_Implementation(APawn NewPawn)
	{
		CheckDestroyed();
		if (!OnNewPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:K2_OnNewPawn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNewPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNewPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, OnNewPawn_NewPawn_Offset), 0, OnNewPawn_NewPawn_PropertyAddress.Address, NewPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNewPawn_FunctionAddress, intPtr, OnNewPawn_ParamsSize);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:GetAllListenerComponents")]
	public unsafe void GetAllListenerComponents(out List<UAIPerceptionComponent> ListenerComponents)
	{
		CheckDestroyed();
		if (!GetAllListenerComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:GetAllListenerComponents");
			ListenerComponents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllListenerComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllListenerComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllListenerComponents_FunctionAddress, intPtr, GetAllListenerComponents_ParamsSize);
		ListenerComponents = new TArrayCopyMarshaler<UAIPerceptionComponent>(1, GetAllListenerComponents_ListenerComponents_PropertyAddress, CachedMarshalingDelegates<UAIPerceptionComponent, UObjectMarshaler<UAIPerceptionComponent>>.FromNative, CachedMarshalingDelegates<UAIPerceptionComponent, UObjectMarshaler<UAIPerceptionComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllListenerComponents_ListenerComponents_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllListenerComponents_ListenerComponents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/AIModule.AISense_Blueprint:GetAllListenerActors")]
	public unsafe void GetAllListenerActors(out List<AActor> ListenerActors)
	{
		CheckDestroyed();
		if (!GetAllListenerActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AISense_Blueprint:GetAllListenerActors");
			ListenerActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllListenerActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllListenerActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllListenerActors_FunctionAddress, intPtr, GetAllListenerActors_ParamsSize);
		ListenerActors = new TArrayCopyMarshaler<AActor>(1, GetAllListenerActors_ListenerActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllListenerActors_ListenerActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllListenerActors_ListenerActors_PropertyAddress.Address, intPtr);
	}

	static UAISense_Blueprint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAISense_Blueprint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAISense_Blueprint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.AISense_Blueprint");
		ListenerDataType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ListenerDataType");
		ListenerDataType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ListenerDataType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ListenerContainer_PropertyAddress, intPtr, "ListenerContainer");
		ListenerContainer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ListenerContainer");
		ListenerContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ListenerContainer", Classes.FArrayProperty);
		OnUpdate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnUpdate");
		OnUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUpdate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnUpdate_EventsToProcess_PropertyAddress, OnUpdate_FunctionAddress, "EventsToProcess");
		OnUpdate_EventsToProcess_Offset = NativeReflectionCached.GetPropertyOffset(OnUpdate_FunctionAddress, "EventsToProcess");
		OnUpdate_EventsToProcess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUpdate_FunctionAddress, "EventsToProcess", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OnUpdate_ReturnValue_PropertyAddress, OnUpdate_FunctionAddress, "ReturnValue");
		OnUpdate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnUpdate_FunctionAddress, "ReturnValue");
		OnUpdate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUpdate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		OnUpdate_IsValid = OnUpdate_FunctionAddress != IntPtr.Zero && OnUpdate_EventsToProcess_IsValid && OnUpdate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AISense_Blueprint:OnUpdate", OnUpdate_IsValid);
		OnListenerUpdated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnListenerUpdated");
		OnListenerUpdated_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListenerUpdated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListenerUpdated_ActorListener_PropertyAddress, OnListenerUpdated_FunctionAddress, "ActorListener");
		OnListenerUpdated_ActorListener_Offset = NativeReflectionCached.GetPropertyOffset(OnListenerUpdated_FunctionAddress, "ActorListener");
		OnListenerUpdated_ActorListener_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenerUpdated_FunctionAddress, "ActorListener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListenerUpdated_PerceptionComponent_PropertyAddress, OnListenerUpdated_FunctionAddress, "PerceptionComponent");
		OnListenerUpdated_PerceptionComponent_Offset = NativeReflectionCached.GetPropertyOffset(OnListenerUpdated_FunctionAddress, "PerceptionComponent");
		OnListenerUpdated_PerceptionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenerUpdated_FunctionAddress, "PerceptionComponent", Classes.FObjectProperty);
		OnListenerUpdated_IsValid = OnListenerUpdated_FunctionAddress != IntPtr.Zero && OnListenerUpdated_ActorListener_IsValid && OnListenerUpdated_PerceptionComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AISense_Blueprint:OnListenerUpdated", OnListenerUpdated_IsValid);
		OnListenerUnregistered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnListenerUnregistered");
		OnListenerUnregistered_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListenerUnregistered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListenerUnregistered_ActorListener_PropertyAddress, OnListenerUnregistered_FunctionAddress, "ActorListener");
		OnListenerUnregistered_ActorListener_Offset = NativeReflectionCached.GetPropertyOffset(OnListenerUnregistered_FunctionAddress, "ActorListener");
		OnListenerUnregistered_ActorListener_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenerUnregistered_FunctionAddress, "ActorListener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListenerUnregistered_PerceptionComponent_PropertyAddress, OnListenerUnregistered_FunctionAddress, "PerceptionComponent");
		OnListenerUnregistered_PerceptionComponent_Offset = NativeReflectionCached.GetPropertyOffset(OnListenerUnregistered_FunctionAddress, "PerceptionComponent");
		OnListenerUnregistered_PerceptionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenerUnregistered_FunctionAddress, "PerceptionComponent", Classes.FObjectProperty);
		OnListenerUnregistered_IsValid = OnListenerUnregistered_FunctionAddress != IntPtr.Zero && OnListenerUnregistered_ActorListener_IsValid && OnListenerUnregistered_PerceptionComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AISense_Blueprint:OnListenerUnregistered", OnListenerUnregistered_IsValid);
		OnListenerRegistered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnListenerRegistered");
		OnListenerRegistered_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListenerRegistered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListenerRegistered_ActorListener_PropertyAddress, OnListenerRegistered_FunctionAddress, "ActorListener");
		OnListenerRegistered_ActorListener_Offset = NativeReflectionCached.GetPropertyOffset(OnListenerRegistered_FunctionAddress, "ActorListener");
		OnListenerRegistered_ActorListener_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenerRegistered_FunctionAddress, "ActorListener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListenerRegistered_PerceptionComponent_PropertyAddress, OnListenerRegistered_FunctionAddress, "PerceptionComponent");
		OnListenerRegistered_PerceptionComponent_Offset = NativeReflectionCached.GetPropertyOffset(OnListenerRegistered_FunctionAddress, "PerceptionComponent");
		OnListenerRegistered_PerceptionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenerRegistered_FunctionAddress, "PerceptionComponent", Classes.FObjectProperty);
		OnListenerRegistered_IsValid = OnListenerRegistered_FunctionAddress != IntPtr.Zero && OnListenerRegistered_ActorListener_IsValid && OnListenerRegistered_PerceptionComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AISense_Blueprint:OnListenerRegistered", OnListenerRegistered_IsValid);
		OnNewPawn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnNewPawn");
		OnNewPawn_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNewPawn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNewPawn_NewPawn_PropertyAddress, OnNewPawn_FunctionAddress, "NewPawn");
		OnNewPawn_NewPawn_Offset = NativeReflectionCached.GetPropertyOffset(OnNewPawn_FunctionAddress, "NewPawn");
		OnNewPawn_NewPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNewPawn_FunctionAddress, "NewPawn", Classes.FObjectProperty);
		OnNewPawn_IsValid = OnNewPawn_FunctionAddress != IntPtr.Zero && OnNewPawn_NewPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AISense_Blueprint:K2_OnNewPawn", OnNewPawn_IsValid);
		GetAllListenerComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllListenerComponents");
		GetAllListenerComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllListenerComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllListenerComponents_ListenerComponents_PropertyAddress, GetAllListenerComponents_FunctionAddress, "ListenerComponents");
		GetAllListenerComponents_ListenerComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetAllListenerComponents_FunctionAddress, "ListenerComponents");
		GetAllListenerComponents_ListenerComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllListenerComponents_FunctionAddress, "ListenerComponents", Classes.FArrayProperty);
		GetAllListenerComponents_IsValid = GetAllListenerComponents_FunctionAddress != IntPtr.Zero && GetAllListenerComponents_ListenerComponents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AISense_Blueprint:GetAllListenerComponents", GetAllListenerComponents_IsValid);
		GetAllListenerActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllListenerActors");
		GetAllListenerActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllListenerActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllListenerActors_ListenerActors_PropertyAddress, GetAllListenerActors_FunctionAddress, "ListenerActors");
		GetAllListenerActors_ListenerActors_Offset = NativeReflectionCached.GetPropertyOffset(GetAllListenerActors_FunctionAddress, "ListenerActors");
		GetAllListenerActors_ListenerActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllListenerActors_FunctionAddress, "ListenerActors", Classes.FArrayProperty);
		GetAllListenerActors_IsValid = GetAllListenerActors_FunctionAddress != IntPtr.Zero && GetAllListenerActors_ListenerActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AISense_Blueprint:GetAllListenerActors", GetAllListenerActors_IsValid);
	}
}
