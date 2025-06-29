using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DLSSBlueprint;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary", "DLSSBlueprint", UnrealModuleType.EnginePlugin)]
public class UDLSSLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool QueryDLSSSupport_IsValid;

	private static IntPtr QueryDLSSSupport_FunctionAddress;

	private static int QueryDLSSSupport_ParamsSize;

	private static bool QueryDLSSSupport_ReturnValue_IsValid;

	private static FFieldAddress QueryDLSSSupport_ReturnValue_PropertyAddress;

	private static int QueryDLSSSupport_ReturnValue_Offset;

	private static bool QueryDLSSRRSupport_IsValid;

	private static IntPtr QueryDLSSRRSupport_FunctionAddress;

	private static int QueryDLSSRRSupport_ParamsSize;

	private static bool QueryDLSSRRSupport_ReturnValue_IsValid;

	private static FFieldAddress QueryDLSSRRSupport_ReturnValue_PropertyAddress;

	private static int QueryDLSSRRSupport_ReturnValue_Offset;

	private static bool IsDLSSSupported_IsValid;

	private static IntPtr IsDLSSSupported_FunctionAddress;

	private static int IsDLSSSupported_ParamsSize;

	private static bool IsDLSSSupported_ReturnValue_IsValid;

	private static FFieldAddress IsDLSSSupported_ReturnValue_PropertyAddress;

	private static int IsDLSSSupported_ReturnValue_Offset;

	private static bool IsDLSSRRSupported_IsValid;

	private static IntPtr IsDLSSRRSupported_FunctionAddress;

	private static int IsDLSSRRSupported_ParamsSize;

	private static bool IsDLSSRRSupported_ReturnValue_IsValid;

	private static FFieldAddress IsDLSSRRSupported_ReturnValue_PropertyAddress;

	private static int IsDLSSRRSupported_ReturnValue_Offset;

	private static bool IsDLSSRREnabled_IsValid;

	private static IntPtr IsDLSSRREnabled_FunctionAddress;

	private static int IsDLSSRREnabled_ParamsSize;

	private static bool IsDLSSRREnabled_ReturnValue_IsValid;

	private static FFieldAddress IsDLSSRREnabled_ReturnValue_PropertyAddress;

	private static int IsDLSSRREnabled_ReturnValue_Offset;

	private static bool IsDLSSModeSupported_IsValid;

	private static IntPtr IsDLSSModeSupported_FunctionAddress;

	private static int IsDLSSModeSupported_ParamsSize;

	private static bool IsDLSSModeSupported_DLSSMode_IsValid;

	private static FFieldAddress IsDLSSModeSupported_DLSSMode_PropertyAddress;

	private static int IsDLSSModeSupported_DLSSMode_Offset;

	private static bool IsDLSSModeSupported_ReturnValue_IsValid;

	private static FFieldAddress IsDLSSModeSupported_ReturnValue_PropertyAddress;

	private static int IsDLSSModeSupported_ReturnValue_Offset;

	private static bool IsDLSSEnabled_IsValid;

	private static IntPtr IsDLSSEnabled_FunctionAddress;

	private static int IsDLSSEnabled_ParamsSize;

	private static bool IsDLSSEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsDLSSEnabled_ReturnValue_PropertyAddress;

	private static int IsDLSSEnabled_ReturnValue_Offset;

	private static bool GetSupportedDLSSModes_IsValid;

	private static IntPtr GetSupportedDLSSModes_FunctionAddress;

	private static int GetSupportedDLSSModes_ParamsSize;

	private static bool GetSupportedDLSSModes_ReturnValue_IsValid;

	private static FFieldAddress GetSupportedDLSSModes_ReturnValue_PropertyAddress;

	private static int GetSupportedDLSSModes_ReturnValue_Offset;

	private static bool GetDLSSScreenPercentageRange_IsValid;

	private static IntPtr GetDLSSScreenPercentageRange_FunctionAddress;

	private static int GetDLSSScreenPercentageRange_ParamsSize;

	private static bool GetDLSSScreenPercentageRange_MinScreenPercentage_IsValid;

	private static FFieldAddress GetDLSSScreenPercentageRange_MinScreenPercentage_PropertyAddress;

	private static int GetDLSSScreenPercentageRange_MinScreenPercentage_Offset;

	private static bool GetDLSSScreenPercentageRange_MaxScreenPercentage_IsValid;

	private static FFieldAddress GetDLSSScreenPercentageRange_MaxScreenPercentage_PropertyAddress;

	private static int GetDLSSScreenPercentageRange_MaxScreenPercentage_Offset;

	private static bool GetDLSSRRMinimumDriverVersion_IsValid;

	private static IntPtr GetDLSSRRMinimumDriverVersion_FunctionAddress;

	private static int GetDLSSRRMinimumDriverVersion_ParamsSize;

	private static bool GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_IsValid;

	private static FFieldAddress GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_PropertyAddress;

	private static int GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_Offset;

	private static bool GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_IsValid;

	private static FFieldAddress GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_PropertyAddress;

	private static int GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_Offset;

	private static bool GetDLSSModeInformation_IsValid;

	private static IntPtr GetDLSSModeInformation_FunctionAddress;

	private static int GetDLSSModeInformation_ParamsSize;

	private static bool GetDLSSModeInformation_DLSSMode_IsValid;

	private static FFieldAddress GetDLSSModeInformation_DLSSMode_PropertyAddress;

	private static int GetDLSSModeInformation_DLSSMode_Offset;

	private static bool GetDLSSModeInformation_ScreenResolution_IsValid;

	private static FFieldAddress GetDLSSModeInformation_ScreenResolution_PropertyAddress;

	private static int GetDLSSModeInformation_ScreenResolution_Offset;

	private static bool GetDLSSModeInformation_bIsSupported_IsValid;

	private static FFieldAddress GetDLSSModeInformation_bIsSupported_PropertyAddress;

	private static int GetDLSSModeInformation_bIsSupported_Offset;

	private static bool GetDLSSModeInformation_OptimalScreenPercentage_IsValid;

	private static FFieldAddress GetDLSSModeInformation_OptimalScreenPercentage_PropertyAddress;

	private static int GetDLSSModeInformation_OptimalScreenPercentage_Offset;

	private static bool GetDLSSModeInformation_bIsFixedScreenPercentage_IsValid;

	private static FFieldAddress GetDLSSModeInformation_bIsFixedScreenPercentage_PropertyAddress;

	private static int GetDLSSModeInformation_bIsFixedScreenPercentage_Offset;

	private static bool GetDLSSModeInformation_MinScreenPercentage_IsValid;

	private static FFieldAddress GetDLSSModeInformation_MinScreenPercentage_PropertyAddress;

	private static int GetDLSSModeInformation_MinScreenPercentage_Offset;

	private static bool GetDLSSModeInformation_MaxScreenPercentage_IsValid;

	private static FFieldAddress GetDLSSModeInformation_MaxScreenPercentage_PropertyAddress;

	private static int GetDLSSModeInformation_MaxScreenPercentage_Offset;

	private static bool GetDLSSModeInformation_OptimalSharpness_IsValid;

	private static FFieldAddress GetDLSSModeInformation_OptimalSharpness_PropertyAddress;

	private static int GetDLSSModeInformation_OptimalSharpness_Offset;

	private static bool GetDLSSMinimumDriverVersion_IsValid;

	private static IntPtr GetDLSSMinimumDriverVersion_FunctionAddress;

	private static int GetDLSSMinimumDriverVersion_ParamsSize;

	private static bool GetDLSSMinimumDriverVersion_MinDriverVersionMajor_IsValid;

	private static FFieldAddress GetDLSSMinimumDriverVersion_MinDriverVersionMajor_PropertyAddress;

	private static int GetDLSSMinimumDriverVersion_MinDriverVersionMajor_Offset;

	private static bool GetDLSSMinimumDriverVersion_MinDriverVersionMinor_IsValid;

	private static FFieldAddress GetDLSSMinimumDriverVersion_MinDriverVersionMinor_PropertyAddress;

	private static int GetDLSSMinimumDriverVersion_MinDriverVersionMinor_Offset;

	private static bool GetDefaultDLSSMode_IsValid;

	private static IntPtr GetDefaultDLSSMode_FunctionAddress;

	private static int GetDefaultDLSSMode_ParamsSize;

	private static bool GetDefaultDLSSMode_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultDLSSMode_ReturnValue_PropertyAddress;

	private static int GetDefaultDLSSMode_ReturnValue_Offset;

	private static bool EnableDLSSRR_IsValid;

	private static IntPtr EnableDLSSRR_FunctionAddress;

	private static int EnableDLSSRR_ParamsSize;

	private static bool EnableDLSSRR_bEnabled_IsValid;

	private static FFieldAddress EnableDLSSRR_bEnabled_PropertyAddress;

	private static int EnableDLSSRR_bEnabled_Offset;

	private static bool EnableDLSS_IsValid;

	private static IntPtr EnableDLSS_FunctionAddress;

	private static int EnableDLSS_ParamsSize;

	private static bool EnableDLSS_bEnabled_IsValid;

	private static FFieldAddress EnableDLSS_bEnabled_PropertyAddress;

	private static int EnableDLSS_bEnabled_Offset;

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:QueryDLSSSupport")]
	public unsafe static EUDLSSSupport QueryDLSSSupport()
	{
		if (!QueryDLSSSupport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:QueryDLSSSupport");
			return EUDLSSSupport.Supported;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryDLSSSupport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryDLSSSupport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryDLSSSupport_FunctionAddress, intPtr, QueryDLSSSupport_ParamsSize);
		return EnumMarshaler<EUDLSSSupport>.FromNative(IntPtr.Add(intPtr, QueryDLSSSupport_ReturnValue_Offset), 0, QueryDLSSSupport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:QueryDLSSRRSupport")]
	public unsafe static EUDLSSSupport QueryDLSSRRSupport()
	{
		if (!QueryDLSSRRSupport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:QueryDLSSRRSupport");
			return EUDLSSSupport.Supported;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryDLSSRRSupport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryDLSSRRSupport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryDLSSRRSupport_FunctionAddress, intPtr, QueryDLSSRRSupport_ParamsSize);
		return EnumMarshaler<EUDLSSSupport>.FromNative(IntPtr.Add(intPtr, QueryDLSSRRSupport_ReturnValue_Offset), 0, QueryDLSSRRSupport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSSupported")]
	public unsafe static bool IsDLSSSupported()
	{
		if (!IsDLSSSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDLSSSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDLSSSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDLSSSupported_FunctionAddress, intPtr, IsDLSSSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDLSSSupported_ReturnValue_Offset), 0, IsDLSSSupported_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSRRSupported")]
	public unsafe static bool IsDLSSRRSupported()
	{
		if (!IsDLSSRRSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSRRSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDLSSRRSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDLSSRRSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDLSSRRSupported_FunctionAddress, intPtr, IsDLSSRRSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDLSSRRSupported_ReturnValue_Offset), 0, IsDLSSRRSupported_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSRREnabled")]
	public unsafe static bool IsDLSSRREnabled()
	{
		if (!IsDLSSRREnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSRREnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDLSSRREnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDLSSRREnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDLSSRREnabled_FunctionAddress, intPtr, IsDLSSRREnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDLSSRREnabled_ReturnValue_Offset), 0, IsDLSSRREnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSModeSupported")]
	public unsafe static bool IsDLSSModeSupported(EUDLSSMode DLSSMode)
	{
		if (!IsDLSSModeSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSModeSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDLSSModeSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDLSSModeSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUDLSSMode>.ToNative(IntPtr.Add(intPtr, IsDLSSModeSupported_DLSSMode_Offset), 0, IsDLSSModeSupported_DLSSMode_PropertyAddress.Address, DLSSMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDLSSModeSupported_FunctionAddress, intPtr, IsDLSSModeSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDLSSModeSupported_ReturnValue_Offset), 0, IsDLSSModeSupported_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSEnabled")]
	public unsafe static bool IsDLSSEnabled()
	{
		if (!IsDLSSEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDLSSEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDLSSEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDLSSEnabled_FunctionAddress, intPtr, IsDLSSEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDLSSEnabled_ReturnValue_Offset), 0, IsDLSSEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:GetSupportedDLSSModes")]
	public unsafe static List<EUDLSSMode> GetSupportedDLSSModes()
	{
		if (!GetSupportedDLSSModes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:GetSupportedDLSSModes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSupportedDLSSModes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSupportedDLSSModes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSupportedDLSSModes_FunctionAddress, intPtr, GetSupportedDLSSModes_ParamsSize);
		List<EUDLSSMode> result = new TArrayCopyMarshaler<EUDLSSMode>(1, GetSupportedDLSSModes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<EUDLSSMode, EnumMarshaler<EUDLSSMode>>.FromNative, CachedMarshalingDelegates<EUDLSSMode, EnumMarshaler<EUDLSSMode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSupportedDLSSModes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSupportedDLSSModes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878915u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSScreenPercentageRange")]
	public unsafe static void GetDLSSScreenPercentageRange(out float MinScreenPercentage, out float MaxScreenPercentage)
	{
		if (!GetDLSSScreenPercentageRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSScreenPercentageRange");
			MinScreenPercentage = 0f;
			MaxScreenPercentage = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDLSSScreenPercentageRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDLSSScreenPercentageRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDLSSScreenPercentageRange_FunctionAddress, intPtr, GetDLSSScreenPercentageRange_ParamsSize);
		MinScreenPercentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDLSSScreenPercentageRange_MinScreenPercentage_Offset), 0, GetDLSSScreenPercentageRange_MinScreenPercentage_PropertyAddress.Address);
		MaxScreenPercentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDLSSScreenPercentageRange_MaxScreenPercentage_Offset), 0, GetDLSSScreenPercentageRange_MaxScreenPercentage_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878915u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSRRMinimumDriverVersion")]
	public unsafe static void GetDLSSRRMinimumDriverVersion(out int MinDriverVersionMajor, out int MinDriverVersionMinor)
	{
		if (!GetDLSSRRMinimumDriverVersion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSRRMinimumDriverVersion");
			MinDriverVersionMajor = 0;
			MinDriverVersionMinor = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDLSSRRMinimumDriverVersion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDLSSRRMinimumDriverVersion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDLSSRRMinimumDriverVersion_FunctionAddress, intPtr, GetDLSSRRMinimumDriverVersion_ParamsSize);
		MinDriverVersionMajor = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_Offset), 0, GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_PropertyAddress.Address);
		MinDriverVersionMinor = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_Offset), 0, GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267523u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSModeInformation")]
	public unsafe static void GetDLSSModeInformation(EUDLSSMode DLSSMode, FVector2D ScreenResolution, out bool bIsSupported, out float OptimalScreenPercentage, out bool bIsFixedScreenPercentage, out float MinScreenPercentage, out float MaxScreenPercentage, out float OptimalSharpness)
	{
		if (!GetDLSSModeInformation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSModeInformation");
			bIsSupported = false;
			OptimalScreenPercentage = 0f;
			bIsFixedScreenPercentage = false;
			MinScreenPercentage = 0f;
			MaxScreenPercentage = 0f;
			OptimalSharpness = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDLSSModeInformation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDLSSModeInformation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUDLSSMode>.ToNative(IntPtr.Add(intPtr, GetDLSSModeInformation_DLSSMode_Offset), 0, GetDLSSModeInformation_DLSSMode_PropertyAddress.Address, DLSSMode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GetDLSSModeInformation_ScreenResolution_Offset), 0, GetDLSSModeInformation_ScreenResolution_PropertyAddress.Address, ScreenResolution);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDLSSModeInformation_FunctionAddress, intPtr, GetDLSSModeInformation_ParamsSize);
		bIsSupported = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetDLSSModeInformation_bIsSupported_Offset), 0, GetDLSSModeInformation_bIsSupported_PropertyAddress.Address);
		OptimalScreenPercentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDLSSModeInformation_OptimalScreenPercentage_Offset), 0, GetDLSSModeInformation_OptimalScreenPercentage_PropertyAddress.Address);
		bIsFixedScreenPercentage = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetDLSSModeInformation_bIsFixedScreenPercentage_Offset), 0, GetDLSSModeInformation_bIsFixedScreenPercentage_PropertyAddress.Address);
		MinScreenPercentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDLSSModeInformation_MinScreenPercentage_Offset), 0, GetDLSSModeInformation_MinScreenPercentage_PropertyAddress.Address);
		MaxScreenPercentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDLSSModeInformation_MaxScreenPercentage_Offset), 0, GetDLSSModeInformation_MaxScreenPercentage_PropertyAddress.Address);
		OptimalSharpness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDLSSModeInformation_OptimalSharpness_Offset), 0, GetDLSSModeInformation_OptimalSharpness_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878915u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSMinimumDriverVersion")]
	public unsafe static void GetDLSSMinimumDriverVersion(out int MinDriverVersionMajor, out int MinDriverVersionMinor)
	{
		if (!GetDLSSMinimumDriverVersion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSMinimumDriverVersion");
			MinDriverVersionMajor = 0;
			MinDriverVersionMinor = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDLSSMinimumDriverVersion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDLSSMinimumDriverVersion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDLSSMinimumDriverVersion_FunctionAddress, intPtr, GetDLSSMinimumDriverVersion_ParamsSize);
		MinDriverVersionMajor = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDLSSMinimumDriverVersion_MinDriverVersionMajor_Offset), 0, GetDLSSMinimumDriverVersion_MinDriverVersionMajor_PropertyAddress.Address);
		MinDriverVersionMinor = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDLSSMinimumDriverVersion_MinDriverVersionMinor_Offset), 0, GetDLSSMinimumDriverVersion_MinDriverVersionMinor_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:GetDefaultDLSSMode")]
	public unsafe static EUDLSSMode GetDefaultDLSSMode()
	{
		if (!GetDefaultDLSSMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:GetDefaultDLSSMode");
			return EUDLSSMode.Off;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultDLSSMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultDLSSMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultDLSSMode_FunctionAddress, intPtr, GetDefaultDLSSMode_ParamsSize);
		return EnumMarshaler<EUDLSSMode>.FromNative(IntPtr.Add(intPtr, GetDefaultDLSSMode_ReturnValue_Offset), 0, GetDefaultDLSSMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:EnableDLSSRR")]
	public unsafe static void EnableDLSSRR(bool bEnabled)
	{
		if (!EnableDLSSRR_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:EnableDLSSRR");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableDLSSRR_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableDLSSRR_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableDLSSRR_bEnabled_Offset), 0, EnableDLSSRR_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableDLSSRR_FunctionAddress, intPtr, EnableDLSSRR_ParamsSize);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/DLSSBlueprint.DLSSLibrary:EnableDLSS")]
	public unsafe static void EnableDLSS(bool bEnabled)
	{
		if (!EnableDLSS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DLSSBlueprint.DLSSLibrary:EnableDLSS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableDLSS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableDLSS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableDLSS_bEnabled_Offset), 0, EnableDLSS_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableDLSS_FunctionAddress, intPtr, EnableDLSS_ParamsSize);
	}

	static UDLSSLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDLSSLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDLSSLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/DLSSBlueprint.DLSSLibrary");
		QueryDLSSSupport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryDLSSSupport");
		QueryDLSSSupport_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryDLSSSupport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryDLSSSupport_ReturnValue_PropertyAddress, QueryDLSSSupport_FunctionAddress, "ReturnValue");
		QueryDLSSSupport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryDLSSSupport_FunctionAddress, "ReturnValue");
		QueryDLSSSupport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryDLSSSupport_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		QueryDLSSSupport_IsValid = QueryDLSSSupport_FunctionAddress != IntPtr.Zero && QueryDLSSSupport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:QueryDLSSSupport", QueryDLSSSupport_IsValid);
		QueryDLSSRRSupport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryDLSSRRSupport");
		QueryDLSSRRSupport_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryDLSSRRSupport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryDLSSRRSupport_ReturnValue_PropertyAddress, QueryDLSSRRSupport_FunctionAddress, "ReturnValue");
		QueryDLSSRRSupport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryDLSSRRSupport_FunctionAddress, "ReturnValue");
		QueryDLSSRRSupport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryDLSSRRSupport_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		QueryDLSSRRSupport_IsValid = QueryDLSSRRSupport_FunctionAddress != IntPtr.Zero && QueryDLSSRRSupport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:QueryDLSSRRSupport", QueryDLSSRRSupport_IsValid);
		IsDLSSSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDLSSSupported");
		IsDLSSSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDLSSSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSSupported_ReturnValue_PropertyAddress, IsDLSSSupported_FunctionAddress, "ReturnValue");
		IsDLSSSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSSupported_FunctionAddress, "ReturnValue");
		IsDLSSSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDLSSSupported_IsValid = IsDLSSSupported_FunctionAddress != IntPtr.Zero && IsDLSSSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSSupported", IsDLSSSupported_IsValid);
		IsDLSSRRSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDLSSRRSupported");
		IsDLSSRRSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDLSSRRSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSRRSupported_ReturnValue_PropertyAddress, IsDLSSRRSupported_FunctionAddress, "ReturnValue");
		IsDLSSRRSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSRRSupported_FunctionAddress, "ReturnValue");
		IsDLSSRRSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSRRSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDLSSRRSupported_IsValid = IsDLSSRRSupported_FunctionAddress != IntPtr.Zero && IsDLSSRRSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSRRSupported", IsDLSSRRSupported_IsValid);
		IsDLSSRREnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDLSSRREnabled");
		IsDLSSRREnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDLSSRREnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSRREnabled_ReturnValue_PropertyAddress, IsDLSSRREnabled_FunctionAddress, "ReturnValue");
		IsDLSSRREnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSRREnabled_FunctionAddress, "ReturnValue");
		IsDLSSRREnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSRREnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDLSSRREnabled_IsValid = IsDLSSRREnabled_FunctionAddress != IntPtr.Zero && IsDLSSRREnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSRREnabled", IsDLSSRREnabled_IsValid);
		IsDLSSModeSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDLSSModeSupported");
		IsDLSSModeSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDLSSModeSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSModeSupported_DLSSMode_PropertyAddress, IsDLSSModeSupported_FunctionAddress, "DLSSMode");
		IsDLSSModeSupported_DLSSMode_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSModeSupported_FunctionAddress, "DLSSMode");
		IsDLSSModeSupported_DLSSMode_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSModeSupported_FunctionAddress, "DLSSMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSModeSupported_ReturnValue_PropertyAddress, IsDLSSModeSupported_FunctionAddress, "ReturnValue");
		IsDLSSModeSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSModeSupported_FunctionAddress, "ReturnValue");
		IsDLSSModeSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSModeSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDLSSModeSupported_IsValid = IsDLSSModeSupported_FunctionAddress != IntPtr.Zero && IsDLSSModeSupported_DLSSMode_IsValid && IsDLSSModeSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSModeSupported", IsDLSSModeSupported_IsValid);
		IsDLSSEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDLSSEnabled");
		IsDLSSEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDLSSEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSEnabled_ReturnValue_PropertyAddress, IsDLSSEnabled_FunctionAddress, "ReturnValue");
		IsDLSSEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSEnabled_FunctionAddress, "ReturnValue");
		IsDLSSEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDLSSEnabled_IsValid = IsDLSSEnabled_FunctionAddress != IntPtr.Zero && IsDLSSEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:IsDLSSEnabled", IsDLSSEnabled_IsValid);
		GetSupportedDLSSModes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSupportedDLSSModes");
		GetSupportedDLSSModes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportedDLSSModes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSupportedDLSSModes_ReturnValue_PropertyAddress, GetSupportedDLSSModes_FunctionAddress, "ReturnValue");
		GetSupportedDLSSModes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportedDLSSModes_FunctionAddress, "ReturnValue");
		GetSupportedDLSSModes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportedDLSSModes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSupportedDLSSModes_IsValid = GetSupportedDLSSModes_FunctionAddress != IntPtr.Zero && GetSupportedDLSSModes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:GetSupportedDLSSModes", GetSupportedDLSSModes_IsValid);
		GetDLSSScreenPercentageRange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDLSSScreenPercentageRange");
		GetDLSSScreenPercentageRange_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDLSSScreenPercentageRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSScreenPercentageRange_MinScreenPercentage_PropertyAddress, GetDLSSScreenPercentageRange_FunctionAddress, "MinScreenPercentage");
		GetDLSSScreenPercentageRange_MinScreenPercentage_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSScreenPercentageRange_FunctionAddress, "MinScreenPercentage");
		GetDLSSScreenPercentageRange_MinScreenPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSScreenPercentageRange_FunctionAddress, "MinScreenPercentage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSScreenPercentageRange_MaxScreenPercentage_PropertyAddress, GetDLSSScreenPercentageRange_FunctionAddress, "MaxScreenPercentage");
		GetDLSSScreenPercentageRange_MaxScreenPercentage_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSScreenPercentageRange_FunctionAddress, "MaxScreenPercentage");
		GetDLSSScreenPercentageRange_MaxScreenPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSScreenPercentageRange_FunctionAddress, "MaxScreenPercentage", Classes.FFloatProperty);
		GetDLSSScreenPercentageRange_IsValid = GetDLSSScreenPercentageRange_FunctionAddress != IntPtr.Zero && GetDLSSScreenPercentageRange_MinScreenPercentage_IsValid && GetDLSSScreenPercentageRange_MaxScreenPercentage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSScreenPercentageRange", GetDLSSScreenPercentageRange_IsValid);
		GetDLSSRRMinimumDriverVersion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDLSSRRMinimumDriverVersion");
		GetDLSSRRMinimumDriverVersion_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDLSSRRMinimumDriverVersion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_PropertyAddress, GetDLSSRRMinimumDriverVersion_FunctionAddress, "MinDriverVersionMajor");
		GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSRRMinimumDriverVersion_FunctionAddress, "MinDriverVersionMajor");
		GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSRRMinimumDriverVersion_FunctionAddress, "MinDriverVersionMajor", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_PropertyAddress, GetDLSSRRMinimumDriverVersion_FunctionAddress, "MinDriverVersionMinor");
		GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSRRMinimumDriverVersion_FunctionAddress, "MinDriverVersionMinor");
		GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSRRMinimumDriverVersion_FunctionAddress, "MinDriverVersionMinor", Classes.FIntProperty);
		GetDLSSRRMinimumDriverVersion_IsValid = GetDLSSRRMinimumDriverVersion_FunctionAddress != IntPtr.Zero && GetDLSSRRMinimumDriverVersion_MinDriverVersionMajor_IsValid && GetDLSSRRMinimumDriverVersion_MinDriverVersionMinor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSRRMinimumDriverVersion", GetDLSSRRMinimumDriverVersion_IsValid);
		GetDLSSModeInformation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDLSSModeInformation");
		GetDLSSModeInformation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDLSSModeInformation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSModeInformation_DLSSMode_PropertyAddress, GetDLSSModeInformation_FunctionAddress, "DLSSMode");
		GetDLSSModeInformation_DLSSMode_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSModeInformation_FunctionAddress, "DLSSMode");
		GetDLSSModeInformation_DLSSMode_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSModeInformation_FunctionAddress, "DLSSMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSModeInformation_ScreenResolution_PropertyAddress, GetDLSSModeInformation_FunctionAddress, "ScreenResolution");
		GetDLSSModeInformation_ScreenResolution_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSModeInformation_FunctionAddress, "ScreenResolution");
		GetDLSSModeInformation_ScreenResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSModeInformation_FunctionAddress, "ScreenResolution", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSModeInformation_bIsSupported_PropertyAddress, GetDLSSModeInformation_FunctionAddress, "bIsSupported");
		GetDLSSModeInformation_bIsSupported_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSModeInformation_FunctionAddress, "bIsSupported");
		GetDLSSModeInformation_bIsSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSModeInformation_FunctionAddress, "bIsSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSModeInformation_OptimalScreenPercentage_PropertyAddress, GetDLSSModeInformation_FunctionAddress, "OptimalScreenPercentage");
		GetDLSSModeInformation_OptimalScreenPercentage_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSModeInformation_FunctionAddress, "OptimalScreenPercentage");
		GetDLSSModeInformation_OptimalScreenPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSModeInformation_FunctionAddress, "OptimalScreenPercentage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSModeInformation_bIsFixedScreenPercentage_PropertyAddress, GetDLSSModeInformation_FunctionAddress, "bIsFixedScreenPercentage");
		GetDLSSModeInformation_bIsFixedScreenPercentage_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSModeInformation_FunctionAddress, "bIsFixedScreenPercentage");
		GetDLSSModeInformation_bIsFixedScreenPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSModeInformation_FunctionAddress, "bIsFixedScreenPercentage", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSModeInformation_MinScreenPercentage_PropertyAddress, GetDLSSModeInformation_FunctionAddress, "MinScreenPercentage");
		GetDLSSModeInformation_MinScreenPercentage_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSModeInformation_FunctionAddress, "MinScreenPercentage");
		GetDLSSModeInformation_MinScreenPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSModeInformation_FunctionAddress, "MinScreenPercentage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSModeInformation_MaxScreenPercentage_PropertyAddress, GetDLSSModeInformation_FunctionAddress, "MaxScreenPercentage");
		GetDLSSModeInformation_MaxScreenPercentage_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSModeInformation_FunctionAddress, "MaxScreenPercentage");
		GetDLSSModeInformation_MaxScreenPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSModeInformation_FunctionAddress, "MaxScreenPercentage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSModeInformation_OptimalSharpness_PropertyAddress, GetDLSSModeInformation_FunctionAddress, "OptimalSharpness");
		GetDLSSModeInformation_OptimalSharpness_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSModeInformation_FunctionAddress, "OptimalSharpness");
		GetDLSSModeInformation_OptimalSharpness_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSModeInformation_FunctionAddress, "OptimalSharpness", Classes.FFloatProperty);
		GetDLSSModeInformation_IsValid = GetDLSSModeInformation_FunctionAddress != IntPtr.Zero && GetDLSSModeInformation_DLSSMode_IsValid && GetDLSSModeInformation_ScreenResolution_IsValid && GetDLSSModeInformation_bIsSupported_IsValid && GetDLSSModeInformation_OptimalScreenPercentage_IsValid && GetDLSSModeInformation_bIsFixedScreenPercentage_IsValid && GetDLSSModeInformation_MinScreenPercentage_IsValid && GetDLSSModeInformation_MaxScreenPercentage_IsValid && GetDLSSModeInformation_OptimalSharpness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSModeInformation", GetDLSSModeInformation_IsValid);
		GetDLSSMinimumDriverVersion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDLSSMinimumDriverVersion");
		GetDLSSMinimumDriverVersion_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDLSSMinimumDriverVersion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSMinimumDriverVersion_MinDriverVersionMajor_PropertyAddress, GetDLSSMinimumDriverVersion_FunctionAddress, "MinDriverVersionMajor");
		GetDLSSMinimumDriverVersion_MinDriverVersionMajor_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSMinimumDriverVersion_FunctionAddress, "MinDriverVersionMajor");
		GetDLSSMinimumDriverVersion_MinDriverVersionMajor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSMinimumDriverVersion_FunctionAddress, "MinDriverVersionMajor", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSMinimumDriverVersion_MinDriverVersionMinor_PropertyAddress, GetDLSSMinimumDriverVersion_FunctionAddress, "MinDriverVersionMinor");
		GetDLSSMinimumDriverVersion_MinDriverVersionMinor_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSMinimumDriverVersion_FunctionAddress, "MinDriverVersionMinor");
		GetDLSSMinimumDriverVersion_MinDriverVersionMinor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSMinimumDriverVersion_FunctionAddress, "MinDriverVersionMinor", Classes.FIntProperty);
		GetDLSSMinimumDriverVersion_IsValid = GetDLSSMinimumDriverVersion_FunctionAddress != IntPtr.Zero && GetDLSSMinimumDriverVersion_MinDriverVersionMajor_IsValid && GetDLSSMinimumDriverVersion_MinDriverVersionMinor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:GetDLSSMinimumDriverVersion", GetDLSSMinimumDriverVersion_IsValid);
		GetDefaultDLSSMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultDLSSMode");
		GetDefaultDLSSMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultDLSSMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultDLSSMode_ReturnValue_PropertyAddress, GetDefaultDLSSMode_FunctionAddress, "ReturnValue");
		GetDefaultDLSSMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultDLSSMode_FunctionAddress, "ReturnValue");
		GetDefaultDLSSMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultDLSSMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDefaultDLSSMode_IsValid = GetDefaultDLSSMode_FunctionAddress != IntPtr.Zero && GetDefaultDLSSMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:GetDefaultDLSSMode", GetDefaultDLSSMode_IsValid);
		EnableDLSSRR_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableDLSSRR");
		EnableDLSSRR_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableDLSSRR_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableDLSSRR_bEnabled_PropertyAddress, EnableDLSSRR_FunctionAddress, "bEnabled");
		EnableDLSSRR_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(EnableDLSSRR_FunctionAddress, "bEnabled");
		EnableDLSSRR_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableDLSSRR_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		EnableDLSSRR_IsValid = EnableDLSSRR_FunctionAddress != IntPtr.Zero && EnableDLSSRR_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:EnableDLSSRR", EnableDLSSRR_IsValid);
		EnableDLSS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableDLSS");
		EnableDLSS_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableDLSS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableDLSS_bEnabled_PropertyAddress, EnableDLSS_FunctionAddress, "bEnabled");
		EnableDLSS_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(EnableDLSS_FunctionAddress, "bEnabled");
		EnableDLSS_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableDLSS_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		EnableDLSS_IsValid = EnableDLSS_FunctionAddress != IntPtr.Zero && EnableDLSS_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DLSSBlueprint.DLSSLibrary:EnableDLSS", EnableDLSS_IsValid);
	}
}
