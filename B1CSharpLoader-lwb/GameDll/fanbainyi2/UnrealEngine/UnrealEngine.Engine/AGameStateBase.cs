using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.GameStateBase", "Engine", UnrealModuleType.Engine)]
public class AGameStateBase : AInfo
{
	private static bool GameModeClass_IsValid;

	private static int GameModeClass_Offset;

	private static bool AuthorityGameMode_IsValid;

	private static int AuthorityGameMode_Offset;

	private static bool SpectatorClass_IsValid;

	private static int SpectatorClass_Offset;

	private static bool PlayerArray_IsValid;

	private static FFieldAddress PlayerArray_PropertyAddress;

	private static int PlayerArray_Offset;

	private TArrayReadOnlyMarshaler<APlayerState> PlayerArray_MarshalerCached;

	private static bool HasMatchStarted_IsValid;

	private static IntPtr HasMatchStarted_FunctionAddress;

	private static int HasMatchStarted_ParamsSize;

	private static bool HasMatchStarted_ReturnValue_IsValid;

	private static FFieldAddress HasMatchStarted_ReturnValue_PropertyAddress;

	private static int HasMatchStarted_ReturnValue_Offset;

	private static bool HasMatchEnded_IsValid;

	private static IntPtr HasMatchEnded_FunctionAddress;

	private static int HasMatchEnded_ParamsSize;

	private static bool HasMatchEnded_ReturnValue_IsValid;

	private static FFieldAddress HasMatchEnded_ReturnValue_PropertyAddress;

	private static int HasMatchEnded_ReturnValue_Offset;

	private static bool HasBegunPlay_IsValid;

	private static IntPtr HasBegunPlay_FunctionAddress;

	private static int HasBegunPlay_ParamsSize;

	private static bool HasBegunPlay_ReturnValue_IsValid;

	private static FFieldAddress HasBegunPlay_ReturnValue_PropertyAddress;

	private static int HasBegunPlay_ReturnValue_Offset;

	private static bool GetServerWorldTimeSeconds_IsValid;

	private static IntPtr GetServerWorldTimeSeconds_FunctionAddress;

	private static int GetServerWorldTimeSeconds_ParamsSize;

	private static bool GetServerWorldTimeSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetServerWorldTimeSeconds_ReturnValue_PropertyAddress;

	private static int GetServerWorldTimeSeconds_ReturnValue_Offset;

	private static bool GetPlayerStartTime_IsValid;

	private static IntPtr GetPlayerStartTime_FunctionAddress;

	private static int GetPlayerStartTime_ParamsSize;

	private static bool GetPlayerStartTime_Controller_IsValid;

	private static FFieldAddress GetPlayerStartTime_Controller_PropertyAddress;

	private static int GetPlayerStartTime_Controller_Offset;

	private static bool GetPlayerStartTime_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerStartTime_ReturnValue_PropertyAddress;

	private static int GetPlayerStartTime_ReturnValue_Offset;

	private static bool GetPlayerRespawnDelay_IsValid;

	private static IntPtr GetPlayerRespawnDelay_FunctionAddress;

	private static int GetPlayerRespawnDelay_ParamsSize;

	private static bool GetPlayerRespawnDelay_Controller_IsValid;

	private static FFieldAddress GetPlayerRespawnDelay_Controller_PropertyAddress;

	private static int GetPlayerRespawnDelay_Controller_Offset;

	private static bool GetPlayerRespawnDelay_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerRespawnDelay_ReturnValue_PropertyAddress;

