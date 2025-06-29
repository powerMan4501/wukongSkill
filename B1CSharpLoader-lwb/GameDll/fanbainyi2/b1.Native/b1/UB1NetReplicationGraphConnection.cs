using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ReplicationGraph;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500840uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.B1NetReplicationGraphConnection", "b1", UnrealModuleType.Game)]
public class UB1NetReplicationGraphConnection : UNetReplicationGraphConnection
{
	private static bool SetActorNotDormantOnConnectionCS_IsValid;

	private static IntPtr SetActorNotDormantOnConnectionCS_FunctionAddress;

	private static int SetActorNotDormantOnConnectionCS_ParamsSize;

	private static bool SetActorNotDormantOnConnectionCS_InActor_IsValid;

	private static FFieldAddress SetActorNotDormantOnConnectionCS_InActor_PropertyAddress;

	private static int SetActorNotDormantOnConnectionCS_InActor_Offset;

	private static bool NotifyActorChannelRemovedCS_IsValid;

	private IntPtr NotifyActorChannelRemovedCS_InstanceFunctionAddress;

	private static IntPtr NotifyActorChannelRemovedCS_FunctionAddress;

	private static int NotifyActorChannelRemovedCS_ParamsSize;

	private static bool NotifyActorChannelRemovedCS_Actor_IsValid;

	private static FFieldAddress NotifyActorChannelRemovedCS_Actor_PropertyAddress;

	private static int NotifyActorChannelRemovedCS_Actor_Offset;

	private static bool NotifyActorChannelCleanedUpCS_IsValid;

	private IntPtr NotifyActorChannelCleanedUpCS_InstanceFunctionAddress;

	private static IntPtr NotifyActorChannelCleanedUpCS_FunctionAddress;

	private static int NotifyActorChannelCleanedUpCS_ParamsSize;

	private static bool NotifyActorChannelCleanedUpCS_ActorChannel_IsValid;

	private static FFieldAddress NotifyActorChannelCleanedUpCS_ActorChannel_PropertyAddress;

	private static int NotifyActorChannelCleanedUpCS_ActorChannel_Offset;

	private static bool NotifyActorChannelCleanedUpCS_CloseReason_IsValid;

	private static FFieldAddress NotifyActorChannelCleanedUpCS_CloseReason_PropertyAddress;

	private static int NotifyActorChannelCleanedUpCS_CloseReason_Offset;

	private static bool NotifyActorChannelAddedCS_IsValid;

	private IntPtr NotifyActorChannelAddedCS_InstanceFunctionAddress;

	private static IntPtr NotifyActorChannelAddedCS_FunctionAddress;

	private static int NotifyActorChannelAddedCS_ParamsSize;

	private static bool NotifyActorChannelAddedCS_Actor_IsValid;

	private static FFieldAddress NotifyActorChannelAddedCS_Actor_PropertyAddress;

	private static int NotifyActorChannelAddedCS_Actor_Offset;

	private static bool NotifyActorChannelAddedCS_Channel_IsValid;

	private static FFieldAddress NotifyActorChannelAddedCS_Channel_PropertyAddress;

	private static int NotifyActorChannelAddedCS_Channel_Offset;

	private static bool IsInServerReal_IsValid;

	private static IntPtr IsInServerReal_FunctionAddress;

	private static int IsInServerReal_ParamsSize;

	private static bool IsInServerReal_ReturnValue_IsValid;

	private static FFieldAddress IsInServerReal_ReturnValue_PropertyAddress;

	private static int IsInServerReal_ReturnValue_Offset;

	private static bool GSAddB1ActorChannel_IsValid;

	private static IntPtr GSAddB1ActorChannel_FunctionAddress;

	private static int GSAddB1ActorChannel_ParamsSize;

	private static bool GSAddB1ActorChannel_Actor_IsValid;

	private static FFieldAddress GSAddB1ActorChannel_Actor_PropertyAddress;

	private static int GSAddB1ActorChannel_Actor_Offset;

	private static bool GetPlayerControllerCS_IsValid;

	private static IntPtr GetPlayerControllerCS_FunctionAddress;

	private static int GetPlayerControllerCS_ParamsSize;

	private static bool GetPlayerControllerCS_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerControllerCS_ReturnValue_PropertyAddress;

