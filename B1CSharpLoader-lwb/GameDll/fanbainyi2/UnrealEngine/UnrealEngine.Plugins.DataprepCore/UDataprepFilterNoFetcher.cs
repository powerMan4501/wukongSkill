using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/DataprepCore.DataprepFilterNoFetcher", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepFilterNoFetcher : UDataprepParameterizableObject
{
	private static bool GetTooltipText_IsValid;

	private IntPtr GetTooltipText_InstanceFunctionAddress;

	private static IntPtr GetTooltipText_FunctionAddress;

	private static int GetTooltipText_ParamsSize;

	private static bool GetTooltipText_ReturnValue_IsValid;

	private static FFieldAddress GetTooltipText_ReturnValue_PropertyAddress;

	private static int GetTooltipText_ReturnValue_Offset;

	private static bool GetNodeDisplayFilterName_IsValid;

	private IntPtr GetNodeDisplayFilterName_InstanceFunctionAddress;

	private static IntPtr GetNodeDisplayFilterName_FunctionAddress;

	private static int GetNodeDisplayFilterName_ParamsSize;

	private static bool GetNodeDisplayFilterName_ReturnValue_IsValid;

	private static FFieldAddress GetNodeDisplayFilterName_ReturnValue_PropertyAddress;

	private static int GetNodeDisplayFilterName_ReturnValue_Offset;

	private static bool GetDisplayFilterName_IsValid;

	private IntPtr GetDisplayFilterName_InstanceFunctionAddress;

	private static IntPtr GetDisplayFilterName_FunctionAddress;

	private static int GetDisplayFilterName_ParamsSize;

	private static bool GetDisplayFilterName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayFilterName_ReturnValue_PropertyAddress;

	private static int GetDisplayFilterName_ReturnValue_Offset;

	private static bool GetAdditionalKeyword_IsValid;

	private IntPtr GetAdditionalKeyword_InstanceFunctionAddress;

	private static IntPtr GetAdditionalKeyword_FunctionAddress;

	private static int GetAdditionalKeyword_ParamsSize;

	private static bool GetAdditionalKeyword_ReturnValue_IsValid;

	private static FFieldAddress GetAdditionalKeyword_ReturnValue_PropertyAddress;

	private static int GetAdditionalKeyword_ReturnValue_Offset;

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepFilterNoFetcher:GetTooltipText")]
	public unsafe string GetTooltipText()
	{
		CheckDestroyed();
		if (!GetTooltipText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilterNoFetcher:GetTooltipText");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilterNoFetcher:GetTooltipText");
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
	[UMetaPath("/Script/DataprepCore.DataprepFilterNoFetcher:GetNodeDisplayFilterName")]
	public unsafe string GetNodeDisplayFilterName()
	{
		CheckDestroyed();
		if (!GetNodeDisplayFilterName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilterNoFetcher:GetNodeDisplayFilterName");
			return FStringMarshaler.DefaultString;
		}
		if (GetNodeDisplayFilterName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetNodeDisplayFilterName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetNodeDisplayFilterName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeDisplayFilterName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeDisplayFilterName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeDisplayFilterName_InstanceFunctionAddress, intPtr, GetNodeDisplayFilterName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetNodeDisplayFilterName_ReturnValue_Offset), 0, GetNodeDisplayFilterName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetNodeDisplayFilterName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetNodeDisplayFilterName_Implementation()
	{
		CheckDestroyed();
		if (!GetNodeDisplayFilterName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilterNoFetcher:GetNodeDisplayFilterName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeDisplayFilterName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeDisplayFilterName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeDisplayFilterName_FunctionAddress, intPtr, GetNodeDisplayFilterName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetNodeDisplayFilterName_ReturnValue_Offset), 0, GetNodeDisplayFilterName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetNodeDisplayFilterName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepFilterNoFetcher:GetDisplayFilterName")]
	public unsafe string GetDisplayFilterName()
	{
		CheckDestroyed();
		if (!GetDisplayFilterName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilterNoFetcher:GetDisplayFilterName");
			return FStringMarshaler.DefaultString;
		}
		if (GetDisplayFilterName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDisplayFilterName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDisplayFilterName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayFilterName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayFilterName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayFilterName_InstanceFunctionAddress, intPtr, GetDisplayFilterName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayFilterName_ReturnValue_Offset), 0, GetDisplayFilterName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayFilterName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetDisplayFilterName_Implementation()
	{
		CheckDestroyed();
		if (!GetDisplayFilterName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilterNoFetcher:GetDisplayFilterName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayFilterName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayFilterName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayFilterName_FunctionAddress, intPtr, GetDisplayFilterName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayFilterName_ReturnValue_Offset), 0, GetDisplayFilterName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayFilterName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepFilterNoFetcher:GetAdditionalKeyword")]
	public unsafe string GetAdditionalKeyword()
	{
		CheckDestroyed();
		if (!GetAdditionalKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilterNoFetcher:GetAdditionalKeyword");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepFilterNoFetcher:GetAdditionalKeyword");
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

	static UDataprepFilterNoFetcher()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepFilterNoFetcher)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepFilterNoFetcher));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepFilterNoFetcher");
		GetTooltipText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTooltipText");
		GetTooltipText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTooltipText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTooltipText_ReturnValue_PropertyAddress, GetTooltipText_FunctionAddress, "ReturnValue");
		GetTooltipText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTooltipText_FunctionAddress, "ReturnValue");
		GetTooltipText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTooltipText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTooltipText_IsValid = GetTooltipText_FunctionAddress != IntPtr.Zero && GetTooltipText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFilterNoFetcher:GetTooltipText", GetTooltipText_IsValid);
		GetNodeDisplayFilterName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeDisplayFilterName");
		GetNodeDisplayFilterName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDisplayFilterName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeDisplayFilterName_ReturnValue_PropertyAddress, GetNodeDisplayFilterName_FunctionAddress, "ReturnValue");
		GetNodeDisplayFilterName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeDisplayFilterName_FunctionAddress, "ReturnValue");
		GetNodeDisplayFilterName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeDisplayFilterName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetNodeDisplayFilterName_IsValid = GetNodeDisplayFilterName_FunctionAddress != IntPtr.Zero && GetNodeDisplayFilterName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFilterNoFetcher:GetNodeDisplayFilterName", GetNodeDisplayFilterName_IsValid);
		GetDisplayFilterName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayFilterName");
		GetDisplayFilterName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayFilterName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayFilterName_ReturnValue_PropertyAddress, GetDisplayFilterName_FunctionAddress, "ReturnValue");
		GetDisplayFilterName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayFilterName_FunctionAddress, "ReturnValue");
		GetDisplayFilterName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayFilterName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayFilterName_IsValid = GetDisplayFilterName_FunctionAddress != IntPtr.Zero && GetDisplayFilterName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFilterNoFetcher:GetDisplayFilterName", GetDisplayFilterName_IsValid);
		GetAdditionalKeyword_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAdditionalKeyword");
		GetAdditionalKeyword_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAdditionalKeyword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAdditionalKeyword_ReturnValue_PropertyAddress, GetAdditionalKeyword_FunctionAddress, "ReturnValue");
		GetAdditionalKeyword_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditionalKeyword_FunctionAddress, "ReturnValue");
		GetAdditionalKeyword_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditionalKeyword_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetAdditionalKeyword_IsValid = GetAdditionalKeyword_FunctionAddress != IntPtr.Zero && GetAdditionalKeyword_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepFilterNoFetcher:GetAdditionalKeyword", GetAdditionalKeyword_IsValid);
	}
}
