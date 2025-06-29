using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS AI Skill Feature")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSAISkillFeature")]
internal class BANS_GSAISkillFeature : BANS_GSBase
{
	private static bool DurationTime_IsValid;

	private static int DurationTime_Offset;

	private static bool IsUseNotifyTime_IsValid;

	private static int IsUseNotifyTime_Offset;

	private static FFieldAddress IsUseNotifyTime_PropertyAddress;

	private static bool SectorParam_IsValid;

	private static int SectorParam_Offset;

	private static bool RectParam_IsValid;

	private static int RectParam_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UMeta(MDProp.EditCondition, "!IsUseNotifyTime")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAISkillFeature:DurationTime")]
	public float DurationTime
	{
		get
		{
			CheckDestroyed();
			if (!DurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAISkillFeature:DurationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DurationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAISkillFeature:DurationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DurationTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAISkillFeature:IsUseNotifyTime")]
	public bool IsUseNotifyTime
	{
		get
		{
			CheckDestroyed();
			if (!IsUseNotifyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAISkillFeature:IsUseNotifyTime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseNotifyTime_Offset), 0, IsUseNotifyTime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseNotifyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAISkillFeature:IsUseNotifyTime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseNotifyTime_Offset), 0, IsUseNotifyTime_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[DisplayName("扇形参数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAISkillFeature:SectorParam")]
	public FSectorParam SectorParam
	{
		get
		{
			CheckDestroyed();
			if (!SectorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAISkillFeature:SectorParam");
				return default(FSectorParam);
			}
			return FSectorParam.FromNative(IntPtr.Add(base.Address, SectorParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectorParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAISkillFeature:SectorParam");
			}
			else
			{
				FSectorParam.ToNative(IntPtr.Add(base.Address, SectorParam_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[DisplayName("矩形参数")]
	[USharpPath("/Script/b1-Managed.BANS_GSAISkillFeature:RectParam")]
	public FRectParam RectParam
	{
		get
		{
			CheckDestroyed();
			if (!RectParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAISkillFeature:RectParam");
				return default(FRectParam);
			}
			return FRectParam.FromNative(IntPtr.Add(base.Address, RectParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RectParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAISkillFeature:RectParam");
			}
			else
			{
				FRectParam.ToNative(IntPtr.Add(base.Address, RectParam_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.AnimNSType = EGsEnAnimNS.AISkillFeature;
		IsUseNotifyTime = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAISkillFeature:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		AFSkillArea aFSkillArea = UObject.NewObject<AFSkillArea>();
		aFSkillArea.ExecuteTime = bGUCharacterCS.World.GetTimeSeconds();
		aFSkillArea.TeamID = bGUCharacterCS.GetTeamIDInCS();
		aFSkillArea.RectParam = RectParam;
		aFSkillArea.RectParam.Yaw = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUCharacterCS).Yaw;
		aFSkillArea.SectorParam = SectorParam;
		aFSkillArea.SectorParam.BaseDir = bGUCharacterCS.GetActorForwardVector().GetSafeNormal();
		aFSkillArea.BaseLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
		if (IsUseNotifyTime)
		{
			aFSkillArea.DurationTime = TotalDuration;
		}
		else
		{
			aFSkillArea.DurationTime = DurationTime;
		}
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(bGUCharacterCS);
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(allActorsOfClass[i]);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnGenerateSkillFeature.Invoke(aFSkillArea);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAISkillFeature:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAISkillFeature bANS_GSAISkillFeature = GCHelper.Find<b1.BANS_GSAISkillFeature>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAISkillFeature.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAISkillFeature");
		DurationTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DurationTime");
		DurationTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DurationTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsUseNotifyTime_PropertyAddress, intPtr, "IsUseNotifyTime");
		IsUseNotifyTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUseNotifyTime");
		IsUseNotifyTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUseNotifyTime", Classes.FBoolProperty);
		SectorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SectorParam");
		SectorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SectorParam", Classes.FStructProperty);
		RectParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "RectParam");
		RectParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RectParam", Classes.FStructProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAISkillFeature:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAISkillFeature()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAISkillFeature)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAISkillFeature));
	}
}
