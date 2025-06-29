using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938540uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.GameMode", "Engine", UnrealModuleType.Engine)]
public class AGameMode : AGameModeBase
{
	private static bool DelayedStart_IsValid;

	private static FFieldAddress DelayedStart_PropertyAddress;

	private static int DelayedStart_Offset;

	private static bool NumSpectators_IsValid;

	private static int NumSpectators_Offset;

	private static bool NumPlayers_IsValid;

	private static int NumPlayers_Offset;

	private static bool NumBots_IsValid;

	private static int NumBots_Offset;

	private static bool MinRespawnDelay_IsValid;

	private static int MinRespawnDelay_Offset;

	private static bool NumTravellingPlayers_IsValid;

	private static int NumTravellingPlayers_Offset;

	private static bool StartMatch_IsValid;

	private static IntPtr StartMatch_FunctionAddress;

	private static int StartMatch_ParamsSize;

	private static bool Say_IsValid;

	private static IntPtr Say_FunctionAddress;

	private static int Say_ParamsSize;

	private static bool Say_Msg_IsValid;

	private static FFieldAddress Say_Msg_PropertyAddress;

	private static int Say_Msg_Offset;

	private static bool RestartGame_IsValid;

	private static IntPtr RestartGame_FunctionAddress;

	private static int RestartGame_ParamsSize;

	private static bool ReadyToStartMatch_IsValid;

	private IntPtr ReadyToStartMatch_InstanceFunctionAddress;

	private static IntPtr ReadyToStartMatch_FunctionAddress;

	private static int ReadyToStartMatch_ParamsSize;

	private static bool ReadyToStartMatch_ReturnValue_IsValid;

	private static FFieldAddress ReadyToStartMatch_ReturnValue_PropertyAddress;

	private static int ReadyToStartMatch_ReturnValue_Offset;

	private static bool ReadyToEndMatch_IsValid;

	private IntPtr ReadyToEndMatch_InstanceFunctionAddress;

	private static IntPtr ReadyToEndMatch_FunctionAddress;

	private static int ReadyToEndMatch_ParamsSize;

	private static bool ReadyToEndMatch_ReturnValue_IsValid;

	private static FFieldAddress ReadyToEndMatch_ReturnValue_PropertyAddress;

	private static int ReadyToEndMatch_ReturnValue_Offset;

	private static bool OnSetMatchState_IsValid;

	private IntPtr OnSetMatchState_InstanceFunctionAddress;

	private static IntPtr OnSetMatchState_FunctionAddress;

	private static int OnSetMatchState_ParamsSize;

	private static bool OnSetMatchState_NewState_IsValid;

	private static FFieldAddress OnSetMatchState_NewState_PropertyAddress;

	private static int OnSetMatchState_NewState_Offset;

	private static bool IsMatchInProgress_IsValid;

	private static IntPtr IsMatchInProgress_FunctionAddress;

	private static int IsMatchInProgress_ParamsSize;

	private static bool IsMatchInProgress_ReturnValue_IsValid;

	private static FFieldAddress IsMatchInProgress_ReturnValue_PropertyAddress;

	private static int IsMatchInProgress_ReturnValue_Offset;

	private static bool GetMatchState_IsValid;

	private static IntPtr GetMatchState_FunctionAddress;

	private static int GetMatchState_ParamsSize;

	private static bool GetMatchState_ReturnValue_IsValid;

	private static FFieldAddress GetMatchState_ReturnValue_PropertyAddress;

	private static int GetMatchState_ReturnValue_Offset;

	private static bool EndMatch_IsValid;

	private static IntPtr EndMatch_FunctionAddress;

	private static int EndMatch_ParamsSize;

	private static bool AbortMatch_IsValid;

	private static IntPtr AbortMatch_FunctionAddress;

