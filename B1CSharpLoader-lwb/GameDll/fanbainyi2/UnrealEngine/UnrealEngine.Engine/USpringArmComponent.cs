using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SpringArmComponent", "Engine", UnrealModuleType.Engine)]
public class USpringArmComponent : USceneComponent
{
	private static bool TargetArmLength_IsValid;

	private static int TargetArmLength_Offset;

	private static bool SocketOffset_IsValid;

	private static int SocketOffset_Offset;

	private static bool TargetOffset_IsValid;

	private static int TargetOffset_Offset;

	private static bool ProbeSize_IsValid;

	private static int ProbeSize_Offset;

	private static bool ProbeChannel_IsValid;

	private static FFieldAddress ProbeChannel_PropertyAddress;

	private static int ProbeChannel_Offset;

	private static bool DoCollisionTest_IsValid;

	private static FFieldAddress DoCollisionTest_PropertyAddress;

	private static int DoCollisionTest_Offset;

	private static bool UsePawnControlRotation_IsValid;

	private static FFieldAddress UsePawnControlRotation_PropertyAddress;

	private static int UsePawnControlRotation_Offset;

	private static bool InheritPitch_IsValid;

	private static FFieldAddress InheritPitch_PropertyAddress;

	private static int InheritPitch_Offset;

	private static bool InheritYaw_IsValid;

	private static FFieldAddress InheritYaw_PropertyAddress;

	private static int InheritYaw_Offset;

	private static bool InheritRoll_IsValid;

	private static FFieldAddress InheritRoll_PropertyAddress;

	private static int InheritRoll_Offset;

	private static bool EnableCameraLag_IsValid;

	private static FFieldAddress EnableCameraLag_PropertyAddress;

	private static int EnableCameraLag_Offset;

	private static bool EnableCameraRotationLag_IsValid;

	private static FFieldAddress EnableCameraRotationLag_PropertyAddress;

	private static int EnableCameraRotationLag_Offset;

	private static bool UseCameraLagSubstepping_IsValid;

	private static FFieldAddress UseCameraLagSubstepping_PropertyAddress;

	private static int UseCameraLagSubstepping_Offset;

	private static bool DrawDebugLagMarkers_IsValid;

	private static FFieldAddress DrawDebugLagMarkers_PropertyAddress;

	private static int DrawDebugLagMarkers_Offset;

	private static bool CameraLagSpeed_IsValid;

	private static int CameraLagSpeed_Offset;

	private static bool CameraRotationLagSpeed_IsValid;

	private static int CameraRotationLagSpeed_Offset;

	private static bool CameraLagMaxTimeStep_IsValid;

	private static int CameraLagMaxTimeStep_Offset;

	private static bool CameraLagMaxDistance_IsValid;

	private static int CameraLagMaxDistance_Offset;

	private static bool ClampToMaxPhysicsDeltaTime_IsValid;

	private static FFieldAddress ClampToMaxPhysicsDeltaTime_PropertyAddress;

	private static int ClampToMaxPhysicsDeltaTime_Offset;

	private static bool IsCollisionFixApplied_IsValid;

	private static IntPtr IsCollisionFixApplied_FunctionAddress;

	private static int IsCollisionFixApplied_ParamsSize;

	private static bool IsCollisionFixApplied_ReturnValue_IsValid;

	private static FFieldAddress IsCollisionFixApplied_ReturnValue_PropertyAddress;

	private static int IsCollisionFixApplied_ReturnValue_Offset;

	private static bool GetUnfixedCameraPosition_IsValid;

	private static IntPtr GetUnfixedCameraPosition_FunctionAddress;

	private static int GetUnfixedCameraPosition_ParamsSize;

	private static bool GetUnfixedCameraPosition_ReturnValue_IsValid;

	private static FFieldAddress GetUnfixedCameraPosition_ReturnValue_PropertyAddress;

	private static int GetUnfixedCameraPosition_ReturnValue_Offset;

	private static bool GetTargetRotation_IsValid;

	private static IntPtr GetTargetRotation_FunctionAddress;

	private static int GetTargetRotation_ParamsSize;

	private static bool GetTargetRotation_ReturnValue_IsValid;

