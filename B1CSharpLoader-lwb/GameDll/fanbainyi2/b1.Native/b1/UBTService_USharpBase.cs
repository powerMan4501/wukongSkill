using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BTService_USharpBase", "b1", UnrealModuleType.Game)]
public class UBTService_USharpBase : UBTService
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

	private static bool IsServiceActive_IsValid;

	private static IntPtr IsServiceActive_FunctionAddress;

	private static int IsServiceActive_ParamsSize;

	private static bool IsServiceActive_ReturnValue_IsValid;

	private static FFieldAddress IsServiceActive_ReturnValue_PropertyAddress;

	private static int IsServiceActive_ReturnValue_Offset;

	private static bool ForceRefreshDetailView_IsValid;

	private static IntPtr ForceRefreshDetailView_FunctionAddress;

	private static int ForceRefreshDetailView_ParamsSize;

	[UProperty(Flags = (PropFlags)11267829521252869uL)]
	[UMetaPath("/Script/b1.BTService_USharpBase:CustomDescription")]
	protected string CustomDescription
	{
		get
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BTService_USharpBase:CustomDescription");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CustomDescription_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BTService_USharpBase:CustomDescription");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CustomDescription_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BTService_USharpBase:SetNodeNameInCS")]
	protected unsafe void SetNodeNameInCS(string NewNodeName)
	{
		CheckDestroyed();
		if (!SetNodeNameInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTService_USharpBase:SetNodeNameInCS");
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
	[UMetaPath("/Script/b1.BTService_USharpBase:RefreshNodeInfoInEditor")]
	public unsafe void RefreshNodeInfoInEditor()
	{
		CheckDestroyed();
		if (!RefreshNodeInfoInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTService_USharpBase:RefreshNodeInfoInEditor");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTService_USharpBase:RefreshNodeInfoInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshNodeInfoInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshNodeInfoInEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshNodeInfoInEditor_FunctionAddress, argsSize: RefreshNodeInfoInEditor_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BTService_USharpBase:OnPropertyChanged")]
	protected unsafe void OnPropertyChanged(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTService_USharpBase:OnPropertyChanged");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTService_USharpBase:OnPropertyChanged");
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
	[UMetaPath("/Script/b1.BTService_USharpBase:IsServiceActive")]
	protected unsafe bool IsServiceActive()
	{
		CheckDestroyed();
		if (!IsServiceActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTService_USharpBase:IsServiceActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsServiceActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsServiceActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsServiceActive_FunctionAddress, intPtr, IsServiceActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsServiceActive_ReturnValue_Offset), 0, IsServiceActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604505089u)]
	[UMetaPath("/Script/b1.BTService_USharpBase:ForceRefreshDetailView")]
	protected unsafe void ForceRefreshDetailView()
	{
		CheckDestroyed();
		if (!ForceRefreshDetailView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BTService_USharpBase:ForceRefreshDetailView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceRefreshDetailView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceRefreshDetailView_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceRefreshDetailView_FunctionAddress, argsSize: ForceRefreshDetailView_ParamsSize);
	}

	static UBTService_USharpBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBTService_USharpBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBTService_USharpBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BTService_USharpBase");
		CustomDescription_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomDescription");
		CustomDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomDescription", Classes.FStrProperty);
		SetNodeNameInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeNameInCS");
		SetNodeNameInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeNameInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeNameInCS_NewNodeName_PropertyAddress, SetNodeNameInCS_FunctionAddress, "NewNodeName");
		SetNodeNameInCS_NewNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeNameInCS_FunctionAddress, "NewNodeName");
		SetNodeNameInCS_NewNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeNameInCS_FunctionAddress, "NewNodeName", Classes.FStrProperty);
		SetNodeNameInCS_IsValid = SetNodeNameInCS_FunctionAddress != IntPtr.Zero && SetNodeNameInCS_NewNodeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTService_USharpBase:SetNodeNameInCS", SetNodeNameInCS_IsValid);
		RefreshNodeInfoInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshNodeInfoInEditor");
		RefreshNodeInfoInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshNodeInfoInEditor_FunctionAddress);
		RefreshNodeInfoInEditor_IsValid = RefreshNodeInfoInEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTService_USharpBase:RefreshNodeInfoInEditor", RefreshNodeInfoInEditor_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTService_USharpBase:OnPropertyChanged", OnPropertyChanged_IsValid);
		IsServiceActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsServiceActive");
		IsServiceActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsServiceActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsServiceActive_ReturnValue_PropertyAddress, IsServiceActive_FunctionAddress, "ReturnValue");
		IsServiceActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsServiceActive_FunctionAddress, "ReturnValue");
		IsServiceActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsServiceActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsServiceActive_IsValid = IsServiceActive_FunctionAddress != IntPtr.Zero && IsServiceActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTService_USharpBase:IsServiceActive", IsServiceActive_IsValid);
		ForceRefreshDetailView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceRefreshDetailView");
		ForceRefreshDetailView_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceRefreshDetailView_FunctionAddress);
		ForceRefreshDetailView_IsValid = ForceRefreshDetailView_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BTService_USharpBase:ForceRefreshDetailView", ForceRefreshDetailView_IsValid);
	}
}
