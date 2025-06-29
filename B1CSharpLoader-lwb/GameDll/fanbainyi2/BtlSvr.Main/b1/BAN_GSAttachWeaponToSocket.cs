using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Attach Weapon To Socket")]
[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket")]
internal class BAN_GSAttachWeaponToSocket : BAN_GSBase
{
	private static bool ActorTag_IsValid;

	private static int ActorTag_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool WeaponIndex_IsValid;

	private static int WeaponIndex_Offset;

	private static bool AttachmentLocationRule_IsValid;

	private static int AttachmentLocationRule_Offset;

	private static FFieldAddress AttachmentLocationRule_PropertyAddress;

	private static bool AttachmentRotationRule_IsValid;

	private static int AttachmentRotationRule_Offset;

	private static FFieldAddress AttachmentRotationRule_PropertyAddress;

	private static bool AttachmentScaleRule_IsValid;

	private static int AttachmentScaleRule_Offset;

	private static FFieldAddress AttachmentScaleRule_PropertyAddress;

	private static bool WeaponNeedPlayAnim_IsValid;

	private static int WeaponNeedPlayAnim_Offset;

	private static FFieldAddress WeaponNeedPlayAnim_PropertyAddress;

	private static bool AnimAsset_IsValid;

	private static int AnimAsset_Offset;

	private static bool WeaponScaleUseCurve_IsValid;

	private static int WeaponScaleUseCurve_Offset;

	private static FFieldAddress WeaponScaleUseCurve_PropertyAddress;

	private static bool WeaponScaleCurve_IsValid;

	private static int WeaponScaleCurve_Offset;

	private static bool WeaponNeedDoCallBP_IsValid;

	private static int WeaponNeedDoCallBP_Offset;

	private static FFieldAddress WeaponNeedDoCallBP_PropertyAddress;

	private static bool WeaponCallBPFloatParam_IsValid;

	private static int WeaponCallBPFloatParam_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:ActorTag")]
	public FName ActorTag
	{
		get
		{
			CheckDestroyed();
			if (!ActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:ActorTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:ActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ActorTag_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponIndex")]
	public int WeaponIndex
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WeaponIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WeaponIndex_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentLocationRule")]
	public EAttachmentRule AttachmentLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentLocationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentLocationRule_Offset), 0, AttachmentLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentLocationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentLocationRule_Offset), 0, AttachmentLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentRotationRule")]
	public EAttachmentRule AttachmentRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentRotationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentRotationRule_Offset), 0, AttachmentRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentRotationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentRotationRule_Offset), 0, AttachmentRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentScaleRule")]
	public EAttachmentRule AttachmentScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!AttachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentScaleRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachmentScaleRule_Offset), 0, AttachmentScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachmentScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AttachmentScaleRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachmentScaleRule_Offset), 0, AttachmentScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponNeedPlayAnim")]
	public bool WeaponNeedPlayAnim
	{
		get
		{
			CheckDestroyed();
			if (!WeaponNeedPlayAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponNeedPlayAnim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WeaponNeedPlayAnim_Offset), 0, WeaponNeedPlayAnim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WeaponNeedPlayAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponNeedPlayAnim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WeaponNeedPlayAnim_Offset), 0, WeaponNeedPlayAnim_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "WeaponNeedPlayAnim")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AnimAsset")]
	public UAnimationAsset AnimAsset
	{
		get
		{
			CheckDestroyed();
			if (!AnimAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AnimAsset");
				return null;
			}
			return UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(base.Address, AnimAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:AnimAsset");
			}
			else
			{
				UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(base.Address, AnimAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!WeaponNeedPlayAnim")]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponScaleUseCurve")]
	public bool WeaponScaleUseCurve
	{
		get
		{
			CheckDestroyed();
			if (!WeaponScaleUseCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponScaleUseCurve");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WeaponScaleUseCurve_Offset), 0, WeaponScaleUseCurve_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WeaponScaleUseCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponScaleUseCurve");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WeaponScaleUseCurve_Offset), 0, WeaponScaleUseCurve_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!WeaponNeedPlayAnim && WeaponScaleUseCurve")]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponScaleCurve")]
	public UCurveVector WeaponScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!WeaponScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponScaleCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, WeaponScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponScaleCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, WeaponScaleCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponNeedDoCallBP")]
	public bool WeaponNeedDoCallBP
	{
		get
		{
			CheckDestroyed();
			if (!WeaponNeedDoCallBP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponNeedDoCallBP");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WeaponNeedDoCallBP_Offset), 0, WeaponNeedDoCallBP_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WeaponNeedDoCallBP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponNeedDoCallBP");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WeaponNeedDoCallBP_Offset), 0, WeaponNeedDoCallBP_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "WeaponNeedDoCallBP")]
	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponCallBPFloatParam")]
	public float WeaponCallBPFloatParam
	{
		get
		{
			CheckDestroyed();
			if (!WeaponCallBPFloatParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponCallBPFloatParam");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WeaponCallBPFloatParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponCallBPFloatParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:WeaponCallBPFloatParam");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WeaponCallBPFloatParam_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		AttachmentLocationRule = EAttachmentRule.SnapToTarget;
		AttachmentRotationRule = EAttachmentRule.SnapToTarget;
		AttachmentScaleRule = EAttachmentRule.KeepRelative;
		WeaponNeedDoCallBP = false;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (!(aActor != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		List<AActor> OutActors = new List<AActor>();
		UGameplayStatics.GetAllActorsOfClassWithTag(bGUCharacterCS, UClass.GetClass<AActor>(), ActorTag, out OutActors);
		if (OutActors.Count <= 0)
		{
			return;
		}
		foreach (AActor item in OutActors)
		{
			BGUWeaponBase bGUWeaponBase = item as BGUWeaponBase;
			if (!(bGUWeaponBase != null))
			{
				continue;
			}
			BGUFunctionLibraryCS.BGUAttachWeaponBySocketName(bGUCharacterCS, bGUWeaponBase, SocketName, WeaponIndex, AttachmentLocationRule, AttachmentRotationRule, AttachmentScaleRule);
			if (WeaponNeedPlayAnim)
			{
				if (AnimAsset != null)
				{
					BUS_EventCollectionCS.Get(bGUWeaponBase)?.Evt_PlayOrStopAnimation.Invoke(IsPlay: true, IsLoop: false, AnimAsset);
				}
			}
			else if (WeaponScaleUseCurve)
			{
				BUS_EventCollectionCS.Get(bGUWeaponBase).Evt_ScaleWeaponByCurve.Invoke(WeaponScaleCurve);
			}
			if (WeaponNeedDoCallBP)
			{
				bGUWeaponBase.WeaponBPFunc(WeaponCallBPFloatParam);
			}
			break;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSAttachWeaponToSocket bAN_GSAttachWeaponToSocket = GCHelper.Find<b1.BAN_GSAttachWeaponToSocket>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSAttachWeaponToSocket.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSAttachWeaponToSocket bAN_GSAttachWeaponToSocket = GCHelper.Find<b1.BAN_GSAttachWeaponToSocket>(obj);
		bool value = bAN_GSAttachWeaponToSocket.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSAttachWeaponToSocket");
		ActorTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorTag");
		ActorTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorTag", Classes.FNameProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		WeaponIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndex");
		WeaponIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AttachmentLocationRule_PropertyAddress, intPtr, "AttachmentLocationRule");
		AttachmentLocationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachmentLocationRule");
		AttachmentLocationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachmentLocationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttachmentRotationRule_PropertyAddress, intPtr, "AttachmentRotationRule");
		AttachmentRotationRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachmentRotationRule");
		AttachmentRotationRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachmentRotationRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttachmentScaleRule_PropertyAddress, intPtr, "AttachmentScaleRule");
		AttachmentScaleRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachmentScaleRule");
		AttachmentScaleRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachmentScaleRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref WeaponNeedPlayAnim_PropertyAddress, intPtr, "WeaponNeedPlayAnim");
		WeaponNeedPlayAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponNeedPlayAnim");
		WeaponNeedPlayAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponNeedPlayAnim", Classes.FBoolProperty);
		AnimAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimAsset");
		AnimAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref WeaponScaleUseCurve_PropertyAddress, intPtr, "WeaponScaleUseCurve");
		WeaponScaleUseCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponScaleUseCurve");
		WeaponScaleUseCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponScaleUseCurve", Classes.FBoolProperty);
		WeaponScaleCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponScaleCurve");
		WeaponScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponScaleCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref WeaponNeedDoCallBP_PropertyAddress, intPtr, "WeaponNeedDoCallBP");
		WeaponNeedDoCallBP_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponNeedDoCallBP");
		WeaponNeedDoCallBP_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponNeedDoCallBP", Classes.FBoolProperty);
		WeaponCallBPFloatParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponCallBPFloatParam");
		WeaponCallBPFloatParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponCallBPFloatParam", Classes.FFloatProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSAttachWeaponToSocket:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSAttachWeaponToSocket()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSAttachWeaponToSocket)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSAttachWeaponToSocket));
	}
}
