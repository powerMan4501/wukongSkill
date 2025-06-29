using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035170uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkItemBoolProperties", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkItemBoolProperties : UWidget
{
	private static bool OnSelectionChanged_IsValid;

	private static int OnSelectionChanged_Offset;

	private FOnItemBoolPropertySelectionChanged OnSelectionChanged_DelegateCached;

	private static bool OnPropertyDragged_IsValid;

	private static int OnPropertyDragged_Offset;

	private FOnItemBoolPropertyDragDetected OnPropertyDragged_DelegateCached;

	private static bool SetSearchText_IsValid;

	private static IntPtr SetSearchText_FunctionAddress;

	private static int SetSearchText_ParamsSize;

	private static bool SetSearchText_newText_IsValid;

	private static FFieldAddress SetSearchText_newText_PropertyAddress;

	private static int SetSearchText_newText_Offset;

	private static bool GetSelectedProperty_IsValid;

	private static IntPtr GetSelectedProperty_FunctionAddress;

	private static int GetSelectedProperty_ParamsSize;

	private static bool GetSelectedProperty_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedProperty_ReturnValue_PropertyAddress;

	private static int GetSelectedProperty_ReturnValue_Offset;

	private static bool GetSearchText_IsValid;

	private static IntPtr GetSearchText_FunctionAddress;

	private static int GetSearchText_ParamsSize;

	private static bool GetSearchText_ReturnValue_IsValid;

	private static FFieldAddress GetSearchText_ReturnValue_PropertyAddress;

	private static int GetSearchText_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkItemBoolProperties:OnSelectionChanged")]
	public FOnItemBoolPropertySelectionChanged OnSelectionChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnSelectionChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkItemBoolProperties:OnSelectionChanged");
				return new FOnItemBoolPropertySelectionChanged();
			}
			if (OnSelectionChanged_DelegateCached == null)
			{
				OnSelectionChanged_DelegateCached = new FOnItemBoolPropertySelectionChanged();
				OnSelectionChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSelectionChanged_Offset));
			}
			return OnSelectionChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkItemBoolProperties:OnPropertyDragged")]
	public FOnItemBoolPropertyDragDetected OnPropertyDragged
	{
		get
		{
			CheckDestroyed();
			if (!OnPropertyDragged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkItemBoolProperties:OnPropertyDragged");
				return new FOnItemBoolPropertyDragDetected();
			}
			if (OnPropertyDragged_DelegateCached == null)
			{
				OnPropertyDragged_DelegateCached = new FOnItemBoolPropertyDragDetected();
				OnPropertyDragged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPropertyDragged_Offset));
			}
			return OnPropertyDragged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkItemBoolProperties:SetSearchText")]
	public unsafe void SetSearchText(string newText)
	{
		CheckDestroyed();
		if (!SetSearchText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkItemBoolProperties:SetSearchText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSearchText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSearchText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSearchText_newText_Offset), 0, SetSearchText_newText_PropertyAddress.Address, newText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSearchText_FunctionAddress, intPtr, SetSearchText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSearchText_newText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/AkAudio.AkItemBoolProperties:GetSelectedProperty")]
	public unsafe string GetSelectedProperty()
	{
		CheckDestroyed();
		if (!GetSelectedProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkItemBoolProperties:GetSelectedProperty");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedProperty_FunctionAddress, intPtr, GetSelectedProperty_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSelectedProperty_ReturnValue_Offset), 0, GetSelectedProperty_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSelectedProperty_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/AkAudio.AkItemBoolProperties:GetSearchText")]
	public unsafe string GetSearchText()
	{
		CheckDestroyed();
		if (!GetSearchText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkItemBoolProperties:GetSearchText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSearchText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSearchText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSearchText_FunctionAddress, intPtr, GetSearchText_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSearchText_ReturnValue_Offset), 0, GetSearchText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSearchText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAkItemBoolProperties()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkItemBoolProperties)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkItemBoolProperties));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkItemBoolProperties");
		OnSelectionChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSelectionChanged");
		OnSelectionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSelectionChanged", Classes.FMulticastDelegateProperty);
		OnPropertyDragged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPropertyDragged");
		OnPropertyDragged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPropertyDragged", Classes.FMulticastDelegateProperty);
		SetSearchText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSearchText");
		SetSearchText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSearchText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSearchText_newText_PropertyAddress, SetSearchText_FunctionAddress, "newText");
		SetSearchText_newText_Offset = NativeReflectionCached.GetPropertyOffset(SetSearchText_FunctionAddress, "newText");
		SetSearchText_newText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSearchText_FunctionAddress, "newText", Classes.FStrProperty);
		SetSearchText_IsValid = SetSearchText_FunctionAddress != IntPtr.Zero && SetSearchText_newText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkItemBoolProperties:SetSearchText", SetSearchText_IsValid);
		GetSelectedProperty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedProperty");
		GetSelectedProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedProperty_ReturnValue_PropertyAddress, GetSelectedProperty_FunctionAddress, "ReturnValue");
		GetSelectedProperty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedProperty_FunctionAddress, "ReturnValue");
		GetSelectedProperty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedProperty_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSelectedProperty_IsValid = GetSelectedProperty_FunctionAddress != IntPtr.Zero && GetSelectedProperty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkItemBoolProperties:GetSelectedProperty", GetSelectedProperty_IsValid);
		GetSearchText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSearchText");
		GetSearchText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSearchText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSearchText_ReturnValue_PropertyAddress, GetSearchText_FunctionAddress, "ReturnValue");
		GetSearchText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSearchText_FunctionAddress, "ReturnValue");
		GetSearchText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSearchText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSearchText_IsValid = GetSearchText_FunctionAddress != IntPtr.Zero && GetSearchText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkItemBoolProperties:GetSearchText", GetSearchText_IsValid);
	}
}
