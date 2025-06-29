using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUActorBase", "b1", UnrealModuleType.Game)]
public class ABGUActorBase : AActor, IBGUActorI, IInterface, IGenericTeamAgentInterface
{
	private static bool BeginPlayFromLevelStreaming_IsValid;

	private static FFieldAddress BeginPlayFromLevelStreaming_PropertyAddress;

	private static int BeginPlayFromLevelStreaming_Offset;

	private static bool ActorCompContainer_IsValid;

	private static int ActorCompContainer_Offset;

	private static bool EventCollection_IsValid;

	private static int EventCollection_Offset;

	private static bool SetTeamID_IsValid;

	private static IntPtr SetTeamID_FunctionAddress;

	private static int SetTeamID_ParamsSize;

	private static bool SetTeamID_ID_IsValid;

	private static FFieldAddress SetTeamID_ID_PropertyAddress;

	private static int SetTeamID_ID_Offset;

	private static bool SetRootComponentCS_IsValid;

	private static IntPtr SetRootComponentCS_FunctionAddress;

	private static int SetRootComponentCS_ParamsSize;

	private static bool SetRootComponentCS_NewRootComponent_IsValid;

	private static FFieldAddress SetRootComponentCS_NewRootComponent_PropertyAddress;

	private static int SetRootComponentCS_NewRootComponent_Offset;

	private static bool SetCompCanEverAffectNavigation_IsValid;

	private static IntPtr SetCompCanEverAffectNavigation_FunctionAddress;

	private static int SetCompCanEverAffectNavigation_ParamsSize;

	private static bool SetCompCanEverAffectNavigation_ActorComponent_IsValid;

	private static FFieldAddress SetCompCanEverAffectNavigation_ActorComponent_PropertyAddress;

	private static int SetCompCanEverAffectNavigation_ActorComponent_Offset;

	private static bool SetCompCanEverAffectNavigation_bRelevant_IsValid;

	private static FFieldAddress SetCompCanEverAffectNavigation_bRelevant_PropertyAddress;

	private static int SetCompCanEverAffectNavigation_bRelevant_Offset;

	private static bool PostInitializeComponentsCS_IsValid;

	private IntPtr PostInitializeComponentsCS_InstanceFunctionAddress;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	private static bool OnPropertyChanged_IsValid;

	private IntPtr OnPropertyChanged_InstanceFunctionAddress;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static int OnPropertyChanged_MemberName_Offset;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static bool OnPostEditMove_IsValid;

	private IntPtr OnPostEditMove_InstanceFunctionAddress;

	private static IntPtr OnPostEditMove_FunctionAddress;

	private static int OnPostEditMove_ParamsSize;

	private static bool OnPostEditMove_bFinish_IsValid;

	private static FFieldAddress OnPostEditMove_bFinish_PropertyAddress;

	private static int OnPostEditMove_bFinish_Offset;

	private static bool OnConstructionCS_IsValid;

	private IntPtr OnConstructionCS_InstanceFunctionAddress;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	private static int OnConstructionCS_Transform_Offset;

	private static bool GetTeamIDCS_IsValid;

	private IntPtr GetTeamIDCS_InstanceFunctionAddress;

	private static IntPtr GetTeamIDCS_FunctionAddress;

	private static int GetTeamIDCS_ParamsSize;

	private static bool GetTeamIDCS_ReturnValue_IsValid;

	private static FFieldAddress GetTeamIDCS_ReturnValue_PropertyAddress;

	private static int GetTeamIDCS_ReturnValue_Offset;

	private static bool GetTeamID_IsValid;

	private static IntPtr GetTeamID_FunctionAddress;

	private static int GetTeamID_ParamsSize;

	private static bool GetTeamID_ReturnValue_IsValid;

	private static FFieldAddress GetTeamID_ReturnValue_PropertyAddress;

	private static int GetTeamID_ReturnValue_Offset;

	private static bool GetBUSEventCollection_IsValid;

	private static IntPtr GetBUSEventCollection_FunctionAddress;

	private static int GetBUSEventCollection_ParamsSize;

