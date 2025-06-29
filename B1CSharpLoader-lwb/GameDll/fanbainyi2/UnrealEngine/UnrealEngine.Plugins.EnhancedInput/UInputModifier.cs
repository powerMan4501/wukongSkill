using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[Abstract]
[UClass(Flags = (ClassFlags)1884303523uL, Config = "Input")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/EnhancedInput.InputModifier", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifier : UObject
{
	private static bool ModifyRaw_IsValid;

	private IntPtr ModifyRaw_InstanceFunctionAddress;

	private static IntPtr ModifyRaw_FunctionAddress;

	private static int ModifyRaw_ParamsSize;

	private static bool ModifyRaw_PlayerInput_IsValid;

	private static FFieldAddress ModifyRaw_PlayerInput_PropertyAddress;

	private static int ModifyRaw_PlayerInput_Offset;

	private static bool ModifyRaw_CurrentValue_IsValid;

	private static FFieldAddress ModifyRaw_CurrentValue_PropertyAddress;

	private static int ModifyRaw_CurrentValue_Offset;

	private static bool ModifyRaw_DeltaTime_IsValid;

	private static FFieldAddress ModifyRaw_DeltaTime_PropertyAddress;

	private static int ModifyRaw_DeltaTime_Offset;

	private static bool ModifyRaw_ReturnValue_IsValid;

	private static FFieldAddress ModifyRaw_ReturnValue_PropertyAddress;

	private static int ModifyRaw_ReturnValue_Offset;

	private static bool GetVisualizationColor_IsValid;

	private IntPtr GetVisualizationColor_InstanceFunctionAddress;

	private static IntPtr GetVisualizationColor_FunctionAddress;

	private static int GetVisualizationColor_ParamsSize;

	private static bool GetVisualizationColor_SampleValue_IsValid;

	private static FFieldAddress GetVisualizationColor_SampleValue_PropertyAddress;

	private static int GetVisualizationColor_SampleValue_Offset;

	private static bool GetVisualizationColor_FinalValue_IsValid;

	private static FFieldAddress GetVisualizationColor_FinalValue_PropertyAddress;

	private static int GetVisualizationColor_FinalValue_Offset;

	private static bool GetVisualizationColor_ReturnValue_IsValid;

	private static FFieldAddress GetVisualizationColor_ReturnValue_PropertyAddress;

	private static int GetVisualizationColor_ReturnValue_Offset;

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/EnhancedInput.InputModifier:ModifyRaw")]
	public unsafe FInputActionValue ModifyRaw(UEnhancedPlayerInput PlayerInput, FInputActionValue CurrentValue, float DeltaTime)
	{
		CheckDestroyed();
		if (!ModifyRaw_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputModifier:ModifyRaw");
			return default(FInputActionValue);
		}
		if (ModifyRaw_InstanceFunctionAddress == IntPtr.Zero)
		{
			ModifyRaw_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ModifyRaw");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyRaw_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyRaw_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnhancedPlayerInput>.ToNative(IntPtr.Add(intPtr, ModifyRaw_PlayerInput_Offset), 0, ModifyRaw_PlayerInput_PropertyAddress.Address, PlayerInput);
		NativeReflection.InitializeValue_InContainer(ModifyRaw_CurrentValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, ModifyRaw_CurrentValue_Offset), 0, ModifyRaw_CurrentValue_PropertyAddress.Address, CurrentValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ModifyRaw_DeltaTime_Offset), 0, ModifyRaw_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, ModifyRaw_InstanceFunctionAddress, intPtr, ModifyRaw_ParamsSize);
		return FInputActionValue.FromNative(IntPtr.Add(intPtr, ModifyRaw_ReturnValue_Offset), 0, ModifyRaw_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual FInputActionValue ModifyRaw_Implementation(UEnhancedPlayerInput PlayerInput, FInputActionValue CurrentValue, float DeltaTime)
	{
		CheckDestroyed();
		if (!ModifyRaw_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputModifier:ModifyRaw");
			return default(FInputActionValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyRaw_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyRaw_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnhancedPlayerInput>.ToNative(IntPtr.Add(intPtr, ModifyRaw_PlayerInput_Offset), 0, ModifyRaw_PlayerInput_PropertyAddress.Address, PlayerInput);
		NativeReflection.InitializeValue_InContainer(ModifyRaw_CurrentValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, ModifyRaw_CurrentValue_Offset), 0, ModifyRaw_CurrentValue_PropertyAddress.Address, CurrentValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ModifyRaw_DeltaTime_Offset), 0, ModifyRaw_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, ModifyRaw_FunctionAddress, intPtr, ModifyRaw_ParamsSize);
		return FInputActionValue.FromNative(IntPtr.Add(intPtr, ModifyRaw_ReturnValue_Offset), 0, ModifyRaw_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1216482304u)]
	[UMetaPath("/Script/EnhancedInput.InputModifier:GetVisualizationColor")]
	public unsafe FLinearColor GetVisualizationColor(FInputActionValue SampleValue, FInputActionValue FinalValue)
	{
		CheckDestroyed();
		if (!GetVisualizationColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputModifier:GetVisualizationColor");
			return default(FLinearColor);
		}
		if (GetVisualizationColor_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetVisualizationColor_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetVisualizationColor");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVisualizationColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVisualizationColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVisualizationColor_SampleValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, GetVisualizationColor_SampleValue_Offset), 0, GetVisualizationColor_SampleValue_PropertyAddress.Address, SampleValue);
		NativeReflection.InitializeValue_InContainer(GetVisualizationColor_FinalValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, GetVisualizationColor_FinalValue_Offset), 0, GetVisualizationColor_FinalValue_PropertyAddress.Address, FinalValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVisualizationColor_InstanceFunctionAddress, intPtr, GetVisualizationColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetVisualizationColor_ReturnValue_Offset), 0, GetVisualizationColor_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual FLinearColor GetVisualizationColor_Implementation(FInputActionValue SampleValue, FInputActionValue FinalValue)
	{
		CheckDestroyed();
		if (!GetVisualizationColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.InputModifier:GetVisualizationColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVisualizationColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVisualizationColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVisualizationColor_SampleValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, GetVisualizationColor_SampleValue_Offset), 0, GetVisualizationColor_SampleValue_PropertyAddress.Address, SampleValue);
		NativeReflection.InitializeValue_InContainer(GetVisualizationColor_FinalValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, GetVisualizationColor_FinalValue_Offset), 0, GetVisualizationColor_FinalValue_PropertyAddress.Address, FinalValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVisualizationColor_FunctionAddress, intPtr, GetVisualizationColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetVisualizationColor_ReturnValue_Offset), 0, GetVisualizationColor_ReturnValue_PropertyAddress.Address);
	}

	static UInputModifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifier));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/EnhancedInput.InputModifier");
		ModifyRaw_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ModifyRaw");
		ModifyRaw_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyRaw_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyRaw_PlayerInput_PropertyAddress, ModifyRaw_FunctionAddress, "PlayerInput");
		ModifyRaw_PlayerInput_Offset = NativeReflectionCached.GetPropertyOffset(ModifyRaw_FunctionAddress, "PlayerInput");
		ModifyRaw_PlayerInput_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyRaw_FunctionAddress, "PlayerInput", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyRaw_CurrentValue_PropertyAddress, ModifyRaw_FunctionAddress, "CurrentValue");
		ModifyRaw_CurrentValue_Offset = NativeReflectionCached.GetPropertyOffset(ModifyRaw_FunctionAddress, "CurrentValue");
		ModifyRaw_CurrentValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyRaw_FunctionAddress, "CurrentValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyRaw_DeltaTime_PropertyAddress, ModifyRaw_FunctionAddress, "DeltaTime");
		ModifyRaw_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(ModifyRaw_FunctionAddress, "DeltaTime");
		ModifyRaw_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyRaw_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyRaw_ReturnValue_PropertyAddress, ModifyRaw_FunctionAddress, "ReturnValue");
		ModifyRaw_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ModifyRaw_FunctionAddress, "ReturnValue");
		ModifyRaw_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyRaw_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ModifyRaw_IsValid = ModifyRaw_FunctionAddress != IntPtr.Zero && ModifyRaw_PlayerInput_IsValid && ModifyRaw_CurrentValue_IsValid && ModifyRaw_DeltaTime_IsValid && ModifyRaw_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputModifier:ModifyRaw", ModifyRaw_IsValid);
		GetVisualizationColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVisualizationColor");
		GetVisualizationColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVisualizationColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVisualizationColor_SampleValue_PropertyAddress, GetVisualizationColor_FunctionAddress, "SampleValue");
		GetVisualizationColor_SampleValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVisualizationColor_FunctionAddress, "SampleValue");
		GetVisualizationColor_SampleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVisualizationColor_FunctionAddress, "SampleValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVisualizationColor_FinalValue_PropertyAddress, GetVisualizationColor_FunctionAddress, "FinalValue");
		GetVisualizationColor_FinalValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVisualizationColor_FunctionAddress, "FinalValue");
		GetVisualizationColor_FinalValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVisualizationColor_FunctionAddress, "FinalValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVisualizationColor_ReturnValue_PropertyAddress, GetVisualizationColor_FunctionAddress, "ReturnValue");
		GetVisualizationColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVisualizationColor_FunctionAddress, "ReturnValue");
		GetVisualizationColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVisualizationColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVisualizationColor_IsValid = GetVisualizationColor_FunctionAddress != IntPtr.Zero && GetVisualizationColor_SampleValue_IsValid && GetVisualizationColor_FinalValue_IsValid && GetVisualizationColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.InputModifier:GetVisualizationColor", GetVisualizationColor_IsValid);
	}
}
