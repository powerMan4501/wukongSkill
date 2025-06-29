using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace UnrealEngine.UMGEditor;

[Abstract]
[UClass(Flags = (ClassFlags)821035169uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMGEditor.PropertyViewBase", "UMGEditor", UnrealModuleType.Engine)]
public class UPropertyViewBase : UWidget
{
	private static bool OnPropertyChanged_IsValid;

	private static int OnPropertyChanged_Offset;

	private FOnPropertyValueChanged OnPropertyChanged_DelegateCached;

	private static bool SetObject_IsValid;

	private static IntPtr SetObject_FunctionAddress;

	private static int SetObject_ParamsSize;

	private static bool SetObject_NewObject_IsValid;

	private static FFieldAddress SetObject_NewObject_PropertyAddress;

	private static int SetObject_NewObject_Offset;

	private static bool GetObject_IsValid;

	private static IntPtr GetObject_FunctionAddress;

	private static int GetObject_ParamsSize;

	private static bool GetObject_ReturnValue_IsValid;

	private static FFieldAddress GetObject_ReturnValue_PropertyAddress;

	private static int GetObject_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/UMGEditor.PropertyViewBase:OnPropertyChanged")]
	protected FOnPropertyValueChanged OnPropertyChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnPropertyChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMGEditor.PropertyViewBase:OnPropertyChanged");
				return new FOnPropertyValueChanged();
			}
			if (OnPropertyChanged_DelegateCached == null)
			{
				OnPropertyChanged_DelegateCached = new FOnPropertyValueChanged();
				OnPropertyChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPropertyChanged_Offset));
			}
			return OnPropertyChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGEditor.PropertyViewBase:SetObject")]
	public unsafe void SetObject(UObject NewObject)
	{
		CheckDestroyed();
		if (!SetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGEditor.PropertyViewBase:SetObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetObject_NewObject_Offset), 0, SetObject_NewObject_PropertyAddress.Address, NewObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetObject_FunctionAddress, intPtr, SetObject_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGEditor.PropertyViewBase:GetObject")]
	public new unsafe UObject GetObject()
	{
		CheckDestroyed();
		if (!GetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGEditor.PropertyViewBase:GetObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetObject_FunctionAddress, intPtr, GetObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObject_ReturnValue_Offset), 0, GetObject_ReturnValue_PropertyAddress.Address);
	}

	static UPropertyViewBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPropertyViewBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPropertyViewBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMGEditor.PropertyViewBase");
		OnPropertyChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPropertyChanged");
		OnPropertyChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPropertyChanged", Classes.FMulticastDelegateProperty);
		SetObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetObject");
		SetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetObject_NewObject_PropertyAddress, SetObject_FunctionAddress, "NewObject");
		SetObject_NewObject_Offset = NativeReflectionCached.GetPropertyOffset(SetObject_FunctionAddress, "NewObject");
		SetObject_NewObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObject_FunctionAddress, "NewObject", Classes.FObjectProperty);
		SetObject_IsValid = SetObject_FunctionAddress != IntPtr.Zero && SetObject_NewObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGEditor.PropertyViewBase:SetObject", SetObject_IsValid);
		GetObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetObject");
		GetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObject_ReturnValue_PropertyAddress, GetObject_FunctionAddress, "ReturnValue");
		GetObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObject_FunctionAddress, "ReturnValue");
		GetObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetObject_IsValid = GetObject_FunctionAddress != IntPtr.Zero && GetObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGEditor.PropertyViewBase:GetObject", GetObject_IsValid);
	}
}