	private static bool GetBUSEventCollection_ReturnValue_IsValid;

	private static FFieldAddress GetBUSEventCollection_ReturnValue_PropertyAddress;

	private static int GetBUSEventCollection_ReturnValue_Offset;

	private static bool GetActorGuidCS_IsValid;

	private IntPtr GetActorGuidCS_InstanceFunctionAddress;

	private static IntPtr GetActorGuidCS_FunctionAddress;

	private static int GetActorGuidCS_ParamsSize;

	private static bool GetActorGuidCS_OutActorGuid_IsValid;

	private static FFieldAddress GetActorGuidCS_OutActorGuid_PropertyAddress;

	private static int GetActorGuidCS_OutActorGuid_Offset;

	private static bool GetActorGuidCS_ReturnValue_IsValid;

	private static FFieldAddress GetActorGuidCS_ReturnValue_PropertyAddress;

	private static int GetActorGuidCS_ReturnValue_Offset;

	private static bool GetActorGuid_IsValid;

	private static IntPtr GetActorGuid_FunctionAddress;

	private static int GetActorGuid_ParamsSize;

	private static bool GetActorGuid_OutActorGuid_IsValid;

	private static FFieldAddress GetActorGuid_OutActorGuid_PropertyAddress;

	private static int GetActorGuid_OutActorGuid_Offset;

	private static bool GetActorGuid_ReturnValue_IsValid;

	private static FFieldAddress GetActorGuid_ReturnValue_PropertyAddress;

	private static int GetActorGuid_ReturnValue_Offset;

	private static bool FullyInit_IsValid;

	private static IntPtr FullyInit_FunctionAddress;

	private static int FullyInit_ParamsSize;

	private static bool ForceRefreshDetailView_IsValid;

	private static IntPtr ForceRefreshDetailView_FunctionAddress;

	private static int ForceRefreshDetailView_ParamsSize;

	private static bool BeginPlayCS_IsValid;

	private IntPtr BeginPlayCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool AttachBaseActorComp_IsValid;

	private static IntPtr AttachBaseActorComp_FunctionAddress;

	private static int AttachBaseActorComp_ParamsSize;

	private static bool AttachBaseActorComp_Comp_IsValid;

	private static FFieldAddress AttachBaseActorComp_Comp_PropertyAddress;

	private static int AttachBaseActorComp_Comp_Offset;

	private static bool ApplyWorldOffsetCS_IsValid;

	private IntPtr ApplyWorldOffsetCS_InstanceFunctionAddress;

	private static IntPtr ApplyWorldOffsetCS_FunctionAddress;

	private static int ApplyWorldOffsetCS_ParamsSize;

	private static bool ApplyWorldOffsetCS_InOffset_IsValid;

	private static FFieldAddress ApplyWorldOffsetCS_InOffset_PropertyAddress;

	private static int ApplyWorldOffsetCS_InOffset_Offset;

	private static bool ApplyWorldOffsetCS_bWorldShift_IsValid;

	private static FFieldAddress ApplyWorldOffsetCS_bWorldShift_PropertyAddress;

