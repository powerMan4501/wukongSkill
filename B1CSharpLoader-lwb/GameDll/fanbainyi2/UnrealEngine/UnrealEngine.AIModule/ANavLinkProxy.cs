using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.NavLinkProxy", "AIModule", UnrealModuleType.Engine)]
public class ANavLinkProxy : AActor, INavLinkHostInterface, IInterface, INavRelevantInterface
{
	private static bool PointLinks_IsValid;

	private static FFieldAddress PointLinks_PropertyAddress;

	private static int PointLinks_Offset;

	private TArrayReadOnlyMarshaler<FNavigationLink> PointLinks_MarshalerCached;

	private static bool OnSmartLinkReached_IsValid;

	private static int OnSmartLinkReached_Offset;

	private FSmartLinkReachedSignature OnSmartLinkReached_DelegateCached;

	private static bool SetSmartLinkEnabled_IsValid;

	private static IntPtr SetSmartLinkEnabled_FunctionAddress;

	private static int SetSmartLinkEnabled_ParamsSize;

	private static bool SetSmartLinkEnabled_bEnabled_IsValid;

	private static FFieldAddress SetSmartLinkEnabled_bEnabled_PropertyAddress;

	private static int SetSmartLinkEnabled_bEnabled_Offset;

	private static bool ResumePathFollowing_IsValid;

	private static IntPtr ResumePathFollowing_FunctionAddress;

	private static int ResumePathFollowing_ParamsSize;

	private static bool ResumePathFollowing_Agent_IsValid;

	private static FFieldAddress ResumePathFollowing_Agent_PropertyAddress;

	private static int ResumePathFollowing_Agent_Offset;

	private static bool ReceiveSmartLinkReached_IsValid;

	private IntPtr ReceiveSmartLinkReached_InstanceFunctionAddress;

	private static IntPtr ReceiveSmartLinkReached_FunctionAddress;

	private static int ReceiveSmartLinkReached_ParamsSize;

	private static bool ReceiveSmartLinkReached_Agent_IsValid;

	private static FFieldAddress ReceiveSmartLinkReached_Agent_PropertyAddress;

	private static int ReceiveSmartLinkReached_Agent_Offset;

	private static bool ReceiveSmartLinkReached_Destination_IsValid;

	private static FFieldAddress ReceiveSmartLinkReached_Destination_PropertyAddress;

	private static int ReceiveSmartLinkReached_Destination_Offset;

	private static bool IsSmartLinkEnabled_IsValid;

	private static IntPtr IsSmartLinkEnabled_FunctionAddress;

	private static int IsSmartLinkEnabled_ParamsSize;

	private static bool IsSmartLinkEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsSmartLinkEnabled_ReturnValue_PropertyAddress;

	private static int IsSmartLinkEnabled_ReturnValue_Offset;

	private static bool HasMovingAgents_IsValid;

	private static IntPtr HasMovingAgents_FunctionAddress;

	private static int HasMovingAgents_ParamsSize;

	private static bool HasMovingAgents_ReturnValue_IsValid;

	private static FFieldAddress HasMovingAgents_ReturnValue_PropertyAddress;

