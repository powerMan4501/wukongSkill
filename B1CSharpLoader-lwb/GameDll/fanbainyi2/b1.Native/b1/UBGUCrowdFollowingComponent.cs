using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)819986596uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUCrowdFollowingComponent", "b1", UnrealModuleType.Game)]
public class UBGUCrowdFollowingComponent : UGSCrowdFollowingComponent
{
	private static bool Pause_IsValid;

	private static FFieldAddress Pause_PropertyAddress;

	private static int Pause_Offset;

	private static bool DesiredVelocity_IsValid;

	private static int DesiredVelocity_Offset;

	private static bool DesiredAngleDelta_IsValid;

	private static int DesiredAngleDelta_Offset;

	private static bool RequestedVelocity_IsValid;

	private static int RequestedVelocity_Offset;

	private static bool YawDelta_IsValid;

	private static int YawDelta_Offset;

	private static bool TerrainRotation_IsValid;

	private static int TerrainRotation_Offset;

	private static bool SpeedLimit_IsValid;

	private static int SpeedLimit_Offset;

	private static bool DeltaPosition_IsValid;

	private static int DeltaPosition_Offset;

	private static bool RotationSpeedMax_IsValid;

	private static int RotationSpeedMax_Offset;

	private static bool RotationSpeedAcc_IsValid;

	private static int RotationSpeedAcc_Offset;

	private static bool SupportFlock_IsValid;

	private static FFieldAddress SupportFlock_PropertyAddress;

	private static int SupportFlock_Offset;

	private static bool SetCrowdFollowingParam_IsValid;

	private static IntPtr SetCrowdFollowingParam_FunctionAddress;

	private static int SetCrowdFollowingParam_ParamsSize;

	private static bool SetCrowdFollowingParam_fSeparationWeight_IsValid;

	private static FFieldAddress SetCrowdFollowingParam_fSeparationWeight_PropertyAddress;

	private static int SetCrowdFollowingParam_fSeparationWeight_Offset;

	private static bool SetCrowdFollowingParam_fCollisionQueryRange_IsValid;

	private static FFieldAddress SetCrowdFollowingParam_fCollisionQueryRange_PropertyAddress;

	private static int SetCrowdFollowingParam_fCollisionQueryRange_Offset;

	private static bool SetCrowdFollowingParam_fPathOptimizationRange_IsValid;

	private static FFieldAddress SetCrowdFollowingParam_fPathOptimizationRange_PropertyAddress;

	private static int SetCrowdFollowingParam_fPathOptimizationRange_Offset;

	private static bool SetCrowdFollowingParam_iAvoidanceQualityLevel_IsValid;

	private static FFieldAddress SetCrowdFollowingParam_iAvoidanceQualityLevel_PropertyAddress;

	private static int SetCrowdFollowingParam_iAvoidanceQualityLevel_Offset;

	private static bool SetCrowdFollowingEnabled_IsValid;

	private static IntPtr SetCrowdFollowingEnabled_FunctionAddress;

	private static int SetCrowdFollowingEnabled_ParamsSize;

	private static bool SetCrowdFollowingEnabled_bEnabled_IsValid;

	private static FFieldAddress SetCrowdFollowingEnabled_bEnabled_PropertyAddress;

	private static int SetCrowdFollowingEnabled_bEnabled_Offset;

	private static bool SetCrowdFollowingEnabled_bIsObstacle_IsValid;

	private static FFieldAddress SetCrowdFollowingEnabled_bIsObstacle_PropertyAddress;

	private static int SetCrowdFollowingEnabled_bIsObstacle_Offset;

