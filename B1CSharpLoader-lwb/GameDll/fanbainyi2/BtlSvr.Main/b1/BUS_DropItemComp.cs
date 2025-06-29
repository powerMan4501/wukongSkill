using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DropItemComp")]
public class BUS_DropItemComp : UActorEditCompBase
{
	private static bool DropItemResID_IsValid;

	private static int DropItemResID_Offset;

	private static bool UseSoulBottleCondition_IsValid;

	private static int UseSoulBottleCondition_Offset;

	private static FFieldAddress UseSoulBottleCondition_PropertyAddress;

	private static bool NewFXSpawnCompTag_IsValid;

	private static int NewFXSpawnCompTag_Offset;

	private static bool NoSoulBottleDropTemplate_IsValid;

	private static int NoSoulBottleDropTemplate_Offset;

	private static bool HaveSoulBottleDropTemplate_IsValid;

	private static int HaveSoulBottleDropTemplate_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("DropItemConfig")]
	[DisplayName("物品ID")]
	[USharpPath("/Script/b1-Managed.BUS_DropItemComp:DropItemResID")]
	public int DropItemResID
	{
		get
		{
			CheckDestroyed();
			if (!DropItemResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:DropItemResID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DropItemResID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropItemResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:DropItemResID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DropItemResID_Offset), value);
			}
		}
	}

	[Tooltip("目前仅供精魄使用")]
	[UProperty]
	[EditAnywhere]
	[Category("魂瓶判断")]
	[DisplayName("使用魂瓶条件")]
	[USharpPath("/Script/b1-Managed.BUS_DropItemComp:UseSoulBottleCondition")]
	public bool UseSoulBottleCondition
	{
		get
		{
			CheckDestroyed();
			if (!UseSoulBottleCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:UseSoulBottleCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSoulBottleCondition_Offset), 0, UseSoulBottleCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSoulBottleCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:UseSoulBottleCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSoulBottleCondition_Offset), 0, UseSoulBottleCondition_PropertyAddress.Address, value);
			}
		}
	}

	[Category("魂瓶判断")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("新特效起始组件Tag")]
	[USharpPath("/Script/b1-Managed.BUS_DropItemComp:NewFXSpawnCompTag")]
	public FName NewFXSpawnCompTag
	{
		get
		{
			CheckDestroyed();
			if (!NewFXSpawnCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:NewFXSpawnCompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NewFXSpawnCompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NewFXSpawnCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:NewFXSpawnCompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NewFXSpawnCompTag_Offset), value);
			}
		}
	}

	[DisplayName("没有魂瓶掉落模板")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("魂瓶判断")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DropItemComp:NoSoulBottleDropTemplate")]
	public UBGWDropItemTemplete NoSoulBottleDropTemplate
	{
		get
		{
			CheckDestroyed();
			if (!NoSoulBottleDropTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:NoSoulBottleDropTemplate");
				return null;
			}
			return UObjectMarshaler<UBGWDropItemTemplete>.FromNative(IntPtr.Add(base.Address, NoSoulBottleDropTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoSoulBottleDropTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:NoSoulBottleDropTemplate");
			}
			else
			{
				UObjectMarshaler<UBGWDropItemTemplete>.ToNative(IntPtr.Add(base.Address, NoSoulBottleDropTemplate_Offset), value);
			}
		}
	}

	[DisplayName("拥有魂瓶掉落模板")]
	[Category("魂瓶判断")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DropItemComp:HaveSoulBottleDropTemplate")]
	public UBGWDropItemTemplete HaveSoulBottleDropTemplate
	{
		get
		{
			CheckDestroyed();
			if (!HaveSoulBottleDropTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:HaveSoulBottleDropTemplate");
				return null;
			}
			return UObjectMarshaler<UBGWDropItemTemplete>.FromNative(IntPtr.Add(base.Address, HaveSoulBottleDropTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HaveSoulBottleDropTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DropItemComp:HaveSoulBottleDropTemplate");
			}
			else
			{
				UObjectMarshaler<UBGWDropItemTemplete>.ToNative(IntPtr.Add(base.Address, HaveSoulBottleDropTemplate_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_DropItemData bUC_DropItemData = RequireWritableData<BUC_DropItemData>();
		bUC_DropItemData.ItemResID = DropItemResID;
		bUC_DropItemData.UseSoulBottleCondition = UseSoulBottleCondition;
		bUC_DropItemData.NoSoulBottleDropTemplate = NoSoulBottleDropTemplate;
		bUC_DropItemData.HaveSoulBottleDropTemplate = HaveSoulBottleDropTemplate;
		bUC_DropItemData.NewFXSpawnCompTag = NewFXSpawnCompTag;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_DropItemComp");
		DropItemResID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropItemResID");
		DropItemResID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropItemResID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref UseSoulBottleCondition_PropertyAddress, unrealStruct, "UseSoulBottleCondition");
		UseSoulBottleCondition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseSoulBottleCondition");
		UseSoulBottleCondition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseSoulBottleCondition", Classes.FBoolProperty);
		NewFXSpawnCompTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NewFXSpawnCompTag");
		NewFXSpawnCompTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NewFXSpawnCompTag", Classes.FNameProperty);
		NoSoulBottleDropTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoSoulBottleDropTemplate");
		NoSoulBottleDropTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoSoulBottleDropTemplate", Classes.FObjectProperty);
		HaveSoulBottleDropTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HaveSoulBottleDropTemplate");
		HaveSoulBottleDropTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HaveSoulBottleDropTemplate", Classes.FObjectProperty);
	}

	static BUS_DropItemComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DropItemComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DropItemComp));
	}
}
