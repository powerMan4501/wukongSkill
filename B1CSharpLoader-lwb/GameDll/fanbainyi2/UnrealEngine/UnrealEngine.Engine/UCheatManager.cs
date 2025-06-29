using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CheatManager", "Engine", UnrealModuleType.Engine)]
public class UCheatManager : UObject
{
	private static bool DebugCameraControllerClass_IsValid;

	private static int DebugCameraControllerClass_Offset;

	private static bool Walk_IsValid;

	private static IntPtr Walk_FunctionAddress;

	private static int Walk_ParamsSize;

	private static bool Teleport_IsValid;

	private static IntPtr Teleport_FunctionAddress;

	private static int Teleport_ParamsSize;

	private static bool Slomo_IsValid;

	private static IntPtr Slomo_FunctionAddress;

	private static int Slomo_ParamsSize;

	private static bool Slomo_NewTimeDilation_IsValid;

	private static FFieldAddress Slomo_NewTimeDilation_PropertyAddress;

	private static int Slomo_NewTimeDilation_Offset;

	private static bool ReceiveInitCheatManager_IsValid;

	private IntPtr ReceiveInitCheatManager_InstanceFunctionAddress;

	private static IntPtr ReceiveInitCheatManager_FunctionAddress;

	private static int ReceiveInitCheatManager_ParamsSize;

	private static bool ReceiveEndPlay_IsValid;

	private IntPtr ReceiveEndPlay_InstanceFunctionAddress;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool PlayersOnly_IsValid;

	private static IntPtr PlayersOnly_FunctionAddress;

	private static int PlayersOnly_ParamsSize;

	private static bool God_IsValid;

	private static IntPtr God_FunctionAddress;

	private static int God_ParamsSize;

	private static bool Ghost_IsValid;

	private static IntPtr Ghost_FunctionAddress;

	private static int Ghost_ParamsSize;

	private static bool GetPlayerController_IsValid;

	private static IntPtr GetPlayerController_FunctionAddress;

	private static int GetPlayerController_ParamsSize;

	private static bool GetPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerController_ReturnValue_PropertyAddress;

	private static int GetPlayerController_ReturnValue_Offset;

	private static bool FreezeFrame_IsValid;

	private static IntPtr FreezeFrame_FunctionAddress;

	private static int FreezeFrame_ParamsSize;

	private static bool FreezeFrame_Delay_IsValid;

	private static FFieldAddress FreezeFrame_Delay_PropertyAddress;

	private static int FreezeFrame_Delay_Offset;

	private static bool Fly_IsValid;

	private static IntPtr Fly_FunctionAddress;

	private static int Fly_ParamsSize;

	private static bool EnableDebugCamera_IsValid;

	private static IntPtr EnableDebugCamera_FunctionAddress;

	private static int EnableDebugCamera_ParamsSize;

	private static bool DisableDebugCamera_IsValid;

	private static IntPtr DisableDebugCamera_FunctionAddress;

	private static int DisableDebugCamera_ParamsSize;

	private static bool DestroyTarget_IsValid;

	private static IntPtr DestroyTarget_FunctionAddress;

	private static int DestroyTarget_ParamsSize;

	private static bool DamageTarget_IsValid;

	private static IntPtr DamageTarget_FunctionAddress;

	private static int DamageTarget_ParamsSize;

	private static bool DamageTarget_DamageAmount_IsValid;

	private static FFieldAddress DamageTarget_DamageAmount_PropertyAddress;

	private static int DamageTarget_DamageAmount_Offset;

	private static bool ChangeSize_IsValid;

	private static IntPtr ChangeSize_FunctionAddress;

	private static int ChangeSize_ParamsSize;

	private static bool ChangeSize_F_IsValid;

	private static FFieldAddress ChangeSize_F_PropertyAddress;

	private static int ChangeSize_F_Offset;

