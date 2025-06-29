using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicalAnimationComponent", "Engine", UnrealModuleType.Engine)]
public class UPhysicalAnimationComponent : UActorComponent
{
	private static bool StrengthMultiplyer_IsValid;

	private static int StrengthMultiplyer_Offset;

	private static bool SetStrengthMultiplyer_IsValid;

	private static IntPtr SetStrengthMultiplyer_FunctionAddress;

	private static int SetStrengthMultiplyer_ParamsSize;

	private static bool SetStrengthMultiplyer_InStrengthMultiplyer_IsValid;

	private static FFieldAddress SetStrengthMultiplyer_InStrengthMultiplyer_PropertyAddress;

	private static int SetStrengthMultiplyer_InStrengthMultiplyer_Offset;

	private static bool SetSkeletalMeshComponent_IsValid;

	private static IntPtr SetSkeletalMeshComponent_FunctionAddress;

	private static int SetSkeletalMeshComponent_ParamsSize;

	private static bool SetSkeletalMeshComponent_InSkeletalMeshComponent_IsValid;

	private static FFieldAddress SetSkeletalMeshComponent_InSkeletalMeshComponent_PropertyAddress;

	private static int SetSkeletalMeshComponent_InSkeletalMeshComponent_Offset;

	private static bool GetBodyTargetTransform_IsValid;

	private static IntPtr GetBodyTargetTransform_FunctionAddress;

	private static int GetBodyTargetTransform_ParamsSize;

	private static bool GetBodyTargetTransform_BodyName_IsValid;

	private static FFieldAddress GetBodyTargetTransform_BodyName_PropertyAddress;

	private static int GetBodyTargetTransform_BodyName_Offset;

	private static bool GetBodyTargetTransform_ReturnValue_IsValid;

	private static FFieldAddress GetBodyTargetTransform_ReturnValue_PropertyAddress;

	private static int GetBodyTargetTransform_ReturnValue_Offset;

	private static bool ApplyPhysicalAnimationSettingsBelow_IsValid;

	private static IntPtr ApplyPhysicalAnimationSettingsBelow_FunctionAddress;

	private static int ApplyPhysicalAnimationSettingsBelow_ParamsSize;

	private static bool ApplyPhysicalAnimationSettingsBelow_BodyName_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationSettingsBelow_BodyName_PropertyAddress;

	private static int ApplyPhysicalAnimationSettingsBelow_BodyName_Offset;

	private static bool ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_PropertyAddress;

	private static int ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_Offset;

	private static bool ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_PropertyAddress;

	private static int ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_Offset;

	private static bool ApplyPhysicalAnimationSettings_IsValid;

	private static IntPtr ApplyPhysicalAnimationSettings_FunctionAddress;

	private static int ApplyPhysicalAnimationSettings_ParamsSize;

	private static bool ApplyPhysicalAnimationSettings_BodyName_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationSettings_BodyName_PropertyAddress;

	private static int ApplyPhysicalAnimationSettings_BodyName_Offset;

	private static bool ApplyPhysicalAnimationSettings_PhysicalAnimationData_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationSettings_PhysicalAnimationData_PropertyAddress;

	private static int ApplyPhysicalAnimationSettings_PhysicalAnimationData_Offset;

	private static bool ApplyPhysicalAnimationProfileBelow_IsValid;

	private static IntPtr ApplyPhysicalAnimationProfileBelow_FunctionAddress;

	private static int ApplyPhysicalAnimationProfileBelow_ParamsSize;

	private static bool ApplyPhysicalAnimationProfileBelow_BodyName_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationProfileBelow_BodyName_PropertyAddress;

	private static int ApplyPhysicalAnimationProfileBelow_BodyName_Offset;

	private static bool ApplyPhysicalAnimationProfileBelow_ProfileName_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationProfileBelow_ProfileName_PropertyAddress;

	private static int ApplyPhysicalAnimationProfileBelow_ProfileName_Offset;

	private static bool ApplyPhysicalAnimationProfileBelow_bIncludeSelf_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationProfileBelow_bIncludeSelf_PropertyAddress;

	private static int ApplyPhysicalAnimationProfileBelow_bIncludeSelf_Offset;

	private static bool ApplyPhysicalAnimationProfileBelow_bClearNotFound_IsValid;

	private static FFieldAddress ApplyPhysicalAnimationProfileBelow_bClearNotFound_PropertyAddress;