	private static int GetPlayerRespawnDelay_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881373436092980uL)]
	[UMetaPath("/Script/Engine.GameStateBase:GameModeClass")]
	public TSubclassOf<AGameModeBase> GameModeClass
	{
		get
		{
			CheckDestroyed();
			if (!GameModeClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameStateBase:GameModeClass");
				return default(TSubclassOf<AGameModeBase>);
			}
			return TSubclassOfMarshaler<AGameModeBase>.FromNative(IntPtr.Add(base.Address, GameModeClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameModeClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameStateBase:GameModeClass");
			}
			else
			{
				TSubclassOfMarshaler<AGameModeBase>.ToNative(IntPtr.Add(base.Address, GameModeClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141125652uL)]
	[UMetaPath("/Script/Engine.GameStateBase:AuthorityGameMode")]
	public AGameModeBase AuthorityGameMode
	{
		get
		{
			CheckDestroyed();
			if (!AuthorityGameMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameStateBase:AuthorityGameMode");
				return null;
			}
			return UObjectMarshaler<AGameModeBase>.FromNative(IntPtr.Add(base.Address, AuthorityGameMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AuthorityGameMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameStateBase:AuthorityGameMode");
			}
			else
			{
				UObjectMarshaler<AGameModeBase>.ToNative(IntPtr.Add(base.Address, AuthorityGameMode_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881373436092980uL)]
	[UMetaPath("/Script/Engine.GameStateBase:SpectatorClass")]
	public TSubclassOf<ASpectatorPawn> SpectatorClass
	{
		get
		{
			CheckDestroyed();
			if (!SpectatorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameStateBase:SpectatorClass");
				return default(TSubclassOf<ASpectatorPawn>);
			}
			return TSubclassOfMarshaler<ASpectatorPawn>.FromNative(IntPtr.Add(base.Address, SpectatorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpectatorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameStateBase:SpectatorClass");
			}
			else
			{
				TSubclassOfMarshaler<ASpectatorPawn>.ToNative(IntPtr.Add(base.Address, SpectatorClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534221844uL)]
	[UMetaPath("/Script/Engine.GameStateBase:PlayerArray")]
	public TArrayReadOnly<APlayerState> PlayerArray
	{
		get
		{
			CheckDestroyed();
			if (!PlayerArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameStateBase:PlayerArray");
				return null;
			}
			if (PlayerArray_MarshalerCached == null)
			{
				PlayerArray_MarshalerCached = new TArrayReadOnlyMarshaler<APlayerState>(1, PlayerArray_PropertyAddress, CachedMarshalingDelegates<APlayerState, UObjectMarshaler<APlayerState>>.FromNative, CachedMarshalingDelegates<APlayerState, UObjectMarshaler<APlayerState>>.ToNative);
			}
			return PlayerArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, PlayerArray_Offset));
		}
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameStateBase:HasMatchStarted")]
	public unsafe bool HasMatchStarted()
	{
		CheckDestroyed();
		if (!HasMatchStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameStateBase:HasMatchStarted");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMatchStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMatchStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasMatchStarted_FunctionAddress, intPtr, HasMatchStarted_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMatchStarted_ReturnValue_Offset), 0, HasMatchStarted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameStateBase:HasMatchEnded")]
	public unsafe bool HasMatchEnded()
	{
		CheckDestroyed();
		if (!HasMatchEnded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameStateBase:HasMatchEnded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMatchEnded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMatchEnded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasMatchEnded_FunctionAddress, intPtr, HasMatchEnded_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMatchEnded_ReturnValue_Offset), 0, HasMatchEnded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameStateBase:HasBegunPlay")]
	public unsafe bool HasBegunPlay()
	{
		CheckDestroyed();
		if (!HasBegunPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameStateBase:HasBegunPlay");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasBegunPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasBegunPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasBegunPlay_FunctionAddress, intPtr, HasBegunPlay_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasBegunPlay_ReturnValue_Offset), 0, HasBegunPlay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameStateBase:GetServerWorldTimeSeconds")]
	public unsafe float GetServerWorldTimeSeconds()
	{
		CheckDestroyed();
		if (!GetServerWorldTimeSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameStateBase:GetServerWorldTimeSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetServerWorldTimeSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetServerWorldTimeSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetServerWorldTimeSeconds_FunctionAddress, intPtr, GetServerWorldTimeSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetServerWorldTimeSeconds_ReturnValue_Offset), 0, GetServerWorldTimeSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameStateBase:GetPlayerStartTime")]
	public unsafe float GetPlayerStartTime(AController Controller)
	{
		CheckDestroyed();
		if (!GetPlayerStartTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameStateBase:GetPlayerStartTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerStartTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerStartTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, GetPlayerStartTime_Controller_Offset), 0, GetPlayerStartTime_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerStartTime_FunctionAddress, intPtr, GetPlayerStartTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlayerStartTime_ReturnValue_Offset), 0, GetPlayerStartTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameStateBase:GetPlayerRespawnDelay")]
	public unsafe float GetPlayerRespawnDelay(AController Controller)
	{
		CheckDestroyed();
		if (!GetPlayerRespawnDelay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameStateBase:GetPlayerRespawnDelay");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerRespawnDelay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerRespawnDelay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, GetPlayerRespawnDelay_Controller_Offset), 0, GetPlayerRespawnDelay_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerRespawnDelay_FunctionAddress, intPtr, GetPlayerRespawnDelay_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlayerRespawnDelay_ReturnValue_Offset), 0, GetPlayerRespawnDelay_ReturnValue_PropertyAddress.Address);
	}

	static AGameStateBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGameStateBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGameStateBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.GameStateBase");
		GameModeClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GameModeClass");
		GameModeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GameModeClass", Classes.FClassProperty);
		AuthorityGameMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AuthorityGameMode");
		AuthorityGameMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AuthorityGameMode", Classes.FObjectProperty);
		SpectatorClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpectatorClass");
		SpectatorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpectatorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayerArray_PropertyAddress, intPtr, "PlayerArray");
		PlayerArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerArray");
		PlayerArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerArray", Classes.FArrayProperty);
		HasMatchStarted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasMatchStarted");
		HasMatchStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMatchStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMatchStarted_ReturnValue_PropertyAddress, HasMatchStarted_FunctionAddress, "ReturnValue");
		HasMatchStarted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMatchStarted_FunctionAddress, "ReturnValue");
		HasMatchStarted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMatchStarted_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMatchStarted_IsValid = HasMatchStarted_FunctionAddress != IntPtr.Zero && HasMatchStarted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameStateBase:HasMatchStarted", HasMatchStarted_IsValid);
		HasMatchEnded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasMatchEnded");
		HasMatchEnded_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMatchEnded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMatchEnded_ReturnValue_PropertyAddress, HasMatchEnded_FunctionAddress, "ReturnValue");
		HasMatchEnded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMatchEnded_FunctionAddress, "ReturnValue");
		HasMatchEnded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMatchEnded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMatchEnded_IsValid = HasMatchEnded_FunctionAddress != IntPtr.Zero && HasMatchEnded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameStateBase:HasMatchEnded", HasMatchEnded_IsValid);
		HasBegunPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasBegunPlay");
		HasBegunPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(HasBegunPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasBegunPlay_ReturnValue_PropertyAddress, HasBegunPlay_FunctionAddress, "ReturnValue");
		HasBegunPlay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasBegunPlay_FunctionAddress, "ReturnValue");
		HasBegunPlay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasBegunPlay_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasBegunPlay_IsValid = HasBegunPlay_FunctionAddress != IntPtr.Zero && HasBegunPlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameStateBase:HasBegunPlay", HasBegunPlay_IsValid);
		GetServerWorldTimeSeconds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetServerWorldTimeSeconds");
		GetServerWorldTimeSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetServerWorldTimeSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetServerWorldTimeSeconds_ReturnValue_PropertyAddress, GetServerWorldTimeSeconds_FunctionAddress, "ReturnValue");
		GetServerWorldTimeSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetServerWorldTimeSeconds_FunctionAddress, "ReturnValue");
		GetServerWorldTimeSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetServerWorldTimeSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetServerWorldTimeSeconds_IsValid = GetServerWorldTimeSeconds_FunctionAddress != IntPtr.Zero && GetServerWorldTimeSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameStateBase:GetServerWorldTimeSeconds", GetServerWorldTimeSeconds_IsValid);
		GetPlayerStartTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerStartTime");
		GetPlayerStartTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerStartTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerStartTime_Controller_PropertyAddress, GetPlayerStartTime_FunctionAddress, "Controller");
		GetPlayerStartTime_Controller_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerStartTime_FunctionAddress, "Controller");
		GetPlayerStartTime_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerStartTime_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerStartTime_ReturnValue_PropertyAddress, GetPlayerStartTime_FunctionAddress, "ReturnValue");
		GetPlayerStartTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerStartTime_FunctionAddress, "ReturnValue");
		GetPlayerStartTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerStartTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlayerStartTime_IsValid = GetPlayerStartTime_FunctionAddress != IntPtr.Zero && GetPlayerStartTime_Controller_IsValid && GetPlayerStartTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameStateBase:GetPlayerStartTime", GetPlayerStartTime_IsValid);
		GetPlayerRespawnDelay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerRespawnDelay");
		GetPlayerRespawnDelay_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerRespawnDelay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerRespawnDelay_Controller_PropertyAddress, GetPlayerRespawnDelay_FunctionAddress, "Controller");
		GetPlayerRespawnDelay_Controller_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerRespawnDelay_FunctionAddress, "Controller");
		GetPlayerRespawnDelay_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerRespawnDelay_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerRespawnDelay_ReturnValue_PropertyAddress, GetPlayerRespawnDelay_FunctionAddress, "ReturnValue");
		GetPlayerRespawnDelay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerRespawnDelay_FunctionAddress, "ReturnValue");
		GetPlayerRespawnDelay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerRespawnDelay_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlayerRespawnDelay_IsValid = GetPlayerRespawnDelay_FunctionAddress != IntPtr.Zero && GetPlayerRespawnDelay_Controller_IsValid && GetPlayerRespawnDelay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameStateBase:GetPlayerRespawnDelay", GetPlayerRespawnDelay_IsValid);
	}
}
