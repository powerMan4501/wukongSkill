using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.AsyncLoadingScreen;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGWGameInstance", "b1", UnrealModuleType.Game)]
public class UBGWGameInstance : UGameInstance
{
	private static bool TravelURLHasOption_IsValid;

	private static IntPtr TravelURLHasOption_FunctionAddress;

	private static int TravelURLHasOption_ParamsSize;

	private static bool TravelURLHasOption_Option_IsValid;

	private static FFieldAddress TravelURLHasOption_Option_PropertyAddress;

	private static int TravelURLHasOption_Option_Offset;

	private static bool TravelURLHasOption_ReturnValue_IsValid;

	private static FFieldAddress TravelURLHasOption_ReturnValue_PropertyAddress;

	private static int TravelURLHasOption_ReturnValue_Offset;

	private static bool TravelURLHasHost_IsValid;

	private static IntPtr TravelURLHasHost_FunctionAddress;

	private static int TravelURLHasHost_ParamsSize;

	private static bool TravelURLHasHost_ReturnValue_IsValid;

	private static FFieldAddress TravelURLHasHost_ReturnValue_PropertyAddress;

	private static int TravelURLHasHost_ReturnValue_Offset;

	private static bool SwitchLoadingScreenThread_IsValid;

	private static IntPtr SwitchLoadingScreenThread_FunctionAddress;

	private static int SwitchLoadingScreenThread_ParamsSize;

	private static bool SwitchLoadingScreenThread_UseSlateThread_IsValid;

	private static FFieldAddress SwitchLoadingScreenThread_UseSlateThread_PropertyAddress;

	private static int SwitchLoadingScreenThread_UseSlateThread_Offset;

	private static bool StartGameInstanceForCS_IsValid;

	private IntPtr StartGameInstanceForCS_InstanceFunctionAddress;

	private static IntPtr StartGameInstanceForCS_FunctionAddress;

	private static int StartGameInstanceForCS_ParamsSize;

	private static bool StartGameInstanceForCS_StartType_IsValid;

	private static FFieldAddress StartGameInstanceForCS_StartType_PropertyAddress;

	private static int StartGameInstanceForCS_StartType_Offset;

	private static bool RequestFadeAway_IsValid;

	private static IntPtr RequestFadeAway_FunctionAddress;

	private static int RequestFadeAway_ParamsSize;

	private static bool RegisterLoadingTipsMask_IsValid;

	private static IntPtr RegisterLoadingTipsMask_FunctionAddress;

	private static int RegisterLoadingTipsMask_ParamsSize;

	private static bool RegisterLoadingTipsMask_MaskTexture_IsValid;

	private static FFieldAddress RegisterLoadingTipsMask_MaskTexture_PropertyAddress;

	private static int RegisterLoadingTipsMask_MaskTexture_Offset;

	private static bool RegisterLoadingTipsInfo_IsValid;

	private static IntPtr RegisterLoadingTipsInfo_FunctionAddress;

	private static int RegisterLoadingTipsInfo_ParamsSize;

	private static bool RegisterLoadingTipsInfo_TipsInfo_IsValid;

	private static FFieldAddress RegisterLoadingTipsInfo_TipsInfo_PropertyAddress;

	private static int RegisterLoadingTipsInfo_TipsInfo_Offset;

	private static bool RegisterChapterInfo_IsValid;

	private static IntPtr RegisterChapterInfo_FunctionAddress;

	private static int RegisterChapterInfo_ParamsSize;

	private static bool RegisterChapterInfo_ChapterInfo_IsValid;

	private static FFieldAddress RegisterChapterInfo_ChapterInfo_PropertyAddress;

	private static int RegisterChapterInfo_ChapterInfo_Offset;

	private static bool RegisterBossRushInfo_IsValid;

	private static IntPtr RegisterBossRushInfo_FunctionAddress;

	private static int RegisterBossRushInfo_ParamsSize;

	private static bool RegisterBossRushInfo_BossRushInfo_IsValid;

	private static FFieldAddress RegisterBossRushInfo_BossRushInfo_PropertyAddress;

	private static int RegisterBossRushInfo_BossRushInfo_Offset;

	private static bool ReceiveTickEvenWhenPaused_IsValid;

	private IntPtr ReceiveTickEvenWhenPaused_InstanceFunctionAddress;

	private static IntPtr ReceiveTickEvenWhenPaused_FunctionAddress;

	private static int ReceiveTickEvenWhenPaused_ParamsSize;

	private static bool ReceiveTickEvenWhenPaused_DeltaSeconds_IsValid;

	private static FFieldAddress ReceiveTickEvenWhenPaused_DeltaSeconds_PropertyAddress;

	private static int ReceiveTickEvenWhenPaused_DeltaSeconds_Offset;

	private static bool ReceiveTickEvenWhenPaused_TickGroup_IsValid;

	private static FFieldAddress ReceiveTickEvenWhenPaused_TickGroup_PropertyAddress;

	private static int ReceiveTickEvenWhenPaused_TickGroup_Offset;

	private static bool ReceiveTick_IsValid;

	private IntPtr ReceiveTick_InstanceFunctionAddress;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static FFieldAddress ReceiveTick_DeltaSeconds_PropertyAddress;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveTick_TickGroup_IsValid;

	private static FFieldAddress ReceiveTick_TickGroup_PropertyAddress;

	private static int ReceiveTick_TickGroup_Offset;

	private static bool ProcessNianHuiLogic_IsValid;

	private IntPtr ProcessNianHuiLogic_InstanceFunctionAddress;

	private static IntPtr ProcessNianHuiLogic_FunctionAddress;

	private static int ProcessNianHuiLogic_ParamsSize;

	private static bool PrepareFadeAway_IsValid;

	private static IntPtr PrepareFadeAway_FunctionAddress;

	private static int PrepareFadeAway_ParamsSize;

	private static bool OpenLoadingScreen_IsValid;

	private static IntPtr OpenLoadingScreen_FunctionAddress;

	private static int OpenLoadingScreen_ParamsSize;

	private static bool OpenLoadingScreen_UseSlateThread_IsValid;

	private static FFieldAddress OpenLoadingScreen_UseSlateThread_PropertyAddress;

	private static int OpenLoadingScreen_UseSlateThread_Offset;

	private static bool OpenLoadingScreen_LoadingScreenType_IsValid;

	private static FFieldAddress OpenLoadingScreen_LoadingScreenType_PropertyAddress;

	private static int OpenLoadingScreen_LoadingScreenType_Offset;

	private static bool OnWorldTickStartCS_IsValid;

	private IntPtr OnWorldTickStartCS_InstanceFunctionAddress;

	private static IntPtr OnWorldTickStartCS_FunctionAddress;

	private static int OnWorldTickStartCS_ParamsSize;

	private static bool OnWorldTickStartCS_World_IsValid;

	private static FFieldAddress OnWorldTickStartCS_World_PropertyAddress;

	private static int OnWorldTickStartCS_World_Offset;

	private static bool OnWorldChangedCS_IsValid;

	private IntPtr OnWorldChangedCS_InstanceFunctionAddress;

	private static IntPtr OnWorldChangedCS_FunctionAddress;

	private static int OnWorldChangedCS_ParamsSize;

	private static bool OnWorldChangedCS_OldWorld_IsValid;

	private static FFieldAddress OnWorldChangedCS_OldWorld_PropertyAddress;

	private static int OnWorldChangedCS_OldWorld_Offset;

	private static bool OnWorldChangedCS_NewWorld_IsValid;

	private static FFieldAddress OnWorldChangedCS_NewWorld_PropertyAddress;

	private static int OnWorldChangedCS_NewWorld_Offset;

	private static bool OnPostActorTickCS_IsValid;

	private IntPtr OnPostActorTickCS_InstanceFunctionAddress;

