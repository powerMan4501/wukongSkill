using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public class UTurnBasedLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RegisterTurnBasedMatchInterfaceObject_IsValid;

	private static IntPtr RegisterTurnBasedMatchInterfaceObject_FunctionAddress;

	private static int RegisterTurnBasedMatchInterfaceObject_ParamsSize;

	private static bool RegisterTurnBasedMatchInterfaceObject_WorldContextObject_IsValid;

	private static FFieldAddress RegisterTurnBasedMatchInterfaceObject_WorldContextObject_PropertyAddress;

	private static int RegisterTurnBasedMatchInterfaceObject_WorldContextObject_Offset;

	private static bool RegisterTurnBasedMatchInterfaceObject_PlayerController_IsValid;

	private static FFieldAddress RegisterTurnBasedMatchInterfaceObject_PlayerController_PropertyAddress;

	private static int RegisterTurnBasedMatchInterfaceObject_PlayerController_Offset;

	private static bool RegisterTurnBasedMatchInterfaceObject_Object_IsValid;

	private static FFieldAddress RegisterTurnBasedMatchInterfaceObject_Object_PropertyAddress;

	private static int RegisterTurnBasedMatchInterfaceObject_Object_Offset;

	private static bool GetPlayerDisplayName_IsValid;

	private static IntPtr GetPlayerDisplayName_FunctionAddress;

	private static int GetPlayerDisplayName_ParamsSize;

	private static bool GetPlayerDisplayName_WorldContextObject_IsValid;

	private static FFieldAddress GetPlayerDisplayName_WorldContextObject_PropertyAddress;

	private static int GetPlayerDisplayName_WorldContextObject_Offset;

	private static bool GetPlayerDisplayName_PlayerController_IsValid;

	private static FFieldAddress GetPlayerDisplayName_PlayerController_PropertyAddress;

	private static int GetPlayerDisplayName_PlayerController_Offset;

	private static bool GetPlayerDisplayName_MatchID_IsValid;

	private static FFieldAddress GetPlayerDisplayName_MatchID_PropertyAddress;

	private static int GetPlayerDisplayName_MatchID_Offset;

	private static bool GetPlayerDisplayName_PlayerIndex_IsValid;

	private static FFieldAddress GetPlayerDisplayName_PlayerIndex_PropertyAddress;

	private static int GetPlayerDisplayName_PlayerIndex_Offset;

	private static bool GetPlayerDisplayName_PlayerDisplayName_IsValid;

	private static FFieldAddress GetPlayerDisplayName_PlayerDisplayName_PropertyAddress;

	private static int GetPlayerDisplayName_PlayerDisplayName_Offset;

	private static bool GetMyPlayerIndex_IsValid;

	private static IntPtr GetMyPlayerIndex_FunctionAddress;

	private static int GetMyPlayerIndex_ParamsSize;

	private static bool GetMyPlayerIndex_WorldContextObject_IsValid;

	private static FFieldAddress GetMyPlayerIndex_WorldContextObject_PropertyAddress;

	private static int GetMyPlayerIndex_WorldContextObject_Offset;

	private static bool GetMyPlayerIndex_PlayerController_IsValid;

	private static FFieldAddress GetMyPlayerIndex_PlayerController_PropertyAddress;

	private static int GetMyPlayerIndex_PlayerController_Offset;

	private static bool GetMyPlayerIndex_MatchID_IsValid;

	private static FFieldAddress GetMyPlayerIndex_MatchID_PropertyAddress;

	private static int GetMyPlayerIndex_MatchID_Offset;

	private static bool GetMyPlayerIndex_PlayerIndex_IsValid;

	private static FFieldAddress GetMyPlayerIndex_PlayerIndex_PropertyAddress;

	private static int GetMyPlayerIndex_PlayerIndex_Offset;

	private static bool GetIsMyTurn_IsValid;

	private static IntPtr GetIsMyTurn_FunctionAddress;

	private static int GetIsMyTurn_ParamsSize;

	private static bool GetIsMyTurn_WorldContextObject_IsValid;

	private static FFieldAddress GetIsMyTurn_WorldContextObject_PropertyAddress;

	private static int GetIsMyTurn_WorldContextObject_Offset;

	private static bool GetIsMyTurn_PlayerController_IsValid;

	private static FFieldAddress GetIsMyTurn_PlayerController_PropertyAddress;

	private static int GetIsMyTurn_PlayerController_Offset;

	private static bool GetIsMyTurn_MatchID_IsValid;

	private static FFieldAddress GetIsMyTurn_MatchID_PropertyAddress;

	private static int GetIsMyTurn_MatchID_Offset;

	private static bool GetIsMyTurn_bIsMyTurn_IsValid;

	private static FFieldAddress GetIsMyTurn_bIsMyTurn_PropertyAddress;

	private static int GetIsMyTurn_bIsMyTurn_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:RegisterTurnBasedMatchInterfaceObject")]
	public unsafe static void RegisterTurnBasedMatchInterfaceObject(UObject WorldContextObject, APlayerController PlayerController, UObject Object)
	{
		if (!RegisterTurnBasedMatchInterfaceObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:RegisterTurnBasedMatchInterfaceObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterTurnBasedMatchInterfaceObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterTurnBasedMatchInterfaceObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RegisterTurnBasedMatchInterfaceObject_WorldContextObject_Offset), 0, RegisterTurnBasedMatchInterfaceObject_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, RegisterTurnBasedMatchInterfaceObject_PlayerController_Offset), 0, RegisterTurnBasedMatchInterfaceObject_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RegisterTurnBasedMatchInterfaceObject_Object_Offset), 0, RegisterTurnBasedMatchInterfaceObject_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterTurnBasedMatchInterfaceObject_FunctionAddress, intPtr, RegisterTurnBasedMatchInterfaceObject_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetPlayerDisplayName")]
	public unsafe static void GetPlayerDisplayName(UObject WorldContextObject, APlayerController PlayerController, string MatchID, int PlayerIndex, out string PlayerDisplayName)
	{
		if (!GetPlayerDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetPlayerDisplayName");
			PlayerDisplayName = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetPlayerDisplayName_WorldContextObject_Offset), 0, GetPlayerDisplayName_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetPlayerDisplayName_PlayerController_Offset), 0, GetPlayerDisplayName_PlayerController_PropertyAddress.Address, PlayerController);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPlayerDisplayName_MatchID_Offset), 0, GetPlayerDisplayName_MatchID_PropertyAddress.Address, MatchID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPlayerDisplayName_PlayerIndex_Offset), 0, GetPlayerDisplayName_PlayerIndex_PropertyAddress.Address, PlayerIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlayerDisplayName_FunctionAddress, intPtr, GetPlayerDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPlayerDisplayName_MatchID_PropertyAddress.Address, intPtr);
		PlayerDisplayName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPlayerDisplayName_PlayerDisplayName_Offset), 0, GetPlayerDisplayName_PlayerDisplayName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPlayerDisplayName_PlayerDisplayName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetMyPlayerIndex")]
	public unsafe static void GetMyPlayerIndex(UObject WorldContextObject, APlayerController PlayerController, string MatchID, out int PlayerIndex)
	{
		if (!GetMyPlayerIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetMyPlayerIndex");
			PlayerIndex = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMyPlayerIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMyPlayerIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetMyPlayerIndex_WorldContextObject_Offset), 0, GetMyPlayerIndex_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetMyPlayerIndex_PlayerController_Offset), 0, GetMyPlayerIndex_PlayerController_PropertyAddress.Address, PlayerController);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetMyPlayerIndex_MatchID_Offset), 0, GetMyPlayerIndex_MatchID_PropertyAddress.Address, MatchID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMyPlayerIndex_FunctionAddress, intPtr, GetMyPlayerIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMyPlayerIndex_MatchID_PropertyAddress.Address, intPtr);
		PlayerIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMyPlayerIndex_PlayerIndex_Offset), 0, GetMyPlayerIndex_PlayerIndex_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetIsMyTurn")]
	public unsafe static void GetIsMyTurn(UObject WorldContextObject, APlayerController PlayerController, string MatchID, out bool bIsMyTurn)
	{
		if (!GetIsMyTurn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetIsMyTurn");
			bIsMyTurn = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsMyTurn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsMyTurn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetIsMyTurn_WorldContextObject_Offset), 0, GetIsMyTurn_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetIsMyTurn_PlayerController_Offset), 0, GetIsMyTurn_PlayerController_PropertyAddress.Address, PlayerController);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetIsMyTurn_MatchID_Offset), 0, GetIsMyTurn_MatchID_PropertyAddress.Address, MatchID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsMyTurn_FunctionAddress, intPtr, GetIsMyTurn_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIsMyTurn_MatchID_PropertyAddress.Address, intPtr);
		bIsMyTurn = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsMyTurn_bIsMyTurn_Offset), 0, GetIsMyTurn_bIsMyTurn_PropertyAddress.Address);
	}

	static UTurnBasedLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTurnBasedLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTurnBasedLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary");
		RegisterTurnBasedMatchInterfaceObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterTurnBasedMatchInterfaceObject");
		RegisterTurnBasedMatchInterfaceObject_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterTurnBasedMatchInterfaceObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterTurnBasedMatchInterfaceObject_WorldContextObject_PropertyAddress, RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "WorldContextObject");
		RegisterTurnBasedMatchInterfaceObject_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "WorldContextObject");
		RegisterTurnBasedMatchInterfaceObject_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterTurnBasedMatchInterfaceObject_PlayerController_PropertyAddress, RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "PlayerController");
		RegisterTurnBasedMatchInterfaceObject_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "PlayerController");
		RegisterTurnBasedMatchInterfaceObject_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterTurnBasedMatchInterfaceObject_Object_PropertyAddress, RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "Object");
		RegisterTurnBasedMatchInterfaceObject_Object_Offset = NativeReflectionCached.GetPropertyOffset(RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "Object");
		RegisterTurnBasedMatchInterfaceObject_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterTurnBasedMatchInterfaceObject_FunctionAddress, "Object", Classes.FObjectProperty);
		RegisterTurnBasedMatchInterfaceObject_IsValid = RegisterTurnBasedMatchInterfaceObject_FunctionAddress != IntPtr.Zero && RegisterTurnBasedMatchInterfaceObject_WorldContextObject_IsValid && RegisterTurnBasedMatchInterfaceObject_PlayerController_IsValid && RegisterTurnBasedMatchInterfaceObject_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:RegisterTurnBasedMatchInterfaceObject", RegisterTurnBasedMatchInterfaceObject_IsValid);
		GetPlayerDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayerDisplayName");
		GetPlayerDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerDisplayName_WorldContextObject_PropertyAddress, GetPlayerDisplayName_FunctionAddress, "WorldContextObject");
		GetPlayerDisplayName_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerDisplayName_FunctionAddress, "WorldContextObject");
		GetPlayerDisplayName_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerDisplayName_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerDisplayName_PlayerController_PropertyAddress, GetPlayerDisplayName_FunctionAddress, "PlayerController");
		GetPlayerDisplayName_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerDisplayName_FunctionAddress, "PlayerController");
		GetPlayerDisplayName_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerDisplayName_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerDisplayName_MatchID_PropertyAddress, GetPlayerDisplayName_FunctionAddress, "MatchID");
		GetPlayerDisplayName_MatchID_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerDisplayName_FunctionAddress, "MatchID");
		GetPlayerDisplayName_MatchID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerDisplayName_FunctionAddress, "MatchID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerDisplayName_PlayerIndex_PropertyAddress, GetPlayerDisplayName_FunctionAddress, "PlayerIndex");
		GetPlayerDisplayName_PlayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerDisplayName_FunctionAddress, "PlayerIndex");
		GetPlayerDisplayName_PlayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerDisplayName_FunctionAddress, "PlayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerDisplayName_PlayerDisplayName_PropertyAddress, GetPlayerDisplayName_FunctionAddress, "PlayerDisplayName");
		GetPlayerDisplayName_PlayerDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerDisplayName_FunctionAddress, "PlayerDisplayName");
		GetPlayerDisplayName_PlayerDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerDisplayName_FunctionAddress, "PlayerDisplayName", Classes.FStrProperty);
		GetPlayerDisplayName_IsValid = GetPlayerDisplayName_FunctionAddress != IntPtr.Zero && GetPlayerDisplayName_WorldContextObject_IsValid && GetPlayerDisplayName_PlayerController_IsValid && GetPlayerDisplayName_MatchID_IsValid && GetPlayerDisplayName_PlayerIndex_IsValid && GetPlayerDisplayName_PlayerDisplayName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetPlayerDisplayName", GetPlayerDisplayName_IsValid);
		GetMyPlayerIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMyPlayerIndex");
		GetMyPlayerIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMyPlayerIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMyPlayerIndex_WorldContextObject_PropertyAddress, GetMyPlayerIndex_FunctionAddress, "WorldContextObject");
		GetMyPlayerIndex_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetMyPlayerIndex_FunctionAddress, "WorldContextObject");
		GetMyPlayerIndex_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMyPlayerIndex_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMyPlayerIndex_PlayerController_PropertyAddress, GetMyPlayerIndex_FunctionAddress, "PlayerController");
		GetMyPlayerIndex_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetMyPlayerIndex_FunctionAddress, "PlayerController");
		GetMyPlayerIndex_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMyPlayerIndex_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMyPlayerIndex_MatchID_PropertyAddress, GetMyPlayerIndex_FunctionAddress, "MatchID");
		GetMyPlayerIndex_MatchID_Offset = NativeReflectionCached.GetPropertyOffset(GetMyPlayerIndex_FunctionAddress, "MatchID");
		GetMyPlayerIndex_MatchID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMyPlayerIndex_FunctionAddress, "MatchID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMyPlayerIndex_PlayerIndex_PropertyAddress, GetMyPlayerIndex_FunctionAddress, "PlayerIndex");
		GetMyPlayerIndex_PlayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetMyPlayerIndex_FunctionAddress, "PlayerIndex");
		GetMyPlayerIndex_PlayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMyPlayerIndex_FunctionAddress, "PlayerIndex", Classes.FIntProperty);
		GetMyPlayerIndex_IsValid = GetMyPlayerIndex_FunctionAddress != IntPtr.Zero && GetMyPlayerIndex_WorldContextObject_IsValid && GetMyPlayerIndex_PlayerController_IsValid && GetMyPlayerIndex_MatchID_IsValid && GetMyPlayerIndex_PlayerIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetMyPlayerIndex", GetMyPlayerIndex_IsValid);
		GetIsMyTurn_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsMyTurn");
		GetIsMyTurn_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsMyTurn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsMyTurn_WorldContextObject_PropertyAddress, GetIsMyTurn_FunctionAddress, "WorldContextObject");
		GetIsMyTurn_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetIsMyTurn_FunctionAddress, "WorldContextObject");
		GetIsMyTurn_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsMyTurn_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsMyTurn_PlayerController_PropertyAddress, GetIsMyTurn_FunctionAddress, "PlayerController");
		GetIsMyTurn_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetIsMyTurn_FunctionAddress, "PlayerController");
		GetIsMyTurn_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsMyTurn_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsMyTurn_MatchID_PropertyAddress, GetIsMyTurn_FunctionAddress, "MatchID");
		GetIsMyTurn_MatchID_Offset = NativeReflectionCached.GetPropertyOffset(GetIsMyTurn_FunctionAddress, "MatchID");
		GetIsMyTurn_MatchID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsMyTurn_FunctionAddress, "MatchID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsMyTurn_bIsMyTurn_PropertyAddress, GetIsMyTurn_FunctionAddress, "bIsMyTurn");
		GetIsMyTurn_bIsMyTurn_Offset = NativeReflectionCached.GetPropertyOffset(GetIsMyTurn_FunctionAddress, "bIsMyTurn");
		GetIsMyTurn_bIsMyTurn_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsMyTurn_FunctionAddress, "bIsMyTurn", Classes.FBoolProperty);
		GetIsMyTurn_IsValid = GetIsMyTurn_FunctionAddress != IntPtr.Zero && GetIsMyTurn_WorldContextObject_IsValid && GetIsMyTurn_PlayerController_IsValid && GetIsMyTurn_MatchID_IsValid && GetIsMyTurn_bIsMyTurn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary:GetIsMyTurn", GetIsMyTurn_IsValid);
	}
}