	private static int ApplyWorldOffsetCS_bWorldShift_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/b1.BGUActorBase:bBeginPlayFromLevelStreaming")]
	public bool BeginPlayFromLevelStreaming
	{
		get
		{
			CheckDestroyed();
			if (!BeginPlayFromLevelStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUActorBase:bBeginPlayFromLevelStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BeginPlayFromLevelStreaming_Offset), 0, BeginPlayFromLevelStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BeginPlayFromLevelStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUActorBase:bBeginPlayFromLevelStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BeginPlayFromLevelStreaming_Offset), 0, BeginPlayFromLevelStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864955200012uL)]
	[UMetaPath("/Script/b1.BGUActorBase:ActorCompContainer")]
	protected UActorCompContainer ActorCompContainer
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUActorBase:ActorCompContainer");
				return null;
			}
			return UObjectMarshaler<UActorCompContainer>.FromNative(IntPtr.Add(base.Address, ActorCompContainer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorCompContainer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUActorBase:ActorCompContainer");
			}
			else
			{
				UObjectMarshaler<UActorCompContainer>.ToNative(IntPtr.Add(base.Address, ActorCompContainer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864955200012uL)]
	[UMetaPath("/Script/b1.BGUActorBase:EventCollection")]
	protected UBUS_EventCollection EventCollection
	{
		get
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUActorBase:EventCollection");
				return null;
			}
			return UObjectMarshaler<UBUS_EventCollection>.FromNative(IntPtr.Add(base.Address, EventCollection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUActorBase:EventCollection");
			}
			else
			{
				UObjectMarshaler<UBUS_EventCollection>.ToNative(IntPtr.Add(base.Address, EventCollection_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUActorBase:SetTeamID")]
	public unsafe void SetTeamID(int ID)
	{
		CheckDestroyed();
		if (!SetTeamID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:SetTeamID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTeamID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTeamID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTeamID_ID_Offset), 0, SetTeamID_ID_PropertyAddress.Address, ID);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTeamID_FunctionAddress, intPtr, SetTeamID_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGUActorBase:SetRootComponentCS")]
	protected unsafe void SetRootComponentCS(USceneComponent NewRootComponent)
	{
		CheckDestroyed();
		if (!SetRootComponentCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:SetRootComponentCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRootComponentCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRootComponentCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetRootComponentCS_NewRootComponent_Offset), 0, SetRootComponentCS_NewRootComponent_PropertyAddress.Address, NewRootComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRootComponentCS_FunctionAddress, intPtr, SetRootComponentCS_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGUActorBase:SetCompCanEverAffectNavigation")]
	protected unsafe void SetCompCanEverAffectNavigation(UActorComponent ActorComponent, bool bRelevant)
	{
		CheckDestroyed();
		if (!SetCompCanEverAffectNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:SetCompCanEverAffectNavigation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCompCanEverAffectNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCompCanEverAffectNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, SetCompCanEverAffectNavigation_ActorComponent_Offset), 0, SetCompCanEverAffectNavigation_ActorComponent_PropertyAddress.Address, ActorComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCompCanEverAffectNavigation_bRelevant_Offset), 0, SetCompCanEverAffectNavigation_bRelevant_PropertyAddress.Address, bRelevant);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCompCanEverAffectNavigation_FunctionAddress, intPtr, SetCompCanEverAffectNavigation_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUActorBase:PostInitializeComponentsCS")]
	protected unsafe void PostInitializeComponentsCS()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:PostInitializeComponentsCS");
			return;
		}
		if (PostInitializeComponentsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostInitializeComponentsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostInitializeComponentsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_InstanceFunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	protected unsafe virtual void PostInitializeComponentsCS_Implementation()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:PostInitializeComponentsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_FunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUActorBase:OnPropertyChanged")]
	protected unsafe void OnPropertyChanged(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:OnPropertyChanged");
			return;
		}
		if (OnPropertyChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPropertyChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPropertyChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_MemberName_Offset), 0, OnPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_PropertyName_Offset), 0, OnPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPropertyChanged_InstanceFunctionAddress, intPtr, OnPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:OnPropertyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_MemberName_Offset), 0, OnPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_PropertyName_Offset), 0, OnPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPropertyChanged_FunctionAddress, intPtr, OnPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUActorBase:OnPostEditMove")]
	protected unsafe void OnPostEditMove(bool bFinish)
	{
		CheckDestroyed();
		if (!OnPostEditMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:OnPostEditMove");
			return;
		}
		if (OnPostEditMove_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostEditMove_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPostEditMove");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostEditMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostEditMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPostEditMove_bFinish_Offset), 0, OnPostEditMove_bFinish_PropertyAddress.Address, bFinish);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostEditMove_InstanceFunctionAddress, intPtr, OnPostEditMove_ParamsSize);
	}

	protected unsafe virtual void OnPostEditMove_Implementation(bool bFinish)
	{
		CheckDestroyed();
		if (!OnPostEditMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:OnPostEditMove");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostEditMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostEditMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPostEditMove_bFinish_Offset), 0, OnPostEditMove_bFinish_PropertyAddress.Address, bFinish);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostEditMove_FunctionAddress, intPtr, OnPostEditMove_ParamsSize);
	}

	[UFunction(Flags = 147326976u)]
	[UMetaPath("/Script/b1.BGUActorBase:OnConstructionCS")]
	protected unsafe void OnConstructionCS(FTransform Transform)
	{
		CheckDestroyed();
		if (!OnConstructionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:OnConstructionCS");
			return;
		}
		if (OnConstructionCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnConstructionCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnConstructionCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnConstructionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnConstructionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnConstructionCS_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, OnConstructionCS_Transform_Offset), 0, OnConstructionCS_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnConstructionCS_InstanceFunctionAddress, intPtr, OnConstructionCS_ParamsSize);
	}

	protected unsafe virtual void OnConstructionCS_Implementation(FTransform Transform)
	{
		CheckDestroyed();
		if (!OnConstructionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:OnConstructionCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnConstructionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnConstructionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnConstructionCS_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, OnConstructionCS_Transform_Offset), 0, OnConstructionCS_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnConstructionCS_FunctionAddress, intPtr, OnConstructionCS_ParamsSize);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.BGUActorBase:GetTeamIDCS")]
	protected unsafe int GetTeamIDCS()
	{
		CheckDestroyed();
		if (!GetTeamIDCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:GetTeamIDCS");
			return 0;
		}
		if (GetTeamIDCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetTeamIDCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetTeamIDCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTeamIDCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTeamIDCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTeamIDCS_InstanceFunctionAddress, intPtr, GetTeamIDCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTeamIDCS_ReturnValue_Offset), 0, GetTeamIDCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetTeamIDCS_Implementation()
	{
		CheckDestroyed();
		if (!GetTeamIDCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:GetTeamIDCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTeamIDCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTeamIDCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTeamIDCS_FunctionAddress, intPtr, GetTeamIDCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTeamIDCS_ReturnValue_Offset), 0, GetTeamIDCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/b1.BGUActorBase:GetTeamID")]
	public unsafe int GetTeamID()
	{
		CheckDestroyed();
		if (!GetTeamID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:GetTeamID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTeamID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTeamID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTeamID_FunctionAddress, intPtr, GetTeamID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTeamID_ReturnValue_Offset), 0, GetTeamID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUActorBase:GetBUSEventCollection")]
	public unsafe UBUS_EventCollection GetBUSEventCollection()
	{
		CheckDestroyed();
		if (!GetBUSEventCollection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:GetBUSEventCollection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBUSEventCollection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBUSEventCollection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBUSEventCollection_FunctionAddress, intPtr, GetBUSEventCollection_ParamsSize);
		return UObjectMarshaler<UBUS_EventCollection>.FromNative(IntPtr.Add(intPtr, GetBUSEventCollection_ReturnValue_Offset), 0, GetBUSEventCollection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212680192u)]
	[UMetaPath("/Script/b1.BGUActorBase:GetActorGuidCS")]
	protected unsafe bool GetActorGuidCS(out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuidCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:GetActorGuidCS");
			OutActorGuid = FStringMarshaler.DefaultString;
			return false;
		}
		if (GetActorGuidCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetActorGuidCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorGuidCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorGuidCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorGuidCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorGuidCS_InstanceFunctionAddress, intPtr, GetActorGuidCS_ParamsSize);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidCS_OutActorGuid_Offset), 0, GetActorGuidCS_OutActorGuid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorGuidCS_OutActorGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidCS_ReturnValue_Offset), 0, GetActorGuidCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetActorGuidCS_Implementation(out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuidCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:GetActorGuidCS");
			OutActorGuid = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorGuidCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorGuidCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorGuidCS_FunctionAddress, intPtr, GetActorGuidCS_ParamsSize);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidCS_OutActorGuid_Offset), 0, GetActorGuidCS_OutActorGuid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorGuidCS_OutActorGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidCS_ReturnValue_Offset), 0, GetActorGuidCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/b1.BGUActorBase:GetActorGuid")]
	public unsafe bool GetActorGuid(out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:GetActorGuid");
			OutActorGuid = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorGuid_FunctionAddress, intPtr, GetActorGuid_ParamsSize);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_OutActorGuid_Offset), 0, GetActorGuid_OutActorGuid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorGuid_OutActorGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_ReturnValue_Offset), 0, GetActorGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUActorBase:FullyInit")]
	public unsafe void FullyInit()
	{
		CheckDestroyed();
		if (!FullyInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:FullyInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FullyInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FullyInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FullyInit_FunctionAddress, argsSize: FullyInit_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGUActorBase:ForceRefreshDetailView")]
	protected unsafe void ForceRefreshDetailView()
	{
		CheckDestroyed();
		if (!ForceRefreshDetailView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:ForceRefreshDetailView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceRefreshDetailView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceRefreshDetailView_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceRefreshDetailView_FunctionAddress, argsSize: ForceRefreshDetailView_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUActorBase:BeginPlayCS")]
	protected unsafe void BeginPlayCS()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:BeginPlayCS");
			return;
		}
		if (BeginPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_InstanceFunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	protected unsafe virtual void BeginPlayCS_Implementation()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:BeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_FunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGUActorBase:AttachBaseActorComp")]
	protected unsafe void AttachBaseActorComp(UBaseActorComp Comp)
	{
		CheckDestroyed();
		if (!AttachBaseActorComp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:AttachBaseActorComp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AttachBaseActorComp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AttachBaseActorComp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBaseActorComp>.ToNative(IntPtr.Add(intPtr, AttachBaseActorComp_Comp_Offset), 0, AttachBaseActorComp_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeFunctionOptimized(base.Address, AttachBaseActorComp_FunctionAddress, intPtr, AttachBaseActorComp_ParamsSize);
	}

	[UFunction(Flags = 147326976u)]
	[UMetaPath("/Script/b1.BGUActorBase:ApplyWorldOffsetCS")]
	protected unsafe void ApplyWorldOffsetCS(FVector InOffset, bool bWorldShift)
	{
		CheckDestroyed();
		if (!ApplyWorldOffsetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:ApplyWorldOffsetCS");
			return;
		}
		if (ApplyWorldOffsetCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ApplyWorldOffsetCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ApplyWorldOffsetCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyWorldOffsetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyWorldOffsetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyWorldOffsetCS_InOffset_Offset), 0, ApplyWorldOffsetCS_InOffset_PropertyAddress.Address, InOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyWorldOffsetCS_bWorldShift_Offset), 0, ApplyWorldOffsetCS_bWorldShift_PropertyAddress.Address, bWorldShift);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyWorldOffsetCS_InstanceFunctionAddress, intPtr, ApplyWorldOffsetCS_ParamsSize);
	}

	protected unsafe virtual void ApplyWorldOffsetCS_Implementation(FVector InOffset, bool bWorldShift)
	{
		CheckDestroyed();
		if (!ApplyWorldOffsetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUActorBase:ApplyWorldOffsetCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyWorldOffsetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyWorldOffsetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyWorldOffsetCS_InOffset_Offset), 0, ApplyWorldOffsetCS_InOffset_PropertyAddress.Address, InOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyWorldOffsetCS_bWorldShift_Offset), 0, ApplyWorldOffsetCS_bWorldShift_PropertyAddress.Address, bWorldShift);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyWorldOffsetCS_FunctionAddress, intPtr, ApplyWorldOffsetCS_ParamsSize);
	}

	static ABGUActorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUActorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUActorBase");
		NativeReflectionCached.GetPropertyRef(ref BeginPlayFromLevelStreaming_PropertyAddress, intPtr, "bBeginPlayFromLevelStreaming");
		BeginPlayFromLevelStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBeginPlayFromLevelStreaming");
		BeginPlayFromLevelStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBeginPlayFromLevelStreaming", Classes.FBoolProperty);
		ActorCompContainer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorCompContainer");
		ActorCompContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorCompContainer", Classes.FObjectProperty);
		EventCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EventCollection");
		EventCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EventCollection", Classes.FObjectProperty);
		SetTeamID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTeamID");
		SetTeamID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTeamID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTeamID_ID_PropertyAddress, SetTeamID_FunctionAddress, "ID");
		SetTeamID_ID_Offset = NativeReflectionCached.GetPropertyOffset(SetTeamID_FunctionAddress, "ID");
		SetTeamID_ID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTeamID_FunctionAddress, "ID", Classes.FIntProperty);
		SetTeamID_IsValid = SetTeamID_FunctionAddress != IntPtr.Zero && SetTeamID_ID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:SetTeamID", SetTeamID_IsValid);
		SetRootComponentCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRootComponentCS");
		SetRootComponentCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRootComponentCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRootComponentCS_NewRootComponent_PropertyAddress, SetRootComponentCS_FunctionAddress, "NewRootComponent");
		SetRootComponentCS_NewRootComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetRootComponentCS_FunctionAddress, "NewRootComponent");
		SetRootComponentCS_NewRootComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootComponentCS_FunctionAddress, "NewRootComponent", Classes.FObjectProperty);
		SetRootComponentCS_IsValid = SetRootComponentCS_FunctionAddress != IntPtr.Zero && SetRootComponentCS_NewRootComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:SetRootComponentCS", SetRootComponentCS_IsValid);
		SetCompCanEverAffectNavigation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCompCanEverAffectNavigation");
		SetCompCanEverAffectNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCompCanEverAffectNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCompCanEverAffectNavigation_ActorComponent_PropertyAddress, SetCompCanEverAffectNavigation_FunctionAddress, "ActorComponent");
		SetCompCanEverAffectNavigation_ActorComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetCompCanEverAffectNavigation_FunctionAddress, "ActorComponent");
		SetCompCanEverAffectNavigation_ActorComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCompCanEverAffectNavigation_FunctionAddress, "ActorComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCompCanEverAffectNavigation_bRelevant_PropertyAddress, SetCompCanEverAffectNavigation_FunctionAddress, "bRelevant");
		SetCompCanEverAffectNavigation_bRelevant_Offset = NativeReflectionCached.GetPropertyOffset(SetCompCanEverAffectNavigation_FunctionAddress, "bRelevant");
		SetCompCanEverAffectNavigation_bRelevant_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCompCanEverAffectNavigation_FunctionAddress, "bRelevant", Classes.FBoolProperty);
		SetCompCanEverAffectNavigation_IsValid = SetCompCanEverAffectNavigation_FunctionAddress != IntPtr.Zero && SetCompCanEverAffectNavigation_ActorComponent_IsValid && SetCompCanEverAffectNavigation_bRelevant_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:SetCompCanEverAffectNavigation", SetCompCanEverAffectNavigation_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:OnPropertyChanged", OnPropertyChanged_IsValid);
		OnPostEditMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostEditMove");
		OnPostEditMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostEditMove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPostEditMove_bFinish_PropertyAddress, OnPostEditMove_FunctionAddress, "bFinish");
		OnPostEditMove_bFinish_Offset = NativeReflectionCached.GetPropertyOffset(OnPostEditMove_FunctionAddress, "bFinish");
		OnPostEditMove_bFinish_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPostEditMove_FunctionAddress, "bFinish", Classes.FBoolProperty);
		OnPostEditMove_IsValid = OnPostEditMove_FunctionAddress != IntPtr.Zero && OnPostEditMove_bFinish_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:OnPostEditMove", OnPostEditMove_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflectionCached.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:OnConstructionCS", OnConstructionCS_IsValid);
		GetTeamIDCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTeamIDCS");
		GetTeamIDCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTeamIDCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTeamIDCS_ReturnValue_PropertyAddress, GetTeamIDCS_FunctionAddress, "ReturnValue");
		GetTeamIDCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTeamIDCS_FunctionAddress, "ReturnValue");
		GetTeamIDCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTeamIDCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTeamIDCS_IsValid = GetTeamIDCS_FunctionAddress != IntPtr.Zero && GetTeamIDCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:GetTeamIDCS", GetTeamIDCS_IsValid);
		GetTeamID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTeamID");
		GetTeamID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTeamID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTeamID_ReturnValue_PropertyAddress, GetTeamID_FunctionAddress, "ReturnValue");
		GetTeamID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTeamID_FunctionAddress, "ReturnValue");
		GetTeamID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTeamID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTeamID_IsValid = GetTeamID_FunctionAddress != IntPtr.Zero && GetTeamID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:GetTeamID", GetTeamID_IsValid);
		GetBUSEventCollection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBUSEventCollection");
		GetBUSEventCollection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBUSEventCollection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBUSEventCollection_ReturnValue_PropertyAddress, GetBUSEventCollection_FunctionAddress, "ReturnValue");
		GetBUSEventCollection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBUSEventCollection_FunctionAddress, "ReturnValue");
		GetBUSEventCollection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBUSEventCollection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBUSEventCollection_IsValid = GetBUSEventCollection_FunctionAddress != IntPtr.Zero && GetBUSEventCollection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:GetBUSEventCollection", GetBUSEventCollection_IsValid);
		GetActorGuidCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuidCS");
		GetActorGuidCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidCS_OutActorGuid_PropertyAddress, GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidCS_ReturnValue_PropertyAddress, GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuidCS_IsValid = GetActorGuidCS_FunctionAddress != IntPtr.Zero && GetActorGuidCS_OutActorGuid_IsValid && GetActorGuidCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:GetActorGuidCS", GetActorGuidCS_IsValid);
		GetActorGuid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuid");
		GetActorGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_OutActorGuid_PropertyAddress, GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_ReturnValue_PropertyAddress, GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuid_IsValid = GetActorGuid_FunctionAddress != IntPtr.Zero && GetActorGuid_OutActorGuid_IsValid && GetActorGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:GetActorGuid", GetActorGuid_IsValid);
		FullyInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FullyInit");
		FullyInit_ParamsSize = NativeReflection.GetFunctionParamsSize(FullyInit_FunctionAddress);
		FullyInit_IsValid = FullyInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:FullyInit", FullyInit_IsValid);
		ForceRefreshDetailView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceRefreshDetailView");
		ForceRefreshDetailView_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceRefreshDetailView_FunctionAddress);
		ForceRefreshDetailView_IsValid = ForceRefreshDetailView_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:ForceRefreshDetailView", ForceRefreshDetailView_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:BeginPlayCS", BeginPlayCS_IsValid);
		AttachBaseActorComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AttachBaseActorComp");
		AttachBaseActorComp_ParamsSize = NativeReflection.GetFunctionParamsSize(AttachBaseActorComp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AttachBaseActorComp_Comp_PropertyAddress, AttachBaseActorComp_FunctionAddress, "Comp");
		AttachBaseActorComp_Comp_Offset = NativeReflectionCached.GetPropertyOffset(AttachBaseActorComp_FunctionAddress, "Comp");
		AttachBaseActorComp_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachBaseActorComp_FunctionAddress, "Comp", Classes.FObjectProperty);
		AttachBaseActorComp_IsValid = AttachBaseActorComp_FunctionAddress != IntPtr.Zero && AttachBaseActorComp_Comp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:AttachBaseActorComp", AttachBaseActorComp_IsValid);
		ApplyWorldOffsetCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyWorldOffsetCS");
		ApplyWorldOffsetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyWorldOffsetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyWorldOffsetCS_InOffset_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_Offset = NativeReflectionCached.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "InOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyWorldOffsetCS_bWorldShift_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_Offset = NativeReflectionCached.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift", Classes.FBoolProperty);
		ApplyWorldOffsetCS_IsValid = ApplyWorldOffsetCS_FunctionAddress != IntPtr.Zero && ApplyWorldOffsetCS_InOffset_IsValid && ApplyWorldOffsetCS_bWorldShift_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUActorBase:ApplyWorldOffsetCS", ApplyWorldOffsetCS_IsValid);
	}
}
