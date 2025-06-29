using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BTTask_USharpBase", "b1", UnrealModuleType.Game)]
public class UBTTask_USharpBase : UBTTaskNode
{
	private static bool CustomDescription_IsValid;

	private static int CustomDescription_Offset;

	private static bool SetNodeNameInCS_IsValid;

	private static IntPtr SetNodeNameInCS_FunctionAddress;

	private static int SetNodeNameInCS_ParamsSize;

	private static bool SetNodeNameInCS_NewNodeName_IsValid;

	private static FFieldAddress SetNodeNameInCS_NewNodeName_PropertyAddress;

	private static int SetNodeNameInCS_NewNodeName_Offset;

	private static bool RefreshNodeInfoInEditor_IsValid;

	private IntPtr RefreshNodeInfoInEditor_InstanceFunctionAddress;

	private static IntPtr RefreshNodeInfoInEditor_FunctionAddress;

	private static int RefreshNodeInfoInEditor_ParamsSize;

	private static bool OnPropertyChanged_IsValid;

	private IntPtr OnPropertyChanged_InstanceFunctionAddress;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static int OnPropertyChanged_MemberName_Offset;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static bool IsTaskExecuting_IsValid;

	private static IntPtr IsTaskExecuting_FunctionAddress;

	private static int IsTaskExecuting_ParamsSize;

	private static bool IsTaskExecuting_ReturnValue_IsValid;

	private static FFieldAddress IsTaskExecuting_ReturnValue_PropertyAddress;

	private static int IsTaskExecuting_ReturnValue_Offset;

	private static bool IsTaskAborting_IsValid;

	private static IntPtr IsTaskAborting_FunctionAddress;

	private static int IsTaskAborting_ParamsSize;

	private static bool IsTaskAborting_ReturnValue_IsValid;

	private static FFieldAddress IsTaskAborting_ReturnValue_PropertyAddress;

	private static int IsTaskAborting_ReturnValue_Offset;

	private static bool ForceRefreshDetailView_IsValid;

	private static IntPtr ForceRefreshDetailView_FunctionAddress;

	private static int ForceRefreshDetailView_ParamsSize;

	private static bool FinishExecute_IsValid;

	private static IntPtr FinishExecute_FunctionAddress;

	private static int FinishExecute_ParamsSize;

	private static bool FinishExecute_bSuccess_IsValid;

	private static FFieldAddress FinishExecute_bSuccess_PropertyAddress;

	private static int FinishExecute_bSuccess_Offset;

	private static bool FinishAbort_IsValid;

	private static IntPtr FinishAbort_FunctionAddress;

	private static int FinishAbort_ParamsSize;

