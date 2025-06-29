using System;
using b1.Plugins.Calliope;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("RemoveBuffOnUnit")]
[UClass]
[USharpPath("/Script/b1-Managed.BSN_RemoveBuffOnUnit")]
public class BSN_RemoveBuffOnUnit : UMovieSceneCalliopeNotifySection
{
	private static bool bTakePlayerAsUnit_IsValid;

	private static int bTakePlayerAsUnit_Offset;

	private static FFieldAddress bTakePlayerAsUnit_PropertyAddress;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool bTriggerRemoveEffect_IsValid;

	private static int bTriggerRemoveEffect_Offset;

	private static FFieldAddress bTriggerRemoveEffect_PropertyAddress;

	private static bool OnNotify_IsValid;

	private static IntPtr OnNotify_FunctionAddress;

	private static int OnNotify_ParamsSize;

	private static bool OnNotify_InPlayer_IsValid;

	private static int OnNotify_InPlayer_Offset;

	private static bool OnNotify_InStatus_IsValid;

	private static int OnNotify_InStatus_Offset;

	private static bool OnNotify_bInBackwards_IsValid;

	private static int OnNotify_bInBackwards_Offset;

	private static FFieldAddress OnNotify_bInBackwards_PropertyAddress;

	private static bool OnPreviewNotify_IsValid;

	private static IntPtr OnPreviewNotify_FunctionAddress;

	private static int OnPreviewNotify_ParamsSize;

	private static bool OnPreviewNotify_InPlaybackContext_IsValid;

	private static int OnPreviewNotify_InPlaybackContext_Offset;

	private static bool OnPreviewNotify_InStatus_IsValid;

	private static int OnPreviewNotify_InStatus_Offset;

	private static bool OnPreviewNotify_bInBackwards_IsValid;

	private static int OnPreviewNotify_bInBackwards_Offset;

	private static FFieldAddress OnPreviewNotify_bInBackwards_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("RemoveBuffOnUnit")]
	[DisplayName("主角作为Unit")]
	[USharpPath("/Script/b1-Managed.BSN_RemoveBuffOnUnit:bTakePlayerAsUnit")]
	public bool bTakePlayerAsUnit
	{
		get
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:bTakePlayerAsUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:bTakePlayerAsUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address, value);
			}
		}
	}

	[Category("RemoveBuffOnUnit")]
	[UMeta(MDProp.EditCondition, "!bTakePlayerAsUnit")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BSN_RemoveBuffOnUnit:UnitGuid")]
	public FGameplayTag UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:UnitGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:UnitGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("RemoveBuffOnUnit")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BSN_RemoveBuffOnUnit:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "1")]
	[Category("RemoveBuffOnUnit")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BSN_RemoveBuffOnUnit:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[Category("RemoveBuffOnUnit")]
	[DisplayName("是否触发移除效果")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BSN_RemoveBuffOnUnit:bTriggerRemoveEffect")]
	public bool bTriggerRemoveEffect
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerRemoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:bTriggerRemoveEffect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerRemoveEffect_Offset), 0, bTriggerRemoveEffect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerRemoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_RemoveBuffOnUnit:bTriggerRemoveEffect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerRemoveEffect_Offset), 0, bTriggerRemoveEffect_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		bTriggerRemoveEffect = true;
	}

	[USharpPath("/Script/b1-Managed.BSN_RemoveBuffOnUnit:OnPreviewNotify")]
	protected override void OnPreviewNotify_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		string plainName = UnitGuid.TagName.PlainName;
		BGUCharacterCS bGUCharacterCS = null;
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(InPlaybackContext);
		foreach (BGUCharacterCS bGUCharacterCS2 in allActorsOfClass)
		{
			if (BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(bGUCharacterCS2).Equals(plainName))
			{
				bGUCharacterCS = bGUCharacterCS2;
				break;
			}
		}
		_ = bGUCharacterCS != null;
	}

	[USharpPath("/Script/b1-Managed.BSN_RemoveBuffOnUnit:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		if (bTakePlayerAsUnit)
		{
			foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(playbackContext))
			{
				RemoveBuffOnUnit(allPlayerActor);
			}
			return;
		}
		string plainName = UnitGuid.TagName.PlainName;
		BGUCharacterCS unit = BGU_DataUtil.GetActorByGuid(playbackContext, plainName) as BGUCharacterCS;
		RemoveBuffOnUnit(unit);
	}

	private void RemoveBuffOnUnit(BGUCharacterCS Unit)
	{
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit)?.Evt_BuffRemove.Invoke(BuffID, EBuffEffectTriggerType.None, BuffLayer, bTriggerRemoveEffect);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_RemoveBuffOnUnit:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_RemoveBuffOnUnit bSN_RemoveBuffOnUnit = GCHelper.Find<BSN_RemoveBuffOnUnit>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_RemoveBuffOnUnit.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_RemoveBuffOnUnit:OnPreviewNotify")]
	private static void OnPreviewNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_RemoveBuffOnUnit bSN_RemoveBuffOnUnit = GCHelper.Find<BSN_RemoveBuffOnUnit>(obj);
		UObject inPlaybackContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnPreviewNotify_InPlaybackContext_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnPreviewNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnPreviewNotify_bInBackwards_Offset), 0, OnPreviewNotify_bInBackwards_PropertyAddress.Address);
		bSN_RemoveBuffOnUnit.OnPreviewNotify_Implementation(inPlaybackContext, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_RemoveBuffOnUnit");
		NativeReflection.GetPropertyRef(ref bTakePlayerAsUnit_PropertyAddress, intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTakePlayerAsUnit", Classes.FBoolProperty);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStructProperty);
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bTriggerRemoveEffect_PropertyAddress, intPtr, "bTriggerRemoveEffect");
		bTriggerRemoveEffect_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTriggerRemoveEffect");
		bTriggerRemoveEffect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTriggerRemoveEffect", Classes.FBoolProperty);
		OnNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotify");
		OnNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotify_FunctionAddress);
		OnNotify_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InPlayer");
		OnNotify_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotify_bInBackwards_PropertyAddress, OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotify_IsValid = OnNotify_FunctionAddress != IntPtr.Zero && OnNotify_InPlayer_IsValid && OnNotify_InStatus_IsValid && OnNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_RemoveBuffOnUnit:OnNotify", OnNotify_IsValid);
		OnPreviewNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewNotify");
		OnPreviewNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewNotify_FunctionAddress);
		OnPreviewNotify_InPlaybackContext_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "InPlaybackContext");
		OnPreviewNotify_InPlaybackContext_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "InPlaybackContext", Classes.FObjectProperty);
		OnPreviewNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "InStatus");
		OnPreviewNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnPreviewNotify_bInBackwards_PropertyAddress, OnPreviewNotify_FunctionAddress, "bInBackwards");
		OnPreviewNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "bInBackwards");
		OnPreviewNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnPreviewNotify_IsValid = OnPreviewNotify_FunctionAddress != IntPtr.Zero && OnPreviewNotify_InPlaybackContext_IsValid && OnPreviewNotify_InStatus_IsValid && OnPreviewNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_RemoveBuffOnUnit:OnPreviewNotify", OnPreviewNotify_IsValid);
	}

	static BSN_RemoveBuffOnUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_RemoveBuffOnUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_RemoveBuffOnUnit));
	}
}
