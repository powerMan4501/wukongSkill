using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AssetTools;

[UClass(Flags = (ClassFlags)809500840uL, Config = "Engine")]
[UMetaPath("/Script/AssetTools.AssetToolsHelpers", "AssetTools", UnrealModuleType.Engine)]
public class UAssetToolsHelpers : UObject
{
	private static IntPtr classAddress;

	private static bool GetAssetTools_IsValid;

	private static IntPtr GetAssetTools_FunctionAddress;

	private static int GetAssetTools_ParamsSize;

	private static bool GetAssetTools_ReturnValue_IsValid;

	private static FFieldAddress GetAssetTools_ReturnValue_PropertyAddress;

	private static int GetAssetTools_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AssetTools.AssetToolsHelpers:GetAssetTools")]
	public unsafe static IAssetTools GetAssetTools()
	{
		if (!GetAssetTools_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetToolsHelpers:GetAssetTools");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetTools_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetTools_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetTools_FunctionAddress, intPtr, GetAssetTools_ParamsSize);
		return InterfaceMarshaler<IAssetTools>.FromNative(IntPtr.Add(intPtr, GetAssetTools_ReturnValue_Offset), 0, GetAssetTools_ReturnValue_PropertyAddress.Address);
	}

	static UAssetToolsHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAssetToolsHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAssetToolsHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AssetTools.AssetToolsHelpers");
		GetAssetTools_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetTools");
		GetAssetTools_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetTools_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetTools_ReturnValue_PropertyAddress, GetAssetTools_FunctionAddress, "ReturnValue");
		GetAssetTools_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetTools_FunctionAddress, "ReturnValue");
		GetAssetTools_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetTools_FunctionAddress, "ReturnValue", Classes.FInterfaceProperty);
		GetAssetTools_IsValid = GetAssetTools_FunctionAddress != IntPtr.Zero && GetAssetTools_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetToolsHelpers:GetAssetTools", GetAssetTools_IsValid);
	}
}