	private static int GetPlayerControllerCS_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1NetReplicationGraphConnection:SetActorNotDormantOnConnectionCS")]
	public unsafe void SetActorNotDormantOnConnectionCS(AActor InActor)
	{
		CheckDestroyed();
		if (!SetActorNotDormantOnConnectionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:SetActorNotDormantOnConnectionCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorNotDormantOnConnectionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorNotDormantOnConnectionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorNotDormantOnConnectionCS_InActor_Offset), 0, SetActorNotDormantOnConnectionCS_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorNotDormantOnConnectionCS_FunctionAddress, intPtr, SetActorNotDormantOnConnectionCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelRemovedCS")]
	public unsafe void NotifyActorChannelRemovedCS(AActor Actor)
	{
		CheckDestroyed();
		if (!NotifyActorChannelRemovedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelRemovedCS");
			return;
		}
		if (NotifyActorChannelRemovedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyActorChannelRemovedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyActorChannelRemovedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyActorChannelRemovedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyActorChannelRemovedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelRemovedCS_Actor_Offset), 0, NotifyActorChannelRemovedCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyActorChannelRemovedCS_InstanceFunctionAddress, intPtr, NotifyActorChannelRemovedCS_ParamsSize);
	}

	protected unsafe virtual void NotifyActorChannelRemovedCS_Implementation(AActor Actor)
	{
		CheckDestroyed();
		if (!NotifyActorChannelRemovedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelRemovedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyActorChannelRemovedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyActorChannelRemovedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelRemovedCS_Actor_Offset), 0, NotifyActorChannelRemovedCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyActorChannelRemovedCS_FunctionAddress, intPtr, NotifyActorChannelRemovedCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelCleanedUpCS")]
	public unsafe void NotifyActorChannelCleanedUpCS(UActorChannel ActorChannel, int CloseReason)
	{
		CheckDestroyed();
		if (!NotifyActorChannelCleanedUpCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelCleanedUpCS");
			return;
		}
		if (NotifyActorChannelCleanedUpCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyActorChannelCleanedUpCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyActorChannelCleanedUpCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyActorChannelCleanedUpCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyActorChannelCleanedUpCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorChannel>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelCleanedUpCS_ActorChannel_Offset), 0, NotifyActorChannelCleanedUpCS_ActorChannel_PropertyAddress.Address, ActorChannel);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelCleanedUpCS_CloseReason_Offset), 0, NotifyActorChannelCleanedUpCS_CloseReason_PropertyAddress.Address, CloseReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyActorChannelCleanedUpCS_InstanceFunctionAddress, intPtr, NotifyActorChannelCleanedUpCS_ParamsSize);
	}

	protected unsafe virtual void NotifyActorChannelCleanedUpCS_Implementation(UActorChannel ActorChannel, int CloseReason)
	{
		CheckDestroyed();
		if (!NotifyActorChannelCleanedUpCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelCleanedUpCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyActorChannelCleanedUpCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyActorChannelCleanedUpCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorChannel>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelCleanedUpCS_ActorChannel_Offset), 0, NotifyActorChannelCleanedUpCS_ActorChannel_PropertyAddress.Address, ActorChannel);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelCleanedUpCS_CloseReason_Offset), 0, NotifyActorChannelCleanedUpCS_CloseReason_PropertyAddress.Address, CloseReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyActorChannelCleanedUpCS_FunctionAddress, intPtr, NotifyActorChannelCleanedUpCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelAddedCS")]
	public unsafe void NotifyActorChannelAddedCS(AActor Actor, UActorChannel Channel)
	{
		CheckDestroyed();
		if (!NotifyActorChannelAddedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelAddedCS");
			return;
		}
		if (NotifyActorChannelAddedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyActorChannelAddedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyActorChannelAddedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyActorChannelAddedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyActorChannelAddedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelAddedCS_Actor_Offset), 0, NotifyActorChannelAddedCS_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UActorChannel>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelAddedCS_Channel_Offset), 0, NotifyActorChannelAddedCS_Channel_PropertyAddress.Address, Channel);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyActorChannelAddedCS_InstanceFunctionAddress, intPtr, NotifyActorChannelAddedCS_ParamsSize);
	}

	protected unsafe virtual void NotifyActorChannelAddedCS_Implementation(AActor Actor, UActorChannel Channel)
	{
		CheckDestroyed();
		if (!NotifyActorChannelAddedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelAddedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyActorChannelAddedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyActorChannelAddedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelAddedCS_Actor_Offset), 0, NotifyActorChannelAddedCS_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UActorChannel>.ToNative(IntPtr.Add(intPtr, NotifyActorChannelAddedCS_Channel_Offset), 0, NotifyActorChannelAddedCS_Channel_PropertyAddress.Address, Channel);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyActorChannelAddedCS_FunctionAddress, intPtr, NotifyActorChannelAddedCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1NetReplicationGraphConnection:IsInServerReal")]
	public unsafe bool IsInServerReal()
	{
		CheckDestroyed();
		if (!IsInServerReal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:IsInServerReal");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInServerReal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInServerReal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInServerReal_FunctionAddress, intPtr, IsInServerReal_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInServerReal_ReturnValue_Offset), 0, IsInServerReal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1NetReplicationGraphConnection:GSAddB1ActorChannel")]
	public unsafe void GSAddB1ActorChannel(AActor Actor)
	{
		CheckDestroyed();
		if (!GSAddB1ActorChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:GSAddB1ActorChannel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSAddB1ActorChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSAddB1ActorChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GSAddB1ActorChannel_Actor_Offset), 0, GSAddB1ActorChannel_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSAddB1ActorChannel_FunctionAddress, intPtr, GSAddB1ActorChannel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.B1NetReplicationGraphConnection:GetPlayerControllerCS")]
	public unsafe APlayerController GetPlayerControllerCS()
	{
		CheckDestroyed();
		if (!GetPlayerControllerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1NetReplicationGraphConnection:GetPlayerControllerCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerControllerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerControllerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerControllerCS_FunctionAddress, intPtr, GetPlayerControllerCS_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetPlayerControllerCS_ReturnValue_Offset), 0, GetPlayerControllerCS_ReturnValue_PropertyAddress.Address);
	}

	static UB1NetReplicationGraphConnection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UB1NetReplicationGraphConnection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UB1NetReplicationGraphConnection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.B1NetReplicationGraphConnection");
		SetActorNotDormantOnConnectionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetActorNotDormantOnConnectionCS");
		SetActorNotDormantOnConnectionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorNotDormantOnConnectionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorNotDormantOnConnectionCS_InActor_PropertyAddress, SetActorNotDormantOnConnectionCS_FunctionAddress, "InActor");
		SetActorNotDormantOnConnectionCS_InActor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorNotDormantOnConnectionCS_FunctionAddress, "InActor");
		SetActorNotDormantOnConnectionCS_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorNotDormantOnConnectionCS_FunctionAddress, "InActor", Classes.FObjectProperty);
		SetActorNotDormantOnConnectionCS_IsValid = SetActorNotDormantOnConnectionCS_FunctionAddress != IntPtr.Zero && SetActorNotDormantOnConnectionCS_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1NetReplicationGraphConnection:SetActorNotDormantOnConnectionCS", SetActorNotDormantOnConnectionCS_IsValid);
		NotifyActorChannelRemovedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyActorChannelRemovedCS");
		NotifyActorChannelRemovedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyActorChannelRemovedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyActorChannelRemovedCS_Actor_PropertyAddress, NotifyActorChannelRemovedCS_FunctionAddress, "Actor");
		NotifyActorChannelRemovedCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(NotifyActorChannelRemovedCS_FunctionAddress, "Actor");
		NotifyActorChannelRemovedCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyActorChannelRemovedCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NotifyActorChannelRemovedCS_IsValid = NotifyActorChannelRemovedCS_FunctionAddress != IntPtr.Zero && NotifyActorChannelRemovedCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelRemovedCS", NotifyActorChannelRemovedCS_IsValid);
		NotifyActorChannelCleanedUpCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyActorChannelCleanedUpCS");
		NotifyActorChannelCleanedUpCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyActorChannelCleanedUpCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyActorChannelCleanedUpCS_ActorChannel_PropertyAddress, NotifyActorChannelCleanedUpCS_FunctionAddress, "ActorChannel");
		NotifyActorChannelCleanedUpCS_ActorChannel_Offset = NativeReflectionCached.GetPropertyOffset(NotifyActorChannelCleanedUpCS_FunctionAddress, "ActorChannel");
		NotifyActorChannelCleanedUpCS_ActorChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyActorChannelCleanedUpCS_FunctionAddress, "ActorChannel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyActorChannelCleanedUpCS_CloseReason_PropertyAddress, NotifyActorChannelCleanedUpCS_FunctionAddress, "CloseReason");
		NotifyActorChannelCleanedUpCS_CloseReason_Offset = NativeReflectionCached.GetPropertyOffset(NotifyActorChannelCleanedUpCS_FunctionAddress, "CloseReason");
		NotifyActorChannelCleanedUpCS_CloseReason_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyActorChannelCleanedUpCS_FunctionAddress, "CloseReason", Classes.FIntProperty);
		NotifyActorChannelCleanedUpCS_IsValid = NotifyActorChannelCleanedUpCS_FunctionAddress != IntPtr.Zero && NotifyActorChannelCleanedUpCS_ActorChannel_IsValid && NotifyActorChannelCleanedUpCS_CloseReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelCleanedUpCS", NotifyActorChannelCleanedUpCS_IsValid);
		NotifyActorChannelAddedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyActorChannelAddedCS");
		NotifyActorChannelAddedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyActorChannelAddedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyActorChannelAddedCS_Actor_PropertyAddress, NotifyActorChannelAddedCS_FunctionAddress, "Actor");
		NotifyActorChannelAddedCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(NotifyActorChannelAddedCS_FunctionAddress, "Actor");
		NotifyActorChannelAddedCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyActorChannelAddedCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyActorChannelAddedCS_Channel_PropertyAddress, NotifyActorChannelAddedCS_FunctionAddress, "Channel");
		NotifyActorChannelAddedCS_Channel_Offset = NativeReflectionCached.GetPropertyOffset(NotifyActorChannelAddedCS_FunctionAddress, "Channel");
		NotifyActorChannelAddedCS_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyActorChannelAddedCS_FunctionAddress, "Channel", Classes.FObjectProperty);
		NotifyActorChannelAddedCS_IsValid = NotifyActorChannelAddedCS_FunctionAddress != IntPtr.Zero && NotifyActorChannelAddedCS_Actor_IsValid && NotifyActorChannelAddedCS_Channel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1NetReplicationGraphConnection:NotifyActorChannelAddedCS", NotifyActorChannelAddedCS_IsValid);
		IsInServerReal_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsInServerReal");
		IsInServerReal_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInServerReal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInServerReal_ReturnValue_PropertyAddress, IsInServerReal_FunctionAddress, "ReturnValue");
		IsInServerReal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInServerReal_FunctionAddress, "ReturnValue");
		IsInServerReal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInServerReal_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInServerReal_IsValid = IsInServerReal_FunctionAddress != IntPtr.Zero && IsInServerReal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1NetReplicationGraphConnection:IsInServerReal", IsInServerReal_IsValid);
		GSAddB1ActorChannel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSAddB1ActorChannel");
		GSAddB1ActorChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAddB1ActorChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSAddB1ActorChannel_Actor_PropertyAddress, GSAddB1ActorChannel_FunctionAddress, "Actor");
		GSAddB1ActorChannel_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GSAddB1ActorChannel_FunctionAddress, "Actor");
		GSAddB1ActorChannel_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GSAddB1ActorChannel_FunctionAddress, "Actor", Classes.FObjectProperty);
		GSAddB1ActorChannel_IsValid = GSAddB1ActorChannel_FunctionAddress != IntPtr.Zero && GSAddB1ActorChannel_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1NetReplicationGraphConnection:GSAddB1ActorChannel", GSAddB1ActorChannel_IsValid);
		GetPlayerControllerCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayerControllerCS");
		GetPlayerControllerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerControllerCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerControllerCS_ReturnValue_PropertyAddress, GetPlayerControllerCS_FunctionAddress, "ReturnValue");
		GetPlayerControllerCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerControllerCS_FunctionAddress, "ReturnValue");
		GetPlayerControllerCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerControllerCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlayerControllerCS_IsValid = GetPlayerControllerCS_FunctionAddress != IntPtr.Zero && GetPlayerControllerCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1NetReplicationGraphConnection:GetPlayerControllerCS", GetPlayerControllerCS_IsValid);
	}
}
