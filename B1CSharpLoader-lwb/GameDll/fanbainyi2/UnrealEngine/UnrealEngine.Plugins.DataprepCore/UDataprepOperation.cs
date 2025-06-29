using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepCore.DataprepOperation", "DataprepCore", UnrealModuleType.EnginePlugin)]
public class UDataprepOperation : UDataprepParameterizableObject
{
	private static bool ReportProgress_IsValid;

	private static IntPtr ReportProgress_FunctionAddress;

	private static int ReportProgress_ParamsSize;

	private static bool ReportProgress_IncrementOfWork_IsValid;

	private static FFieldAddress ReportProgress_IncrementOfWork_PropertyAddress;

	private static int ReportProgress_IncrementOfWork_Offset;

	private static bool ReportProgress_InMessage_IsValid;

	private static FFieldAddress ReportProgress_InMessage_PropertyAddress;

	private static int ReportProgress_InMessage_Offset;

	private static bool OnExecution_IsValid;

	private IntPtr OnExecution_InstanceFunctionAddress;

	private static IntPtr OnExecution_FunctionAddress;

	private static int OnExecution_ParamsSize;

	private static bool OnExecution_InContext_IsValid;

	private static FFieldAddress OnExecution_InContext_PropertyAddress;

	private static int OnExecution_InContext_Offset;

	private static bool LogWarning_IsValid;

	private static IntPtr LogWarning_FunctionAddress;

	private static int LogWarning_ParamsSize;

	private static bool LogWarning_InLogText_IsValid;

	private static FFieldAddress LogWarning_InLogText_PropertyAddress;

	private static int LogWarning_InLogText_Offset;

	private static bool LogInfo_IsValid;

	private static IntPtr LogInfo_FunctionAddress;

	private static int LogInfo_ParamsSize;

	private static bool LogInfo_InLogText_IsValid;

	private static FFieldAddress LogInfo_InLogText_PropertyAddress;

	private static int LogInfo_InLogText_Offset;

	private static bool LogError_IsValid;

	private static IntPtr LogError_FunctionAddress;

	private static int LogError_ParamsSize;

	private static bool LogError_InLogError_IsValid;

	private static FFieldAddress LogError_InLogError_PropertyAddress;

	private static int LogError_InLogError_Offset;

	private static bool GetTooltip_IsValid;

	private IntPtr GetTooltip_InstanceFunctionAddress;

	private static IntPtr GetTooltip_FunctionAddress;

	private static int GetTooltip_ParamsSize;

	private static bool GetTooltip_ReturnValue_IsValid;

	private static FFieldAddress GetTooltip_ReturnValue_PropertyAddress;

	private static int GetTooltip_ReturnValue_Offset;

	private static bool GetDisplayOperationName_IsValid;

	private IntPtr GetDisplayOperationName_InstanceFunctionAddress;

	private static IntPtr GetDisplayOperationName_FunctionAddress;

	private static int GetDisplayOperationName_ParamsSize;

	private static bool GetDisplayOperationName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayOperationName_ReturnValue_PropertyAddress;

	private static int GetDisplayOperationName_ReturnValue_Offset;

	private static bool GetCategory_IsValid;

	private IntPtr GetCategory_InstanceFunctionAddress;

	private static IntPtr GetCategory_FunctionAddress;

	private static int GetCategory_ParamsSize;

	private static bool GetCategory_ReturnValue_IsValid;

	private static FFieldAddress GetCategory_ReturnValue_PropertyAddress;

	private static int GetCategory_ReturnValue_Offset;

	private static bool GetAdditionalKeyword_IsValid;

	private IntPtr GetAdditionalKeyword_InstanceFunctionAddress;

	private static IntPtr GetAdditionalKeyword_FunctionAddress;

	private static int GetAdditionalKeyword_ParamsSize;

	private static bool GetAdditionalKeyword_ReturnValue_IsValid;

	private static FFieldAddress GetAdditionalKeyword_ReturnValue_PropertyAddress;

	private static int GetAdditionalKeyword_ReturnValue_Offset;

	private static bool Execute_IsValid;

	private static IntPtr Execute_FunctionAddress;