	private static int ApplyPhysicalAnimationProfileBelow_bClearNotFound_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PhysicalAnimationComponent:StrengthMultiplyer")]
	public float StrengthMultiplyer
	{
		get
		{
			CheckDestroyed();
			if (!StrengthMultiplyer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalAnimationComponent:StrengthMultiplyer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StrengthMultiplyer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StrengthMultiplyer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicalAnimationComponent:StrengthMultiplyer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StrengthMultiplyer_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicalAnimationComponent:SetStrengthMultiplyer")]
	public unsafe void SetStrengthMultiplyer(float InStrengthMultiplyer)
	{
		CheckDestroyed();
		if (!SetStrengthMultiplyer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicalAnimationComponent:SetStrengthMultiplyer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStrengthMultiplyer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStrengthMultiplyer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStrengthMultiplyer_InStrengthMultiplyer_Offset), 0, SetStrengthMultiplyer_InStrengthMultiplyer_PropertyAddress.Address, InStrengthMultiplyer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStrengthMultiplyer_FunctionAddress, intPtr, SetStrengthMultiplyer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicalAnimationComponent:SetSkeletalMeshComponent")]
	public unsafe void SetSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent)
	{
		CheckDestroyed();
		if (!SetSkeletalMeshComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicalAnimationComponent:SetSkeletalMeshComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkeletalMeshComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkeletalMeshComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetSkeletalMeshComponent_InSkeletalMeshComponent_Offset), 0, SetSkeletalMeshComponent_InSkeletalMeshComponent_PropertyAddress.Address, InSkeletalMeshComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkeletalMeshComponent_FunctionAddress, intPtr, SetSkeletalMeshComponent_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PhysicalAnimationComponent:GetBodyTargetTransform")]
	public unsafe FTransform GetBodyTargetTransform(FName BodyName)
	{
		CheckDestroyed();
		if (!GetBodyTargetTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicalAnimationComponent:GetBodyTargetTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBodyTargetTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBodyTargetTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBodyTargetTransform_BodyName_Offset), 0, GetBodyTargetTransform_BodyName_PropertyAddress.Address, BodyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBodyTargetTransform_FunctionAddress, intPtr, GetBodyTargetTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBodyTargetTransform_ReturnValue_Offset), 0, GetBodyTargetTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationSettingsBelow")]
	public unsafe void ApplyPhysicalAnimationSettingsBelow(FName BodyName, FPhysicalAnimationData PhysicalAnimationData, bool bIncludeSelf = true)
	{
		CheckDestroyed();
		if (!ApplyPhysicalAnimationSettingsBelow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationSettingsBelow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPhysicalAnimationSettingsBelow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPhysicalAnimationSettingsBelow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationSettingsBelow_BodyName_Offset), 0, ApplyPhysicalAnimationSettingsBelow_BodyName_PropertyAddress.Address, BodyName);
		NativeReflection.InitializeValue_InContainer(ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_PropertyAddress.Address, intPtr);
		FPhysicalAnimationData.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_Offset), 0, ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_PropertyAddress.Address, PhysicalAnimationData);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_Offset), 0, ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_PropertyAddress.Address, bIncludeSelf);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyPhysicalAnimationSettingsBelow_FunctionAddress, intPtr, ApplyPhysicalAnimationSettingsBelow_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationSettings")]
	public unsafe void ApplyPhysicalAnimationSettings(FName BodyName, FPhysicalAnimationData PhysicalAnimationData)
	{
		CheckDestroyed();
		if (!ApplyPhysicalAnimationSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPhysicalAnimationSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPhysicalAnimationSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationSettings_BodyName_Offset), 0, ApplyPhysicalAnimationSettings_BodyName_PropertyAddress.Address, BodyName);
		NativeReflection.InitializeValue_InContainer(ApplyPhysicalAnimationSettings_PhysicalAnimationData_PropertyAddress.Address, intPtr);
		FPhysicalAnimationData.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationSettings_PhysicalAnimationData_Offset), 0, ApplyPhysicalAnimationSettings_PhysicalAnimationData_PropertyAddress.Address, PhysicalAnimationData);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyPhysicalAnimationSettings_FunctionAddress, intPtr, ApplyPhysicalAnimationSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationProfileBelow")]
	public unsafe void ApplyPhysicalAnimationProfileBelow(FName BodyName, FName ProfileName, bool bIncludeSelf = true, bool bClearNotFound = false)
	{
		CheckDestroyed();
		if (!ApplyPhysicalAnimationProfileBelow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationProfileBelow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPhysicalAnimationProfileBelow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPhysicalAnimationProfileBelow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationProfileBelow_BodyName_Offset), 0, ApplyPhysicalAnimationProfileBelow_BodyName_PropertyAddress.Address, BodyName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationProfileBelow_ProfileName_Offset), 0, ApplyPhysicalAnimationProfileBelow_ProfileName_PropertyAddress.Address, ProfileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationProfileBelow_bIncludeSelf_Offset), 0, ApplyPhysicalAnimationProfileBelow_bIncludeSelf_PropertyAddress.Address, bIncludeSelf);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyPhysicalAnimationProfileBelow_bClearNotFound_Offset), 0, ApplyPhysicalAnimationProfileBelow_bClearNotFound_PropertyAddress.Address, bClearNotFound);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyPhysicalAnimationProfileBelow_FunctionAddress, intPtr, ApplyPhysicalAnimationProfileBelow_ParamsSize);
	}

	static UPhysicalAnimationComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicalAnimationComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicalAnimationComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PhysicalAnimationComponent");
		StrengthMultiplyer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrengthMultiplyer");
		StrengthMultiplyer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrengthMultiplyer", Classes.FFloatProperty);
		SetStrengthMultiplyer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStrengthMultiplyer");
		SetStrengthMultiplyer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStrengthMultiplyer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStrengthMultiplyer_InStrengthMultiplyer_PropertyAddress, SetStrengthMultiplyer_FunctionAddress, "InStrengthMultiplyer");
		SetStrengthMultiplyer_InStrengthMultiplyer_Offset = NativeReflectionCached.GetPropertyOffset(SetStrengthMultiplyer_FunctionAddress, "InStrengthMultiplyer");
		SetStrengthMultiplyer_InStrengthMultiplyer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStrengthMultiplyer_FunctionAddress, "InStrengthMultiplyer", Classes.FFloatProperty);
		SetStrengthMultiplyer_IsValid = SetStrengthMultiplyer_FunctionAddress != IntPtr.Zero && SetStrengthMultiplyer_InStrengthMultiplyer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicalAnimationComponent:SetStrengthMultiplyer", SetStrengthMultiplyer_IsValid);
		SetSkeletalMeshComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkeletalMeshComponent");
		SetSkeletalMeshComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkeletalMeshComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshComponent_InSkeletalMeshComponent_PropertyAddress, SetSkeletalMeshComponent_FunctionAddress, "InSkeletalMeshComponent");
		SetSkeletalMeshComponent_InSkeletalMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshComponent_FunctionAddress, "InSkeletalMeshComponent");
		SetSkeletalMeshComponent_InSkeletalMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshComponent_FunctionAddress, "InSkeletalMeshComponent", Classes.FObjectProperty);
		SetSkeletalMeshComponent_IsValid = SetSkeletalMeshComponent_FunctionAddress != IntPtr.Zero && SetSkeletalMeshComponent_InSkeletalMeshComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicalAnimationComponent:SetSkeletalMeshComponent", SetSkeletalMeshComponent_IsValid);
		GetBodyTargetTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBodyTargetTransform");
		GetBodyTargetTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBodyTargetTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBodyTargetTransform_BodyName_PropertyAddress, GetBodyTargetTransform_FunctionAddress, "BodyName");
		GetBodyTargetTransform_BodyName_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyTargetTransform_FunctionAddress, "BodyName");
		GetBodyTargetTransform_BodyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyTargetTransform_FunctionAddress, "BodyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBodyTargetTransform_ReturnValue_PropertyAddress, GetBodyTargetTransform_FunctionAddress, "ReturnValue");
		GetBodyTargetTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyTargetTransform_FunctionAddress, "ReturnValue");
		GetBodyTargetTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyTargetTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBodyTargetTransform_IsValid = GetBodyTargetTransform_FunctionAddress != IntPtr.Zero && GetBodyTargetTransform_BodyName_IsValid && GetBodyTargetTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicalAnimationComponent:GetBodyTargetTransform", GetBodyTargetTransform_IsValid);
		ApplyPhysicalAnimationSettingsBelow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyPhysicalAnimationSettingsBelow");
		ApplyPhysicalAnimationSettingsBelow_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPhysicalAnimationSettingsBelow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationSettingsBelow_BodyName_PropertyAddress, ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "BodyName");
		ApplyPhysicalAnimationSettingsBelow_BodyName_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "BodyName");
		ApplyPhysicalAnimationSettingsBelow_BodyName_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "BodyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_PropertyAddress, ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "PhysicalAnimationData");
		ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "PhysicalAnimationData");
		ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "PhysicalAnimationData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_PropertyAddress, ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "bIncludeSelf");
		ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "bIncludeSelf");
		ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationSettingsBelow_FunctionAddress, "bIncludeSelf", Classes.FBoolProperty);
		ApplyPhysicalAnimationSettingsBelow_IsValid = ApplyPhysicalAnimationSettingsBelow_FunctionAddress != IntPtr.Zero && ApplyPhysicalAnimationSettingsBelow_BodyName_IsValid && ApplyPhysicalAnimationSettingsBelow_PhysicalAnimationData_IsValid && ApplyPhysicalAnimationSettingsBelow_bIncludeSelf_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationSettingsBelow", ApplyPhysicalAnimationSettingsBelow_IsValid);
		ApplyPhysicalAnimationSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyPhysicalAnimationSettings");
		ApplyPhysicalAnimationSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPhysicalAnimationSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationSettings_BodyName_PropertyAddress, ApplyPhysicalAnimationSettings_FunctionAddress, "BodyName");
		ApplyPhysicalAnimationSettings_BodyName_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationSettings_FunctionAddress, "BodyName");
		ApplyPhysicalAnimationSettings_BodyName_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationSettings_FunctionAddress, "BodyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationSettings_PhysicalAnimationData_PropertyAddress, ApplyPhysicalAnimationSettings_FunctionAddress, "PhysicalAnimationData");
		ApplyPhysicalAnimationSettings_PhysicalAnimationData_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationSettings_FunctionAddress, "PhysicalAnimationData");
		ApplyPhysicalAnimationSettings_PhysicalAnimationData_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationSettings_FunctionAddress, "PhysicalAnimationData", Classes.FStructProperty);
		ApplyPhysicalAnimationSettings_IsValid = ApplyPhysicalAnimationSettings_FunctionAddress != IntPtr.Zero && ApplyPhysicalAnimationSettings_BodyName_IsValid && ApplyPhysicalAnimationSettings_PhysicalAnimationData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationSettings", ApplyPhysicalAnimationSettings_IsValid);
		ApplyPhysicalAnimationProfileBelow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyPhysicalAnimationProfileBelow");
		ApplyPhysicalAnimationProfileBelow_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPhysicalAnimationProfileBelow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationProfileBelow_BodyName_PropertyAddress, ApplyPhysicalAnimationProfileBelow_FunctionAddress, "BodyName");
		ApplyPhysicalAnimationProfileBelow_BodyName_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationProfileBelow_FunctionAddress, "BodyName");
		ApplyPhysicalAnimationProfileBelow_BodyName_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationProfileBelow_FunctionAddress, "BodyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationProfileBelow_ProfileName_PropertyAddress, ApplyPhysicalAnimationProfileBelow_FunctionAddress, "ProfileName");
		ApplyPhysicalAnimationProfileBelow_ProfileName_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationProfileBelow_FunctionAddress, "ProfileName");
		ApplyPhysicalAnimationProfileBelow_ProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationProfileBelow_FunctionAddress, "ProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationProfileBelow_bIncludeSelf_PropertyAddress, ApplyPhysicalAnimationProfileBelow_FunctionAddress, "bIncludeSelf");
		ApplyPhysicalAnimationProfileBelow_bIncludeSelf_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationProfileBelow_FunctionAddress, "bIncludeSelf");
		ApplyPhysicalAnimationProfileBelow_bIncludeSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationProfileBelow_FunctionAddress, "bIncludeSelf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalAnimationProfileBelow_bClearNotFound_PropertyAddress, ApplyPhysicalAnimationProfileBelow_FunctionAddress, "bClearNotFound");
		ApplyPhysicalAnimationProfileBelow_bClearNotFound_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicalAnimationProfileBelow_FunctionAddress, "bClearNotFound");
		ApplyPhysicalAnimationProfileBelow_bClearNotFound_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicalAnimationProfileBelow_FunctionAddress, "bClearNotFound", Classes.FBoolProperty);
		ApplyPhysicalAnimationProfileBelow_IsValid = ApplyPhysicalAnimationProfileBelow_FunctionAddress != IntPtr.Zero && ApplyPhysicalAnimationProfileBelow_BodyName_IsValid && ApplyPhysicalAnimationProfileBelow_ProfileName_IsValid && ApplyPhysicalAnimationProfileBelow_bIncludeSelf_IsValid && ApplyPhysicalAnimationProfileBelow_bClearNotFound_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicalAnimationComponent:ApplyPhysicalAnimationProfileBelow", ApplyPhysicalAnimationProfileBelow_IsValid);
	}
}