	[UProperty(Flags = (PropFlags)6755469234283012uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:bPause")]
	public bool Pause
	{
		get
		{
			CheckDestroyed();
			if (!Pause_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:bPause");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Pause_Offset), 0, Pause_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Pause_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:bPause");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Pause_Offset), 0, Pause_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:DesiredVelocity")]
	public FVector DesiredVelocity
	{
		get
		{
			CheckDestroyed();
			if (!DesiredVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:DesiredVelocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, DesiredVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DesiredVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:DesiredVelocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, DesiredVelocity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:DesiredAngleDelta")]
	public float DesiredAngleDelta
	{
		get
		{
			CheckDestroyed();
			if (!DesiredAngleDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:DesiredAngleDelta");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DesiredAngleDelta_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DesiredAngleDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:DesiredAngleDelta");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DesiredAngleDelta_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:RequestedVelocity")]
	public FVector RequestedVelocity
	{
		get
		{
			CheckDestroyed();
			if (!RequestedVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:RequestedVelocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RequestedVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RequestedVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:RequestedVelocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RequestedVelocity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:YawDelta")]
	public float YawDelta
	{
		get
		{
			CheckDestroyed();
			if (!YawDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:YawDelta");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, YawDelta_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YawDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:YawDelta");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, YawDelta_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420720661uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:TerrainRotation")]
	public FRotator TerrainRotation
	{
		get
		{
			CheckDestroyed();
			if (!TerrainRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:TerrainRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, TerrainRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TerrainRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:TerrainRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, TerrainRotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:SpeedLimit")]
	public float SpeedLimit
	{
		get
		{
			CheckDestroyed();
			if (!SpeedLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:SpeedLimit");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:SpeedLimit");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedLimit_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:DeltaPosition")]
	public FVector DeltaPosition
	{
		get
		{
			CheckDestroyed();
			if (!DeltaPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:DeltaPosition");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, DeltaPosition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeltaPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:DeltaPosition");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, DeltaPosition_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:RotationSpeedMax")]
	public float RotationSpeedMax
	{
		get
		{
			CheckDestroyed();
			if (!RotationSpeedMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:RotationSpeedMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotationSpeedMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationSpeedMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:RotationSpeedMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotationSpeedMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:RotationSpeedAcc")]
	public float RotationSpeedAcc
	{
		get
		{
			CheckDestroyed();
			if (!RotationSpeedAcc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:RotationSpeedAcc");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotationSpeedAcc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationSpeedAcc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:RotationSpeedAcc");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotationSpeedAcc_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:bSupportFlock")]
	public bool SupportFlock
	{
		get
		{
			CheckDestroyed();
			if (!SupportFlock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:bSupportFlock");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SupportFlock_Offset), 0, SupportFlock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SupportFlock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCrowdFollowingComponent:bSupportFlock");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SupportFlock_Offset), 0, SupportFlock_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:SetCrowdFollowingParam")]
	public unsafe void SetCrowdFollowingParam(float fSeparationWeight, float fCollisionQueryRange, float fPathOptimizationRange, int iAvoidanceQualityLevel)
	{
		CheckDestroyed();
		if (!SetCrowdFollowingParam_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCrowdFollowingComponent:SetCrowdFollowingParam");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCrowdFollowingParam_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCrowdFollowingParam_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCrowdFollowingParam_fSeparationWeight_Offset), 0, SetCrowdFollowingParam_fSeparationWeight_PropertyAddress.Address, fSeparationWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCrowdFollowingParam_fCollisionQueryRange_Offset), 0, SetCrowdFollowingParam_fCollisionQueryRange_PropertyAddress.Address, fCollisionQueryRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCrowdFollowingParam_fPathOptimizationRange_Offset), 0, SetCrowdFollowingParam_fPathOptimizationRange_PropertyAddress.Address, fPathOptimizationRange);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCrowdFollowingParam_iAvoidanceQualityLevel_Offset), 0, SetCrowdFollowingParam_iAvoidanceQualityLevel_PropertyAddress.Address, iAvoidanceQualityLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCrowdFollowingParam_FunctionAddress, intPtr, SetCrowdFollowingParam_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCrowdFollowingComponent:SetCrowdFollowingEnabled")]
	public unsafe void SetCrowdFollowingEnabled(bool bEnabled, bool bIsObstacle)
	{
		CheckDestroyed();
		if (!SetCrowdFollowingEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCrowdFollowingComponent:SetCrowdFollowingEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCrowdFollowingEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCrowdFollowingEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCrowdFollowingEnabled_bEnabled_Offset), 0, SetCrowdFollowingEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCrowdFollowingEnabled_bIsObstacle_Offset), 0, SetCrowdFollowingEnabled_bIsObstacle_PropertyAddress.Address, bIsObstacle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCrowdFollowingEnabled_FunctionAddress, intPtr, SetCrowdFollowingEnabled_ParamsSize);
	}

	static UBGUCrowdFollowingComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUCrowdFollowingComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUCrowdFollowingComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUCrowdFollowingComponent");
		NativeReflectionCached.GetPropertyRef(ref Pause_PropertyAddress, intPtr, "bPause");
		Pause_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPause");
		Pause_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPause", Classes.FBoolProperty);
		DesiredVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DesiredVelocity");
		DesiredVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DesiredVelocity", Classes.FStructProperty);
		DesiredAngleDelta_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DesiredAngleDelta");
		DesiredAngleDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DesiredAngleDelta", Classes.FFloatProperty);
		RequestedVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RequestedVelocity");
		RequestedVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RequestedVelocity", Classes.FStructProperty);
		YawDelta_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YawDelta");
		YawDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YawDelta", Classes.FFloatProperty);
		TerrainRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TerrainRotation");
		TerrainRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TerrainRotation", Classes.FStructProperty);
		SpeedLimit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedLimit");
		SpeedLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedLimit", Classes.FFloatProperty);
		DeltaPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeltaPosition");
		DeltaPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeltaPosition", Classes.FStructProperty);
		RotationSpeedMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationSpeedMax");
		RotationSpeedMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationSpeedMax", Classes.FFloatProperty);
		RotationSpeedAcc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationSpeedAcc");
		RotationSpeedAcc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationSpeedAcc", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportFlock_PropertyAddress, intPtr, "bSupportFlock");
		SupportFlock_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSupportFlock");
		SupportFlock_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSupportFlock", Classes.FBoolProperty);
		SetCrowdFollowingParam_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCrowdFollowingParam");
		SetCrowdFollowingParam_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCrowdFollowingParam_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCrowdFollowingParam_fSeparationWeight_PropertyAddress, SetCrowdFollowingParam_FunctionAddress, "fSeparationWeight");
		SetCrowdFollowingParam_fSeparationWeight_Offset = NativeReflectionCached.GetPropertyOffset(SetCrowdFollowingParam_FunctionAddress, "fSeparationWeight");
		SetCrowdFollowingParam_fSeparationWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCrowdFollowingParam_FunctionAddress, "fSeparationWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCrowdFollowingParam_fCollisionQueryRange_PropertyAddress, SetCrowdFollowingParam_FunctionAddress, "fCollisionQueryRange");
		SetCrowdFollowingParam_fCollisionQueryRange_Offset = NativeReflectionCached.GetPropertyOffset(SetCrowdFollowingParam_FunctionAddress, "fCollisionQueryRange");
		SetCrowdFollowingParam_fCollisionQueryRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCrowdFollowingParam_FunctionAddress, "fCollisionQueryRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCrowdFollowingParam_fPathOptimizationRange_PropertyAddress, SetCrowdFollowingParam_FunctionAddress, "fPathOptimizationRange");
		SetCrowdFollowingParam_fPathOptimizationRange_Offset = NativeReflectionCached.GetPropertyOffset(SetCrowdFollowingParam_FunctionAddress, "fPathOptimizationRange");
		SetCrowdFollowingParam_fPathOptimizationRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCrowdFollowingParam_FunctionAddress, "fPathOptimizationRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCrowdFollowingParam_iAvoidanceQualityLevel_PropertyAddress, SetCrowdFollowingParam_FunctionAddress, "iAvoidanceQualityLevel");
		SetCrowdFollowingParam_iAvoidanceQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetCrowdFollowingParam_FunctionAddress, "iAvoidanceQualityLevel");
		SetCrowdFollowingParam_iAvoidanceQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCrowdFollowingParam_FunctionAddress, "iAvoidanceQualityLevel", Classes.FIntProperty);
		SetCrowdFollowingParam_IsValid = SetCrowdFollowingParam_FunctionAddress != IntPtr.Zero && SetCrowdFollowingParam_fSeparationWeight_IsValid && SetCrowdFollowingParam_fCollisionQueryRange_IsValid && SetCrowdFollowingParam_fPathOptimizationRange_IsValid && SetCrowdFollowingParam_iAvoidanceQualityLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCrowdFollowingComponent:SetCrowdFollowingParam", SetCrowdFollowingParam_IsValid);
		SetCrowdFollowingEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCrowdFollowingEnabled");
		SetCrowdFollowingEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCrowdFollowingEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCrowdFollowingEnabled_bEnabled_PropertyAddress, SetCrowdFollowingEnabled_FunctionAddress, "bEnabled");
		SetCrowdFollowingEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetCrowdFollowingEnabled_FunctionAddress, "bEnabled");
		SetCrowdFollowingEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCrowdFollowingEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCrowdFollowingEnabled_bIsObstacle_PropertyAddress, SetCrowdFollowingEnabled_FunctionAddress, "bIsObstacle");
		SetCrowdFollowingEnabled_bIsObstacle_Offset = NativeReflectionCached.GetPropertyOffset(SetCrowdFollowingEnabled_FunctionAddress, "bIsObstacle");
		SetCrowdFollowingEnabled_bIsObstacle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCrowdFollowingEnabled_FunctionAddress, "bIsObstacle", Classes.FBoolProperty);
		SetCrowdFollowingEnabled_IsValid = SetCrowdFollowingEnabled_FunctionAddress != IntPtr.Zero && SetCrowdFollowingEnabled_bEnabled_IsValid && SetCrowdFollowingEnabled_bIsObstacle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCrowdFollowingComponent:SetCrowdFollowingEnabled", SetCrowdFollowingEnabled_IsValid);
	}
}
