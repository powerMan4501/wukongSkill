using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[UMetaPath("/Script/DataprepCore.DataprepFetcher", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepFetcher : UDataprepParameterizableObject
{
	private static bool GetTooltipText_IsValid;

	private IntPtr GetTooltipText_InstanceFunctionAddress;

	private static IntPtr GetTooltipText_FunctionAddress;

	private static int GetTooltipText_ParamsSize;

	private static bool GetTooltipText_ReturnValue_IsValid;

	private static FFieldAddress GetTooltipText_ReturnValue_PropertyAddress;

	private static int GetTooltipText_ReturnValue_Offset;

	private static bool GetNodeDisplayFetcherName_IsValid;

	private IntPtr GetNodeDisplayFetcherName_InstanceFunctionAddress;

	private static IntPtr GetNodeDisplayFetcherName_FunctionAddress;

	private static int GetNodeDisplayFetcherName_ParamsSize;

	private static bool GetNodeDisplayFetcherName_ReturnValue_IsValid;

	private static FFieldAddress GetNodeDisplayFetcherName_ReturnValue_PropertyAddress;

	private static int GetNodeDisplayFetcherName_ReturnValue_Offset;

	private static bool GetDisplayFetcherName_IsValid;

	private IntPtr GetDisplayFetcherName_InstanceFunctionAddress;

	private static IntPtr GetDisplayFetcherName_FunctionAddress;

	private static int GetDisplayFetcherName_ParamsSize;

	private static bool GetDisplayFetcherName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayFetcherName_ReturnValue_PropertyAddress;

	private static int GetDisplayFetcherName_ReturnValue_Offset;

	private static bool GetAdditionalKeyword_IsValid;

	private IntPtr GetAdditionalKeyword_InstanceFunctionAddress;

	private static IntPtr GetAdditionalKeyword_FunctionAddress;

	private static int GetAdditionalKeyword_ParamsSize;

	private static bool GetAdditionalKeyword_ReturnValue_IsValid;

	private static FFieldAddress GetAdditionalKeyword_ReturnValue_PropertyAddress;

	private static int GetAdditionalKeyword_ReturnValue_Offset;

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepFetcher:GetTooltipText")]
	public unsafe string GetTooltipText()
	{
		CheckDestroyed();
		if (!GetTooltipText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFetcher:GetTooltipText");
			return FStringMarshaler.DefaultString;
		}
		if (GetTooltipText_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetTooltipText_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetTooltipText");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTooltipText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTooltipText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTooltipText_InstanceFunctionAddress, intPtr, GetTooltipText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTooltipText_ReturnValue_Offset), 0, GetTooltipText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTooltipText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetTooltipText_Implementation()
	{
		CheckDestroyed();
		if (!GetTooltipText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFetcher:GetTooltipText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTooltipText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTooltipText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTooltipText_FunctionAddress, intPtr, GetTooltipText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTooltipText_ReturnValue_Offset), 0, GetTooltipText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTooltipText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepFetcher:GetNodeDisplayFetcherName")]
	public unsafe string GetNodeDisplayFetcherName()
	{
		CheckDestroyed();
		if (!GetNodeDisplayFetcherName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFetcher:GetNodeDisplayFetcherName");
			return FStringMarshaler.DefaultString;
		}
		if (GetNodeDisplayFetcherName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetNodeDisplayFetcherName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetNodeDisplayFetcherName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeDisplayFetcherName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeDisplayFetcherName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeDisplayFetcherName_InstanceFunctionAddress, intPtr, GetNodeDisplayFetcherName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetNodeDisplayFetcherName_ReturnValue_Offset), 0, GetNodeDisplayFetcherName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetNodeDisplayFetcherName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetNodeDisplayFetcherName_Implementation()
	{
		CheckDestroyed();
		if (!GetNodeDisplayFetcherName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFetcher:GetNodeDisplayFetcherName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeDisplayFetcherName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeDisplayFetcherName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeDisplayFetcherName_FunctionAddress, intPtr, GetNodeDisplayFetcherName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetNodeDisplayFetcherName_ReturnValue_Offset), 0, GetNodeDisplayFetcherName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetNodeDisplayFetcherName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepFetcher:GetDisplayFetcherName")]
	public unsafe string GetDisplayFetcherName()
	{
		CheckDestroyed();
		if (!GetDisplayFetcherName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFetcher:GetDisplayFetcherName");
			return FStringMarshaler.DefaultString;
		}
		if (GetDisplayFetcherName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDisplayFetcherName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDisplayFetcherName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayFetcherName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayFetcherName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayFetcherName_InstanceFunctionAddress, intPtr, GetDisplayFetcherName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayFetcherName_ReturnValue_Offset), 0, GetDisplayFetcherName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayFetcherName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetDisplayFetcherName_Implementation()
	{
		CheckDestroyed();
		if (!GetDisplayFetcherName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFetcher:GetDisplayFetcherName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayFetcherName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayFetcherName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayFetcherName_FunctionAddress, intPtr, GetDisplayFetcherName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayFetcherName_ReturnValue_Offset), 0, GetDisplayFetcherName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayFetcherName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepFetcher:GetAdditionalKeyword")]
	public unsafe string GetAdditionalKeyword()
	{
		CheckDestroyed();
		if (!GetAdditionalKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFetcher:GetAdditionalKeyword");
			return FStringMarshaler.DefaultString;
		}
		if (GetAdditionalKeyword_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAdditionalKeyword_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAdditionalKeyword");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAdditionalKeyword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAdditionalKeyword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAdditionalKeyword_InstanceFunctionAddress, intPtr, GetAdditionalKeyword_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetAdditionalKeyword_ReturnValue_Offset), 0, GetAdditionalKeyword_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetAdditionalKeyword_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetAdditionalKeyword_Implementation()
	{
		CheckDestroyed();
		if (!GetAdditionalKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFetcher:GetAdditionalKeyword");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAdditionalKeyword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAdditionalKeyword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAdditionalKeyword_FunctionAddress, intPtr, GetAdditionalKeyword_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetAdditionalKeyword_ReturnValue_Offset), 0, GetAdditionalKeyword_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetAdditionalKeyword_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UDataprepFetcher()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepFetcher)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepFetcher));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepFetcher");
		GetTooltipText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTooltipText");
		GetTooltipText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTooltipText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTooltipText_ReturnValue_PropertyAddress, GetTooltipText_FunctionAddress, "ReturnValue");
		GetTooltipText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTooltipText_FunctionAddress, "ReturnValue");
		GetTooltipText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTooltipText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTooltipText_IsValid = GetTooltipText_FunctionAddress != IntPtr.Zero && GetTooltipText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFetcher:GetTooltipText", GetTooltipText_IsValid);
		GetNodeDisplayFetcherName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeDisplayFetcherName");
		GetNodeDisplayFetcherName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDisplayFetcherName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeDisplayFetcherName_ReturnValue_PropertyAddress, GetNodeDisplayFetcherName_FunctionAddress, "ReturnValue");
		GetNodeDisplayFetcherName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeDisplayFetcherName_FunctionAddress, "ReturnValue");
		GetNodeDisplayFetcherName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeDisplayFetcherName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetNodeDisplayFetcherName_IsValid = GetNodeDisplayFetcherName_FunctionAddress != IntPtr.Zero && GetNodeDisplayFetcherName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFetcher:GetNodeDisplayFetcherName", GetNodeDisplayFetcherName_IsValid);
		GetDisplayFetcherName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayFetcherName");
		GetDisplayFetcherName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayFetcherName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayFetcherName_ReturnValue_PropertyAddress, GetDisplayFetcherName_FunctionAddress, "ReturnValue");
		GetDisplayFetcherName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayFetcherName_FunctionAddress, "ReturnValue");
		GetDisplayFetcherName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayFetcherName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayFetcherName_IsValid = GetDisplayFetcherName_FunctionAddress != IntPtr.Zero && GetDisplayFetcherName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFetcher:GetDisplayFetcherName", GetDisplayFetcherName_IsValid);
		GetAdditionalKeyword_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAdditionalKeyword");
		GetAdditionalKeyword_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAdditionalKeyword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAdditionalKeyword_ReturnValue_PropertyAddress, GetAdditionalKeyword_FunctionAddress, "ReturnValue");
		GetAdditionalKeyword_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditionalKeyword_FunctionAddress, "ReturnValue");
		GetAdditionalKeyword_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditionalKeyword_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetAdditionalKeyword_IsValid = GetAdditionalKeyword_FunctionAddress != IntPtr.Zero && GetAdditionalKeyword_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFetcher:GetAdditionalKeyword", GetAdditionalKeyword_IsValid);
	}
}
