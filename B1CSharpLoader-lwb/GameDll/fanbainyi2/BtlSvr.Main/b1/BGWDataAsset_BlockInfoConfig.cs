using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig")]
public class BGWDataAsset_BlockInfoConfig : UBGWDataAsset, b1.IBGWDataAssetHasAnimationReferences
{
	private static bool BlockCounterType_IsValid;

	private static int BlockCounterType_Offset;

	private static FFieldAddress BlockCounterType_PropertyAddress;

	private static bool BlockAMSelectMode_IsValid;

	private static int BlockAMSelectMode_Offset;

	private static FFieldAddress BlockAMSelectMode_PropertyAddress;

	private static bool BlockTiggerAngleLeft_IsValid;

	private static int BlockTiggerAngleLeft_Offset;

	private static bool BlockTiggerAngleRight_IsValid;

	private static int BlockTiggerAngleRight_Offset;

	private static bool AreaDivisionLineForwardLeft_IsValid;

	private static int AreaDivisionLineForwardLeft_Offset;

	private static bool AreaDivisionLineForwardRight_IsValid;

	private static int AreaDivisionLineForwardRight_Offset;

	private static bool AreaDivisionLineBackwardLeft_IsValid;

	private static int AreaDivisionLineBackwardLeft_Offset;

	private static bool AreaDivisionLineBackwardRight_IsValid;

	private static int AreaDivisionLineBackwardRight_Offset;

	private static bool PerfectBlockInfoWarp_IsValid;

	private static int PerfectBlockInfoWarp_Offset;

	private static bool NormalBlockInfoWarp_IsValid;

	private static int NormalBlockInfoWarp_Offset;

	private static bool BeAttackedBlockInfoWarp_IsValid;

	private static int BeAttackedBlockInfoWarp_Offset;