	private static IntPtr OnPostActorTickCS_FunctionAddress;

	private static int OnPostActorTickCS_ParamsSize;

	private static bool OnPostActorTickCS_World_IsValid;

	private static FFieldAddress OnPostActorTickCS_World_PropertyAddress;

	private static int OnPostActorTickCS_World_Offset;

	private static bool OnGameModeMatchStateSetCS_IsValid;

	private IntPtr OnGameModeMatchStateSetCS_InstanceFunctionAddress;

	private static IntPtr OnGameModeMatchStateSetCS_FunctionAddress;

	private static int OnGameModeMatchStateSetCS_ParamsSize;

	private static bool OnGameModeMatchStateSetCS_NewMatchState_IsValid;

	private static FFieldAddress OnGameModeMatchStateSetCS_NewMatchState_PropertyAddress;

	private static int OnGameModeMatchStateSetCS_NewMatchState_Offset;

	private static bool IsToggleLoadingTipsFinish_IsValid;

	private static IntPtr IsToggleLoadingTipsFinish_FunctionAddress;

	private static int IsToggleLoadingTipsFinish_ParamsSize;

	private static bool IsToggleLoadingTipsFinish_ReturnValue_IsValid;

	private static FFieldAddress IsToggleLoadingTipsFinish_ReturnValue_PropertyAddress;

	private static int IsToggleLoadingTipsFinish_ReturnValue_Offset;

	private static bool IsLoadingScreenFadeAwayFinish_IsValid;

	private static IntPtr IsLoadingScreenFadeAwayFinish_FunctionAddress;

	private static int IsLoadingScreenFadeAwayFinish_ParamsSize;

	private static bool IsLoadingScreenFadeAwayFinish_ReturnValue_IsValid;

	private static FFieldAddress IsLoadingScreenFadeAwayFinish_ReturnValue_PropertyAddress;

	private static int IsLoadingScreenFadeAwayFinish_ReturnValue_Offset;

	private static bool GetWorldForCS_IsValid;

	private static IntPtr GetWorldForCS_FunctionAddress;

	private static int GetWorldForCS_ParamsSize;

	private static bool GetWorldForCS_ReturnValue_IsValid;

	private static FFieldAddress GetWorldForCS_ReturnValue_PropertyAddress;

	private static int GetWorldForCS_ReturnValue_Offset;

	private static bool GetTravelURLHost_IsValid;

	private static IntPtr GetTravelURLHost_FunctionAddress;

	private static int GetTravelURLHost_ParamsSize;

	private static bool GetTravelURLHost_ReturnValue_IsValid;

	private static FFieldAddress GetTravelURLHost_ReturnValue_PropertyAddress;

	private static int GetTravelURLHost_ReturnValue_Offset;

	private static bool GetTravelURLForCS_IsValid;

	private static IntPtr GetTravelURLForCS_FunctionAddress;

	private static int GetTravelURLForCS_ParamsSize;

	private static bool GetTravelURLForCS_ReturnValue_IsValid;

	private static FFieldAddress GetTravelURLForCS_ReturnValue_PropertyAddress;

	private static int GetTravelURLForCS_ReturnValue_Offset;

	private static bool GetTimeInMSSinceLoadingOpen_IsValid;

	private static IntPtr GetTimeInMSSinceLoadingOpen_FunctionAddress;

	private static int GetTimeInMSSinceLoadingOpen_ParamsSize;

	private static bool GetTimeInMSSinceLoadingOpen_ReturnValue_IsValid;

	private static FFieldAddress GetTimeInMSSinceLoadingOpen_ReturnValue_PropertyAddress;

	private static int GetTimeInMSSinceLoadingOpen_ReturnValue_Offset;

	private static bool GetOnlineSessionClassCS_IsValid;

	private IntPtr GetOnlineSessionClassCS_InstanceFunctionAddress;

	private static IntPtr GetOnlineSessionClassCS_FunctionAddress;

	private static int GetOnlineSessionClassCS_ParamsSize;

	private static bool GetOnlineSessionClassCS_ReturnValue_IsValid;

	private static FFieldAddress GetOnlineSessionClassCS_ReturnValue_PropertyAddress;

	private static int GetOnlineSessionClassCS_ReturnValue_Offset;

	private static bool GetLastUseTips_IsValid;

	private static IntPtr GetLastUseTips_FunctionAddress;

	private static int GetLastUseTips_ParamsSize;

	private static bool GetLastUseTips_ReturnValue_IsValid;

	private static FFieldAddress GetLastUseTips_ReturnValue_PropertyAddress;

	private static int GetLastUseTips_ReturnValue_Offset;

	private static bool GetFirstGamePlayerForCS_IsValid;

	private static IntPtr GetFirstGamePlayerForCS_FunctionAddress;

	private static int GetFirstGamePlayerForCS_ParamsSize;

	private static bool GetFirstGamePlayerForCS_ReturnValue_IsValid;

	private static FFieldAddress GetFirstGamePlayerForCS_ReturnValue_PropertyAddress;

	private static int GetFirstGamePlayerForCS_ReturnValue_Offset;

	private static bool GetEvents_IsValid;

	private static IntPtr GetEvents_FunctionAddress;

	private static int GetEvents_ParamsSize;

	private static bool GetEvents_ReturnValue_IsValid;

	private static FFieldAddress GetEvents_ReturnValue_PropertyAddress;

	private static int GetEvents_ReturnValue_Offset;

	private static bool GetCurLoadingScreenType_IsValid;

	private static IntPtr GetCurLoadingScreenType_FunctionAddress;

	private static int GetCurLoadingScreenType_ParamsSize;

	private static bool GetCurLoadingScreenType_ReturnValue_IsValid;

	private static FFieldAddress GetCurLoadingScreenType_ReturnValue_PropertyAddress;

	private static int GetCurLoadingScreenType_ReturnValue_Offset;

	private static bool GetCurLoadingScreenState_IsValid;

	private static IntPtr GetCurLoadingScreenState_FunctionAddress;

	private static int GetCurLoadingScreenState_ParamsSize;

	private static bool GetCurLoadingScreenState_ReturnValue_IsValid;

	private static FFieldAddress GetCurLoadingScreenState_ReturnValue_PropertyAddress;

	private static int GetCurLoadingScreenState_ReturnValue_Offset;

	private static bool CloseLoadingScreen_IsValid;

	private static IntPtr CloseLoadingScreen_FunctionAddress;

	private static int CloseLoadingScreen_ParamsSize;

	private static bool CanFadeAway_IsValid;

	private static IntPtr CanFadeAway_FunctionAddress;

	private static int CanFadeAway_ParamsSize;

	private static bool CanFadeAway_ReturnValue_IsValid;

	private static FFieldAddress CanFadeAway_ReturnValue_PropertyAddress;

	private static int CanFadeAway_ReturnValue_Offset;

	private static bool BeginToggleLoadingTips_IsValid;

	private static IntPtr BeginToggleLoadingTips_FunctionAddress;

	private static int BeginToggleLoadingTips_ParamsSize;

	private static bool BeginToggleLoadingTips_InputComponent_IsValid;

	private static FFieldAddress BeginToggleLoadingTips_InputComponent_PropertyAddress;

