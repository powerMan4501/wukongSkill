using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USynthesisUtilitiesBlueprintFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetLogFrequency_IsValid;

	private static IntPtr GetLogFrequency_FunctionAddress;

	private static int GetLogFrequency_ParamsSize;

	private static bool GetLogFrequency_InLinearValue_IsValid;

	private static FFieldAddress GetLogFrequency_InLinearValue_PropertyAddress;

	private static int GetLogFrequency_InLinearValue_Offset;

	private static bool GetLogFrequency_InDomainMin_IsValid;

	private static FFieldAddress GetLogFrequency_InDomainMin_PropertyAddress;

	private static int GetLogFrequency_InDomainMin_Offset;

	private static bool GetLogFrequency_InDomainMax_IsValid;

	private static FFieldAddress GetLogFrequency_InDomainMax_PropertyAddress;

	private static int GetLogFrequency_InDomainMax_Offset;

	private static bool GetLogFrequency_InRangeMin_IsValid;

	private static FFieldAddress GetLogFrequency_InRangeMin_PropertyAddress;

	private static int GetLogFrequency_InRangeMin_Offset;

	private static bool GetLogFrequency_InRangeMax_IsValid;

	private static FFieldAddress GetLogFrequency_InRangeMax_PropertyAddress;

	private static int GetLogFrequency_InRangeMax_Offset;

	private static bool GetLogFrequency_ReturnValue_IsValid;

	private static FFieldAddress GetLogFrequency_ReturnValue_PropertyAddress;

	private static int GetLogFrequency_ReturnValue_Offset;

	private static bool GetLinearFrequency_IsValid;

	private static IntPtr GetLinearFrequency_FunctionAddress;

	private static int GetLinearFrequency_ParamsSize;

	private static bool GetLinearFrequency_InLogFrequencyValue_IsValid;

	private static FFieldAddress GetLinearFrequency_InLogFrequencyValue_PropertyAddress;

	private static int GetLinearFrequency_InLogFrequencyValue_Offset;

	private static bool GetLinearFrequency_InDomainMin_IsValid;

	private static FFieldAddress GetLinearFrequency_InDomainMin_PropertyAddress;

	private static int GetLinearFrequency_InDomainMin_Offset;

	private static bool GetLinearFrequency_InDomainMax_IsValid;

	private static FFieldAddress GetLinearFrequency_InDomainMax_PropertyAddress;

	private static int GetLinearFrequency_InDomainMax_Offset;

	private static bool GetLinearFrequency_InRangeMin_IsValid;

	private static FFieldAddress GetLinearFrequency_InRangeMin_PropertyAddress;

	private static int GetLinearFrequency_InRangeMin_Offset;

	private static bool GetLinearFrequency_InRangeMax_IsValid;

	private static FFieldAddress GetLinearFrequency_InRangeMax_PropertyAddress;

	private static int GetLinearFrequency_InRangeMax_Offset;

	private static bool GetLinearFrequency_ReturnValue_IsValid;

	private static FFieldAddress GetLinearFrequency_ReturnValue_PropertyAddress;

	private static int GetLinearFrequency_ReturnValue_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary:GetLogFrequency")]
	public unsafe static float GetLogFrequency(float InLinearValue, float InDomainMin, float InDomainMax, float InRangeMin, float InRangeMax)
	{
		if (!GetLogFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary:GetLogFrequency");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLogFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLogFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLogFrequency_InLinearValue_Offset), 0, GetLogFrequency_InLinearValue_PropertyAddress.Address, InLinearValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLogFrequency_InDomainMin_Offset), 0, GetLogFrequency_InDomainMin_PropertyAddress.Address, InDomainMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLogFrequency_InDomainMax_Offset), 0, GetLogFrequency_InDomainMax_PropertyAddress.Address, InDomainMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLogFrequency_InRangeMin_Offset), 0, GetLogFrequency_InRangeMin_PropertyAddress.Address, InRangeMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLogFrequency_InRangeMax_Offset), 0, GetLogFrequency_InRangeMax_PropertyAddress.Address, InRangeMax);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLogFrequency_FunctionAddress, intPtr, GetLogFrequency_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLogFrequency_ReturnValue_Offset), 0, GetLogFrequency_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary:GetLinearFrequency")]
	public unsafe static float GetLinearFrequency(float InLogFrequencyValue, float InDomainMin, float InDomainMax, float InRangeMin, float InRangeMax)
	{
		if (!GetLinearFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary:GetLinearFrequency");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLinearFrequency_InLogFrequencyValue_Offset), 0, GetLinearFrequency_InLogFrequencyValue_PropertyAddress.Address, InLogFrequencyValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLinearFrequency_InDomainMin_Offset), 0, GetLinearFrequency_InDomainMin_PropertyAddress.Address, InDomainMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLinearFrequency_InDomainMax_Offset), 0, GetLinearFrequency_InDomainMax_PropertyAddress.Address, InDomainMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLinearFrequency_InRangeMin_Offset), 0, GetLinearFrequency_InRangeMin_PropertyAddress.Address, InRangeMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLinearFrequency_InRangeMax_Offset), 0, GetLinearFrequency_InRangeMax_PropertyAddress.Address, InRangeMax);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearFrequency_FunctionAddress, intPtr, GetLinearFrequency_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearFrequency_ReturnValue_Offset), 0, GetLinearFrequency_ReturnValue_PropertyAddress.Address);
	}

	static USynthesisUtilitiesBlueprintFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USynthesisUtilitiesBlueprintFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USynthesisUtilitiesBlueprintFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary");
		GetLogFrequency_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLogFrequency");
		GetLogFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLogFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLogFrequency_InLinearValue_PropertyAddress, GetLogFrequency_FunctionAddress, "InLinearValue");
		GetLogFrequency_InLinearValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLogFrequency_FunctionAddress, "InLinearValue");
		GetLogFrequency_InLinearValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLogFrequency_FunctionAddress, "InLinearValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLogFrequency_InDomainMin_PropertyAddress, GetLogFrequency_FunctionAddress, "InDomainMin");
		GetLogFrequency_InDomainMin_Offset = NativeReflectionCached.GetPropertyOffset(GetLogFrequency_FunctionAddress, "InDomainMin");
		GetLogFrequency_InDomainMin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLogFrequency_FunctionAddress, "InDomainMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLogFrequency_InDomainMax_PropertyAddress, GetLogFrequency_FunctionAddress, "InDomainMax");
		GetLogFrequency_InDomainMax_Offset = NativeReflectionCached.GetPropertyOffset(GetLogFrequency_FunctionAddress, "InDomainMax");
		GetLogFrequency_InDomainMax_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLogFrequency_FunctionAddress, "InDomainMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLogFrequency_InRangeMin_PropertyAddress, GetLogFrequency_FunctionAddress, "InRangeMin");
		GetLogFrequency_InRangeMin_Offset = NativeReflectionCached.GetPropertyOffset(GetLogFrequency_FunctionAddress, "InRangeMin");
		GetLogFrequency_InRangeMin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLogFrequency_FunctionAddress, "InRangeMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLogFrequency_InRangeMax_PropertyAddress, GetLogFrequency_FunctionAddress, "InRangeMax");
		GetLogFrequency_InRangeMax_Offset = NativeReflectionCached.GetPropertyOffset(GetLogFrequency_FunctionAddress, "InRangeMax");
		GetLogFrequency_InRangeMax_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLogFrequency_FunctionAddress, "InRangeMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLogFrequency_ReturnValue_PropertyAddress, GetLogFrequency_FunctionAddress, "ReturnValue");
		GetLogFrequency_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLogFrequency_FunctionAddress, "ReturnValue");
		GetLogFrequency_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLogFrequency_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetLogFrequency_IsValid = GetLogFrequency_FunctionAddress != IntPtr.Zero && GetLogFrequency_InLinearValue_IsValid && GetLogFrequency_InDomainMin_IsValid && GetLogFrequency_InDomainMax_IsValid && GetLogFrequency_InRangeMin_IsValid && GetLogFrequency_InRangeMax_IsValid && GetLogFrequency_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary:GetLogFrequency", GetLogFrequency_IsValid);
		GetLinearFrequency_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearFrequency");
		GetLinearFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearFrequency_InLogFrequencyValue_PropertyAddress, GetLinearFrequency_FunctionAddress, "InLogFrequencyValue");
		GetLinearFrequency_InLogFrequencyValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearFrequency_FunctionAddress, "InLogFrequencyValue");
		GetLinearFrequency_InLogFrequencyValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearFrequency_FunctionAddress, "InLogFrequencyValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearFrequency_InDomainMin_PropertyAddress, GetLinearFrequency_FunctionAddress, "InDomainMin");
		GetLinearFrequency_InDomainMin_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearFrequency_FunctionAddress, "InDomainMin");
		GetLinearFrequency_InDomainMin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearFrequency_FunctionAddress, "InDomainMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearFrequency_InDomainMax_PropertyAddress, GetLinearFrequency_FunctionAddress, "InDomainMax");
		GetLinearFrequency_InDomainMax_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearFrequency_FunctionAddress, "InDomainMax");
		GetLinearFrequency_InDomainMax_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearFrequency_FunctionAddress, "InDomainMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearFrequency_InRangeMin_PropertyAddress, GetLinearFrequency_FunctionAddress, "InRangeMin");
		GetLinearFrequency_InRangeMin_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearFrequency_FunctionAddress, "InRangeMin");
		GetLinearFrequency_InRangeMin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearFrequency_FunctionAddress, "InRangeMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearFrequency_InRangeMax_PropertyAddress, GetLinearFrequency_FunctionAddress, "InRangeMax");
		GetLinearFrequency_InRangeMax_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearFrequency_FunctionAddress, "InRangeMax");
		GetLinearFrequency_InRangeMax_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearFrequency_FunctionAddress, "InRangeMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearFrequency_ReturnValue_PropertyAddress, GetLinearFrequency_FunctionAddress, "ReturnValue");
		GetLinearFrequency_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearFrequency_FunctionAddress, "ReturnValue");
		GetLinearFrequency_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearFrequency_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetLinearFrequency_IsValid = GetLinearFrequency_FunctionAddress != IntPtr.Zero && GetLinearFrequency_InLogFrequencyValue_IsValid && GetLinearFrequency_InDomainMin_IsValid && GetLinearFrequency_InDomainMax_IsValid && GetLinearFrequency_InRangeMin_IsValid && GetLinearFrequency_InRangeMax_IsValid && GetLinearFrequency_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary:GetLinearFrequency", GetLinearFrequency_IsValid);
	}
}
