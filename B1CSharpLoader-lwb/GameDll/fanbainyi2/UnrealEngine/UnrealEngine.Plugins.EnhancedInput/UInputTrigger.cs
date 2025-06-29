using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[Abstract]
[UClass(Flags = (ClassFlags)1884303527uL, Config = "Input")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/EnhancedInput.InputTrigger", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputTrigger : UObject
{
	private static bool ActuationThreshold_IsValid;

	private static int ActuationThreshold_Offset;

	private static bool LastValue_IsValid;

	private static int LastValue_Offset;

	private static bool UpdateState_IsValid;

	private IntPtr UpdateState_InstanceFunctionAddress;

	private static IntPtr UpdateState_FunctionAddress;

	private static int UpdateState_ParamsSize;

	private static bool UpdateState_PlayerInput_IsValid;

	private static FFieldAddress UpdateState_PlayerInput_PropertyAddress;

	private static int UpdateState_PlayerInput_Offset;

	private static bool UpdateState_ModifiedValue_IsValid;

	private static FFieldAddress UpdateState_ModifiedValue_PropertyAddress;

	private static int UpdateState_ModifiedValue_Offset;

	private static bool UpdateState_DeltaTime_IsValid;

	private static FFieldAddress UpdateState_DeltaTime_PropertyAddress;

	private static int UpdateState_DeltaTime_Offset;

	private static bool UpdateState_ReturnValue_IsValid;

	private static FFieldAddress UpdateState_ReturnValue_PropertyAddress;

	private static int UpdateState_ReturnValue_Offset;

	private static bool IsActuated_IsValid;

	private static IntPtr IsActuated_FunctionAddress;

	private static int IsActuated_ParamsSize;

	private static bool IsActuated_ForValue_IsValid;

	private static FFieldAddress IsActuated_ForValue_PropertyAddress;

	private static int IsActuated_ForValue_Offset;

	private static bool IsActuated_ReturnValue_IsValid;

	private static FFieldAddress IsActuated_ReturnValue_PropertyAddress;

	private static int IsActuated_ReturnValue_Offset;

	private static bool GetTriggerType_IsValid;

	private IntPtr GetTriggerType_InstanceFunctionAddress;

	private static IntPtr GetTriggerType_FunctionAddress;

	private static int GetTriggerType_ParamsSize;

	private static bool GetTriggerType_ReturnValue_IsValid;

	private static FFieldAddress GetTriggerType_ReturnValue_PropertyAddress;

	private static int GetTriggerType_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTrigger:ActuationThreshold")]
	public float ActuationThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ActuationThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTrigger:ActuationThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ActuationThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActuationThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTrigger:ActuationThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ActuationThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/EnhancedInput.InputTrigger:LastValue")]
	public FInputActionValue LastValue
	{
		get
		{
			CheckDestroyed();
			if (!LastValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTrigger:LastValue");
				return default(FInputActionValue);
			}
			return FInputActionValue.FromNative(IntPtr.Add(base.Address, LastValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTrigger:LastValue");
			}
			else
			{
				FInputActionValue.ToNative(IntPtr.Add(base.Address, LastValue_Offset), value);
			}
		}
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/EnhancedInput.InputTrigger:UpdateState")]
	public unsafe ETriggerState UpdateState(UEnhancedPlayerInput PlayerInput, FInputActionValue ModifiedValue, float DeltaTime)
	{
		CheckDestroyed();
		if (!UpdateState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputTrigger:UpdateState");
			return ETriggerState.None;
		}
		if (UpdateState_InstanceFunctionAddress == IntPtr.Zero)
		{
			UpdateState_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "UpdateState");
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnhancedPlayerInput>.ToNative(IntPtr.Add(intPtr, UpdateState_PlayerInput_Offset), 0, UpdateState_PlayerInput_PropertyAddress.Address, PlayerInput);
		NativeReflection.InitializeValue_InContainer(UpdateState_ModifiedValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, UpdateState_ModifiedValue_Offset), 0, UpdateState_ModifiedValue_PropertyAddress.Address, ModifiedValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateState_DeltaTime_Offset), 0, UpdateState_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateState_InstanceFunctionAddress, intPtr, UpdateState_ParamsSize);
		return EnumMarshaler<ETriggerState>.FromNative(IntPtr.Add(intPtr, UpdateState_ReturnValue_Offset), 0, UpdateState_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual ETriggerState UpdateState_Implementation(UEnhancedPlayerInput PlayerInput, FInputActionValue ModifiedValue, float DeltaTime)
	{
		CheckDestroyed();
		if (!UpdateState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputTrigger:UpdateState");
			return ETriggerState.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnhancedPlayerInput>.ToNative(IntPtr.Add(intPtr, UpdateState_PlayerInput_Offset), 0, UpdateState_PlayerInput_PropertyAddress.Address, PlayerInput);
		NativeReflection.InitializeValue_InContainer(UpdateState_ModifiedValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, UpdateState_ModifiedValue_Offset), 0, UpdateState_ModifiedValue_PropertyAddress.Address, ModifiedValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateState_DeltaTime_Offset), 0, UpdateState_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateState_FunctionAddress, intPtr, UpdateState_ParamsSize);
		return EnumMarshaler<ETriggerState>.FromNative(IntPtr.Add(intPtr, UpdateState_ReturnValue_Offset), 0, UpdateState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/EnhancedInput.InputTrigger:IsActuated")]
	public unsafe bool IsActuated(FInputActionValue ForValue)
	{
		CheckDestroyed();
		if (!IsActuated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputTrigger:IsActuated");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActuated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActuated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsActuated_ForValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, IsActuated_ForValue_Offset), 0, IsActuated_ForValue_PropertyAddress.Address, ForValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActuated_FunctionAddress, intPtr, IsActuated_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActuated_ReturnValue_Offset), 0, IsActuated_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/EnhancedInput.InputTrigger:GetTriggerType")]
	public unsafe ETriggerType GetTriggerType()
	{
		CheckDestroyed();
		if (!GetTriggerType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputTrigger:GetTriggerType");
			return ETriggerType.Explicit;
		}
		if (GetTriggerType_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetTriggerType_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetTriggerType");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriggerType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriggerType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriggerType_InstanceFunctionAddress, intPtr, GetTriggerType_ParamsSize);
		return EnumMarshaler<ETriggerType>.FromNative(IntPtr.Add(intPtr, GetTriggerType_ReturnValue_Offset), 0, GetTriggerType_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual ETriggerType GetTriggerType_Implementation()
	{
		CheckDestroyed();
		if (!GetTriggerType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputTrigger:GetTriggerType");
			return ETriggerType.Explicit;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriggerType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriggerType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriggerType_FunctionAddress, intPtr, GetTriggerType_ParamsSize);
		return EnumMarshaler<ETriggerType>.FromNative(IntPtr.Add(intPtr, GetTriggerType_ReturnValue_Offset), 0, GetTriggerType_ReturnValue_PropertyAddress.Address);
	}

	static UInputTrigger()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputTrigger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputTrigger));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/EnhancedInput.InputTrigger");
		ActuationThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActuationThreshold");
		ActuationThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActuationThreshold", Classes.FFloatProperty);
		LastValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastValue");
		LastValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastValue", Classes.FStructProperty);
		UpdateState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateState");
		UpdateState_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateState_PlayerInput_PropertyAddress, UpdateState_FunctionAddress, "PlayerInput");
		UpdateState_PlayerInput_Offset = NativeReflectionCached.GetPropertyOffset(UpdateState_FunctionAddress, "PlayerInput");
		UpdateState_PlayerInput_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateState_FunctionAddress, "PlayerInput", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateState_ModifiedValue_PropertyAddress, UpdateState_FunctionAddress, "ModifiedValue");
		UpdateState_ModifiedValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateState_FunctionAddress, "ModifiedValue");
		UpdateState_ModifiedValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateState_FunctionAddress, "ModifiedValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateState_DeltaTime_PropertyAddress, UpdateState_FunctionAddress, "DeltaTime");
		UpdateState_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(UpdateState_FunctionAddress, "DeltaTime");
		UpdateState_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateState_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateState_ReturnValue_PropertyAddress, UpdateState_FunctionAddress, "ReturnValue");
		UpdateState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateState_FunctionAddress, "ReturnValue");
		UpdateState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		UpdateState_IsValid = UpdateState_FunctionAddress != IntPtr.Zero && UpdateState_PlayerInput_IsValid && UpdateState_ModifiedValue_IsValid && UpdateState_DeltaTime_IsValid && UpdateState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputTrigger:UpdateState", UpdateState_IsValid);
		IsActuated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsActuated");
		IsActuated_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActuated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActuated_ForValue_PropertyAddress, IsActuated_FunctionAddress, "ForValue");
		IsActuated_ForValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActuated_FunctionAddress, "ForValue");
		IsActuated_ForValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActuated_FunctionAddress, "ForValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActuated_ReturnValue_PropertyAddress, IsActuated_FunctionAddress, "ReturnValue");
		IsActuated_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActuated_FunctionAddress, "ReturnValue");
		IsActuated_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActuated_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActuated_IsValid = IsActuated_FunctionAddress != IntPtr.Zero && IsActuated_ForValue_IsValid && IsActuated_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputTrigger:IsActuated", IsActuated_IsValid);
		GetTriggerType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTriggerType");
		GetTriggerType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriggerType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriggerType_ReturnValue_PropertyAddress, GetTriggerType_FunctionAddress, "ReturnValue");
		GetTriggerType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriggerType_FunctionAddress, "ReturnValue");
		GetTriggerType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriggerType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetTriggerType_IsValid = GetTriggerType_FunctionAddress != IntPtr.Zero && GetTriggerType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputTrigger:GetTriggerType", GetTriggerType_IsValid);
	}
}
