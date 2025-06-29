using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.DebugCameraController", "Engine", UnrealModuleType.Engine)]
public class ADebugCameraController : APlayerController
{
	private static bool SpeedScale_IsValid;

	private static int SpeedScale_Offset;

	private static bool InitialMaxSpeed_IsValid;

	private static int InitialMaxSpeed_Offset;

	private static bool InitialAccel_IsValid;

	private static int InitialAccel_Offset;

	private static bool InitialDecel_IsValid;

	private static int InitialDecel_Offset;

	private static bool ToggleDisplay_IsValid;

	private static IntPtr ToggleDisplay_FunctionAddress;

	private static int ToggleDisplay_ParamsSize;

	private static bool SetPawnMovementSpeedScale_IsValid;

	private static IntPtr SetPawnMovementSpeedScale_FunctionAddress;

	private static int SetPawnMovementSpeedScale_ParamsSize;

	private static bool SetPawnMovementSpeedScale_NewSpeedScale_IsValid;

	private static FFieldAddress SetPawnMovementSpeedScale_NewSpeedScale_PropertyAddress;

	private static int SetPawnMovementSpeedScale_NewSpeedScale_Offset;

	private static bool ReceiveOnDeactivate_IsValid;

	private IntPtr ReceiveOnDeactivate_InstanceFunctionAddress;

	private static IntPtr ReceiveOnDeactivate_FunctionAddress;

	private static int ReceiveOnDeactivate_ParamsSize;

	private static bool ReceiveOnDeactivate_RestoredPC_IsValid;

	private static FFieldAddress ReceiveOnDeactivate_RestoredPC_PropertyAddress;

	private static int ReceiveOnDeactivate_RestoredPC_Offset;

	private static bool ReceiveOnActorSelected_IsValid;

	private IntPtr ReceiveOnActorSelected_InstanceFunctionAddress;

	private static IntPtr ReceiveOnActorSelected_FunctionAddress;

	private static int ReceiveOnActorSelected_ParamsSize;

	private static bool ReceiveOnActorSelected_NewSelectedActor_IsValid;

	private static FFieldAddress ReceiveOnActorSelected_NewSelectedActor_PropertyAddress;

	private static int ReceiveOnActorSelected_NewSelectedActor_Offset;

	private static bool ReceiveOnActorSelected_SelectHitLocation_IsValid;

	private static FFieldAddress ReceiveOnActorSelected_SelectHitLocation_PropertyAddress;

	private static int ReceiveOnActorSelected_SelectHitLocation_Offset;

	private static bool ReceiveOnActorSelected_SelectHitNormal_IsValid;

	private static FFieldAddress ReceiveOnActorSelected_SelectHitNormal_PropertyAddress;

	private static int ReceiveOnActorSelected_SelectHitNormal_Offset;

	private static bool ReceiveOnActorSelected_Hit_IsValid;

	private static FFieldAddress ReceiveOnActorSelected_Hit_PropertyAddress;

	private static int ReceiveOnActorSelected_Hit_Offset;

	private static bool ReceiveOnActivate_IsValid;

	private IntPtr ReceiveOnActivate_InstanceFunctionAddress;

	private static IntPtr ReceiveOnActivate_FunctionAddress;

	private static int ReceiveOnActivate_ParamsSize;

	private static bool ReceiveOnActivate_OriginalPC_IsValid;

	private static FFieldAddress ReceiveOnActivate_OriginalPC_PropertyAddress;

	private static int ReceiveOnActivate_OriginalPC_Offset;

	private static bool GetSelectedActor_IsValid;

	private static IntPtr GetSelectedActor_FunctionAddress;

	private static int GetSelectedActor_ParamsSize;

	private static bool GetSelectedActor_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedActor_ReturnValue_PropertyAddress;

