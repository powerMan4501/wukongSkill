using System;
using b1.Localization;
using b1.Plugins.Calliope;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("ShowSpecialUIV2")]
[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2")]
public class BSNS_ShowSpecialUIV2 : UMovieSceneCalliopeNotifyStateSection
{
	private static bool UIPageID_IsValid;

	private static int UIPageID_Offset;

	private static FFieldAddress UIPageID_PropertyAddress;

	private static bool DialogueID_IsValid;

	private static int DialogueID_Offset;

	private static bool NameID_IsValid;

	private static int NameID_Offset;

	private static bool MediaID_IsValid;

	private static int MediaID_Offset;

	private static bool OpenEndingCredits_IsValid;

	private static int OpenEndingCredits_Offset;

	private static FFieldAddress OpenEndingCredits_PropertyAddress;

	private static bool OnNotifyEnd_IsValid;

	private static IntPtr OnNotifyEnd_FunctionAddress;

	private static int OnNotifyEnd_ParamsSize;

	private static bool OnNotifyEnd_Player_IsValid;

	private static int OnNotifyEnd_Player_Offset;

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

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static int GetDisplayName_ReturnValue_Offset;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2:UIPageID")]
	public EUIPageType UIPageID
	{
		get
		{
			CheckDestroyed();
			if (!UIPageID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:UIPageID");
				return EUIPageType.None;
			}
			return EnumMarshaler<EUIPageType>.FromNative(IntPtr.Add(base.Address, UIPageID_Offset), 0, UIPageID_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UIPageID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:UIPageID");
			}
			else
			{
				EnumMarshaler<EUIPageType>.ToNative(IntPtr.Add(base.Address, UIPageID_Offset), 0, UIPageID_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UIPageID == EUIPageType::Story")]
	[Category("Dialogue")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2:DialogueID")]
	public int DialogueID
	{
		get
		{
			CheckDestroyed();
			if (!DialogueID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:DialogueID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DialogueID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DialogueID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:DialogueID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DialogueID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UIPageID == EUIPageType::Name")]
	[Category("Name")]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2:NameID")]
	public int NameID
	{
		get
		{
			CheckDestroyed();
			if (!NameID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:NameID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NameID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NameID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:NameID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NameID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Media")]
	[UMeta(MDProp.EditCondition, "UIPageID == EUIPageType::SeqMediaPlayer")]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2:MediaID")]
	public int MediaID
	{
		get
		{
			CheckDestroyed();
			if (!MediaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:MediaID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MediaID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:MediaID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MediaID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UIPageID == EUIPageType::EndCredits")]
	[Category("EndingCredits")]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OpenEndingCredits")]
	public EEndingCreditsAction OpenEndingCredits
	{
		get
		{
			CheckDestroyed();
			if (!OpenEndingCredits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OpenEndingCredits");
				return EEndingCreditsAction.Open;
			}
			return EnumMarshaler<EEndingCreditsAction>.FromNative(IntPtr.Add(base.Address, OpenEndingCredits_Offset), 0, OpenEndingCredits_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenEndingCredits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OpenEndingCredits");
			}
			else
			{
				EnumMarshaler<EEndingCreditsAction>.ToNative(IntPtr.Add(base.Address, OpenEndingCredits_Offset), 0, OpenEndingCredits_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OnNotifyBegin")]
	protected override void OnNotifyBegin_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(playbackContext);
		if (bGW_UIEventCollection == null)
		{
			return;
		}
		int movieInstanceIndex = InPlayer.MovieInstanceIndex;
		IBGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(InPlayer);
		if (gameStateReadonlyData != null && gameStateReadonlyData.IsMovieFastForwardSkiping(movieInstanceIndex))
		{
			return;
		}
		if (UIPageID == EUIPageType.Story)
		{
			string name = "";
			string content = "";
			FUStDialogueDesc dialogueDesc = BGW_GameDB.GetDialogueDesc(DialogueID);
			if (dialogueDesc != null)
			{
				name = dialogueDesc.Name.ToFText().ToString();
				content = dialogueDesc.Content.ToFText().ToString();
			}
			BGW_UIMgr.Get(playbackContext)?.PlaySubtitle(name, content, GetDurationTime());
		}
		else if (UIPageID == EUIPageType.Name)
		{
			bGW_UIEventCollection?.Evt_UI_ActiveName?.Invoke(B1: true, NameID, GetDurationTime());
		}
		else if (UIPageID == EUIPageType.SeqMediaPlayer)
		{
			bGW_UIEventCollection?.Evt_UI_SeqMediaPlayer_Cache(MediaID);
			bGW_UIEventCollection?.Evt_UI_SeqMediaPlayer_Play();
		}
		else if (UIPageID == EUIPageType.SeqLogo)
		{
			BGUFunctionLibraryManaged.BGUSetPageActive(playbackContext, GSEUtil.GetPageIDbyPageType(UIPageID), IsActive: true);
		}
		else if (UIPageID == EUIPageType.EndCredits)
		{
			EEndingCreditsAction openEndingCredits = OpenEndingCredits;
			if (openEndingCredits == EEndingCreditsAction.Open || openEndingCredits != EEndingCreditsAction.OpenBackground)
			{
				bGW_UIEventCollection?.Evt_UI_ShowEndingCredits?.Invoke();
			}
			else
			{
				bGW_UIEventCollection?.Evt_UI_OpenEndingCreditsBackground?.Invoke();
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OnNotifyEnd")]
	protected override void OnNotifyEnd_Implementation(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = Player.GetPlaybackContext();
		if (UIPageID == EUIPageType.SeqLogo)
		{
			BGUFunctionLibraryManaged.BGUSetPageActive(playbackContext, GSEUtil.GetPageIDbyPageType(UIPageID), IsActive: false);
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUIV2:GetDisplayName")]
	protected override string GetDisplayName_Implementation()
	{
		if (UIPageID == EUIPageType.Story)
		{
			FUStDialogueDesc dialogueDesc = BGW_GameDB.GetDialogueDesc(DialogueID);
			if (dialogueDesc != null)
			{
				return dialogueDesc.Content;
			}
		}
		return base.GetDisplayName_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OnNotifyEnd")]
	private static void OnNotifyEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_ShowSpecialUIV2 bSNS_ShowSpecialUIV = GCHelper.Find<BSNS_ShowSpecialUIV2>(obj);
		UCalliopeLevelSequencePlayer player = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_Player_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyEnd_bInBackwards_Offset), 0, OnNotifyEnd_bInBackwards_PropertyAddress.Address);
		bSNS_ShowSpecialUIV.OnNotifyEnd_Implementation(player, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OnNotifyBegin")]
	private static void OnNotifyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_ShowSpecialUIV2 bSNS_ShowSpecialUIV = GCHelper.Find<BSNS_ShowSpecialUIV2>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address);
		bSNS_ShowSpecialUIV.OnNotifyBegin_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_ShowSpecialUIV2:GetDisplayName")]
	private static void GetDisplayName__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_ShowSpecialUIV2 bSNS_ShowSpecialUIV = GCHelper.Find<BSNS_ShowSpecialUIV2>(obj);
		string displayName_Implementation = bSNS_ShowSpecialUIV.GetDisplayName_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayName_ReturnValue_Offset), displayName_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSNS_ShowSpecialUIV2");
		NativeReflection.GetPropertyRef(ref UIPageID_PropertyAddress, intPtr, "UIPageID");
		UIPageID_Offset = NativeReflection.GetPropertyOffset(intPtr, "UIPageID");
		UIPageID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UIPageID", Classes.FEnumProperty);
		DialogueID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DialogueID");
		DialogueID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DialogueID", Classes.FIntProperty);
		NameID_Offset = NativeReflection.GetPropertyOffset(intPtr, "NameID");
		NameID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NameID", Classes.FIntProperty);
		MediaID_Offset = NativeReflection.GetPropertyOffset(intPtr, "MediaID");
		MediaID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MediaID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OpenEndingCredits_PropertyAddress, intPtr, "OpenEndingCredits");
		OpenEndingCredits_Offset = NativeReflection.GetPropertyOffset(intPtr, "OpenEndingCredits");
		OpenEndingCredits_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OpenEndingCredits", Classes.FEnumProperty);
		OnNotifyEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyEnd");
		OnNotifyEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyEnd_FunctionAddress);
		OnNotifyEnd_Player_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "Player");
		OnNotifyEnd_Player_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "Player", Classes.FObjectProperty);
		OnNotifyEnd_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "InStatus");
		OnNotifyEnd_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotifyEnd_bInBackwards_PropertyAddress, OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyEnd_IsValid = OnNotifyEnd_FunctionAddress != IntPtr.Zero && OnNotifyEnd_Player_IsValid && OnNotifyEnd_InStatus_IsValid && OnNotifyEnd_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OnNotifyEnd", OnNotifyEnd_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_ShowSpecialUIV2:OnNotifyBegin", OnNotifyBegin_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_ShowSpecialUIV2:GetDisplayName", GetDisplayName_IsValid);
	}

	static BSNS_ShowSpecialUIV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSNS_ShowSpecialUIV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSNS_ShowSpecialUIV2));
	}
}
