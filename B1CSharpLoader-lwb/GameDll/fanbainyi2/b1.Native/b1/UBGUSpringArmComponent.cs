using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUSpringArmComponent", "b1", UnrealModuleType.Game)]
public class UBGUSpringArmComponent : USpringArmComponent
{
	private static bool EnableHideMeshTrace_IsValid;

	private static FFieldAddress EnableHideMeshTrace_PropertyAddress;

	private static int EnableHideMeshTrace_Offset;

	private static bool SpringBackSpeed_IsValid;

	private static int SpringBackSpeed_Offset;

	private static bool CameraLagMaxDistance3Axis_IsValid;

	private static int CameraLagMaxDistance3Axis_Offset;

	private static bool CameraLagSpeed3Axis_IsValid;

	private static int CameraLagSpeed3Axis_Offset;

	private static bool CameraLagInverseSpeed3Axis_IsValid;

	private static int CameraLagInverseSpeed3Axis_Offset;

	private static bool CameraLagUseMaxOffset_IsValid;

	private static int CameraLagUseMaxOffset_Offset;

	private static bool ResetArmLengthLerpCache_IsValid;

	private static IntPtr ResetArmLengthLerpCache_FunctionAddress;

	private static int ResetArmLengthLerpCache_ParamsSize;

	private static bool GetPreviousValues_IsValid;

	private static IntPtr GetPreviousValues_FunctionAddress;

	private static int GetPreviousValues_ParamsSize;

	private static bool GetPreviousValues_OutPreviousDesiredLoc_IsValid;

	private static FFieldAddress GetPreviousValues_OutPreviousDesiredLoc_PropertyAddress;

	private static int GetPreviousValues_OutPreviousDesiredLoc_Offset;

	private static bool GetPreviousValues_OutPreviousArmOrigin_IsValid;

	private static FFieldAddress GetPreviousValues_OutPreviousArmOrigin_PropertyAddress;

	private static int GetPreviousValues_OutPreviousArmOrigin_Offset;

	private static bool GetPreviousValues_OutPreviousDesiredRot_IsValid;

	private static FFieldAddress GetPreviousValues_OutPreviousDesiredRot_PropertyAddress;

	private static int GetPreviousValues_OutPreviousDesiredRot_Offset;

	private static bool CalcSmoothLocation_IsValid;

	private IntPtr CalcSmoothLocation_InstanceFunctionAddress;

	private static IntPtr CalcSmoothLocation_FunctionAddress;

	private static int CalcSmoothLocation_ParamsSize;

	private static bool CalcSmoothLocation_Current_IsValid;

	private static FFieldAddress CalcSmoothLocation_Current_PropertyAddress;

	private static int CalcSmoothLocation_Current_Offset;

	private static bool CalcSmoothLocation_Target_IsValid;

	private static FFieldAddress CalcSmoothLocation_Target_PropertyAddress;

	private static int CalcSmoothLocation_Target_Offset;

	private static bool CalcSmoothLocation_DeltaTime_IsValid;

	private static FFieldAddress CalcSmoothLocation_DeltaTime_PropertyAddress;

	private static int CalcSmoothLocation_DeltaTime_Offset;

	private static bool CalcSmoothLocation_SmoothSpeed_IsValid;

	private static FFieldAddress CalcSmoothLocation_SmoothSpeed_PropertyAddress;

	private static int CalcSmoothLocation_SmoothSpeed_Offset;

	private static bool CalcSmoothLocation_ReturnValue_IsValid;

	private static FFieldAddress CalcSmoothLocation_ReturnValue_PropertyAddress;

	private static int CalcSmoothLocation_ReturnValue_Offset;

	private static bool BlendLocationsInCS_IsValid;

	private IntPtr BlendLocationsInCS_InstanceFunctionAddress;

	private static IntPtr BlendLocationsInCS_FunctionAddress;

	private static int BlendLocationsInCS_ParamsSize;

	private static bool BlendLocationsInCS_OriginArmLocation_IsValid;

	private static FFieldAddress BlendLocationsInCS_OriginArmLocation_PropertyAddress;

	private static int BlendLocationsInCS_OriginArmLocation_Offset;

