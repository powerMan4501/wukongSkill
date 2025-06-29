using System;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig")]
public class BGWDataAsset_EquipIllusionConfig : UBGWDataAsset
{
	private static bool Position_IsValid;

	private static int Position_Offset;

	private static FFieldAddress Position_PropertyAddress;

	private static bool SM_IsValid;

	private static int SM_Offset;

	private static bool ABP_IsValid;

	private static int ABP_Offset;

	private static bool StaticMesh_IsValid;

	private static int StaticMesh_Offset;

	private static FFieldAddress StaticMesh_PropertyAddress;

	private TArrayReadWriteMarshaler<UStaticMesh> StaticMesh_Marshaler;

	private static bool ModularType_IsValid;

	private static int ModularType_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("装备位置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:Position")]
	public EquipPosition Position
	{
		get
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:Position");
				return EquipPosition.Head;
			}
			return EnumMarshaler<EquipPosition>.FromNative(IntPtr.Add(base.Address, Position_Offset), 0, Position_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:Position");
			}
			else
			{
				EnumMarshaler<EquipPosition>.ToNative(IntPtr.Add(base.Address, Position_Offset), 0, Position_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("用于替换的SkeletalMesh")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:SM")]
	public USkeletalMesh SM
	{
		get
		{
			CheckDestroyed();
			if (!SM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:SM");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, SM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:SM");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, SM_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("SkeletalMesh对应的ABP")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:ABP")]
	public TSubclassOf<UAnimInstance> ABP
	{
		get
		{
			CheckDestroyed();
			if (!ABP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:ABP");
				return default(TSubclassOf<UAnimInstance>);
			}
			return TSubclassOfMarshaler<UAnimInstance>.FromNative(IntPtr.Add(base.Address, ABP_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:ABP");
			}
			else
			{
				TSubclassOfMarshaler<UAnimInstance>.ToNative(IntPtr.Add(base.Address, ABP_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("部位StaticMesh")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:StaticMesh")]
	public TArrayReadWrite<UStaticMesh> StaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:StaticMesh");
				return null;
			}
			if (StaticMesh_Marshaler == null)
			{
				StaticMesh_Marshaler = new TArrayReadWriteMarshaler<UStaticMesh>(1, StaticMesh_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative);
			}
			return StaticMesh_Marshaler.FromNative(IntPtr.Add(base.Address, StaticMesh_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("角色模块类型：0主姿势，1拷贝姿势")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:ModularType")]
	public int ModularType
	{
		get
		{
			CheckDestroyed();
			if (!ModularType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:ModularType");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ModularType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModularType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig:ModularType");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ModularType_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_EquipIllusionConfig");
		NativeReflection.GetPropertyRef(ref Position_PropertyAddress, unrealStruct, "Position");
		Position_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Position");
		Position_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Position", Classes.FEnumProperty);
		SM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SM");
		SM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SM", Classes.FObjectProperty);
		ABP_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ABP");
		ABP_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ABP", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref StaticMesh_PropertyAddress, unrealStruct, "StaticMesh");
		StaticMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StaticMesh");
		StaticMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StaticMesh", Classes.FArrayProperty);
		ModularType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ModularType");
		ModularType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ModularType", Classes.FIntProperty);
	}

	static BGWDataAsset_EquipIllusionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_EquipIllusionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_EquipIllusionConfig));
	}
}
