using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConsoleVariablesEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesAsset", "ConsoleVariablesEditor", UnrealModuleType.EnginePlugin)]
public class UConsoleVariablesAsset : UObject
{
	private static bool SetVariableCollectionDescription_IsValid;

	private static IntPtr SetVariableCollectionDescription_FunctionAddress;

	private static int SetVariableCollectionDescription_ParamsSize;

	private static bool SetVariableCollectionDescription_InVariableCollectionDescription_IsValid;

	private static FFieldAddress SetVariableCollectionDescription_InVariableCollectionDescription_PropertyAddress;

	private static int SetVariableCollectionDescription_InVariableCollectionDescription_Offset;

	private static bool GetVariableCollectionDescription_IsValid;

	private static IntPtr GetVariableCollectionDescription_FunctionAddress;

	private static int GetVariableCollectionDescription_ParamsSize;

	private static bool GetVariableCollectionDescription_ReturnValue_IsValid;

	private static FFieldAddress GetVariableCollectionDescription_ReturnValue_PropertyAddress;

	private static int GetVariableCollectionDescription_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesAsset:SetVariableCollectionDescription")]
	public unsafe void SetVariableCollectionDescription(string InVariableCollectionDescription)
	{
		CheckDestroyed();
		if (!SetVariableCollectionDescription_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesAsset:SetVariableCollectionDescription");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableCollectionDescription_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableCollectionDescription_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVariableCollectionDescription_InVariableCollectionDescription_Offset), 0, SetVariableCollectionDescription_InVariableCollectionDescription_PropertyAddress.Address, InVariableCollectionDescription);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableCollectionDescription_FunctionAddress, intPtr, SetVariableCollectionDescription_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVariableCollectionDescription_InVariableCollectionDescription_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesAsset:GetVariableCollectionDescription")]
	public unsafe string GetVariableCollectionDescription()
	{
		CheckDestroyed();
		if (!GetVariableCollectionDescription_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesAsset:GetVariableCollectionDescription");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariableCollectionDescription_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariableCollectionDescription_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariableCollectionDescription_FunctionAddress, intPtr, GetVariableCollectionDescription_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetVariableCollectionDescription_ReturnValue_Offset), 0, GetVariableCollectionDescription_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetVariableCollectionDescription_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UConsoleVariablesAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UConsoleVariablesAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UConsoleVariablesAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ConsoleVariablesEditor.ConsoleVariablesAsset");
		SetVariableCollectionDescription_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVariableCollectionDescription");
		SetVariableCollectionDescription_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableCollectionDescription_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableCollectionDescription_InVariableCollectionDescription_PropertyAddress, SetVariableCollectionDescription_FunctionAddress, "InVariableCollectionDescription");
		SetVariableCollectionDescription_InVariableCollectionDescription_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableCollectionDescription_FunctionAddress, "InVariableCollectionDescription");
		SetVariableCollectionDescription_InVariableCollectionDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableCollectionDescription_FunctionAddress, "InVariableCollectionDescription", Classes.FStrProperty);
		SetVariableCollectionDescription_IsValid = SetVariableCollectionDescription_FunctionAddress != IntPtr.Zero && SetVariableCollectionDescription_InVariableCollectionDescription_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesAsset:SetVariableCollectionDescription", SetVariableCollectionDescription_IsValid);
		GetVariableCollectionDescription_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVariableCollectionDescription");
		GetVariableCollectionDescription_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariableCollectionDescription_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariableCollectionDescription_ReturnValue_PropertyAddress, GetVariableCollectionDescription_FunctionAddress, "ReturnValue");
		GetVariableCollectionDescription_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableCollectionDescription_FunctionAddress, "ReturnValue");
		GetVariableCollectionDescription_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableCollectionDescription_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetVariableCollectionDescription_IsValid = GetVariableCollectionDescription_FunctionAddress != IntPtr.Zero && GetVariableCollectionDescription_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesAsset:GetVariableCollectionDescription", GetVariableCollectionDescription_IsValid);
	}
}
