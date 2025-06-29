using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig")]
public class BGWDataAsset_UnitBeAttackedConfig : UBGWDataAsset, b1.IBGWDataAssetHasAnimationReferences
{
	private static bool NoteString1_IsValid;

	private static int NoteString1_Offset;

	private static bool NoteString2_IsValid;

	private static int NoteString2_Offset;

	private static bool NoteString3_IsValid;

	private static int NoteString3_Offset;

	private static bool NormalStiffAMPath_IsValid;

	private static int NormalStiffAMPath_Offset;

	private static bool UnitResName_IsValid;

	private static int UnitResName_Offset;

	private static bool NormalStiffInfoList_IsValid;

	private static int NormalStiffInfoList_Offset;

	private static FFieldAddress NormalStiffInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FNormalStiffInfo> NormalStiffInfoList_Marshaler;

	private static bool BeHitResFlyHit_IsValid;

	private static int BeHitResFlyHit_Offset;

	private static bool BeHitResFlyHitWithRM_IsValid;

	private static int BeHitResFlyHitWithRM_Offset;

	private static bool BeRoaredResForLight_IsValid;

	private static int BeRoaredResForLight_Offset;

	private static bool BeRoaredResForMedium_IsValid;

	private static int BeRoaredResForMedium_Offset;

	private static bool BeRoaredResForHeavy_IsValid;

	private static int BeRoaredResForHeavy_Offset;

	private static bool PointAttractionFrontAM_IsValid;

	private static int PointAttractionFrontAM_Offset;

	private static bool PointAttractionBackAM_IsValid;

	private static int PointAttractionBackAM_Offset;

	private static bool BeBlindStiffingAM_IsValid;

	private static int BeBlindStiffingAM_Offset;

	private static bool ImmobilizeBreakFXPath_IsValid;

	private static int ImmobilizeBreakFXPath_Offset;

	private static bool ImmobilizeBreakForwardAM_IsValid;

	private static int ImmobilizeBreakForwardAM_Offset;

	private static bool ImmobilizeBreakBackwardAM_IsValid;

	private static int ImmobilizeBreakBackwardAM_Offset;

	private static bool ImmobilizeBreakLeftsideAM_IsValid;

	private static int ImmobilizeBreakLeftsideAM_Offset;

	private static bool ImmobilizeBreakRightsideAM_IsValid;

	private static int ImmobilizeBreakRightsideAM_Offset;

	private static bool ForwardBeAttackedAdditiveAnim_IsValid;

	private static int ForwardBeAttackedAdditiveAnim_Offset;

	private static bool RightBeAttackedAdditiveAnim_IsValid;

	private static int RightBeAttackedAdditiveAnim_Offset;

	private static bool LeftBeAttackedAdditiveAnim_IsValid;

	private static int LeftBeAttackedAdditiveAnim_Offset;

	private static bool BackwardBeAttackedAdditiveAnim_IsValid;

	private static int BackwardBeAttackedAdditiveAnim_Offset;

	private static bool FrozenBreakAM_IsValid;

	private static int FrozenBreakAM_Offset;

	private static bool Enable_Rotate_AssistBreakFrozen_IsValid;

	private static int Enable_Rotate_AssistBreakFrozen_Offset;

	private static FFieldAddress Enable_Rotate_AssistBreakFrozen_PropertyAddress;

	private static bool AssistBreakFrozenAM_IsValid;

	private static int AssistBreakFrozenAM_Offset;

	private static bool HitLevelDivide_Jump_IsValid;

	private static int HitLevelDivide_Jump_Offset;

	private static bool ForwardBeAttackedAdditiveAnim_Jump_IsValid;

	private static int ForwardBeAttackedAdditiveAnim_Jump_Offset;

	private static bool RightBeAttackedAdditiveAnim_Jump_IsValid;

	private static int RightBeAttackedAdditiveAnim_Jump_Offset;

	private static bool LeftBeAttackedAdditiveAnim_Jump_IsValid;

	private static int LeftBeAttackedAdditiveAnim_Jump_Offset;

	private static bool BackwardBeAttackedAdditiveAnim_Jump_IsValid;

