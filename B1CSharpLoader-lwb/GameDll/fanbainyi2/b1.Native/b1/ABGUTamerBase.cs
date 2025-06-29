using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUTamerBase", "b1", UnrealModuleType.Game)]
public class ABGUTamerBase : AActor
{
	private static bool BeginPlayFromLevelStreaming_IsValid;

	private static FFieldAddress BeginPlayFromLevelStreaming_PropertyAddress;

	private static int BeginPlayFromLevelStreaming_Offset;

	private static bool SpawnedPlayerState_IsValid;

	private static int SpawnedPlayerState_Offset;

	private static bool SpawnedTamerGuid_IsValid;

	private static int SpawnedTamerGuid_Offset;

	private static bool TamerType_IsValid;

	private static FFieldAddress TamerType_PropertyAddress;

	private static int TamerType_Offset;

	private static bool EnableShowLODMesh_IsValid;

	private static FFieldAddress EnableShowLODMesh_PropertyAddress;

	private static int EnableShowLODMesh_Offset;

	private static bool LODMaxDistance_IsValid;

	private static int LODMaxDistance_Offset;

	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	private static bool CapsuleComponent_IsValid;

	private static int CapsuleComponent_Offset;

	private static bool LowLODMesh_IsValid;

	private static int LowLODMesh_Offset;

	private static bool SetLODMeshVisible_IsValid;

	private static IntPtr SetLODMeshVisible_FunctionAddress;

	private static int SetLODMeshVisible_ParamsSize;

	private static bool SetLODMeshVisible_InVisible_IsValid;

	private static FFieldAddress SetLODMeshVisible_InVisible_PropertyAddress;

	private static int SetLODMeshVisible_InVisible_Offset;

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

	private static bool OnPostEditMove_bFisnish_IsValid;

	private static FFieldAddress OnPostEditMove_bFisnish_PropertyAddress;

	private static int OnPostEditMove_bFisnish_Offset;

	private static bool OnConstructionCS_IsValid;

	private IntPtr OnConstructionCS_InstanceFunctionAddress;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	private static int OnConstructionCS_Transform_Offset;

	private static bool GetHighLODMeshConfig_IsValid;

	private IntPtr GetHighLODMeshConfig_InstanceFunctionAddress;

	private static IntPtr GetHighLODMeshConfig_FunctionAddress;

	private static int GetHighLODMeshConfig_ParamsSize;

	private static bool GetHighLODMeshConfig_OutMeshConfig_IsValid;

	private static FFieldAddress GetHighLODMeshConfig_OutMeshConfig_PropertyAddress;

	private static int GetHighLODMeshConfig_OutMeshConfig_Offset;

	private static bool GetHighLODMeshConfig_ReturnValue_IsValid;

	private static FFieldAddress GetHighLODMeshConfig_ReturnValue_PropertyAddress;

	private static int GetHighLODMeshConfig_ReturnValue_Offset;

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

	private static bool ForceRefreshDetailView_IsValid;

	private static IntPtr ForceRefreshDetailView_FunctionAddress;

	private static int ForceRefreshDetailView_ParamsSize;

	private static bool BeginPlayCS_IsValid;

