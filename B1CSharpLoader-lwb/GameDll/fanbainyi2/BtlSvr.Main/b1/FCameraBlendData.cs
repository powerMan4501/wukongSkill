using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.CameraBlendData")]
public struct FCameraBlendData
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:ControllerRotation")]
	public FRotator ControllerRotation;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:SpringArmTargetLength")]
	public float SpringArmTargetLength;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CameraBlendData:SpringArmTargetLengthOffset")]
	public float SpringArmTargetLengthOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:SprintArmSocketOffset")]
	public FVector SprintArmSocketOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:SprintArmTargetOffset")]
	public FVector SprintArmTargetOffset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CameraBlendData:CameraOffset")]
	public FVector CameraOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:CameraRotation")]
	public FRotator CameraRotation;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:FieldOfView")]
	public float FieldOfView;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:FieldOfViewOffset")]
	public float FieldOfViewOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:ControllerYawInput")]
	public float ControllerYawInput;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CameraBlendData:IsXAxisSmoothed")]
	public bool IsXAxisSmoothed;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CameraBlendData:IsYAxisSmoothed")]
	public bool IsYAxisSmoothed;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CameraBlendData:IsZAxisSmoothed")]
	public bool IsZAxisSmoothed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:SpringArmRelativeLocation")]
	public FVector SpringArmRelativeLocation;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:CurrentCameraLagSpeed")]
	public float CurrentCameraLagSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:FocalDistance")]
	public float FocalDistance;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CameraBlendData:DepthBlurKM")]
	public float DepthBlurKM;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CameraBlendData:DepthBlurRadius")]
	public float DepthBlurRadius;

	private static int CameraBlendData_StructSize;

	private static int CameraBlendData_IsValid;

	private static bool ControllerRotation_IsValid;

	private static int ControllerRotation_Offset;

	private static bool SpringArmTargetLength_IsValid;

	private static int SpringArmTargetLength_Offset;

	private static bool SpringArmTargetLengthOffset_IsValid;

	private static int SpringArmTargetLengthOffset_Offset;

	private static bool SprintArmSocketOffset_IsValid;

	private static int SprintArmSocketOffset_Offset;

	private static bool SprintArmTargetOffset_IsValid;

	private static int SprintArmTargetOffset_Offset;

	private static bool CameraOffset_IsValid;

	private static int CameraOffset_Offset;

	private static bool CameraRotation_IsValid;

	private static int CameraRotation_Offset;

	private static bool FieldOfView_IsValid;

	private static int FieldOfView_Offset;

	private static bool FieldOfViewOffset_IsValid;

	private static int FieldOfViewOffset_Offset;

	private static bool ControllerYawInput_IsValid;

	private static int ControllerYawInput_Offset;

	private static bool IsXAxisSmoothed_IsValid;

	private static int IsXAxisSmoothed_Offset;

	private static FFieldAddress IsXAxisSmoothed_PropertyAddress;

	private static bool IsYAxisSmoothed_IsValid;

	private static int IsYAxisSmoothed_Offset;

	private static FFieldAddress IsYAxisSmoothed_PropertyAddress;

	private static bool IsZAxisSmoothed_IsValid;

	private static int IsZAxisSmoothed_Offset;

	private static FFieldAddress IsZAxisSmoothed_PropertyAddress;

	private static bool SpringArmRelativeLocation_IsValid;

	private static int SpringArmRelativeLocation_Offset;

	private static bool CurrentCameraLagSpeed_IsValid;

	private static int CurrentCameraLagSpeed_Offset;

	private static bool FocalDistance_IsValid;

	private static int FocalDistance_Offset;

	private static bool DepthBlurKM_IsValid;

	private static int DepthBlurKM_Offset;

	private static bool DepthBlurRadius_IsValid;

	private static int DepthBlurRadius_Offset;

	public FCameraBlendData Copy()
	{
		return this;
	}

	public static FCameraBlendData FromNative(IntPtr nativeBuffer)
	{
		return new FCameraBlendData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraBlendData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraBlendData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraBlendData(IntPtr.Add(nativeBuffer, arrayIndex * CameraBlendData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraBlendData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CameraBlendData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CameraBlendData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CameraBlendData");
			return;
		}
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, ControllerRotation_Offset), ControllerRotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpringArmTargetLength_Offset), SpringArmTargetLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpringArmTargetLengthOffset_Offset), SpringArmTargetLengthOffset);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SprintArmSocketOffset_Offset), SprintArmSocketOffset);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SprintArmTargetOffset_Offset), SprintArmTargetOffset);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, CameraOffset_Offset), CameraOffset);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, CameraRotation_Offset), CameraRotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FieldOfView_Offset), FieldOfView);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FieldOfViewOffset_Offset), FieldOfViewOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ControllerYawInput_Offset), ControllerYawInput);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsXAxisSmoothed_Offset), 0, IsXAxisSmoothed_PropertyAddress.Address, IsXAxisSmoothed);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsYAxisSmoothed_Offset), 0, IsYAxisSmoothed_PropertyAddress.Address, IsYAxisSmoothed);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsZAxisSmoothed_Offset), 0, IsZAxisSmoothed_PropertyAddress.Address, IsZAxisSmoothed);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SpringArmRelativeLocation_Offset), SpringArmRelativeLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CurrentCameraLagSpeed_Offset), CurrentCameraLagSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocalDistance_Offset), FocalDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DepthBlurKM_Offset), DepthBlurKM);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DepthBlurRadius_Offset), DepthBlurRadius);
	}

	public FCameraBlendData(IntPtr nativeStruct)
	{
		if (CameraBlendData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CameraBlendData");
			ControllerRotation = default(FRotator);
			SpringArmTargetLength = 0f;
			SpringArmTargetLengthOffset = 0f;
			SprintArmSocketOffset = default(FVector);
			SprintArmTargetOffset = default(FVector);
			CameraOffset = default(FVector);
			CameraRotation = default(FRotator);
			FieldOfView = 0f;
			FieldOfViewOffset = 0f;
			ControllerYawInput = 0f;
			IsXAxisSmoothed = false;
			IsYAxisSmoothed = false;
			IsZAxisSmoothed = false;
			SpringArmRelativeLocation = default(FVector);
			CurrentCameraLagSpeed = 0f;
			FocalDistance = 0f;
			DepthBlurKM = 0f;
			DepthBlurRadius = 0f;
		}
		else
		{
			ControllerRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, ControllerRotation_Offset));
			SpringArmTargetLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpringArmTargetLength_Offset));
			SpringArmTargetLengthOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpringArmTargetLengthOffset_Offset));
			SprintArmSocketOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SprintArmSocketOffset_Offset));
			SprintArmTargetOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SprintArmTargetOffset_Offset));
			CameraOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, CameraOffset_Offset));
			CameraRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, CameraRotation_Offset));
			FieldOfView = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FieldOfView_Offset));
			FieldOfViewOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FieldOfViewOffset_Offset));
			ControllerYawInput = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ControllerYawInput_Offset));
			IsXAxisSmoothed = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsXAxisSmoothed_Offset), 0, IsXAxisSmoothed_PropertyAddress.Address);
			IsYAxisSmoothed = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsYAxisSmoothed_Offset), 0, IsYAxisSmoothed_PropertyAddress.Address);
			IsZAxisSmoothed = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsZAxisSmoothed_Offset), 0, IsZAxisSmoothed_PropertyAddress.Address);
			SpringArmRelativeLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SpringArmRelativeLocation_Offset));
			CurrentCameraLagSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CurrentCameraLagSpeed_Offset));
			FocalDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocalDistance_Offset));
			DepthBlurKM = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DepthBlurKM_Offset));
			DepthBlurRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DepthBlurRadius_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CameraBlendData");
		CameraBlendData_StructSize = NativeReflection.GetStructSize(intPtr);
		ControllerRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ControllerRotation");
		ControllerRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ControllerRotation", Classes.FStructProperty);
		SpringArmTargetLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpringArmTargetLength");
		SpringArmTargetLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpringArmTargetLength", Classes.FFloatProperty);
		SpringArmTargetLengthOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpringArmTargetLengthOffset");
		SpringArmTargetLengthOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpringArmTargetLengthOffset", Classes.FFloatProperty);
		SprintArmSocketOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SprintArmSocketOffset");
		SprintArmSocketOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SprintArmSocketOffset", Classes.FStructProperty);
		SprintArmTargetOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SprintArmTargetOffset");
		SprintArmTargetOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SprintArmTargetOffset", Classes.FStructProperty);
		CameraOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraOffset");
		CameraOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraOffset", Classes.FStructProperty);
		CameraRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraRotation");
		CameraRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraRotation", Classes.FStructProperty);
		FieldOfView_Offset = NativeReflection.GetPropertyOffset(intPtr, "FieldOfView");
		FieldOfView_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FieldOfView", Classes.FFloatProperty);
		FieldOfViewOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "FieldOfViewOffset");
		FieldOfViewOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FieldOfViewOffset", Classes.FFloatProperty);
		ControllerYawInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "ControllerYawInput");
		ControllerYawInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ControllerYawInput", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsXAxisSmoothed_PropertyAddress, intPtr, "IsXAxisSmoothed");
		IsXAxisSmoothed_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsXAxisSmoothed");
		IsXAxisSmoothed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsXAxisSmoothed", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsYAxisSmoothed_PropertyAddress, intPtr, "IsYAxisSmoothed");
		IsYAxisSmoothed_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsYAxisSmoothed");
		IsYAxisSmoothed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsYAxisSmoothed", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsZAxisSmoothed_PropertyAddress, intPtr, "IsZAxisSmoothed");
		IsZAxisSmoothed_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsZAxisSmoothed");
		IsZAxisSmoothed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsZAxisSmoothed", Classes.FBoolProperty);
		SpringArmRelativeLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpringArmRelativeLocation");
		SpringArmRelativeLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpringArmRelativeLocation", Classes.FStructProperty);
		CurrentCameraLagSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurrentCameraLagSpeed");
		CurrentCameraLagSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurrentCameraLagSpeed", Classes.FFloatProperty);
		FocalDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "FocalDistance");
		FocalDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FocalDistance", Classes.FFloatProperty);
		DepthBlurKM_Offset = NativeReflection.GetPropertyOffset(intPtr, "DepthBlurKM");
		DepthBlurKM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DepthBlurKM", Classes.FFloatProperty);
		DepthBlurRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "DepthBlurRadius");
		DepthBlurRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DepthBlurRadius", Classes.FFloatProperty);
		CameraBlendData_IsValid = ((intPtr != IntPtr.Zero && ControllerRotation_IsValid && SpringArmTargetLength_IsValid && SpringArmTargetLengthOffset_IsValid && SprintArmSocketOffset_IsValid && SprintArmTargetOffset_IsValid && CameraOffset_IsValid && CameraRotation_IsValid && FieldOfView_IsValid && FieldOfViewOffset_IsValid && ControllerYawInput_IsValid && IsXAxisSmoothed_IsValid && IsYAxisSmoothed_IsValid && IsZAxisSmoothed_IsValid && SpringArmRelativeLocation_IsValid && CurrentCameraLagSpeed_IsValid && FocalDistance_IsValid && DepthBlurKM_IsValid && DepthBlurRadius_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CameraBlendData", (byte)CameraBlendData_IsValid != 0);
	}

	static FCameraBlendData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCameraBlendData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraBlendData));
	}
}
