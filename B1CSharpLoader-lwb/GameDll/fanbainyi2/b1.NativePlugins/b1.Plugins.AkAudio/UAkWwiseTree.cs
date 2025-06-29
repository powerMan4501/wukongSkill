using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035170uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkWwiseTree", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkWwiseTree : UWidget
{
	private static bool OnSelectionChanged_IsValid;

	private static int OnSelectionChanged_Offset;

	private FOnItemSelectionChanged OnSelectionChanged_DelegateCached;

	private static bool OnItemDragged_IsValid;

	private static int OnItemDragged_Offset;

	private FOnItemDragDetected OnItemDragged_DelegateCached;

	private static bool SetSearchText_IsValid;

	private static IntPtr SetSearchText_FunctionAddress;

	private static int SetSearchText_ParamsSize;

	private static bool SetSearchText_newText_IsValid;

	private static FFieldAddress SetSearchText_newText_PropertyAddress;

	private static int SetSearchText_newText_Offset;

	private static bool GetSelectedItem_IsValid;

	private static IntPtr GetSelectedItem_FunctionAddress;

	private static int GetSelectedItem_ParamsSize;

	private static bool GetSelectedItem_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedItem_ReturnValue_PropertyAddress;

	private static int GetSelectedItem_ReturnValue_Offset;

	private static bool GetSearchText_IsValid;

	private static IntPtr GetSearchText_FunctionAddress;

	private static int GetSearchText_ParamsSize;

	private static bool GetSearchText_ReturnValue_IsValid;

	private static FFieldAddress GetSearchText_ReturnValue_PropertyAddress;

	private static int GetSearchText_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkWwiseTree:OnSelectionChanged")]
	public FOnItemSelectionChanged OnSelectionChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnSelectionChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkWwiseTree:OnSelectionChanged");
				return new FOnItemSelectionChanged();
			}
			if (OnSelectionChanged_DelegateCached == null)
			{
				OnSelectionChanged_DelegateCached = new FOnItemSelectionChanged();
				OnSelectionChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSelectionChanged_Offset));
			}
			return OnSelectionChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkWwiseTree:OnItemDragged")]
	public FOnItemDragDetected OnItemDragged
	{
		get
		{
			CheckDestroyed();
			if (!OnItemDragged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkWwiseTree:OnItemDragged");
				return new FOnItemDragDetected();
			}
			if (OnItemDragged_DelegateCached == null)
			{
				OnItemDragged_DelegateCached = new FOnItemDragDetected();
				OnItemDragged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnItemDragged_Offset));
			}
			return OnItemDragged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AkAudio.AkWwiseTree:SetSearchText")]
	public unsafe void SetSearchText(string newText)
	{
		CheckDestroyed();
		if (!SetSearchText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWwiseTree:SetSearchText");
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
	[UMetaPath("/Script/AkAudio.AkWwiseTree:GetSelectedItem")]
	public unsafe FAkWwiseObjectDetails GetSelectedItem()
	{
		CheckDestroyed();
		if (!GetSelectedItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWwiseTree:GetSelectedItem");
			return default(FAkWwiseObjectDetails);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedItem_FunctionAddress, intPtr, GetSelectedItem_ParamsSize);
		FAkWwiseObjectDetails result = FAkWwiseObjectDetails.FromNative(IntPtr.Add(intPtr, GetSelectedItem_ReturnValue_Offset), 0, GetSelectedItem_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSelectedItem_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/AkAudio.AkWwiseTree:GetSearchText")]
	public unsafe string GetSearchText()
	{
		CheckDestroyed();
		if (!GetSearchText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWwiseTree:GetSearchText");
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

	static UAkWwiseTree()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkWwiseTree)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkWwiseTree));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkWwiseTree");
		OnSelectionChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSelectionChanged");
		OnSelectionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSelectionChanged", Classes.FMulticastDelegateProperty);
		OnItemDragged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnItemDragged");
		OnItemDragged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnItemDragged", Classes.FMulticastDelegateProperty);
		SetSearchText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSearchText");
		SetSearchText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSearchText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSearchText_newText_PropertyAddress, SetSearchText_FunctionAddress, "newText");
		SetSearchText_newText_Offset = NativeReflectionCached.GetPropertyOffset(SetSearchText_FunctionAddress, "newText");
		SetSearchText_newText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSearchText_FunctionAddress, "newText", Classes.FStrProperty);
		SetSearchText_IsValid = SetSearchText_FunctionAddress != IntPtr.Zero && SetSearchText_newText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWwiseTree:SetSearchText", SetSearchText_IsValid);
		GetSelectedItem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedItem");
		GetSelectedItem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedItem_ReturnValue_PropertyAddress, GetSelectedItem_FunctionAddress, "ReturnValue");
		GetSelectedItem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedItem_FunctionAddress, "ReturnValue");
		GetSelectedItem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedItem_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSelectedItem_IsValid = GetSelectedItem_FunctionAddress != IntPtr.Zero && GetSelectedItem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWwiseTree:GetSelectedItem", GetSelectedItem_IsValid);
		GetSearchText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSearchText");
		GetSearchText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSearchText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSearchText_ReturnValue_PropertyAddress, GetSearchText_FunctionAddress, "ReturnValue");
		GetSearchText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSearchText_FunctionAddress, "ReturnValue");
		GetSearchText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSearchText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSearchText_IsValid = GetSearchText_FunctionAddress != IntPtr.Zero && GetSearchText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWwiseTree:GetSearchText", GetSearchText_IsValid);
	}
}
