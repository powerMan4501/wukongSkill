using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.PropertyEditor", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UPropertyEditor : UWidget
{
	private static bool OnChange_IsValid;

	private static int OnChange_Offset;

	private FPropertyEditorPropertyChanged OnChange_DelegateCached;

	private static bool UpdateFromSelection_IsValid;

	private static FFieldAddress UpdateFromSelection_PropertyAddress;

	private static int UpdateFromSelection_Offset;

	private static bool Lockable_IsValid;

	private static FFieldAddress Lockable_PropertyAddress;

	private static int Lockable_Offset;

	private static bool AllowSearch_IsValid;

	private static FFieldAddress AllowSearch_PropertyAddress;

	private static int AllowSearch_Offset;

	private static bool HideSelectionTip_IsValid;

	private static FFieldAddress HideSelectionTip_PropertyAddress;

	private static int HideSelectionTip_Offset;

	private static bool ReadOnly_IsValid;

	private static FFieldAddress ReadOnly_PropertyAddress;

	private static int ReadOnly_Offset;

	private static bool EnablePropertyPath_IsValid;

	private static FFieldAddress EnablePropertyPath_PropertyAddress;

	private static int EnablePropertyPath_Offset;

	private static bool NameAreaSettings_IsValid;

	private static FFieldAddress NameAreaSettings_PropertyAddress;

	private static int NameAreaSettings_Offset;

	private static bool SetObjects_IsValid;

	private static IntPtr SetObjects_FunctionAddress;

	private static int SetObjects_ParamsSize;

	private static bool SetObjects_Objects_IsValid;

	private static FFieldAddress SetObjects_Objects_PropertyAddress;

	private static int SetObjects_Objects_Offset;

	private static bool SetObjects_bForceRefresh_IsValid;

	private static FFieldAddress SetObjects_bForceRefresh_PropertyAddress;

	private static int SetObjects_bForceRefresh_Offset;

	private static bool SetObjects_bOverrideLock_IsValid;

	private static FFieldAddress SetObjects_bOverrideLock_PropertyAddress;

	private static int SetObjects_bOverrideLock_Offset;

	private static bool SetObject_IsValid;

	private static IntPtr SetObject_FunctionAddress;

	private static int SetObject_ParamsSize;

	private static bool SetObject_Object_IsValid;

	private static FFieldAddress SetObject_Object_PropertyAddress;

	private static int SetObject_Object_Offset;

	private static bool SetObject_bForceRefresh_IsValid;

	private static FFieldAddress SetObject_bForceRefresh_PropertyAddress;

	private static int SetObject_bForceRefresh_Offset;

	private static bool IsPropertyVisible_IsValid;

	private IntPtr IsPropertyVisible_InstanceFunctionAddress;

	private static IntPtr IsPropertyVisible_FunctionAddress;

	private static int IsPropertyVisible_ParamsSize;

	private static bool IsPropertyVisible_PropertName_IsValid;

	private static FFieldAddress IsPropertyVisible_PropertName_PropertyAddress;

	private static int IsPropertyVisible_PropertName_Offset;

	private static bool IsPropertyVisible_ParentPropertyName_IsValid;

	private static FFieldAddress IsPropertyVisible_ParentPropertyName_PropertyAddress;

	private static int IsPropertyVisible_ParentPropertyName_Offset;

	private static bool IsPropertyVisible_PropertyPaths_IsValid;

	private static FFieldAddress IsPropertyVisible_PropertyPaths_PropertyAddress;

	private static int IsPropertyVisible_PropertyPaths_Offset;

	private static bool IsPropertyVisible_ReturnValue_IsValid;

	private static FFieldAddress IsPropertyVisible_ReturnValue_PropertyAddress;

	private static int IsPropertyVisible_ReturnValue_Offset;

	private static bool IsPropertyReadOnly_IsValid;

	private IntPtr IsPropertyReadOnly_InstanceFunctionAddress;

	private static IntPtr IsPropertyReadOnly_FunctionAddress;

	private static int IsPropertyReadOnly_ParamsSize;

	private static bool IsPropertyReadOnly_PropertyName_IsValid;

	private static FFieldAddress IsPropertyReadOnly_PropertyName_PropertyAddress;

	private static int IsPropertyReadOnly_PropertyName_Offset;

	private static bool IsPropertyReadOnly_ParentPropertyName_IsValid;

	private static FFieldAddress IsPropertyReadOnly_ParentPropertyName_PropertyAddress;

	private static int IsPropertyReadOnly_ParentPropertyName_Offset;

	private static bool IsPropertyReadOnly_PropertyPaths_IsValid;

	private static FFieldAddress IsPropertyReadOnly_PropertyPaths_PropertyAddress;

	private static int IsPropertyReadOnly_PropertyPaths_Offset;

	private static bool IsPropertyReadOnly_ReturnValue_IsValid;

	private static FFieldAddress IsPropertyReadOnly_ReturnValue_PropertyAddress;

	private static int IsPropertyReadOnly_ReturnValue_Offset;

	private static bool ForceRefresh_IsValid;

	private static IntPtr ForceRefresh_FunctionAddress;

	private static int ForceRefresh_ParamsSize;

	private static bool Destruct_IsValid;

	private IntPtr Destruct_InstanceFunctionAddress;

	private static IntPtr Destruct_FunctionAddress;

	private static int Destruct_ParamsSize;

	private static bool Construct_IsValid;

	private IntPtr Construct_InstanceFunctionAddress;

	private static IntPtr Construct_FunctionAddress;

	private static int Construct_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:OnChange")]
	public FPropertyEditorPropertyChanged OnChange
	{
		get
		{
			CheckDestroyed();
			if (!OnChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:OnChange");
				return new FPropertyEditorPropertyChanged();
			}
			if (OnChange_DelegateCached == null)
			{
				OnChange_DelegateCached = new FPropertyEditorPropertyChanged();
				OnChange_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnChange_Offset));
			}
			return OnChange_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:bUpdateFromSelection")]
	public bool UpdateFromSelection
	{
		get
		{
			CheckDestroyed();
			if (!UpdateFromSelection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bUpdateFromSelection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UpdateFromSelection_Offset), 0, UpdateFromSelection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UpdateFromSelection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bUpdateFromSelection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UpdateFromSelection_Offset), 0, UpdateFromSelection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:bLockable")]
	public bool Lockable
	{
		get
		{
			CheckDestroyed();
			if (!Lockable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bLockable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Lockable_Offset), 0, Lockable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Lockable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bLockable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Lockable_Offset), 0, Lockable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:bAllowSearch")]
	public bool AllowSearch
	{
		get
		{
			CheckDestroyed();
			if (!AllowSearch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bAllowSearch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowSearch_Offset), 0, AllowSearch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowSearch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bAllowSearch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowSearch_Offset), 0, AllowSearch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:bHideSelectionTip")]
	public bool HideSelectionTip
	{
		get
		{
			CheckDestroyed();
			if (!HideSelectionTip_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bHideSelectionTip");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HideSelectionTip_Offset), 0, HideSelectionTip_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HideSelectionTip_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bHideSelectionTip");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HideSelectionTip_Offset), 0, HideSelectionTip_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:bReadOnly")]
	public bool ReadOnly
	{
		get
		{
			CheckDestroyed();
			if (!ReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bReadOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReadOnly_Offset), 0, ReadOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReadOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bReadOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReadOnly_Offset), 0, ReadOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:bEnablePropertyPath")]
	public bool EnablePropertyPath
	{
		get
		{
			CheckDestroyed();
			if (!EnablePropertyPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bEnablePropertyPath");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePropertyPath_Offset), 0, EnablePropertyPath_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePropertyPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:bEnablePropertyPath");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePropertyPath_Offset), 0, EnablePropertyPath_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:NameAreaSettings")]
	public EPropertyEditorNameAreaSettings NameAreaSettings
	{
		get
		{
			CheckDestroyed();
			if (!NameAreaSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:NameAreaSettings");
				return EPropertyEditorNameAreaSettings.HideNameArea;
			}
			return EnumMarshaler<EPropertyEditorNameAreaSettings>.FromNative(IntPtr.Add(base.Address, NameAreaSettings_Offset), 0, NameAreaSettings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NameAreaSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.PropertyEditor:NameAreaSettings");
			}
			else
			{
				EnumMarshaler<EPropertyEditorNameAreaSettings>.ToNative(IntPtr.Add(base.Address, NameAreaSettings_Offset), 0, NameAreaSettings_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:SetObjects")]
	public unsafe void SetObjects(List<UObject> Objects, bool bForceRefresh, bool bOverrideLock)
	{
		CheckDestroyed();
		if (!SetObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:SetObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetObjects_Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetObjects_Objects_Offset), Objects);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetObjects_bForceRefresh_Offset), 0, SetObjects_bForceRefresh_PropertyAddress.Address, bForceRefresh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetObjects_bOverrideLock_Offset), 0, SetObjects_bOverrideLock_PropertyAddress.Address, bOverrideLock);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetObjects_FunctionAddress, intPtr, SetObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetObjects_Objects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:SetObject")]
	public unsafe void SetObject(UObject Object, bool bForceRefresh)
	{
		CheckDestroyed();
		if (!SetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:SetObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetObject_Object_Offset), 0, SetObject_Object_PropertyAddress.Address, Object);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetObject_bForceRefresh_Offset), 0, SetObject_bForceRefresh_PropertyAddress.Address, bForceRefresh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetObject_FunctionAddress, intPtr, SetObject_ParamsSize);
	}

	[UFunction(Flags = 675417088u)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:IsPropertyVisible")]
	public unsafe bool IsPropertyVisible(string PropertName, string ParentPropertyName, List<string> PropertyPaths)
	{
		CheckDestroyed();
		if (!IsPropertyVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:IsPropertyVisible");
			return false;
		}
		if (IsPropertyVisible_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsPropertyVisible_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsPropertyVisible");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPropertyVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPropertyVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPropertyVisible_PropertName_Offset), 0, IsPropertyVisible_PropertName_PropertyAddress.Address, PropertName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPropertyVisible_ParentPropertyName_Offset), 0, IsPropertyVisible_ParentPropertyName_PropertyAddress.Address, ParentPropertyName);
		new TArrayCopyMarshaler<string>(1, IsPropertyVisible_PropertyPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, IsPropertyVisible_PropertyPaths_Offset), PropertyPaths);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPropertyVisible_InstanceFunctionAddress, intPtr, IsPropertyVisible_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsPropertyVisible_PropertName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsPropertyVisible_ParentPropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsPropertyVisible_PropertyPaths_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPropertyVisible_ReturnValue_Offset), 0, IsPropertyVisible_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsPropertyVisible_Implementation(string PropertName, string ParentPropertyName, List<string> PropertyPaths)
	{
		CheckDestroyed();
		if (!IsPropertyVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:IsPropertyVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPropertyVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPropertyVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPropertyVisible_PropertName_Offset), 0, IsPropertyVisible_PropertName_PropertyAddress.Address, PropertName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPropertyVisible_ParentPropertyName_Offset), 0, IsPropertyVisible_ParentPropertyName_PropertyAddress.Address, ParentPropertyName);
		new TArrayCopyMarshaler<string>(1, IsPropertyVisible_PropertyPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, IsPropertyVisible_PropertyPaths_Offset), PropertyPaths);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPropertyVisible_FunctionAddress, intPtr, IsPropertyVisible_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsPropertyVisible_PropertName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsPropertyVisible_ParentPropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsPropertyVisible_PropertyPaths_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPropertyVisible_ReturnValue_Offset), 0, IsPropertyVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 675417088u)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:IsPropertyReadOnly")]
	public unsafe bool IsPropertyReadOnly(string PropertyName, string ParentPropertyName, List<string> PropertyPaths)
	{
		CheckDestroyed();
		if (!IsPropertyReadOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:IsPropertyReadOnly");
			return false;
		}
		if (IsPropertyReadOnly_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsPropertyReadOnly_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsPropertyReadOnly");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPropertyReadOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPropertyReadOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPropertyReadOnly_PropertyName_Offset), 0, IsPropertyReadOnly_PropertyName_PropertyAddress.Address, PropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPropertyReadOnly_ParentPropertyName_Offset), 0, IsPropertyReadOnly_ParentPropertyName_PropertyAddress.Address, ParentPropertyName);
		new TArrayCopyMarshaler<string>(1, IsPropertyReadOnly_PropertyPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, IsPropertyReadOnly_PropertyPaths_Offset), PropertyPaths);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPropertyReadOnly_InstanceFunctionAddress, intPtr, IsPropertyReadOnly_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsPropertyReadOnly_PropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsPropertyReadOnly_ParentPropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsPropertyReadOnly_PropertyPaths_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPropertyReadOnly_ReturnValue_Offset), 0, IsPropertyReadOnly_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsPropertyReadOnly_Implementation(string PropertyName, string ParentPropertyName, List<string> PropertyPaths)
	{
		CheckDestroyed();
		if (!IsPropertyReadOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:IsPropertyReadOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPropertyReadOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPropertyReadOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPropertyReadOnly_PropertyName_Offset), 0, IsPropertyReadOnly_PropertyName_PropertyAddress.Address, PropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPropertyReadOnly_ParentPropertyName_Offset), 0, IsPropertyReadOnly_ParentPropertyName_PropertyAddress.Address, ParentPropertyName);
		new TArrayCopyMarshaler<string>(1, IsPropertyReadOnly_PropertyPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, IsPropertyReadOnly_PropertyPaths_Offset), PropertyPaths);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPropertyReadOnly_FunctionAddress, intPtr, IsPropertyReadOnly_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsPropertyReadOnly_PropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsPropertyReadOnly_ParentPropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsPropertyReadOnly_PropertyPaths_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPropertyReadOnly_ReturnValue_Offset), 0, IsPropertyReadOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:ForceRefresh")]
	public unsafe void ForceRefresh()
	{
		CheckDestroyed();
		if (!ForceRefresh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:ForceRefresh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceRefresh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceRefresh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceRefresh_FunctionAddress, argsSize: ForceRefresh_ParamsSize);
	}

	[UFunction(Flags = 671221768u)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:Destruct")]
	public unsafe void Destruct()
	{
		CheckDestroyed();
		if (!Destruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:Destruct");
			return;
		}
		if (Destruct_InstanceFunctionAddress == IntPtr.Zero)
		{
			Destruct_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Destruct");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destruct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destruct_InstanceFunctionAddress, argsSize: Destruct_ParamsSize);
	}

	protected unsafe virtual void Destruct_Implementation()
	{
		CheckDestroyed();
		if (!Destruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:Destruct");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destruct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destruct_FunctionAddress, argsSize: Destruct_ParamsSize);
	}

	[UFunction(Flags = 671221768u)]
	[UMetaPath("/Script/JavascriptEditor.PropertyEditor:Construct")]
	public unsafe void Construct()
	{
		CheckDestroyed();
		if (!Construct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:Construct");
			return;
		}
		if (Construct_InstanceFunctionAddress == IntPtr.Zero)
		{
			Construct_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Construct");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Construct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Construct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Construct_InstanceFunctionAddress, argsSize: Construct_ParamsSize);
	}

	protected unsafe virtual void Construct_Implementation()
	{
		CheckDestroyed();
		if (!Construct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.PropertyEditor:Construct");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Construct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Construct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Construct_FunctionAddress, argsSize: Construct_ParamsSize);
	}

	static UPropertyEditor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPropertyEditor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPropertyEditor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptEditor.PropertyEditor");
		OnChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnChange");
		OnChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnChange", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateFromSelection_PropertyAddress, intPtr, "bUpdateFromSelection");
		UpdateFromSelection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUpdateFromSelection");
		UpdateFromSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUpdateFromSelection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Lockable_PropertyAddress, intPtr, "bLockable");
		Lockable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLockable");
		Lockable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLockable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSearch_PropertyAddress, intPtr, "bAllowSearch");
		AllowSearch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowSearch");
		AllowSearch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowSearch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HideSelectionTip_PropertyAddress, intPtr, "bHideSelectionTip");
		HideSelectionTip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHideSelectionTip");
		HideSelectionTip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHideSelectionTip", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadOnly_PropertyAddress, intPtr, "bReadOnly");
		ReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReadOnly");
		ReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReadOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnablePropertyPath_PropertyAddress, intPtr, "bEnablePropertyPath");
		EnablePropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnablePropertyPath");
		EnablePropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnablePropertyPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NameAreaSettings_PropertyAddress, intPtr, "NameAreaSettings");
		NameAreaSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NameAreaSettings");
		NameAreaSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NameAreaSettings", Classes.FEnumProperty);
		SetObjects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetObjects");
		SetObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(SetObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetObjects_Objects_PropertyAddress, SetObjects_FunctionAddress, "Objects");
		SetObjects_Objects_Offset = NativeReflectionCached.GetPropertyOffset(SetObjects_FunctionAddress, "Objects");
		SetObjects_Objects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjects_FunctionAddress, "Objects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObjects_bForceRefresh_PropertyAddress, SetObjects_FunctionAddress, "bForceRefresh");
		SetObjects_bForceRefresh_Offset = NativeReflectionCached.GetPropertyOffset(SetObjects_FunctionAddress, "bForceRefresh");
		SetObjects_bForceRefresh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjects_FunctionAddress, "bForceRefresh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObjects_bOverrideLock_PropertyAddress, SetObjects_FunctionAddress, "bOverrideLock");
		SetObjects_bOverrideLock_Offset = NativeReflectionCached.GetPropertyOffset(SetObjects_FunctionAddress, "bOverrideLock");
		SetObjects_bOverrideLock_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjects_FunctionAddress, "bOverrideLock", Classes.FBoolProperty);
		SetObjects_IsValid = SetObjects_FunctionAddress != IntPtr.Zero && SetObjects_Objects_IsValid && SetObjects_bForceRefresh_IsValid && SetObjects_bOverrideLock_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.PropertyEditor:SetObjects", SetObjects_IsValid);
		SetObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetObject");
		SetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetObject_Object_PropertyAddress, SetObject_FunctionAddress, "Object");
		SetObject_Object_Offset = NativeReflectionCached.GetPropertyOffset(SetObject_FunctionAddress, "Object");
		SetObject_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObject_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObject_bForceRefresh_PropertyAddress, SetObject_FunctionAddress, "bForceRefresh");
		SetObject_bForceRefresh_Offset = NativeReflectionCached.GetPropertyOffset(SetObject_FunctionAddress, "bForceRefresh");
		SetObject_bForceRefresh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObject_FunctionAddress, "bForceRefresh", Classes.FBoolProperty);
		SetObject_IsValid = SetObject_FunctionAddress != IntPtr.Zero && SetObject_Object_IsValid && SetObject_bForceRefresh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.PropertyEditor:SetObject", SetObject_IsValid);
		IsPropertyVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPropertyVisible");
		IsPropertyVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPropertyVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPropertyVisible_PropertName_PropertyAddress, IsPropertyVisible_FunctionAddress, "PropertName");
		IsPropertyVisible_PropertName_Offset = NativeReflectionCached.GetPropertyOffset(IsPropertyVisible_FunctionAddress, "PropertName");
		IsPropertyVisible_PropertName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPropertyVisible_FunctionAddress, "PropertName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPropertyVisible_ParentPropertyName_PropertyAddress, IsPropertyVisible_FunctionAddress, "ParentPropertyName");
		IsPropertyVisible_ParentPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(IsPropertyVisible_FunctionAddress, "ParentPropertyName");
		IsPropertyVisible_ParentPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPropertyVisible_FunctionAddress, "ParentPropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPropertyVisible_PropertyPaths_PropertyAddress, IsPropertyVisible_FunctionAddress, "PropertyPaths");
		IsPropertyVisible_PropertyPaths_Offset = NativeReflectionCached.GetPropertyOffset(IsPropertyVisible_FunctionAddress, "PropertyPaths");
		IsPropertyVisible_PropertyPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPropertyVisible_FunctionAddress, "PropertyPaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPropertyVisible_ReturnValue_PropertyAddress, IsPropertyVisible_FunctionAddress, "ReturnValue");
		IsPropertyVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPropertyVisible_FunctionAddress, "ReturnValue");
		IsPropertyVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPropertyVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPropertyVisible_IsValid = IsPropertyVisible_FunctionAddress != IntPtr.Zero && IsPropertyVisible_PropertName_IsValid && IsPropertyVisible_ParentPropertyName_IsValid && IsPropertyVisible_PropertyPaths_IsValid && IsPropertyVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.PropertyEditor:IsPropertyVisible", IsPropertyVisible_IsValid);
		IsPropertyReadOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPropertyReadOnly");
		IsPropertyReadOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPropertyReadOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPropertyReadOnly_PropertyName_PropertyAddress, IsPropertyReadOnly_FunctionAddress, "PropertyName");
		IsPropertyReadOnly_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(IsPropertyReadOnly_FunctionAddress, "PropertyName");
		IsPropertyReadOnly_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPropertyReadOnly_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPropertyReadOnly_ParentPropertyName_PropertyAddress, IsPropertyReadOnly_FunctionAddress, "ParentPropertyName");
		IsPropertyReadOnly_ParentPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(IsPropertyReadOnly_FunctionAddress, "ParentPropertyName");
		IsPropertyReadOnly_ParentPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPropertyReadOnly_FunctionAddress, "ParentPropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPropertyReadOnly_PropertyPaths_PropertyAddress, IsPropertyReadOnly_FunctionAddress, "PropertyPaths");
		IsPropertyReadOnly_PropertyPaths_Offset = NativeReflectionCached.GetPropertyOffset(IsPropertyReadOnly_FunctionAddress, "PropertyPaths");
		IsPropertyReadOnly_PropertyPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPropertyReadOnly_FunctionAddress, "PropertyPaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPropertyReadOnly_ReturnValue_PropertyAddress, IsPropertyReadOnly_FunctionAddress, "ReturnValue");
		IsPropertyReadOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPropertyReadOnly_FunctionAddress, "ReturnValue");
		IsPropertyReadOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPropertyReadOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPropertyReadOnly_IsValid = IsPropertyReadOnly_FunctionAddress != IntPtr.Zero && IsPropertyReadOnly_PropertyName_IsValid && IsPropertyReadOnly_ParentPropertyName_IsValid && IsPropertyReadOnly_PropertyPaths_IsValid && IsPropertyReadOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.PropertyEditor:IsPropertyReadOnly", IsPropertyReadOnly_IsValid);
		ForceRefresh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceRefresh");
		ForceRefresh_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceRefresh_FunctionAddress);
		ForceRefresh_IsValid = ForceRefresh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.PropertyEditor:ForceRefresh", ForceRefresh_IsValid);
		Destruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Destruct");
		Destruct_ParamsSize = NativeReflection.GetFunctionParamsSize(Destruct_FunctionAddress);
		Destruct_IsValid = Destruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.PropertyEditor:Destruct", Destruct_IsValid);
		Construct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Construct");
		Construct_ParamsSize = NativeReflection.GetFunctionParamsSize(Construct_FunctionAddress);
		Construct_IsValid = Construct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.PropertyEditor:Construct", Construct_IsValid);
	}
}
