using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "EditorSettings")]
[BlueprintType]
[UMetaPath("/Script/DataprepCore.DataprepContentConsumer", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepContentConsumer : UObject
{
	private static bool SetTargetContentFolderAutomated_IsValid;

	private static IntPtr SetTargetContentFolderAutomated_FunctionAddress;

	private static int SetTargetContentFolderAutomated_ParamsSize;

	private static bool SetTargetContentFolderAutomated_InTargetContentFolder_IsValid;

	private static FFieldAddress SetTargetContentFolderAutomated_InTargetContentFolder_PropertyAddress;

	private static int SetTargetContentFolderAutomated_InTargetContentFolder_Offset;

	private static bool SetTargetContentFolderAutomated_OutFailureReason_IsValid;

	private static FFieldAddress SetTargetContentFolderAutomated_OutFailureReason_PropertyAddress;

	private static int SetTargetContentFolderAutomated_OutFailureReason_Offset;

	private static bool SetTargetContentFolderAutomated_ReturnValue_IsValid;

	private static FFieldAddress SetTargetContentFolderAutomated_ReturnValue_PropertyAddress;

	private static int SetTargetContentFolderAutomated_ReturnValue_Offset;

	private static bool SetTargetContentFolder_IsValid;

	private static IntPtr SetTargetContentFolder_FunctionAddress;

	private static int SetTargetContentFolder_ParamsSize;

	private static bool SetTargetContentFolder_InTargetContentFolder_IsValid;

	private static FFieldAddress SetTargetContentFolder_InTargetContentFolder_PropertyAddress;

	private static int SetTargetContentFolder_InTargetContentFolder_Offset;

	private static bool SetTargetContentFolder_OutFailureReason_IsValid;

	private static FFieldAddress SetTargetContentFolder_OutFailureReason_PropertyAddress;

	private static int SetTargetContentFolder_OutFailureReason_Offset;

	private static bool SetTargetContentFolder_ReturnValue_IsValid;

	private static FFieldAddress SetTargetContentFolder_ReturnValue_PropertyAddress;

	private static int SetTargetContentFolder_ReturnValue_Offset;

	private static bool SetLevelNameAutomated_IsValid;

	private static IntPtr SetLevelNameAutomated_FunctionAddress;

	private static int SetLevelNameAutomated_ParamsSize;

	private static bool SetLevelNameAutomated_InLevelName_IsValid;

	private static FFieldAddress SetLevelNameAutomated_InLevelName_PropertyAddress;

	private static int SetLevelNameAutomated_InLevelName_Offset;

	private static bool SetLevelNameAutomated_OutFailureReason_IsValid;

	private static FFieldAddress SetLevelNameAutomated_OutFailureReason_PropertyAddress;

	private static int SetLevelNameAutomated_OutFailureReason_Offset;

	private static bool SetLevelNameAutomated_ReturnValue_IsValid;

	private static FFieldAddress SetLevelNameAutomated_ReturnValue_PropertyAddress;

	private static int SetLevelNameAutomated_ReturnValue_Offset;

	private static bool SetLevelName_IsValid;

	private static IntPtr SetLevelName_FunctionAddress;

	private static int SetLevelName_ParamsSize;

	private static bool SetLevelName_InLevelName_IsValid;

	private static FFieldAddress SetLevelName_InLevelName_PropertyAddress;

	private static int SetLevelName_InLevelName_Offset;

	private static bool SetLevelName_OutFailureReason_IsValid;

	private static FFieldAddress SetLevelName_OutFailureReason_PropertyAddress;

	private static int SetLevelName_OutFailureReason_Offset;

	private static bool SetLevelName_ReturnValue_IsValid;

	private static FFieldAddress SetLevelName_ReturnValue_PropertyAddress;

	private static int SetLevelName_ReturnValue_Offset;

	private static bool GetTargetContentFolder_IsValid;

	private static IntPtr GetTargetContentFolder_FunctionAddress;

	private static int GetTargetContentFolder_ParamsSize;

	private static bool GetTargetContentFolder_ReturnValue_IsValid;

	private static FFieldAddress GetTargetContentFolder_ReturnValue_PropertyAddress;

	private static int GetTargetContentFolder_ReturnValue_Offset;

	private static bool GetLevelName_IsValid;

	private static IntPtr GetLevelName_FunctionAddress;

	private static int GetLevelName_ParamsSize;

	private static bool GetLevelName_ReturnValue_IsValid;

	private static FFieldAddress GetLevelName_ReturnValue_PropertyAddress;

	private static int GetLevelName_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataprepCore.DataprepContentConsumer:SetTargetContentFolderAutomated")]
	public unsafe bool SetTargetContentFolderAutomated(string InTargetContentFolder, out FText OutFailureReason)
	{
		CheckDestroyed();
		if (!SetTargetContentFolderAutomated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepContentConsumer:SetTargetContentFolderAutomated");
			OutFailureReason = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetContentFolderAutomated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetContentFolderAutomated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetTargetContentFolderAutomated_InTargetContentFolder_Offset), 0, SetTargetContentFolderAutomated_InTargetContentFolder_PropertyAddress.Address, InTargetContentFolder);
		NativeReflection.InitializeValue_InContainer(SetTargetContentFolderAutomated_OutFailureReason_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTargetContentFolderAutomated_FunctionAddress, intPtr, SetTargetContentFolderAutomated_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTargetContentFolderAutomated_InTargetContentFolder_PropertyAddress.Address, intPtr);
		OutFailureReason = FTextMarshaler.FromNative(IntPtr.Add(intPtr, SetTargetContentFolderAutomated_OutFailureReason_Offset), 0, SetTargetContentFolderAutomated_OutFailureReason_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetTargetContentFolderAutomated_OutFailureReason_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetTargetContentFolderAutomated_ReturnValue_Offset), 0, SetTargetContentFolderAutomated_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataprepCore.DataprepContentConsumer:SetTargetContentFolder")]
	public unsafe bool SetTargetContentFolder(string InTargetContentFolder, out FText OutFailureReason)
	{
		CheckDestroyed();
		if (!SetTargetContentFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepContentConsumer:SetTargetContentFolder");
			OutFailureReason = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetContentFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetContentFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetTargetContentFolder_InTargetContentFolder_Offset), 0, SetTargetContentFolder_InTargetContentFolder_PropertyAddress.Address, InTargetContentFolder);
		NativeReflection.InitializeValue_InContainer(SetTargetContentFolder_OutFailureReason_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTargetContentFolder_FunctionAddress, intPtr, SetTargetContentFolder_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTargetContentFolder_InTargetContentFolder_PropertyAddress.Address, intPtr);
		OutFailureReason = FTextMarshaler.FromNative(IntPtr.Add(intPtr, SetTargetContentFolder_OutFailureReason_Offset), 0, SetTargetContentFolder_OutFailureReason_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetTargetContentFolder_OutFailureReason_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetTargetContentFolder_ReturnValue_Offset), 0, SetTargetContentFolder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataprepCore.DataprepContentConsumer:SetLevelNameAutomated")]
	public unsafe bool SetLevelNameAutomated(string InLevelName, out FText OutFailureReason)
	{
		CheckDestroyed();
		if (!SetLevelNameAutomated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepContentConsumer:SetLevelNameAutomated");
			OutFailureReason = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelNameAutomated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelNameAutomated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelNameAutomated_InLevelName_Offset), 0, SetLevelNameAutomated_InLevelName_PropertyAddress.Address, InLevelName);
		NativeReflection.InitializeValue_InContainer(SetLevelNameAutomated_OutFailureReason_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLevelNameAutomated_FunctionAddress, intPtr, SetLevelNameAutomated_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLevelNameAutomated_InLevelName_PropertyAddress.Address, intPtr);
		OutFailureReason = FTextMarshaler.FromNative(IntPtr.Add(intPtr, SetLevelNameAutomated_OutFailureReason_Offset), 0, SetLevelNameAutomated_OutFailureReason_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLevelNameAutomated_OutFailureReason_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLevelNameAutomated_ReturnValue_Offset), 0, SetLevelNameAutomated_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataprepCore.DataprepContentConsumer:SetLevelName")]
	public unsafe bool SetLevelName(string InLevelName, out FText OutFailureReason)
	{
		CheckDestroyed();
		if (!SetLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepContentConsumer:SetLevelName");
			OutFailureReason = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelName_InLevelName_Offset), 0, SetLevelName_InLevelName_PropertyAddress.Address, InLevelName);
		NativeReflection.InitializeValue_InContainer(SetLevelName_OutFailureReason_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLevelName_FunctionAddress, intPtr, SetLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLevelName_InLevelName_PropertyAddress.Address, intPtr);
		OutFailureReason = FTextMarshaler.FromNative(IntPtr.Add(intPtr, SetLevelName_OutFailureReason_Offset), 0, SetLevelName_OutFailureReason_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetLevelName_OutFailureReason_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLevelName_ReturnValue_Offset), 0, SetLevelName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DataprepCore.DataprepContentConsumer:GetTargetContentFolder")]
	public unsafe string GetTargetContentFolder()
	{
		CheckDestroyed();
		if (!GetTargetContentFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepContentConsumer:GetTargetContentFolder");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTargetContentFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTargetContentFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTargetContentFolder_FunctionAddress, intPtr, GetTargetContentFolder_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTargetContentFolder_ReturnValue_Offset), 0, GetTargetContentFolder_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTargetContentFolder_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DataprepCore.DataprepContentConsumer:GetLevelName")]
	public unsafe string GetLevelName()
	{
		CheckDestroyed();
		if (!GetLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepContentConsumer:GetLevelName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLevelName_FunctionAddress, intPtr, GetLevelName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLevelName_ReturnValue_Offset), 0, GetLevelName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLevelName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UDataprepContentConsumer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepContentConsumer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepContentConsumer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepContentConsumer");
		SetTargetContentFolderAutomated_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTargetContentFolderAutomated");
		SetTargetContentFolderAutomated_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetContentFolderAutomated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetContentFolderAutomated_InTargetContentFolder_PropertyAddress, SetTargetContentFolderAutomated_FunctionAddress, "InTargetContentFolder");
		SetTargetContentFolderAutomated_InTargetContentFolder_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetContentFolderAutomated_FunctionAddress, "InTargetContentFolder");
		SetTargetContentFolderAutomated_InTargetContentFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetContentFolderAutomated_FunctionAddress, "InTargetContentFolder", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTargetContentFolderAutomated_OutFailureReason_PropertyAddress, SetTargetContentFolderAutomated_FunctionAddress, "OutFailureReason");
		SetTargetContentFolderAutomated_OutFailureReason_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetContentFolderAutomated_FunctionAddress, "OutFailureReason");
		SetTargetContentFolderAutomated_OutFailureReason_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetContentFolderAutomated_FunctionAddress, "OutFailureReason", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTargetContentFolderAutomated_ReturnValue_PropertyAddress, SetTargetContentFolderAutomated_FunctionAddress, "ReturnValue");
		SetTargetContentFolderAutomated_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetContentFolderAutomated_FunctionAddress, "ReturnValue");
		SetTargetContentFolderAutomated_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetContentFolderAutomated_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTargetContentFolderAutomated_IsValid = SetTargetContentFolderAutomated_FunctionAddress != IntPtr.Zero && SetTargetContentFolderAutomated_InTargetContentFolder_IsValid && SetTargetContentFolderAutomated_OutFailureReason_IsValid && SetTargetContentFolderAutomated_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepContentConsumer:SetTargetContentFolderAutomated", SetTargetContentFolderAutomated_IsValid);
		SetTargetContentFolder_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTargetContentFolder");
		SetTargetContentFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetContentFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetContentFolder_InTargetContentFolder_PropertyAddress, SetTargetContentFolder_FunctionAddress, "InTargetContentFolder");
		SetTargetContentFolder_InTargetContentFolder_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetContentFolder_FunctionAddress, "InTargetContentFolder");
		SetTargetContentFolder_InTargetContentFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetContentFolder_FunctionAddress, "InTargetContentFolder", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTargetContentFolder_OutFailureReason_PropertyAddress, SetTargetContentFolder_FunctionAddress, "OutFailureReason");
		SetTargetContentFolder_OutFailureReason_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetContentFolder_FunctionAddress, "OutFailureReason");
		SetTargetContentFolder_OutFailureReason_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetContentFolder_FunctionAddress, "OutFailureReason", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTargetContentFolder_ReturnValue_PropertyAddress, SetTargetContentFolder_FunctionAddress, "ReturnValue");
		SetTargetContentFolder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetContentFolder_FunctionAddress, "ReturnValue");
		SetTargetContentFolder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetContentFolder_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTargetContentFolder_IsValid = SetTargetContentFolder_FunctionAddress != IntPtr.Zero && SetTargetContentFolder_InTargetContentFolder_IsValid && SetTargetContentFolder_OutFailureReason_IsValid && SetTargetContentFolder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepContentConsumer:SetTargetContentFolder", SetTargetContentFolder_IsValid);
		SetLevelNameAutomated_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLevelNameAutomated");
		SetLevelNameAutomated_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelNameAutomated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelNameAutomated_InLevelName_PropertyAddress, SetLevelNameAutomated_FunctionAddress, "InLevelName");
		SetLevelNameAutomated_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelNameAutomated_FunctionAddress, "InLevelName");
		SetLevelNameAutomated_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelNameAutomated_FunctionAddress, "InLevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelNameAutomated_OutFailureReason_PropertyAddress, SetLevelNameAutomated_FunctionAddress, "OutFailureReason");
		SetLevelNameAutomated_OutFailureReason_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelNameAutomated_FunctionAddress, "OutFailureReason");
		SetLevelNameAutomated_OutFailureReason_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelNameAutomated_FunctionAddress, "OutFailureReason", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelNameAutomated_ReturnValue_PropertyAddress, SetLevelNameAutomated_FunctionAddress, "ReturnValue");
		SetLevelNameAutomated_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelNameAutomated_FunctionAddress, "ReturnValue");
		SetLevelNameAutomated_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelNameAutomated_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLevelNameAutomated_IsValid = SetLevelNameAutomated_FunctionAddress != IntPtr.Zero && SetLevelNameAutomated_InLevelName_IsValid && SetLevelNameAutomated_OutFailureReason_IsValid && SetLevelNameAutomated_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepContentConsumer:SetLevelNameAutomated", SetLevelNameAutomated_IsValid);
		SetLevelName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLevelName");
		SetLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelName_InLevelName_PropertyAddress, SetLevelName_FunctionAddress, "InLevelName");
		SetLevelName_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelName_FunctionAddress, "InLevelName");
		SetLevelName_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelName_FunctionAddress, "InLevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelName_OutFailureReason_PropertyAddress, SetLevelName_FunctionAddress, "OutFailureReason");
		SetLevelName_OutFailureReason_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelName_FunctionAddress, "OutFailureReason");
		SetLevelName_OutFailureReason_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelName_FunctionAddress, "OutFailureReason", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelName_ReturnValue_PropertyAddress, SetLevelName_FunctionAddress, "ReturnValue");
		SetLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelName_FunctionAddress, "ReturnValue");
		SetLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLevelName_IsValid = SetLevelName_FunctionAddress != IntPtr.Zero && SetLevelName_InLevelName_IsValid && SetLevelName_OutFailureReason_IsValid && SetLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepContentConsumer:SetLevelName", SetLevelName_IsValid);
		GetTargetContentFolder_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTargetContentFolder");
		GetTargetContentFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTargetContentFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTargetContentFolder_ReturnValue_PropertyAddress, GetTargetContentFolder_FunctionAddress, "ReturnValue");
		GetTargetContentFolder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetContentFolder_FunctionAddress, "ReturnValue");
		GetTargetContentFolder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetContentFolder_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTargetContentFolder_IsValid = GetTargetContentFolder_FunctionAddress != IntPtr.Zero && GetTargetContentFolder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepContentConsumer:GetTargetContentFolder", GetTargetContentFolder_IsValid);
		GetLevelName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLevelName");
		GetLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelName_ReturnValue_PropertyAddress, GetLevelName_FunctionAddress, "ReturnValue");
		GetLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelName_FunctionAddress, "ReturnValue");
		GetLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLevelName_IsValid = GetLevelName_FunctionAddress != IntPtr.Zero && GetLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepContentConsumer:GetLevelName", GetLevelName_IsValid);
	}
}