	[UProperty]
	[EditAnywhere]
	[DisplayName("格挡计数类型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockCounterType")]
	public EBlockCounterType BlockCounterType
	{
		get
		{
			CheckDestroyed();
			if (!BlockCounterType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockCounterType");
				return EBlockCounterType.AddCountAfterBounced;
			}
			return EnumMarshaler<EBlockCounterType>.FromNative(IntPtr.Add(base.Address, BlockCounterType_Offset), 0, BlockCounterType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlockCounterType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockCounterType");
			}
			else
			{
				EnumMarshaler<EBlockCounterType>.ToNative(IntPtr.Add(base.Address, BlockCounterType_Offset), 0, BlockCounterType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("格挡动画选择模式")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockAMSelectMode")]
	public EBlockAMSelectMode BlockAMSelectMode
	{
		get
		{
			CheckDestroyed();
			if (!BlockAMSelectMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockAMSelectMode");
				return EBlockAMSelectMode.SequenceSelectMode;
			}
			return EnumMarshaler<EBlockAMSelectMode>.FromNative(IntPtr.Add(base.Address, BlockAMSelectMode_Offset), 0, BlockAMSelectMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlockAMSelectMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockAMSelectMode");
			}
			else
			{
				EnumMarshaler<EBlockAMSelectMode>.ToNative(IntPtr.Add(base.Address, BlockAMSelectMode_Offset), 0, BlockAMSelectMode_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, "180")]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, "-180")]
	[Tooltip("以角色正前方为0°，左边最大-180°，右边最大180°")]
	[DisplayName("格挡触发角度左")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockTiggerAngleLeft")]
	public float BlockTiggerAngleLeft
	{
		get
		{
			CheckDestroyed();
			if (!BlockTiggerAngleLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockTiggerAngleLeft");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlockTiggerAngleLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlockTiggerAngleLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockTiggerAngleLeft");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlockTiggerAngleLeft_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "-180")]
	[Tooltip("以角色正前方为0°，左边最大-180°，右边最大180°")]
	[UMeta(MDProp.ClampMax, "180")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("格挡触发角度右")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockTiggerAngleRight")]
	public float BlockTiggerAngleRight
	{
		get
		{
			CheckDestroyed();
			if (!BlockTiggerAngleRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockTiggerAngleRight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlockTiggerAngleRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlockTiggerAngleRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BlockTiggerAngleRight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlockTiggerAngleRight_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, "180")]
	[Tooltip("用以确定攻击者所在区域")]
	[UProperty]
	[UMeta(MDProp.ClampMin, "-180")]
	[DisplayName("左前分割角度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineForwardLeft")]
	public float AreaDivisionLineForwardLeft
	{
		get
		{
			CheckDestroyed();
			if (!AreaDivisionLineForwardLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineForwardLeft");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AreaDivisionLineForwardLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaDivisionLineForwardLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineForwardLeft");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AreaDivisionLineForwardLeft_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("右前分割角度")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[Tooltip("用以确定攻击者所在区域")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineForwardRight")]
	public float AreaDivisionLineForwardRight
	{
		get
		{
			CheckDestroyed();
			if (!AreaDivisionLineForwardRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineForwardRight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AreaDivisionLineForwardRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaDivisionLineForwardRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineForwardRight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AreaDivisionLineForwardRight_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[DisplayName("左后分割角度")]
	[EditAnywhere]
	[Tooltip("用以确定攻击者所在区域")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineBackwardLeft")]
	public float AreaDivisionLineBackwardLeft
	{
		get
		{
			CheckDestroyed();
			if (!AreaDivisionLineBackwardLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineBackwardLeft");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AreaDivisionLineBackwardLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaDivisionLineBackwardLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineBackwardLeft");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AreaDivisionLineBackwardLeft_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("右后分割角度")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[Tooltip("用以确定攻击者所在区域")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineBackwardRight")]
	public float AreaDivisionLineBackwardRight
	{
		get
		{
			CheckDestroyed();
			if (!AreaDivisionLineBackwardRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineBackwardRight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AreaDivisionLineBackwardRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaDivisionLineBackwardRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:AreaDivisionLineBackwardRight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AreaDivisionLineBackwardRight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("完美格挡信息")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:PerfectBlockInfoWarp")]
	public FBlockInfoWarp_Perfect PerfectBlockInfoWarp
	{
		get
		{
			CheckDestroyed();
			if (!PerfectBlockInfoWarp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:PerfectBlockInfoWarp");
				return default(FBlockInfoWarp_Perfect);
			}
			return FBlockInfoWarp_Perfect.FromNative(IntPtr.Add(base.Address, PerfectBlockInfoWarp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerfectBlockInfoWarp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:PerfectBlockInfoWarp");
			}
			else
			{
				FBlockInfoWarp_Perfect.ToNative(IntPtr.Add(base.Address, PerfectBlockInfoWarp_Offset), value);
			}
		}
	}

	[DisplayName("普通格挡信息")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:NormalBlockInfoWarp")]
	public FBlockInfoWarp_Normal NormalBlockInfoWarp
	{
		get
		{
			CheckDestroyed();
			if (!NormalBlockInfoWarp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:NormalBlockInfoWarp");
				return default(FBlockInfoWarp_Normal);
			}
			return FBlockInfoWarp_Normal.FromNative(IntPtr.Add(base.Address, NormalBlockInfoWarp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalBlockInfoWarp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:NormalBlockInfoWarp");
			}
			else
			{
				FBlockInfoWarp_Normal.ToNative(IntPtr.Add(base.Address, NormalBlockInfoWarp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("普通受击信息")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BeAttackedBlockInfoWarp")]
	public FBlockInfoWarp_BeAttacked BeAttackedBlockInfoWarp
	{
		get
		{
			CheckDestroyed();
			if (!BeAttackedBlockInfoWarp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BeAttackedBlockInfoWarp");
				return default(FBlockInfoWarp_BeAttacked);
			}
			return FBlockInfoWarp_BeAttacked.FromNative(IntPtr.Add(base.Address, BeAttackedBlockInfoWarp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeAttackedBlockInfoWarp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig:BeAttackedBlockInfoWarp");
			}
			else
			{
				FBlockInfoWarp_BeAttacked.ToNative(IntPtr.Add(base.Address, BeAttackedBlockInfoWarp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		BlockTiggerAngleLeft = -180f;
		BlockTiggerAngleRight = 180f;
		BlockCounterType = EBlockCounterType.AddCountAfterBlock;
		BlockAMSelectMode = EBlockAMSelectMode.SequenceSelectMode;
	}

	public void GetAnimationReferences(out List<UAnimSequenceBase> AnimMontages)
	{
		AnimMontages = new List<UAnimSequenceBase>();
		if (PerfectBlockInfoWarp.BreakBlockAM != null)
		{
			AnimMontages.Add(PerfectBlockInfoWarp.BreakBlockAM);
		}
		if (PerfectBlockInfoWarp.BreakBlock2WeakAM != null)
		{
			AnimMontages.Add(PerfectBlockInfoWarp.BreakBlock2WeakAM);
		}
		foreach (FBlockAMInfo blockAMInfo in PerfectBlockInfoWarp.BlockAMInfoList)
		{
			if (blockAMInfo.DirectBlockAMInfo.ForwardBlockAMInfo.AM2Block != null)
			{
				AnimMontages.Add(blockAMInfo.DirectBlockAMInfo.ForwardBlockAMInfo.AM2Block);
			}
			if (blockAMInfo.DirectBlockAMInfo.ForwardBlockAMInfo.BlockBounceAM != null)
			{
				AnimMontages.Add(blockAMInfo.DirectBlockAMInfo.ForwardBlockAMInfo.BlockBounceAM);
			}
			if (blockAMInfo.DirectBlockAMInfo.BackwardBlockAMInfo.AM2Block != null)
			{
				AnimMontages.Add(blockAMInfo.DirectBlockAMInfo.BackwardBlockAMInfo.AM2Block);
			}
			if (blockAMInfo.DirectBlockAMInfo.BackwardBlockAMInfo.BlockBounceAM != null)
			{
				AnimMontages.Add(blockAMInfo.DirectBlockAMInfo.BackwardBlockAMInfo.BlockBounceAM);
			}
			if (blockAMInfo.DirectBlockAMInfo.LeftSideBlockAMInfo.AM2Block != null)
			{
				AnimMontages.Add(blockAMInfo.DirectBlockAMInfo.LeftSideBlockAMInfo.AM2Block);
			}
			if (blockAMInfo.DirectBlockAMInfo.LeftSideBlockAMInfo.BlockBounceAM != null)
			{
				AnimMontages.Add(blockAMInfo.DirectBlockAMInfo.LeftSideBlockAMInfo.BlockBounceAM);
			}
			if (blockAMInfo.DirectBlockAMInfo.RightSideBlockAMInfo.AM2Block != null)
			{
				AnimMontages.Add(blockAMInfo.DirectBlockAMInfo.RightSideBlockAMInfo.AM2Block);
			}
			if (blockAMInfo.DirectBlockAMInfo.RightSideBlockAMInfo.BlockBounceAM != null)
			{
				AnimMontages.Add(blockAMInfo.DirectBlockAMInfo.RightSideBlockAMInfo.BlockBounceAM);
			}
		}
		if (NormalBlockInfoWarp.BreakBlockAM != null)
		{
			AnimMontages.Add(NormalBlockInfoWarp.BreakBlockAM);
		}
		if (NormalBlockInfoWarp.BreakBlock2WeakAM != null)
		{
			AnimMontages.Add(NormalBlockInfoWarp.BreakBlock2WeakAM);
		}
		foreach (FBlockInfoByHitLevel blockInfoByHitLevel in NormalBlockInfoWarp.BlockInfoByHitLevelList)
		{
			foreach (FBlockAMInfo blockAMInfo2 in blockInfoByHitLevel.BlockAMInfoList)
			{
				if (blockAMInfo2.DirectBlockAMInfo.ForwardBlockAMInfo.AM2Block != null)
				{
					AnimMontages.Add(blockAMInfo2.DirectBlockAMInfo.ForwardBlockAMInfo.AM2Block);
				}
				if (blockAMInfo2.DirectBlockAMInfo.ForwardBlockAMInfo.BlockBounceAM != null)
				{
					AnimMontages.Add(blockAMInfo2.DirectBlockAMInfo.ForwardBlockAMInfo.BlockBounceAM);
				}
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BlockInfoConfig");
		NativeReflection.GetPropertyRef(ref BlockCounterType_PropertyAddress, unrealStruct, "BlockCounterType");
		BlockCounterType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlockCounterType");
		BlockCounterType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlockCounterType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BlockAMSelectMode_PropertyAddress, unrealStruct, "BlockAMSelectMode");
		BlockAMSelectMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlockAMSelectMode");
		BlockAMSelectMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlockAMSelectMode", Classes.FEnumProperty);
		BlockTiggerAngleLeft_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlockTiggerAngleLeft");
		BlockTiggerAngleLeft_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlockTiggerAngleLeft", Classes.FFloatProperty);
		BlockTiggerAngleRight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlockTiggerAngleRight");
		BlockTiggerAngleRight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlockTiggerAngleRight", Classes.FFloatProperty);
		AreaDivisionLineForwardLeft_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AreaDivisionLineForwardLeft");
		AreaDivisionLineForwardLeft_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AreaDivisionLineForwardLeft", Classes.FFloatProperty);
		AreaDivisionLineForwardRight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AreaDivisionLineForwardRight");
		AreaDivisionLineForwardRight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AreaDivisionLineForwardRight", Classes.FFloatProperty);
		AreaDivisionLineBackwardLeft_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AreaDivisionLineBackwardLeft");
		AreaDivisionLineBackwardLeft_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AreaDivisionLineBackwardLeft", Classes.FFloatProperty);
		AreaDivisionLineBackwardRight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AreaDivisionLineBackwardRight");
		AreaDivisionLineBackwardRight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AreaDivisionLineBackwardRight", Classes.FFloatProperty);
		PerfectBlockInfoWarp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerfectBlockInfoWarp");
		PerfectBlockInfoWarp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerfectBlockInfoWarp", Classes.FStructProperty);
		NormalBlockInfoWarp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalBlockInfoWarp");
		NormalBlockInfoWarp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalBlockInfoWarp", Classes.FStructProperty);
		BeAttackedBlockInfoWarp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeAttackedBlockInfoWarp");
		BeAttackedBlockInfoWarp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeAttackedBlockInfoWarp", Classes.FStructProperty);
	}

	static BGWDataAsset_BlockInfoConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BlockInfoConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BlockInfoConfig));
	}
}
