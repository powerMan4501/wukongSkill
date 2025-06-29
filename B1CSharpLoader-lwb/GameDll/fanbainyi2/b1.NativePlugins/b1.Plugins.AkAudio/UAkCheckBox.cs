using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035174uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkCheckBox", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkCheckBox : UContentWidget
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool AkOnCheckStateChanged_IsValid;

	private static int AkOnCheckStateChanged_Offset;

	private FAkOnCheckBoxComponentStateChanged AkOnCheckStateChanged_DelegateCached;

	private static bool OnItemDropped_IsValid;

	private static int OnItemDropped_Offset;

	private FOnWwiseItemDropDetected OnItemDropped_DelegateCached;

	private static bool OnPropertyDropped_IsValid;

	private static int OnPropertyDropped_Offset;

	private FOnBoolPropertyDropDetected OnPropertyDropped_DelegateCached;

	private static bool SetIsChecked_IsValid;

	private static IntPtr SetIsChecked_FunctionAddress;

	private static int SetIsChecked_ParamsSize;

	private static bool SetIsChecked_InIsChecked_IsValid;

	private static FFieldAddress SetIsChecked_InIsChecked_PropertyAddress;

	private static int SetIsChecked_InIsChecked_Offset;

	private static bool SetCheckedState_IsValid;

	private static IntPtr SetCheckedState_FunctionAddress;

	private static int SetCheckedState_ParamsSize;

	private static bool SetCheckedState_InCheckedState_IsValid;

	private static FFieldAddress SetCheckedState_InCheckedState_PropertyAddress;

	private static int SetCheckedState_InCheckedState_Offset;

	private static bool SetAkItemId_IsValid;

	private static IntPtr SetAkItemId_FunctionAddress;

	private static int SetAkItemId_ParamsSize;

	private static bool SetAkItemId_ItemId_IsValid;

	private static FFieldAddress SetAkItemId_ItemId_PropertyAddress;

	private static int SetAkItemId_ItemId_Offset;

	private static bool SetAkBoolProperty_IsValid;

	private static IntPtr SetAkBoolProperty_FunctionAddress;

	private static int SetAkBoolProperty_ParamsSize;

	private static bool SetAkBoolProperty_ItemProperty_IsValid;

	private static FFieldAddress SetAkBoolProperty_ItemProperty_PropertyAddress;

	private static int SetAkBoolProperty_ItemProperty_Offset;

	private static bool IsPressed_IsValid;

	private static IntPtr IsPressed_FunctionAddress;

	private static int IsPressed_ParamsSize;

	private static bool IsPressed_ReturnValue_IsValid;

	private static FFieldAddress IsPressed_ReturnValue_PropertyAddress;

	private static int IsPressed_ReturnValue_Offset;

	private static bool IsChecked_IsValid;

	private static IntPtr IsChecked_FunctionAddress;

	private static int IsChecked_ParamsSize;

	private static bool IsChecked_ReturnValue_IsValid;

	private static FFieldAddress IsChecked_ReturnValue_PropertyAddress;

	private static int IsChecked_ReturnValue_Offset;

	private static bool GetCheckedState_IsValid;

	private static IntPtr GetCheckedState_FunctionAddress;

	private static int GetCheckedState_ParamsSize;

	private static bool GetCheckedState_ReturnValue_IsValid;

	private static FFieldAddress GetCheckedState_ReturnValue_PropertyAddress;

	private static int GetCheckedState_ReturnValue_Offset;

	private static bool GetAkProperty_IsValid;

	private static IntPtr GetAkProperty_FunctionAddress;

	private static int GetAkProperty_ParamsSize;

	private static bool GetAkProperty_ReturnValue_IsValid;

	private static FFieldAddress GetAkProperty_ReturnValue_PropertyAddress;

	private static int GetAkProperty_ReturnValue_Offset;

	private static bool GetAkItemId_IsValid;

	private static IntPtr GetAkItemId_FunctionAddress;

	private static int GetAkItemId_ParamsSize;

	private static bool GetAkItemId_ReturnValue_IsValid;

	private static FFieldAddress GetAkItemId_ReturnValue_PropertyAddress;

	private static int GetAkItemId_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:WidgetStyle")]
	public FCheckBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:WidgetStyle");
				return default(FCheckBoxStyle);
			}
			return FCheckBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:WidgetStyle");
			}
			else
			{
				FCheckBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:IsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:IsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:IsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:AkOnCheckStateChanged")]
	public FAkOnCheckBoxComponentStateChanged AkOnCheckStateChanged
	{
		get
		{
			CheckDestroyed();
			if (!AkOnCheckStateChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:AkOnCheckStateChanged");
				return new FAkOnCheckBoxComponentStateChanged();
			}
			if (AkOnCheckStateChanged_DelegateCached == null)
			{
				AkOnCheckStateChanged_DelegateCached = new FAkOnCheckBoxComponentStateChanged();
				AkOnCheckStateChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, AkOnCheckStateChanged_Offset));
			}
			return AkOnCheckStateChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:OnItemDropped")]
	public FOnWwiseItemDropDetected OnItemDropped
	{
		get
		{
			CheckDestroyed();
			if (!OnItemDropped_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:OnItemDropped");
				return new FOnWwiseItemDropDetected();
			}
			if (OnItemDropped_DelegateCached == null)
			{
				OnItemDropped_DelegateCached = new FOnWwiseItemDropDetected();
				OnItemDropped_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnItemDropped_Offset));
			}
			return OnItemDropped_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:OnPropertyDropped")]
	public FOnBoolPropertyDropDetected OnPropertyDropped
	{
		get
		{
			CheckDestroyed();
			if (!OnPropertyDropped_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCheckBox:OnPropertyDropped");
				return new FOnBoolPropertyDropDetected();
			}
			if (OnPropertyDropped_DelegateCached == null)
			{
				OnPropertyDropped_DelegateCached = new FOnBoolPropertyDropDetected();
				OnPropertyDropped_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPropertyDropped_Offset));
			}
			return OnPropertyDropped_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:SetIsChecked")]
	public unsafe void SetIsChecked(bool InIsChecked)
	{
		CheckDestroyed();
		if (!SetIsChecked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:SetIsChecked");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsChecked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsChecked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsChecked_InIsChecked_Offset), 0, SetIsChecked_InIsChecked_PropertyAddress.Address, InIsChecked);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsChecked_FunctionAddress, intPtr, SetIsChecked_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:SetCheckedState")]
	public unsafe void SetCheckedState(ECheckBoxState InCheckedState)
	{
		CheckDestroyed();
		if (!SetCheckedState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:SetCheckedState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCheckedState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCheckedState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECheckBoxState>.ToNative(IntPtr.Add(intPtr, SetCheckedState_InCheckedState_Offset), 0, SetCheckedState_InCheckedState_PropertyAddress.Address, InCheckedState);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCheckedState_FunctionAddress, intPtr, SetCheckedState_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:SetAkItemId")]
	public unsafe void SetAkItemId(Guid ItemId)
	{
		CheckDestroyed();
		if (!SetAkItemId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:SetAkItemId");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAkItemId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAkItemId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, SetAkItemId_ItemId_Offset), 0, SetAkItemId_ItemId_PropertyAddress.Address, ItemId);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAkItemId_FunctionAddress, intPtr, SetAkItemId_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:SetAkBoolProperty")]
	public unsafe void SetAkBoolProperty(string ItemProperty)
	{
		CheckDestroyed();
		if (!SetAkBoolProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:SetAkBoolProperty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAkBoolProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAkBoolProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetAkBoolProperty_ItemProperty_Offset), 0, SetAkBoolProperty_ItemProperty_PropertyAddress.Address, ItemProperty);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAkBoolProperty_FunctionAddress, intPtr, SetAkBoolProperty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAkBoolProperty_ItemProperty_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:IsPressed")]
	public unsafe bool IsPressed()
	{
		CheckDestroyed();
		if (!IsPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:IsPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPressed_FunctionAddress, intPtr, IsPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPressed_ReturnValue_Offset), 0, IsPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:IsChecked")]
	public unsafe bool IsChecked()
	{
		CheckDestroyed();
		if (!IsChecked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:IsChecked");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsChecked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsChecked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsChecked_FunctionAddress, intPtr, IsChecked_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsChecked_ReturnValue_Offset), 0, IsChecked_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:GetCheckedState")]
	public unsafe ECheckBoxState GetCheckedState()
	{
		CheckDestroyed();
		if (!GetCheckedState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:GetCheckedState");
			return ECheckBoxState.Unchecked;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCheckedState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCheckedState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCheckedState_FunctionAddress, intPtr, GetCheckedState_ParamsSize);
		return EnumMarshaler<ECheckBoxState>.FromNative(IntPtr.Add(intPtr, GetCheckedState_ReturnValue_Offset), 0, GetCheckedState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:GetAkProperty")]
	public unsafe string GetAkProperty()
	{
		CheckDestroyed();
		if (!GetAkProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:GetAkProperty");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAkProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAkProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAkProperty_FunctionAddress, intPtr, GetAkProperty_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAkProperty_ReturnValue_Offset), 0, GetAkProperty_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAkProperty_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/AkAudio.AkCheckBox:GetAkItemId")]
	public unsafe Guid GetAkItemId()
	{
		CheckDestroyed();
		if (!GetAkItemId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkCheckBox:GetAkItemId");
			return default(Guid);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAkItemId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAkItemId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAkItemId_FunctionAddress, intPtr, GetAkItemId_ParamsSize);
		return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(intPtr, GetAkItemId_ReturnValue_Offset), 0, GetAkItemId_ReturnValue_PropertyAddress.Address);
	}

	static UAkCheckBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkCheckBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkCheckBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkCheckBox");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, intPtr, "IsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsFocusable", Classes.FBoolProperty);
		AkOnCheckStateChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AkOnCheckStateChanged");
		AkOnCheckStateChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AkOnCheckStateChanged", Classes.FMulticastDelegateProperty);
		OnItemDropped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnItemDropped");
		OnItemDropped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnItemDropped", Classes.FMulticastDelegateProperty);
		OnPropertyDropped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPropertyDropped");
		OnPropertyDropped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPropertyDropped", Classes.FMulticastDelegateProperty);
		SetIsChecked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsChecked");
		SetIsChecked_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsChecked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsChecked_InIsChecked_PropertyAddress, SetIsChecked_FunctionAddress, "InIsChecked");
		SetIsChecked_InIsChecked_Offset = NativeReflectionCached.GetPropertyOffset(SetIsChecked_FunctionAddress, "InIsChecked");
		SetIsChecked_InIsChecked_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsChecked_FunctionAddress, "InIsChecked", Classes.FBoolProperty);
		SetIsChecked_IsValid = SetIsChecked_FunctionAddress != IntPtr.Zero && SetIsChecked_InIsChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:SetIsChecked", SetIsChecked_IsValid);
		SetCheckedState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCheckedState");
		SetCheckedState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCheckedState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCheckedState_InCheckedState_PropertyAddress, SetCheckedState_FunctionAddress, "InCheckedState");
		SetCheckedState_InCheckedState_Offset = NativeReflectionCached.GetPropertyOffset(SetCheckedState_FunctionAddress, "InCheckedState");
		SetCheckedState_InCheckedState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCheckedState_FunctionAddress, "InCheckedState", Classes.FEnumProperty);
		SetCheckedState_IsValid = SetCheckedState_FunctionAddress != IntPtr.Zero && SetCheckedState_InCheckedState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:SetCheckedState", SetCheckedState_IsValid);
		SetAkItemId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAkItemId");
		SetAkItemId_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAkItemId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAkItemId_ItemId_PropertyAddress, SetAkItemId_FunctionAddress, "ItemId");
		SetAkItemId_ItemId_Offset = NativeReflectionCached.GetPropertyOffset(SetAkItemId_FunctionAddress, "ItemId");
		SetAkItemId_ItemId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAkItemId_FunctionAddress, "ItemId", Classes.FStructProperty);
		SetAkItemId_IsValid = SetAkItemId_FunctionAddress != IntPtr.Zero && SetAkItemId_ItemId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:SetAkItemId", SetAkItemId_IsValid);
		SetAkBoolProperty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAkBoolProperty");
		SetAkBoolProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAkBoolProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAkBoolProperty_ItemProperty_PropertyAddress, SetAkBoolProperty_FunctionAddress, "ItemProperty");
		SetAkBoolProperty_ItemProperty_Offset = NativeReflectionCached.GetPropertyOffset(SetAkBoolProperty_FunctionAddress, "ItemProperty");
		SetAkBoolProperty_ItemProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAkBoolProperty_FunctionAddress, "ItemProperty", Classes.FStrProperty);
		SetAkBoolProperty_IsValid = SetAkBoolProperty_FunctionAddress != IntPtr.Zero && SetAkBoolProperty_ItemProperty_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:SetAkBoolProperty", SetAkBoolProperty_IsValid);
		IsPressed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPressed");
		IsPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPressed_ReturnValue_PropertyAddress, IsPressed_FunctionAddress, "ReturnValue");
		IsPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPressed_FunctionAddress, "ReturnValue");
		IsPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPressed_IsValid = IsPressed_FunctionAddress != IntPtr.Zero && IsPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:IsPressed", IsPressed_IsValid);
		IsChecked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsChecked");
		IsChecked_ParamsSize = NativeReflection.GetFunctionParamsSize(IsChecked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsChecked_ReturnValue_PropertyAddress, IsChecked_FunctionAddress, "ReturnValue");
		IsChecked_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsChecked_FunctionAddress, "ReturnValue");
		IsChecked_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsChecked_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsChecked_IsValid = IsChecked_FunctionAddress != IntPtr.Zero && IsChecked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:IsChecked", IsChecked_IsValid);
		GetCheckedState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCheckedState");
		GetCheckedState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCheckedState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCheckedState_ReturnValue_PropertyAddress, GetCheckedState_FunctionAddress, "ReturnValue");
		GetCheckedState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCheckedState_FunctionAddress, "ReturnValue");
		GetCheckedState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCheckedState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCheckedState_IsValid = GetCheckedState_FunctionAddress != IntPtr.Zero && GetCheckedState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:GetCheckedState", GetCheckedState_IsValid);
		GetAkProperty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAkProperty");
		GetAkProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAkProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAkProperty_ReturnValue_PropertyAddress, GetAkProperty_FunctionAddress, "ReturnValue");
		GetAkProperty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAkProperty_FunctionAddress, "ReturnValue");
		GetAkProperty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkProperty_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAkProperty_IsValid = GetAkProperty_FunctionAddress != IntPtr.Zero && GetAkProperty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:GetAkProperty", GetAkProperty_IsValid);
		GetAkItemId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAkItemId");
		GetAkItemId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAkItemId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAkItemId_ReturnValue_PropertyAddress, GetAkItemId_FunctionAddress, "ReturnValue");
		GetAkItemId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAkItemId_FunctionAddress, "ReturnValue");
		GetAkItemId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkItemId_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAkItemId_IsValid = GetAkItemId_FunctionAddress != IntPtr.Zero && GetAkItemId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkCheckBox:GetAkItemId", GetAkItemId_IsValid);
	}
}