	private static int HasMovingAgents_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/AIModule.NavLinkProxy:PointLinks")]
	public TArrayReadOnly<FNavigationLink> PointLinks
	{
		get
		{
			CheckDestroyed();
			if (!PointLinks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.NavLinkProxy:PointLinks");
				return null;
			}
			if (PointLinks_MarshalerCached == null)
			{
				PointLinks_MarshalerCached = new TArrayReadOnlyMarshaler<FNavigationLink>(1, PointLinks_PropertyAddress, CachedMarshalingDelegates<FNavigationLink, FNavigationLink>.FromNative, CachedMarshalingDelegates<FNavigationLink, FNavigationLink>.ToNative);
			}
			return PointLinks_MarshalerCached.FromNative(IntPtr.Add(base.Address, PointLinks_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/AIModule.NavLinkProxy:OnSmartLinkReached")]
	protected FSmartLinkReachedSignature OnSmartLinkReached
	{
		get
		{
			CheckDestroyed();
			if (!OnSmartLinkReached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.NavLinkProxy:OnSmartLinkReached");
				return new FSmartLinkReachedSignature();
			}
			if (OnSmartLinkReached_DelegateCached == null)
			{
				OnSmartLinkReached_DelegateCached = new FSmartLinkReachedSignature();
				OnSmartLinkReached_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSmartLinkReached_Offset));
			}
			return OnSmartLinkReached_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.NavLinkProxy:SetSmartLinkEnabled")]
	public unsafe void SetSmartLinkEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetSmartLinkEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.NavLinkProxy:SetSmartLinkEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSmartLinkEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSmartLinkEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSmartLinkEnabled_bEnabled_Offset), 0, SetSmartLinkEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSmartLinkEnabled_FunctionAddress, intPtr, SetSmartLinkEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.NavLinkProxy:ResumePathFollowing")]
	public unsafe void ResumePathFollowing(AActor Agent)
	{
		CheckDestroyed();
		if (!ResumePathFollowing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.NavLinkProxy:ResumePathFollowing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumePathFollowing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumePathFollowing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ResumePathFollowing_Agent_Offset), 0, ResumePathFollowing_Agent_PropertyAddress.Address, Agent);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResumePathFollowing_FunctionAddress, intPtr, ResumePathFollowing_ParamsSize);
	}

	[UFunction(Flags = 146933760u)]
	[UMetaPath("/Script/AIModule.NavLinkProxy:ReceiveSmartLinkReached")]
	public unsafe void ReceiveSmartLinkReached(AActor Agent, FVector Destination)
	{
		CheckDestroyed();
		if (!ReceiveSmartLinkReached_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.NavLinkProxy:ReceiveSmartLinkReached");
			return;
		}
		if (ReceiveSmartLinkReached_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveSmartLinkReached_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveSmartLinkReached");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveSmartLinkReached_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveSmartLinkReached_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveSmartLinkReached_Agent_Offset), 0, ReceiveSmartLinkReached_Agent_PropertyAddress.Address, Agent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveSmartLinkReached_Destination_Offset), 0, ReceiveSmartLinkReached_Destination_PropertyAddress.Address, Destination);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveSmartLinkReached_InstanceFunctionAddress, intPtr, ReceiveSmartLinkReached_ParamsSize);
	}

	protected unsafe virtual void ReceiveSmartLinkReached_Implementation(AActor Agent, FVector Destination)
	{
		CheckDestroyed();
		if (!ReceiveSmartLinkReached_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.NavLinkProxy:ReceiveSmartLinkReached");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveSmartLinkReached_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveSmartLinkReached_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveSmartLinkReached_Agent_Offset), 0, ReceiveSmartLinkReached_Agent_PropertyAddress.Address, Agent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveSmartLinkReached_Destination_Offset), 0, ReceiveSmartLinkReached_Destination_PropertyAddress.Address, Destination);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveSmartLinkReached_FunctionAddress, intPtr, ReceiveSmartLinkReached_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.NavLinkProxy:IsSmartLinkEnabled")]
	public unsafe bool IsSmartLinkEnabled()
	{
		CheckDestroyed();
		if (!IsSmartLinkEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.NavLinkProxy:IsSmartLinkEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSmartLinkEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSmartLinkEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSmartLinkEnabled_FunctionAddress, intPtr, IsSmartLinkEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSmartLinkEnabled_ReturnValue_Offset), 0, IsSmartLinkEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.NavLinkProxy:HasMovingAgents")]
	public unsafe bool HasMovingAgents()
	{
		CheckDestroyed();
		if (!HasMovingAgents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.NavLinkProxy:HasMovingAgents");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMovingAgents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMovingAgents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasMovingAgents_FunctionAddress, intPtr, HasMovingAgents_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMovingAgents_ReturnValue_Offset), 0, HasMovingAgents_ReturnValue_PropertyAddress.Address);
	}

	static ANavLinkProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ANavLinkProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ANavLinkProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.NavLinkProxy");
		NativeReflectionCached.GetPropertyRef(ref PointLinks_PropertyAddress, intPtr, "PointLinks");
		PointLinks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PointLinks");
		PointLinks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PointLinks", Classes.FArrayProperty);
		OnSmartLinkReached_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSmartLinkReached");
		OnSmartLinkReached_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSmartLinkReached", Classes.FMulticastDelegateProperty);
		SetSmartLinkEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSmartLinkEnabled");
		SetSmartLinkEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSmartLinkEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSmartLinkEnabled_bEnabled_PropertyAddress, SetSmartLinkEnabled_FunctionAddress, "bEnabled");
		SetSmartLinkEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetSmartLinkEnabled_FunctionAddress, "bEnabled");
		SetSmartLinkEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSmartLinkEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetSmartLinkEnabled_IsValid = SetSmartLinkEnabled_FunctionAddress != IntPtr.Zero && SetSmartLinkEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.NavLinkProxy:SetSmartLinkEnabled", SetSmartLinkEnabled_IsValid);
		ResumePathFollowing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResumePathFollowing");
		ResumePathFollowing_ParamsSize = NativeReflection.GetFunctionParamsSize(ResumePathFollowing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResumePathFollowing_Agent_PropertyAddress, ResumePathFollowing_FunctionAddress, "Agent");
		ResumePathFollowing_Agent_Offset = NativeReflectionCached.GetPropertyOffset(ResumePathFollowing_FunctionAddress, "Agent");
		ResumePathFollowing_Agent_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumePathFollowing_FunctionAddress, "Agent", Classes.FObjectProperty);
		ResumePathFollowing_IsValid = ResumePathFollowing_FunctionAddress != IntPtr.Zero && ResumePathFollowing_Agent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.NavLinkProxy:ResumePathFollowing", ResumePathFollowing_IsValid);
		ReceiveSmartLinkReached_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveSmartLinkReached");
		ReceiveSmartLinkReached_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveSmartLinkReached_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveSmartLinkReached_Agent_PropertyAddress, ReceiveSmartLinkReached_FunctionAddress, "Agent");
		ReceiveSmartLinkReached_Agent_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveSmartLinkReached_FunctionAddress, "Agent");
		ReceiveSmartLinkReached_Agent_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveSmartLinkReached_FunctionAddress, "Agent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveSmartLinkReached_Destination_PropertyAddress, ReceiveSmartLinkReached_FunctionAddress, "Destination");
		ReceiveSmartLinkReached_Destination_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveSmartLinkReached_FunctionAddress, "Destination");
		ReceiveSmartLinkReached_Destination_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveSmartLinkReached_FunctionAddress, "Destination", Classes.FStructProperty);
		ReceiveSmartLinkReached_IsValid = ReceiveSmartLinkReached_FunctionAddress != IntPtr.Zero && ReceiveSmartLinkReached_Agent_IsValid && ReceiveSmartLinkReached_Destination_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.NavLinkProxy:ReceiveSmartLinkReached", ReceiveSmartLinkReached_IsValid);
		IsSmartLinkEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSmartLinkEnabled");
		IsSmartLinkEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSmartLinkEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSmartLinkEnabled_ReturnValue_PropertyAddress, IsSmartLinkEnabled_FunctionAddress, "ReturnValue");
		IsSmartLinkEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSmartLinkEnabled_FunctionAddress, "ReturnValue");
		IsSmartLinkEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSmartLinkEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSmartLinkEnabled_IsValid = IsSmartLinkEnabled_FunctionAddress != IntPtr.Zero && IsSmartLinkEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.NavLinkProxy:IsSmartLinkEnabled", IsSmartLinkEnabled_IsValid);
		HasMovingAgents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasMovingAgents");
		HasMovingAgents_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMovingAgents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMovingAgents_ReturnValue_PropertyAddress, HasMovingAgents_FunctionAddress, "ReturnValue");
		HasMovingAgents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMovingAgents_FunctionAddress, "ReturnValue");
		HasMovingAgents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMovingAgents_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMovingAgents_IsValid = HasMovingAgents_FunctionAddress != IntPtr.Zero && HasMovingAgents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.NavLinkProxy:HasMovingAgents", HasMovingAgents_IsValid);
	}
}
