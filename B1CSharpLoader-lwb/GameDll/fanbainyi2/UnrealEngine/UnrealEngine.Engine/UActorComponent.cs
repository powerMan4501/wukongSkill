using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ActorComponent", "Engine", UnrealModuleType.Engine)]
public class UActorComponent : UObject, IInterface_AssetUserData, IInterface
{
	private static int PrimaryComponentTick_Offset;

	private static bool ComponentTags_IsValid;

	private static FFieldAddress ComponentTags_PropertyAddress;

	private static int ComponentTags_Offset;

	private TArrayReadWriteMarshaler<FName> ComponentTags_MarshalerCached;

	private static bool Replicates_IsValid;

	private static FFieldAddress Replicates_PropertyAddress;

	private static int Replicates_Offset;

	private static bool AutoActivate_IsValid;

	private static FFieldAddress AutoActivate_PropertyAddress;

	private static int AutoActivate_Offset;

	private static bool IsEditorOnly_IsValid;

	private static FFieldAddress IsEditorOnly_PropertyAddress;

	private static int IsEditorOnly_Offset;

	private static bool OnComponentActivated_IsValid;

	private static int OnComponentActivated_Offset;

	private FActorComponentActivatedSignature OnComponentActivated_DelegateCached;

	private static bool OnComponentDeactivated_IsValid;

	private static int OnComponentDeactivated_Offset;

	private FActorComponentDeactivateSignature OnComponentDeactivated_DelegateCached;

	private static bool ToggleActive_IsValid;

	private static IntPtr ToggleActive_FunctionAddress;

	private static int ToggleActive_ParamsSize;

	private static bool SetTickGroup_IsValid;

	private static IntPtr SetTickGroup_FunctionAddress;

	private static int SetTickGroup_ParamsSize;

	private static bool SetTickGroup_NewTickGroup_IsValid;

	private static FFieldAddress SetTickGroup_NewTickGroup_PropertyAddress;

	private static int SetTickGroup_NewTickGroup_Offset;

	private static bool SetTickableWhenPaused_IsValid;

	private static IntPtr SetTickableWhenPaused_FunctionAddress;

	private static int SetTickableWhenPaused_ParamsSize;

	private static bool SetTickableWhenPaused_bTickableWhenPaused_IsValid;

	private static FFieldAddress SetTickableWhenPaused_bTickableWhenPaused_PropertyAddress;

	private static int SetTickableWhenPaused_bTickableWhenPaused_Offset;

	private static bool SetIsReplicated_IsValid;

	private static IntPtr SetIsReplicated_FunctionAddress;

	private static int SetIsReplicated_ParamsSize;

	private static bool SetIsReplicated_ShouldReplicate_IsValid;

	private static FFieldAddress SetIsReplicated_ShouldReplicate_PropertyAddress;

	private static int SetIsReplicated_ShouldReplicate_Offset;

	private static bool SetComponentTickIntervalAndCooldown_IsValid;

	private static IntPtr SetComponentTickIntervalAndCooldown_FunctionAddress;

	private static int SetComponentTickIntervalAndCooldown_ParamsSize;

	private static bool SetComponentTickIntervalAndCooldown_TickInterval_IsValid;

	private static FFieldAddress SetComponentTickIntervalAndCooldown_TickInterval_PropertyAddress;

	private static int SetComponentTickIntervalAndCooldown_TickInterval_Offset;

	private static bool SetComponentTickInterval_IsValid;

	private static IntPtr SetComponentTickInterval_FunctionAddress;

	private static int SetComponentTickInterval_ParamsSize;

	private static bool SetComponentTickInterval_TickInterval_IsValid;

	private static FFieldAddress SetComponentTickInterval_TickInterval_PropertyAddress;

	private static int SetComponentTickInterval_TickInterval_Offset;

	private static bool SetComponentTickEnabled_IsValid;

	private static IntPtr SetComponentTickEnabled_FunctionAddress;

	private static int SetComponentTickEnabled_ParamsSize;

	private static bool SetComponentTickEnabled_bEnabled_IsValid;

	private static FFieldAddress SetComponentTickEnabled_bEnabled_PropertyAddress;

	private static int SetComponentTickEnabled_bEnabled_Offset;

	private static bool SetAutoActivate_IsValid;

	private static IntPtr SetAutoActivate_FunctionAddress;

	private static int SetAutoActivate_ParamsSize;

	private static bool SetAutoActivate_bNewAutoActivate_IsValid;

	private static FFieldAddress SetAutoActivate_bNewAutoActivate_PropertyAddress;

	private static int SetAutoActivate_bNewAutoActivate_Offset;

	private static bool SetActive_IsValid;

	private static IntPtr SetActive_FunctionAddress;

	private static int SetActive_ParamsSize;

	private static bool SetActive_bNewActive_IsValid;

	private static FFieldAddress SetActive_bNewActive_PropertyAddress;

	private static int SetActive_bNewActive_Offset;

	private static bool SetActive_bReset_IsValid;

