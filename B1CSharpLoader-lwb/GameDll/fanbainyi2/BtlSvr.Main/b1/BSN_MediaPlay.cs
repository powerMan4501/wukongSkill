using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("MediaPlay")]
[USharpPath("/Script/b1-Managed.BSN_MediaPlay")]
public class BSN_MediaPlay : UMovieSceneCalliopeNotifySection
{
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

	[USharpPath("/Script/b1-Managed.BSN_MediaPlay:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(Player.GetPlaybackContext());
		if (!(bGW_UIEventCollection == null))
		{
			int movieInstanceIndex = Player.MovieInstanceIndex;
			IBGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(Player);
			if (gameStateReadonlyData == null || !gameStateReadonlyData.IsMovieFastForwardSkiping(movieInstanceIndex))
			{
				bGW_UIEventCollection?.Evt_UI_SeqMediaPlayer_Play();
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_MediaPlay:GetDisplayName")]
	protected override string GetDisplayName_Implementation()
	{
		return "流媒体播放";
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_MediaPlay:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_MediaPlay bSN_MediaPlay = GCHelper.Find<BSN_MediaPlay>(obj);
		UCalliopeLevelSequencePlayer player = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_Player_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_MediaPlay.OnNotify_Implementation(player, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_MediaPlay:GetDisplayName")]
	private static void GetDisplayName__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_MediaPlay bSN_MediaPlay = GCHelper.Find<BSN_MediaPlay>(obj);
		string displayName_Implementation = bSN_MediaPlay.GetDisplayName_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayName_ReturnValue_Offset), displayName_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BSN_MediaPlay");
		OnNotify_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNotify");
		OnNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotify_FunctionAddress);
		OnNotify_Player_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "Player");
		OnNotify_Player_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "Player", Classes.FObjectProperty);
		OnNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotify_bInBackwards_PropertyAddress, OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotify_IsValid = OnNotify_FunctionAddress != IntPtr.Zero && OnNotify_Player_IsValid && OnNotify_InStatus_IsValid && OnNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_MediaPlay:OnNotify", OnNotify_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_MediaPlay:GetDisplayName", GetDisplayName_IsValid);
	}

	static BSN_MediaPlay()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_MediaPlay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_MediaPlay));
	}
}