	private IntPtr BeginPlayCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

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
	[UMetaPath("/Script/b1.BGUTamerBase:bBeginPlayFromLevelStreaming")]
	public bool BeginPlayFromLevelStreaming
	{
		get
		{
			CheckDestroyed();
			if (!BeginPlayFromLevelStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:bBeginPlayFromLevelStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BeginPlayFromLevelStreaming_Offset), 0, BeginPlayFromLevelStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BeginPlayFromLevelStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:bBeginPlayFromLevelStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BeginPlayFromLevelStreaming_Offset), 0, BeginPlayFromLevelStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274852uL)]
	[UMetaPath("/Script/b1.BGUTamerBase:SpawnedPlayerState")]
	public APlayerState SpawnedPlayerState
	{
		get
		{
			CheckDestroyed();
			if (!SpawnedPlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:SpawnedPlayerState");
				return null;
			}
			return UObjectMarshaler<APlayerState>.FromNative(IntPtr.Add(base.Address, SpawnedPlayerState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnedPlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:SpawnedPlayerState");
			}
			else
			{
				UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(base.Address, SpawnedPlayerState_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056292uL)]
	[UMetaPath("/Script/b1.BGUTamerBase:SpawnedTamerGuid")]
	public string SpawnedTamerGuid
	{
		get
		{
			CheckDestroyed();
			if (!SpawnedTamerGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:SpawnedTamerGuid");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SpawnedTamerGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnedTamerGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:SpawnedTamerGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SpawnedTamerGuid_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283060uL)]
	[UMetaPath("/Script/b1.BGUTamerBase:TamerType")]
	public ETamerType TamerType
	{
		get
		{
			CheckDestroyed();
			if (!TamerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:TamerType");
				return ETamerType.None;
			}
			return EnumMarshaler<ETamerType>.FromNative(IntPtr.Add(base.Address, TamerType_Offset), 0, TamerType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TamerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:TamerType");
			}
			else
			{
				EnumMarshaler<ETamerType>.ToNative(IntPtr.Add(base.Address, TamerType_Offset), 0, TamerType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUTamerBase:bEnableShowLODMesh")]
	public bool EnableShowLODMesh
	{
		get
		{
			CheckDestroyed();
			if (!EnableShowLODMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:bEnableShowLODMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableShowLODMesh_Offset), 0, EnableShowLODMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableShowLODMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:bEnableShowLODMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableShowLODMesh_Offset), 0, EnableShowLODMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUTamerBase:LODMaxDistance")]
	public int LODMaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!LODMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:LODMaxDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LODMaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LODMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:LODMaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LODMaxDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/b1.BGUTamerBase:Mesh")]
	public USkeletalMeshComponent Mesh
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:Mesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, Mesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:Mesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, Mesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/b1.BGUTamerBase:CapsuleComponent")]
	public UCapsuleComponent CapsuleComponent
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:CapsuleComponent");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, CapsuleComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:CapsuleComponent");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, CapsuleComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/b1.BGUTamerBase:LowLODMesh")]
	public UStaticMeshComponent LowLODMesh
	{
		get
		{
			CheckDestroyed();
			if (!LowLODMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:LowLODMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, LowLODMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LowLODMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUTamerBase:LowLODMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, LowLODMesh_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUTamerBase:SetLODMeshVisible")]
	public unsafe void SetLODMeshVisible(bool InVisible)
	{
		CheckDestroyed();
		if (!SetLODMeshVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:SetLODMeshVisible");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLODMeshVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLODMeshVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLODMeshVisible_InVisible_Offset), 0, SetLODMeshVisible_InVisible_PropertyAddress.Address, InVisible);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLODMeshVisible_FunctionAddress, intPtr, SetLODMeshVisible_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUTamerBase:PostInitializeComponentsCS")]
	protected unsafe void PostInitializeComponentsCS()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:PostInitializeComponentsCS");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:PostInitializeComponentsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_FunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUTamerBase:OnPropertyChanged")]
	protected unsafe void OnPropertyChanged(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:OnPropertyChanged");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:OnPropertyChanged");
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
	[UMetaPath("/Script/b1.BGUTamerBase:OnPostEditMove")]
	protected unsafe void OnPostEditMove(bool bFisnish)
	{
		CheckDestroyed();
		if (!OnPostEditMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:OnPostEditMove");
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
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPostEditMove_bFisnish_Offset), 0, OnPostEditMove_bFisnish_PropertyAddress.Address, bFisnish);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostEditMove_InstanceFunctionAddress, intPtr, OnPostEditMove_ParamsSize);
	}

	protected unsafe virtual void OnPostEditMove_Implementation(bool bFisnish)
	{
		CheckDestroyed();
		if (!OnPostEditMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:OnPostEditMove");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostEditMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostEditMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPostEditMove_bFisnish_Offset), 0, OnPostEditMove_bFisnish_PropertyAddress.Address, bFisnish);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostEditMove_FunctionAddress, intPtr, OnPostEditMove_ParamsSize);
	}

	[UFunction(Flags = 147326976u)]
	[UMetaPath("/Script/b1.BGUTamerBase:OnConstructionCS")]
	protected unsafe void OnConstructionCS(FTransform Transform)
	{
		CheckDestroyed();
		if (!OnConstructionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:OnConstructionCS");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:OnConstructionCS");
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

	[UFunction(Flags = 138939392u)]
	[UMetaPath("/Script/b1.BGUTamerBase:GetHighLODMeshConfig")]
	protected unsafe bool GetHighLODMeshConfig(out FTamerHighLODRootMeshConfig OutMeshConfig)
	{
		CheckDestroyed();
		if (!GetHighLODMeshConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:GetHighLODMeshConfig");
			OutMeshConfig = default(FTamerHighLODRootMeshConfig);
			return false;
		}
		if (GetHighLODMeshConfig_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetHighLODMeshConfig_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetHighLODMeshConfig");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHighLODMeshConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHighLODMeshConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetHighLODMeshConfig_OutMeshConfig_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHighLODMeshConfig_InstanceFunctionAddress, intPtr, GetHighLODMeshConfig_ParamsSize);
		OutMeshConfig = FTamerHighLODRootMeshConfig.FromNative(IntPtr.Add(intPtr, GetHighLODMeshConfig_OutMeshConfig_Offset), 0, GetHighLODMeshConfig_OutMeshConfig_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetHighLODMeshConfig_OutMeshConfig_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHighLODMeshConfig_ReturnValue_Offset), 0, GetHighLODMeshConfig_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetHighLODMeshConfig_Implementation(out FTamerHighLODRootMeshConfig OutMeshConfig)
	{
		CheckDestroyed();
		if (!GetHighLODMeshConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:GetHighLODMeshConfig");
			OutMeshConfig = default(FTamerHighLODRootMeshConfig);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHighLODMeshConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHighLODMeshConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetHighLODMeshConfig_OutMeshConfig_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHighLODMeshConfig_FunctionAddress, intPtr, GetHighLODMeshConfig_ParamsSize);
		OutMeshConfig = FTamerHighLODRootMeshConfig.FromNative(IntPtr.Add(intPtr, GetHighLODMeshConfig_OutMeshConfig_Offset), 0, GetHighLODMeshConfig_OutMeshConfig_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetHighLODMeshConfig_OutMeshConfig_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHighLODMeshConfig_ReturnValue_Offset), 0, GetHighLODMeshConfig_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212680192u)]
	[UMetaPath("/Script/b1.BGUTamerBase:GetActorGuidCS")]
	protected unsafe bool GetActorGuidCS(out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuidCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:GetActorGuidCS");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:GetActorGuidCS");
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
	[UMetaPath("/Script/b1.BGUTamerBase:GetActorGuid")]
	public unsafe bool GetActorGuid(out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:GetActorGuid");
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

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGUTamerBase:ForceRefreshDetailView")]
	protected unsafe void ForceRefreshDetailView()
	{
		CheckDestroyed();
		if (!ForceRefreshDetailView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:ForceRefreshDetailView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceRefreshDetailView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceRefreshDetailView_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceRefreshDetailView_FunctionAddress, argsSize: ForceRefreshDetailView_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUTamerBase:BeginPlayCS")]
	protected unsafe void BeginPlayCS()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:BeginPlayCS");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:BeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_FunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	[UFunction(Flags = 147326976u)]
	[UMetaPath("/Script/b1.BGUTamerBase:ApplyWorldOffsetCS")]
	protected unsafe void ApplyWorldOffsetCS(FVector InOffset, bool bWorldShift)
	{
		CheckDestroyed();
		if (!ApplyWorldOffsetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:ApplyWorldOffsetCS");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUTamerBase:ApplyWorldOffsetCS");
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

	static ABGUTamerBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUTamerBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUTamerBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUTamerBase");
		NativeReflectionCached.GetPropertyRef(ref BeginPlayFromLevelStreaming_PropertyAddress, intPtr, "bBeginPlayFromLevelStreaming");
		BeginPlayFromLevelStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBeginPlayFromLevelStreaming");
		BeginPlayFromLevelStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBeginPlayFromLevelStreaming", Classes.FBoolProperty);
		SpawnedPlayerState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnedPlayerState");
		SpawnedPlayerState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnedPlayerState", Classes.FObjectProperty);
		SpawnedTamerGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnedTamerGuid");
		SpawnedTamerGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnedTamerGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TamerType_PropertyAddress, intPtr, "TamerType");
		TamerType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TamerType");
		TamerType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TamerType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableShowLODMesh_PropertyAddress, intPtr, "bEnableShowLODMesh");
		EnableShowLODMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableShowLODMesh");
		EnableShowLODMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableShowLODMesh", Classes.FBoolProperty);
		LODMaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODMaxDistance");
		LODMaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODMaxDistance", Classes.FIntProperty);
		Mesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		CapsuleComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapsuleComponent");
		CapsuleComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapsuleComponent", Classes.FObjectProperty);
		LowLODMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowLODMesh");
		LowLODMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowLODMesh", Classes.FObjectProperty);
		SetLODMeshVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLODMeshVisible");
		SetLODMeshVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLODMeshVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLODMeshVisible_InVisible_PropertyAddress, SetLODMeshVisible_FunctionAddress, "InVisible");
		SetLODMeshVisible_InVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetLODMeshVisible_FunctionAddress, "InVisible");
		SetLODMeshVisible_InVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODMeshVisible_FunctionAddress, "InVisible", Classes.FBoolProperty);
		SetLODMeshVisible_IsValid = SetLODMeshVisible_FunctionAddress != IntPtr.Zero && SetLODMeshVisible_InVisible_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:SetLODMeshVisible", SetLODMeshVisible_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:OnPropertyChanged", OnPropertyChanged_IsValid);
		OnPostEditMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostEditMove");
		OnPostEditMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostEditMove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPostEditMove_bFisnish_PropertyAddress, OnPostEditMove_FunctionAddress, "bFisnish");
		OnPostEditMove_bFisnish_Offset = NativeReflectionCached.GetPropertyOffset(OnPostEditMove_FunctionAddress, "bFisnish");
		OnPostEditMove_bFisnish_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPostEditMove_FunctionAddress, "bFisnish", Classes.FBoolProperty);
		OnPostEditMove_IsValid = OnPostEditMove_FunctionAddress != IntPtr.Zero && OnPostEditMove_bFisnish_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:OnPostEditMove", OnPostEditMove_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflectionCached.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:OnConstructionCS", OnConstructionCS_IsValid);
		GetHighLODMeshConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHighLODMeshConfig");
		GetHighLODMeshConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHighLODMeshConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHighLODMeshConfig_OutMeshConfig_PropertyAddress, GetHighLODMeshConfig_FunctionAddress, "OutMeshConfig");
		GetHighLODMeshConfig_OutMeshConfig_Offset = NativeReflectionCached.GetPropertyOffset(GetHighLODMeshConfig_FunctionAddress, "OutMeshConfig");
		GetHighLODMeshConfig_OutMeshConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHighLODMeshConfig_FunctionAddress, "OutMeshConfig", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHighLODMeshConfig_ReturnValue_PropertyAddress, GetHighLODMeshConfig_FunctionAddress, "ReturnValue");
		GetHighLODMeshConfig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHighLODMeshConfig_FunctionAddress, "ReturnValue");
		GetHighLODMeshConfig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHighLODMeshConfig_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHighLODMeshConfig_IsValid = GetHighLODMeshConfig_FunctionAddress != IntPtr.Zero && GetHighLODMeshConfig_OutMeshConfig_IsValid && GetHighLODMeshConfig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:GetHighLODMeshConfig", GetHighLODMeshConfig_IsValid);
		GetActorGuidCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuidCS");
		GetActorGuidCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidCS_OutActorGuid_PropertyAddress, GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidCS_ReturnValue_PropertyAddress, GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuidCS_IsValid = GetActorGuidCS_FunctionAddress != IntPtr.Zero && GetActorGuidCS_OutActorGuid_IsValid && GetActorGuidCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:GetActorGuidCS", GetActorGuidCS_IsValid);
		GetActorGuid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuid");
		GetActorGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_OutActorGuid_PropertyAddress, GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_ReturnValue_PropertyAddress, GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuid_IsValid = GetActorGuid_FunctionAddress != IntPtr.Zero && GetActorGuid_OutActorGuid_IsValid && GetActorGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:GetActorGuid", GetActorGuid_IsValid);
		ForceRefreshDetailView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceRefreshDetailView");
		ForceRefreshDetailView_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceRefreshDetailView_FunctionAddress);
		ForceRefreshDetailView_IsValid = ForceRefreshDetailView_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:ForceRefreshDetailView", ForceRefreshDetailView_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:BeginPlayCS", BeginPlayCS_IsValid);
		ApplyWorldOffsetCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyWorldOffsetCS");
		ApplyWorldOffsetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyWorldOffsetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyWorldOffsetCS_InOffset_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_Offset = NativeReflectionCached.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "InOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyWorldOffsetCS_bWorldShift_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_Offset = NativeReflectionCached.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift", Classes.FBoolProperty);
		ApplyWorldOffsetCS_IsValid = ApplyWorldOffsetCS_FunctionAddress != IntPtr.Zero && ApplyWorldOffsetCS_InOffset_IsValid && ApplyWorldOffsetCS_bWorldShift_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUTamerBase:ApplyWorldOffsetCS", ApplyWorldOffsetCS_IsValid);
	}
}
