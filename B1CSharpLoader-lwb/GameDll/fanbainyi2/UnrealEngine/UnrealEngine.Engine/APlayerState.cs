using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PlayerState", "Engine", UnrealModuleType.Engine)]
public class APlayerState : AInfo
{
	private static bool Score_IsValid;

	private static int Score_Offset;

	private static bool PlayerId_IsValid;

	private static int PlayerId_Offset;

	private static bool IsSpectator_IsValid;

	private static FFieldAddress IsSpectator_PropertyAddress;

	private static int IsSpectator_Offset;

	private static bool IsABot_IsValid;

	private static FFieldAddress IsABot_PropertyAddress;

	private static int IsABot_Offset;

	private static bool OnPawnSet_IsValid;

	private static int OnPawnSet_Offset;

	private FOnPlayerStatePawnSet OnPawnSet_DelegateCached;

	private static bool PawnPrivate_IsValid;

	private static int PawnPrivate_Offset;

	private static bool ReceiveOverrideWith_IsValid;

	private IntPtr ReceiveOverrideWith_InstanceFunctionAddress;

	private static IntPtr ReceiveOverrideWith_FunctionAddress;

	private static int ReceiveOverrideWith_ParamsSize;

	private static bool ReceiveOverrideWith_OldPlayerState_IsValid;

	private static FFieldAddress ReceiveOverrideWith_OldPlayerState_PropertyAddress;

	private static int ReceiveOverrideWith_OldPlayerState_Offset;

	private static bool ReceiveCopyProperties_IsValid;

	private IntPtr ReceiveCopyProperties_InstanceFunctionAddress;

	private static IntPtr ReceiveCopyProperties_FunctionAddress;

	private static int ReceiveCopyProperties_ParamsSize;

	private static bool ReceiveCopyProperties_NewPlayerState_IsValid;

	private static FFieldAddress ReceiveCopyProperties_NewPlayerState_PropertyAddress;

	private static int ReceiveCopyProperties_NewPlayerState_Offset;

	private static bool IsOnlyASpectator_IsValid;

	private static IntPtr IsOnlyASpectator_FunctionAddress;

	private static int IsOnlyASpectator_ParamsSize;

	private static bool IsOnlyASpectator_ReturnValue_IsValid;

	private static FFieldAddress IsOnlyASpectator_ReturnValue_PropertyAddress;

	private static int IsOnlyASpectator_ReturnValue_Offset;

	private static bool GetPlayerName_IsValid;

	private static IntPtr GetPlayerName_FunctionAddress;

	private static int GetPlayerName_ParamsSize;

	private static bool GetPlayerName_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerName_ReturnValue_PropertyAddress;

	private static int GetPlayerName_ReturnValue_Offset;

	private static bool GetPlayerController_IsValid;

	private static IntPtr GetPlayerController_FunctionAddress;

	private static int GetPlayerController_ParamsSize;

	private static bool GetPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerController_ReturnValue_PropertyAddress;

	private static int GetPlayerController_ReturnValue_Offset;

	private static bool GetPingInMilliseconds_IsValid;

	private static IntPtr GetPingInMilliseconds_FunctionAddress;

	private static int GetPingInMilliseconds_ParamsSize;

	private static bool GetPingInMilliseconds_ReturnValue_IsValid;

	private static FFieldAddress GetPingInMilliseconds_ReturnValue_PropertyAddress;

	private static int GetPingInMilliseconds_ReturnValue_Offset;

	private static bool GetPawn_IsValid;

	private static IntPtr GetPawn_FunctionAddress;

	private static int GetPawn_ParamsSize;

	private static bool GetPawn_ReturnValue_IsValid;

	private static FFieldAddress GetPawn_ReturnValue_PropertyAddress;

	private static int GetPawn_ReturnValue_Offset;

	private static bool BP_GetUniqueId_IsValid;

	private static IntPtr BP_GetUniqueId_FunctionAddress;

	private static int BP_GetUniqueId_ParamsSize;

	private static bool BP_GetUniqueId_ReturnValue_IsValid;

	private static FFieldAddress BP_GetUniqueId_ReturnValue_PropertyAddress;

