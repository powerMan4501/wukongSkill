using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UClass(Flags = (ClassFlags)818942112uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GameplayCameras.MatineeCameraShake", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public class UMatineeCameraShake : UCameraShakeBase
{
	private static IntPtr classAddress;

	private static bool RotOscillation_IsValid;

	private static int RotOscillation_Offset;

	private static bool LocOscillation_IsValid;

	private static int LocOscillation_Offset;

	private static bool FOVOscillation_IsValid;

	private static int FOVOscillation_Offset;

	private static bool OscillatorTimeRemaining_IsValid;

	private static int OscillatorTimeRemaining_Offset;

	private static bool AnimInst_IsValid;

	private static int AnimInst_Offset;

	private static bool StartMatineeCameraShakeFromSource_IsValid;

	private static IntPtr StartMatineeCameraShakeFromSource_FunctionAddress;

	private static int StartMatineeCameraShakeFromSource_ParamsSize;

	private static bool StartMatineeCameraShakeFromSource_PlayerCameraManager_IsValid;

	private static FFieldAddress StartMatineeCameraShakeFromSource_PlayerCameraManager_PropertyAddress;

	private static int StartMatineeCameraShakeFromSource_PlayerCameraManager_Offset;

	private static bool StartMatineeCameraShakeFromSource_ShakeClass_IsValid;

	private static FFieldAddress StartMatineeCameraShakeFromSource_ShakeClass_PropertyAddress;

	private static int StartMatineeCameraShakeFromSource_ShakeClass_Offset;

	private static bool StartMatineeCameraShakeFromSource_SourceComponent_IsValid;

	private static FFieldAddress StartMatineeCameraShakeFromSource_SourceComponent_PropertyAddress;

	private static int StartMatineeCameraShakeFromSource_SourceComponent_Offset;

	private static bool StartMatineeCameraShakeFromSource_Scale_IsValid;

	private static FFieldAddress StartMatineeCameraShakeFromSource_Scale_PropertyAddress;

	private static int StartMatineeCameraShakeFromSource_Scale_Offset;

	private static bool StartMatineeCameraShakeFromSource_PlaySpace_IsValid;

	private static FFieldAddress StartMatineeCameraShakeFromSource_PlaySpace_PropertyAddress;

	private static int StartMatineeCameraShakeFromSource_PlaySpace_Offset;

	private static bool StartMatineeCameraShakeFromSource_UserPlaySpaceRot_IsValid;

	private static FFieldAddress StartMatineeCameraShakeFromSource_UserPlaySpaceRot_PropertyAddress;

	private static int StartMatineeCameraShakeFromSource_UserPlaySpaceRot_Offset;

	private static bool StartMatineeCameraShakeFromSource_ReturnValue_IsValid;

	private static FFieldAddress StartMatineeCameraShakeFromSource_ReturnValue_PropertyAddress;

	private static int StartMatineeCameraShakeFromSource_ReturnValue_Offset;

	private static bool StartMatineeCameraShake_IsValid;

	private static IntPtr StartMatineeCameraShake_FunctionAddress;

	private static int StartMatineeCameraShake_ParamsSize;

	private static bool StartMatineeCameraShake_PlayerCameraManager_IsValid;

	private static FFieldAddress StartMatineeCameraShake_PlayerCameraManager_PropertyAddress;

	private static int StartMatineeCameraShake_PlayerCameraManager_Offset;

	private static bool StartMatineeCameraShake_ShakeClass_IsValid;

	private static FFieldAddress StartMatineeCameraShake_ShakeClass_PropertyAddress;

	private static int StartMatineeCameraShake_ShakeClass_Offset;

	private static bool StartMatineeCameraShake_Scale_IsValid;

	private static FFieldAddress StartMatineeCameraShake_Scale_PropertyAddress;

	private static int StartMatineeCameraShake_Scale_Offset;

	private static bool StartMatineeCameraShake_PlaySpace_IsValid;

	private static FFieldAddress StartMatineeCameraShake_PlaySpace_PropertyAddress;

	private static int StartMatineeCameraShake_PlaySpace_Offset;

	private static bool StartMatineeCameraShake_UserPlaySpaceRot_IsValid;

	private static FFieldAddress StartMatineeCameraShake_UserPlaySpaceRot_PropertyAddress;

	private static int StartMatineeCameraShake_UserPlaySpaceRot_Offset;

	private static bool StartMatineeCameraShake_ReturnValue_IsValid;

	private static FFieldAddress StartMatineeCameraShake_ReturnValue_PropertyAddress;

	private static int StartMatineeCameraShake_ReturnValue_Offset;

	private static bool ReceiveStopShake_IsValid;

	private IntPtr ReceiveStopShake_InstanceFunctionAddress;

	private static IntPtr ReceiveStopShake_FunctionAddress;

	private static int ReceiveStopShake_ParamsSize;

	private static bool ReceiveStopShake_bImmediately_IsValid;

	private static FFieldAddress ReceiveStopShake_bImmediately_PropertyAddress;

	private static int ReceiveStopShake_bImmediately_Offset;

	private static bool ReceivePlayShake_IsValid;

	private IntPtr ReceivePlayShake_InstanceFunctionAddress;

	private static IntPtr ReceivePlayShake_FunctionAddress;

	private static int ReceivePlayShake_ParamsSize;

	private static bool ReceivePlayShake_Scale_IsValid;

	private static FFieldAddress ReceivePlayShake_Scale_PropertyAddress;

	private static int ReceivePlayShake_Scale_Offset;

	private static bool ReceiveIsFinished_IsValid;

	private IntPtr ReceiveIsFinished_InstanceFunctionAddress;

	private static IntPtr ReceiveIsFinished_FunctionAddress;

	private static int ReceiveIsFinished_ParamsSize;

	private static bool ReceiveIsFinished_ReturnValue_IsValid;

	private static FFieldAddress ReceiveIsFinished_ReturnValue_PropertyAddress;

	private static int ReceiveIsFinished_ReturnValue_Offset;

	private static bool BlueprintUpdateCameraShake_IsValid;

	private IntPtr BlueprintUpdateCameraShake_InstanceFunctionAddress;

	private static IntPtr BlueprintUpdateCameraShake_FunctionAddress;

	private static int BlueprintUpdateCameraShake_ParamsSize;

	private static bool BlueprintUpdateCameraShake_DeltaTime_IsValid;

	private static FFieldAddress BlueprintUpdateCameraShake_DeltaTime_PropertyAddress;

	private static int BlueprintUpdateCameraShake_DeltaTime_Offset;

	private static bool BlueprintUpdateCameraShake_Alpha_IsValid;

	private static FFieldAddress BlueprintUpdateCameraShake_Alpha_PropertyAddress;

	private static int BlueprintUpdateCameraShake_Alpha_Offset;

	private static bool BlueprintUpdateCameraShake_POV_IsValid;

	private static FFieldAddress BlueprintUpdateCameraShake_POV_PropertyAddress;

	private static int BlueprintUpdateCameraShake_POV_Offset;

	private static bool BlueprintUpdateCameraShake_ModifiedPOV_IsValid;

	private static FFieldAddress BlueprintUpdateCameraShake_ModifiedPOV_PropertyAddress;

	private static int BlueprintUpdateCameraShake_ModifiedPOV_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:RotOscillation")]
	public FROscillator RotOscillation
	{
		get
		{
			CheckDestroyed();
			if (!RotOscillation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:RotOscillation");
				return default(FROscillator);
			}
			return FROscillator.FromNative(IntPtr.Add(base.Address, RotOscillation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotOscillation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:RotOscillation");
			}
			else
			{
				FROscillator.ToNative(IntPtr.Add(base.Address, RotOscillation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:LocOscillation")]
	public FVOscillator LocOscillation
	{
		get
		{
			CheckDestroyed();
			if (!LocOscillation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:LocOscillation");
				return default(FVOscillator);
			}
			return FVOscillator.FromNative(IntPtr.Add(base.Address, LocOscillation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocOscillation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:LocOscillation");
			}
			else
			{
				FVOscillator.ToNative(IntPtr.Add(base.Address, LocOscillation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:FOVOscillation")]
	public FOscillator FOVOscillation
	{
		get
		{
			CheckDestroyed();
			if (!FOVOscillation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:FOVOscillation");
				return default(FOscillator);
			}
			return FOscillator.FromNative(IntPtr.Add(base.Address, FOVOscillation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FOVOscillation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:FOVOscillation");
			}
			else
			{
				FOscillator.ToNative(IntPtr.Add(base.Address, FOVOscillation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:OscillatorTimeRemaining")]
	public float OscillatorTimeRemaining
	{
		get
		{
			CheckDestroyed();
			if (!OscillatorTimeRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:OscillatorTimeRemaining");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OscillatorTimeRemaining_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OscillatorTimeRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:OscillatorTimeRemaining");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OscillatorTimeRemaining_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141125652uL)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:AnimInst")]
	public UCameraAnimInst AnimInst
	{
		get
		{
			CheckDestroyed();
			if (!AnimInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:AnimInst");
				return null;
			}
			return UObjectMarshaler<UCameraAnimInst>.FromNative(IntPtr.Add(base.Address, AnimInst_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayCameras.MatineeCameraShake:AnimInst");
			}
			else
			{
				UObjectMarshaler<UCameraAnimInst>.ToNative(IntPtr.Add(base.Address, AnimInst_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:StartMatineeCameraShakeFromSource")]
	public unsafe static UMatineeCameraShake StartMatineeCameraShakeFromSource(APlayerCameraManager PlayerCameraManager, TSubclassOf<UMatineeCameraShake> ShakeClass, UCameraShakeSourceComponent SourceComponent, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
	{
		if (!StartMatineeCameraShakeFromSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:StartMatineeCameraShakeFromSource");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartMatineeCameraShakeFromSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartMatineeCameraShakeFromSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShakeFromSource_PlayerCameraManager_Offset), 0, StartMatineeCameraShakeFromSource_PlayerCameraManager_PropertyAddress.Address, PlayerCameraManager);
		TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShakeFromSource_ShakeClass_Offset), 0, StartMatineeCameraShakeFromSource_ShakeClass_PropertyAddress.Address, ShakeClass);
		UObjectMarshaler<UCameraShakeSourceComponent>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShakeFromSource_SourceComponent_Offset), 0, StartMatineeCameraShakeFromSource_SourceComponent_PropertyAddress.Address, SourceComponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShakeFromSource_Scale_Offset), 0, StartMatineeCameraShakeFromSource_Scale_PropertyAddress.Address, Scale);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShakeFromSource_PlaySpace_Offset), 0, StartMatineeCameraShakeFromSource_PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShakeFromSource_UserPlaySpaceRot_Offset), 0, StartMatineeCameraShakeFromSource_UserPlaySpaceRot_PropertyAddress.Address, UserPlaySpaceRot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartMatineeCameraShakeFromSource_FunctionAddress, intPtr, StartMatineeCameraShakeFromSource_ParamsSize);
		return UObjectMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(intPtr, StartMatineeCameraShakeFromSource_ReturnValue_Offset), 0, StartMatineeCameraShakeFromSource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:StartMatineeCameraShake")]
	public unsafe static UMatineeCameraShake StartMatineeCameraShake(APlayerCameraManager PlayerCameraManager, TSubclassOf<UMatineeCameraShake> ShakeClass, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
	{
		if (!StartMatineeCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:StartMatineeCameraShake");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartMatineeCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartMatineeCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShake_PlayerCameraManager_Offset), 0, StartMatineeCameraShake_PlayerCameraManager_PropertyAddress.Address, PlayerCameraManager);
		TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShake_ShakeClass_Offset), 0, StartMatineeCameraShake_ShakeClass_PropertyAddress.Address, ShakeClass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShake_Scale_Offset), 0, StartMatineeCameraShake_Scale_PropertyAddress.Address, Scale);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShake_PlaySpace_Offset), 0, StartMatineeCameraShake_PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, StartMatineeCameraShake_UserPlaySpaceRot_Offset), 0, StartMatineeCameraShake_UserPlaySpaceRot_PropertyAddress.Address, UserPlaySpaceRot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartMatineeCameraShake_FunctionAddress, intPtr, StartMatineeCameraShake_ParamsSize);
		return UObjectMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(intPtr, StartMatineeCameraShake_ReturnValue_Offset), 0, StartMatineeCameraShake_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:ReceiveStopShake")]
	public unsafe void ReceiveStopShake(bool bImmediately)
	{
		CheckDestroyed();
		if (!ReceiveStopShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:ReceiveStopShake");
			return;
		}
		if (ReceiveStopShake_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveStopShake_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveStopShake");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveStopShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveStopShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReceiveStopShake_bImmediately_Offset), 0, ReceiveStopShake_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveStopShake_InstanceFunctionAddress, intPtr, ReceiveStopShake_ParamsSize);
	}

	protected unsafe virtual void ReceiveStopShake_Implementation(bool bImmediately)
	{
		CheckDestroyed();
		if (!ReceiveStopShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:ReceiveStopShake");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveStopShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveStopShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReceiveStopShake_bImmediately_Offset), 0, ReceiveStopShake_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveStopShake_FunctionAddress, intPtr, ReceiveStopShake_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:ReceivePlayShake")]
	public unsafe void ReceivePlayShake(float Scale)
	{
		CheckDestroyed();
		if (!ReceivePlayShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:ReceivePlayShake");
			return;
		}
		if (ReceivePlayShake_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceivePlayShake_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceivePlayShake");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePlayShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePlayShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceivePlayShake_Scale_Offset), 0, ReceivePlayShake_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePlayShake_InstanceFunctionAddress, intPtr, ReceivePlayShake_ParamsSize);
	}

	protected unsafe virtual void ReceivePlayShake_Implementation(float Scale)
	{
		CheckDestroyed();
		if (!ReceivePlayShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:ReceivePlayShake");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePlayShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePlayShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceivePlayShake_Scale_Offset), 0, ReceivePlayShake_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePlayShake_FunctionAddress, intPtr, ReceivePlayShake_ParamsSize);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:ReceiveIsFinished")]
	public unsafe bool ReceiveIsFinished()
	{
		CheckDestroyed();
		if (!ReceiveIsFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:ReceiveIsFinished");
			return false;
		}
		if (ReceiveIsFinished_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveIsFinished_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveIsFinished");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveIsFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveIsFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveIsFinished_InstanceFunctionAddress, intPtr, ReceiveIsFinished_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReceiveIsFinished_ReturnValue_Offset), 0, ReceiveIsFinished_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ReceiveIsFinished_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveIsFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:ReceiveIsFinished");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveIsFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveIsFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveIsFinished_FunctionAddress, intPtr, ReceiveIsFinished_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReceiveIsFinished_ReturnValue_Offset), 0, ReceiveIsFinished_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/GameplayCameras.MatineeCameraShake:BlueprintUpdateCameraShake")]
	public unsafe void BlueprintUpdateCameraShake(float DeltaTime, float Alpha, FMinimalViewInfo POV, out FMinimalViewInfo ModifiedPOV)
	{
		CheckDestroyed();
		if (!BlueprintUpdateCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:BlueprintUpdateCameraShake");
			ModifiedPOV = default(FMinimalViewInfo);
			return;
		}
		if (BlueprintUpdateCameraShake_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlueprintUpdateCameraShake_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlueprintUpdateCameraShake");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintUpdateCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintUpdateCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintUpdateCameraShake_DeltaTime_Offset), 0, BlueprintUpdateCameraShake_DeltaTime_PropertyAddress.Address, DeltaTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintUpdateCameraShake_Alpha_Offset), 0, BlueprintUpdateCameraShake_Alpha_PropertyAddress.Address, Alpha);
		NativeReflection.InitializeValue_InContainer(BlueprintUpdateCameraShake_POV_PropertyAddress.Address, intPtr);
		FMinimalViewInfo.ToNative(IntPtr.Add(intPtr, BlueprintUpdateCameraShake_POV_Offset), 0, BlueprintUpdateCameraShake_POV_PropertyAddress.Address, POV);
		NativeReflection.InitializeValue_InContainer(BlueprintUpdateCameraShake_ModifiedPOV_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintUpdateCameraShake_InstanceFunctionAddress, intPtr, BlueprintUpdateCameraShake_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BlueprintUpdateCameraShake_POV_PropertyAddress.Address, intPtr);
		ModifiedPOV = FMinimalViewInfo.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCameraShake_ModifiedPOV_Offset), 0, BlueprintUpdateCameraShake_ModifiedPOV_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BlueprintUpdateCameraShake_ModifiedPOV_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void BlueprintUpdateCameraShake_Implementation(float DeltaTime, float Alpha, FMinimalViewInfo POV, out FMinimalViewInfo ModifiedPOV)
	{
		CheckDestroyed();
		if (!BlueprintUpdateCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.MatineeCameraShake:BlueprintUpdateCameraShake");
			ModifiedPOV = default(FMinimalViewInfo);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintUpdateCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintUpdateCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintUpdateCameraShake_DeltaTime_Offset), 0, BlueprintUpdateCameraShake_DeltaTime_PropertyAddress.Address, DeltaTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlueprintUpdateCameraShake_Alpha_Offset), 0, BlueprintUpdateCameraShake_Alpha_PropertyAddress.Address, Alpha);
		NativeReflection.InitializeValue_InContainer(BlueprintUpdateCameraShake_POV_PropertyAddress.Address, intPtr);
		FMinimalViewInfo.ToNative(IntPtr.Add(intPtr, BlueprintUpdateCameraShake_POV_Offset), 0, BlueprintUpdateCameraShake_POV_PropertyAddress.Address, POV);
		NativeReflection.InitializeValue_InContainer(BlueprintUpdateCameraShake_ModifiedPOV_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintUpdateCameraShake_FunctionAddress, intPtr, BlueprintUpdateCameraShake_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BlueprintUpdateCameraShake_POV_PropertyAddress.Address, intPtr);
		ModifiedPOV = FMinimalViewInfo.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCameraShake_ModifiedPOV_Offset), 0, BlueprintUpdateCameraShake_ModifiedPOV_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BlueprintUpdateCameraShake_ModifiedPOV_PropertyAddress.Address, intPtr);
	}

	static UMatineeCameraShake()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMatineeCameraShake)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMatineeCameraShake));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GameplayCameras.MatineeCameraShake");
		RotOscillation_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "RotOscillation");
		RotOscillation_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "RotOscillation", Classes.FStructProperty);
		LocOscillation_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "LocOscillation");
		LocOscillation_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "LocOscillation", Classes.FStructProperty);
		FOVOscillation_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "FOVOscillation");
		FOVOscillation_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "FOVOscillation", Classes.FStructProperty);
		OscillatorTimeRemaining_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OscillatorTimeRemaining");
		OscillatorTimeRemaining_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OscillatorTimeRemaining", Classes.FFloatProperty);
		AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "AnimInst");
		AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "AnimInst", Classes.FObjectProperty);
		StartMatineeCameraShakeFromSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartMatineeCameraShakeFromSource");
		StartMatineeCameraShakeFromSource_ParamsSize = NativeReflection.GetFunctionParamsSize(StartMatineeCameraShakeFromSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShakeFromSource_PlayerCameraManager_PropertyAddress, StartMatineeCameraShakeFromSource_FunctionAddress, "PlayerCameraManager");
		StartMatineeCameraShakeFromSource_PlayerCameraManager_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShakeFromSource_FunctionAddress, "PlayerCameraManager");
		StartMatineeCameraShakeFromSource_PlayerCameraManager_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShakeFromSource_FunctionAddress, "PlayerCameraManager", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShakeFromSource_ShakeClass_PropertyAddress, StartMatineeCameraShakeFromSource_FunctionAddress, "ShakeClass");
		StartMatineeCameraShakeFromSource_ShakeClass_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShakeFromSource_FunctionAddress, "ShakeClass");
		StartMatineeCameraShakeFromSource_ShakeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShakeFromSource_FunctionAddress, "ShakeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShakeFromSource_SourceComponent_PropertyAddress, StartMatineeCameraShakeFromSource_FunctionAddress, "SourceComponent");
		StartMatineeCameraShakeFromSource_SourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShakeFromSource_FunctionAddress, "SourceComponent");
		StartMatineeCameraShakeFromSource_SourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShakeFromSource_FunctionAddress, "SourceComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShakeFromSource_Scale_PropertyAddress, StartMatineeCameraShakeFromSource_FunctionAddress, "Scale");
		StartMatineeCameraShakeFromSource_Scale_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShakeFromSource_FunctionAddress, "Scale");
		StartMatineeCameraShakeFromSource_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShakeFromSource_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShakeFromSource_PlaySpace_PropertyAddress, StartMatineeCameraShakeFromSource_FunctionAddress, "PlaySpace");
		StartMatineeCameraShakeFromSource_PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShakeFromSource_FunctionAddress, "PlaySpace");
		StartMatineeCameraShakeFromSource_PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShakeFromSource_FunctionAddress, "PlaySpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShakeFromSource_UserPlaySpaceRot_PropertyAddress, StartMatineeCameraShakeFromSource_FunctionAddress, "UserPlaySpaceRot");
		StartMatineeCameraShakeFromSource_UserPlaySpaceRot_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShakeFromSource_FunctionAddress, "UserPlaySpaceRot");
		StartMatineeCameraShakeFromSource_UserPlaySpaceRot_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShakeFromSource_FunctionAddress, "UserPlaySpaceRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShakeFromSource_ReturnValue_PropertyAddress, StartMatineeCameraShakeFromSource_FunctionAddress, "ReturnValue");
		StartMatineeCameraShakeFromSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShakeFromSource_FunctionAddress, "ReturnValue");
		StartMatineeCameraShakeFromSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShakeFromSource_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		StartMatineeCameraShakeFromSource_IsValid = StartMatineeCameraShakeFromSource_FunctionAddress != IntPtr.Zero && StartMatineeCameraShakeFromSource_PlayerCameraManager_IsValid && StartMatineeCameraShakeFromSource_ShakeClass_IsValid && StartMatineeCameraShakeFromSource_SourceComponent_IsValid && StartMatineeCameraShakeFromSource_Scale_IsValid && StartMatineeCameraShakeFromSource_PlaySpace_IsValid && StartMatineeCameraShakeFromSource_UserPlaySpaceRot_IsValid && StartMatineeCameraShakeFromSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.MatineeCameraShake:StartMatineeCameraShakeFromSource", StartMatineeCameraShakeFromSource_IsValid);
		StartMatineeCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartMatineeCameraShake");
		StartMatineeCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(StartMatineeCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShake_PlayerCameraManager_PropertyAddress, StartMatineeCameraShake_FunctionAddress, "PlayerCameraManager");
		StartMatineeCameraShake_PlayerCameraManager_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShake_FunctionAddress, "PlayerCameraManager");
		StartMatineeCameraShake_PlayerCameraManager_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShake_FunctionAddress, "PlayerCameraManager", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShake_ShakeClass_PropertyAddress, StartMatineeCameraShake_FunctionAddress, "ShakeClass");
		StartMatineeCameraShake_ShakeClass_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShake_FunctionAddress, "ShakeClass");
		StartMatineeCameraShake_ShakeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShake_FunctionAddress, "ShakeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShake_Scale_PropertyAddress, StartMatineeCameraShake_FunctionAddress, "Scale");
		StartMatineeCameraShake_Scale_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShake_FunctionAddress, "Scale");
		StartMatineeCameraShake_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShake_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShake_PlaySpace_PropertyAddress, StartMatineeCameraShake_FunctionAddress, "PlaySpace");
		StartMatineeCameraShake_PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShake_FunctionAddress, "PlaySpace");
		StartMatineeCameraShake_PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShake_FunctionAddress, "PlaySpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShake_UserPlaySpaceRot_PropertyAddress, StartMatineeCameraShake_FunctionAddress, "UserPlaySpaceRot");
		StartMatineeCameraShake_UserPlaySpaceRot_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShake_FunctionAddress, "UserPlaySpaceRot");
		StartMatineeCameraShake_UserPlaySpaceRot_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShake_FunctionAddress, "UserPlaySpaceRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartMatineeCameraShake_ReturnValue_PropertyAddress, StartMatineeCameraShake_FunctionAddress, "ReturnValue");
		StartMatineeCameraShake_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartMatineeCameraShake_FunctionAddress, "ReturnValue");
		StartMatineeCameraShake_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartMatineeCameraShake_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		StartMatineeCameraShake_IsValid = StartMatineeCameraShake_FunctionAddress != IntPtr.Zero && StartMatineeCameraShake_PlayerCameraManager_IsValid && StartMatineeCameraShake_ShakeClass_IsValid && StartMatineeCameraShake_Scale_IsValid && StartMatineeCameraShake_PlaySpace_IsValid && StartMatineeCameraShake_UserPlaySpaceRot_IsValid && StartMatineeCameraShake_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.MatineeCameraShake:StartMatineeCameraShake", StartMatineeCameraShake_IsValid);
		ReceiveStopShake_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReceiveStopShake");
		ReceiveStopShake_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveStopShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveStopShake_bImmediately_PropertyAddress, ReceiveStopShake_FunctionAddress, "bImmediately");
		ReceiveStopShake_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveStopShake_FunctionAddress, "bImmediately");
		ReceiveStopShake_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveStopShake_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		ReceiveStopShake_IsValid = ReceiveStopShake_FunctionAddress != IntPtr.Zero && ReceiveStopShake_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.MatineeCameraShake:ReceiveStopShake", ReceiveStopShake_IsValid);
		ReceivePlayShake_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReceivePlayShake");
		ReceivePlayShake_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceivePlayShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceivePlayShake_Scale_PropertyAddress, ReceivePlayShake_FunctionAddress, "Scale");
		ReceivePlayShake_Scale_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePlayShake_FunctionAddress, "Scale");
		ReceivePlayShake_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePlayShake_FunctionAddress, "Scale", Classes.FFloatProperty);
		ReceivePlayShake_IsValid = ReceivePlayShake_FunctionAddress != IntPtr.Zero && ReceivePlayShake_Scale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.MatineeCameraShake:ReceivePlayShake", ReceivePlayShake_IsValid);
		ReceiveIsFinished_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReceiveIsFinished");
		ReceiveIsFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveIsFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveIsFinished_ReturnValue_PropertyAddress, ReceiveIsFinished_FunctionAddress, "ReturnValue");
		ReceiveIsFinished_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveIsFinished_FunctionAddress, "ReturnValue");
		ReceiveIsFinished_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveIsFinished_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReceiveIsFinished_IsValid = ReceiveIsFinished_FunctionAddress != IntPtr.Zero && ReceiveIsFinished_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.MatineeCameraShake:ReceiveIsFinished", ReceiveIsFinished_IsValid);
		BlueprintUpdateCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BlueprintUpdateCameraShake");
		BlueprintUpdateCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCameraShake_DeltaTime_PropertyAddress, BlueprintUpdateCameraShake_FunctionAddress, "DeltaTime");
		BlueprintUpdateCameraShake_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCameraShake_FunctionAddress, "DeltaTime");
		BlueprintUpdateCameraShake_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCameraShake_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCameraShake_Alpha_PropertyAddress, BlueprintUpdateCameraShake_FunctionAddress, "Alpha");
		BlueprintUpdateCameraShake_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCameraShake_FunctionAddress, "Alpha");
		BlueprintUpdateCameraShake_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCameraShake_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCameraShake_POV_PropertyAddress, BlueprintUpdateCameraShake_FunctionAddress, "POV");
		BlueprintUpdateCameraShake_POV_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCameraShake_FunctionAddress, "POV");
		BlueprintUpdateCameraShake_POV_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCameraShake_FunctionAddress, "POV", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCameraShake_ModifiedPOV_PropertyAddress, BlueprintUpdateCameraShake_FunctionAddress, "ModifiedPOV");
		BlueprintUpdateCameraShake_ModifiedPOV_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCameraShake_FunctionAddress, "ModifiedPOV");
		BlueprintUpdateCameraShake_ModifiedPOV_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCameraShake_FunctionAddress, "ModifiedPOV", Classes.FStructProperty);
		BlueprintUpdateCameraShake_IsValid = BlueprintUpdateCameraShake_FunctionAddress != IntPtr.Zero && BlueprintUpdateCameraShake_DeltaTime_IsValid && BlueprintUpdateCameraShake_Alpha_IsValid && BlueprintUpdateCameraShake_POV_IsValid && BlueprintUpdateCameraShake_ModifiedPOV_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.MatineeCameraShake:BlueprintUpdateCameraShake", BlueprintUpdateCameraShake_IsValid);
	}
}