	private static FFieldAddress SetActive_bReset_PropertyAddress;

	private static int SetActive_bReset_Offset;

	private static bool RemoveTickPrerequisiteComponent_IsValid;

	private static IntPtr RemoveTickPrerequisiteComponent_FunctionAddress;

	private static int RemoveTickPrerequisiteComponent_ParamsSize;

	private static bool RemoveTickPrerequisiteComponent_PrerequisiteComponent_IsValid;

	private static FFieldAddress RemoveTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress;

	private static int RemoveTickPrerequisiteComponent_PrerequisiteComponent_Offset;

	private static bool RemoveTickPrerequisiteActor_IsValid;

	private static IntPtr RemoveTickPrerequisiteActor_FunctionAddress;

	private static int RemoveTickPrerequisiteActor_ParamsSize;

	private static bool RemoveTickPrerequisiteActor_PrerequisiteActor_IsValid;

	private static FFieldAddress RemoveTickPrerequisiteActor_PrerequisiteActor_PropertyAddress;

	private static int RemoveTickPrerequisiteActor_PrerequisiteActor_Offset;

	private static bool ReceiveTick_IsValid;

	private IntPtr ReceiveTick_InstanceFunctionAddress;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static FFieldAddress ReceiveTick_DeltaSeconds_PropertyAddress;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveEndPlay_IsValid;

	private IntPtr ReceiveEndPlay_InstanceFunctionAddress;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static bool ReceiveBeginPlay_IsValid;

	private IntPtr ReceiveBeginPlay_InstanceFunctionAddress;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	private static bool DestroyComponent_IsValid;

	private static IntPtr DestroyComponent_FunctionAddress;

	private static int DestroyComponent_ParamsSize;

	private static bool DestroyComponent_Object_IsValid;

	private static FFieldAddress DestroyComponent_Object_PropertyAddress;

	private static int DestroyComponent_Object_Offset;

	private static bool IsComponentTickEnabled_IsValid;

	private static IntPtr IsComponentTickEnabled_FunctionAddress;

	private static int IsComponentTickEnabled_ParamsSize;

	private static bool IsComponentTickEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsComponentTickEnabled_ReturnValue_PropertyAddress;

	private static int IsComponentTickEnabled_ReturnValue_Offset;

	private static bool IsBeingDestroyed_IsValid;

	private static IntPtr IsBeingDestroyed_FunctionAddress;

	private static int IsBeingDestroyed_ParamsSize;

	private static bool IsBeingDestroyed_ReturnValue_IsValid;

	private static FFieldAddress IsBeingDestroyed_ReturnValue_PropertyAddress;

	private static int IsBeingDestroyed_ReturnValue_Offset;

	private static bool IsActive_IsValid;

	private static IntPtr IsActive_FunctionAddress;

	private static int IsActive_ParamsSize;

	private static bool IsActive_ReturnValue_IsValid;

	private static FFieldAddress IsActive_ReturnValue_PropertyAddress;

	private static int IsActive_ReturnValue_Offset;

	private static bool GetOwner_IsValid;

	private static IntPtr GetOwner_FunctionAddress;

	private static int GetOwner_ParamsSize;

	private static bool GetOwner_ReturnValue_IsValid;

	private static FFieldAddress GetOwner_ReturnValue_PropertyAddress;

	private static int GetOwner_ReturnValue_Offset;

	private static bool GetComponentTickInterval_IsValid;

	private static IntPtr GetComponentTickInterval_FunctionAddress;

	private static int GetComponentTickInterval_ParamsSize;

	private static bool GetComponentTickInterval_ReturnValue_IsValid;

	private static FFieldAddress GetComponentTickInterval_ReturnValue_PropertyAddress;

	private static int GetComponentTickInterval_ReturnValue_Offset;

	private static bool Deactivate_IsValid;

	private static IntPtr Deactivate_FunctionAddress;

	private static int Deactivate_ParamsSize;

	private static bool ComponentHasTag_IsValid;

	private static IntPtr ComponentHasTag_FunctionAddress;

	private static int ComponentHasTag_ParamsSize;

	private static bool ComponentHasTag_Tag_IsValid;

	private static FFieldAddress ComponentHasTag_Tag_PropertyAddress;

	private static int ComponentHasTag_Tag_Offset;

	private static bool ComponentHasTag_ReturnValue_IsValid;

	private static FFieldAddress ComponentHasTag_ReturnValue_PropertyAddress;

	private static int ComponentHasTag_ReturnValue_Offset;

	private static bool AddTickPrerequisiteComponent_IsValid;

	private static IntPtr AddTickPrerequisiteComponent_FunctionAddress;

	private static int AddTickPrerequisiteComponent_ParamsSize;

	private static bool AddTickPrerequisiteComponent_PrerequisiteComponent_IsValid;

	private static FFieldAddress AddTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress;

	private static int AddTickPrerequisiteComponent_PrerequisiteComponent_Offset;

	private static bool AddTickPrerequisiteActor_IsValid;