	private static int BP_GetUniqueId_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755473529242164uL)]
	[UMetaPath("/Script/Engine.PlayerState:Score")]
	public float Score
	{
		get
		{
			CheckDestroyed();
			if (!Score_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:Score");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Score_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Score_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:Score");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Score_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755473529242164uL)]
	[UMetaPath("/Script/Engine.PlayerState:PlayerId")]
	public int PlayerId
	{
		get
		{
			CheckDestroyed();
			if (!PlayerId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:PlayerId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlayerId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:PlayerId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlayerId_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532532uL)]
	[UMetaPath("/Script/Engine.PlayerState:bIsSpectator")]
	public bool IsSpectator
	{
		get
		{
			CheckDestroyed();
			if (!IsSpectator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:bIsSpectator");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSpectator_Offset), 0, IsSpectator_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSpectator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:bIsSpectator");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSpectator_Offset), 0, IsSpectator_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532532uL)]
	[UMetaPath("/Script/Engine.PlayerState:bIsABot")]
	public bool IsABot
	{
		get
		{
			CheckDestroyed();
			if (!IsABot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:bIsABot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsABot_Offset), 0, IsABot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsABot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:bIsABot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsABot_Offset), 0, IsABot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlayerState:OnPawnSet")]
	public FOnPlayerStatePawnSet OnPawnSet
	{
		get
		{
			CheckDestroyed();
			if (!OnPawnSet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:OnPawnSet");
				return new FOnPlayerStatePawnSet();
			}
			if (OnPawnSet_DelegateCached == null)
			{
				OnPawnSet_DelegateCached = new FOnPlayerStatePawnSet();
				OnPawnSet_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPawnSet_Offset));
			}
			return OnPawnSet_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)21392168023228948uL)]
	[UMetaPath("/Script/Engine.PlayerState:PawnPrivate")]
	public APawn PawnPrivate
	{
		get
		{
			CheckDestroyed();
			if (!PawnPrivate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:PawnPrivate");
				return null;
			}
			return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(base.Address, PawnPrivate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PawnPrivate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerState:PawnPrivate");
			}
			else
			{
				UObjectMarshaler<APawn>.ToNative(IntPtr.Add(base.Address, PawnPrivate_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/Engine.PlayerState:ReceiveOverrideWith")]
	protected unsafe void ReceiveOverrideWith(APlayerState OldPlayerState)
	{
		CheckDestroyed();
		if (!ReceiveOverrideWith_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:ReceiveOverrideWith");
			return;
		}
		if (ReceiveOverrideWith_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveOverrideWith_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveOverrideWith");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveOverrideWith_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveOverrideWith_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, ReceiveOverrideWith_OldPlayerState_Offset), 0, ReceiveOverrideWith_OldPlayerState_PropertyAddress.Address, OldPlayerState);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveOverrideWith_InstanceFunctionAddress, intPtr, ReceiveOverrideWith_ParamsSize);
	}

	protected unsafe virtual void ReceiveOverrideWith_Implementation(APlayerState OldPlayerState)
	{
		CheckDestroyed();
		if (!ReceiveOverrideWith_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:ReceiveOverrideWith");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveOverrideWith_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveOverrideWith_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, ReceiveOverrideWith_OldPlayerState_Offset), 0, ReceiveOverrideWith_OldPlayerState_PropertyAddress.Address, OldPlayerState);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveOverrideWith_FunctionAddress, intPtr, ReceiveOverrideWith_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/Engine.PlayerState:ReceiveCopyProperties")]
	protected unsafe void ReceiveCopyProperties(APlayerState NewPlayerState)
	{
		CheckDestroyed();
		if (!ReceiveCopyProperties_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:ReceiveCopyProperties");
			return;
		}
		if (ReceiveCopyProperties_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveCopyProperties_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveCopyProperties");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveCopyProperties_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveCopyProperties_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, ReceiveCopyProperties_NewPlayerState_Offset), 0, ReceiveCopyProperties_NewPlayerState_PropertyAddress.Address, NewPlayerState);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveCopyProperties_InstanceFunctionAddress, intPtr, ReceiveCopyProperties_ParamsSize);
	}

	protected unsafe virtual void ReceiveCopyProperties_Implementation(APlayerState NewPlayerState)
	{
		CheckDestroyed();
		if (!ReceiveCopyProperties_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:ReceiveCopyProperties");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveCopyProperties_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveCopyProperties_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, ReceiveCopyProperties_NewPlayerState_Offset), 0, ReceiveCopyProperties_NewPlayerState_PropertyAddress.Address, NewPlayerState);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveCopyProperties_FunctionAddress, intPtr, ReceiveCopyProperties_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerState:IsOnlyASpectator")]
	public unsafe bool IsOnlyASpectator()
	{
		CheckDestroyed();
		if (!IsOnlyASpectator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:IsOnlyASpectator");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOnlyASpectator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOnlyASpectator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOnlyASpectator_FunctionAddress, intPtr, IsOnlyASpectator_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOnlyASpectator_ReturnValue_Offset), 0, IsOnlyASpectator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerState:GetPlayerName")]
	public unsafe string GetPlayerName()
	{
		CheckDestroyed();
		if (!GetPlayerName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:GetPlayerName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerName_FunctionAddress, intPtr, GetPlayerName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPlayerName_ReturnValue_Offset), 0, GetPlayerName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPlayerName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerState:GetPlayerController")]
	public unsafe APlayerController GetPlayerController()
	{
		CheckDestroyed();
		if (!GetPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:GetPlayerController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerController_FunctionAddress, intPtr, GetPlayerController_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetPlayerController_ReturnValue_Offset), 0, GetPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerState:GetPingInMilliseconds")]
	public unsafe float GetPingInMilliseconds()
	{
		CheckDestroyed();
		if (!GetPingInMilliseconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:GetPingInMilliseconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPingInMilliseconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPingInMilliseconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPingInMilliseconds_FunctionAddress, intPtr, GetPingInMilliseconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPingInMilliseconds_ReturnValue_Offset), 0, GetPingInMilliseconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerState:GetPawn")]
	public unsafe APawn GetPawn()
	{
		CheckDestroyed();
		if (!GetPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:GetPawn");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPawn_FunctionAddress, intPtr, GetPawn_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, GetPawn_ReturnValue_Offset), 0, GetPawn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerState:BP_GetUniqueId")]
	public unsafe FUniqueNetIdRepl BP_GetUniqueId()
	{
		CheckDestroyed();
		if (!BP_GetUniqueId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerState:BP_GetUniqueId");
			return default(FUniqueNetIdRepl);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_GetUniqueId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_GetUniqueId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_GetUniqueId_FunctionAddress, intPtr, BP_GetUniqueId_ParamsSize);
		FUniqueNetIdRepl result = FUniqueNetIdRepl.FromNative(IntPtr.Add(intPtr, BP_GetUniqueId_ReturnValue_Offset), 0, BP_GetUniqueId_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BP_GetUniqueId_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static APlayerState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APlayerState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APlayerState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PlayerState");
		Score_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Score");
		Score_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Score", Classes.FFloatProperty);
		PlayerId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerId");
		PlayerId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSpectator_PropertyAddress, intPtr, "bIsSpectator");
		IsSpectator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSpectator");
		IsSpectator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSpectator", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsABot_PropertyAddress, intPtr, "bIsABot");
		IsABot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsABot");
		IsABot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsABot", Classes.FBoolProperty);
		OnPawnSet_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPawnSet");
		OnPawnSet_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPawnSet", Classes.FMulticastDelegateProperty);
		PawnPrivate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PawnPrivate");
		PawnPrivate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PawnPrivate", Classes.FObjectProperty);
		ReceiveOverrideWith_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveOverrideWith");
		ReceiveOverrideWith_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveOverrideWith_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveOverrideWith_OldPlayerState_PropertyAddress, ReceiveOverrideWith_FunctionAddress, "OldPlayerState");
		ReceiveOverrideWith_OldPlayerState_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveOverrideWith_FunctionAddress, "OldPlayerState");
		ReceiveOverrideWith_OldPlayerState_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveOverrideWith_FunctionAddress, "OldPlayerState", Classes.FObjectProperty);
		ReceiveOverrideWith_IsValid = ReceiveOverrideWith_FunctionAddress != IntPtr.Zero && ReceiveOverrideWith_OldPlayerState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerState:ReceiveOverrideWith", ReceiveOverrideWith_IsValid);
		ReceiveCopyProperties_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveCopyProperties");
		ReceiveCopyProperties_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveCopyProperties_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveCopyProperties_NewPlayerState_PropertyAddress, ReceiveCopyProperties_FunctionAddress, "NewPlayerState");
		ReceiveCopyProperties_NewPlayerState_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveCopyProperties_FunctionAddress, "NewPlayerState");
		ReceiveCopyProperties_NewPlayerState_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveCopyProperties_FunctionAddress, "NewPlayerState", Classes.FObjectProperty);
		ReceiveCopyProperties_IsValid = ReceiveCopyProperties_FunctionAddress != IntPtr.Zero && ReceiveCopyProperties_NewPlayerState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerState:ReceiveCopyProperties", ReceiveCopyProperties_IsValid);
		IsOnlyASpectator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOnlyASpectator");
		IsOnlyASpectator_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOnlyASpectator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOnlyASpectator_ReturnValue_PropertyAddress, IsOnlyASpectator_FunctionAddress, "ReturnValue");
		IsOnlyASpectator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOnlyASpectator_FunctionAddress, "ReturnValue");
		IsOnlyASpectator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOnlyASpectator_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOnlyASpectator_IsValid = IsOnlyASpectator_FunctionAddress != IntPtr.Zero && IsOnlyASpectator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerState:IsOnlyASpectator", IsOnlyASpectator_IsValid);
		GetPlayerName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerName");
		GetPlayerName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerName_ReturnValue_PropertyAddress, GetPlayerName_FunctionAddress, "ReturnValue");
		GetPlayerName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerName_FunctionAddress, "ReturnValue");
		GetPlayerName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPlayerName_IsValid = GetPlayerName_FunctionAddress != IntPtr.Zero && GetPlayerName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerState:GetPlayerName", GetPlayerName_IsValid);
		GetPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerController");
		GetPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerController_ReturnValue_PropertyAddress, GetPlayerController_FunctionAddress, "ReturnValue");
		GetPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerController_FunctionAddress, "ReturnValue");
		GetPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlayerController_IsValid = GetPlayerController_FunctionAddress != IntPtr.Zero && GetPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerState:GetPlayerController", GetPlayerController_IsValid);
		GetPingInMilliseconds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPingInMilliseconds");
		GetPingInMilliseconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPingInMilliseconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPingInMilliseconds_ReturnValue_PropertyAddress, GetPingInMilliseconds_FunctionAddress, "ReturnValue");
		GetPingInMilliseconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPingInMilliseconds_FunctionAddress, "ReturnValue");
		GetPingInMilliseconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPingInMilliseconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPingInMilliseconds_IsValid = GetPingInMilliseconds_FunctionAddress != IntPtr.Zero && GetPingInMilliseconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerState:GetPingInMilliseconds", GetPingInMilliseconds_IsValid);
		GetPawn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPawn");
		GetPawn_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPawn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPawn_ReturnValue_PropertyAddress, GetPawn_FunctionAddress, "ReturnValue");
		GetPawn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPawn_FunctionAddress, "ReturnValue");
		GetPawn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPawn_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPawn_IsValid = GetPawn_FunctionAddress != IntPtr.Zero && GetPawn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerState:GetPawn", GetPawn_IsValid);
		BP_GetUniqueId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_GetUniqueId");
		BP_GetUniqueId_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_GetUniqueId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_GetUniqueId_ReturnValue_PropertyAddress, BP_GetUniqueId_FunctionAddress, "ReturnValue");
		BP_GetUniqueId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_GetUniqueId_FunctionAddress, "ReturnValue");
		BP_GetUniqueId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_GetUniqueId_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BP_GetUniqueId_IsValid = BP_GetUniqueId_FunctionAddress != IntPtr.Zero && BP_GetUniqueId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerState:BP_GetUniqueId", BP_GetUniqueId_IsValid);
	}
}
