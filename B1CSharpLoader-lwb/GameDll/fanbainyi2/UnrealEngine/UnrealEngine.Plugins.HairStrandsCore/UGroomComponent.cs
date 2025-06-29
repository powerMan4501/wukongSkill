using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomComponent", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomComponent : UMeshComponent, ILODSyncInterface, IInterface
{
	private static bool GroomAsset_IsValid;

	private static int GroomAsset_Offset;

	private static bool GroomCache_IsValid;

	private static int GroomCache_Offset;

	private static bool BindingAsset_IsValid;

	private static int BindingAsset_Offset;

	private static bool PhysicsAsset_IsValid;

	private static int PhysicsAsset_Offset;

	private static bool SimulationSettings_IsValid;

	private static int SimulationSettings_Offset;

	private static bool AttachmentName_IsValid;

	private static int AttachmentName_Offset;

	private static bool GroomGroupsDesc_IsValid;

	private static FFieldAddress GroomGroupsDesc_PropertyAddress;

	private static int GroomGroupsDesc_Offset;

	private TArrayReadWriteMarshaler<FHairGroupDesc> GroomGroupsDesc_MarshalerCached;

	private static bool UseCards_IsValid;

	private static FFieldAddress UseCards_PropertyAddress;

	private static int UseCards_Offset;

	private static bool SetPhysicsAsset_IsValid;

	private static IntPtr SetPhysicsAsset_FunctionAddress;

	private static int SetPhysicsAsset_ParamsSize;

	private static bool SetPhysicsAsset_InPhysicsAsset_IsValid;

	private static FFieldAddress SetPhysicsAsset_InPhysicsAsset_PropertyAddress;

	private static int SetPhysicsAsset_InPhysicsAsset_Offset;

	private static bool SetHairLengthScaleEnable_IsValid;

	private static IntPtr SetHairLengthScaleEnable_FunctionAddress;

	private static int SetHairLengthScaleEnable_ParamsSize;

	private static bool SetHairLengthScaleEnable_bEnable_IsValid;

	private static FFieldAddress SetHairLengthScaleEnable_bEnable_PropertyAddress;

	private static int SetHairLengthScaleEnable_bEnable_Offset;

	private static bool SetHairLengthScale_IsValid;

	private static IntPtr SetHairLengthScale_FunctionAddress;

	private static int SetHairLengthScale_ParamsSize;

	private static bool SetHairLengthScale_Scale_IsValid;

	private static FFieldAddress SetHairLengthScale_Scale_PropertyAddress;

	private static int SetHairLengthScale_Scale_Offset;

	private static bool SetGroomAsset_IsValid;

	private static IntPtr SetGroomAsset_FunctionAddress;

	private static int SetGroomAsset_ParamsSize;

	private static bool SetGroomAsset_Asset_IsValid;

	private static FFieldAddress SetGroomAsset_Asset_PropertyAddress;

	private static int SetGroomAsset_Asset_Offset;

	private static bool SetEnableSimulation_IsValid;

	private static IntPtr SetEnableSimulation_FunctionAddress;

	private static int SetEnableSimulation_ParamsSize;

	private static bool SetEnableSimulation_bInEnableSimulation_IsValid;

	private static FFieldAddress SetEnableSimulation_bInEnableSimulation_PropertyAddress;

	private static int SetEnableSimulation_bInEnableSimulation_Offset;

	private static bool SetBindingAsset_IsValid;

	private static IntPtr SetBindingAsset_FunctionAddress;

	private static int SetBindingAsset_ParamsSize;

	private static bool SetBindingAsset_InBinding_IsValid;

	private static FFieldAddress SetBindingAsset_InBinding_PropertyAddress;

	private static int SetBindingAsset_InBinding_Offset;

	private static bool ResetSimulation_IsValid;

	private static IntPtr ResetSimulation_FunctionAddress;

	private static int ResetSimulation_ParamsSize;

	private static bool ResetCollisionComponents_IsValid;

	private static IntPtr ResetCollisionComponents_FunctionAddress;

	private static int ResetCollisionComponents_ParamsSize;

	private static bool GetIsHairLengthScaleEnabled_IsValid;

	private static IntPtr GetIsHairLengthScaleEnabled_FunctionAddress;

	private static int GetIsHairLengthScaleEnabled_ParamsSize;

	private static bool GetIsHairLengthScaleEnabled_ReturnValue_IsValid;

	private static FFieldAddress GetIsHairLengthScaleEnabled_ReturnValue_PropertyAddress;

	private static int GetIsHairLengthScaleEnabled_ReturnValue_Offset;

	private static bool AddCollisionComponent_IsValid;

	private static IntPtr AddCollisionComponent_FunctionAddress;

	private static int AddCollisionComponent_ParamsSize;

	private static bool AddCollisionComponent_SkeletalMeshComponent_IsValid;

	private static FFieldAddress AddCollisionComponent_SkeletalMeshComponent_PropertyAddress;

	private static int AddCollisionComponent_SkeletalMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)7881377731052037uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:GroomAsset")]
	public UGroomAsset GroomAsset
	{
		get
		{
			CheckDestroyed();
			if (!GroomAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:GroomAsset");
				return null;
			}
			return UObjectMarshaler<UGroomAsset>.FromNative(IntPtr.Add(base.Address, GroomAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroomAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:GroomAsset");
			}
			else
			{
				UObjectMarshaler<UGroomAsset>.ToNative(IntPtr.Add(base.Address, GroomAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881377731052037uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:GroomCache")]
	public UGroomCache GroomCache
	{
		get
		{
			CheckDestroyed();
			if (!GroomCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:GroomCache");
				return null;
			}
			return UObjectMarshaler<UGroomCache>.FromNative(IntPtr.Add(base.Address, GroomCache_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroomCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:GroomCache");
			}
			else
			{
				UObjectMarshaler<UGroomCache>.ToNative(IntPtr.Add(base.Address, GroomCache_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881377731052053uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:BindingAsset")]
	public UGroomBindingAsset BindingAsset
	{
		get
		{
			CheckDestroyed();
			if (!BindingAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:BindingAsset");
				return null;
			}
			return UObjectMarshaler<UGroomBindingAsset>.FromNative(IntPtr.Add(base.Address, BindingAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindingAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:BindingAsset");
			}
			else
			{
				UObjectMarshaler<UGroomBindingAsset>.ToNative(IntPtr.Add(base.Address, BindingAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:PhysicsAsset")]
	public UPhysicsAsset PhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:PhysicsAsset");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, PhysicsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:PhysicsAsset");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, PhysicsAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503608217305093uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:SimulationSettings")]
	public FHairSimulationSettings SimulationSettings
	{
		get
		{
			CheckDestroyed();
			if (!SimulationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:SimulationSettings");
				return default(FHairSimulationSettings);
			}
			return FHairSimulationSettings.FromNative(IntPtr.Add(base.Address, SimulationSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimulationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:SimulationSettings");
			}
			else
			{
				FHairSimulationSettings.ToNative(IntPtr.Add(base.Address, SimulationSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759806077501957uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:AttachmentName")]
	public string AttachmentName
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:AttachmentName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AttachmentName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:AttachmentName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AttachmentName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:GroomGroupsDesc")]
	public TArrayReadWrite<FHairGroupDesc> GroomGroupsDesc
	{
		get
		{
			CheckDestroyed();
			if (!GroomGroupsDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:GroomGroupsDesc");
				return null;
			}
			if (GroomGroupsDesc_MarshalerCached == null)
			{
				GroomGroupsDesc_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupDesc>(1, GroomGroupsDesc_PropertyAddress, CachedMarshalingDelegates<FHairGroupDesc, FHairGroupDesc>.FromNative, CachedMarshalingDelegates<FHairGroupDesc, FHairGroupDesc>.ToNative);
			}
			return GroomGroupsDesc_MarshalerCached.FromNative(IntPtr.Add(base.Address, GroomGroupsDesc_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:bUseCards")]
	public bool UseCards
	{
		get
		{
			CheckDestroyed();
			if (!UseCards_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:bUseCards");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCards_Offset), 0, UseCards_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCards_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomComponent:bUseCards");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCards_Offset), 0, UseCards_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:SetPhysicsAsset")]
	public unsafe void SetPhysicsAsset(UPhysicsAsset InPhysicsAsset)
	{
		CheckDestroyed();
		if (!SetPhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:SetPhysicsAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, SetPhysicsAsset_InPhysicsAsset_Offset), 0, SetPhysicsAsset_InPhysicsAsset_PropertyAddress.Address, InPhysicsAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPhysicsAsset_FunctionAddress, intPtr, SetPhysicsAsset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:SetHairLengthScaleEnable")]
	public unsafe void SetHairLengthScaleEnable(bool bEnable)
	{
		CheckDestroyed();
		if (!SetHairLengthScaleEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:SetHairLengthScaleEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHairLengthScaleEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHairLengthScaleEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetHairLengthScaleEnable_bEnable_Offset), 0, SetHairLengthScaleEnable_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHairLengthScaleEnable_FunctionAddress, intPtr, SetHairLengthScaleEnable_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:SetHairLengthScale")]
	public unsafe void SetHairLengthScale(float Scale)
	{
		CheckDestroyed();
		if (!SetHairLengthScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:SetHairLengthScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHairLengthScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHairLengthScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetHairLengthScale_Scale_Offset), 0, SetHairLengthScale_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHairLengthScale_FunctionAddress, intPtr, SetHairLengthScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:SetGroomAsset")]
	public unsafe void SetGroomAsset(UGroomAsset Asset)
	{
		CheckDestroyed();
		if (!SetGroomAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:SetGroomAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGroomAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGroomAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGroomAsset>.ToNative(IntPtr.Add(intPtr, SetGroomAsset_Asset_Offset), 0, SetGroomAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGroomAsset_FunctionAddress, intPtr, SetGroomAsset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:SetEnableSimulation")]
	public unsafe void SetEnableSimulation(bool bInEnableSimulation)
	{
		CheckDestroyed();
		if (!SetEnableSimulation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:SetEnableSimulation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableSimulation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableSimulation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableSimulation_bInEnableSimulation_Offset), 0, SetEnableSimulation_bInEnableSimulation_PropertyAddress.Address, bInEnableSimulation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableSimulation_FunctionAddress, intPtr, SetEnableSimulation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:SetBindingAsset")]
	public unsafe void SetBindingAsset(UGroomBindingAsset InBinding)
	{
		CheckDestroyed();
		if (!SetBindingAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:SetBindingAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBindingAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBindingAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGroomBindingAsset>.ToNative(IntPtr.Add(intPtr, SetBindingAsset_InBinding_Offset), 0, SetBindingAsset_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBindingAsset_FunctionAddress, intPtr, SetBindingAsset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:ResetSimulation")]
	public unsafe void ResetSimulation()
	{
		CheckDestroyed();
		if (!ResetSimulation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:ResetSimulation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetSimulation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetSimulation_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetSimulation_FunctionAddress, argsSize: ResetSimulation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:ResetCollisionComponents")]
	public unsafe void ResetCollisionComponents()
	{
		CheckDestroyed();
		if (!ResetCollisionComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:ResetCollisionComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetCollisionComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetCollisionComponents_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetCollisionComponents_FunctionAddress, argsSize: ResetCollisionComponents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:GetIsHairLengthScaleEnabled")]
	public unsafe bool GetIsHairLengthScaleEnabled()
	{
		CheckDestroyed();
		if (!GetIsHairLengthScaleEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:GetIsHairLengthScaleEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsHairLengthScaleEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsHairLengthScaleEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIsHairLengthScaleEnabled_FunctionAddress, intPtr, GetIsHairLengthScaleEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsHairLengthScaleEnabled_ReturnValue_Offset), 0, GetIsHairLengthScaleEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/HairStrandsCore.GroomComponent:AddCollisionComponent")]
	public unsafe void AddCollisionComponent(USkeletalMeshComponent SkeletalMeshComponent)
	{
		CheckDestroyed();
		if (!AddCollisionComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/HairStrandsCore.GroomComponent:AddCollisionComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCollisionComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCollisionComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, AddCollisionComponent_SkeletalMeshComponent_Offset), 0, AddCollisionComponent_SkeletalMeshComponent_PropertyAddress.Address, SkeletalMeshComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddCollisionComponent_FunctionAddress, intPtr, AddCollisionComponent_ParamsSize);
	}

	static UGroomComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/HairStrandsCore.GroomComponent");
		GroomAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroomAsset");
		GroomAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroomAsset", Classes.FObjectProperty);
		GroomCache_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroomCache");
		GroomCache_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroomCache", Classes.FObjectProperty);
		BindingAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BindingAsset");
		BindingAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BindingAsset", Classes.FObjectProperty);
		PhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysicsAsset");
		PhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysicsAsset", Classes.FObjectProperty);
		SimulationSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimulationSettings");
		SimulationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimulationSettings", Classes.FStructProperty);
		AttachmentName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttachmentName");
		AttachmentName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttachmentName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GroomGroupsDesc_PropertyAddress, intPtr, "GroomGroupsDesc");
		GroomGroupsDesc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroomGroupsDesc");
		GroomGroupsDesc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroomGroupsDesc", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCards_PropertyAddress, intPtr, "bUseCards");
		UseCards_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCards");
		UseCards_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCards", Classes.FBoolProperty);
		SetPhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPhysicsAsset");
		SetPhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAsset_InPhysicsAsset_PropertyAddress, SetPhysicsAsset_FunctionAddress, "InPhysicsAsset");
		SetPhysicsAsset_InPhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAsset_FunctionAddress, "InPhysicsAsset");
		SetPhysicsAsset_InPhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAsset_FunctionAddress, "InPhysicsAsset", Classes.FObjectProperty);
		SetPhysicsAsset_IsValid = SetPhysicsAsset_FunctionAddress != IntPtr.Zero && SetPhysicsAsset_InPhysicsAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:SetPhysicsAsset", SetPhysicsAsset_IsValid);
		SetHairLengthScaleEnable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHairLengthScaleEnable");
		SetHairLengthScaleEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHairLengthScaleEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHairLengthScaleEnable_bEnable_PropertyAddress, SetHairLengthScaleEnable_FunctionAddress, "bEnable");
		SetHairLengthScaleEnable_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetHairLengthScaleEnable_FunctionAddress, "bEnable");
		SetHairLengthScaleEnable_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHairLengthScaleEnable_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetHairLengthScaleEnable_IsValid = SetHairLengthScaleEnable_FunctionAddress != IntPtr.Zero && SetHairLengthScaleEnable_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:SetHairLengthScaleEnable", SetHairLengthScaleEnable_IsValid);
		SetHairLengthScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHairLengthScale");
		SetHairLengthScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHairLengthScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHairLengthScale_Scale_PropertyAddress, SetHairLengthScale_FunctionAddress, "Scale");
		SetHairLengthScale_Scale_Offset = NativeReflectionCached.GetPropertyOffset(SetHairLengthScale_FunctionAddress, "Scale");
		SetHairLengthScale_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHairLengthScale_FunctionAddress, "Scale", Classes.FFloatProperty);
		SetHairLengthScale_IsValid = SetHairLengthScale_FunctionAddress != IntPtr.Zero && SetHairLengthScale_Scale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:SetHairLengthScale", SetHairLengthScale_IsValid);
		SetGroomAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGroomAsset");
		SetGroomAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGroomAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGroomAsset_Asset_PropertyAddress, SetGroomAsset_FunctionAddress, "Asset");
		SetGroomAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(SetGroomAsset_FunctionAddress, "Asset");
		SetGroomAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGroomAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		SetGroomAsset_IsValid = SetGroomAsset_FunctionAddress != IntPtr.Zero && SetGroomAsset_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:SetGroomAsset", SetGroomAsset_IsValid);
		SetEnableSimulation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableSimulation");
		SetEnableSimulation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableSimulation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableSimulation_bInEnableSimulation_PropertyAddress, SetEnableSimulation_FunctionAddress, "bInEnableSimulation");
		SetEnableSimulation_bInEnableSimulation_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableSimulation_FunctionAddress, "bInEnableSimulation");
		SetEnableSimulation_bInEnableSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableSimulation_FunctionAddress, "bInEnableSimulation", Classes.FBoolProperty);
		SetEnableSimulation_IsValid = SetEnableSimulation_FunctionAddress != IntPtr.Zero && SetEnableSimulation_bInEnableSimulation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:SetEnableSimulation", SetEnableSimulation_IsValid);
		SetBindingAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBindingAsset");
		SetBindingAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBindingAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBindingAsset_InBinding_PropertyAddress, SetBindingAsset_FunctionAddress, "InBinding");
		SetBindingAsset_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(SetBindingAsset_FunctionAddress, "InBinding");
		SetBindingAsset_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBindingAsset_FunctionAddress, "InBinding", Classes.FObjectProperty);
		SetBindingAsset_IsValid = SetBindingAsset_FunctionAddress != IntPtr.Zero && SetBindingAsset_InBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:SetBindingAsset", SetBindingAsset_IsValid);
		ResetSimulation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetSimulation");
		ResetSimulation_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetSimulation_FunctionAddress);
		ResetSimulation_IsValid = ResetSimulation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:ResetSimulation", ResetSimulation_IsValid);
		ResetCollisionComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetCollisionComponents");
		ResetCollisionComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetCollisionComponents_FunctionAddress);
		ResetCollisionComponents_IsValid = ResetCollisionComponents_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:ResetCollisionComponents", ResetCollisionComponents_IsValid);
		GetIsHairLengthScaleEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIsHairLengthScaleEnabled");
		GetIsHairLengthScaleEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsHairLengthScaleEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsHairLengthScaleEnabled_ReturnValue_PropertyAddress, GetIsHairLengthScaleEnabled_FunctionAddress, "ReturnValue");
		GetIsHairLengthScaleEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsHairLengthScaleEnabled_FunctionAddress, "ReturnValue");
		GetIsHairLengthScaleEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsHairLengthScaleEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsHairLengthScaleEnabled_IsValid = GetIsHairLengthScaleEnabled_FunctionAddress != IntPtr.Zero && GetIsHairLengthScaleEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:GetIsHairLengthScaleEnabled", GetIsHairLengthScaleEnabled_IsValid);
		AddCollisionComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddCollisionComponent");
		AddCollisionComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCollisionComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCollisionComponent_SkeletalMeshComponent_PropertyAddress, AddCollisionComponent_FunctionAddress, "SkeletalMeshComponent");
		AddCollisionComponent_SkeletalMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(AddCollisionComponent_FunctionAddress, "SkeletalMeshComponent");
		AddCollisionComponent_SkeletalMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCollisionComponent_FunctionAddress, "SkeletalMeshComponent", Classes.FObjectProperty);
		AddCollisionComponent_IsValid = AddCollisionComponent_FunctionAddress != IntPtr.Zero && AddCollisionComponent_SkeletalMeshComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/HairStrandsCore.GroomComponent:AddCollisionComponent", AddCollisionComponent_IsValid);
	}
}
