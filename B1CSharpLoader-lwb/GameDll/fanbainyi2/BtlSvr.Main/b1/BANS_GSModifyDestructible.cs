using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Modify Destructible")]
[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible")]
internal class BANS_GSModifyDestructible : BANS_GSBase
{
	private static bool ModifyType_IsValid;

	private static int ModifyType_Offset;

	private static FFieldAddress ModifyType_PropertyAddress;

	private static bool ImpulseType_IsValid;

	private static int ImpulseType_Offset;

	private static FFieldAddress ImpulseType_PropertyAddress;

	private static bool ImpulseStrengthLevel_IsValid;

	private static int ImpulseStrengthLevel_Offset;

	private static FFieldAddress ImpulseStrengthLevel_PropertyAddress;

	private static bool ImpulseStrength_IsValid;

	private static int ImpulseStrength_Offset;

	private static bool MassLevel_IsValid;

	private static int MassLevel_Offset;

	private static FFieldAddress MassLevel_PropertyAddress;

	private static bool StrengthLevel_IsValid;

	private static int StrengthLevel_Offset;

	private static FFieldAddress StrengthLevel_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:ModifyType")]
	public EGSDestructibleModifyType ModifyType
	{
		get
		{
			CheckDestroyed();
			if (!ModifyType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:ModifyType");
				return EGSDestructibleModifyType.Break;
			}
			return EnumMarshaler<EGSDestructibleModifyType>.FromNative(IntPtr.Add(base.Address, ModifyType_Offset), 0, ModifyType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ModifyType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:ModifyType");
			}
			else
			{
				EnumMarshaler<EGSDestructibleModifyType>.ToNative(IntPtr.Add(base.Address, ModifyType_Offset), 0, ModifyType_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "ModifyType == EGSDestructibleModifyType::Break")]
	[Tooltip("破碎冲量配置类型")]
	[DisplayName("破碎冲量配置类型")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseType")]
	public EGSHitDestructibleImpulseType ImpulseType
	{
		get
		{
			CheckDestroyed();
			if (!ImpulseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseType");
				return EGSHitDestructibleImpulseType.Default;
			}
			return EnumMarshaler<EGSHitDestructibleImpulseType>.FromNative(IntPtr.Add(base.Address, ImpulseType_Offset), 0, ImpulseType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImpulseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseType");
			}
			else
			{
				EnumMarshaler<EGSHitDestructibleImpulseType>.ToNative(IntPtr.Add(base.Address, ImpulseType_Offset), 0, ImpulseType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("破碎力度级别冲量")]
	[UMeta(MDProp.EditCondition, "ModifyType == EGSDestructibleModifyType::Break && ImpulseType == EGSHitDestructibleImpulseType::StrengthLevel")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("按破碎力度级别设置冲量")]
	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseStrengthLevel")]
	public EGSHitDestructibleStrengthLevel ImpulseStrengthLevel
	{
		get
		{
			CheckDestroyed();
			if (!ImpulseStrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseStrengthLevel");
				return EGSHitDestructibleStrengthLevel.None;
			}
			return EnumMarshaler<EGSHitDestructibleStrengthLevel>.FromNative(IntPtr.Add(base.Address, ImpulseStrengthLevel_Offset), 0, ImpulseStrengthLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImpulseStrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseStrengthLevel");
			}
			else
			{
				EnumMarshaler<EGSHitDestructibleStrengthLevel>.ToNative(IntPtr.Add(base.Address, ImpulseStrengthLevel_Offset), 0, ImpulseStrengthLevel_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("手动输入破碎力度冲量大小")]
	[Category("Anim Notify")]
	[UMeta(MDProp.EditCondition, "ModifyType == EGSDestructibleModifyType::Break && ImpulseType == EGSHitDestructibleImpulseType::Manual")]
	[UProperty]
	[DisplayName("破碎力度冲量")]
	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseStrength")]
	public float ImpulseStrength
	{
		get
		{
			CheckDestroyed();
			if (!ImpulseStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ImpulseStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImpulseStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:ImpulseStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ImpulseStrength_Offset), value);
			}
		}
	}

	[Tooltip("面对角色移动碰撞时，破碎物的强度")]
	[UMeta(MDProp.EditCondition, "ModifyType == EGSDestructibleModifyType::Modify")]
	[DisplayName("破碎物移动破碎强度")]
	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:MassLevel")]
	public DestructibleMassLevel MassLevel
	{
		get
		{
			CheckDestroyed();
			if (!MassLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:MassLevel");
				return DestructibleMassLevel.Basic;
			}
			return EnumMarshaler<DestructibleMassLevel>.FromNative(IntPtr.Add(base.Address, MassLevel_Offset), 0, MassLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MassLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:MassLevel");
			}
			else
			{
				EnumMarshaler<DestructibleMassLevel>.ToNative(IntPtr.Add(base.Address, MassLevel_Offset), 0, MassLevel_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("破碎物攻击破碎强度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("破碎物面对受击时的强度")]
	[UMeta(MDProp.EditCondition, "ModifyType == EGSDestructibleModifyType::Modify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:StrengthLevel")]
	public DestructibleStrengthLevel StrengthLevel
	{
		get
		{
			CheckDestroyed();
			if (!StrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:StrengthLevel");
				return DestructibleStrengthLevel.LightHitDestroy;
			}
			return EnumMarshaler<DestructibleStrengthLevel>.FromNative(IntPtr.Add(base.Address, StrengthLevel_Offset), 0, StrengthLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSModifyDestructible:StrengthLevel");
			}
			else
			{
				EnumMarshaler<DestructibleStrengthLevel>.ToNative(IntPtr.Add(base.Address, StrengthLevel_Offset), 0, StrengthLevel_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.CanBePlacedInASCS = true;
		base.CanUseQueuedType = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		List<UActorComponent> componentsByClass = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<UChildActorComponent>());
		List<BGUFXActorBase> list = new List<BGUFXActorBase>();
		foreach (UActorComponent item in componentsByClass)
		{
			UChildActorComponent uChildActorComponent = item as UChildActorComponent;
			if (!(uChildActorComponent == null))
			{
				BGUFXActorBase bGUFXActorBase = uChildActorComponent.ChildActor as BGUFXActorBase;
				if (!(bGUFXActorBase == null) && bGUFXActorBase.ActorHasTag(B1GlobalFNames.Destructible))
				{
					list.Add(bGUFXActorBase);
				}
			}
		}
		switch (ModifyType)
		{
		case EGSDestructibleModifyType.Break:
		{
			foreach (BGUFXActorBase item2 in list)
			{
				switch (ImpulseType)
				{
				case EGSHitDestructibleImpulseType.Manual:
					BGUFunctionLibraryCS.BGUDestroyDestructible(item2, item2.GetActorLocation(), -item2.GetActorForwardVector(), ImpulseStrength);
					break;
				case EGSHitDestructibleImpulseType.StrengthLevel:
					BGUFunctionLibraryCS.BGUDestroyDestructible(item2, item2.GetActorLocation(), -item2.GetActorForwardVector(), BGUFunctionLibraryCS.GetDestructibleImpulse(item2, ImpulseStrengthLevel));
					break;
				default:
					BGUFunctionLibraryCS.BGUDestroyDestructible(item2, item2.GetActorLocation(), -item2.GetActorForwardVector());
					break;
				}
			}
			break;
		}
		case EGSDestructibleModifyType.Modify:
		{
			foreach (BGUFXActorBase item3 in list)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(item3);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_ModifyDestructible.Invoke(MassLevel, StrengthLevel);
				}
			}
			break;
		}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSModifyDestructible bANS_GSModifyDestructible = GCHelper.Find<b1.BANS_GSModifyDestructible>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSModifyDestructible.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSModifyDestructible bANS_GSModifyDestructible = GCHelper.Find<b1.BANS_GSModifyDestructible>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSModifyDestructible.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSModifyDestructible bANS_GSModifyDestructible = GCHelper.Find<b1.BANS_GSModifyDestructible>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSModifyDestructible.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSModifyDestructible");
		NativeReflection.GetPropertyRef(ref ModifyType_PropertyAddress, intPtr, "ModifyType");
		ModifyType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ModifyType");
		ModifyType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ModifyType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ImpulseType_PropertyAddress, intPtr, "ImpulseType");
		ImpulseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImpulseType");
		ImpulseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImpulseType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ImpulseStrengthLevel_PropertyAddress, intPtr, "ImpulseStrengthLevel");
		ImpulseStrengthLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImpulseStrengthLevel");
		ImpulseStrengthLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImpulseStrengthLevel", Classes.FEnumProperty);
		ImpulseStrength_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImpulseStrength");
		ImpulseStrength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImpulseStrength", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MassLevel_PropertyAddress, intPtr, "MassLevel");
		MassLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "MassLevel");
		MassLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MassLevel", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref StrengthLevel_PropertyAddress, intPtr, "StrengthLevel");
		StrengthLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "StrengthLevel");
		StrengthLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StrengthLevel", Classes.FEnumProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSModifyDestructible:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSModifyDestructible()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSModifyDestructible)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSModifyDestructible));
	}
}
