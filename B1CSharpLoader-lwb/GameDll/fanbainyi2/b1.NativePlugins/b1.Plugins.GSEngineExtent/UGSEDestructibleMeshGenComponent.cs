using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ApexDestruction;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public class UGSEDestructibleMeshGenComponent : UActorComponent
{
	private static bool TargetBlueprint_IsValid;

	private static int TargetBlueprint_Offset;

	private static bool FolderPath_IsValid;

	private static int FolderPath_Offset;

	private static bool DestructibleComponentArray_IsValid;

	private static FFieldAddress DestructibleComponentArray_PropertyAddress;

	private static int DestructibleComponentArray_Offset;

	private TArrayReadWriteMarshaler<UDestructibleComponent> DestructibleComponentArray_MarshalerCached;

	private static bool BoneNameArray_IsValid;

	private static FFieldAddress BoneNameArray_PropertyAddress;

	private static int BoneNameArray_Offset;

	private TArrayReadWriteMarshaler<FName> BoneNameArray_MarshalerCached;

	private static bool UseCustomCollisionToDefault_IsValid;

	private static FFieldAddress UseCustomCollisionToDefault_PropertyAddress;

	private static int UseCustomCollisionToDefault_Offset;

	private static bool RefreshPriviewObjectsOnAnimalMesh_IsValid;

	private static FFieldAddress RefreshPriviewObjectsOnAnimalMesh_PropertyAddress;

	private static int RefreshPriviewObjectsOnAnimalMesh_Offset;

	private static bool BodyInstance_IsValid;

	private static int BodyInstance_Offset;

	private static bool FloatCurve_IsValid;

	private static int FloatCurve_Offset;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool FloatCurveTick_IsValid;

	private static int FloatCurveTick_Offset;

	private FComponentCurveSignature FloatCurveTick_DelegateCached;

	private static bool SetCollisionResponseToChannelByName_IsValid;

	private static IntPtr SetCollisionResponseToChannelByName_FunctionAddress;

	private static int SetCollisionResponseToChannelByName_ParamsSize;

	private static bool SetCollisionResponseToChannelByName_Channel_IsValid;

	private static FFieldAddress SetCollisionResponseToChannelByName_Channel_PropertyAddress;

	private static int SetCollisionResponseToChannelByName_Channel_Offset;

	private static bool SetCollisionResponseToChannelByName_NewResponse_IsValid;

	private static FFieldAddress SetCollisionResponseToChannelByName_NewResponse_PropertyAddress;

	private static int SetCollisionResponseToChannelByName_NewResponse_Offset;

	private static bool SetCollisionResponseToChannelByName_Name_IsValid;

	private static FFieldAddress SetCollisionResponseToChannelByName_Name_PropertyAddress;

	private static int SetCollisionResponseToChannelByName_Name_Offset;

	private static bool SetCollisionResponseToChannelByName_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionResponseToChannelByName_ReturnValue_PropertyAddress;

	private static int SetCollisionResponseToChannelByName_ReturnValue_Offset;

	private static bool SetCollisionResponseToChannel_IsValid;

	private static IntPtr SetCollisionResponseToChannel_FunctionAddress;

	private static int SetCollisionResponseToChannel_ParamsSize;

	private static bool SetCollisionResponseToChannel_Channel_IsValid;

	private static FFieldAddress SetCollisionResponseToChannel_Channel_PropertyAddress;

	private static int SetCollisionResponseToChannel_Channel_Offset;

	private static bool SetCollisionResponseToChannel_NewResponse_IsValid;

	private static FFieldAddress SetCollisionResponseToChannel_NewResponse_PropertyAddress;

	private static int SetCollisionResponseToChannel_NewResponse_Offset;

	private static bool SetCollisionResponseToChannel_Comp_IsValid;

	private static FFieldAddress SetCollisionResponseToChannel_Comp_PropertyAddress;

	private static int SetCollisionResponseToChannel_Comp_Offset;

	private static bool SetCollisionResponseToChannel_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionResponseToChannel_ReturnValue_PropertyAddress;

	private static int SetCollisionResponseToChannel_ReturnValue_Offset;

	private static bool SetCollisionResponseToAllChannelsByName_IsValid;

	private static IntPtr SetCollisionResponseToAllChannelsByName_FunctionAddress;

	private static int SetCollisionResponseToAllChannelsByName_ParamsSize;

	private static bool SetCollisionResponseToAllChannelsByName_NewResponse_IsValid;

	private static FFieldAddress SetCollisionResponseToAllChannelsByName_NewResponse_PropertyAddress;

	private static int SetCollisionResponseToAllChannelsByName_NewResponse_Offset;

	private static bool SetCollisionResponseToAllChannelsByName_Name_IsValid;

	private static FFieldAddress SetCollisionResponseToAllChannelsByName_Name_PropertyAddress;

	private static int SetCollisionResponseToAllChannelsByName_Name_Offset;

	private static bool SetCollisionResponseToAllChannelsByName_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionResponseToAllChannelsByName_ReturnValue_PropertyAddress;

	private static int SetCollisionResponseToAllChannelsByName_ReturnValue_Offset;

	private static bool SetCollisionResponseToAllChannels_IsValid;

	private static IntPtr SetCollisionResponseToAllChannels_FunctionAddress;

	private static int SetCollisionResponseToAllChannels_ParamsSize;

	private static bool SetCollisionResponseToAllChannels_NewResponse_IsValid;

	private static FFieldAddress SetCollisionResponseToAllChannels_NewResponse_PropertyAddress;

	private static int SetCollisionResponseToAllChannels_NewResponse_Offset;

	private static bool SetCollisionResponseToAllChannels_Comp_IsValid;

	private static FFieldAddress SetCollisionResponseToAllChannels_Comp_PropertyAddress;

	private static int SetCollisionResponseToAllChannels_Comp_Offset;

	private static bool SetCollisionResponseToAllChannels_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionResponseToAllChannels_ReturnValue_PropertyAddress;

	private static int SetCollisionResponseToAllChannels_ReturnValue_Offset;

	private static bool SetCollisionObjectTypeByName_IsValid;

	private static IntPtr SetCollisionObjectTypeByName_FunctionAddress;

	private static int SetCollisionObjectTypeByName_ParamsSize;

	private static bool SetCollisionObjectTypeByName_Channel_IsValid;

	private static FFieldAddress SetCollisionObjectTypeByName_Channel_PropertyAddress;

	private static int SetCollisionObjectTypeByName_Channel_Offset;

	private static bool SetCollisionObjectTypeByName_Name_IsValid;

	private static FFieldAddress SetCollisionObjectTypeByName_Name_PropertyAddress;

	private static int SetCollisionObjectTypeByName_Name_Offset;

	private static bool SetCollisionObjectTypeByName_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionObjectTypeByName_ReturnValue_PropertyAddress;

	private static int SetCollisionObjectTypeByName_ReturnValue_Offset;

	private static bool SetCollisionObjectType_IsValid;

	private static IntPtr SetCollisionObjectType_FunctionAddress;

	private static int SetCollisionObjectType_ParamsSize;

	private static bool SetCollisionObjectType_Channel_IsValid;

	private static FFieldAddress SetCollisionObjectType_Channel_PropertyAddress;

	private static int SetCollisionObjectType_Channel_Offset;

	private static bool SetCollisionObjectType_Comp_IsValid;

	private static FFieldAddress SetCollisionObjectType_Comp_PropertyAddress;

	private static int SetCollisionObjectType_Comp_Offset;

	private static bool SetCollisionObjectType_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionObjectType_ReturnValue_PropertyAddress;

	private static int SetCollisionObjectType_ReturnValue_Offset;

	private static bool SetCollisionEnabledForceByName_IsValid;

	private static IntPtr SetCollisionEnabledForceByName_FunctionAddress;

	private static int SetCollisionEnabledForceByName_ParamsSize;

	private static bool SetCollisionEnabledForceByName_NewType_IsValid;

	private static FFieldAddress SetCollisionEnabledForceByName_NewType_PropertyAddress;

	private static int SetCollisionEnabledForceByName_NewType_Offset;

	private static bool SetCollisionEnabledForceByName_Name_IsValid;

	private static FFieldAddress SetCollisionEnabledForceByName_Name_PropertyAddress;

	private static int SetCollisionEnabledForceByName_Name_Offset;

	private static bool SetCollisionEnabledForceByName_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionEnabledForceByName_ReturnValue_PropertyAddress;

	private static int SetCollisionEnabledForceByName_ReturnValue_Offset;

	private static bool SetCollisionEnabledForce_IsValid;

	private static IntPtr SetCollisionEnabledForce_FunctionAddress;

	private static int SetCollisionEnabledForce_ParamsSize;

	private static bool SetCollisionEnabledForce_NewType_IsValid;

	private static FFieldAddress SetCollisionEnabledForce_NewType_PropertyAddress;

	private static int SetCollisionEnabledForce_NewType_Offset;

	private static bool SetCollisionEnabledForce_Comp_IsValid;

	private static FFieldAddress SetCollisionEnabledForce_Comp_PropertyAddress;

	private static int SetCollisionEnabledForce_Comp_Offset;

	private static bool SetCollisionEnabledForce_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionEnabledForce_ReturnValue_PropertyAddress;

	private static int SetCollisionEnabledForce_ReturnValue_Offset;

	private static bool SetAllCollisionResponseToChannel_IsValid;

	private static IntPtr SetAllCollisionResponseToChannel_FunctionAddress;

	private static int SetAllCollisionResponseToChannel_ParamsSize;

	private static bool SetAllCollisionResponseToChannel_Channel_IsValid;

	private static FFieldAddress SetAllCollisionResponseToChannel_Channel_PropertyAddress;

	private static int SetAllCollisionResponseToChannel_Channel_Offset;

	private static bool SetAllCollisionResponseToChannel_NewResponse_IsValid;

	private static FFieldAddress SetAllCollisionResponseToChannel_NewResponse_PropertyAddress;

	private static int SetAllCollisionResponseToChannel_NewResponse_Offset;

	private static bool SetAllCollisionResponseToChannel_ReturnValue_IsValid;

	private static FFieldAddress SetAllCollisionResponseToChannel_ReturnValue_PropertyAddress;

	private static int SetAllCollisionResponseToChannel_ReturnValue_Offset;

	private static bool SetAllCollisionResponseToAllChannels_IsValid;

	private static IntPtr SetAllCollisionResponseToAllChannels_FunctionAddress;

	private static int SetAllCollisionResponseToAllChannels_ParamsSize;

	private static bool SetAllCollisionResponseToAllChannels_NewResponse_IsValid;

	private static FFieldAddress SetAllCollisionResponseToAllChannels_NewResponse_PropertyAddress;

	private static int SetAllCollisionResponseToAllChannels_NewResponse_Offset;

	private static bool SetAllCollisionResponseToAllChannels_ReturnValue_IsValid;

	private static FFieldAddress SetAllCollisionResponseToAllChannels_ReturnValue_PropertyAddress;

	private static int SetAllCollisionResponseToAllChannels_ReturnValue_Offset;

	private static bool SetAllCollisionObjectType_IsValid;

	private static IntPtr SetAllCollisionObjectType_FunctionAddress;

	private static int SetAllCollisionObjectType_ParamsSize;

	private static bool SetAllCollisionObjectType_Channel_IsValid;

	private static FFieldAddress SetAllCollisionObjectType_Channel_PropertyAddress;

	private static int SetAllCollisionObjectType_Channel_Offset;

	private static bool SetAllCollisionObjectType_ReturnValue_IsValid;

	private static FFieldAddress SetAllCollisionObjectType_ReturnValue_PropertyAddress;

	private static int SetAllCollisionObjectType_ReturnValue_Offset;

	private static bool SetAllCollisionEnabledForce_IsValid;

	private static IntPtr SetAllCollisionEnabledForce_FunctionAddress;

	private static int SetAllCollisionEnabledForce_ParamsSize;

	private static bool SetAllCollisionEnabledForce_NewType_IsValid;

	private static FFieldAddress SetAllCollisionEnabledForce_NewType_PropertyAddress;

	private static int SetAllCollisionEnabledForce_NewType_Offset;

	private static bool SetAllCollisionEnabledForce_ReturnValue_IsValid;

	private static FFieldAddress SetAllCollisionEnabledForce_ReturnValue_PropertyAddress;

	private static int SetAllCollisionEnabledForce_ReturnValue_Offset;

	private static bool ReAttachToBones_IsValid;

	private static IntPtr ReAttachToBones_FunctionAddress;

	private static int ReAttachToBones_ParamsSize;

	private static bool ReAttachToBones_ReturnValue_IsValid;

	private static FFieldAddress ReAttachToBones_ReturnValue_PropertyAddress;

	private static int ReAttachToBones_ReturnValue_Offset;

	private static bool GenerateDestructibleMeshComponents_IsValid;

	private static IntPtr GenerateDestructibleMeshComponents_FunctionAddress;

	private static int GenerateDestructibleMeshComponents_ParamsSize;

	private static bool GenerateDestructibleMeshComponents_ReturnValue_IsValid;

	private static FFieldAddress GenerateDestructibleMeshComponents_ReturnValue_PropertyAddress;

	private static int GenerateDestructibleMeshComponents_ReturnValue_Offset;

	private static bool GenerateAnimlMeshPreviewObject_IsValid;

	private static IntPtr GenerateAnimlMeshPreviewObject_FunctionAddress;

	private static int GenerateAnimlMeshPreviewObject_ParamsSize;

	private static bool GenerateAnimlMeshPreviewObject_ReturnValue_IsValid;

	private static FFieldAddress GenerateAnimlMeshPreviewObject_ReturnValue_PropertyAddress;

	private static int GenerateAnimlMeshPreviewObject_ReturnValue_Offset;

	private static bool CallFloatCurve_IsValid;

	private static IntPtr CallFloatCurve_FunctionAddress;

	private static int CallFloatCurve_ParamsSize;

	private static bool CallFloatCurve_ReturnValue_IsValid;

	private static FFieldAddress CallFloatCurve_ReturnValue_PropertyAddress;

	private static int CallFloatCurve_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:TargetBlueprint")]
	public UBlueprint TargetBlueprint
	{
		get
		{
			CheckDestroyed();
			if (!TargetBlueprint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:TargetBlueprint");
				return null;
			}
			return UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(base.Address, TargetBlueprint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetBlueprint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:TargetBlueprint");
			}
			else
			{
				UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(base.Address, TargetBlueprint_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:FolderPath")]
	public string FolderPath
	{
		get
		{
			CheckDestroyed();
			if (!FolderPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:FolderPath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FolderPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FolderPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:FolderPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FolderPath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504149383315981uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:DestructibleComponentArray")]
	public TArrayReadWrite<UDestructibleComponent> DestructibleComponentArray
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleComponentArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:DestructibleComponentArray");
				return null;
			}
			if (DestructibleComponentArray_MarshalerCached == null)
			{
				DestructibleComponentArray_MarshalerCached = new TArrayReadWriteMarshaler<UDestructibleComponent>(1, DestructibleComponentArray_PropertyAddress, CachedMarshalingDelegates<UDestructibleComponent, UObjectMarshaler<UDestructibleComponent>>.FromNative, CachedMarshalingDelegates<UDestructibleComponent, UObjectMarshaler<UDestructibleComponent>>.ToNative);
			}
			return DestructibleComponentArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, DestructibleComponentArray_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:BoneNameArray")]
	public TArrayReadWrite<FName> BoneNameArray
	{
		get
		{
			CheckDestroyed();
			if (!BoneNameArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:BoneNameArray");
				return null;
			}
			if (BoneNameArray_MarshalerCached == null)
			{
				BoneNameArray_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, BoneNameArray_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneNameArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, BoneNameArray_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:bUseCustomCollisionToDefault")]
	public bool UseCustomCollisionToDefault
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomCollisionToDefault_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:bUseCustomCollisionToDefault");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomCollisionToDefault_Offset), 0, UseCustomCollisionToDefault_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomCollisionToDefault_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:bUseCustomCollisionToDefault");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomCollisionToDefault_Offset), 0, UseCustomCollisionToDefault_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:bRefreshPriviewObjectsOnAnimalMesh")]
	public bool RefreshPriviewObjectsOnAnimalMesh
	{
		get
		{
			CheckDestroyed();
			if (!RefreshPriviewObjectsOnAnimalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:bRefreshPriviewObjectsOnAnimalMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RefreshPriviewObjectsOnAnimalMesh_Offset), 0, RefreshPriviewObjectsOnAnimalMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RefreshPriviewObjectsOnAnimalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:bRefreshPriviewObjectsOnAnimalMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RefreshPriviewObjectsOnAnimalMesh_Offset), 0, RefreshPriviewObjectsOnAnimalMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:BodyInstance")]
	public FBodyInstance BodyInstance
	{
		get
		{
			CheckDestroyed();
			if (!BodyInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:BodyInstance");
				return default(FBodyInstance);
			}
			return FBodyInstance.FromNative(IntPtr.Add(base.Address, BodyInstance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:BodyInstance");
			}
			else
			{
				FBodyInstance.ToNative(IntPtr.Add(base.Address, BodyInstance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:FloatCurve")]
	public UCurveFloat FloatCurve
	{
		get
		{
			CheckDestroyed();
			if (!FloatCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:FloatCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, FloatCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FloatCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:FloatCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, FloatCurve_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:ParamName")]
	public FName ParamName
	{
		get
		{
			CheckDestroyed();
			if (!ParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:ParamName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ParamName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:ParamName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ParamName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:FloatCurveTick")]
	public FComponentCurveSignature FloatCurveTick
	{
		get
		{
			CheckDestroyed();
			if (!FloatCurveTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:FloatCurveTick");
				return new FComponentCurveSignature();
			}
			if (FloatCurveTick_DelegateCached == null)
			{
				FloatCurveTick_DelegateCached = new FComponentCurveSignature();
				FloatCurveTick_DelegateCached.SetAddress(IntPtr.Add(base.Address, FloatCurveTick_Offset));
			}
			return FloatCurveTick_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToChannelByName")]
	public unsafe bool SetCollisionResponseToChannelByName(ECollisionChannel Channel, ECollisionResponseType NewResponse, string Name)
	{
		CheckDestroyed();
		if (!SetCollisionResponseToChannelByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToChannelByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionResponseToChannelByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionResponseToChannelByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToChannelByName_Channel_Offset), 0, SetCollisionResponseToChannelByName_Channel_PropertyAddress.Address, Channel);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToChannelByName_NewResponse_Offset), 0, SetCollisionResponseToChannelByName_NewResponse_PropertyAddress.Address, NewResponse);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToChannelByName_Name_Offset), 0, SetCollisionResponseToChannelByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionResponseToChannelByName_FunctionAddress, intPtr, SetCollisionResponseToChannelByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCollisionResponseToChannelByName_Name_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionResponseToChannelByName_ReturnValue_Offset), 0, SetCollisionResponseToChannelByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToChannel")]
	public unsafe bool SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponseType NewResponse, UDestructibleComponent Comp)
	{
		CheckDestroyed();
		if (!SetCollisionResponseToChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionResponseToChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionResponseToChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToChannel_Channel_Offset), 0, SetCollisionResponseToChannel_Channel_PropertyAddress.Address, Channel);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToChannel_NewResponse_Offset), 0, SetCollisionResponseToChannel_NewResponse_PropertyAddress.Address, NewResponse);
		UObjectMarshaler<UDestructibleComponent>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToChannel_Comp_Offset), 0, SetCollisionResponseToChannel_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionResponseToChannel_FunctionAddress, intPtr, SetCollisionResponseToChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionResponseToChannel_ReturnValue_Offset), 0, SetCollisionResponseToChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToAllChannelsByName")]
	public unsafe bool SetCollisionResponseToAllChannelsByName(ECollisionResponseType NewResponse, string Name)
	{
		CheckDestroyed();
		if (!SetCollisionResponseToAllChannelsByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToAllChannelsByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionResponseToAllChannelsByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionResponseToAllChannelsByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToAllChannelsByName_NewResponse_Offset), 0, SetCollisionResponseToAllChannelsByName_NewResponse_PropertyAddress.Address, NewResponse);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToAllChannelsByName_Name_Offset), 0, SetCollisionResponseToAllChannelsByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionResponseToAllChannelsByName_FunctionAddress, intPtr, SetCollisionResponseToAllChannelsByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCollisionResponseToAllChannelsByName_Name_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionResponseToAllChannelsByName_ReturnValue_Offset), 0, SetCollisionResponseToAllChannelsByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToAllChannels")]
	public unsafe bool SetCollisionResponseToAllChannels(ECollisionResponseType NewResponse, UDestructibleComponent Comp)
	{
		CheckDestroyed();
		if (!SetCollisionResponseToAllChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToAllChannels");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionResponseToAllChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionResponseToAllChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToAllChannels_NewResponse_Offset), 0, SetCollisionResponseToAllChannels_NewResponse_PropertyAddress.Address, NewResponse);
		UObjectMarshaler<UDestructibleComponent>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToAllChannels_Comp_Offset), 0, SetCollisionResponseToAllChannels_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionResponseToAllChannels_FunctionAddress, intPtr, SetCollisionResponseToAllChannels_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionResponseToAllChannels_ReturnValue_Offset), 0, SetCollisionResponseToAllChannels_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionObjectTypeByName")]
	public unsafe bool SetCollisionObjectTypeByName(ECollisionChannel Channel, string Name)
	{
		CheckDestroyed();
		if (!SetCollisionObjectTypeByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionObjectTypeByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionObjectTypeByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionObjectTypeByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SetCollisionObjectTypeByName_Channel_Offset), 0, SetCollisionObjectTypeByName_Channel_PropertyAddress.Address, Channel);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCollisionObjectTypeByName_Name_Offset), 0, SetCollisionObjectTypeByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionObjectTypeByName_FunctionAddress, intPtr, SetCollisionObjectTypeByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCollisionObjectTypeByName_Name_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionObjectTypeByName_ReturnValue_Offset), 0, SetCollisionObjectTypeByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionObjectType")]
	public unsafe bool SetCollisionObjectType(ECollisionChannel Channel, UDestructibleComponent Comp)
	{
		CheckDestroyed();
		if (!SetCollisionObjectType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionObjectType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionObjectType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionObjectType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SetCollisionObjectType_Channel_Offset), 0, SetCollisionObjectType_Channel_PropertyAddress.Address, Channel);
		UObjectMarshaler<UDestructibleComponent>.ToNative(IntPtr.Add(intPtr, SetCollisionObjectType_Comp_Offset), 0, SetCollisionObjectType_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionObjectType_FunctionAddress, intPtr, SetCollisionObjectType_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionObjectType_ReturnValue_Offset), 0, SetCollisionObjectType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionEnabledForceByName")]
	public unsafe bool SetCollisionEnabledForceByName(ECollisionEnabled NewType, string Name)
	{
		CheckDestroyed();
		if (!SetCollisionEnabledForceByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionEnabledForceByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionEnabledForceByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionEnabledForceByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, SetCollisionEnabledForceByName_NewType_Offset), 0, SetCollisionEnabledForceByName_NewType_PropertyAddress.Address, NewType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCollisionEnabledForceByName_Name_Offset), 0, SetCollisionEnabledForceByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionEnabledForceByName_FunctionAddress, intPtr, SetCollisionEnabledForceByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCollisionEnabledForceByName_Name_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionEnabledForceByName_ReturnValue_Offset), 0, SetCollisionEnabledForceByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionEnabledForce")]
	public unsafe bool SetCollisionEnabledForce(ECollisionEnabled NewType, UDestructibleComponent Comp)
	{
		CheckDestroyed();
		if (!SetCollisionEnabledForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionEnabledForce");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionEnabledForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionEnabledForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, SetCollisionEnabledForce_NewType_Offset), 0, SetCollisionEnabledForce_NewType_PropertyAddress.Address, NewType);
		UObjectMarshaler<UDestructibleComponent>.ToNative(IntPtr.Add(intPtr, SetCollisionEnabledForce_Comp_Offset), 0, SetCollisionEnabledForce_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionEnabledForce_FunctionAddress, intPtr, SetCollisionEnabledForce_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionEnabledForce_ReturnValue_Offset), 0, SetCollisionEnabledForce_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionResponseToChannel")]
	public unsafe bool SetAllCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponseType NewResponse)
	{
		CheckDestroyed();
		if (!SetAllCollisionResponseToChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionResponseToChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllCollisionResponseToChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllCollisionResponseToChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SetAllCollisionResponseToChannel_Channel_Offset), 0, SetAllCollisionResponseToChannel_Channel_PropertyAddress.Address, Channel);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetAllCollisionResponseToChannel_NewResponse_Offset), 0, SetAllCollisionResponseToChannel_NewResponse_PropertyAddress.Address, NewResponse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllCollisionResponseToChannel_FunctionAddress, intPtr, SetAllCollisionResponseToChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAllCollisionResponseToChannel_ReturnValue_Offset), 0, SetAllCollisionResponseToChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionResponseToAllChannels")]
	public unsafe bool SetAllCollisionResponseToAllChannels(ECollisionResponseType NewResponse)
	{
		CheckDestroyed();
		if (!SetAllCollisionResponseToAllChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionResponseToAllChannels");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllCollisionResponseToAllChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllCollisionResponseToAllChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetAllCollisionResponseToAllChannels_NewResponse_Offset), 0, SetAllCollisionResponseToAllChannels_NewResponse_PropertyAddress.Address, NewResponse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllCollisionResponseToAllChannels_FunctionAddress, intPtr, SetAllCollisionResponseToAllChannels_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAllCollisionResponseToAllChannels_ReturnValue_Offset), 0, SetAllCollisionResponseToAllChannels_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionObjectType")]
	public unsafe bool SetAllCollisionObjectType(ECollisionChannel Channel)
	{
		CheckDestroyed();
		if (!SetAllCollisionObjectType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionObjectType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllCollisionObjectType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllCollisionObjectType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SetAllCollisionObjectType_Channel_Offset), 0, SetAllCollisionObjectType_Channel_PropertyAddress.Address, Channel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllCollisionObjectType_FunctionAddress, intPtr, SetAllCollisionObjectType_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAllCollisionObjectType_ReturnValue_Offset), 0, SetAllCollisionObjectType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionEnabledForce")]
	public unsafe bool SetAllCollisionEnabledForce(ECollisionEnabled NewType)
	{
		CheckDestroyed();
		if (!SetAllCollisionEnabledForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionEnabledForce");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllCollisionEnabledForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllCollisionEnabledForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, SetAllCollisionEnabledForce_NewType_Offset), 0, SetAllCollisionEnabledForce_NewType_PropertyAddress.Address, NewType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllCollisionEnabledForce_FunctionAddress, intPtr, SetAllCollisionEnabledForce_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAllCollisionEnabledForce_ReturnValue_Offset), 0, SetAllCollisionEnabledForce_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:ReAttachToBones")]
	public unsafe bool ReAttachToBones()
	{
		CheckDestroyed();
		if (!ReAttachToBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:ReAttachToBones");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReAttachToBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReAttachToBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReAttachToBones_FunctionAddress, intPtr, ReAttachToBones_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReAttachToBones_ReturnValue_Offset), 0, ReAttachToBones_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:GenerateDestructibleMeshComponents")]
	public unsafe bool GenerateDestructibleMeshComponents()
	{
		CheckDestroyed();
		if (!GenerateDestructibleMeshComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:GenerateDestructibleMeshComponents");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateDestructibleMeshComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateDestructibleMeshComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateDestructibleMeshComponents_FunctionAddress, intPtr, GenerateDestructibleMeshComponents_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateDestructibleMeshComponents_ReturnValue_Offset), 0, GenerateDestructibleMeshComponents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:GenerateAnimlMeshPreviewObject")]
	public unsafe bool GenerateAnimlMeshPreviewObject()
	{
		CheckDestroyed();
		if (!GenerateAnimlMeshPreviewObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:GenerateAnimlMeshPreviewObject");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateAnimlMeshPreviewObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateAnimlMeshPreviewObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateAnimlMeshPreviewObject_FunctionAddress, intPtr, GenerateAnimlMeshPreviewObject_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateAnimlMeshPreviewObject_ReturnValue_Offset), 0, GenerateAnimlMeshPreviewObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:CallFloatCurve")]
	public unsafe bool CallFloatCurve()
	{
		CheckDestroyed();
		if (!CallFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:CallFloatCurve");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CallFloatCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CallFloatCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CallFloatCurve_FunctionAddress, intPtr, CallFloatCurve_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CallFloatCurve_ReturnValue_Offset), 0, CallFloatCurve_ReturnValue_PropertyAddress.Address);
	}

	static UGSEDestructibleMeshGenComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEDestructibleMeshGenComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEDestructibleMeshGenComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent");
		TargetBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetBlueprint");
		TargetBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetBlueprint", Classes.FObjectProperty);
		FolderPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FolderPath");
		FolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DestructibleComponentArray_PropertyAddress, intPtr, "DestructibleComponentArray");
		DestructibleComponentArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DestructibleComponentArray");
		DestructibleComponentArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DestructibleComponentArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoneNameArray_PropertyAddress, intPtr, "BoneNameArray");
		BoneNameArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneNameArray");
		BoneNameArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneNameArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomCollisionToDefault_PropertyAddress, intPtr, "bUseCustomCollisionToDefault");
		UseCustomCollisionToDefault_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCustomCollisionToDefault");
		UseCustomCollisionToDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCustomCollisionToDefault", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RefreshPriviewObjectsOnAnimalMesh_PropertyAddress, intPtr, "bRefreshPriviewObjectsOnAnimalMesh");
		RefreshPriviewObjectsOnAnimalMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRefreshPriviewObjectsOnAnimalMesh");
		RefreshPriviewObjectsOnAnimalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRefreshPriviewObjectsOnAnimalMesh", Classes.FBoolProperty);
		BodyInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BodyInstance");
		BodyInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BodyInstance", Classes.FStructProperty);
		FloatCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloatCurve");
		FloatCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloatCurve", Classes.FObjectProperty);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		FloatCurveTick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloatCurveTick");
		FloatCurveTick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloatCurveTick", Classes.FMulticastDelegateProperty);
		SetCollisionResponseToChannelByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionResponseToChannelByName");
		SetCollisionResponseToChannelByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionResponseToChannelByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannelByName_Channel_PropertyAddress, SetCollisionResponseToChannelByName_FunctionAddress, "Channel");
		SetCollisionResponseToChannelByName_Channel_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannelByName_FunctionAddress, "Channel");
		SetCollisionResponseToChannelByName_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannelByName_FunctionAddress, "Channel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannelByName_NewResponse_PropertyAddress, SetCollisionResponseToChannelByName_FunctionAddress, "NewResponse");
		SetCollisionResponseToChannelByName_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannelByName_FunctionAddress, "NewResponse");
		SetCollisionResponseToChannelByName_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannelByName_FunctionAddress, "NewResponse", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannelByName_Name_PropertyAddress, SetCollisionResponseToChannelByName_FunctionAddress, "Name");
		SetCollisionResponseToChannelByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannelByName_FunctionAddress, "Name");
		SetCollisionResponseToChannelByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannelByName_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannelByName_ReturnValue_PropertyAddress, SetCollisionResponseToChannelByName_FunctionAddress, "ReturnValue");
		SetCollisionResponseToChannelByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannelByName_FunctionAddress, "ReturnValue");
		SetCollisionResponseToChannelByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannelByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionResponseToChannelByName_IsValid = SetCollisionResponseToChannelByName_FunctionAddress != IntPtr.Zero && SetCollisionResponseToChannelByName_Channel_IsValid && SetCollisionResponseToChannelByName_NewResponse_IsValid && SetCollisionResponseToChannelByName_Name_IsValid && SetCollisionResponseToChannelByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToChannelByName", SetCollisionResponseToChannelByName_IsValid);
		SetCollisionResponseToChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionResponseToChannel");
		SetCollisionResponseToChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionResponseToChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannel_Channel_PropertyAddress, SetCollisionResponseToChannel_FunctionAddress, "Channel");
		SetCollisionResponseToChannel_Channel_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannel_FunctionAddress, "Channel");
		SetCollisionResponseToChannel_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannel_FunctionAddress, "Channel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannel_NewResponse_PropertyAddress, SetCollisionResponseToChannel_FunctionAddress, "NewResponse");
		SetCollisionResponseToChannel_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannel_FunctionAddress, "NewResponse");
		SetCollisionResponseToChannel_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannel_FunctionAddress, "NewResponse", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannel_Comp_PropertyAddress, SetCollisionResponseToChannel_FunctionAddress, "Comp");
		SetCollisionResponseToChannel_Comp_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannel_FunctionAddress, "Comp");
		SetCollisionResponseToChannel_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannel_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannel_ReturnValue_PropertyAddress, SetCollisionResponseToChannel_FunctionAddress, "ReturnValue");
		SetCollisionResponseToChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannel_FunctionAddress, "ReturnValue");
		SetCollisionResponseToChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionResponseToChannel_IsValid = SetCollisionResponseToChannel_FunctionAddress != IntPtr.Zero && SetCollisionResponseToChannel_Channel_IsValid && SetCollisionResponseToChannel_NewResponse_IsValid && SetCollisionResponseToChannel_Comp_IsValid && SetCollisionResponseToChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToChannel", SetCollisionResponseToChannel_IsValid);
		SetCollisionResponseToAllChannelsByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionResponseToAllChannelsByName");
		SetCollisionResponseToAllChannelsByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionResponseToAllChannelsByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToAllChannelsByName_NewResponse_PropertyAddress, SetCollisionResponseToAllChannelsByName_FunctionAddress, "NewResponse");
		SetCollisionResponseToAllChannelsByName_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToAllChannelsByName_FunctionAddress, "NewResponse");
		SetCollisionResponseToAllChannelsByName_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToAllChannelsByName_FunctionAddress, "NewResponse", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToAllChannelsByName_Name_PropertyAddress, SetCollisionResponseToAllChannelsByName_FunctionAddress, "Name");
		SetCollisionResponseToAllChannelsByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToAllChannelsByName_FunctionAddress, "Name");
		SetCollisionResponseToAllChannelsByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToAllChannelsByName_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToAllChannelsByName_ReturnValue_PropertyAddress, SetCollisionResponseToAllChannelsByName_FunctionAddress, "ReturnValue");
		SetCollisionResponseToAllChannelsByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToAllChannelsByName_FunctionAddress, "ReturnValue");
		SetCollisionResponseToAllChannelsByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToAllChannelsByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionResponseToAllChannelsByName_IsValid = SetCollisionResponseToAllChannelsByName_FunctionAddress != IntPtr.Zero && SetCollisionResponseToAllChannelsByName_NewResponse_IsValid && SetCollisionResponseToAllChannelsByName_Name_IsValid && SetCollisionResponseToAllChannelsByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToAllChannelsByName", SetCollisionResponseToAllChannelsByName_IsValid);
		SetCollisionResponseToAllChannels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionResponseToAllChannels");
		SetCollisionResponseToAllChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionResponseToAllChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToAllChannels_NewResponse_PropertyAddress, SetCollisionResponseToAllChannels_FunctionAddress, "NewResponse");
		SetCollisionResponseToAllChannels_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToAllChannels_FunctionAddress, "NewResponse");
		SetCollisionResponseToAllChannels_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToAllChannels_FunctionAddress, "NewResponse", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToAllChannels_Comp_PropertyAddress, SetCollisionResponseToAllChannels_FunctionAddress, "Comp");
		SetCollisionResponseToAllChannels_Comp_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToAllChannels_FunctionAddress, "Comp");
		SetCollisionResponseToAllChannels_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToAllChannels_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToAllChannels_ReturnValue_PropertyAddress, SetCollisionResponseToAllChannels_FunctionAddress, "ReturnValue");
		SetCollisionResponseToAllChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToAllChannels_FunctionAddress, "ReturnValue");
		SetCollisionResponseToAllChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToAllChannels_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionResponseToAllChannels_IsValid = SetCollisionResponseToAllChannels_FunctionAddress != IntPtr.Zero && SetCollisionResponseToAllChannels_NewResponse_IsValid && SetCollisionResponseToAllChannels_Comp_IsValid && SetCollisionResponseToAllChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionResponseToAllChannels", SetCollisionResponseToAllChannels_IsValid);
		SetCollisionObjectTypeByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionObjectTypeByName");
		SetCollisionObjectTypeByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionObjectTypeByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionObjectTypeByName_Channel_PropertyAddress, SetCollisionObjectTypeByName_FunctionAddress, "Channel");
		SetCollisionObjectTypeByName_Channel_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionObjectTypeByName_FunctionAddress, "Channel");
		SetCollisionObjectTypeByName_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionObjectTypeByName_FunctionAddress, "Channel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionObjectTypeByName_Name_PropertyAddress, SetCollisionObjectTypeByName_FunctionAddress, "Name");
		SetCollisionObjectTypeByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionObjectTypeByName_FunctionAddress, "Name");
		SetCollisionObjectTypeByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionObjectTypeByName_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionObjectTypeByName_ReturnValue_PropertyAddress, SetCollisionObjectTypeByName_FunctionAddress, "ReturnValue");
		SetCollisionObjectTypeByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionObjectTypeByName_FunctionAddress, "ReturnValue");
		SetCollisionObjectTypeByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionObjectTypeByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionObjectTypeByName_IsValid = SetCollisionObjectTypeByName_FunctionAddress != IntPtr.Zero && SetCollisionObjectTypeByName_Channel_IsValid && SetCollisionObjectTypeByName_Name_IsValid && SetCollisionObjectTypeByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionObjectTypeByName", SetCollisionObjectTypeByName_IsValid);
		SetCollisionObjectType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionObjectType");
		SetCollisionObjectType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionObjectType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionObjectType_Channel_PropertyAddress, SetCollisionObjectType_FunctionAddress, "Channel");
		SetCollisionObjectType_Channel_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionObjectType_FunctionAddress, "Channel");
		SetCollisionObjectType_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionObjectType_FunctionAddress, "Channel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionObjectType_Comp_PropertyAddress, SetCollisionObjectType_FunctionAddress, "Comp");
		SetCollisionObjectType_Comp_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionObjectType_FunctionAddress, "Comp");
		SetCollisionObjectType_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionObjectType_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionObjectType_ReturnValue_PropertyAddress, SetCollisionObjectType_FunctionAddress, "ReturnValue");
		SetCollisionObjectType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionObjectType_FunctionAddress, "ReturnValue");
		SetCollisionObjectType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionObjectType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionObjectType_IsValid = SetCollisionObjectType_FunctionAddress != IntPtr.Zero && SetCollisionObjectType_Channel_IsValid && SetCollisionObjectType_Comp_IsValid && SetCollisionObjectType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionObjectType", SetCollisionObjectType_IsValid);
		SetCollisionEnabledForceByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionEnabledForceByName");
		SetCollisionEnabledForceByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionEnabledForceByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnabledForceByName_NewType_PropertyAddress, SetCollisionEnabledForceByName_FunctionAddress, "NewType");
		SetCollisionEnabledForceByName_NewType_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnabledForceByName_FunctionAddress, "NewType");
		SetCollisionEnabledForceByName_NewType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnabledForceByName_FunctionAddress, "NewType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnabledForceByName_Name_PropertyAddress, SetCollisionEnabledForceByName_FunctionAddress, "Name");
		SetCollisionEnabledForceByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnabledForceByName_FunctionAddress, "Name");
		SetCollisionEnabledForceByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnabledForceByName_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnabledForceByName_ReturnValue_PropertyAddress, SetCollisionEnabledForceByName_FunctionAddress, "ReturnValue");
		SetCollisionEnabledForceByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnabledForceByName_FunctionAddress, "ReturnValue");
		SetCollisionEnabledForceByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnabledForceByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionEnabledForceByName_IsValid = SetCollisionEnabledForceByName_FunctionAddress != IntPtr.Zero && SetCollisionEnabledForceByName_NewType_IsValid && SetCollisionEnabledForceByName_Name_IsValid && SetCollisionEnabledForceByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionEnabledForceByName", SetCollisionEnabledForceByName_IsValid);
		SetCollisionEnabledForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionEnabledForce");
		SetCollisionEnabledForce_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionEnabledForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnabledForce_NewType_PropertyAddress, SetCollisionEnabledForce_FunctionAddress, "NewType");
		SetCollisionEnabledForce_NewType_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnabledForce_FunctionAddress, "NewType");
		SetCollisionEnabledForce_NewType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnabledForce_FunctionAddress, "NewType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnabledForce_Comp_PropertyAddress, SetCollisionEnabledForce_FunctionAddress, "Comp");
		SetCollisionEnabledForce_Comp_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnabledForce_FunctionAddress, "Comp");
		SetCollisionEnabledForce_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnabledForce_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnabledForce_ReturnValue_PropertyAddress, SetCollisionEnabledForce_FunctionAddress, "ReturnValue");
		SetCollisionEnabledForce_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnabledForce_FunctionAddress, "ReturnValue");
		SetCollisionEnabledForce_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnabledForce_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionEnabledForce_IsValid = SetCollisionEnabledForce_FunctionAddress != IntPtr.Zero && SetCollisionEnabledForce_NewType_IsValid && SetCollisionEnabledForce_Comp_IsValid && SetCollisionEnabledForce_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetCollisionEnabledForce", SetCollisionEnabledForce_IsValid);
		SetAllCollisionResponseToChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllCollisionResponseToChannel");
		SetAllCollisionResponseToChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllCollisionResponseToChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionResponseToChannel_Channel_PropertyAddress, SetAllCollisionResponseToChannel_FunctionAddress, "Channel");
		SetAllCollisionResponseToChannel_Channel_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionResponseToChannel_FunctionAddress, "Channel");
		SetAllCollisionResponseToChannel_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionResponseToChannel_FunctionAddress, "Channel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionResponseToChannel_NewResponse_PropertyAddress, SetAllCollisionResponseToChannel_FunctionAddress, "NewResponse");
		SetAllCollisionResponseToChannel_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionResponseToChannel_FunctionAddress, "NewResponse");
		SetAllCollisionResponseToChannel_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionResponseToChannel_FunctionAddress, "NewResponse", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionResponseToChannel_ReturnValue_PropertyAddress, SetAllCollisionResponseToChannel_FunctionAddress, "ReturnValue");
		SetAllCollisionResponseToChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionResponseToChannel_FunctionAddress, "ReturnValue");
		SetAllCollisionResponseToChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionResponseToChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAllCollisionResponseToChannel_IsValid = SetAllCollisionResponseToChannel_FunctionAddress != IntPtr.Zero && SetAllCollisionResponseToChannel_Channel_IsValid && SetAllCollisionResponseToChannel_NewResponse_IsValid && SetAllCollisionResponseToChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionResponseToChannel", SetAllCollisionResponseToChannel_IsValid);
		SetAllCollisionResponseToAllChannels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllCollisionResponseToAllChannels");
		SetAllCollisionResponseToAllChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllCollisionResponseToAllChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionResponseToAllChannels_NewResponse_PropertyAddress, SetAllCollisionResponseToAllChannels_FunctionAddress, "NewResponse");
		SetAllCollisionResponseToAllChannels_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionResponseToAllChannels_FunctionAddress, "NewResponse");
		SetAllCollisionResponseToAllChannels_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionResponseToAllChannels_FunctionAddress, "NewResponse", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionResponseToAllChannels_ReturnValue_PropertyAddress, SetAllCollisionResponseToAllChannels_FunctionAddress, "ReturnValue");
		SetAllCollisionResponseToAllChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionResponseToAllChannels_FunctionAddress, "ReturnValue");
		SetAllCollisionResponseToAllChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionResponseToAllChannels_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAllCollisionResponseToAllChannels_IsValid = SetAllCollisionResponseToAllChannels_FunctionAddress != IntPtr.Zero && SetAllCollisionResponseToAllChannels_NewResponse_IsValid && SetAllCollisionResponseToAllChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionResponseToAllChannels", SetAllCollisionResponseToAllChannels_IsValid);
		SetAllCollisionObjectType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllCollisionObjectType");
		SetAllCollisionObjectType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllCollisionObjectType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionObjectType_Channel_PropertyAddress, SetAllCollisionObjectType_FunctionAddress, "Channel");
		SetAllCollisionObjectType_Channel_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionObjectType_FunctionAddress, "Channel");
		SetAllCollisionObjectType_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionObjectType_FunctionAddress, "Channel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionObjectType_ReturnValue_PropertyAddress, SetAllCollisionObjectType_FunctionAddress, "ReturnValue");
		SetAllCollisionObjectType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionObjectType_FunctionAddress, "ReturnValue");
		SetAllCollisionObjectType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionObjectType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAllCollisionObjectType_IsValid = SetAllCollisionObjectType_FunctionAddress != IntPtr.Zero && SetAllCollisionObjectType_Channel_IsValid && SetAllCollisionObjectType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionObjectType", SetAllCollisionObjectType_IsValid);
		SetAllCollisionEnabledForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllCollisionEnabledForce");
		SetAllCollisionEnabledForce_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllCollisionEnabledForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionEnabledForce_NewType_PropertyAddress, SetAllCollisionEnabledForce_FunctionAddress, "NewType");
		SetAllCollisionEnabledForce_NewType_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionEnabledForce_FunctionAddress, "NewType");
		SetAllCollisionEnabledForce_NewType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionEnabledForce_FunctionAddress, "NewType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllCollisionEnabledForce_ReturnValue_PropertyAddress, SetAllCollisionEnabledForce_FunctionAddress, "ReturnValue");
		SetAllCollisionEnabledForce_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAllCollisionEnabledForce_FunctionAddress, "ReturnValue");
		SetAllCollisionEnabledForce_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllCollisionEnabledForce_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAllCollisionEnabledForce_IsValid = SetAllCollisionEnabledForce_FunctionAddress != IntPtr.Zero && SetAllCollisionEnabledForce_NewType_IsValid && SetAllCollisionEnabledForce_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:SetAllCollisionEnabledForce", SetAllCollisionEnabledForce_IsValid);
		ReAttachToBones_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReAttachToBones");
		ReAttachToBones_ParamsSize = NativeReflection.GetFunctionParamsSize(ReAttachToBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReAttachToBones_ReturnValue_PropertyAddress, ReAttachToBones_FunctionAddress, "ReturnValue");
		ReAttachToBones_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReAttachToBones_FunctionAddress, "ReturnValue");
		ReAttachToBones_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReAttachToBones_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReAttachToBones_IsValid = ReAttachToBones_FunctionAddress != IntPtr.Zero && ReAttachToBones_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:ReAttachToBones", ReAttachToBones_IsValid);
		GenerateDestructibleMeshComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateDestructibleMeshComponents");
		GenerateDestructibleMeshComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateDestructibleMeshComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleMeshComponents_ReturnValue_PropertyAddress, GenerateDestructibleMeshComponents_FunctionAddress, "ReturnValue");
		GenerateDestructibleMeshComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleMeshComponents_FunctionAddress, "ReturnValue");
		GenerateDestructibleMeshComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleMeshComponents_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateDestructibleMeshComponents_IsValid = GenerateDestructibleMeshComponents_FunctionAddress != IntPtr.Zero && GenerateDestructibleMeshComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:GenerateDestructibleMeshComponents", GenerateDestructibleMeshComponents_IsValid);
		GenerateAnimlMeshPreviewObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateAnimlMeshPreviewObject");
		GenerateAnimlMeshPreviewObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateAnimlMeshPreviewObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateAnimlMeshPreviewObject_ReturnValue_PropertyAddress, GenerateAnimlMeshPreviewObject_FunctionAddress, "ReturnValue");
		GenerateAnimlMeshPreviewObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateAnimlMeshPreviewObject_FunctionAddress, "ReturnValue");
		GenerateAnimlMeshPreviewObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateAnimlMeshPreviewObject_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateAnimlMeshPreviewObject_IsValid = GenerateAnimlMeshPreviewObject_FunctionAddress != IntPtr.Zero && GenerateAnimlMeshPreviewObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:GenerateAnimlMeshPreviewObject", GenerateAnimlMeshPreviewObject_IsValid);
		CallFloatCurve_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CallFloatCurve");
		CallFloatCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(CallFloatCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CallFloatCurve_ReturnValue_PropertyAddress, CallFloatCurve_FunctionAddress, "ReturnValue");
		CallFloatCurve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CallFloatCurve_FunctionAddress, "ReturnValue");
		CallFloatCurve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CallFloatCurve_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CallFloatCurve_IsValid = CallFloatCurve_FunctionAddress != IntPtr.Zero && CallFloatCurve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSEDestructibleMeshGenComponent:CallFloatCurve", CallFloatCurve_IsValid);
	}
}