	private static IntPtr AddTickPrerequisiteActor_FunctionAddress;

	private static int AddTickPrerequisiteActor_ParamsSize;

	private static bool AddTickPrerequisiteActor_PrerequisiteActor_IsValid;

	private static FFieldAddress AddTickPrerequisiteActor_PrerequisiteActor_PropertyAddress;

	private static int AddTickPrerequisiteActor_PrerequisiteActor_Offset;

	private static bool Activate_IsValid;

	private static IntPtr Activate_FunctionAddress;

	private static int Activate_ParamsSize;

	private static bool Activate_bReset_IsValid;

	private static FFieldAddress Activate_bReset_PropertyAddress;

	private static int Activate_bReset_Offset;

	[UProperty(Flags = (PropFlags)4503599627436033uL)]
	[UMetaPath("/Script/Engine.ActorComponent:PrimaryComponentTick")]
	public FTickFunction PrimaryComponentTick
	{
		get
		{
			CheckDestroyed();
			return new FTickFunction(IntPtr.Add(base.Address, PrimaryComponentTick_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.ActorComponent:ComponentTags")]
	public TArrayReadWrite<FName> ComponentTags
	{
		get
		{
			CheckDestroyed();
			if (!ComponentTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:ComponentTags");
				return null;
			}
			if (ComponentTags_MarshalerCached == null)
			{
				ComponentTags_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, ComponentTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return ComponentTags_MarshalerCached.FromNative(IntPtr.Add(base.Address, ComponentTags_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)20266267042709557uL)]
	[UMetaPath("/Script/Engine.ActorComponent:bReplicates")]
	public bool Replicates
	{
		get
		{
			CheckDestroyed();
			if (!Replicates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:bReplicates");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Replicates_Offset), 0, Replicates_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Replicates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:bReplicates");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Replicates_Offset), 0, Replicates_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.ActorComponent:bAutoActivate")]
	public bool AutoActivate
	{
		get
		{
			CheckDestroyed();
			if (!AutoActivate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:bAutoActivate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoActivate_Offset), 0, AutoActivate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoActivate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:bAutoActivate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoActivate_Offset), 0, AutoActivate_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.ActorComponent:bIsEditorOnly")]
	public bool IsEditorOnly
	{
		get
		{
			CheckDestroyed();
			if (!IsEditorOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:bIsEditorOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsEditorOnly_Offset), 0, IsEditorOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsEditorOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:bIsEditorOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsEditorOnly_Offset), 0, IsEditorOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.ActorComponent:OnComponentActivated")]
	public FActorComponentActivatedSignature OnComponentActivated
	{
		get
		{
			CheckDestroyed();
			if (!OnComponentActivated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:OnComponentActivated");
				return new FActorComponentActivatedSignature();
			}
			if (OnComponentActivated_DelegateCached == null)
			{
				OnComponentActivated_DelegateCached = new FActorComponentActivatedSignature();
				OnComponentActivated_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComponentActivated_Offset));
			}
			return OnComponentActivated_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.ActorComponent:OnComponentDeactivated")]
	public FActorComponentDeactivateSignature OnComponentDeactivated
	{
		get
		{
			CheckDestroyed();
			if (!OnComponentDeactivated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ActorComponent:OnComponentDeactivated");
				return new FActorComponentDeactivateSignature();
			}
			if (OnComponentDeactivated_DelegateCached == null)
			{
				OnComponentDeactivated_DelegateCached = new FActorComponentDeactivateSignature();
				OnComponentDeactivated_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComponentDeactivated_Offset));
			}
			return OnComponentDeactivated_DelegateCached;
		}
	}

	private static void LoadNativeTypeInjected(IntPtr classAddress)
	{
		PrimaryComponentTick_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "PrimaryComponentTick");
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:ToggleActive")]
	public unsafe void ToggleActive()
	{
		CheckDestroyed();
		if (!ToggleActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:ToggleActive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleActive_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ToggleActive_FunctionAddress, argsSize: ToggleActive_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ActorComponent:SetTickGroup")]
	public unsafe void SetTickGroup(ETickingGroup NewTickGroup)
	{
		CheckDestroyed();
		if (!SetTickGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:SetTickGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETickingGroup>.ToNative(IntPtr.Add(intPtr, SetTickGroup_NewTickGroup_Offset), 0, SetTickGroup_NewTickGroup_PropertyAddress.Address, NewTickGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTickGroup_FunctionAddress, intPtr, SetTickGroup_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ActorComponent:SetTickableWhenPaused")]
	public unsafe void SetTickableWhenPaused(bool bTickableWhenPaused)
	{
		CheckDestroyed();
		if (!SetTickableWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:SetTickableWhenPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickableWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickableWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTickableWhenPaused_bTickableWhenPaused_Offset), 0, SetTickableWhenPaused_bTickableWhenPaused_PropertyAddress.Address, bTickableWhenPaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTickableWhenPaused_FunctionAddress, intPtr, SetTickableWhenPaused_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ActorComponent:SetIsReplicated")]
	public unsafe void SetIsReplicated(bool ShouldReplicate)
	{
		CheckDestroyed();
		if (!SetIsReplicated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:SetIsReplicated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsReplicated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsReplicated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsReplicated_ShouldReplicate_Offset), 0, SetIsReplicated_ShouldReplicate_PropertyAddress.Address, ShouldReplicate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsReplicated_FunctionAddress, intPtr, SetIsReplicated_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ActorComponent:SetComponentTickIntervalAndCooldown")]
	public unsafe void SetComponentTickIntervalAndCooldown(float TickInterval)
	{
		CheckDestroyed();
		if (!SetComponentTickIntervalAndCooldown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:SetComponentTickIntervalAndCooldown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetComponentTickIntervalAndCooldown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetComponentTickIntervalAndCooldown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetComponentTickIntervalAndCooldown_TickInterval_Offset), 0, SetComponentTickIntervalAndCooldown_TickInterval_PropertyAddress.Address, TickInterval);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetComponentTickIntervalAndCooldown_FunctionAddress, intPtr, SetComponentTickIntervalAndCooldown_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ActorComponent:SetComponentTickInterval")]
	public unsafe void SetComponentTickInterval(float TickInterval)
	{
		CheckDestroyed();
		if (!SetComponentTickInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:SetComponentTickInterval");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetComponentTickInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetComponentTickInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetComponentTickInterval_TickInterval_Offset), 0, SetComponentTickInterval_TickInterval_PropertyAddress.Address, TickInterval);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetComponentTickInterval_FunctionAddress, intPtr, SetComponentTickInterval_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:SetComponentTickEnabled")]
	public unsafe void SetComponentTickEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetComponentTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:SetComponentTickEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetComponentTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetComponentTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetComponentTickEnabled_bEnabled_Offset), 0, SetComponentTickEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetComponentTickEnabled_FunctionAddress, intPtr, SetComponentTickEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:SetAutoActivate")]
	public unsafe void SetAutoActivate(bool bNewAutoActivate)
	{
		CheckDestroyed();
		if (!SetAutoActivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:SetAutoActivate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAutoActivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAutoActivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAutoActivate_bNewAutoActivate_Offset), 0, SetAutoActivate_bNewAutoActivate_PropertyAddress.Address, bNewAutoActivate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAutoActivate_FunctionAddress, intPtr, SetAutoActivate_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:SetActive")]
	public unsafe void SetActive(bool bNewActive, bool bReset = false)
	{
		CheckDestroyed();
		if (!SetActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:SetActive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActive_bNewActive_Offset), 0, SetActive_bNewActive_PropertyAddress.Address, bNewActive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActive_bReset_Offset), 0, SetActive_bReset_PropertyAddress.Address, bReset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActive_FunctionAddress, intPtr, SetActive_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:RemoveTickPrerequisiteComponent")]
	public unsafe void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
	{
		CheckDestroyed();
		if (!RemoveTickPrerequisiteComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:RemoveTickPrerequisiteComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTickPrerequisiteComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTickPrerequisiteComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, RemoveTickPrerequisiteComponent_PrerequisiteComponent_Offset), 0, RemoveTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress.Address, PrerequisiteComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTickPrerequisiteComponent_FunctionAddress, intPtr, RemoveTickPrerequisiteComponent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:RemoveTickPrerequisiteActor")]
	public unsafe void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
	{
		CheckDestroyed();
		if (!RemoveTickPrerequisiteActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:RemoveTickPrerequisiteActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTickPrerequisiteActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTickPrerequisiteActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveTickPrerequisiteActor_PrerequisiteActor_Offset), 0, RemoveTickPrerequisiteActor_PrerequisiteActor_PropertyAddress.Address, PrerequisiteActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTickPrerequisiteActor_FunctionAddress, intPtr, RemoveTickPrerequisiteActor_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.ActorComponent:ReceiveTick")]
	public unsafe void ReceiveTick(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:ReceiveTick");
			return;
		}
		if (ReceiveTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTick_DeltaSeconds_Offset), 0, ReceiveTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTick_InstanceFunctionAddress, intPtr, ReceiveTick_ParamsSize);
	}

	protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:ReceiveTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTick_DeltaSeconds_Offset), 0, ReceiveTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTick_FunctionAddress, intPtr, ReceiveTick_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.ActorComponent:ReceiveEndPlay")]
	public unsafe void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!ReceiveEndPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:ReceiveEndPlay");
			return;
		}
		if (ReceiveEndPlay_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveEndPlay_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveEndPlay");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveEndPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveEndPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveEndPlay_InstanceFunctionAddress, intPtr, ReceiveEndPlay_ParamsSize);
	}

	protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!ReceiveEndPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:ReceiveEndPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveEndPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveEndPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveEndPlay_FunctionAddress, intPtr, ReceiveEndPlay_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.ActorComponent:ReceiveBeginPlay")]
	public unsafe void ReceiveBeginPlay()
	{
		CheckDestroyed();
		if (!ReceiveBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:ReceiveBeginPlay");
			return;
		}
		if (ReceiveBeginPlay_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveBeginPlay_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveBeginPlay");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveBeginPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveBeginPlay_InstanceFunctionAddress, argsSize: ReceiveBeginPlay_ParamsSize);
	}

	protected unsafe virtual void ReceiveBeginPlay_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:ReceiveBeginPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveBeginPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveBeginPlay_FunctionAddress, argsSize: ReceiveBeginPlay_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_DestroyComponent")]
	[UMetaPath("/Script/Engine.ActorComponent:K2_DestroyComponent")]
	public unsafe void DestroyComponent(UObject Object)
	{
		CheckDestroyed();
		if (!DestroyComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:K2_DestroyComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DestroyComponent_Object_Offset), 0, DestroyComponent_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, DestroyComponent_FunctionAddress, intPtr, DestroyComponent_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.ActorComponent:IsComponentTickEnabled")]
	public unsafe bool IsComponentTickEnabled()
	{
		CheckDestroyed();
		if (!IsComponentTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:IsComponentTickEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsComponentTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsComponentTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsComponentTickEnabled_FunctionAddress, intPtr, IsComponentTickEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsComponentTickEnabled_ReturnValue_Offset), 0, IsComponentTickEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.ActorComponent:IsBeingDestroyed")]
	public unsafe bool IsBeingDestroyed()
	{
		CheckDestroyed();
		if (!IsBeingDestroyed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:IsBeingDestroyed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBeingDestroyed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBeingDestroyed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBeingDestroyed_FunctionAddress, intPtr, IsBeingDestroyed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBeingDestroyed_ReturnValue_Offset), 0, IsBeingDestroyed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.ActorComponent:IsActive")]
	public unsafe bool IsActive()
	{
		CheckDestroyed();
		if (!IsActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:IsActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActive_FunctionAddress, intPtr, IsActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActive_ReturnValue_Offset), 0, IsActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.ActorComponent:GetOwner")]
	public unsafe AActor GetOwner()
	{
		CheckDestroyed();
		if (!GetOwner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:GetOwner");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwner_FunctionAddress, intPtr, GetOwner_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetOwner_ReturnValue_Offset), 0, GetOwner_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.ActorComponent:GetComponentTickInterval")]
	public unsafe float GetComponentTickInterval()
	{
		CheckDestroyed();
		if (!GetComponentTickInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:GetComponentTickInterval");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponentTickInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponentTickInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComponentTickInterval_FunctionAddress, intPtr, GetComponentTickInterval_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetComponentTickInterval_ReturnValue_Offset), 0, GetComponentTickInterval_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:Deactivate")]
	public unsafe void Deactivate()
	{
		CheckDestroyed();
		if (!Deactivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:Deactivate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Deactivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Deactivate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Deactivate_FunctionAddress, argsSize: Deactivate_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.ActorComponent:ComponentHasTag")]
	public unsafe bool ComponentHasTag(FName Tag)
	{
		CheckDestroyed();
		if (!ComponentHasTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:ComponentHasTag");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComponentHasTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentHasTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ComponentHasTag_Tag_Offset), 0, ComponentHasTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeFunctionOptimized(base.Address, ComponentHasTag_FunctionAddress, intPtr, ComponentHasTag_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ComponentHasTag_ReturnValue_Offset), 0, ComponentHasTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:AddTickPrerequisiteComponent")]
	public unsafe void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
	{
		CheckDestroyed();
		if (!AddTickPrerequisiteComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:AddTickPrerequisiteComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTickPrerequisiteComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTickPrerequisiteComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, AddTickPrerequisiteComponent_PrerequisiteComponent_Offset), 0, AddTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress.Address, PrerequisiteComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTickPrerequisiteComponent_FunctionAddress, intPtr, AddTickPrerequisiteComponent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:AddTickPrerequisiteActor")]
	public unsafe void AddTickPrerequisiteActor(AActor PrerequisiteActor)
	{
		CheckDestroyed();
		if (!AddTickPrerequisiteActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:AddTickPrerequisiteActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTickPrerequisiteActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTickPrerequisiteActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddTickPrerequisiteActor_PrerequisiteActor_Offset), 0, AddTickPrerequisiteActor_PrerequisiteActor_PropertyAddress.Address, PrerequisiteActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTickPrerequisiteActor_FunctionAddress, intPtr, AddTickPrerequisiteActor_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ActorComponent:Activate")]
	public unsafe void Activate(bool bReset = false)
	{
		CheckDestroyed();
		if (!Activate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponent:Activate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Activate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Activate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Activate_bReset_Offset), 0, Activate_bReset_PropertyAddress.Address, bReset);
		NativeReflection.InvokeFunctionOptimized(base.Address, Activate_FunctionAddress, intPtr, Activate_ParamsSize);
	}

	static UActorComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UActorComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UActorComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.ActorComponent");
		NativeReflectionCached.GetPropertyRef(ref ComponentTags_PropertyAddress, intPtr, "ComponentTags");
		ComponentTags_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentTags");
		ComponentTags_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentTags", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Replicates_PropertyAddress, intPtr, "bReplicates");
		Replicates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReplicates");
		Replicates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReplicates", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoActivate_PropertyAddress, intPtr, "bAutoActivate");
		AutoActivate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoActivate");
		AutoActivate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoActivate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEditorOnly_PropertyAddress, intPtr, "bIsEditorOnly");
		IsEditorOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsEditorOnly");
		IsEditorOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsEditorOnly", Classes.FBoolProperty);
		OnComponentActivated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComponentActivated");
		OnComponentActivated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComponentActivated", Classes.FMulticastDelegateProperty);
		OnComponentDeactivated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComponentDeactivated");
		OnComponentDeactivated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComponentDeactivated", Classes.FMulticastDelegateProperty);
		ToggleActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToggleActive");
		ToggleActive_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleActive_FunctionAddress);
		ToggleActive_IsValid = ToggleActive_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:ToggleActive", ToggleActive_IsValid);
		SetTickGroup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTickGroup");
		SetTickGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickGroup_NewTickGroup_PropertyAddress, SetTickGroup_FunctionAddress, "NewTickGroup");
		SetTickGroup_NewTickGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetTickGroup_FunctionAddress, "NewTickGroup");
		SetTickGroup_NewTickGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickGroup_FunctionAddress, "NewTickGroup", Classes.FByteProperty);
		SetTickGroup_IsValid = SetTickGroup_FunctionAddress != IntPtr.Zero && SetTickGroup_NewTickGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:SetTickGroup", SetTickGroup_IsValid);
		SetTickableWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTickableWhenPaused");
		SetTickableWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickableWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickableWhenPaused_bTickableWhenPaused_PropertyAddress, SetTickableWhenPaused_FunctionAddress, "bTickableWhenPaused");
		SetTickableWhenPaused_bTickableWhenPaused_Offset = NativeReflectionCached.GetPropertyOffset(SetTickableWhenPaused_FunctionAddress, "bTickableWhenPaused");
		SetTickableWhenPaused_bTickableWhenPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickableWhenPaused_FunctionAddress, "bTickableWhenPaused", Classes.FBoolProperty);
		SetTickableWhenPaused_IsValid = SetTickableWhenPaused_FunctionAddress != IntPtr.Zero && SetTickableWhenPaused_bTickableWhenPaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:SetTickableWhenPaused", SetTickableWhenPaused_IsValid);
		SetIsReplicated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsReplicated");
		SetIsReplicated_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsReplicated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsReplicated_ShouldReplicate_PropertyAddress, SetIsReplicated_FunctionAddress, "ShouldReplicate");
		SetIsReplicated_ShouldReplicate_Offset = NativeReflectionCached.GetPropertyOffset(SetIsReplicated_FunctionAddress, "ShouldReplicate");
		SetIsReplicated_ShouldReplicate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsReplicated_FunctionAddress, "ShouldReplicate", Classes.FBoolProperty);
		SetIsReplicated_IsValid = SetIsReplicated_FunctionAddress != IntPtr.Zero && SetIsReplicated_ShouldReplicate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:SetIsReplicated", SetIsReplicated_IsValid);
		SetComponentTickIntervalAndCooldown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetComponentTickIntervalAndCooldown");
		SetComponentTickIntervalAndCooldown_ParamsSize = NativeReflection.GetFunctionParamsSize(SetComponentTickIntervalAndCooldown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetComponentTickIntervalAndCooldown_TickInterval_PropertyAddress, SetComponentTickIntervalAndCooldown_FunctionAddress, "TickInterval");
		SetComponentTickIntervalAndCooldown_TickInterval_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentTickIntervalAndCooldown_FunctionAddress, "TickInterval");
		SetComponentTickIntervalAndCooldown_TickInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentTickIntervalAndCooldown_FunctionAddress, "TickInterval", Classes.FFloatProperty);
		SetComponentTickIntervalAndCooldown_IsValid = SetComponentTickIntervalAndCooldown_FunctionAddress != IntPtr.Zero && SetComponentTickIntervalAndCooldown_TickInterval_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:SetComponentTickIntervalAndCooldown", SetComponentTickIntervalAndCooldown_IsValid);
		SetComponentTickInterval_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetComponentTickInterval");
		SetComponentTickInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(SetComponentTickInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetComponentTickInterval_TickInterval_PropertyAddress, SetComponentTickInterval_FunctionAddress, "TickInterval");
		SetComponentTickInterval_TickInterval_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentTickInterval_FunctionAddress, "TickInterval");
		SetComponentTickInterval_TickInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentTickInterval_FunctionAddress, "TickInterval", Classes.FFloatProperty);
		SetComponentTickInterval_IsValid = SetComponentTickInterval_FunctionAddress != IntPtr.Zero && SetComponentTickInterval_TickInterval_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:SetComponentTickInterval", SetComponentTickInterval_IsValid);
		SetComponentTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetComponentTickEnabled");
		SetComponentTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetComponentTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetComponentTickEnabled_bEnabled_PropertyAddress, SetComponentTickEnabled_FunctionAddress, "bEnabled");
		SetComponentTickEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentTickEnabled_FunctionAddress, "bEnabled");
		SetComponentTickEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentTickEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetComponentTickEnabled_IsValid = SetComponentTickEnabled_FunctionAddress != IntPtr.Zero && SetComponentTickEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:SetComponentTickEnabled", SetComponentTickEnabled_IsValid);
		SetAutoActivate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAutoActivate");
		SetAutoActivate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAutoActivate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAutoActivate_bNewAutoActivate_PropertyAddress, SetAutoActivate_FunctionAddress, "bNewAutoActivate");
		SetAutoActivate_bNewAutoActivate_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoActivate_FunctionAddress, "bNewAutoActivate");
		SetAutoActivate_bNewAutoActivate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoActivate_FunctionAddress, "bNewAutoActivate", Classes.FBoolProperty);
		SetAutoActivate_IsValid = SetAutoActivate_FunctionAddress != IntPtr.Zero && SetAutoActivate_bNewAutoActivate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:SetAutoActivate", SetAutoActivate_IsValid);
		SetActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActive");
		SetActive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActive_bNewActive_PropertyAddress, SetActive_FunctionAddress, "bNewActive");
		SetActive_bNewActive_Offset = NativeReflectionCached.GetPropertyOffset(SetActive_FunctionAddress, "bNewActive");
		SetActive_bNewActive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActive_FunctionAddress, "bNewActive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActive_bReset_PropertyAddress, SetActive_FunctionAddress, "bReset");
		SetActive_bReset_Offset = NativeReflectionCached.GetPropertyOffset(SetActive_FunctionAddress, "bReset");
		SetActive_bReset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActive_FunctionAddress, "bReset", Classes.FBoolProperty);
		SetActive_IsValid = SetActive_FunctionAddress != IntPtr.Zero && SetActive_bNewActive_IsValid && SetActive_bReset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:SetActive", SetActive_IsValid);
		RemoveTickPrerequisiteComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveTickPrerequisiteComponent");
		RemoveTickPrerequisiteComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTickPrerequisiteComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress, RemoveTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent");
		RemoveTickPrerequisiteComponent_PrerequisiteComponent_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent");
		RemoveTickPrerequisiteComponent_PrerequisiteComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent", Classes.FObjectProperty);
		RemoveTickPrerequisiteComponent_IsValid = RemoveTickPrerequisiteComponent_FunctionAddress != IntPtr.Zero && RemoveTickPrerequisiteComponent_PrerequisiteComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:RemoveTickPrerequisiteComponent", RemoveTickPrerequisiteComponent_IsValid);
		RemoveTickPrerequisiteActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveTickPrerequisiteActor");
		RemoveTickPrerequisiteActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTickPrerequisiteActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTickPrerequisiteActor_PrerequisiteActor_PropertyAddress, RemoveTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor");
		RemoveTickPrerequisiteActor_PrerequisiteActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor");
		RemoveTickPrerequisiteActor_PrerequisiteActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor", Classes.FObjectProperty);
		RemoveTickPrerequisiteActor_IsValid = RemoveTickPrerequisiteActor_FunctionAddress != IntPtr.Zero && RemoveTickPrerequisiteActor_PrerequisiteActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:RemoveTickPrerequisiteActor", RemoveTickPrerequisiteActor_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_DeltaSeconds_PropertyAddress, ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:ReceiveTick", ReceiveTick_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FByteProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
		DestroyComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_DestroyComponent");
		DestroyComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyComponent_Object_PropertyAddress, DestroyComponent_FunctionAddress, "Object");
		DestroyComponent_Object_Offset = NativeReflectionCached.GetPropertyOffset(DestroyComponent_FunctionAddress, "Object");
		DestroyComponent_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyComponent_FunctionAddress, "Object", Classes.FObjectProperty);
		DestroyComponent_IsValid = DestroyComponent_FunctionAddress != IntPtr.Zero && DestroyComponent_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:K2_DestroyComponent", DestroyComponent_IsValid);
		IsComponentTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsComponentTickEnabled");
		IsComponentTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsComponentTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsComponentTickEnabled_ReturnValue_PropertyAddress, IsComponentTickEnabled_FunctionAddress, "ReturnValue");
		IsComponentTickEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsComponentTickEnabled_FunctionAddress, "ReturnValue");
		IsComponentTickEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsComponentTickEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsComponentTickEnabled_IsValid = IsComponentTickEnabled_FunctionAddress != IntPtr.Zero && IsComponentTickEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:IsComponentTickEnabled", IsComponentTickEnabled_IsValid);
		IsBeingDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsBeingDestroyed");
		IsBeingDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBeingDestroyed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBeingDestroyed_ReturnValue_PropertyAddress, IsBeingDestroyed_FunctionAddress, "ReturnValue");
		IsBeingDestroyed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBeingDestroyed_FunctionAddress, "ReturnValue");
		IsBeingDestroyed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBeingDestroyed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBeingDestroyed_IsValid = IsBeingDestroyed_FunctionAddress != IntPtr.Zero && IsBeingDestroyed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:IsBeingDestroyed", IsBeingDestroyed_IsValid);
		IsActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsActive");
		IsActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActive_ReturnValue_PropertyAddress, IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActive_IsValid = IsActive_FunctionAddress != IntPtr.Zero && IsActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:IsActive", IsActive_IsValid);
		GetOwner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwner");
		GetOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwner_ReturnValue_PropertyAddress, GetOwner_FunctionAddress, "ReturnValue");
		GetOwner_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwner_FunctionAddress, "ReturnValue");
		GetOwner_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwner_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwner_IsValid = GetOwner_FunctionAddress != IntPtr.Zero && GetOwner_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:GetOwner", GetOwner_IsValid);
		GetComponentTickInterval_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetComponentTickInterval");
		GetComponentTickInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponentTickInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComponentTickInterval_ReturnValue_PropertyAddress, GetComponentTickInterval_FunctionAddress, "ReturnValue");
		GetComponentTickInterval_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentTickInterval_FunctionAddress, "ReturnValue");
		GetComponentTickInterval_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentTickInterval_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetComponentTickInterval_IsValid = GetComponentTickInterval_FunctionAddress != IntPtr.Zero && GetComponentTickInterval_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:GetComponentTickInterval", GetComponentTickInterval_IsValid);
		Deactivate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Deactivate");
		Deactivate_ParamsSize = NativeReflection.GetFunctionParamsSize(Deactivate_FunctionAddress);
		Deactivate_IsValid = Deactivate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:Deactivate", Deactivate_IsValid);
		ComponentHasTag_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ComponentHasTag");
		ComponentHasTag_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentHasTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentHasTag_Tag_PropertyAddress, ComponentHasTag_FunctionAddress, "Tag");
		ComponentHasTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(ComponentHasTag_FunctionAddress, "Tag");
		ComponentHasTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentHasTag_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentHasTag_ReturnValue_PropertyAddress, ComponentHasTag_FunctionAddress, "ReturnValue");
		ComponentHasTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ComponentHasTag_FunctionAddress, "ReturnValue");
		ComponentHasTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentHasTag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ComponentHasTag_IsValid = ComponentHasTag_FunctionAddress != IntPtr.Zero && ComponentHasTag_Tag_IsValid && ComponentHasTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:ComponentHasTag", ComponentHasTag_IsValid);
		AddTickPrerequisiteComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTickPrerequisiteComponent");
		AddTickPrerequisiteComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTickPrerequisiteComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress, AddTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent");
		AddTickPrerequisiteComponent_PrerequisiteComponent_Offset = NativeReflectionCached.GetPropertyOffset(AddTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent");
		AddTickPrerequisiteComponent_PrerequisiteComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent", Classes.FObjectProperty);
		AddTickPrerequisiteComponent_IsValid = AddTickPrerequisiteComponent_FunctionAddress != IntPtr.Zero && AddTickPrerequisiteComponent_PrerequisiteComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:AddTickPrerequisiteComponent", AddTickPrerequisiteComponent_IsValid);
		AddTickPrerequisiteActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTickPrerequisiteActor");
		AddTickPrerequisiteActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTickPrerequisiteActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTickPrerequisiteActor_PrerequisiteActor_PropertyAddress, AddTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor");
		AddTickPrerequisiteActor_PrerequisiteActor_Offset = NativeReflectionCached.GetPropertyOffset(AddTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor");
		AddTickPrerequisiteActor_PrerequisiteActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor", Classes.FObjectProperty);
		AddTickPrerequisiteActor_IsValid = AddTickPrerequisiteActor_FunctionAddress != IntPtr.Zero && AddTickPrerequisiteActor_PrerequisiteActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:AddTickPrerequisiteActor", AddTickPrerequisiteActor_IsValid);
		Activate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Activate");
		Activate_ParamsSize = NativeReflection.GetFunctionParamsSize(Activate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Activate_bReset_PropertyAddress, Activate_FunctionAddress, "bReset");
		Activate_bReset_Offset = NativeReflectionCached.GetPropertyOffset(Activate_FunctionAddress, "bReset");
		Activate_bReset_IsValid = NativeReflectionCached.ValidatePropertyClass(Activate_FunctionAddress, "bReset", Classes.FBoolProperty);
		Activate_IsValid = Activate_FunctionAddress != IntPtr.Zero && Activate_bReset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponent:Activate", Activate_IsValid);
		LoadNativeTypeInjected(intPtr);
	}
}
