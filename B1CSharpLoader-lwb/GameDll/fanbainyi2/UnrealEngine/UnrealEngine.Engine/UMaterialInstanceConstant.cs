using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818421920uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialInstanceConstant", "Engine", UnrealModuleType.Engine)]
public class UMaterialInstanceConstant : UMaterialInstance
{
	private static bool GetVectorParameterValue_IsValid;

	private static IntPtr GetVectorParameterValue_FunctionAddress;

	private static int GetVectorParameterValue_ParamsSize;

	private static bool GetVectorParameterValue_ParameterName_IsValid;

	private static FFieldAddress GetVectorParameterValue_ParameterName_PropertyAddress;

	private static int GetVectorParameterValue_ParameterName_Offset;

	private static bool GetVectorParameterValue_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameterValue_ReturnValue_PropertyAddress;

	private static int GetVectorParameterValue_ReturnValue_Offset;

	private static bool GetTextureParameterValue_IsValid;

	private static IntPtr GetTextureParameterValue_FunctionAddress;

	private static int GetTextureParameterValue_ParamsSize;

	private static bool GetTextureParameterValue_ParameterName_IsValid;

	private static FFieldAddress GetTextureParameterValue_ParameterName_PropertyAddress;

	private static int GetTextureParameterValue_ParameterName_Offset;

	private static bool GetTextureParameterValue_ReturnValue_IsValid;

	private static FFieldAddress GetTextureParameterValue_ReturnValue_PropertyAddress;

	private static int GetTextureParameterValue_ReturnValue_Offset;

	private static bool GetScalarParameterValue_IsValid;

	private static IntPtr GetScalarParameterValue_FunctionAddress;

	private static int GetScalarParameterValue_ParamsSize;

	private static bool GetScalarParameterValue_ParameterName_IsValid;

	private static FFieldAddress GetScalarParameterValue_ParameterName_PropertyAddress;

	private static int GetScalarParameterValue_ParameterName_Offset;

	private static bool GetScalarParameterValue_ReturnValue_IsValid;

	private static FFieldAddress GetScalarParameterValue_ReturnValue_PropertyAddress;

	private static int GetScalarParameterValue_ReturnValue_Offset;

	[UFunction(Flags = 75629569u, OriginalName = "K2_GetVectorParameterValue")]
	[UMetaPath("/Script/Engine.MaterialInstanceConstant:K2_GetVectorParameterValue")]
	public unsafe FLinearColor GetVectorParameterValue(FName ParameterName)
	{
		CheckDestroyed();
		if (!GetVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceConstant:K2_GetVectorParameterValue");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorParameterValue_ParameterName_Offset), 0, GetVectorParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorParameterValue_FunctionAddress, intPtr, GetVectorParameterValue_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetVectorParameterValue_ReturnValue_Offset), 0, GetVectorParameterValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_GetTextureParameterValue")]
	[UMetaPath("/Script/Engine.MaterialInstanceConstant:K2_GetTextureParameterValue")]
	public unsafe UTexture GetTextureParameterValue(FName ParameterName)
	{
		CheckDestroyed();
		if (!GetTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceConstant:K2_GetTextureParameterValue");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTextureParameterValue_ParameterName_Offset), 0, GetTextureParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureParameterValue_FunctionAddress, intPtr, GetTextureParameterValue_ParamsSize);
		return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(intPtr, GetTextureParameterValue_ReturnValue_Offset), 0, GetTextureParameterValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_GetScalarParameterValue")]
	[UMetaPath("/Script/Engine.MaterialInstanceConstant:K2_GetScalarParameterValue")]
	public unsafe float GetScalarParameterValue(FName ParameterName)
	{
		CheckDestroyed();
		if (!GetScalarParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceConstant:K2_GetScalarParameterValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScalarParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScalarParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetScalarParameterValue_ParameterName_Offset), 0, GetScalarParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScalarParameterValue_FunctionAddress, intPtr, GetScalarParameterValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScalarParameterValue_ReturnValue_Offset), 0, GetScalarParameterValue_ReturnValue_PropertyAddress.Address);
	}

	static UMaterialInstanceConstant()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialInstanceConstant)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialInstanceConstant));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.MaterialInstanceConstant");
		GetVectorParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetVectorParameterValue");
		GetVectorParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValue_ParameterName_PropertyAddress, GetVectorParameterValue_FunctionAddress, "ParameterName");
		GetVectorParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValue_FunctionAddress, "ParameterName");
		GetVectorParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValue_ReturnValue_PropertyAddress, GetVectorParameterValue_FunctionAddress, "ReturnValue");
		GetVectorParameterValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValue_FunctionAddress, "ReturnValue");
		GetVectorParameterValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorParameterValue_IsValid = GetVectorParameterValue_FunctionAddress != IntPtr.Zero && GetVectorParameterValue_ParameterName_IsValid && GetVectorParameterValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceConstant:K2_GetVectorParameterValue", GetVectorParameterValue_IsValid);
		GetTextureParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetTextureParameterValue");
		GetTextureParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterValue_ParameterName_PropertyAddress, GetTextureParameterValue_FunctionAddress, "ParameterName");
		GetTextureParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterValue_FunctionAddress, "ParameterName");
		GetTextureParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterValue_ReturnValue_PropertyAddress, GetTextureParameterValue_FunctionAddress, "ReturnValue");
		GetTextureParameterValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterValue_FunctionAddress, "ReturnValue");
		GetTextureParameterValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterValue_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTextureParameterValue_IsValid = GetTextureParameterValue_FunctionAddress != IntPtr.Zero && GetTextureParameterValue_ParameterName_IsValid && GetTextureParameterValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceConstant:K2_GetTextureParameterValue", GetTextureParameterValue_IsValid);
		GetScalarParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetScalarParameterValue");
		GetScalarParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScalarParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValue_ParameterName_PropertyAddress, GetScalarParameterValue_FunctionAddress, "ParameterName");
		GetScalarParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValue_FunctionAddress, "ParameterName");
		GetScalarParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValue_ReturnValue_PropertyAddress, GetScalarParameterValue_FunctionAddress, "ReturnValue");
		GetScalarParameterValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValue_FunctionAddress, "ReturnValue");
		GetScalarParameterValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScalarParameterValue_IsValid = GetScalarParameterValue_FunctionAddress != IntPtr.Zero && GetScalarParameterValue_ParameterName_IsValid && GetScalarParameterValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceConstant:K2_GetScalarParameterValue", GetScalarParameterValue_IsValid);
	}
}
