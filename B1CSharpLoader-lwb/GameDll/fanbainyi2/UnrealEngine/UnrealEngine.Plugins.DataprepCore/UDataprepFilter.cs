using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/DataprepCore.DataprepFilter", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepFilter : UDataprepParameterizableObject
{
	private static bool GetFetcher_IsValid;

	private static IntPtr GetFetcher_FunctionAddress;

	private static int GetFetcher_ParamsSize;

	private static bool GetFetcher_ReturnValue_IsValid;

	private static FFieldAddress GetFetcher_ReturnValue_PropertyAddress;

	private static int GetFetcher_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DataprepCore.DataprepFilter:GetFetcher")]
	public unsafe UDataprepFetcher GetFetcher()
	{
		CheckDestroyed();
		if (!GetFetcher_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilter:GetFetcher");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFetcher_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFetcher_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFetcher_FunctionAddress, intPtr, GetFetcher_ParamsSize);
		return UObjectMarshaler<UDataprepFetcher>.FromNative(IntPtr.Add(intPtr, GetFetcher_ReturnValue_Offset), 0, GetFetcher_ReturnValue_PropertyAddress.Address);
	}

	static UDataprepFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepFilter");
		GetFetcher_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFetcher");
		GetFetcher_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFetcher_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFetcher_ReturnValue_PropertyAddress, GetFetcher_FunctionAddress, "ReturnValue");
		GetFetcher_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFetcher_FunctionAddress, "ReturnValue");
		GetFetcher_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFetcher_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFetcher_IsValid = GetFetcher_FunctionAddress != IntPtr.Zero && GetFetcher_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFilter:GetFetcher", GetFetcher_IsValid);
	}
}
