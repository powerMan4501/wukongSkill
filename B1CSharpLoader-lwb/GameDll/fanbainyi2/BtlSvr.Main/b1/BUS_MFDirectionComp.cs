using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MFDirectionComp")]
public class BUS_MFDirectionComp : UActorEditCompBase
{
	private static bool DirectionUsage_IsValid;

	private static int DirectionUsage_Offset;

	private static FFieldAddress DirectionUsage_PropertyAddress;

	private static bool DirectionType_IsValid;

	private static int DirectionType_Offset;

	private static FFieldAddress DirectionType_PropertyAddress;

	private static bool DirectionTypeDetail_IsValid;

	private static int DirectionTypeDetail_Offset;

	private static FFieldAddress DirectionTypeDetail_PropertyAddress;

	private static bool AnchorPointTag_IsValid;

	private static int AnchorPointTag_Offset;

	private static bool DirectionEffects_IsValid;

	private static int DirectionEffects_Offset;

	private static FFieldAddress DirectionEffects_PropertyAddress;

	private TArrayReadWriteMarshaler<MFDirectionEffect> DirectionEffects_Marshaler;

	[EditAnywhere]
	[UProperty]
	[Category("Magic Field Direction Config")]
	[USharpPath("/Script/b1-Managed.BUS_MFDirectionComp:DirectionUsage")]
	public EMagicFieldDirectionUsage DirectionUsage
	{
		get
		{
			CheckDestroyed();
			if (!DirectionUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:DirectionUsage");
				return EMagicFieldDirectionUsage.None;
			}
			return EnumMarshaler<EMagicFieldDirectionUsage>.FromNative(IntPtr.Add(base.Address, DirectionUsage_Offset), 0, DirectionUsage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DirectionUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:DirectionUsage");
			}
			else
			{
				EnumMarshaler<EMagicFieldDirectionUsage>.ToNative(IntPtr.Add(base.Address, DirectionUsage_Offset), 0, DirectionUsage_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "DirectionUsage != EMagicFieldDirectionUsage::None")]
	[EditAnywhere]
	[UProperty]
	[Category("Magic Field Direction Config")]
	[USharpPath("/Script/b1-Managed.BUS_MFDirectionComp:DirectionType")]
	public EMagicFieldDirectionType DirectionType
	{
		get
		{
			CheckDestroyed();
			if (!DirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:DirectionType");
				return EMagicFieldDirectionType.None;
			}
			return EnumMarshaler<EMagicFieldDirectionType>.FromNative(IntPtr.Add(base.Address, DirectionType_Offset), 0, DirectionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:DirectionType");
			}
			else
			{
				EnumMarshaler<EMagicFieldDirectionType>.ToNative(IntPtr.Add(base.Address, DirectionType_Offset), 0, DirectionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Magic Field Direction Config")]
	[UMeta(MDProp.EditCondition, "DirectionType == EMagicFieldDirectionType::Radial || DirectionType == EMagicFieldDirectionType::Spiral")]
	[USharpPath("/Script/b1-Managed.BUS_MFDirectionComp:DirectionTypeDetail")]
	public EMagicFieldDirectionTypeDetail DirectionTypeDetail
	{
		get
		{
			CheckDestroyed();
			if (!DirectionTypeDetail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:DirectionTypeDetail");
				return EMagicFieldDirectionTypeDetail.Positive;
			}
			return EnumMarshaler<EMagicFieldDirectionTypeDetail>.FromNative(IntPtr.Add(base.Address, DirectionTypeDetail_Offset), 0, DirectionTypeDetail_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DirectionTypeDetail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:DirectionTypeDetail");
			}
			else
			{
				EnumMarshaler<EMagicFieldDirectionTypeDetail>.ToNative(IntPtr.Add(base.Address, DirectionTypeDetail_Offset), 0, DirectionTypeDetail_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Magic Field Direction Config")]
	[USharpPath("/Script/b1-Managed.BUS_MFDirectionComp:AnchorPointTag")]
	public FName AnchorPointTag
	{
		get
		{
			CheckDestroyed();
			if (!AnchorPointTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:AnchorPointTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AnchorPointTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnchorPointTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:AnchorPointTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AnchorPointTag_Offset), value);
			}
		}
	}

	[Category("Magic Field Direction Config")]
	[EditAnywhere]
	[DisplayName("任意方向单位效果列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_MFDirectionComp:DirectionEffects")]
	public TArrayReadWrite<MFDirectionEffect> DirectionEffects
	{
		get
		{
			CheckDestroyed();
			if (!DirectionEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MFDirectionComp:DirectionEffects");
				return null;
			}
			if (DirectionEffects_Marshaler == null)
			{
				DirectionEffects_Marshaler = new TArrayReadWriteMarshaler<MFDirectionEffect>(1, DirectionEffects_PropertyAddress, CachedMarshalingDelegates<MFDirectionEffect, MFDirectionEffect>.FromNative, CachedMarshalingDelegates<MFDirectionEffect, MFDirectionEffect>.ToNative);
			}
			return DirectionEffects_Marshaler.FromNative(IntPtr.Add(base.Address, DirectionEffects_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_MFDirectionData bUC_MFDirectionData = RequireWritableData<b1.BUC_MFDirectionData>();
		bUC_MFDirectionData.MFDirectionUsage = DirectionUsage;
		bUC_MFDirectionData.MFDirectionType = DirectionType;
		bUC_MFDirectionData.MFDirectionTypeDetail = DirectionTypeDetail;
		bUC_MFDirectionData.AnchorPointTag = AnchorPointTag;
		foreach (MFDirectionEffect directionEffect in DirectionEffects)
		{
			MFDirectionEffect DirectionEffect = directionEffect;
			bUC_MFDirectionData.DirectionEffects.Add(DirectionEffect.TriggerEvent, new MFDirectionEffectForData(in DirectionEffect));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_MFDirectionComp");
		NativeReflection.GetPropertyRef(ref DirectionUsage_PropertyAddress, unrealStruct, "DirectionUsage");
		DirectionUsage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionUsage");
		DirectionUsage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionUsage", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DirectionType_PropertyAddress, unrealStruct, "DirectionType");
		DirectionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionType");
		DirectionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DirectionTypeDetail_PropertyAddress, unrealStruct, "DirectionTypeDetail");
		DirectionTypeDetail_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionTypeDetail");
		DirectionTypeDetail_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionTypeDetail", Classes.FEnumProperty);
		AnchorPointTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnchorPointTag");
		AnchorPointTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnchorPointTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref DirectionEffects_PropertyAddress, unrealStruct, "DirectionEffects");
		DirectionEffects_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionEffects");
		DirectionEffects_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionEffects", Classes.FArrayProperty);
	}

	static BUS_MFDirectionComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_MFDirectionComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_MFDirectionComp));
	}
}
