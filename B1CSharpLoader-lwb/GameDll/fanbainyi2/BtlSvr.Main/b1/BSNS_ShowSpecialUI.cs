using System;
using b1.Localization;
using b1.Plugins.Calliope;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("ShowSpecialUI")]
[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUI")]
public class BSNS_ShowSpecialUI : UMovieSceneCalliopeNotifyStateSection
{
	private static bool UIPageID_IsValid;

	private static int UIPageID_Offset;

	private static FFieldAddress UIPageID_PropertyAddress;

	private static bool DialogueID_IsValid;

	private static int DialogueID_Offset;

	private static bool NameID_IsValid;

	private static int NameID_Offset;

	private static bool ChapterID_IsValid;

	private static int ChapterID_Offset;

	private static bool MediaID_IsValid;

	private static int MediaID_Offset;

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

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUI:UIPageID")]
	public EUIPageID UIPageID
	{
		get
		{
			CheckDestroyed();
			if (!UIPageID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:UIPageID");
				return EUIPageID.MIN;
			}
			return EnumMarshaler<EUIPageID>.FromNative(IntPtr.Add(base.Address, UIPageID_Offset), 0, UIPageID_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UIPageID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:UIPageID");
			}
			else
			{
				EnumMarshaler<EUIPageID>.ToNative(IntPtr.Add(base.Address, UIPageID_Offset), 0, UIPageID_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UIPageID == EUIPageID::Story")]
	[Category("Dialogue")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUI:DialogueID")]
	public int DialogueID
	{
		get
		{
			CheckDestroyed();
			if (!DialogueID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:DialogueID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DialogueID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DialogueID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:DialogueID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DialogueID_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Name")]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UIPageID == EUIPageID::Name")]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUI:NameID")]
	public int NameID
	{
		get
		{
			CheckDestroyed();
			if (!NameID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:NameID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NameID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NameID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:NameID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NameID_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UIPageID == EUIPageID::ChapterMovie")]
	[Category("Chapter")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUI:ChapterID")]
	public int ChapterID
	{
		get
		{
			CheckDestroyed();
			if (!ChapterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:ChapterID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChapterID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChapterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:ChapterID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChapterID_Offset), value);
			}
		}
	}

	[Category("Media")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UIPageID == EUIPageID::SeqMediaPlayer")]
	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUI:MediaID")]
	public int MediaID
	{
		get
		{
			CheckDestroyed();
			if (!MediaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:MediaID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MediaID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_ShowSpecialUI:MediaID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MediaID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUI:OnNotifyBegin")]
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
		if (UIPageID == EUIPageID.Story)
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
		else if (UIPageID == EUIPageID.Name)
		{
			bGW_UIEventCollection?.Evt_UI_ActiveName?.Invoke(B1: true, NameID, GetDurationTime());
		}
		else if (UIPageID != EUIPageID.ChapterMovie && UIPageID == EUIPageID.SeqMediaPlayer)
		{
			bGW_UIEventCollection?.Evt_UI_SeqMediaPlayer_Cache(MediaID);
			bGW_UIEventCollection?.Evt_UI_SeqMediaPlayer_Play();
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_ShowSpecialUI:GetDisplayName")]
	protected override string GetDisplayName_Implementation()
	{
		if (UIPageID == EUIPageID.Story)
		{
			FUStDialogueDesc dialogueDesc = BGW_GameDB.GetDialogueDesc(DialogueID);
			if (dialogueDesc != null)
			{
				return dialogueDesc.Content;
			}
		}
		return base.GetDisplayName_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_ShowSpecialUI:OnNotifyBegin")]
	private static void OnNotifyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_ShowSpecialUI bSNS_ShowSpecialUI = GCHelper.Find<BSNS_ShowSpecialUI>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address);
		bSNS_ShowSpecialUI.OnNotifyBegin_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_ShowSpecialUI:GetDisplayName")]
	private static void GetDisplayName__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_ShowSpecialUI bSNS_ShowSpecialUI = GCHelper.Find<BSNS_ShowSpecialUI>(obj);
		string displayName_Implementation = bSNS_ShowSpecialUI.GetDisplayName_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayName_ReturnValue_Offset), displayName_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSNS_ShowSpecialUI");
		NativeReflection.GetPropertyRef(ref UIPageID_PropertyAddress, intPtr, "UIPageID");
		UIPageID_Offset = NativeReflection.GetPropertyOffset(intPtr, "UIPageID");
		UIPageID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UIPageID", Classes.FEnumProperty);
		DialogueID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DialogueID");
		DialogueID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DialogueID", Classes.FIntProperty);
		NameID_Offset = NativeReflection.GetPropertyOffset(intPtr, "NameID");
		NameID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NameID", Classes.FIntProperty);
		ChapterID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChapterID");
		ChapterID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChapterID", Classes.FIntProperty);
		MediaID_Offset = NativeReflection.GetPropertyOffset(intPtr, "MediaID");
		MediaID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MediaID", Classes.FIntProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_ShowSpecialUI:OnNotifyBegin", OnNotifyBegin_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_ShowSpecialUI:GetDisplayName", GetDisplayName_IsValid);
	}

	static BSNS_ShowSpecialUI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSNS_ShowSpecialUI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSNS_ShowSpecialUI));
	}
}