	[UProperty(Flags = (PropFlags)7881369141182997uL)]
	[UMetaPath("/Script/Engine.CheatManager:DebugCameraControllerClass")]
	protected TSubclassOf<ADebugCameraController> DebugCameraControllerClass
	{
		get
		{
			CheckDestroyed();
			if (!DebugCameraControllerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CheatManager:DebugCameraControllerClass");
				return default(TSubclassOf<ADebugCameraController>);
			}
			return TSubclassOfMarshaler<ADebugCameraController>.FromNative(IntPtr.Add(base.Address, DebugCameraControllerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugCameraControllerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CheatManager:DebugCameraControllerClass");
			}
			else
			{
				TSubclassOfMarshaler<ADebugCameraController>.ToNative(IntPtr.Add(base.Address, DebugCameraControllerClass_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:Walk")]
	public unsafe void Walk()
	{
		CheckDestroyed();
		if (!Walk_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:Walk");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Walk_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Walk_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Walk_FunctionAddress, argsSize: Walk_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:Teleport")]
	public unsafe void Teleport()
	{
		CheckDestroyed();
		if (!Teleport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:Teleport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Teleport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Teleport_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Teleport_FunctionAddress, argsSize: Teleport_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:Slomo")]
	public unsafe void Slomo(float NewTimeDilation)
	{
		CheckDestroyed();
		if (!Slomo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:Slomo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Slomo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Slomo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Slomo_NewTimeDilation_Offset), 0, Slomo_NewTimeDilation_PropertyAddress.Address, NewTimeDilation);
		NativeReflection.InvokeFunctionOptimized(base.Address, Slomo_FunctionAddress, intPtr, Slomo_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.CheatManager:ReceiveInitCheatManager")]
	public unsafe void ReceiveInitCheatManager()
	{
		CheckDestroyed();
		if (!ReceiveInitCheatManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:ReceiveInitCheatManager");
			return;
		}
		if (ReceiveInitCheatManager_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveInitCheatManager_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveInitCheatManager");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveInitCheatManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveInitCheatManager_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveInitCheatManager_InstanceFunctionAddress, argsSize: ReceiveInitCheatManager_ParamsSize);
	}

	protected unsafe virtual void ReceiveInitCheatManager_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveInitCheatManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:ReceiveInitCheatManager");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveInitCheatManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveInitCheatManager_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveInitCheatManager_FunctionAddress, argsSize: ReceiveInitCheatManager_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.CheatManager:ReceiveEndPlay")]
	public unsafe void ReceiveEndPlay()
	{
		CheckDestroyed();
		if (!ReceiveEndPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:ReceiveEndPlay");
			return;
		}
		if (ReceiveEndPlay_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveEndPlay_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveEndPlay");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveEndPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveEndPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveEndPlay_InstanceFunctionAddress, argsSize: ReceiveEndPlay_ParamsSize);
	}

	protected unsafe virtual void ReceiveEndPlay_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveEndPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:ReceiveEndPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveEndPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveEndPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveEndPlay_FunctionAddress, argsSize: ReceiveEndPlay_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:PlayersOnly")]
	public unsafe void PlayersOnly()
	{
		CheckDestroyed();
		if (!PlayersOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:PlayersOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayersOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayersOnly_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayersOnly_FunctionAddress, argsSize: PlayersOnly_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:God")]
	public unsafe void God()
	{
		CheckDestroyed();
		if (!God_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:God");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(God_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)God_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: God_FunctionAddress, argsSize: God_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:Ghost")]
	public unsafe void Ghost()
	{
		CheckDestroyed();
		if (!Ghost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:Ghost");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Ghost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Ghost_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Ghost_FunctionAddress, argsSize: Ghost_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CheatManager:GetPlayerController")]
	public unsafe APlayerController GetPlayerController()
	{
		CheckDestroyed();
		if (!GetPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:GetPlayerController");
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

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:FreezeFrame")]
	public unsafe void FreezeFrame(float Delay)
	{
		CheckDestroyed();
		if (!FreezeFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:FreezeFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FreezeFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FreezeFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FreezeFrame_Delay_Offset), 0, FreezeFrame_Delay_PropertyAddress.Address, Delay);
		NativeReflection.InvokeFunctionOptimized(base.Address, FreezeFrame_FunctionAddress, intPtr, FreezeFrame_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:Fly")]
	public unsafe void Fly()
	{
		CheckDestroyed();
		if (!Fly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:Fly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Fly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Fly_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Fly_FunctionAddress, argsSize: Fly_ParamsSize);
	}

	[UFunction(Flags = 67634176u)]
	[UMetaPath("/Script/Engine.CheatManager:EnableDebugCamera")]
	protected unsafe void EnableDebugCamera()
	{
		CheckDestroyed();
		if (!EnableDebugCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:EnableDebugCamera");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableDebugCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableDebugCamera_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EnableDebugCamera_FunctionAddress, argsSize: EnableDebugCamera_ParamsSize);
	}

	[UFunction(Flags = 67634176u)]
	[UMetaPath("/Script/Engine.CheatManager:DisableDebugCamera")]
	protected unsafe void DisableDebugCamera()
	{
		CheckDestroyed();
		if (!DisableDebugCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:DisableDebugCamera");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableDebugCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableDebugCamera_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableDebugCamera_FunctionAddress, argsSize: DisableDebugCamera_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:DestroyTarget")]
	public unsafe void DestroyTarget()
	{
		CheckDestroyed();
		if (!DestroyTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:DestroyTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyTarget_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DestroyTarget_FunctionAddress, argsSize: DestroyTarget_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:DamageTarget")]
	public unsafe void DamageTarget(float DamageAmount)
	{
		CheckDestroyed();
		if (!DamageTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:DamageTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DamageTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DamageTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DamageTarget_DamageAmount_Offset), 0, DamageTarget_DamageAmount_PropertyAddress.Address, DamageAmount);
		NativeReflection.InvokeFunctionOptimized(base.Address, DamageTarget_FunctionAddress, intPtr, DamageTarget_ParamsSize);
	}

	[UFunction(Flags = 67241472u)]
	[UMetaPath("/Script/Engine.CheatManager:ChangeSize")]
	public unsafe void ChangeSize(float F)
	{
		CheckDestroyed();
		if (!ChangeSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManager:ChangeSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ChangeSize_F_Offset), 0, ChangeSize_F_PropertyAddress.Address, F);
		NativeReflection.InvokeFunctionOptimized(base.Address, ChangeSize_FunctionAddress, intPtr, ChangeSize_ParamsSize);
	}

	static UCheatManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCheatManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCheatManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CheatManager");
		DebugCameraControllerClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugCameraControllerClass");
		DebugCameraControllerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugCameraControllerClass", Classes.FClassProperty);
		Walk_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Walk");
		Walk_ParamsSize = NativeReflection.GetFunctionParamsSize(Walk_FunctionAddress);
		Walk_IsValid = Walk_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:Walk", Walk_IsValid);
		Teleport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Teleport");
		Teleport_ParamsSize = NativeReflection.GetFunctionParamsSize(Teleport_FunctionAddress);
		Teleport_IsValid = Teleport_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:Teleport", Teleport_IsValid);
		Slomo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Slomo");
		Slomo_ParamsSize = NativeReflection.GetFunctionParamsSize(Slomo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Slomo_NewTimeDilation_PropertyAddress, Slomo_FunctionAddress, "NewTimeDilation");
		Slomo_NewTimeDilation_Offset = NativeReflectionCached.GetPropertyOffset(Slomo_FunctionAddress, "NewTimeDilation");
		Slomo_NewTimeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(Slomo_FunctionAddress, "NewTimeDilation", Classes.FFloatProperty);
		Slomo_IsValid = Slomo_FunctionAddress != IntPtr.Zero && Slomo_NewTimeDilation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:Slomo", Slomo_IsValid);
		ReceiveInitCheatManager_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveInitCheatManager");
		ReceiveInitCheatManager_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveInitCheatManager_FunctionAddress);
		ReceiveInitCheatManager_IsValid = ReceiveInitCheatManager_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:ReceiveInitCheatManager", ReceiveInitCheatManager_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		PlayersOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayersOnly");
		PlayersOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayersOnly_FunctionAddress);
		PlayersOnly_IsValid = PlayersOnly_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:PlayersOnly", PlayersOnly_IsValid);
		God_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "God");
		God_ParamsSize = NativeReflection.GetFunctionParamsSize(God_FunctionAddress);
		God_IsValid = God_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:God", God_IsValid);
		Ghost_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Ghost");
		Ghost_ParamsSize = NativeReflection.GetFunctionParamsSize(Ghost_FunctionAddress);
		Ghost_IsValid = Ghost_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:Ghost", Ghost_IsValid);
		GetPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerController");
		GetPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerController_ReturnValue_PropertyAddress, GetPlayerController_FunctionAddress, "ReturnValue");
		GetPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerController_FunctionAddress, "ReturnValue");
		GetPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlayerController_IsValid = GetPlayerController_FunctionAddress != IntPtr.Zero && GetPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:GetPlayerController", GetPlayerController_IsValid);
		FreezeFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FreezeFrame");
		FreezeFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(FreezeFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FreezeFrame_Delay_PropertyAddress, FreezeFrame_FunctionAddress, "Delay");
		FreezeFrame_Delay_Offset = NativeReflectionCached.GetPropertyOffset(FreezeFrame_FunctionAddress, "Delay");
		FreezeFrame_Delay_IsValid = NativeReflectionCached.ValidatePropertyClass(FreezeFrame_FunctionAddress, "Delay", Classes.FFloatProperty);
		FreezeFrame_IsValid = FreezeFrame_FunctionAddress != IntPtr.Zero && FreezeFrame_Delay_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:FreezeFrame", FreezeFrame_IsValid);
		Fly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Fly");
		Fly_ParamsSize = NativeReflection.GetFunctionParamsSize(Fly_FunctionAddress);
		Fly_IsValid = Fly_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:Fly", Fly_IsValid);
		EnableDebugCamera_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableDebugCamera");
		EnableDebugCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableDebugCamera_FunctionAddress);
		EnableDebugCamera_IsValid = EnableDebugCamera_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:EnableDebugCamera", EnableDebugCamera_IsValid);
		DisableDebugCamera_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableDebugCamera");
		DisableDebugCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableDebugCamera_FunctionAddress);
		DisableDebugCamera_IsValid = DisableDebugCamera_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:DisableDebugCamera", DisableDebugCamera_IsValid);
		DestroyTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DestroyTarget");
		DestroyTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyTarget_FunctionAddress);
		DestroyTarget_IsValid = DestroyTarget_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:DestroyTarget", DestroyTarget_IsValid);
		DamageTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DamageTarget");
		DamageTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(DamageTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DamageTarget_DamageAmount_PropertyAddress, DamageTarget_FunctionAddress, "DamageAmount");
		DamageTarget_DamageAmount_Offset = NativeReflectionCached.GetPropertyOffset(DamageTarget_FunctionAddress, "DamageAmount");
		DamageTarget_DamageAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(DamageTarget_FunctionAddress, "DamageAmount", Classes.FFloatProperty);
		DamageTarget_IsValid = DamageTarget_FunctionAddress != IntPtr.Zero && DamageTarget_DamageAmount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:DamageTarget", DamageTarget_IsValid);
		ChangeSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChangeSize");
		ChangeSize_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeSize_F_PropertyAddress, ChangeSize_FunctionAddress, "F");
		ChangeSize_F_Offset = NativeReflectionCached.GetPropertyOffset(ChangeSize_FunctionAddress, "F");
		ChangeSize_F_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeSize_FunctionAddress, "F", Classes.FFloatProperty);
		ChangeSize_IsValid = ChangeSize_FunctionAddress != IntPtr.Zero && ChangeSize_F_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManager:ChangeSize", ChangeSize_IsValid);
	}
}