	private static int BackwardBeAttackedAdditiveAnim_Jump_Offset;

	private static bool BeAttackedAnim_Jump_IsValid;

	private static int BeAttackedAnim_Jump_Offset;

	private static bool BeAttackedAnim_Jump_CliffDistCheck_IsValid;

	private static int BeAttackedAnim_Jump_CliffDistCheck_Offset;

	private static bool BeAttackedAnim_PillarFormBreak_IsValid;

	private static int BeAttackedAnim_PillarFormBreak_Offset;

	private static bool NormalStiffAMList_IsValid;

	private static int NormalStiffAMList_Offset;

	private static FFieldAddress NormalStiffAMList_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> NormalStiffAMList_Marshaler;

	[DisplayName("动画规则里dep后的数字是单位当前受击ID后两位")]
	[BlueprintReadOnly]
	[UProperty]
	[Category("Note")]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString1")]
	public byte NoteString1
	{
		get
		{
			CheckDestroyed();
			if (!NoteString1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString1");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, NoteString1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoteString1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString1");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, NoteString1_Offset), value);
			}
		}
	}

	[DisplayName("单位资源名称和受击路径要和实际动画对应上")]
	[UProperty]
	[BlueprintReadOnly]
	[VisibleAnywhere]
	[Category("Note")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString2")]
	public byte NoteString2
	{
		get
		{
			CheckDestroyed();
			if (!NoteString2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString2");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, NoteString2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoteString2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString2");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, NoteString2_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[Category("Note")]
	[DisplayName("有什么受击问题，blog.EnableBeAttackedInfoLog 1 可解君愁")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString3")]
	public byte NoteString3
	{
		get
		{
			CheckDestroyed();
			if (!NoteString3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString3");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, NoteString3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoteString3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NoteString3");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, NoteString3_Offset), value);
			}
		}
	}

	[DisplayName("普通受击动作目录路径")]
	[Category("NormalStiff")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NormalStiffAMPath")]
	public string NormalStiffAMPath
	{
		get
		{
			CheckDestroyed();
			if (!NormalStiffAMPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NormalStiffAMPath");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, NormalStiffAMPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalStiffAMPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NormalStiffAMPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, NormalStiffAMPath_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("NormalStiff")]
	[DisplayName("单位资源名称")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:UnitResName")]
	public string UnitResName
	{
		get
		{
			CheckDestroyed();
			if (!UnitResName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:UnitResName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UnitResName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitResName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:UnitResName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UnitResName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("NormalStiff")]
	[DisplayName("普通受击信息(按挡位区分)")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NormalStiffInfoList")]
	public TArrayReadWrite<FNormalStiffInfo> NormalStiffInfoList
	{
		get
		{
			CheckDestroyed();
			if (!NormalStiffInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NormalStiffInfoList");
				return null;
			}
			if (NormalStiffInfoList_Marshaler == null)
			{
				NormalStiffInfoList_Marshaler = new TArrayReadWriteMarshaler<FNormalStiffInfo>(1, NormalStiffInfoList_PropertyAddress, CachedMarshalingDelegates<FNormalStiffInfo, FNormalStiffInfo>.FromNative, CachedMarshalingDelegates<FNormalStiffInfo, FNormalStiffInfo>.ToNative);
			}
			return NormalStiffInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, NormalStiffInfoList_Offset));
		}
	}

	[DisplayName("空中受击动画")]
	[Category("FlyHit")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeHitResFlyHit")]
	public UAnimMontage BeHitResFlyHit
	{
		get
		{
			CheckDestroyed();
			if (!BeHitResFlyHit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeHitResFlyHit");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeHitResFlyHit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeHitResFlyHit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeHitResFlyHit");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeHitResFlyHit_Offset), value);
			}
		}
	}

	[Category("FlyHit")]
	[BlueprintReadOnly]
	[DisplayName("空中受击动画(带RootMotion)")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeHitResFlyHitWithRM")]
	public UAnimMontage BeHitResFlyHitWithRM
	{
		get
		{
			CheckDestroyed();
			if (!BeHitResFlyHitWithRM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeHitResFlyHitWithRM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeHitResFlyHitWithRM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeHitResFlyHitWithRM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeHitResFlyHitWithRM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeHitResFlyHitWithRM_Offset), value);
			}
		}
	}

	[Category("Roared")]
	[DisplayName("轻吼叫硬直动画")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForLight")]
	public UAnimMontage BeRoaredResForLight
	{
		get
		{
			CheckDestroyed();
			if (!BeRoaredResForLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForLight");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeRoaredResForLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeRoaredResForLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForLight");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeRoaredResForLight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Roared")]
	[DisplayName("中吼叫硬直动画")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForMedium")]
	public UAnimMontage BeRoaredResForMedium
	{
		get
		{
			CheckDestroyed();
			if (!BeRoaredResForMedium_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForMedium");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeRoaredResForMedium_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeRoaredResForMedium_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForMedium");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeRoaredResForMedium_Offset), value);
			}
		}
	}

	[DisplayName("重吼叫硬直动画")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Roared")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForHeavy")]
	public UAnimMontage BeRoaredResForHeavy
	{
		get
		{
			CheckDestroyed();
			if (!BeRoaredResForHeavy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForHeavy");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeRoaredResForHeavy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeRoaredResForHeavy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeRoaredResForHeavy");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeRoaredResForHeavy_Offset), value);
			}
		}
	}

	[Category("PointAttr")]
	[DisplayName("正面点吸附动画")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:PointAttractionFrontAM")]
	public UAnimMontage PointAttractionFrontAM
	{
		get
		{
			CheckDestroyed();
			if (!PointAttractionFrontAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:PointAttractionFrontAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, PointAttractionFrontAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointAttractionFrontAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:PointAttractionFrontAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, PointAttractionFrontAM_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("PointAttr")]
	[DisplayName("背面点吸附动画")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:PointAttractionBackAM")]
	public UAnimMontage PointAttractionBackAM
	{
		get
		{
			CheckDestroyed();
			if (!PointAttractionBackAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:PointAttractionBackAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, PointAttractionBackAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointAttractionBackAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:PointAttractionBackAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, PointAttractionBackAM_Offset), value);
			}
		}
	}

	[DisplayName("致盲硬直动画")]
	[Category("Blind")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeBlindStiffingAM")]
	public UAnimMontage BeBlindStiffingAM
	{
		get
		{
			CheckDestroyed();
			if (!BeBlindStiffingAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeBlindStiffingAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeBlindStiffingAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeBlindStiffingAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeBlindStiffingAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeBlindStiffingAM_Offset), value);
			}
		}
	}

	[Tooltip("建议填入DBC的路径")]
	[DisplayName("定身击破特效路径")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[Category("Immobilize")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakFXPath")]
	public FName ImmobilizeBreakFXPath
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeBreakFXPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakFXPath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ImmobilizeBreakFXPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeBreakFXPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakFXPath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ImmobilizeBreakFXPath_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Category("Immobilize")]
	[DisplayName("前向定身击碎动画")]
	[Tooltip("是参考攻击者位于受击者的方位，")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakForwardAM")]
	public UAnimMontage ImmobilizeBreakForwardAM
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeBreakForwardAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakForwardAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, ImmobilizeBreakForwardAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeBreakForwardAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakForwardAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, ImmobilizeBreakForwardAM_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("是参考攻击者位于受击者的方位")]
	[DisplayName("后向定身击碎动画")]
	[Category("Immobilize")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakBackwardAM")]
	public UAnimMontage ImmobilizeBreakBackwardAM
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeBreakBackwardAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakBackwardAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, ImmobilizeBreakBackwardAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeBreakBackwardAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakBackwardAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, ImmobilizeBreakBackwardAM_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("是参考攻击者位于受击者的方位")]
	[BlueprintReadOnly]
	[DisplayName("左向定身击碎动画")]
	[Category("Immobilize")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakLeftsideAM")]
	public UAnimMontage ImmobilizeBreakLeftsideAM
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeBreakLeftsideAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakLeftsideAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, ImmobilizeBreakLeftsideAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeBreakLeftsideAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakLeftsideAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, ImmobilizeBreakLeftsideAM_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Immobilize")]
	[DisplayName("右向定身击碎动画")]
	[Tooltip("是参考攻击者位于受击者的方位")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakRightsideAM")]
	public UAnimMontage ImmobilizeBreakRightsideAM
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeBreakRightsideAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakRightsideAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, ImmobilizeBreakRightsideAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeBreakRightsideAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ImmobilizeBreakRightsideAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, ImmobilizeBreakRightsideAM_Offset), value);
			}
		}
	}

	[Category("BehitAdditive")]
	[BlueprintReadOnly]
	[DisplayName("前向受击叠加动画")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("这里的朝向是指攻击朝向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ForwardBeAttackedAdditiveAnim")]
	public UAnimMontage ForwardBeAttackedAdditiveAnim
	{
		get
		{
			CheckDestroyed();
			if (!ForwardBeAttackedAdditiveAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ForwardBeAttackedAdditiveAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, ForwardBeAttackedAdditiveAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardBeAttackedAdditiveAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ForwardBeAttackedAdditiveAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, ForwardBeAttackedAdditiveAnim_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("这里的朝向是指攻击朝向")]
	[DisplayName("右侧受击叠加动画")]
	[Category("BehitAdditive")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:RightBeAttackedAdditiveAnim")]
	public UAnimMontage RightBeAttackedAdditiveAnim
	{
		get
		{
			CheckDestroyed();
			if (!RightBeAttackedAdditiveAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:RightBeAttackedAdditiveAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, RightBeAttackedAdditiveAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightBeAttackedAdditiveAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:RightBeAttackedAdditiveAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, RightBeAttackedAdditiveAnim_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("BehitAdditive")]
	[DisplayName("左侧受击叠加动画")]
	[Tooltip("这里的朝向是指攻击朝向")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:LeftBeAttackedAdditiveAnim")]
	public UAnimMontage LeftBeAttackedAdditiveAnim
	{
		get
		{
			CheckDestroyed();
			if (!LeftBeAttackedAdditiveAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:LeftBeAttackedAdditiveAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, LeftBeAttackedAdditiveAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftBeAttackedAdditiveAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:LeftBeAttackedAdditiveAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, LeftBeAttackedAdditiveAnim_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("这里的朝向是指攻击朝向")]
	[DisplayName("后向受击叠加动画")]
	[Category("BehitAdditive")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BackwardBeAttackedAdditiveAnim")]
	public UAnimMontage BackwardBeAttackedAdditiveAnim
	{
		get
		{
			CheckDestroyed();
			if (!BackwardBeAttackedAdditiveAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BackwardBeAttackedAdditiveAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BackwardBeAttackedAdditiveAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackwardBeAttackedAdditiveAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BackwardBeAttackedAdditiveAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BackwardBeAttackedAdditiveAnim_Offset), value);
			}
		}
	}

	[DisplayName("冰冻破碎动画")]
	[UProperty]
	[Category("Frozen")]
	[BlueprintReadOnly]
	[Tooltip("受击者转向攻击者，播放的面向攻击者的受击动画")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:FrozenBreakAM")]
	public UAnimMontage FrozenBreakAM
	{
		get
		{
			CheckDestroyed();
			if (!FrozenBreakAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:FrozenBreakAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, FrozenBreakAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrozenBreakAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:FrozenBreakAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, FrozenBreakAM_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Frozen")]
	[DisplayName("援助解冻是否转向攻击者")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:Enable_Rotate_AssistBreakFrozen")]
	public bool Enable_Rotate_AssistBreakFrozen
	{
		get
		{
			CheckDestroyed();
			if (!Enable_Rotate_AssistBreakFrozen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:Enable_Rotate_AssistBreakFrozen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enable_Rotate_AssistBreakFrozen_Offset), 0, Enable_Rotate_AssistBreakFrozen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enable_Rotate_AssistBreakFrozen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:Enable_Rotate_AssistBreakFrozen");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enable_Rotate_AssistBreakFrozen_Offset), 0, Enable_Rotate_AssistBreakFrozen_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[Category("Frozen")]
	[DisplayName("援助解冻动画")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:AssistBreakFrozenAM")]
	public UAnimMontage AssistBreakFrozenAM
	{
		get
		{
			CheckDestroyed();
			if (!AssistBreakFrozenAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:AssistBreakFrozenAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AssistBreakFrozenAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AssistBreakFrozenAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:AssistBreakFrozenAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AssistBreakFrozenAM_Offset), value);
			}
		}
	}

	[Tooltip("小于等于该档：播Additive且不打断跳跃，大于该档：受击者转向攻击者，播放的面向攻击者的受击动画")]
	[DisplayName("跳跃中受击分档")]
	[Category("Jump")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:HitLevelDivide_Jump")]
	public int HitLevelDivide_Jump
	{
		get
		{
			CheckDestroyed();
			if (!HitLevelDivide_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:HitLevelDivide_Jump");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HitLevelDivide_Jump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitLevelDivide_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:HitLevelDivide_Jump");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HitLevelDivide_Jump_Offset), value);
			}
		}
	}

	[Tooltip("这里的朝向是指攻击朝向")]
	[DisplayName("跳跃中前向轻受击叠加动画")]
	[Category("Jump")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ForwardBeAttackedAdditiveAnim_Jump")]
	public UAnimMontage ForwardBeAttackedAdditiveAnim_Jump
	{
		get
		{
			CheckDestroyed();
			if (!ForwardBeAttackedAdditiveAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ForwardBeAttackedAdditiveAnim_Jump");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, ForwardBeAttackedAdditiveAnim_Jump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardBeAttackedAdditiveAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:ForwardBeAttackedAdditiveAnim_Jump");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, ForwardBeAttackedAdditiveAnim_Jump_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Jump")]
	[UProperty]
	[DisplayName("跳跃中右侧轻受击叠加动画")]
	[Tooltip("这里的朝向是指攻击朝向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:RightBeAttackedAdditiveAnim_Jump")]
	public UAnimMontage RightBeAttackedAdditiveAnim_Jump
	{
		get
		{
			CheckDestroyed();
			if (!RightBeAttackedAdditiveAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:RightBeAttackedAdditiveAnim_Jump");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, RightBeAttackedAdditiveAnim_Jump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightBeAttackedAdditiveAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:RightBeAttackedAdditiveAnim_Jump");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, RightBeAttackedAdditiveAnim_Jump_Offset), value);
			}
		}
	}

	[DisplayName("跳跃中左侧轻受击叠加动画")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Jump")]
	[Tooltip("这里的朝向是指攻击朝向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:LeftBeAttackedAdditiveAnim_Jump")]
	public UAnimMontage LeftBeAttackedAdditiveAnim_Jump
	{
		get
		{
			CheckDestroyed();
			if (!LeftBeAttackedAdditiveAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:LeftBeAttackedAdditiveAnim_Jump");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, LeftBeAttackedAdditiveAnim_Jump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftBeAttackedAdditiveAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:LeftBeAttackedAdditiveAnim_Jump");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, LeftBeAttackedAdditiveAnim_Jump_Offset), value);
			}
		}
	}

	[Category("Jump")]
	[Tooltip("这里的朝向是指攻击朝向")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[DisplayName("跳跃中后向轻受击叠加动画")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BackwardBeAttackedAdditiveAnim_Jump")]
	public UAnimMontage BackwardBeAttackedAdditiveAnim_Jump
	{
		get
		{
			CheckDestroyed();
			if (!BackwardBeAttackedAdditiveAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BackwardBeAttackedAdditiveAnim_Jump");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BackwardBeAttackedAdditiveAnim_Jump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackwardBeAttackedAdditiveAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BackwardBeAttackedAdditiveAnim_Jump");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BackwardBeAttackedAdditiveAnim_Jump_Offset), value);
			}
		}
	}

	[Tooltip("受击者转向攻击者，播放的面向攻击者的受击动画")]
	[Category("Jump")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[DisplayName("跳跃中重受击动画")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_Jump")]
	public UAnimMontage BeAttackedAnim_Jump
	{
		get
		{
			CheckDestroyed();
			if (!BeAttackedAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_Jump");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeAttackedAnim_Jump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeAttackedAnim_Jump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_Jump");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeAttackedAnim_Jump_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Jump")]
	[DisplayName("跳跃中重受击悬崖检测距离")]
	[Tooltip("跳跃中重受击悬崖保护距离")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_Jump_CliffDistCheck")]
	public float BeAttackedAnim_Jump_CliffDistCheck
	{
		get
		{
			CheckDestroyed();
			if (!BeAttackedAnim_Jump_CliffDistCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_Jump_CliffDistCheck");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeAttackedAnim_Jump_CliffDistCheck_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeAttackedAnim_Jump_CliffDistCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_Jump_CliffDistCheck");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeAttackedAnim_Jump_CliffDistCheck_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("PillarForm")]
	[DisplayName("撑棍特殊受击动画")]
	[Tooltip("SkillDamageExpand表里配置可以打爆撑棍时触发")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_PillarFormBreak")]
	public UAnimMontage BeAttackedAnim_PillarFormBreak
	{
		get
		{
			CheckDestroyed();
			if (!BeAttackedAnim_PillarFormBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_PillarFormBreak");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeAttackedAnim_PillarFormBreak_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeAttackedAnim_PillarFormBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:BeAttackedAnim_PillarFormBreak");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeAttackedAnim_PillarFormBreak_Offset), value);
			}
		}
	}

	[Category("NormalStiffAMConfig")]
	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[DisplayName("普通受击动作列表")]
	[Tooltip("预加载使用")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NormalStiffAMList")]
	public TArrayReadWrite<UAnimMontage> NormalStiffAMList
	{
		get
		{
			CheckDestroyed();
			if (!NormalStiffAMList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig:NormalStiffAMList");
				return null;
			}
			if (NormalStiffAMList_Marshaler == null)
			{
				NormalStiffAMList_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, NormalStiffAMList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return NormalStiffAMList_Marshaler.FromNative(IntPtr.Add(base.Address, NormalStiffAMList_Offset));
		}
	}

	public void GetAnimationReferences(out List<UAnimSequenceBase> AnimMontages)
	{
		AnimMontages = new List<UAnimSequenceBase>();
		foreach (UAnimMontage normalStiffAM in NormalStiffAMList)
		{
			if (normalStiffAM != null)
			{
				AnimMontages.Add(normalStiffAM);
			}
		}
		if (BeHitResFlyHit != null)
		{
			AnimMontages.Add(BeHitResFlyHit);
		}
		if (BeHitResFlyHitWithRM != null)
		{
			AnimMontages.Add(BeHitResFlyHitWithRM);
		}
		if (BeRoaredResForLight != null)
		{
			AnimMontages.Add(BeRoaredResForLight);
		}
		if (BeRoaredResForMedium != null)
		{
			AnimMontages.Add(BeRoaredResForMedium);
		}
		if (BeRoaredResForHeavy != null)
		{
			AnimMontages.Add(BeRoaredResForHeavy);
		}
		if (PointAttractionFrontAM != null)
		{
			AnimMontages.Add(PointAttractionFrontAM);
		}
		if (PointAttractionBackAM != null)
		{
			AnimMontages.Add(PointAttractionBackAM);
		}
		if (BeBlindStiffingAM != null)
		{
			AnimMontages.Add(BeBlindStiffingAM);
		}
		if (ImmobilizeBreakForwardAM != null)
		{
			AnimMontages.Add(ImmobilizeBreakForwardAM);
		}
		if (ImmobilizeBreakBackwardAM != null)
		{
			AnimMontages.Add(ImmobilizeBreakBackwardAM);
		}
		if (ImmobilizeBreakLeftsideAM != null)
		{
			AnimMontages.Add(ImmobilizeBreakLeftsideAM);
		}
		if (ImmobilizeBreakRightsideAM != null)
		{
			AnimMontages.Add(ImmobilizeBreakRightsideAM);
		}
		if (ForwardBeAttackedAdditiveAnim != null)
		{
			AnimMontages.Add(ForwardBeAttackedAdditiveAnim);
		}
		if (RightBeAttackedAdditiveAnim != null)
		{
			AnimMontages.Add(RightBeAttackedAdditiveAnim);
		}
		if (LeftBeAttackedAdditiveAnim != null)
		{
			AnimMontages.Add(LeftBeAttackedAdditiveAnim);
		}
		if (BackwardBeAttackedAdditiveAnim != null)
		{
			AnimMontages.Add(BackwardBeAttackedAdditiveAnim);
		}
		if (FrozenBreakAM != null)
		{
			AnimMontages.Add(FrozenBreakAM);
		}
		if (AssistBreakFrozenAM != null)
		{
			AnimMontages.Add(AssistBreakFrozenAM);
		}
		if (ForwardBeAttackedAdditiveAnim_Jump != null)
		{
			AnimMontages.Add(ForwardBeAttackedAdditiveAnim_Jump);
		}
		if (RightBeAttackedAdditiveAnim_Jump != null)
		{
			AnimMontages.Add(RightBeAttackedAdditiveAnim_Jump);
		}
		if (LeftBeAttackedAdditiveAnim_Jump != null)
		{
			AnimMontages.Add(LeftBeAttackedAdditiveAnim_Jump);
		}
		if (BackwardBeAttackedAdditiveAnim_Jump != null)
		{
			AnimMontages.Add(BackwardBeAttackedAdditiveAnim_Jump);
		}
		if (BeAttackedAnim_PillarFormBreak != null)
		{
			AnimMontages.Add(BeAttackedAnim_PillarFormBreak);
		}
		if (BeAttackedAnim_Jump != null)
		{
			AnimMontages.Add(BeAttackedAnim_Jump);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_UnitBeAttackedConfig");
		NoteString1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoteString1");
		NoteString1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoteString1", Classes.FByteProperty);
		NoteString2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoteString2");
		NoteString2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoteString2", Classes.FByteProperty);
		NoteString3_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NoteString3");
		NoteString3_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NoteString3", Classes.FByteProperty);
		NormalStiffAMPath_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalStiffAMPath");
		NormalStiffAMPath_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalStiffAMPath", Classes.FStrProperty);
		UnitResName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitResName");
		UnitResName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitResName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref NormalStiffInfoList_PropertyAddress, unrealStruct, "NormalStiffInfoList");
		NormalStiffInfoList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalStiffInfoList");
		NormalStiffInfoList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalStiffInfoList", Classes.FArrayProperty);
		BeHitResFlyHit_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeHitResFlyHit");
		BeHitResFlyHit_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeHitResFlyHit", Classes.FObjectProperty);
		BeHitResFlyHitWithRM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeHitResFlyHitWithRM");
		BeHitResFlyHitWithRM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeHitResFlyHitWithRM", Classes.FObjectProperty);
		BeRoaredResForLight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeRoaredResForLight");
		BeRoaredResForLight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeRoaredResForLight", Classes.FObjectProperty);
		BeRoaredResForMedium_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeRoaredResForMedium");
		BeRoaredResForMedium_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeRoaredResForMedium", Classes.FObjectProperty);
		BeRoaredResForHeavy_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeRoaredResForHeavy");
		BeRoaredResForHeavy_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeRoaredResForHeavy", Classes.FObjectProperty);
		PointAttractionFrontAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointAttractionFrontAM");
		PointAttractionFrontAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointAttractionFrontAM", Classes.FObjectProperty);
		PointAttractionBackAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointAttractionBackAM");
		PointAttractionBackAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointAttractionBackAM", Classes.FObjectProperty);
		BeBlindStiffingAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeBlindStiffingAM");
		BeBlindStiffingAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeBlindStiffingAM", Classes.FObjectProperty);
		ImmobilizeBreakFXPath_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeBreakFXPath");
		ImmobilizeBreakFXPath_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeBreakFXPath", Classes.FNameProperty);
		ImmobilizeBreakForwardAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeBreakForwardAM");
		ImmobilizeBreakForwardAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeBreakForwardAM", Classes.FObjectProperty);
		ImmobilizeBreakBackwardAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeBreakBackwardAM");
		ImmobilizeBreakBackwardAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeBreakBackwardAM", Classes.FObjectProperty);
		ImmobilizeBreakLeftsideAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeBreakLeftsideAM");
		ImmobilizeBreakLeftsideAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeBreakLeftsideAM", Classes.FObjectProperty);
		ImmobilizeBreakRightsideAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeBreakRightsideAM");
		ImmobilizeBreakRightsideAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeBreakRightsideAM", Classes.FObjectProperty);
		ForwardBeAttackedAdditiveAnim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForwardBeAttackedAdditiveAnim");
		ForwardBeAttackedAdditiveAnim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForwardBeAttackedAdditiveAnim", Classes.FObjectProperty);
		RightBeAttackedAdditiveAnim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RightBeAttackedAdditiveAnim");
		RightBeAttackedAdditiveAnim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RightBeAttackedAdditiveAnim", Classes.FObjectProperty);
		LeftBeAttackedAdditiveAnim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeftBeAttackedAdditiveAnim");
		LeftBeAttackedAdditiveAnim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeftBeAttackedAdditiveAnim", Classes.FObjectProperty);
		BackwardBeAttackedAdditiveAnim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BackwardBeAttackedAdditiveAnim");
		BackwardBeAttackedAdditiveAnim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BackwardBeAttackedAdditiveAnim", Classes.FObjectProperty);
		FrozenBreakAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FrozenBreakAM");
		FrozenBreakAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FrozenBreakAM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Enable_Rotate_AssistBreakFrozen_PropertyAddress, unrealStruct, "Enable_Rotate_AssistBreakFrozen");
		Enable_Rotate_AssistBreakFrozen_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Enable_Rotate_AssistBreakFrozen");
		Enable_Rotate_AssistBreakFrozen_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Enable_Rotate_AssistBreakFrozen", Classes.FBoolProperty);
		AssistBreakFrozenAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AssistBreakFrozenAM");
		AssistBreakFrozenAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AssistBreakFrozenAM", Classes.FObjectProperty);
		HitLevelDivide_Jump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitLevelDivide_Jump");
		HitLevelDivide_Jump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitLevelDivide_Jump", Classes.FIntProperty);
		ForwardBeAttackedAdditiveAnim_Jump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForwardBeAttackedAdditiveAnim_Jump");
		ForwardBeAttackedAdditiveAnim_Jump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForwardBeAttackedAdditiveAnim_Jump", Classes.FObjectProperty);
		RightBeAttackedAdditiveAnim_Jump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RightBeAttackedAdditiveAnim_Jump");
		RightBeAttackedAdditiveAnim_Jump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RightBeAttackedAdditiveAnim_Jump", Classes.FObjectProperty);
		LeftBeAttackedAdditiveAnim_Jump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeftBeAttackedAdditiveAnim_Jump");
		LeftBeAttackedAdditiveAnim_Jump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeftBeAttackedAdditiveAnim_Jump", Classes.FObjectProperty);
		BackwardBeAttackedAdditiveAnim_Jump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BackwardBeAttackedAdditiveAnim_Jump");
		BackwardBeAttackedAdditiveAnim_Jump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BackwardBeAttackedAdditiveAnim_Jump", Classes.FObjectProperty);
		BeAttackedAnim_Jump_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeAttackedAnim_Jump");
		BeAttackedAnim_Jump_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeAttackedAnim_Jump", Classes.FObjectProperty);
		BeAttackedAnim_Jump_CliffDistCheck_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeAttackedAnim_Jump_CliffDistCheck");
		BeAttackedAnim_Jump_CliffDistCheck_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeAttackedAnim_Jump_CliffDistCheck", Classes.FFloatProperty);
		BeAttackedAnim_PillarFormBreak_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeAttackedAnim_PillarFormBreak");
		BeAttackedAnim_PillarFormBreak_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeAttackedAnim_PillarFormBreak", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref NormalStiffAMList_PropertyAddress, unrealStruct, "NormalStiffAMList");
		NormalStiffAMList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NormalStiffAMList");
		NormalStiffAMList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NormalStiffAMList", Classes.FArrayProperty);
	}

	static BGWDataAsset_UnitBeAttackedConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_UnitBeAttackedConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_UnitBeAttackedConfig));
	}
}