	private static FFieldAddress GetTargetRotation_ReturnValue_PropertyAddress;

	private static int GetTargetRotation_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:TargetArmLength")]
	public float TargetArmLength
	{
		get
		{
			CheckDestroyed();
			if (!TargetArmLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:TargetArmLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TargetArmLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetArmLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:TargetArmLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TargetArmLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:SocketOffset")]
	public FVector SocketOffset
	{
		get
		{
			CheckDestroyed();
			if (!SocketOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:SocketOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, SocketOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:SocketOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, SocketOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:TargetOffset")]
	public FVector TargetOffset
	{
		get
		{
			CheckDestroyed();
			if (!TargetOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:TargetOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, TargetOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:TargetOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, TargetOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:ProbeSize")]
	public float ProbeSize
	{
		get
		{
			CheckDestroyed();
			if (!ProbeSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:ProbeSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProbeSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProbeSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:ProbeSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProbeSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:ProbeChannel")]
	public ECollisionChannel ProbeChannel
	{
		get
		{
			CheckDestroyed();
			if (!ProbeChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:ProbeChannel");
				return ECollisionChannel.ECC_WorldStatic;
			}
			return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(base.Address, ProbeChannel_Offset), 0, ProbeChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProbeChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:ProbeChannel");
			}
			else
			{
				EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(base.Address, ProbeChannel_Offset), 0, ProbeChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bDoCollisionTest")]
	public bool DoCollisionTest
	{
		get
		{
			CheckDestroyed();
			if (!DoCollisionTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bDoCollisionTest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DoCollisionTest_Offset), 0, DoCollisionTest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DoCollisionTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bDoCollisionTest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DoCollisionTest_Offset), 0, DoCollisionTest_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bUsePawnControlRotation")]
	public bool UsePawnControlRotation
	{
		get
		{
			CheckDestroyed();
			if (!UsePawnControlRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bUsePawnControlRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePawnControlRotation_Offset), 0, UsePawnControlRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePawnControlRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bUsePawnControlRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePawnControlRotation_Offset), 0, UsePawnControlRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bInheritPitch")]
	public bool InheritPitch
	{
		get
		{
			CheckDestroyed();
			if (!InheritPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bInheritPitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InheritPitch_Offset), 0, InheritPitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InheritPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bInheritPitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InheritPitch_Offset), 0, InheritPitch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bInheritYaw")]
	public bool InheritYaw
	{
		get
		{
			CheckDestroyed();
			if (!InheritYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bInheritYaw");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InheritYaw_Offset), 0, InheritYaw_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InheritYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bInheritYaw");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InheritYaw_Offset), 0, InheritYaw_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bInheritRoll")]
	public bool InheritRoll
	{
		get
		{
			CheckDestroyed();
			if (!InheritRoll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bInheritRoll");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InheritRoll_Offset), 0, InheritRoll_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InheritRoll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bInheritRoll");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InheritRoll_Offset), 0, InheritRoll_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bEnableCameraLag")]
	public bool EnableCameraLag
	{
		get
		{
			CheckDestroyed();
			if (!EnableCameraLag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bEnableCameraLag");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCameraLag_Offset), 0, EnableCameraLag_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCameraLag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bEnableCameraLag");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCameraLag_Offset), 0, EnableCameraLag_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bEnableCameraRotationLag")]
	public bool EnableCameraRotationLag
	{
		get
		{
			CheckDestroyed();
			if (!EnableCameraRotationLag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bEnableCameraRotationLag");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCameraRotationLag_Offset), 0, EnableCameraRotationLag_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCameraRotationLag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bEnableCameraRotationLag");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCameraRotationLag_Offset), 0, EnableCameraRotationLag_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bUseCameraLagSubstepping")]
	public bool UseCameraLagSubstepping
	{
		get
		{
			CheckDestroyed();
			if (!UseCameraLagSubstepping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bUseCameraLagSubstepping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCameraLagSubstepping_Offset), 0, UseCameraLagSubstepping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCameraLagSubstepping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bUseCameraLagSubstepping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCameraLagSubstepping_Offset), 0, UseCameraLagSubstepping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bDrawDebugLagMarkers")]
	public bool DrawDebugLagMarkers
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebugLagMarkers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bDrawDebugLagMarkers");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawDebugLagMarkers_Offset), 0, DrawDebugLagMarkers_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebugLagMarkers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bDrawDebugLagMarkers");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawDebugLagMarkers_Offset), 0, DrawDebugLagMarkers_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:CameraLagSpeed")]
	public float CameraLagSpeed
	{
		get
		{
			CheckDestroyed();
			if (!CameraLagSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:CameraLagSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraLagSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLagSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:CameraLagSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraLagSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:CameraRotationLagSpeed")]
	public float CameraRotationLagSpeed
	{
		get
		{
			CheckDestroyed();
			if (!CameraRotationLagSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:CameraRotationLagSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraRotationLagSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraRotationLagSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:CameraRotationLagSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraRotationLagSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:CameraLagMaxTimeStep")]
	public float CameraLagMaxTimeStep
	{
		get
		{
			CheckDestroyed();
			if (!CameraLagMaxTimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:CameraLagMaxTimeStep");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraLagMaxTimeStep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLagMaxTimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:CameraLagMaxTimeStep");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraLagMaxTimeStep_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:CameraLagMaxDistance")]
	public float CameraLagMaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!CameraLagMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:CameraLagMaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraLagMaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLagMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:CameraLagMaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraLagMaxDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SpringArmComponent:bClampToMaxPhysicsDeltaTime")]
	public bool ClampToMaxPhysicsDeltaTime
	{
		get
		{
			CheckDestroyed();
			if (!ClampToMaxPhysicsDeltaTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bClampToMaxPhysicsDeltaTime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClampToMaxPhysicsDeltaTime_Offset), 0, ClampToMaxPhysicsDeltaTime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClampToMaxPhysicsDeltaTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpringArmComponent:bClampToMaxPhysicsDeltaTime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClampToMaxPhysicsDeltaTime_Offset), 0, ClampToMaxPhysicsDeltaTime_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SpringArmComponent:IsCollisionFixApplied")]
	public unsafe bool IsCollisionFixApplied()
	{
		CheckDestroyed();
		if (!IsCollisionFixApplied_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SpringArmComponent:IsCollisionFixApplied");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCollisionFixApplied_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCollisionFixApplied_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCollisionFixApplied_FunctionAddress, intPtr, IsCollisionFixApplied_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCollisionFixApplied_ReturnValue_Offset), 0, IsCollisionFixApplied_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SpringArmComponent:GetUnfixedCameraPosition")]
	public unsafe FVector GetUnfixedCameraPosition()
	{
		CheckDestroyed();
		if (!GetUnfixedCameraPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SpringArmComponent:GetUnfixedCameraPosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnfixedCameraPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnfixedCameraPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnfixedCameraPosition_FunctionAddress, intPtr, GetUnfixedCameraPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetUnfixedCameraPosition_ReturnValue_Offset), 0, GetUnfixedCameraPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SpringArmComponent:GetTargetRotation")]
	public unsafe FRotator GetTargetRotation()
	{
		CheckDestroyed();
		if (!GetTargetRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SpringArmComponent:GetTargetRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTargetRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTargetRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTargetRotation_FunctionAddress, intPtr, GetTargetRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetTargetRotation_ReturnValue_Offset), 0, GetTargetRotation_ReturnValue_PropertyAddress.Address);
	}

	static USpringArmComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USpringArmComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USpringArmComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SpringArmComponent");
		TargetArmLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetArmLength");
		TargetArmLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetArmLength", Classes.FFloatProperty);
		SocketOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketOffset");
		SocketOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketOffset", Classes.FStructProperty);
		TargetOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetOffset");
		TargetOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetOffset", Classes.FStructProperty);
		ProbeSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProbeSize");
		ProbeSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProbeSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ProbeChannel_PropertyAddress, intPtr, "ProbeChannel");
		ProbeChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProbeChannel");
		ProbeChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProbeChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DoCollisionTest_PropertyAddress, intPtr, "bDoCollisionTest");
		DoCollisionTest_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDoCollisionTest");
		DoCollisionTest_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDoCollisionTest", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsePawnControlRotation_PropertyAddress, intPtr, "bUsePawnControlRotation");
		UsePawnControlRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUsePawnControlRotation");
		UsePawnControlRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUsePawnControlRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InheritPitch_PropertyAddress, intPtr, "bInheritPitch");
		InheritPitch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInheritPitch");
		InheritPitch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInheritPitch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InheritYaw_PropertyAddress, intPtr, "bInheritYaw");
		InheritYaw_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInheritYaw");
		InheritYaw_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInheritYaw", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InheritRoll_PropertyAddress, intPtr, "bInheritRoll");
		InheritRoll_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInheritRoll");
		InheritRoll_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInheritRoll", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCameraLag_PropertyAddress, intPtr, "bEnableCameraLag");
		EnableCameraLag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableCameraLag");
		EnableCameraLag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableCameraLag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCameraRotationLag_PropertyAddress, intPtr, "bEnableCameraRotationLag");
		EnableCameraRotationLag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableCameraRotationLag");
		EnableCameraRotationLag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableCameraRotationLag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCameraLagSubstepping_PropertyAddress, intPtr, "bUseCameraLagSubstepping");
		UseCameraLagSubstepping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCameraLagSubstepping");
		UseCameraLagSubstepping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCameraLagSubstepping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugLagMarkers_PropertyAddress, intPtr, "bDrawDebugLagMarkers");
		DrawDebugLagMarkers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawDebugLagMarkers");
		DrawDebugLagMarkers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawDebugLagMarkers", Classes.FBoolProperty);
		CameraLagSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraLagSpeed");
		CameraLagSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraLagSpeed", Classes.FFloatProperty);
		CameraRotationLagSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraRotationLagSpeed");
		CameraRotationLagSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraRotationLagSpeed", Classes.FFloatProperty);
		CameraLagMaxTimeStep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraLagMaxTimeStep");
		CameraLagMaxTimeStep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraLagMaxTimeStep", Classes.FFloatProperty);
		CameraLagMaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraLagMaxDistance");
		CameraLagMaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraLagMaxDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ClampToMaxPhysicsDeltaTime_PropertyAddress, intPtr, "bClampToMaxPhysicsDeltaTime");
		ClampToMaxPhysicsDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClampToMaxPhysicsDeltaTime");
		ClampToMaxPhysicsDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClampToMaxPhysicsDeltaTime", Classes.FBoolProperty);
		IsCollisionFixApplied_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsCollisionFixApplied");
		IsCollisionFixApplied_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCollisionFixApplied_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCollisionFixApplied_ReturnValue_PropertyAddress, IsCollisionFixApplied_FunctionAddress, "ReturnValue");
		IsCollisionFixApplied_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCollisionFixApplied_FunctionAddress, "ReturnValue");
		IsCollisionFixApplied_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCollisionFixApplied_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCollisionFixApplied_IsValid = IsCollisionFixApplied_FunctionAddress != IntPtr.Zero && IsCollisionFixApplied_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SpringArmComponent:IsCollisionFixApplied", IsCollisionFixApplied_IsValid);
		GetUnfixedCameraPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUnfixedCameraPosition");
		GetUnfixedCameraPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnfixedCameraPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnfixedCameraPosition_ReturnValue_PropertyAddress, GetUnfixedCameraPosition_FunctionAddress, "ReturnValue");
		GetUnfixedCameraPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnfixedCameraPosition_FunctionAddress, "ReturnValue");
		GetUnfixedCameraPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnfixedCameraPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUnfixedCameraPosition_IsValid = GetUnfixedCameraPosition_FunctionAddress != IntPtr.Zero && GetUnfixedCameraPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SpringArmComponent:GetUnfixedCameraPosition", GetUnfixedCameraPosition_IsValid);
		GetTargetRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTargetRotation");
		GetTargetRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTargetRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTargetRotation_ReturnValue_PropertyAddress, GetTargetRotation_FunctionAddress, "ReturnValue");
		GetTargetRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetRotation_FunctionAddress, "ReturnValue");
		GetTargetRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTargetRotation_IsValid = GetTargetRotation_FunctionAddress != IntPtr.Zero && GetTargetRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SpringArmComponent:GetTargetRotation", GetTargetRotation_IsValid);
	}
}