	private static int Execute_ParamsSize;

	private static bool Execute_InObjects_IsValid;

	private static FFieldAddress Execute_InObjects_PropertyAddress;

	private static int Execute_InObjects_Offset;

	private static bool EndWork_IsValid;

	private static IntPtr EndWork_FunctionAddress;

	private static int EndWork_ParamsSize;

	private static bool BeginWork_IsValid;

	private static IntPtr BeginWork_FunctionAddress;

	private static int BeginWork_ParamsSize;

	private static bool BeginWork_InDescription_IsValid;

	private static FFieldAddress BeginWork_InDescription_PropertyAddress;

	private static int BeginWork_InDescription_Offset;

	private static bool BeginWork_InAmountOfWork_IsValid;

	private static FFieldAddress BeginWork_InAmountOfWork_PropertyAddress;

	private static int BeginWork_InAmountOfWork_Offset;

	private static bool AssetsModified_IsValid;

	private static IntPtr AssetsModified_FunctionAddress;

	private static int AssetsModified_ParamsSize;

	private static bool AssetsModified_Assets_IsValid;

	private static FFieldAddress AssetsModified_Assets_PropertyAddress;

	private static int AssetsModified_Assets_Offset;

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:ReportProgress")]
	protected unsafe void ReportProgress(float IncrementOfWork, FText InMessage)
	{
		CheckDestroyed();
		if (!ReportProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:ReportProgress");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReportProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReportProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReportProgress_IncrementOfWork_Offset), 0, ReportProgress_IncrementOfWork_PropertyAddress.Address, IncrementOfWork);
		NativeReflection.InitializeValue_InContainer(ReportProgress_InMessage_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ReportProgress_InMessage_Offset), 0, ReportProgress_InMessage_PropertyAddress.Address, InMessage);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReportProgress_FunctionAddress, intPtr, ReportProgress_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReportProgress_InMessage_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138939392u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:OnExecution")]
	protected unsafe void OnExecution(FDataprepContext InContext)
	{
		CheckDestroyed();
		if (!OnExecution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:OnExecution");
			return;
		}
		if (OnExecution_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnExecution_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnExecution");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExecution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExecution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnExecution_InContext_PropertyAddress.Address, intPtr);
		FDataprepContext.ToNative(IntPtr.Add(intPtr, OnExecution_InContext_Offset), 0, OnExecution_InContext_PropertyAddress.Address, InContext);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExecution_InstanceFunctionAddress, intPtr, OnExecution_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnExecution_InContext_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnExecution_Implementation(FDataprepContext InContext)
	{
		CheckDestroyed();
		if (!OnExecution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:OnExecution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExecution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExecution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnExecution_InContext_PropertyAddress.Address, intPtr);
		FDataprepContext.ToNative(IntPtr.Add(intPtr, OnExecution_InContext_Offset), 0, OnExecution_InContext_PropertyAddress.Address, InContext);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExecution_FunctionAddress, intPtr, OnExecution_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnExecution_InContext_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:LogWarning")]
	protected unsafe void LogWarning(FText InLogText)
	{
		CheckDestroyed();
		if (!LogWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:LogWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(LogWarning_InLogText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, LogWarning_InLogText_Offset), 0, LogWarning_InLogText_PropertyAddress.Address, InLogText);
		NativeReflection.InvokeFunctionOptimized(base.Address, LogWarning_FunctionAddress, intPtr, LogWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogWarning_InLogText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:LogInfo")]
	protected unsafe void LogInfo(FText InLogText)
	{
		CheckDestroyed();
		if (!LogInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:LogInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(LogInfo_InLogText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, LogInfo_InLogText_Offset), 0, LogInfo_InLogText_PropertyAddress.Address, InLogText);
		NativeReflection.InvokeFunctionOptimized(base.Address, LogInfo_FunctionAddress, intPtr, LogInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogInfo_InLogText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:LogError")]
	protected unsafe void LogError(FText InLogError)
	{
		CheckDestroyed();
		if (!LogError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:LogError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(LogError_InLogError_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, LogError_InLogError_Offset), 0, LogError_InLogError_PropertyAddress.Address, InLogError);
		NativeReflection.InvokeFunctionOptimized(base.Address, LogError_FunctionAddress, intPtr, LogError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogError_InLogError_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:GetTooltip")]
	public unsafe string GetTooltip()
	{
		CheckDestroyed();
		if (!GetTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:GetTooltip");
			return FStringMarshaler.DefaultString;
		}
		if (GetTooltip_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetTooltip_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetTooltip");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTooltip_InstanceFunctionAddress, intPtr, GetTooltip_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTooltip_ReturnValue_Offset), 0, GetTooltip_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTooltip_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetTooltip_Implementation()
	{
		CheckDestroyed();
		if (!GetTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:GetTooltip");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTooltip_FunctionAddress, intPtr, GetTooltip_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTooltip_ReturnValue_Offset), 0, GetTooltip_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTooltip_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:GetDisplayOperationName")]
	public unsafe string GetDisplayOperationName()
	{
		CheckDestroyed();
		if (!GetDisplayOperationName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:GetDisplayOperationName");
			return FStringMarshaler.DefaultString;
		}
		if (GetDisplayOperationName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDisplayOperationName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDisplayOperationName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayOperationName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayOperationName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayOperationName_InstanceFunctionAddress, intPtr, GetDisplayOperationName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayOperationName_ReturnValue_Offset), 0, GetDisplayOperationName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayOperationName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetDisplayOperationName_Implementation()
	{
		CheckDestroyed();
		if (!GetDisplayOperationName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:GetDisplayOperationName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayOperationName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayOperationName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayOperationName_FunctionAddress, intPtr, GetDisplayOperationName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayOperationName_ReturnValue_Offset), 0, GetDisplayOperationName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayOperationName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:GetCategory")]
	public unsafe string GetCategory()
	{
		CheckDestroyed();
		if (!GetCategory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:GetCategory");
			return FStringMarshaler.DefaultString;
		}
		if (GetCategory_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCategory_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCategory");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCategory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCategory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCategory_InstanceFunctionAddress, intPtr, GetCategory_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCategory_ReturnValue_Offset), 0, GetCategory_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetCategory_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetCategory_Implementation()
	{
		CheckDestroyed();
		if (!GetCategory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:GetCategory");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCategory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCategory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCategory_FunctionAddress, intPtr, GetCategory_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCategory_ReturnValue_Offset), 0, GetCategory_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetCategory_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:GetAdditionalKeyword")]
	public unsafe string GetAdditionalKeyword()
	{
		CheckDestroyed();
		if (!GetAdditionalKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:GetAdditionalKeyword");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:GetAdditionalKeyword");
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

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:Execute")]
	public unsafe void Execute(List<UObject> InObjects)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:Execute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, Execute_InObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, Execute_InObjects_Offset), InObjects);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_FunctionAddress, intPtr, Execute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Execute_InObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:EndWork")]
	protected unsafe void EndWork()
	{
		CheckDestroyed();
		if (!EndWork_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:EndWork");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndWork_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndWork_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndWork_FunctionAddress, argsSize: EndWork_ParamsSize);
	}

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:BeginWork")]
	protected unsafe void BeginWork(FText InDescription, float InAmountOfWork)
	{
		CheckDestroyed();
		if (!BeginWork_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:BeginWork");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginWork_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginWork_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BeginWork_InDescription_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, BeginWork_InDescription_Offset), 0, BeginWork_InDescription_PropertyAddress.Address, InDescription);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BeginWork_InAmountOfWork_Offset), 0, BeginWork_InAmountOfWork_PropertyAddress.Address, InAmountOfWork);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginWork_FunctionAddress, intPtr, BeginWork_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BeginWork_InDescription_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/DataprepCore.DataprepOperation:AssetsModified")]
	protected unsafe void AssetsModified(List<UObject> Assets)
	{
		CheckDestroyed();
		if (!AssetsModified_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepCore.DataprepOperation:AssetsModified");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssetsModified_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssetsModified_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, AssetsModified_Assets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, AssetsModified_Assets_Offset), Assets);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssetsModified_FunctionAddress, intPtr, AssetsModified_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssetsModified_Assets_PropertyAddress.Address, intPtr);
	}

	static UDataprepOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataprepCore.DataprepOperation");
		ReportProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReportProgress");
		ReportProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(ReportProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReportProgress_IncrementOfWork_PropertyAddress, ReportProgress_FunctionAddress, "IncrementOfWork");
		ReportProgress_IncrementOfWork_Offset = NativeReflectionCached.GetPropertyOffset(ReportProgress_FunctionAddress, "IncrementOfWork");
		ReportProgress_IncrementOfWork_IsValid = NativeReflectionCached.ValidatePropertyClass(ReportProgress_FunctionAddress, "IncrementOfWork", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReportProgress_InMessage_PropertyAddress, ReportProgress_FunctionAddress, "InMessage");
		ReportProgress_InMessage_Offset = NativeReflectionCached.GetPropertyOffset(ReportProgress_FunctionAddress, "InMessage");
		ReportProgress_InMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(ReportProgress_FunctionAddress, "InMessage", Classes.FTextProperty);
		ReportProgress_IsValid = ReportProgress_FunctionAddress != IntPtr.Zero && ReportProgress_IncrementOfWork_IsValid && ReportProgress_InMessage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:ReportProgress", ReportProgress_IsValid);
		OnExecution_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnExecution");
		OnExecution_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExecution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExecution_InContext_PropertyAddress, OnExecution_FunctionAddress, "InContext");
		OnExecution_InContext_Offset = NativeReflectionCached.GetPropertyOffset(OnExecution_FunctionAddress, "InContext");
		OnExecution_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExecution_FunctionAddress, "InContext", Classes.FStructProperty);
		OnExecution_IsValid = OnExecution_FunctionAddress != IntPtr.Zero && OnExecution_InContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:OnExecution", OnExecution_IsValid);
		LogWarning_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LogWarning");
		LogWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(LogWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogWarning_InLogText_PropertyAddress, LogWarning_FunctionAddress, "InLogText");
		LogWarning_InLogText_Offset = NativeReflectionCached.GetPropertyOffset(LogWarning_FunctionAddress, "InLogText");
		LogWarning_InLogText_IsValid = NativeReflectionCached.ValidatePropertyClass(LogWarning_FunctionAddress, "InLogText", Classes.FTextProperty);
		LogWarning_IsValid = LogWarning_FunctionAddress != IntPtr.Zero && LogWarning_InLogText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:LogWarning", LogWarning_IsValid);
		LogInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LogInfo");
		LogInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(LogInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogInfo_InLogText_PropertyAddress, LogInfo_FunctionAddress, "InLogText");
		LogInfo_InLogText_Offset = NativeReflectionCached.GetPropertyOffset(LogInfo_FunctionAddress, "InLogText");
		LogInfo_InLogText_IsValid = NativeReflectionCached.ValidatePropertyClass(LogInfo_FunctionAddress, "InLogText", Classes.FTextProperty);
		LogInfo_IsValid = LogInfo_FunctionAddress != IntPtr.Zero && LogInfo_InLogText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:LogInfo", LogInfo_IsValid);
		LogError_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LogError");
		LogError_ParamsSize = NativeReflection.GetFunctionParamsSize(LogError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogError_InLogError_PropertyAddress, LogError_FunctionAddress, "InLogError");
		LogError_InLogError_Offset = NativeReflectionCached.GetPropertyOffset(LogError_FunctionAddress, "InLogError");
		LogError_InLogError_IsValid = NativeReflectionCached.ValidatePropertyClass(LogError_FunctionAddress, "InLogError", Classes.FTextProperty);
		LogError_IsValid = LogError_FunctionAddress != IntPtr.Zero && LogError_InLogError_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:LogError", LogError_IsValid);
		GetTooltip_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTooltip");
		GetTooltip_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTooltip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTooltip_ReturnValue_PropertyAddress, GetTooltip_FunctionAddress, "ReturnValue");
		GetTooltip_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTooltip_FunctionAddress, "ReturnValue");
		GetTooltip_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTooltip_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTooltip_IsValid = GetTooltip_FunctionAddress != IntPtr.Zero && GetTooltip_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:GetTooltip", GetTooltip_IsValid);
		GetDisplayOperationName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayOperationName");
		GetDisplayOperationName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayOperationName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayOperationName_ReturnValue_PropertyAddress, GetDisplayOperationName_FunctionAddress, "ReturnValue");
		GetDisplayOperationName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayOperationName_FunctionAddress, "ReturnValue");
		GetDisplayOperationName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayOperationName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayOperationName_IsValid = GetDisplayOperationName_FunctionAddress != IntPtr.Zero && GetDisplayOperationName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:GetDisplayOperationName", GetDisplayOperationName_IsValid);
		GetCategory_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCategory");
		GetCategory_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCategory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCategory_ReturnValue_PropertyAddress, GetCategory_FunctionAddress, "ReturnValue");
		GetCategory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCategory_FunctionAddress, "ReturnValue");
		GetCategory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCategory_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetCategory_IsValid = GetCategory_FunctionAddress != IntPtr.Zero && GetCategory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:GetCategory", GetCategory_IsValid);
		GetAdditionalKeyword_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAdditionalKeyword");
		GetAdditionalKeyword_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAdditionalKeyword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAdditionalKeyword_ReturnValue_PropertyAddress, GetAdditionalKeyword_FunctionAddress, "ReturnValue");
		GetAdditionalKeyword_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditionalKeyword_FunctionAddress, "ReturnValue");
		GetAdditionalKeyword_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditionalKeyword_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetAdditionalKeyword_IsValid = GetAdditionalKeyword_FunctionAddress != IntPtr.Zero && GetAdditionalKeyword_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:GetAdditionalKeyword", GetAdditionalKeyword_IsValid);
		Execute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Execute");
		Execute_ParamsSize = NativeReflection.GetFunctionParamsSize(Execute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Execute_InObjects_PropertyAddress, Execute_FunctionAddress, "InObjects");
		Execute_InObjects_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "InObjects");
		Execute_InObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "InObjects", Classes.FArrayProperty);
		Execute_IsValid = Execute_FunctionAddress != IntPtr.Zero && Execute_InObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:Execute", Execute_IsValid);
		EndWork_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndWork");
		EndWork_ParamsSize = NativeReflection.GetFunctionParamsSize(EndWork_FunctionAddress);
		EndWork_IsValid = EndWork_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:EndWork", EndWork_IsValid);
		BeginWork_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginWork");
		BeginWork_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginWork_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginWork_InDescription_PropertyAddress, BeginWork_FunctionAddress, "InDescription");
		BeginWork_InDescription_Offset = NativeReflectionCached.GetPropertyOffset(BeginWork_FunctionAddress, "InDescription");
		BeginWork_InDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginWork_FunctionAddress, "InDescription", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginWork_InAmountOfWork_PropertyAddress, BeginWork_FunctionAddress, "InAmountOfWork");
		BeginWork_InAmountOfWork_Offset = NativeReflectionCached.GetPropertyOffset(BeginWork_FunctionAddress, "InAmountOfWork");
		BeginWork_InAmountOfWork_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginWork_FunctionAddress, "InAmountOfWork", Classes.FFloatProperty);
		BeginWork_IsValid = BeginWork_FunctionAddress != IntPtr.Zero && BeginWork_InDescription_IsValid && BeginWork_InAmountOfWork_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:BeginWork", BeginWork_IsValid);
		AssetsModified_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AssetsModified");
		AssetsModified_ParamsSize = NativeReflection.GetFunctionParamsSize(AssetsModified_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssetsModified_Assets_PropertyAddress, AssetsModified_FunctionAddress, "Assets");
		AssetsModified_Assets_Offset = NativeReflectionCached.GetPropertyOffset(AssetsModified_FunctionAddress, "Assets");
		AssetsModified_Assets_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetsModified_FunctionAddress, "Assets", Classes.FArrayProperty);
		AssetsModified_IsValid = AssetsModified_FunctionAddress != IntPtr.Zero && AssetsModified_Assets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepCore.DataprepOperation:AssetsModified", AssetsModified_IsValid);
	}
}