	private static int GetSelectedActor_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234340373uL)]
	[UMetaPath("/Script/Engine.DebugCameraController:SpeedScale")]
	protected float SpeedScale
	{
		get
		{
			CheckDestroyed();
			if (!SpeedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DebugCameraController:SpeedScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DebugCameraController:SpeedScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340373uL)]
	[UMetaPath("/Script/Engine.DebugCameraController:InitialMaxSpeed")]
	protected float InitialMaxSpeed
	{
		get
		{
			CheckDestroyed();
			if (!InitialMaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DebugCameraController:InitialMaxSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InitialMaxSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialMaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DebugCameraController:InitialMaxSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InitialMaxSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340373uL)]
	[UMetaPath("/Script/Engine.DebugCameraController:InitialAccel")]
	protected float InitialAccel
	{
		get
		{
			CheckDestroyed();
			if (!InitialAccel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DebugCameraController:InitialAccel");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InitialAccel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialAccel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DebugCameraController:InitialAccel");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InitialAccel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340373uL)]
	[UMetaPath("/Script/Engine.DebugCameraController:InitialDecel")]
	protected float InitialDecel
	{
		get
		{
			CheckDestroyed();
			if (!InitialDecel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DebugCameraController:InitialDecel");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InitialDecel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialDecel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DebugCameraController:InitialDecel");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InitialDecel_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DebugCameraController:ToggleDisplay")]
	public unsafe void ToggleDisplay()
	{
		CheckDestroyed();
		if (!ToggleDisplay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:ToggleDisplay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleDisplay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleDisplay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ToggleDisplay_FunctionAddress, argsSize: ToggleDisplay_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DebugCameraController:SetPawnMovementSpeedScale")]
	public unsafe void SetPawnMovementSpeedScale(float NewSpeedScale)
	{
		CheckDestroyed();
		if (!SetPawnMovementSpeedScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:SetPawnMovementSpeedScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPawnMovementSpeedScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPawnMovementSpeedScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPawnMovementSpeedScale_NewSpeedScale_Offset), 0, SetPawnMovementSpeedScale_NewSpeedScale_PropertyAddress.Address, NewSpeedScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPawnMovementSpeedScale_FunctionAddress, intPtr, SetPawnMovementSpeedScale_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.DebugCameraController:ReceiveOnDeactivate")]
	public unsafe void ReceiveOnDeactivate(APlayerController RestoredPC)
	{
		CheckDestroyed();
		if (!ReceiveOnDeactivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:ReceiveOnDeactivate");
			return;
		}
		if (ReceiveOnDeactivate_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveOnDeactivate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveOnDeactivate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveOnDeactivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveOnDeactivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ReceiveOnDeactivate_RestoredPC_Offset), 0, ReceiveOnDeactivate_RestoredPC_PropertyAddress.Address, RestoredPC);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveOnDeactivate_InstanceFunctionAddress, intPtr, ReceiveOnDeactivate_ParamsSize);
	}

	protected unsafe virtual void ReceiveOnDeactivate_Implementation(APlayerController RestoredPC)
	{
		CheckDestroyed();
		if (!ReceiveOnDeactivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:ReceiveOnDeactivate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveOnDeactivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveOnDeactivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ReceiveOnDeactivate_RestoredPC_Offset), 0, ReceiveOnDeactivate_RestoredPC_PropertyAddress.Address, RestoredPC);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveOnDeactivate_FunctionAddress, intPtr, ReceiveOnDeactivate_ParamsSize);
	}

	[UFunction(Flags = 147326976u)]
	[UMetaPath("/Script/Engine.DebugCameraController:ReceiveOnActorSelected")]
	protected unsafe void ReceiveOnActorSelected(AActor NewSelectedActor, FVector SelectHitLocation, FVector SelectHitNormal, FHitResult Hit)
	{
		CheckDestroyed();
		if (!ReceiveOnActorSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:ReceiveOnActorSelected");
			return;
		}
		if (ReceiveOnActorSelected_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveOnActorSelected_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveOnActorSelected");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveOnActorSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveOnActorSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveOnActorSelected_NewSelectedActor_Offset), 0, ReceiveOnActorSelected_NewSelectedActor_PropertyAddress.Address, NewSelectedActor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveOnActorSelected_SelectHitLocation_Offset), 0, ReceiveOnActorSelected_SelectHitLocation_PropertyAddress.Address, SelectHitLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveOnActorSelected_SelectHitNormal_Offset), 0, ReceiveOnActorSelected_SelectHitNormal_PropertyAddress.Address, SelectHitNormal);
		NativeReflection.InitializeValue_InContainer(ReceiveOnActorSelected_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, ReceiveOnActorSelected_Hit_Offset), 0, ReceiveOnActorSelected_Hit_PropertyAddress.Address, Hit);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveOnActorSelected_InstanceFunctionAddress, intPtr, ReceiveOnActorSelected_ParamsSize);
	}

	protected unsafe virtual void ReceiveOnActorSelected_Implementation(AActor NewSelectedActor, FVector SelectHitLocation, FVector SelectHitNormal, FHitResult Hit)
	{
		CheckDestroyed();
		if (!ReceiveOnActorSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:ReceiveOnActorSelected");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveOnActorSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveOnActorSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveOnActorSelected_NewSelectedActor_Offset), 0, ReceiveOnActorSelected_NewSelectedActor_PropertyAddress.Address, NewSelectedActor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveOnActorSelected_SelectHitLocation_Offset), 0, ReceiveOnActorSelected_SelectHitLocation_PropertyAddress.Address, SelectHitLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveOnActorSelected_SelectHitNormal_Offset), 0, ReceiveOnActorSelected_SelectHitNormal_PropertyAddress.Address, SelectHitNormal);
		NativeReflection.InitializeValue_InContainer(ReceiveOnActorSelected_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, ReceiveOnActorSelected_Hit_Offset), 0, ReceiveOnActorSelected_Hit_PropertyAddress.Address, Hit);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveOnActorSelected_FunctionAddress, intPtr, ReceiveOnActorSelected_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.DebugCameraController:ReceiveOnActivate")]
	public unsafe void ReceiveOnActivate(APlayerController OriginalPC)
	{
		CheckDestroyed();
		if (!ReceiveOnActivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:ReceiveOnActivate");
			return;
		}
		if (ReceiveOnActivate_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveOnActivate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveOnActivate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveOnActivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveOnActivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ReceiveOnActivate_OriginalPC_Offset), 0, ReceiveOnActivate_OriginalPC_PropertyAddress.Address, OriginalPC);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveOnActivate_InstanceFunctionAddress, intPtr, ReceiveOnActivate_ParamsSize);
	}

	protected unsafe virtual void ReceiveOnActivate_Implementation(APlayerController OriginalPC)
	{
		CheckDestroyed();
		if (!ReceiveOnActivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:ReceiveOnActivate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveOnActivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveOnActivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ReceiveOnActivate_OriginalPC_Offset), 0, ReceiveOnActivate_OriginalPC_PropertyAddress.Address, OriginalPC);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveOnActivate_FunctionAddress, intPtr, ReceiveOnActivate_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.DebugCameraController:GetSelectedActor")]
	public unsafe AActor GetSelectedActor()
	{
		CheckDestroyed();
		if (!GetSelectedActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DebugCameraController:GetSelectedActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedActor_FunctionAddress, intPtr, GetSelectedActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetSelectedActor_ReturnValue_Offset), 0, GetSelectedActor_ReturnValue_PropertyAddress.Address);
	}

	static ADebugCameraController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADebugCameraController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADebugCameraController));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.DebugCameraController");
		SpeedScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedScale");
		SpeedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedScale", Classes.FFloatProperty);
		InitialMaxSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialMaxSpeed");
		InitialMaxSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialMaxSpeed", Classes.FFloatProperty);
		InitialAccel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialAccel");
		InitialAccel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialAccel", Classes.FFloatProperty);
		InitialDecel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialDecel");
		InitialDecel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialDecel", Classes.FFloatProperty);
		ToggleDisplay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToggleDisplay");
		ToggleDisplay_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleDisplay_FunctionAddress);
		ToggleDisplay_IsValid = ToggleDisplay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DebugCameraController:ToggleDisplay", ToggleDisplay_IsValid);
		SetPawnMovementSpeedScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPawnMovementSpeedScale");
		SetPawnMovementSpeedScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPawnMovementSpeedScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPawnMovementSpeedScale_NewSpeedScale_PropertyAddress, SetPawnMovementSpeedScale_FunctionAddress, "NewSpeedScale");
		SetPawnMovementSpeedScale_NewSpeedScale_Offset = NativeReflectionCached.GetPropertyOffset(SetPawnMovementSpeedScale_FunctionAddress, "NewSpeedScale");
		SetPawnMovementSpeedScale_NewSpeedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPawnMovementSpeedScale_FunctionAddress, "NewSpeedScale", Classes.FFloatProperty);
		SetPawnMovementSpeedScale_IsValid = SetPawnMovementSpeedScale_FunctionAddress != IntPtr.Zero && SetPawnMovementSpeedScale_NewSpeedScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DebugCameraController:SetPawnMovementSpeedScale", SetPawnMovementSpeedScale_IsValid);
		ReceiveOnDeactivate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveOnDeactivate");
		ReceiveOnDeactivate_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveOnDeactivate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveOnDeactivate_RestoredPC_PropertyAddress, ReceiveOnDeactivate_FunctionAddress, "RestoredPC");
		ReceiveOnDeactivate_RestoredPC_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveOnDeactivate_FunctionAddress, "RestoredPC");
		ReceiveOnDeactivate_RestoredPC_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveOnDeactivate_FunctionAddress, "RestoredPC", Classes.FObjectProperty);
		ReceiveOnDeactivate_IsValid = ReceiveOnDeactivate_FunctionAddress != IntPtr.Zero && ReceiveOnDeactivate_RestoredPC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DebugCameraController:ReceiveOnDeactivate", ReceiveOnDeactivate_IsValid);
		ReceiveOnActorSelected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveOnActorSelected");
		ReceiveOnActorSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveOnActorSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveOnActorSelected_NewSelectedActor_PropertyAddress, ReceiveOnActorSelected_FunctionAddress, "NewSelectedActor");
		ReceiveOnActorSelected_NewSelectedActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveOnActorSelected_FunctionAddress, "NewSelectedActor");
		ReceiveOnActorSelected_NewSelectedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveOnActorSelected_FunctionAddress, "NewSelectedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveOnActorSelected_SelectHitLocation_PropertyAddress, ReceiveOnActorSelected_FunctionAddress, "SelectHitLocation");
		ReceiveOnActorSelected_SelectHitLocation_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveOnActorSelected_FunctionAddress, "SelectHitLocation");
		ReceiveOnActorSelected_SelectHitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveOnActorSelected_FunctionAddress, "SelectHitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveOnActorSelected_SelectHitNormal_PropertyAddress, ReceiveOnActorSelected_FunctionAddress, "SelectHitNormal");
		ReceiveOnActorSelected_SelectHitNormal_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveOnActorSelected_FunctionAddress, "SelectHitNormal");
		ReceiveOnActorSelected_SelectHitNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveOnActorSelected_FunctionAddress, "SelectHitNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveOnActorSelected_Hit_PropertyAddress, ReceiveOnActorSelected_FunctionAddress, "Hit");
		ReceiveOnActorSelected_Hit_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveOnActorSelected_FunctionAddress, "Hit");
		ReceiveOnActorSelected_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveOnActorSelected_FunctionAddress, "Hit", Classes.FStructProperty);
		ReceiveOnActorSelected_IsValid = ReceiveOnActorSelected_FunctionAddress != IntPtr.Zero && ReceiveOnActorSelected_NewSelectedActor_IsValid && ReceiveOnActorSelected_SelectHitLocation_IsValid && ReceiveOnActorSelected_SelectHitNormal_IsValid && ReceiveOnActorSelected_Hit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DebugCameraController:ReceiveOnActorSelected", ReceiveOnActorSelected_IsValid);
		ReceiveOnActivate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveOnActivate");
		ReceiveOnActivate_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveOnActivate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveOnActivate_OriginalPC_PropertyAddress, ReceiveOnActivate_FunctionAddress, "OriginalPC");
		ReceiveOnActivate_OriginalPC_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveOnActivate_FunctionAddress, "OriginalPC");
		ReceiveOnActivate_OriginalPC_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveOnActivate_FunctionAddress, "OriginalPC", Classes.FObjectProperty);
		ReceiveOnActivate_IsValid = ReceiveOnActivate_FunctionAddress != IntPtr.Zero && ReceiveOnActivate_OriginalPC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DebugCameraController:ReceiveOnActivate", ReceiveOnActivate_IsValid);
		GetSelectedActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedActor");
		GetSelectedActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedActor_ReturnValue_PropertyAddress, GetSelectedActor_FunctionAddress, "ReturnValue");
		GetSelectedActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedActor_FunctionAddress, "ReturnValue");
		GetSelectedActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSelectedActor_IsValid = GetSelectedActor_FunctionAddress != IntPtr.Zero && GetSelectedActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DebugCameraController:GetSelectedActor", GetSelectedActor_IsValid);
	}
}
