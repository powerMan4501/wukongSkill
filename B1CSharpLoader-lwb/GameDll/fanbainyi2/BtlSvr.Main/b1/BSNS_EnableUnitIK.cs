using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Enable Unit IK")]
[UClass]
[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK")]
internal class BSNS_EnableUnitIK : UMovieSceneCalliopeNotifyStateSection
{
	private static bool bTakePlayerAsUnit_IsValid;

	private static int bTakePlayerAsUnit_Offset;

	private static FFieldAddress bTakePlayerAsUnit_PropertyAddress;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool bEnableIK_IsValid;

	private static int bEnableIK_Offset;

	private static FFieldAddress bEnableIK_PropertyAddress;

	private static bool bEnableForefootIK_IsValid;

	private static int bEnableForefootIK_Offset;

	private static FFieldAddress bEnableForefootIK_PropertyAddress;

	private static bool bEnableSpineIK_IsValid;

	private static int bEnableSpineIK_Offset;

	private static FFieldAddress bEnableSpineIK_PropertyAddress;

	private static bool OnNotifyEnd_IsValid;

	private static IntPtr OnNotifyEnd_FunctionAddress;

	private static int OnNotifyEnd_ParamsSize;

	private static bool OnNotifyEnd_InPlayer_IsValid;

	private static int OnNotifyEnd_InPlayer_Offset;

	private static bool OnNotifyEnd_InStatus_IsValid;

	private static int OnNotifyEnd_InStatus_Offset;

	private static bool OnNotifyEnd_bInBackwards_IsValid;

	private static int OnNotifyEnd_bInBackwards_Offset;

	private static FFieldAddress OnNotifyEnd_bInBackwards_PropertyAddress;

	private static bool OnNotifyBegin_IsValid;

	private static IntPtr OnNotifyBegin_FunctionAddress;

	private static int OnNotifyBegin_ParamsSize;

	private static bool OnNotifyBegin_InPlayer_IsValid;

	private static int OnNotifyBegin_InPlayer_Offset;

	private static bool OnNotifyBegin_InStatus_IsValid;

	private static int OnNotifyBegin_InStatus_Offset;

	private static bool OnNotifyBegin_bInBackwards_IsValid;

	private static int OnNotifyBegin_bInBackwards_Offset;

	private static FFieldAddress OnNotifyBegin_bInBackwards_PropertyAddress;

	private static bool OnPreviewNotifyEnd_IsValid;

	private static IntPtr OnPreviewNotifyEnd_FunctionAddress;

	private static int OnPreviewNotifyEnd_ParamsSize;

	private static bool OnPreviewNotifyEnd_InPlaybackContext_IsValid;

	private static int OnPreviewNotifyEnd_InPlaybackContext_Offset;

	private static bool OnPreviewNotifyEnd_InStatus_IsValid;

	private static int OnPreviewNotifyEnd_InStatus_Offset;

	private static bool OnPreviewNotifyEnd_bInBackwards_IsValid;

	private static int OnPreviewNotifyEnd_bInBackwards_Offset;

	private static FFieldAddress OnPreviewNotifyEnd_bInBackwards_PropertyAddress;

	private static bool OnPreviewNotifyBegin_IsValid;

	private static IntPtr OnPreviewNotifyBegin_FunctionAddress;

	private static int OnPreviewNotifyBegin_ParamsSize;

	private static bool OnPreviewNotifyBegin_InPlaybackContext_IsValid;

	private static int OnPreviewNotifyBegin_InPlaybackContext_Offset;

	private static bool OnPreviewNotifyBegin_InStatus_IsValid;

	private static int OnPreviewNotifyBegin_InStatus_Offset;

	private static bool OnPreviewNotifyBegin_bInBackwards_IsValid;

	private static int OnPreviewNotifyBegin_bInBackwards_Offset;

	private static FFieldAddress OnPreviewNotifyBegin_bInBackwards_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[Category("EnableUnitIK")]
	[DisplayName("主角作为Unit")]
	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:bTakePlayerAsUnit")]
	public bool bTakePlayerAsUnit
	{
		get
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:bTakePlayerAsUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:bTakePlayerAsUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("EnableUnitIK")]
	[UMeta(MDProp.EditCondition, "!bTakePlayerAsUnit")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:UnitGuid")]
	public FGameplayTag UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:UnitGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:UnitGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("EnableUnitIK")]
	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableIK")]
	public bool bEnableIK
	{
		get
		{
			CheckDestroyed();
			if (!bEnableIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableIK_Offset), 0, bEnableIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableIK_Offset), 0, bEnableIK_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("EnableUnitIK")]
	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableForefootIK")]
	public bool bEnableForefootIK
	{
		get
		{
			CheckDestroyed();
			if (!bEnableForefootIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableForefootIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableForefootIK_Offset), 0, bEnableForefootIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableForefootIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableForefootIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableForefootIK_Offset), 0, bEnableForefootIK_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("EnableUnitIK")]
	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableSpineIK")]
	public bool bEnableSpineIK
	{
		get
		{
			CheckDestroyed();
			if (!bEnableSpineIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableSpineIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableSpineIK_Offset), 0, bEnableSpineIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableSpineIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_EnableUnitIK:bEnableSpineIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableSpineIK_Offset), 0, bEnableSpineIK_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:OnPreviewNotifyBegin")]
	protected override void OnPreviewNotifyBegin_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		BGUCharacterCS bGUCharacterCS = null;
		if (!bTakePlayerAsUnit)
		{
			string plainName = UnitGuid.TagName.PlainName;
			BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(InPlaybackContext);
			foreach (BGUCharacterCS bGUCharacterCS2 in allActorsOfClass)
			{
				if (BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(bGUCharacterCS2).Equals(plainName))
				{
					bGUCharacterCS = bGUCharacterCS2;
					break;
				}
			}
		}
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetBoolBoolProperty.Invoke(EPropType.Mesh_EnableFootIK, bEnableIK, bEnableForefootIK, 0u, GetUniqueID());
				bUS_GSEventCollection.Evt_SetEnableSpineIK.Invoke(bEnableSpineIK);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:OnPreviewNotifyEnd")]
	protected override void OnPreviewNotifyEnd_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		BGUCharacterCS bGUCharacterCS = null;
		if (!bTakePlayerAsUnit)
		{
			string plainName = UnitGuid.TagName.PlainName;
			BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(InPlaybackContext);
			foreach (BGUCharacterCS bGUCharacterCS2 in allActorsOfClass)
			{
				if (BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(bGUCharacterCS2).Equals(plainName))
				{
					bGUCharacterCS = bGUCharacterCS2;
					break;
				}
			}
		}
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		IBUC_ABPHelperData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>(bGUCharacterCS);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.ABPSettingData != null)
		{
			BUABPSpineIKSettingData spineIKSetting = unPersistentReadOnlyData.ABPSettingData.SpineIKSetting;
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(0u, GetUniqueID());
				bUS_GSEventCollection.Evt_SetEnableSpineIK.Invoke(spineIKSetting.bEnableSpineIK);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:OnNotifyBegin")]
	protected override void OnNotifyBegin_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		List<AActor> list = new List<AActor>();
		if (bTakePlayerAsUnit)
		{
			int numLocalPlayerControllers = UGameplayStatics.GetNumLocalPlayerControllers(playbackContext);
			for (int i = 0; i < numLocalPlayerControllers; i++)
			{
				AActor playerCharacter = UGameplayStatics.GetPlayerCharacter(playbackContext, i);
				if (playerCharacter != null)
				{
					list.Add(playerCharacter);
				}
			}
		}
		else
		{
			string plainName = UnitGuid.TagName.PlainName;
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(playbackContext, plainName);
			list.Add(actorByGuid);
		}
		foreach (AActor item in list)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(item);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetBoolBoolProperty.Invoke(EPropType.Mesh_EnableFootIK, bEnableIK, bEnableForefootIK, 0u, GetUniqueID());
				bUS_GSEventCollection.Evt_SetEnableSpineIK.Invoke(bEnableSpineIK);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_EnableUnitIK:OnNotifyEnd")]
	protected override void OnNotifyEnd_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		List<AActor> list = new List<AActor>();
		if (bTakePlayerAsUnit)
		{
			int numLocalPlayerControllers = UGameplayStatics.GetNumLocalPlayerControllers(playbackContext);
			for (int i = 0; i < numLocalPlayerControllers; i++)
			{
				AActor playerCharacter = UGameplayStatics.GetPlayerCharacter(playbackContext, i);
				if (playerCharacter != null)
				{
					list.Add(playerCharacter);
				}
			}
		}
		else
		{
			string plainName = UnitGuid.TagName.PlainName;
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(playbackContext, plainName);
			if (actorByGuid != null)
			{
				list.Add(actorByGuid);
			}
		}
		foreach (AActor item in list)
		{
			IBUC_ABPHelperData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>(item);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.ABPSettingData != null)
			{
				BUABPSpineIKSettingData spineIKSetting = unPersistentReadOnlyData.ABPSettingData.SpineIKSetting;
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(item);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_ResetProperty.Invoke(0u, GetUniqueID());
					bUS_GSEventCollection.Evt_SetEnableSpineIK.Invoke(spineIKSetting.bEnableSpineIK);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_EnableUnitIK:OnNotifyEnd")]
	private static void OnNotifyEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSNS_EnableUnitIK bSNS_EnableUnitIK = GCHelper.Find<b1.BSNS_EnableUnitIK>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyEnd_bInBackwards_Offset), 0, OnNotifyEnd_bInBackwards_PropertyAddress.Address);
		bSNS_EnableUnitIK.OnNotifyEnd_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_EnableUnitIK:OnNotifyBegin")]
	private static void OnNotifyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSNS_EnableUnitIK bSNS_EnableUnitIK = GCHelper.Find<b1.BSNS_EnableUnitIK>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address);
		bSNS_EnableUnitIK.OnNotifyBegin_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_EnableUnitIK:OnPreviewNotifyEnd")]
	private static void OnPreviewNotifyEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSNS_EnableUnitIK bSNS_EnableUnitIK = GCHelper.Find<b1.BSNS_EnableUnitIK>(obj);
		UObject inPlaybackContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnPreviewNotifyEnd_InPlaybackContext_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnPreviewNotifyEnd_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnPreviewNotifyEnd_bInBackwards_Offset), 0, OnPreviewNotifyEnd_bInBackwards_PropertyAddress.Address);
		bSNS_EnableUnitIK.OnPreviewNotifyEnd_Implementation(inPlaybackContext, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_EnableUnitIK:OnPreviewNotifyBegin")]
	private static void OnPreviewNotifyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSNS_EnableUnitIK bSNS_EnableUnitIK = GCHelper.Find<b1.BSNS_EnableUnitIK>(obj);
		UObject inPlaybackContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnPreviewNotifyBegin_InPlaybackContext_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnPreviewNotifyBegin_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnPreviewNotifyBegin_bInBackwards_Offset), 0, OnPreviewNotifyBegin_bInBackwards_PropertyAddress.Address);
		bSNS_EnableUnitIK.OnPreviewNotifyBegin_Implementation(inPlaybackContext, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSNS_EnableUnitIK");
		NativeReflection.GetPropertyRef(ref bTakePlayerAsUnit_PropertyAddress, intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTakePlayerAsUnit", Classes.FBoolProperty);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bEnableIK_PropertyAddress, intPtr, "bEnableIK");
		bEnableIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableIK");
		bEnableIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableForefootIK_PropertyAddress, intPtr, "bEnableForefootIK");
		bEnableForefootIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableForefootIK");
		bEnableForefootIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableForefootIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableSpineIK_PropertyAddress, intPtr, "bEnableSpineIK");
		bEnableSpineIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableSpineIK");
		bEnableSpineIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableSpineIK", Classes.FBoolProperty);
		OnNotifyEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyEnd");
		OnNotifyEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyEnd_FunctionAddress);
		OnNotifyEnd_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "InPlayer");
		OnNotifyEnd_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotifyEnd_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "InStatus");
		OnNotifyEnd_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotifyEnd_bInBackwards_PropertyAddress, OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyEnd_IsValid = OnNotifyEnd_FunctionAddress != IntPtr.Zero && OnNotifyEnd_InPlayer_IsValid && OnNotifyEnd_InStatus_IsValid && OnNotifyEnd_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_EnableUnitIK:OnNotifyEnd", OnNotifyEnd_IsValid);
		OnNotifyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyBegin");
		OnNotifyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyBegin_FunctionAddress);
		OnNotifyBegin_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "InPlayer");
		OnNotifyBegin_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotifyBegin_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "InStatus");
		OnNotifyBegin_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotifyBegin_bInBackwards_PropertyAddress, OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyBegin_IsValid = OnNotifyBegin_FunctionAddress != IntPtr.Zero && OnNotifyBegin_InPlayer_IsValid && OnNotifyBegin_InStatus_IsValid && OnNotifyBegin_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_EnableUnitIK:OnNotifyBegin", OnNotifyBegin_IsValid);
		OnPreviewNotifyEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewNotifyEnd");
		OnPreviewNotifyEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewNotifyEnd_FunctionAddress);
		OnPreviewNotifyEnd_InPlaybackContext_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotifyEnd_FunctionAddress, "InPlaybackContext");
		OnPreviewNotifyEnd_InPlaybackContext_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotifyEnd_FunctionAddress, "InPlaybackContext", Classes.FObjectProperty);
		OnPreviewNotifyEnd_InStatus_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotifyEnd_FunctionAddress, "InStatus");
		OnPreviewNotifyEnd_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotifyEnd_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnPreviewNotifyEnd_bInBackwards_PropertyAddress, OnPreviewNotifyEnd_FunctionAddress, "bInBackwards");
		OnPreviewNotifyEnd_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotifyEnd_FunctionAddress, "bInBackwards");
		OnPreviewNotifyEnd_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotifyEnd_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnPreviewNotifyEnd_IsValid = OnPreviewNotifyEnd_FunctionAddress != IntPtr.Zero && OnPreviewNotifyEnd_InPlaybackContext_IsValid && OnPreviewNotifyEnd_InStatus_IsValid && OnPreviewNotifyEnd_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_EnableUnitIK:OnPreviewNotifyEnd", OnPreviewNotifyEnd_IsValid);
		OnPreviewNotifyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewNotifyBegin");
		OnPreviewNotifyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewNotifyBegin_FunctionAddress);
		OnPreviewNotifyBegin_InPlaybackContext_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotifyBegin_FunctionAddress, "InPlaybackContext");
		OnPreviewNotifyBegin_InPlaybackContext_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotifyBegin_FunctionAddress, "InPlaybackContext", Classes.FObjectProperty);
		OnPreviewNotifyBegin_InStatus_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotifyBegin_FunctionAddress, "InStatus");
		OnPreviewNotifyBegin_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotifyBegin_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnPreviewNotifyBegin_bInBackwards_PropertyAddress, OnPreviewNotifyBegin_FunctionAddress, "bInBackwards");
		OnPreviewNotifyBegin_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotifyBegin_FunctionAddress, "bInBackwards");
		OnPreviewNotifyBegin_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotifyBegin_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnPreviewNotifyBegin_IsValid = OnPreviewNotifyBegin_FunctionAddress != IntPtr.Zero && OnPreviewNotifyBegin_InPlaybackContext_IsValid && OnPreviewNotifyBegin_InStatus_IsValid && OnPreviewNotifyBegin_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_EnableUnitIK:OnPreviewNotifyBegin", OnPreviewNotifyBegin_IsValid);
	}

	static BSNS_EnableUnitIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BSNS_EnableUnitIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BSNS_EnableUnitIK));
	}
}
