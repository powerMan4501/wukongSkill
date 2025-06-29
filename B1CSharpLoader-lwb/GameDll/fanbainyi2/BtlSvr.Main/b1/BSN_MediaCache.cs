using System;
using b1.Plugins.Calliope;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("MediaCache")]
[USharpPath("/Script/b1-Managed.BSN_MediaCache")]
public class BSN_MediaCache : UMovieSceneCalliopeNotifySection
{
	private static bool MediaID_IsValid;

	private static int MediaID_Offset;

	private static bool OnNotify_IsValid;

	private static IntPtr OnNotify_FunctionAddress;

	private static int OnNotify_ParamsSize;

	private static bool OnNotify_Player_IsValid;

	private static int OnNotify_Player_Offset;

	private static bool OnNotify_InStatus_IsValid;

	private static int OnNotify_InStatus_Offset;

	private static bool OnNotify_bInBackwards_IsValid;

	private static int OnNotify_bInBackwards_Offset;

	private static FFieldAddress OnNotify_bInBackwards_PropertyAddress;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static int GetDisplayName_ReturnValue_Offset;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Media")]
	[USharpPath("/Script/b1-Managed.BSN_MediaCache:MediaID")]
	public int MediaID
	{
		get
		{
			CheckDestroyed();
			if (!MediaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_MediaCache:MediaID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MediaID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_MediaCache:MediaID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MediaID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_MediaCache:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(Player.GetPlaybackContext());
		if (!(bGW_UIEventCollection == null))
		{
			int movieInstanceIndex = Player.MovieInstanceIndex;
			IBGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(Player);
			if (gameStateReadonlyData == null || !gameStateReadonlyData.IsMovieFastForwardSkiping(movieInstanceIndex))
			{
				bGW_UIEventCollection?.Evt_UI_SeqMediaPlayer_Cache(MediaID);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_MediaCache:GetDisplayName")]
	protected override string GetDisplayName_Implementation()
	{
		MovieAndSubtitleDesc movieAndSubtitleDesc = GameDBRuntime.GetMovieAndSubtitleDesc(MediaID);
		if (movieAndSubtitleDesc != null)
		{
			return "流媒体缓冲: " + movieAndSubtitleDesc.MoviePath;
		}
		return base.GetDisplayName_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_MediaCache:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_MediaCache bSN_MediaCache = GCHelper.Find<BSN_MediaCache>(obj);
		UCalliopeLevelSequencePlayer player = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_Player_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_MediaCache.OnNotify_Implementation(player, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_MediaCache:GetDisplayName")]
	private static void GetDisplayName__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_MediaCache bSN_MediaCache = GCHelper.Find<BSN_MediaCache>(obj);
		string displayName_Implementation = bSN_MediaCache.GetDisplayName_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayName_ReturnValue_Offset), displayName_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_MediaCache");
		MediaID_Offset = NativeReflection.GetPropertyOffset(intPtr, "MediaID");
		MediaID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MediaID", Classes.FIntProperty);
		OnNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotify");
		OnNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotify_FunctionAddress);
		OnNotify_Player_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "Player");
		OnNotify_Player_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "Player", Classes.FObjectProperty);
		OnNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotify_bInBackwards_PropertyAddress, OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotify_IsValid = OnNotify_FunctionAddress != IntPtr.Zero && OnNotify_Player_IsValid && OnNotify_InStatus_IsValid && OnNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_MediaCache:OnNotify", OnNotify_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_MediaCache:GetDisplayName", GetDisplayName_IsValid);
	}

	static BSN_MediaCache()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_MediaCache)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_MediaCache));
	}
}