	private static bool BlendLocationsInCS_DesiredArmLocation_IsValid;

	private static FFieldAddress BlendLocationsInCS_DesiredArmLocation_PropertyAddress;

	private static int BlendLocationsInCS_DesiredArmLocation_Offset;

	private static bool BlendLocationsInCS_HitResult_IsValid;

	private static FFieldAddress BlendLocationsInCS_HitResult_PropertyAddress;

	private static int BlendLocationsInCS_HitResult_Offset;

	private static bool BlendLocationsInCS_DeltaTime_IsValid;

	private static FFieldAddress BlendLocationsInCS_DeltaTime_PropertyAddress;

	private static int BlendLocationsInCS_DeltaTime_Offset;

	private static bool BlendLocationsInCS_ReturnValue_IsValid;

	private static FFieldAddress BlendLocationsInCS_ReturnValue_PropertyAddress;

	private static int BlendLocationsInCS_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:bEnableHideMeshTrace")]
	public bool EnableHideMeshTrace
	{
		get
		{
			CheckDestroyed();
			if (!EnableHideMeshTrace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:bEnableHideMeshTrace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableHideMeshTrace_Offset), 0, EnableHideMeshTrace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableHideMeshTrace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:bEnableHideMeshTrace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableHideMeshTrace_Offset), 0, EnableHideMeshTrace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:SpringBackSpeed")]
	public float SpringBackSpeed
	{
		get
		{
			CheckDestroyed();
			if (!SpringBackSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:SpringBackSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpringBackSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpringBackSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:SpringBackSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpringBackSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:CameraLagMaxDistance3Axis")]
	public FVector CameraLagMaxDistance3Axis
	{
		get
		{
			CheckDestroyed();
			if (!CameraLagMaxDistance3Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:CameraLagMaxDistance3Axis");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CameraLagMaxDistance3Axis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLagMaxDistance3Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:CameraLagMaxDistance3Axis");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CameraLagMaxDistance3Axis_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:CameraLagSpeed3Axis")]
	public FVector CameraLagSpeed3Axis
	{
		get
		{
			CheckDestroyed();
			if (!CameraLagSpeed3Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:CameraLagSpeed3Axis");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CameraLagSpeed3Axis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLagSpeed3Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:CameraLagSpeed3Axis");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CameraLagSpeed3Axis_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:CameraLagInverseSpeed3Axis")]
	public FVector CameraLagInverseSpeed3Axis
	{
		get
		{
			CheckDestroyed();
			if (!CameraLagInverseSpeed3Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:CameraLagInverseSpeed3Axis");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CameraLagInverseSpeed3Axis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLagInverseSpeed3Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:CameraLagInverseSpeed3Axis");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CameraLagInverseSpeed3Axis_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:CameraLagUseMaxOffset")]
	public float CameraLagUseMaxOffset
	{
		get
		{
			CheckDestroyed();
			if (!CameraLagUseMaxOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:CameraLagUseMaxOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraLagUseMaxOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLagUseMaxOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUSpringArmComponent:CameraLagUseMaxOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraLagUseMaxOffset_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:ResetArmLengthLerpCache")]
	public unsafe void ResetArmLengthLerpCache()
	{
		CheckDestroyed();
		if (!ResetArmLengthLerpCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSpringArmComponent:ResetArmLengthLerpCache");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetArmLengthLerpCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetArmLengthLerpCache_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetArmLengthLerpCache_FunctionAddress, argsSize: ResetArmLengthLerpCache_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:GetPreviousValues")]
	public unsafe void GetPreviousValues(out FVector OutPreviousDesiredLoc, out FVector OutPreviousArmOrigin, out FRotator OutPreviousDesiredRot)
	{
		CheckDestroyed();
		if (!GetPreviousValues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSpringArmComponent:GetPreviousValues");
			OutPreviousDesiredLoc = default(FVector);
			OutPreviousArmOrigin = default(FVector);
			OutPreviousDesiredRot = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviousValues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviousValues_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviousValues_FunctionAddress, intPtr, GetPreviousValues_ParamsSize);
		OutPreviousDesiredLoc = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPreviousValues_OutPreviousDesiredLoc_Offset), 0, GetPreviousValues_OutPreviousDesiredLoc_PropertyAddress.Address);
		OutPreviousArmOrigin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPreviousValues_OutPreviousArmOrigin_Offset), 0, GetPreviousValues_OutPreviousArmOrigin_PropertyAddress.Address);
		OutPreviousDesiredRot = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetPreviousValues_OutPreviousDesiredRot_Offset), 0, GetPreviousValues_OutPreviousDesiredRot_PropertyAddress.Address);
	}

	[UFunction(Flags = 143133696u)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:CalcSmoothLocation")]
	protected unsafe FVector CalcSmoothLocation(FVector Current, FVector Target, float DeltaTime, FVector SmoothSpeed)
	{
		CheckDestroyed();
		if (!CalcSmoothLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSpringArmComponent:CalcSmoothLocation");
			return default(FVector);
		}
		if (CalcSmoothLocation_InstanceFunctionAddress == IntPtr.Zero)
		{
			CalcSmoothLocation_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CalcSmoothLocation");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcSmoothLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcSmoothLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcSmoothLocation_Current_Offset), 0, CalcSmoothLocation_Current_PropertyAddress.Address, Current);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcSmoothLocation_Target_Offset), 0, CalcSmoothLocation_Target_PropertyAddress.Address, Target);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalcSmoothLocation_DeltaTime_Offset), 0, CalcSmoothLocation_DeltaTime_PropertyAddress.Address, DeltaTime);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcSmoothLocation_SmoothSpeed_Offset), 0, CalcSmoothLocation_SmoothSpeed_PropertyAddress.Address, SmoothSpeed);
		NativeReflection.InvokeFunctionOptimized(base.Address, CalcSmoothLocation_InstanceFunctionAddress, intPtr, CalcSmoothLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, CalcSmoothLocation_ReturnValue_Offset), 0, CalcSmoothLocation_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual FVector CalcSmoothLocation_Implementation(FVector Current, FVector Target, float DeltaTime, FVector SmoothSpeed)
	{
		CheckDestroyed();
		if (!CalcSmoothLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSpringArmComponent:CalcSmoothLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcSmoothLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcSmoothLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcSmoothLocation_Current_Offset), 0, CalcSmoothLocation_Current_PropertyAddress.Address, Current);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcSmoothLocation_Target_Offset), 0, CalcSmoothLocation_Target_PropertyAddress.Address, Target);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalcSmoothLocation_DeltaTime_Offset), 0, CalcSmoothLocation_DeltaTime_PropertyAddress.Address, DeltaTime);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalcSmoothLocation_SmoothSpeed_Offset), 0, CalcSmoothLocation_SmoothSpeed_PropertyAddress.Address, SmoothSpeed);
		NativeReflection.InvokeFunctionOptimized(base.Address, CalcSmoothLocation_FunctionAddress, intPtr, CalcSmoothLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, CalcSmoothLocation_ReturnValue_Offset), 0, CalcSmoothLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 147328000u)]
	[UMetaPath("/Script/b1.BGUSpringArmComponent:BlendLocationsInCS")]
	protected unsafe FVector BlendLocationsInCS(FVector OriginArmLocation, FVector DesiredArmLocation, FHitResult HitResult, float DeltaTime)
	{
		CheckDestroyed();
		if (!BlendLocationsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSpringArmComponent:BlendLocationsInCS");
			return default(FVector);
		}
		if (BlendLocationsInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlendLocationsInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlendLocationsInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlendLocationsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlendLocationsInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BlendLocationsInCS_OriginArmLocation_Offset), 0, BlendLocationsInCS_OriginArmLocation_PropertyAddress.Address, OriginArmLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BlendLocationsInCS_DesiredArmLocation_Offset), 0, BlendLocationsInCS_DesiredArmLocation_PropertyAddress.Address, DesiredArmLocation);
		NativeReflection.InitializeValue_InContainer(BlendLocationsInCS_HitResult_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, BlendLocationsInCS_HitResult_Offset), 0, BlendLocationsInCS_HitResult_PropertyAddress.Address, HitResult);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlendLocationsInCS_DeltaTime_Offset), 0, BlendLocationsInCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlendLocationsInCS_InstanceFunctionAddress, intPtr, BlendLocationsInCS_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BlendLocationsInCS_ReturnValue_Offset), 0, BlendLocationsInCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual FVector BlendLocationsInCS_Implementation(FVector OriginArmLocation, FVector DesiredArmLocation, FHitResult HitResult, float DeltaTime)
	{
		CheckDestroyed();
		if (!BlendLocationsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSpringArmComponent:BlendLocationsInCS");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlendLocationsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlendLocationsInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BlendLocationsInCS_OriginArmLocation_Offset), 0, BlendLocationsInCS_OriginArmLocation_PropertyAddress.Address, OriginArmLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BlendLocationsInCS_DesiredArmLocation_Offset), 0, BlendLocationsInCS_DesiredArmLocation_PropertyAddress.Address, DesiredArmLocation);
		NativeReflection.InitializeValue_InContainer(BlendLocationsInCS_HitResult_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, BlendLocationsInCS_HitResult_Offset), 0, BlendLocationsInCS_HitResult_PropertyAddress.Address, HitResult);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlendLocationsInCS_DeltaTime_Offset), 0, BlendLocationsInCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlendLocationsInCS_FunctionAddress, intPtr, BlendLocationsInCS_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BlendLocationsInCS_ReturnValue_Offset), 0, BlendLocationsInCS_ReturnValue_PropertyAddress.Address);
	}

	static UBGUSpringArmComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUSpringArmComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUSpringArmComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUSpringArmComponent");
		NativeReflectionCached.GetPropertyRef(ref EnableHideMeshTrace_PropertyAddress, intPtr, "bEnableHideMeshTrace");
		EnableHideMeshTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableHideMeshTrace");
		EnableHideMeshTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableHideMeshTrace", Classes.FBoolProperty);
		SpringBackSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpringBackSpeed");
		SpringBackSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpringBackSpeed", Classes.FFloatProperty);
		CameraLagMaxDistance3Axis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraLagMaxDistance3Axis");
		CameraLagMaxDistance3Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraLagMaxDistance3Axis", Classes.FStructProperty);
		CameraLagSpeed3Axis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraLagSpeed3Axis");
		CameraLagSpeed3Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraLagSpeed3Axis", Classes.FStructProperty);
		CameraLagInverseSpeed3Axis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraLagInverseSpeed3Axis");
		CameraLagInverseSpeed3Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraLagInverseSpeed3Axis", Classes.FStructProperty);
		CameraLagUseMaxOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraLagUseMaxOffset");
		CameraLagUseMaxOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraLagUseMaxOffset", Classes.FFloatProperty);
		ResetArmLengthLerpCache_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetArmLengthLerpCache");
		ResetArmLengthLerpCache_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetArmLengthLerpCache_FunctionAddress);
		ResetArmLengthLerpCache_IsValid = ResetArmLengthLerpCache_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSpringArmComponent:ResetArmLengthLerpCache", ResetArmLengthLerpCache_IsValid);
		GetPreviousValues_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPreviousValues");
		GetPreviousValues_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviousValues_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviousValues_OutPreviousDesiredLoc_PropertyAddress, GetPreviousValues_FunctionAddress, "OutPreviousDesiredLoc");
		GetPreviousValues_OutPreviousDesiredLoc_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviousValues_FunctionAddress, "OutPreviousDesiredLoc");
		GetPreviousValues_OutPreviousDesiredLoc_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviousValues_FunctionAddress, "OutPreviousDesiredLoc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviousValues_OutPreviousArmOrigin_PropertyAddress, GetPreviousValues_FunctionAddress, "OutPreviousArmOrigin");
		GetPreviousValues_OutPreviousArmOrigin_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviousValues_FunctionAddress, "OutPreviousArmOrigin");
		GetPreviousValues_OutPreviousArmOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviousValues_FunctionAddress, "OutPreviousArmOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviousValues_OutPreviousDesiredRot_PropertyAddress, GetPreviousValues_FunctionAddress, "OutPreviousDesiredRot");
		GetPreviousValues_OutPreviousDesiredRot_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviousValues_FunctionAddress, "OutPreviousDesiredRot");
		GetPreviousValues_OutPreviousDesiredRot_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviousValues_FunctionAddress, "OutPreviousDesiredRot", Classes.FStructProperty);
		GetPreviousValues_IsValid = GetPreviousValues_FunctionAddress != IntPtr.Zero && GetPreviousValues_OutPreviousDesiredLoc_IsValid && GetPreviousValues_OutPreviousArmOrigin_IsValid && GetPreviousValues_OutPreviousDesiredRot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSpringArmComponent:GetPreviousValues", GetPreviousValues_IsValid);
		CalcSmoothLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CalcSmoothLocation");
		CalcSmoothLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcSmoothLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcSmoothLocation_Current_PropertyAddress, CalcSmoothLocation_FunctionAddress, "Current");
		CalcSmoothLocation_Current_Offset = NativeReflectionCached.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "Current");
		CalcSmoothLocation_Current_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "Current", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcSmoothLocation_Target_PropertyAddress, CalcSmoothLocation_FunctionAddress, "Target");
		CalcSmoothLocation_Target_Offset = NativeReflectionCached.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "Target");
		CalcSmoothLocation_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "Target", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcSmoothLocation_DeltaTime_PropertyAddress, CalcSmoothLocation_FunctionAddress, "DeltaTime");
		CalcSmoothLocation_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "DeltaTime");
		CalcSmoothLocation_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcSmoothLocation_SmoothSpeed_PropertyAddress, CalcSmoothLocation_FunctionAddress, "SmoothSpeed");
		CalcSmoothLocation_SmoothSpeed_Offset = NativeReflectionCached.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "SmoothSpeed");
		CalcSmoothLocation_SmoothSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "SmoothSpeed", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcSmoothLocation_ReturnValue_PropertyAddress, CalcSmoothLocation_FunctionAddress, "ReturnValue");
		CalcSmoothLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "ReturnValue");
		CalcSmoothLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CalcSmoothLocation_IsValid = CalcSmoothLocation_FunctionAddress != IntPtr.Zero && CalcSmoothLocation_Current_IsValid && CalcSmoothLocation_Target_IsValid && CalcSmoothLocation_DeltaTime_IsValid && CalcSmoothLocation_SmoothSpeed_IsValid && CalcSmoothLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSpringArmComponent:CalcSmoothLocation", CalcSmoothLocation_IsValid);
		BlendLocationsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlendLocationsInCS");
		BlendLocationsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BlendLocationsInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlendLocationsInCS_OriginArmLocation_PropertyAddress, BlendLocationsInCS_FunctionAddress, "OriginArmLocation");
		BlendLocationsInCS_OriginArmLocation_Offset = NativeReflectionCached.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "OriginArmLocation");
		BlendLocationsInCS_OriginArmLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "OriginArmLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendLocationsInCS_DesiredArmLocation_PropertyAddress, BlendLocationsInCS_FunctionAddress, "DesiredArmLocation");
		BlendLocationsInCS_DesiredArmLocation_Offset = NativeReflectionCached.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "DesiredArmLocation");
		BlendLocationsInCS_DesiredArmLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "DesiredArmLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendLocationsInCS_HitResult_PropertyAddress, BlendLocationsInCS_FunctionAddress, "HitResult");
		BlendLocationsInCS_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "HitResult");
		BlendLocationsInCS_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendLocationsInCS_DeltaTime_PropertyAddress, BlendLocationsInCS_FunctionAddress, "DeltaTime");
		BlendLocationsInCS_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "DeltaTime");
		BlendLocationsInCS_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendLocationsInCS_ReturnValue_PropertyAddress, BlendLocationsInCS_FunctionAddress, "ReturnValue");
		BlendLocationsInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "ReturnValue");
		BlendLocationsInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BlendLocationsInCS_IsValid = BlendLocationsInCS_FunctionAddress != IntPtr.Zero && BlendLocationsInCS_OriginArmLocation_IsValid && BlendLocationsInCS_DesiredArmLocation_IsValid && BlendLocationsInCS_HitResult_IsValid && BlendLocationsInCS_DeltaTime_IsValid && BlendLocationsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSpringArmComponent:BlendLocationsInCS", BlendLocationsInCS_IsValid);
	}
}