	private static int BeginToggleLoadingTips_InputComponent_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:TravelURLHasOption")]
	public unsafe bool TravelURLHasOption(string Option)
	{
		CheckDestroyed();
		if (!TravelURLHasOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:TravelURLHasOption");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TravelURLHasOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TravelURLHasOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TravelURLHasOption_Option_Offset), 0, TravelURLHasOption_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeFunctionOptimized(base.Address, TravelURLHasOption_FunctionAddress, intPtr, TravelURLHasOption_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TravelURLHasOption_Option_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TravelURLHasOption_ReturnValue_Offset), 0, TravelURLHasOption_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:TravelURLHasHost")]
	public unsafe bool TravelURLHasHost()
	{
		CheckDestroyed();
		if (!TravelURLHasHost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:TravelURLHasHost");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TravelURLHasHost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TravelURLHasHost_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, TravelURLHasHost_FunctionAddress, intPtr, TravelURLHasHost_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TravelURLHasHost_ReturnValue_Offset), 0, TravelURLHasHost_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:SwitchLoadingScreenThread")]
	public unsafe void SwitchLoadingScreenThread(bool UseSlateThread)
	{
		CheckDestroyed();
		if (!SwitchLoadingScreenThread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:SwitchLoadingScreenThread");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchLoadingScreenThread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchLoadingScreenThread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchLoadingScreenThread_UseSlateThread_Offset), 0, SwitchLoadingScreenThread_UseSlateThread_PropertyAddress.Address, UseSlateThread);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchLoadingScreenThread_FunctionAddress, intPtr, SwitchLoadingScreenThread_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:StartGameInstanceForCS")]
	public unsafe void StartGameInstanceForCS(EStartGameInstanceTypeForCS StartType)
	{
		CheckDestroyed();
		if (!StartGameInstanceForCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:StartGameInstanceForCS");
			return;
		}
		if (StartGameInstanceForCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			StartGameInstanceForCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "StartGameInstanceForCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartGameInstanceForCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartGameInstanceForCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EStartGameInstanceTypeForCS>.ToNative(IntPtr.Add(intPtr, StartGameInstanceForCS_StartType_Offset), 0, StartGameInstanceForCS_StartType_PropertyAddress.Address, StartType);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartGameInstanceForCS_InstanceFunctionAddress, intPtr, StartGameInstanceForCS_ParamsSize);
	}

	protected unsafe virtual void StartGameInstanceForCS_Implementation(EStartGameInstanceTypeForCS StartType)
	{
		CheckDestroyed();
		if (!StartGameInstanceForCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:StartGameInstanceForCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartGameInstanceForCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartGameInstanceForCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EStartGameInstanceTypeForCS>.ToNative(IntPtr.Add(intPtr, StartGameInstanceForCS_StartType_Offset), 0, StartGameInstanceForCS_StartType_PropertyAddress.Address, StartType);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartGameInstanceForCS_FunctionAddress, intPtr, StartGameInstanceForCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:RequestFadeAway")]
	public unsafe void RequestFadeAway()
	{
		CheckDestroyed();
		if (!RequestFadeAway_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:RequestFadeAway");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestFadeAway_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestFadeAway_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestFadeAway_FunctionAddress, argsSize: RequestFadeAway_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:RegisterLoadingTipsMask")]
	public unsafe void RegisterLoadingTipsMask(UTexture2D MaskTexture)
	{
		CheckDestroyed();
		if (!RegisterLoadingTipsMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:RegisterLoadingTipsMask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterLoadingTipsMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterLoadingTipsMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, RegisterLoadingTipsMask_MaskTexture_Offset), 0, RegisterLoadingTipsMask_MaskTexture_PropertyAddress.Address, MaskTexture);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterLoadingTipsMask_FunctionAddress, intPtr, RegisterLoadingTipsMask_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:RegisterLoadingTipsInfo")]
	public unsafe void RegisterLoadingTipsInfo(FLoadingTipsInfo TipsInfo)
	{
		CheckDestroyed();
		if (!RegisterLoadingTipsInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:RegisterLoadingTipsInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterLoadingTipsInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterLoadingTipsInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RegisterLoadingTipsInfo_TipsInfo_PropertyAddress.Address, intPtr);
		FLoadingTipsInfo.ToNative(IntPtr.Add(intPtr, RegisterLoadingTipsInfo_TipsInfo_Offset), 0, RegisterLoadingTipsInfo_TipsInfo_PropertyAddress.Address, TipsInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterLoadingTipsInfo_FunctionAddress, intPtr, RegisterLoadingTipsInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RegisterLoadingTipsInfo_TipsInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:RegisterChapterInfo")]
	public unsafe void RegisterChapterInfo(FChapterInfo ChapterInfo)
	{
		CheckDestroyed();
		if (!RegisterChapterInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:RegisterChapterInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterChapterInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterChapterInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RegisterChapterInfo_ChapterInfo_PropertyAddress.Address, intPtr);
		FChapterInfo.ToNative(IntPtr.Add(intPtr, RegisterChapterInfo_ChapterInfo_Offset), 0, RegisterChapterInfo_ChapterInfo_PropertyAddress.Address, ChapterInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterChapterInfo_FunctionAddress, intPtr, RegisterChapterInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RegisterChapterInfo_ChapterInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:RegisterBossRushInfo")]
	public unsafe void RegisterBossRushInfo(FBossRushInfo BossRushInfo)
	{
		CheckDestroyed();
		if (!RegisterBossRushInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:RegisterBossRushInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterBossRushInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterBossRushInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RegisterBossRushInfo_BossRushInfo_PropertyAddress.Address, intPtr);
		FBossRushInfo.ToNative(IntPtr.Add(intPtr, RegisterBossRushInfo_BossRushInfo_Offset), 0, RegisterBossRushInfo_BossRushInfo_PropertyAddress.Address, BossRushInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterBossRushInfo_FunctionAddress, intPtr, RegisterBossRushInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RegisterBossRushInfo_BossRushInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:ReceiveTickEvenWhenPaused")]
	public unsafe void ReceiveTickEvenWhenPaused(float DeltaSeconds, int TickGroup)
	{
		CheckDestroyed();
		if (!ReceiveTickEvenWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:ReceiveTickEvenWhenPaused");
			return;
		}
		if (ReceiveTickEvenWhenPaused_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveTickEvenWhenPaused_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveTickEvenWhenPaused");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTickEvenWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTickEvenWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTickEvenWhenPaused_DeltaSeconds_Offset), 0, ReceiveTickEvenWhenPaused_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveTickEvenWhenPaused_TickGroup_Offset), 0, ReceiveTickEvenWhenPaused_TickGroup_PropertyAddress.Address, TickGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTickEvenWhenPaused_InstanceFunctionAddress, intPtr, ReceiveTickEvenWhenPaused_ParamsSize);
	}

	protected unsafe virtual void ReceiveTickEvenWhenPaused_Implementation(float DeltaSeconds, int TickGroup)
	{
		CheckDestroyed();
		if (!ReceiveTickEvenWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:ReceiveTickEvenWhenPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTickEvenWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTickEvenWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTickEvenWhenPaused_DeltaSeconds_Offset), 0, ReceiveTickEvenWhenPaused_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveTickEvenWhenPaused_TickGroup_Offset), 0, ReceiveTickEvenWhenPaused_TickGroup_PropertyAddress.Address, TickGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTickEvenWhenPaused_FunctionAddress, intPtr, ReceiveTickEvenWhenPaused_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:ReceiveTick")]
	public unsafe void ReceiveTick(float DeltaSeconds, int TickGroup)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:ReceiveTick");
			return;
		}
		if (ReceiveTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTick_DeltaSeconds_Offset), 0, ReceiveTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveTick_TickGroup_Offset), 0, ReceiveTick_TickGroup_PropertyAddress.Address, TickGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTick_InstanceFunctionAddress, intPtr, ReceiveTick_ParamsSize);
	}

	protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds, int TickGroup)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:ReceiveTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTick_DeltaSeconds_Offset), 0, ReceiveTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveTick_TickGroup_Offset), 0, ReceiveTick_TickGroup_PropertyAddress.Address, TickGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTick_FunctionAddress, intPtr, ReceiveTick_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:ProcessNianHuiLogic")]
	public unsafe void ProcessNianHuiLogic()
	{
		CheckDestroyed();
		if (!ProcessNianHuiLogic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:ProcessNianHuiLogic");
			return;
		}
		if (ProcessNianHuiLogic_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProcessNianHuiLogic_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProcessNianHuiLogic");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessNianHuiLogic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessNianHuiLogic_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ProcessNianHuiLogic_InstanceFunctionAddress, argsSize: ProcessNianHuiLogic_ParamsSize);
	}

	protected unsafe virtual void ProcessNianHuiLogic_Implementation()
	{
		CheckDestroyed();
		if (!ProcessNianHuiLogic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:ProcessNianHuiLogic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessNianHuiLogic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessNianHuiLogic_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ProcessNianHuiLogic_FunctionAddress, argsSize: ProcessNianHuiLogic_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:PrepareFadeAway")]
	public unsafe void PrepareFadeAway()
	{
		CheckDestroyed();
		if (!PrepareFadeAway_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:PrepareFadeAway");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrepareFadeAway_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrepareFadeAway_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PrepareFadeAway_FunctionAddress, argsSize: PrepareFadeAway_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:OpenLoadingScreen")]
	public unsafe void OpenLoadingScreen(bool UseSlateThread, EGSLoadingScreenType LoadingScreenType)
	{
		CheckDestroyed();
		if (!OpenLoadingScreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OpenLoadingScreen");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenLoadingScreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenLoadingScreen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OpenLoadingScreen_UseSlateThread_Offset), 0, OpenLoadingScreen_UseSlateThread_PropertyAddress.Address, UseSlateThread);
		EnumMarshaler<EGSLoadingScreenType>.ToNative(IntPtr.Add(intPtr, OpenLoadingScreen_LoadingScreenType_Offset), 0, OpenLoadingScreen_LoadingScreenType_PropertyAddress.Address, LoadingScreenType);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenLoadingScreen_FunctionAddress, intPtr, OpenLoadingScreen_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:OnWorldTickStartCS")]
	public unsafe void OnWorldTickStartCS(UWorld World)
	{
		CheckDestroyed();
		if (!OnWorldTickStartCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OnWorldTickStartCS");
			return;
		}
		if (OnWorldTickStartCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWorldTickStartCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWorldTickStartCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldTickStartCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldTickStartCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldTickStartCS_World_Offset), 0, OnWorldTickStartCS_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldTickStartCS_InstanceFunctionAddress, intPtr, OnWorldTickStartCS_ParamsSize);
	}

	protected unsafe virtual void OnWorldTickStartCS_Implementation(UWorld World)
	{
		CheckDestroyed();
		if (!OnWorldTickStartCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OnWorldTickStartCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldTickStartCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldTickStartCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldTickStartCS_World_Offset), 0, OnWorldTickStartCS_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldTickStartCS_FunctionAddress, intPtr, OnWorldTickStartCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:OnWorldChangedCS")]
	public unsafe void OnWorldChangedCS(UWorld OldWorld, UWorld NewWorld)
	{
		CheckDestroyed();
		if (!OnWorldChangedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OnWorldChangedCS");
			return;
		}
		if (OnWorldChangedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWorldChangedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWorldChangedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldChangedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldChangedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldChangedCS_OldWorld_Offset), 0, OnWorldChangedCS_OldWorld_PropertyAddress.Address, OldWorld);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldChangedCS_NewWorld_Offset), 0, OnWorldChangedCS_NewWorld_PropertyAddress.Address, NewWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldChangedCS_InstanceFunctionAddress, intPtr, OnWorldChangedCS_ParamsSize);
	}

	protected unsafe virtual void OnWorldChangedCS_Implementation(UWorld OldWorld, UWorld NewWorld)
	{
		CheckDestroyed();
		if (!OnWorldChangedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OnWorldChangedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldChangedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldChangedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldChangedCS_OldWorld_Offset), 0, OnWorldChangedCS_OldWorld_PropertyAddress.Address, OldWorld);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldChangedCS_NewWorld_Offset), 0, OnWorldChangedCS_NewWorld_PropertyAddress.Address, NewWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldChangedCS_FunctionAddress, intPtr, OnWorldChangedCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:OnPostActorTickCS")]
	public unsafe void OnPostActorTickCS(UWorld World)
	{
		CheckDestroyed();
		if (!OnPostActorTickCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OnPostActorTickCS");
			return;
		}
		if (OnPostActorTickCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostActorTickCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPostActorTickCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostActorTickCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostActorTickCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnPostActorTickCS_World_Offset), 0, OnPostActorTickCS_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostActorTickCS_InstanceFunctionAddress, intPtr, OnPostActorTickCS_ParamsSize);
	}

	protected unsafe virtual void OnPostActorTickCS_Implementation(UWorld World)
	{
		CheckDestroyed();
		if (!OnPostActorTickCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OnPostActorTickCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostActorTickCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostActorTickCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnPostActorTickCS_World_Offset), 0, OnPostActorTickCS_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPostActorTickCS_FunctionAddress, intPtr, OnPostActorTickCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:OnGameModeMatchStateSetCS")]
	public unsafe void OnGameModeMatchStateSetCS(FName NewMatchState)
	{
		CheckDestroyed();
		if (!OnGameModeMatchStateSetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OnGameModeMatchStateSetCS");
			return;
		}
		if (OnGameModeMatchStateSetCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnGameModeMatchStateSetCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnGameModeMatchStateSetCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGameModeMatchStateSetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGameModeMatchStateSetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnGameModeMatchStateSetCS_NewMatchState_Offset), 0, OnGameModeMatchStateSetCS_NewMatchState_PropertyAddress.Address, NewMatchState);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGameModeMatchStateSetCS_InstanceFunctionAddress, intPtr, OnGameModeMatchStateSetCS_ParamsSize);
	}

	protected unsafe virtual void OnGameModeMatchStateSetCS_Implementation(FName NewMatchState)
	{
		CheckDestroyed();
		if (!OnGameModeMatchStateSetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:OnGameModeMatchStateSetCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGameModeMatchStateSetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGameModeMatchStateSetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnGameModeMatchStateSetCS_NewMatchState_Offset), 0, OnGameModeMatchStateSetCS_NewMatchState_PropertyAddress.Address, NewMatchState);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGameModeMatchStateSetCS_FunctionAddress, intPtr, OnGameModeMatchStateSetCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:IsToggleLoadingTipsFinish")]
	public unsafe bool IsToggleLoadingTipsFinish()
	{
		CheckDestroyed();
		if (!IsToggleLoadingTipsFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:IsToggleLoadingTipsFinish");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsToggleLoadingTipsFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsToggleLoadingTipsFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsToggleLoadingTipsFinish_FunctionAddress, intPtr, IsToggleLoadingTipsFinish_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsToggleLoadingTipsFinish_ReturnValue_Offset), 0, IsToggleLoadingTipsFinish_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:IsLoadingScreenFadeAwayFinish")]
	public unsafe bool IsLoadingScreenFadeAwayFinish()
	{
		CheckDestroyed();
		if (!IsLoadingScreenFadeAwayFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:IsLoadingScreenFadeAwayFinish");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLoadingScreenFadeAwayFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLoadingScreenFadeAwayFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLoadingScreenFadeAwayFinish_FunctionAddress, intPtr, IsLoadingScreenFadeAwayFinish_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLoadingScreenFadeAwayFinish_ReturnValue_Offset), 0, IsLoadingScreenFadeAwayFinish_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetWorldForCS")]
	public unsafe UWorld GetWorldForCS()
	{
		CheckDestroyed();
		if (!GetWorldForCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetWorldForCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldForCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldForCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldForCS_FunctionAddress, intPtr, GetWorldForCS_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetWorldForCS_ReturnValue_Offset), 0, GetWorldForCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetTravelURLHost")]
	public unsafe string GetTravelURLHost()
	{
		CheckDestroyed();
		if (!GetTravelURLHost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetTravelURLHost");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTravelURLHost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTravelURLHost_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTravelURLHost_FunctionAddress, intPtr, GetTravelURLHost_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTravelURLHost_ReturnValue_Offset), 0, GetTravelURLHost_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTravelURLHost_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetTravelURLForCS")]
	public unsafe string GetTravelURLForCS()
	{
		CheckDestroyed();
		if (!GetTravelURLForCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetTravelURLForCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTravelURLForCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTravelURLForCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTravelURLForCS_FunctionAddress, intPtr, GetTravelURLForCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTravelURLForCS_ReturnValue_Offset), 0, GetTravelURLForCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTravelURLForCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetTimeInMSSinceLoadingOpen")]
	public unsafe double GetTimeInMSSinceLoadingOpen()
	{
		CheckDestroyed();
		if (!GetTimeInMSSinceLoadingOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetTimeInMSSinceLoadingOpen");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimeInMSSinceLoadingOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimeInMSSinceLoadingOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTimeInMSSinceLoadingOpen_FunctionAddress, intPtr, GetTimeInMSSinceLoadingOpen_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetTimeInMSSinceLoadingOpen_ReturnValue_Offset), 0, GetTimeInMSSinceLoadingOpen_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetOnlineSessionClassCS")]
	public unsafe TSubclassOf<UOnlineSession> GetOnlineSessionClassCS()
	{
		CheckDestroyed();
		if (!GetOnlineSessionClassCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetOnlineSessionClassCS");
			return default(TSubclassOf<UOnlineSession>);
		}
		if (GetOnlineSessionClassCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetOnlineSessionClassCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetOnlineSessionClassCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOnlineSessionClassCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOnlineSessionClassCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOnlineSessionClassCS_InstanceFunctionAddress, intPtr, GetOnlineSessionClassCS_ParamsSize);
		return TSubclassOfMarshaler<UOnlineSession>.FromNative(IntPtr.Add(intPtr, GetOnlineSessionClassCS_ReturnValue_Offset), 0, GetOnlineSessionClassCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual TSubclassOf<UOnlineSession> GetOnlineSessionClassCS_Implementation()
	{
		CheckDestroyed();
		if (!GetOnlineSessionClassCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetOnlineSessionClassCS");
			return default(TSubclassOf<UOnlineSession>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOnlineSessionClassCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOnlineSessionClassCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOnlineSessionClassCS_FunctionAddress, intPtr, GetOnlineSessionClassCS_ParamsSize);
		return TSubclassOfMarshaler<UOnlineSession>.FromNative(IntPtr.Add(intPtr, GetOnlineSessionClassCS_ReturnValue_Offset), 0, GetOnlineSessionClassCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetLastUseTips")]
	public unsafe List<int> GetLastUseTips()
	{
		CheckDestroyed();
		if (!GetLastUseTips_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetLastUseTips");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastUseTips_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastUseTips_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastUseTips_FunctionAddress, intPtr, GetLastUseTips_ParamsSize);
		List<int> result = new TArrayCopyMarshaler<int>(1, GetLastUseTips_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLastUseTips_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLastUseTips_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetFirstGamePlayerForCS")]
	public unsafe ULocalPlayer GetFirstGamePlayerForCS()
	{
		CheckDestroyed();
		if (!GetFirstGamePlayerForCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetFirstGamePlayerForCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFirstGamePlayerForCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFirstGamePlayerForCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFirstGamePlayerForCS_FunctionAddress, intPtr, GetFirstGamePlayerForCS_ParamsSize);
		return UObjectMarshaler<ULocalPlayer>.FromNative(IntPtr.Add(intPtr, GetFirstGamePlayerForCS_ReturnValue_Offset), 0, GetFirstGamePlayerForCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetEvents")]
	public unsafe UBGW_EventCollection GetEvents()
	{
		CheckDestroyed();
		if (!GetEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetEvents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEvents_FunctionAddress, intPtr, GetEvents_ParamsSize);
		return UObjectMarshaler<UBGW_EventCollection>.FromNative(IntPtr.Add(intPtr, GetEvents_ReturnValue_Offset), 0, GetEvents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetCurLoadingScreenType")]
	public unsafe EGSLoadingScreenType GetCurLoadingScreenType()
	{
		CheckDestroyed();
		if (!GetCurLoadingScreenType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetCurLoadingScreenType");
			return EGSLoadingScreenType.Unknown;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurLoadingScreenType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurLoadingScreenType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurLoadingScreenType_FunctionAddress, intPtr, GetCurLoadingScreenType_ParamsSize);
		return EnumMarshaler<EGSLoadingScreenType>.FromNative(IntPtr.Add(intPtr, GetCurLoadingScreenType_ReturnValue_Offset), 0, GetCurLoadingScreenType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:GetCurLoadingScreenState")]
	public unsafe EGSLoadingScreenState GetCurLoadingScreenState()
	{
		CheckDestroyed();
		if (!GetCurLoadingScreenState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:GetCurLoadingScreenState");
			return EGSLoadingScreenState.Idle;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurLoadingScreenState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurLoadingScreenState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurLoadingScreenState_FunctionAddress, intPtr, GetCurLoadingScreenState_ParamsSize);
		return EnumMarshaler<EGSLoadingScreenState>.FromNative(IntPtr.Add(intPtr, GetCurLoadingScreenState_ReturnValue_Offset), 0, GetCurLoadingScreenState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:CloseLoadingScreen")]
	public unsafe void CloseLoadingScreen()
	{
		CheckDestroyed();
		if (!CloseLoadingScreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:CloseLoadingScreen");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseLoadingScreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseLoadingScreen_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CloseLoadingScreen_FunctionAddress, argsSize: CloseLoadingScreen_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:CanFadeAway")]
	public unsafe bool CanFadeAway()
	{
		CheckDestroyed();
		if (!CanFadeAway_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:CanFadeAway");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanFadeAway_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanFadeAway_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanFadeAway_FunctionAddress, intPtr, CanFadeAway_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanFadeAway_ReturnValue_Offset), 0, CanFadeAway_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWGameInstance:BeginToggleLoadingTips")]
	public unsafe void BeginToggleLoadingTips(UGSInputComponent InputComponent)
	{
		CheckDestroyed();
		if (!BeginToggleLoadingTips_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameInstance:BeginToggleLoadingTips");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginToggleLoadingTips_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginToggleLoadingTips_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSInputComponent>.ToNative(IntPtr.Add(intPtr, BeginToggleLoadingTips_InputComponent_Offset), 0, BeginToggleLoadingTips_InputComponent_PropertyAddress.Address, InputComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginToggleLoadingTips_FunctionAddress, intPtr, BeginToggleLoadingTips_ParamsSize);
	}

	static UBGWGameInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWGameInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWGameInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWGameInstance");
		TravelURLHasOption_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TravelURLHasOption");
		TravelURLHasOption_ParamsSize = NativeReflection.GetFunctionParamsSize(TravelURLHasOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TravelURLHasOption_Option_PropertyAddress, TravelURLHasOption_FunctionAddress, "Option");
		TravelURLHasOption_Option_Offset = NativeReflectionCached.GetPropertyOffset(TravelURLHasOption_FunctionAddress, "Option");
		TravelURLHasOption_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(TravelURLHasOption_FunctionAddress, "Option", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TravelURLHasOption_ReturnValue_PropertyAddress, TravelURLHasOption_FunctionAddress, "ReturnValue");
		TravelURLHasOption_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TravelURLHasOption_FunctionAddress, "ReturnValue");
		TravelURLHasOption_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TravelURLHasOption_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TravelURLHasOption_IsValid = TravelURLHasOption_FunctionAddress != IntPtr.Zero && TravelURLHasOption_Option_IsValid && TravelURLHasOption_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:TravelURLHasOption", TravelURLHasOption_IsValid);
		TravelURLHasHost_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TravelURLHasHost");
		TravelURLHasHost_ParamsSize = NativeReflection.GetFunctionParamsSize(TravelURLHasHost_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TravelURLHasHost_ReturnValue_PropertyAddress, TravelURLHasHost_FunctionAddress, "ReturnValue");
		TravelURLHasHost_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TravelURLHasHost_FunctionAddress, "ReturnValue");
		TravelURLHasHost_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TravelURLHasHost_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TravelURLHasHost_IsValid = TravelURLHasHost_FunctionAddress != IntPtr.Zero && TravelURLHasHost_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:TravelURLHasHost", TravelURLHasHost_IsValid);
		SwitchLoadingScreenThread_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SwitchLoadingScreenThread");
		SwitchLoadingScreenThread_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchLoadingScreenThread_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchLoadingScreenThread_UseSlateThread_PropertyAddress, SwitchLoadingScreenThread_FunctionAddress, "UseSlateThread");
		SwitchLoadingScreenThread_UseSlateThread_Offset = NativeReflectionCached.GetPropertyOffset(SwitchLoadingScreenThread_FunctionAddress, "UseSlateThread");
		SwitchLoadingScreenThread_UseSlateThread_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchLoadingScreenThread_FunctionAddress, "UseSlateThread", Classes.FBoolProperty);
		SwitchLoadingScreenThread_IsValid = SwitchLoadingScreenThread_FunctionAddress != IntPtr.Zero && SwitchLoadingScreenThread_UseSlateThread_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:SwitchLoadingScreenThread", SwitchLoadingScreenThread_IsValid);
		StartGameInstanceForCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartGameInstanceForCS");
		StartGameInstanceForCS_ParamsSize = NativeReflection.GetFunctionParamsSize(StartGameInstanceForCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartGameInstanceForCS_StartType_PropertyAddress, StartGameInstanceForCS_FunctionAddress, "StartType");
		StartGameInstanceForCS_StartType_Offset = NativeReflectionCached.GetPropertyOffset(StartGameInstanceForCS_FunctionAddress, "StartType");
		StartGameInstanceForCS_StartType_IsValid = NativeReflectionCached.ValidatePropertyClass(StartGameInstanceForCS_FunctionAddress, "StartType", Classes.FByteProperty);
		StartGameInstanceForCS_IsValid = StartGameInstanceForCS_FunctionAddress != IntPtr.Zero && StartGameInstanceForCS_StartType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:StartGameInstanceForCS", StartGameInstanceForCS_IsValid);
		RequestFadeAway_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RequestFadeAway");
		RequestFadeAway_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestFadeAway_FunctionAddress);
		RequestFadeAway_IsValid = RequestFadeAway_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:RequestFadeAway", RequestFadeAway_IsValid);
		RegisterLoadingTipsMask_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegisterLoadingTipsMask");
		RegisterLoadingTipsMask_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterLoadingTipsMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterLoadingTipsMask_MaskTexture_PropertyAddress, RegisterLoadingTipsMask_FunctionAddress, "MaskTexture");
		RegisterLoadingTipsMask_MaskTexture_Offset = NativeReflectionCached.GetPropertyOffset(RegisterLoadingTipsMask_FunctionAddress, "MaskTexture");
		RegisterLoadingTipsMask_MaskTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterLoadingTipsMask_FunctionAddress, "MaskTexture", Classes.FObjectProperty);
		RegisterLoadingTipsMask_IsValid = RegisterLoadingTipsMask_FunctionAddress != IntPtr.Zero && RegisterLoadingTipsMask_MaskTexture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:RegisterLoadingTipsMask", RegisterLoadingTipsMask_IsValid);
		RegisterLoadingTipsInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegisterLoadingTipsInfo");
		RegisterLoadingTipsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterLoadingTipsInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterLoadingTipsInfo_TipsInfo_PropertyAddress, RegisterLoadingTipsInfo_FunctionAddress, "TipsInfo");
		RegisterLoadingTipsInfo_TipsInfo_Offset = NativeReflectionCached.GetPropertyOffset(RegisterLoadingTipsInfo_FunctionAddress, "TipsInfo");
		RegisterLoadingTipsInfo_TipsInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterLoadingTipsInfo_FunctionAddress, "TipsInfo", Classes.FStructProperty);
		RegisterLoadingTipsInfo_IsValid = RegisterLoadingTipsInfo_FunctionAddress != IntPtr.Zero && RegisterLoadingTipsInfo_TipsInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:RegisterLoadingTipsInfo", RegisterLoadingTipsInfo_IsValid);
		RegisterChapterInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegisterChapterInfo");
		RegisterChapterInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterChapterInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterChapterInfo_ChapterInfo_PropertyAddress, RegisterChapterInfo_FunctionAddress, "ChapterInfo");
		RegisterChapterInfo_ChapterInfo_Offset = NativeReflectionCached.GetPropertyOffset(RegisterChapterInfo_FunctionAddress, "ChapterInfo");
		RegisterChapterInfo_ChapterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterChapterInfo_FunctionAddress, "ChapterInfo", Classes.FStructProperty);
		RegisterChapterInfo_IsValid = RegisterChapterInfo_FunctionAddress != IntPtr.Zero && RegisterChapterInfo_ChapterInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:RegisterChapterInfo", RegisterChapterInfo_IsValid);
		RegisterBossRushInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegisterBossRushInfo");
		RegisterBossRushInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterBossRushInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterBossRushInfo_BossRushInfo_PropertyAddress, RegisterBossRushInfo_FunctionAddress, "BossRushInfo");
		RegisterBossRushInfo_BossRushInfo_Offset = NativeReflectionCached.GetPropertyOffset(RegisterBossRushInfo_FunctionAddress, "BossRushInfo");
		RegisterBossRushInfo_BossRushInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterBossRushInfo_FunctionAddress, "BossRushInfo", Classes.FStructProperty);
		RegisterBossRushInfo_IsValid = RegisterBossRushInfo_FunctionAddress != IntPtr.Zero && RegisterBossRushInfo_BossRushInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:RegisterBossRushInfo", RegisterBossRushInfo_IsValid);
		ReceiveTickEvenWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveTickEvenWhenPaused");
		ReceiveTickEvenWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTickEvenWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTickEvenWhenPaused_DeltaSeconds_PropertyAddress, ReceiveTickEvenWhenPaused_FunctionAddress, "DeltaSeconds");
		ReceiveTickEvenWhenPaused_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTickEvenWhenPaused_FunctionAddress, "DeltaSeconds");
		ReceiveTickEvenWhenPaused_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTickEvenWhenPaused_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTickEvenWhenPaused_TickGroup_PropertyAddress, ReceiveTickEvenWhenPaused_FunctionAddress, "TickGroup");
		ReceiveTickEvenWhenPaused_TickGroup_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTickEvenWhenPaused_FunctionAddress, "TickGroup");
		ReceiveTickEvenWhenPaused_TickGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTickEvenWhenPaused_FunctionAddress, "TickGroup", Classes.FIntProperty);
		ReceiveTickEvenWhenPaused_IsValid = ReceiveTickEvenWhenPaused_FunctionAddress != IntPtr.Zero && ReceiveTickEvenWhenPaused_DeltaSeconds_IsValid && ReceiveTickEvenWhenPaused_TickGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:ReceiveTickEvenWhenPaused", ReceiveTickEvenWhenPaused_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_DeltaSeconds_PropertyAddress, ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_TickGroup_PropertyAddress, ReceiveTick_FunctionAddress, "TickGroup");
		ReceiveTick_TickGroup_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "TickGroup");
		ReceiveTick_TickGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "TickGroup", Classes.FIntProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid && ReceiveTick_TickGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:ReceiveTick", ReceiveTick_IsValid);
		ProcessNianHuiLogic_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProcessNianHuiLogic");
		ProcessNianHuiLogic_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessNianHuiLogic_FunctionAddress);
		ProcessNianHuiLogic_IsValid = ProcessNianHuiLogic_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:ProcessNianHuiLogic", ProcessNianHuiLogic_IsValid);
		PrepareFadeAway_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PrepareFadeAway");
		PrepareFadeAway_ParamsSize = NativeReflection.GetFunctionParamsSize(PrepareFadeAway_FunctionAddress);
		PrepareFadeAway_IsValid = PrepareFadeAway_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:PrepareFadeAway", PrepareFadeAway_IsValid);
		OpenLoadingScreen_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OpenLoadingScreen");
		OpenLoadingScreen_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenLoadingScreen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenLoadingScreen_UseSlateThread_PropertyAddress, OpenLoadingScreen_FunctionAddress, "UseSlateThread");
		OpenLoadingScreen_UseSlateThread_Offset = NativeReflectionCached.GetPropertyOffset(OpenLoadingScreen_FunctionAddress, "UseSlateThread");
		OpenLoadingScreen_UseSlateThread_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenLoadingScreen_FunctionAddress, "UseSlateThread", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenLoadingScreen_LoadingScreenType_PropertyAddress, OpenLoadingScreen_FunctionAddress, "LoadingScreenType");
		OpenLoadingScreen_LoadingScreenType_Offset = NativeReflectionCached.GetPropertyOffset(OpenLoadingScreen_FunctionAddress, "LoadingScreenType");
		OpenLoadingScreen_LoadingScreenType_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenLoadingScreen_FunctionAddress, "LoadingScreenType", Classes.FEnumProperty);
		OpenLoadingScreen_IsValid = OpenLoadingScreen_FunctionAddress != IntPtr.Zero && OpenLoadingScreen_UseSlateThread_IsValid && OpenLoadingScreen_LoadingScreenType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:OpenLoadingScreen", OpenLoadingScreen_IsValid);
		OnWorldTickStartCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWorldTickStartCS");
		OnWorldTickStartCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldTickStartCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWorldTickStartCS_World_PropertyAddress, OnWorldTickStartCS_FunctionAddress, "World");
		OnWorldTickStartCS_World_Offset = NativeReflectionCached.GetPropertyOffset(OnWorldTickStartCS_FunctionAddress, "World");
		OnWorldTickStartCS_World_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWorldTickStartCS_FunctionAddress, "World", Classes.FObjectProperty);
		OnWorldTickStartCS_IsValid = OnWorldTickStartCS_FunctionAddress != IntPtr.Zero && OnWorldTickStartCS_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:OnWorldTickStartCS", OnWorldTickStartCS_IsValid);
		OnWorldChangedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWorldChangedCS");
		OnWorldChangedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldChangedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWorldChangedCS_OldWorld_PropertyAddress, OnWorldChangedCS_FunctionAddress, "OldWorld");
		OnWorldChangedCS_OldWorld_Offset = NativeReflectionCached.GetPropertyOffset(OnWorldChangedCS_FunctionAddress, "OldWorld");
		OnWorldChangedCS_OldWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWorldChangedCS_FunctionAddress, "OldWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnWorldChangedCS_NewWorld_PropertyAddress, OnWorldChangedCS_FunctionAddress, "NewWorld");
		OnWorldChangedCS_NewWorld_Offset = NativeReflectionCached.GetPropertyOffset(OnWorldChangedCS_FunctionAddress, "NewWorld");
		OnWorldChangedCS_NewWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWorldChangedCS_FunctionAddress, "NewWorld", Classes.FObjectProperty);
		OnWorldChangedCS_IsValid = OnWorldChangedCS_FunctionAddress != IntPtr.Zero && OnWorldChangedCS_OldWorld_IsValid && OnWorldChangedCS_NewWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:OnWorldChangedCS", OnWorldChangedCS_IsValid);
		OnPostActorTickCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPostActorTickCS");
		OnPostActorTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostActorTickCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPostActorTickCS_World_PropertyAddress, OnPostActorTickCS_FunctionAddress, "World");
		OnPostActorTickCS_World_Offset = NativeReflectionCached.GetPropertyOffset(OnPostActorTickCS_FunctionAddress, "World");
		OnPostActorTickCS_World_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPostActorTickCS_FunctionAddress, "World", Classes.FObjectProperty);
		OnPostActorTickCS_IsValid = OnPostActorTickCS_FunctionAddress != IntPtr.Zero && OnPostActorTickCS_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:OnPostActorTickCS", OnPostActorTickCS_IsValid);
		OnGameModeMatchStateSetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnGameModeMatchStateSetCS");
		OnGameModeMatchStateSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGameModeMatchStateSetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGameModeMatchStateSetCS_NewMatchState_PropertyAddress, OnGameModeMatchStateSetCS_FunctionAddress, "NewMatchState");
		OnGameModeMatchStateSetCS_NewMatchState_Offset = NativeReflectionCached.GetPropertyOffset(OnGameModeMatchStateSetCS_FunctionAddress, "NewMatchState");
		OnGameModeMatchStateSetCS_NewMatchState_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGameModeMatchStateSetCS_FunctionAddress, "NewMatchState", Classes.FNameProperty);
		OnGameModeMatchStateSetCS_IsValid = OnGameModeMatchStateSetCS_FunctionAddress != IntPtr.Zero && OnGameModeMatchStateSetCS_NewMatchState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:OnGameModeMatchStateSetCS", OnGameModeMatchStateSetCS_IsValid);
		IsToggleLoadingTipsFinish_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsToggleLoadingTipsFinish");
		IsToggleLoadingTipsFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(IsToggleLoadingTipsFinish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsToggleLoadingTipsFinish_ReturnValue_PropertyAddress, IsToggleLoadingTipsFinish_FunctionAddress, "ReturnValue");
		IsToggleLoadingTipsFinish_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsToggleLoadingTipsFinish_FunctionAddress, "ReturnValue");
		IsToggleLoadingTipsFinish_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsToggleLoadingTipsFinish_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsToggleLoadingTipsFinish_IsValid = IsToggleLoadingTipsFinish_FunctionAddress != IntPtr.Zero && IsToggleLoadingTipsFinish_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:IsToggleLoadingTipsFinish", IsToggleLoadingTipsFinish_IsValid);
		IsLoadingScreenFadeAwayFinish_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLoadingScreenFadeAwayFinish");
		IsLoadingScreenFadeAwayFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLoadingScreenFadeAwayFinish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLoadingScreenFadeAwayFinish_ReturnValue_PropertyAddress, IsLoadingScreenFadeAwayFinish_FunctionAddress, "ReturnValue");
		IsLoadingScreenFadeAwayFinish_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLoadingScreenFadeAwayFinish_FunctionAddress, "ReturnValue");
		IsLoadingScreenFadeAwayFinish_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLoadingScreenFadeAwayFinish_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLoadingScreenFadeAwayFinish_IsValid = IsLoadingScreenFadeAwayFinish_FunctionAddress != IntPtr.Zero && IsLoadingScreenFadeAwayFinish_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:IsLoadingScreenFadeAwayFinish", IsLoadingScreenFadeAwayFinish_IsValid);
		GetWorldForCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWorldForCS");
		GetWorldForCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldForCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldForCS_ReturnValue_PropertyAddress, GetWorldForCS_FunctionAddress, "ReturnValue");
		GetWorldForCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldForCS_FunctionAddress, "ReturnValue");
		GetWorldForCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldForCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldForCS_IsValid = GetWorldForCS_FunctionAddress != IntPtr.Zero && GetWorldForCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetWorldForCS", GetWorldForCS_IsValid);
		GetTravelURLHost_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTravelURLHost");
		GetTravelURLHost_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTravelURLHost_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTravelURLHost_ReturnValue_PropertyAddress, GetTravelURLHost_FunctionAddress, "ReturnValue");
		GetTravelURLHost_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTravelURLHost_FunctionAddress, "ReturnValue");
		GetTravelURLHost_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTravelURLHost_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTravelURLHost_IsValid = GetTravelURLHost_FunctionAddress != IntPtr.Zero && GetTravelURLHost_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetTravelURLHost", GetTravelURLHost_IsValid);
		GetTravelURLForCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTravelURLForCS");
		GetTravelURLForCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTravelURLForCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTravelURLForCS_ReturnValue_PropertyAddress, GetTravelURLForCS_FunctionAddress, "ReturnValue");
		GetTravelURLForCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTravelURLForCS_FunctionAddress, "ReturnValue");
		GetTravelURLForCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTravelURLForCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTravelURLForCS_IsValid = GetTravelURLForCS_FunctionAddress != IntPtr.Zero && GetTravelURLForCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetTravelURLForCS", GetTravelURLForCS_IsValid);
		GetTimeInMSSinceLoadingOpen_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTimeInMSSinceLoadingOpen");
		GetTimeInMSSinceLoadingOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimeInMSSinceLoadingOpen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimeInMSSinceLoadingOpen_ReturnValue_PropertyAddress, GetTimeInMSSinceLoadingOpen_FunctionAddress, "ReturnValue");
		GetTimeInMSSinceLoadingOpen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeInMSSinceLoadingOpen_FunctionAddress, "ReturnValue");
		GetTimeInMSSinceLoadingOpen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeInMSSinceLoadingOpen_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetTimeInMSSinceLoadingOpen_IsValid = GetTimeInMSSinceLoadingOpen_FunctionAddress != IntPtr.Zero && GetTimeInMSSinceLoadingOpen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetTimeInMSSinceLoadingOpen", GetTimeInMSSinceLoadingOpen_IsValid);
		GetOnlineSessionClassCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOnlineSessionClassCS");
		GetOnlineSessionClassCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOnlineSessionClassCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOnlineSessionClassCS_ReturnValue_PropertyAddress, GetOnlineSessionClassCS_FunctionAddress, "ReturnValue");
		GetOnlineSessionClassCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOnlineSessionClassCS_FunctionAddress, "ReturnValue");
		GetOnlineSessionClassCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOnlineSessionClassCS_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetOnlineSessionClassCS_IsValid = GetOnlineSessionClassCS_FunctionAddress != IntPtr.Zero && GetOnlineSessionClassCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetOnlineSessionClassCS", GetOnlineSessionClassCS_IsValid);
		GetLastUseTips_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLastUseTips");
		GetLastUseTips_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastUseTips_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastUseTips_ReturnValue_PropertyAddress, GetLastUseTips_FunctionAddress, "ReturnValue");
		GetLastUseTips_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastUseTips_FunctionAddress, "ReturnValue");
		GetLastUseTips_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastUseTips_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLastUseTips_IsValid = GetLastUseTips_FunctionAddress != IntPtr.Zero && GetLastUseTips_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetLastUseTips", GetLastUseTips_IsValid);
		GetFirstGamePlayerForCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFirstGamePlayerForCS");
		GetFirstGamePlayerForCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFirstGamePlayerForCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFirstGamePlayerForCS_ReturnValue_PropertyAddress, GetFirstGamePlayerForCS_FunctionAddress, "ReturnValue");
		GetFirstGamePlayerForCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstGamePlayerForCS_FunctionAddress, "ReturnValue");
		GetFirstGamePlayerForCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstGamePlayerForCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFirstGamePlayerForCS_IsValid = GetFirstGamePlayerForCS_FunctionAddress != IntPtr.Zero && GetFirstGamePlayerForCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetFirstGamePlayerForCS", GetFirstGamePlayerForCS_IsValid);
		GetEvents_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEvents");
		GetEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEvents_ReturnValue_PropertyAddress, GetEvents_FunctionAddress, "ReturnValue");
		GetEvents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEvents_FunctionAddress, "ReturnValue");
		GetEvents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEvents_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEvents_IsValid = GetEvents_FunctionAddress != IntPtr.Zero && GetEvents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetEvents", GetEvents_IsValid);
		GetCurLoadingScreenType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurLoadingScreenType");
		GetCurLoadingScreenType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurLoadingScreenType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurLoadingScreenType_ReturnValue_PropertyAddress, GetCurLoadingScreenType_FunctionAddress, "ReturnValue");
		GetCurLoadingScreenType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurLoadingScreenType_FunctionAddress, "ReturnValue");
		GetCurLoadingScreenType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurLoadingScreenType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCurLoadingScreenType_IsValid = GetCurLoadingScreenType_FunctionAddress != IntPtr.Zero && GetCurLoadingScreenType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetCurLoadingScreenType", GetCurLoadingScreenType_IsValid);
		GetCurLoadingScreenState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurLoadingScreenState");
		GetCurLoadingScreenState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurLoadingScreenState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurLoadingScreenState_ReturnValue_PropertyAddress, GetCurLoadingScreenState_FunctionAddress, "ReturnValue");
		GetCurLoadingScreenState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurLoadingScreenState_FunctionAddress, "ReturnValue");
		GetCurLoadingScreenState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurLoadingScreenState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCurLoadingScreenState_IsValid = GetCurLoadingScreenState_FunctionAddress != IntPtr.Zero && GetCurLoadingScreenState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:GetCurLoadingScreenState", GetCurLoadingScreenState_IsValid);
		CloseLoadingScreen_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CloseLoadingScreen");
		CloseLoadingScreen_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseLoadingScreen_FunctionAddress);
		CloseLoadingScreen_IsValid = CloseLoadingScreen_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:CloseLoadingScreen", CloseLoadingScreen_IsValid);
		CanFadeAway_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanFadeAway");
		CanFadeAway_ParamsSize = NativeReflection.GetFunctionParamsSize(CanFadeAway_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanFadeAway_ReturnValue_PropertyAddress, CanFadeAway_FunctionAddress, "ReturnValue");
		CanFadeAway_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanFadeAway_FunctionAddress, "ReturnValue");
		CanFadeAway_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanFadeAway_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanFadeAway_IsValid = CanFadeAway_FunctionAddress != IntPtr.Zero && CanFadeAway_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:CanFadeAway", CanFadeAway_IsValid);
		BeginToggleLoadingTips_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginToggleLoadingTips");
		BeginToggleLoadingTips_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginToggleLoadingTips_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginToggleLoadingTips_InputComponent_PropertyAddress, BeginToggleLoadingTips_FunctionAddress, "InputComponent");
		BeginToggleLoadingTips_InputComponent_Offset = NativeReflectionCached.GetPropertyOffset(BeginToggleLoadingTips_FunctionAddress, "InputComponent");
		BeginToggleLoadingTips_InputComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginToggleLoadingTips_FunctionAddress, "InputComponent", Classes.FObjectProperty);
		BeginToggleLoadingTips_IsValid = BeginToggleLoadingTips_FunctionAddress != IntPtr.Zero && BeginToggleLoadingTips_InputComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameInstance:BeginToggleLoadingTips", BeginToggleLoadingTips_IsValid);
	}
}