	[UProperty(Flags = (PropFlags)11267829521252869uL)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:CustomDescription")]
	protected string CustomDescription
	{
		get
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BTTask_USharpBase:CustomDescription");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CustomDescription_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BTTask_USharpBase:CustomDescription");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CustomDescription_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:SetNodeNameInCS")]
	protected unsafe void SetNodeNameInCS(string NewNodeName)
	{
		CheckDestroyed();
		if (!SetNodeNameInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:SetNodeNameInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeNameInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeNameInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeNameInCS_NewNodeName_Offset), 0, SetNodeNameInCS_NewNodeName_PropertyAddress.Address, NewNodeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeNameInCS_FunctionAddress, intPtr, SetNodeNameInCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeNameInCS_NewNodeName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:RefreshNodeInfoInEditor")]
	public unsafe void RefreshNodeInfoInEditor()
	{
		CheckDestroyed();
		if (!RefreshNodeInfoInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:RefreshNodeInfoInEditor");
			return;
		}
		if (RefreshNodeInfoInEditor_InstanceFunctionAddress == IntPtr.Zero)
		{
			RefreshNodeInfoInEditor_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RefreshNodeInfoInEditor");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshNodeInfoInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshNodeInfoInEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshNodeInfoInEditor_InstanceFunctionAddress, argsSize: RefreshNodeInfoInEditor_ParamsSize);
	}

	protected unsafe virtual void RefreshNodeInfoInEditor_Implementation()
	{
		CheckDestroyed();
		if (!RefreshNodeInfoInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:RefreshNodeInfoInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshNodeInfoInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshNodeInfoInEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshNodeInfoInEditor_FunctionAddress, argsSize: RefreshNodeInfoInEditor_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:OnPropertyChanged")]
	protected unsafe void OnPropertyChanged(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:OnPropertyChanged");
			return;
		}
		if (OnPropertyChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPropertyChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPropertyChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_MemberName_Offset), 0, OnPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_PropertyName_Offset), 0, OnPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPropertyChanged_InstanceFunctionAddress, intPtr, OnPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:OnPropertyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_MemberName_Offset), 0, OnPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_PropertyName_Offset), 0, OnPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPropertyChanged_FunctionAddress, intPtr, OnPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:IsTaskExecuting")]
	protected unsafe bool IsTaskExecuting()
	{
		CheckDestroyed();
		if (!IsTaskExecuting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:IsTaskExecuting");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTaskExecuting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTaskExecuting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTaskExecuting_FunctionAddress, intPtr, IsTaskExecuting_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTaskExecuting_ReturnValue_Offset), 0, IsTaskExecuting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:IsTaskAborting")]
	protected unsafe bool IsTaskAborting()
	{
		CheckDestroyed();
		if (!IsTaskAborting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:IsTaskAborting");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTaskAborting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTaskAborting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTaskAborting_FunctionAddress, intPtr, IsTaskAborting_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTaskAborting_ReturnValue_Offset), 0, IsTaskAborting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604505089u)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:ForceRefreshDetailView")]
	protected unsafe void ForceRefreshDetailView()
	{
		CheckDestroyed();
		if (!ForceRefreshDetailView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:ForceRefreshDetailView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceRefreshDetailView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceRefreshDetailView_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceRefreshDetailView_FunctionAddress, argsSize: ForceRefreshDetailView_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:FinishExecute")]
	protected unsafe void FinishExecute(bool bSuccess)
	{
		CheckDestroyed();
		if (!FinishExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:FinishExecute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FinishExecute_bSuccess_Offset), 0, FinishExecute_bSuccess_PropertyAddress.Address, bSuccess);
		NativeReflection.InvokeFunctionOptimized(base.Address, FinishExecute_FunctionAddress, intPtr, FinishExecute_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BTTask_USharpBase:FinishAbort")]
	protected unsafe void FinishAbort()
	{
		CheckDestroyed();
		if (!FinishAbort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTTask_USharpBase:FinishAbort");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishAbort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishAbort_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FinishAbort_FunctionAddress, argsSize: FinishAbort_ParamsSize);
	}

	static UBTTask_USharpBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBTTask_USharpBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBTTask_USharpBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BTTask_USharpBase");
		CustomDescription_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomDescription");
		CustomDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomDescription", Classes.FStrProperty);
		SetNodeNameInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeNameInCS");
		SetNodeNameInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeNameInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeNameInCS_NewNodeName_PropertyAddress, SetNodeNameInCS_FunctionAddress, "NewNodeName");
		SetNodeNameInCS_NewNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeNameInCS_FunctionAddress, "NewNodeName");
		SetNodeNameInCS_NewNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeNameInCS_FunctionAddress, "NewNodeName", Classes.FStrProperty);
		SetNodeNameInCS_IsValid = SetNodeNameInCS_FunctionAddress != IntPtr.Zero && SetNodeNameInCS_NewNodeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTTask_USharpBase:SetNodeNameInCS", SetNodeNameInCS_IsValid);
		RefreshNodeInfoInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshNodeInfoInEditor");
		RefreshNodeInfoInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshNodeInfoInEditor_FunctionAddress);
		RefreshNodeInfoInEditor_IsValid = RefreshNodeInfoInEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTTask_USharpBase:RefreshNodeInfoInEditor", RefreshNodeInfoInEditor_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTTask_USharpBase:OnPropertyChanged", OnPropertyChanged_IsValid);
		IsTaskExecuting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsTaskExecuting");
		IsTaskExecuting_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTaskExecuting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTaskExecuting_ReturnValue_PropertyAddress, IsTaskExecuting_FunctionAddress, "ReturnValue");
		IsTaskExecuting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTaskExecuting_FunctionAddress, "ReturnValue");
		IsTaskExecuting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTaskExecuting_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTaskExecuting_IsValid = IsTaskExecuting_FunctionAddress != IntPtr.Zero && IsTaskExecuting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTTask_USharpBase:IsTaskExecuting", IsTaskExecuting_IsValid);
		IsTaskAborting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsTaskAborting");
		IsTaskAborting_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTaskAborting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTaskAborting_ReturnValue_PropertyAddress, IsTaskAborting_FunctionAddress, "ReturnValue");
		IsTaskAborting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTaskAborting_FunctionAddress, "ReturnValue");
		IsTaskAborting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTaskAborting_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTaskAborting_IsValid = IsTaskAborting_FunctionAddress != IntPtr.Zero && IsTaskAborting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTTask_USharpBase:IsTaskAborting", IsTaskAborting_IsValid);
		ForceRefreshDetailView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceRefreshDetailView");
		ForceRefreshDetailView_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceRefreshDetailView_FunctionAddress);
		ForceRefreshDetailView_IsValid = ForceRefreshDetailView_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTTask_USharpBase:ForceRefreshDetailView", ForceRefreshDetailView_IsValid);
		FinishExecute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FinishExecute");
		FinishExecute_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishExecute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FinishExecute_bSuccess_PropertyAddress, FinishExecute_FunctionAddress, "bSuccess");
		FinishExecute_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(FinishExecute_FunctionAddress, "bSuccess");
		FinishExecute_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(FinishExecute_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		FinishExecute_IsValid = FinishExecute_FunctionAddress != IntPtr.Zero && FinishExecute_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTTask_USharpBase:FinishExecute", FinishExecute_IsValid);
		FinishAbort_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FinishAbort");
		FinishAbort_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishAbort_FunctionAddress);
		FinishAbort_IsValid = FinishAbort_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTTask_USharpBase:FinishAbort", FinishAbort_IsValid);
	}
}