	private static int AbortMatch_ParamsSize;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.GameMode:bDelayedStart")]
	public bool DelayedStart
	{
		get
		{
			CheckDestroyed();
			if (!DelayedStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:bDelayedStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DelayedStart_Offset), 0, DelayedStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DelayedStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:bDelayedStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DelayedStart_Offset), 0, DelayedStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.GameMode:NumSpectators")]
	public int NumSpectators
	{
		get
		{
			CheckDestroyed();
			if (!NumSpectators_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:NumSpectators");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumSpectators_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumSpectators_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:NumSpectators");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumSpectators_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.GameMode:NumPlayers")]
	public int NumPlayers
	{
		get
		{
			CheckDestroyed();
			if (!NumPlayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:NumPlayers");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumPlayers_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumPlayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:NumPlayers");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumPlayers_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.GameMode:NumBots")]
	public int NumBots
	{
		get
		{
			CheckDestroyed();
			if (!NumBots_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:NumBots");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumBots_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumBots_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:NumBots");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumBots_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.GameMode:MinRespawnDelay")]
	public float MinRespawnDelay
	{
		get
		{
			CheckDestroyed();
			if (!MinRespawnDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:MinRespawnDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinRespawnDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinRespawnDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:MinRespawnDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinRespawnDelay_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.GameMode:NumTravellingPlayers")]
	public int NumTravellingPlayers
	{
		get
		{
			CheckDestroyed();
			if (!NumTravellingPlayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:NumTravellingPlayers");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumTravellingPlayers_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumTravellingPlayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameMode:NumTravellingPlayers");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumTravellingPlayers_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameMode:StartMatch")]
	public unsafe void StartMatch()
	{
		CheckDestroyed();
		if (!StartMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:StartMatch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartMatch_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartMatch_FunctionAddress, argsSize: StartMatch_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.GameMode:Say")]
	public unsafe void Say(string Msg)
	{
		CheckDestroyed();
		if (!Say_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:Say");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Say_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Say_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Say_Msg_Offset), 0, Say_Msg_PropertyAddress.Address, Msg);
		NativeReflection.InvokeFunctionOptimized(base.Address, Say_FunctionAddress, intPtr, Say_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Say_Msg_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameMode:RestartGame")]
	public unsafe void RestartGame()
	{
		CheckDestroyed();
		if (!RestartGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:RestartGame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartGame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RestartGame_FunctionAddress, argsSize: RestartGame_ParamsSize);
	}

	[UFunction(Flags = 134745088u)]
	[UMetaPath("/Script/Engine.GameMode:ReadyToStartMatch")]
	protected unsafe bool ReadyToStartMatch()
	{
		CheckDestroyed();
		if (!ReadyToStartMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:ReadyToStartMatch");
			return false;
		}
		if (ReadyToStartMatch_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReadyToStartMatch_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReadyToStartMatch");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadyToStartMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadyToStartMatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadyToStartMatch_InstanceFunctionAddress, intPtr, ReadyToStartMatch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadyToStartMatch_ReturnValue_Offset), 0, ReadyToStartMatch_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ReadyToStartMatch_Implementation()
	{
		CheckDestroyed();
		if (!ReadyToStartMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:ReadyToStartMatch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadyToStartMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadyToStartMatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadyToStartMatch_FunctionAddress, intPtr, ReadyToStartMatch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadyToStartMatch_ReturnValue_Offset), 0, ReadyToStartMatch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134745088u)]
	[UMetaPath("/Script/Engine.GameMode:ReadyToEndMatch")]
	protected unsafe bool ReadyToEndMatch()
	{
		CheckDestroyed();
		if (!ReadyToEndMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:ReadyToEndMatch");
			return false;
		}
		if (ReadyToEndMatch_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReadyToEndMatch_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReadyToEndMatch");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadyToEndMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadyToEndMatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadyToEndMatch_InstanceFunctionAddress, intPtr, ReadyToEndMatch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadyToEndMatch_ReturnValue_Offset), 0, ReadyToEndMatch_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ReadyToEndMatch_Implementation()
	{
		CheckDestroyed();
		if (!ReadyToEndMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:ReadyToEndMatch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadyToEndMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadyToEndMatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadyToEndMatch_FunctionAddress, intPtr, ReadyToEndMatch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadyToEndMatch_ReturnValue_Offset), 0, ReadyToEndMatch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134744064u, OriginalName = "K2_OnSetMatchState")]
	[UMetaPath("/Script/Engine.GameMode:K2_OnSetMatchState")]
	protected unsafe void OnSetMatchState(FName NewState)
	{
		CheckDestroyed();
		if (!OnSetMatchState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:K2_OnSetMatchState");
			return;
		}
		if (OnSetMatchState_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSetMatchState_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnSetMatchState");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetMatchState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetMatchState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnSetMatchState_NewState_Offset), 0, OnSetMatchState_NewState_PropertyAddress.Address, NewState);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetMatchState_InstanceFunctionAddress, intPtr, OnSetMatchState_ParamsSize);
	}

	protected unsafe virtual void OnSetMatchState_Implementation(FName NewState)
	{
		CheckDestroyed();
		if (!OnSetMatchState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:K2_OnSetMatchState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetMatchState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetMatchState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnSetMatchState_NewState_Offset), 0, OnSetMatchState_NewState_PropertyAddress.Address, NewState);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetMatchState_FunctionAddress, intPtr, OnSetMatchState_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameMode:IsMatchInProgress")]
	public unsafe bool IsMatchInProgress()
	{
		CheckDestroyed();
		if (!IsMatchInProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:IsMatchInProgress");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMatchInProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMatchInProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMatchInProgress_FunctionAddress, intPtr, IsMatchInProgress_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMatchInProgress_ReturnValue_Offset), 0, IsMatchInProgress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameMode:GetMatchState")]
	public unsafe FName GetMatchState()
	{
		CheckDestroyed();
		if (!GetMatchState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:GetMatchState");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMatchState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMatchState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMatchState_FunctionAddress, intPtr, GetMatchState_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetMatchState_ReturnValue_Offset), 0, GetMatchState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameMode:EndMatch")]
	public unsafe void EndMatch()
	{
		CheckDestroyed();
		if (!EndMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:EndMatch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndMatch_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndMatch_FunctionAddress, argsSize: EndMatch_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameMode:AbortMatch")]
	public unsafe void AbortMatch()
	{
		CheckDestroyed();
		if (!AbortMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameMode:AbortMatch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AbortMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AbortMatch_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: AbortMatch_FunctionAddress, argsSize: AbortMatch_ParamsSize);
	}

	static AGameMode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGameMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGameMode));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.GameMode");
		NativeReflectionCached.GetPropertyRef(ref DelayedStart_PropertyAddress, intPtr, "bDelayedStart");
		DelayedStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDelayedStart");
		DelayedStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDelayedStart", Classes.FBoolProperty);
		NumSpectators_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumSpectators");
		NumSpectators_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumSpectators", Classes.FIntProperty);
		NumPlayers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumPlayers");
		NumPlayers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumPlayers", Classes.FIntProperty);
		NumBots_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumBots");
		NumBots_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumBots", Classes.FIntProperty);
		MinRespawnDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinRespawnDelay");
		MinRespawnDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinRespawnDelay", Classes.FFloatProperty);
		NumTravellingPlayers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumTravellingPlayers");
		NumTravellingPlayers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumTravellingPlayers", Classes.FIntProperty);
		StartMatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartMatch");
		StartMatch_ParamsSize = NativeReflection.GetFunctionParamsSize(StartMatch_FunctionAddress);
		StartMatch_IsValid = StartMatch_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:StartMatch", StartMatch_IsValid);
		Say_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Say");
		Say_ParamsSize = NativeReflection.GetFunctionParamsSize(Say_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Say_Msg_PropertyAddress, Say_FunctionAddress, "Msg");
		Say_Msg_Offset = NativeReflectionCached.GetPropertyOffset(Say_FunctionAddress, "Msg");
		Say_Msg_IsValid = NativeReflectionCached.ValidatePropertyClass(Say_FunctionAddress, "Msg", Classes.FStrProperty);
		Say_IsValid = Say_FunctionAddress != IntPtr.Zero && Say_Msg_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:Say", Say_IsValid);
		RestartGame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RestartGame");
		RestartGame_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartGame_FunctionAddress);
		RestartGame_IsValid = RestartGame_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:RestartGame", RestartGame_IsValid);
		ReadyToStartMatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReadyToStartMatch");
		ReadyToStartMatch_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadyToStartMatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadyToStartMatch_ReturnValue_PropertyAddress, ReadyToStartMatch_FunctionAddress, "ReturnValue");
		ReadyToStartMatch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadyToStartMatch_FunctionAddress, "ReturnValue");
		ReadyToStartMatch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadyToStartMatch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadyToStartMatch_IsValid = ReadyToStartMatch_FunctionAddress != IntPtr.Zero && ReadyToStartMatch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:ReadyToStartMatch", ReadyToStartMatch_IsValid);
		ReadyToEndMatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReadyToEndMatch");
		ReadyToEndMatch_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadyToEndMatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadyToEndMatch_ReturnValue_PropertyAddress, ReadyToEndMatch_FunctionAddress, "ReturnValue");
		ReadyToEndMatch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadyToEndMatch_FunctionAddress, "ReturnValue");
		ReadyToEndMatch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadyToEndMatch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadyToEndMatch_IsValid = ReadyToEndMatch_FunctionAddress != IntPtr.Zero && ReadyToEndMatch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:ReadyToEndMatch", ReadyToEndMatch_IsValid);
		OnSetMatchState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnSetMatchState");
		OnSetMatchState_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetMatchState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSetMatchState_NewState_PropertyAddress, OnSetMatchState_FunctionAddress, "NewState");
		OnSetMatchState_NewState_Offset = NativeReflectionCached.GetPropertyOffset(OnSetMatchState_FunctionAddress, "NewState");
		OnSetMatchState_NewState_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSetMatchState_FunctionAddress, "NewState", Classes.FNameProperty);
		OnSetMatchState_IsValid = OnSetMatchState_FunctionAddress != IntPtr.Zero && OnSetMatchState_NewState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:K2_OnSetMatchState", OnSetMatchState_IsValid);
		IsMatchInProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsMatchInProgress");
		IsMatchInProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMatchInProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMatchInProgress_ReturnValue_PropertyAddress, IsMatchInProgress_FunctionAddress, "ReturnValue");
		IsMatchInProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMatchInProgress_FunctionAddress, "ReturnValue");
		IsMatchInProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMatchInProgress_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMatchInProgress_IsValid = IsMatchInProgress_FunctionAddress != IntPtr.Zero && IsMatchInProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:IsMatchInProgress", IsMatchInProgress_IsValid);
		GetMatchState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMatchState");
		GetMatchState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMatchState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMatchState_ReturnValue_PropertyAddress, GetMatchState_FunctionAddress, "ReturnValue");
		GetMatchState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMatchState_FunctionAddress, "ReturnValue");
		GetMatchState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMatchState_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetMatchState_IsValid = GetMatchState_FunctionAddress != IntPtr.Zero && GetMatchState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:GetMatchState", GetMatchState_IsValid);
		EndMatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndMatch");
		EndMatch_ParamsSize = NativeReflection.GetFunctionParamsSize(EndMatch_FunctionAddress);
		EndMatch_IsValid = EndMatch_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:EndMatch", EndMatch_IsValid);
		AbortMatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AbortMatch");
		AbortMatch_ParamsSize = NativeReflection.GetFunctionParamsSize(AbortMatch_FunctionAddress);
		AbortMatch_IsValid = AbortMatch_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameMode:AbortMatch", AbortMatch_IsValid);
	}
}
