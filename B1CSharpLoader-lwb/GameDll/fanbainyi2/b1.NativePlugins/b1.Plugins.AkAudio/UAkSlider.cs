using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035174uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkSlider", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkSlider : UWidget
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool Orientation_IsValid;

	private static FFieldAddress Orientation_PropertyAddress;

	private static int Orientation_Offset;

	private static bool SliderBarColor_IsValid;

	private static int SliderBarColor_Offset;

	private static bool SliderHandleColor_IsValid;

	private static int SliderHandleColor_Offset;

	private static bool IndentHandle_IsValid;

	private static FFieldAddress IndentHandle_PropertyAddress;

	private static int IndentHandle_Offset;

	private static bool Locked_IsValid;

	private static FFieldAddress Locked_PropertyAddress;

	private static int Locked_Offset;

	private static bool StepSize_IsValid;

	private static int StepSize_Offset;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool OnValueChanged_IsValid;

	private static int OnValueChanged_Offset;

	private FAkOnFloatValueChangedEvent OnValueChanged_DelegateCached;

	private static bool OnItemDropped_IsValid;

	private static int OnItemDropped_Offset;

	private FOnItemDropDetected OnItemDropped_DelegateCached;

	private static bool OnPropertyDropped_IsValid;

	private static int OnPropertyDropped_Offset;

	private FOnPropertyDropDetected OnPropertyDropped_DelegateCached;

	private static bool SetValue_IsValid;

	private static IntPtr SetValue_FunctionAddress;

	private static int SetValue_ParamsSize;

	private static bool SetValue_InValue_IsValid;

	private static FFieldAddress SetValue_InValue_PropertyAddress;

	private static int SetValue_InValue_Offset;

	private static bool SetStepSize_IsValid;

	private static IntPtr SetStepSize_FunctionAddress;

	private static int SetStepSize_ParamsSize;

	private static bool SetStepSize_InValue_IsValid;

	private static FFieldAddress SetStepSize_InValue_PropertyAddress;

	private static int SetStepSize_InValue_Offset;

	private static bool SetSliderHandleColor_IsValid;

	private static IntPtr SetSliderHandleColor_FunctionAddress;

	private static int SetSliderHandleColor_ParamsSize;

	private static bool SetSliderHandleColor_InValue_IsValid;

	private static FFieldAddress SetSliderHandleColor_InValue_PropertyAddress;

	private static int SetSliderHandleColor_InValue_Offset;

	private static bool SetSliderBarColor_IsValid;

	private static IntPtr SetSliderBarColor_FunctionAddress;

	private static int SetSliderBarColor_ParamsSize;

	private static bool SetSliderBarColor_InValue_IsValid;

	private static FFieldAddress SetSliderBarColor_InValue_PropertyAddress;

	private static int SetSliderBarColor_InValue_Offset;

	private static bool SetLocked_IsValid;

	private static IntPtr SetLocked_FunctionAddress;

	private static int SetLocked_ParamsSize;

	private static bool SetLocked_InValue_IsValid;

	private static FFieldAddress SetLocked_InValue_PropertyAddress;

	private static int SetLocked_InValue_Offset;

	private static bool SetIndentHandle_IsValid;

	private static IntPtr SetIndentHandle_FunctionAddress;

	private static int SetIndentHandle_ParamsSize;

	private static bool SetIndentHandle_InValue_IsValid;

	private static FFieldAddress SetIndentHandle_InValue_PropertyAddress;

	private static int SetIndentHandle_InValue_Offset;

	private static bool SetAkSliderItemProperty_IsValid;

	private static IntPtr SetAkSliderItemProperty_FunctionAddress;

	private static int SetAkSliderItemProperty_ParamsSize;

	private static bool SetAkSliderItemProperty_ItemProperty_IsValid;

	private static FFieldAddress SetAkSliderItemProperty_ItemProperty_PropertyAddress;

	private static int SetAkSliderItemProperty_ItemProperty_Offset;

	private static bool SetAkSliderItemId_IsValid;

	private static IntPtr SetAkSliderItemId_FunctionAddress;

	private static int SetAkSliderItemId_ParamsSize;

	private static bool SetAkSliderItemId_ItemId_IsValid;

	private static FFieldAddress SetAkSliderItemId_ItemId_PropertyAddress;

	private static int SetAkSliderItemId_ItemId_Offset;

	private static bool GetValue_IsValid;

	private static IntPtr GetValue_FunctionAddress;

	private static int GetValue_ParamsSize;

	private static bool GetValue_ReturnValue_IsValid;

	private static FFieldAddress GetValue_ReturnValue_PropertyAddress;

	private static int GetValue_ReturnValue_Offset;

	private static bool GetAkSliderItemProperty_IsValid;

	private static IntPtr GetAkSliderItemProperty_FunctionAddress;

	private static int GetAkSliderItemProperty_ParamsSize;

	private static bool GetAkSliderItemProperty_ReturnValue_IsValid;

	private static FFieldAddress GetAkSliderItemProperty_ReturnValue_PropertyAddress;

	private static int GetAkSliderItemProperty_ReturnValue_Offset;

	private static bool GetAkSliderItemId_IsValid;

	private static IntPtr GetAkSliderItemId_FunctionAddress;

	private static int GetAkSliderItemId_ParamsSize;

	private static bool GetAkSliderItemId_ReturnValue_IsValid;

	private static FFieldAddress GetAkSliderItemId_ReturnValue_PropertyAddress;

	private static int GetAkSliderItemId_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:WidgetStyle")]
	public FSliderStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:WidgetStyle");
				return default(FSliderStyle);
			}
			return FSliderStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:WidgetStyle");
			}
			else
			{
				FSliderStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:Orientation")]
	public EOrientation Orientation
	{
		get
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:Orientation");
				return EOrientation.Orient_Horizontal;
			}
			return EnumMarshaler<EOrientation>.FromNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:Orientation");
			}
			else
			{
				EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:SliderBarColor")]
	public FLinearColor SliderBarColor
	{
		get
		{
			CheckDestroyed();
			if (!SliderBarColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:SliderBarColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SliderBarColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderBarColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:SliderBarColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SliderBarColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:SliderHandleColor")]
	public FLinearColor SliderHandleColor
	{
		get
		{
			CheckDestroyed();
			if (!SliderHandleColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:SliderHandleColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SliderHandleColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderHandleColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:SliderHandleColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SliderHandleColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:IndentHandle")]
	public bool IndentHandle
	{
		get
		{
			CheckDestroyed();
			if (!IndentHandle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:IndentHandle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IndentHandle_Offset), 0, IndentHandle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IndentHandle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:IndentHandle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IndentHandle_Offset), 0, IndentHandle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:Locked")]
	public bool Locked
	{
		get
		{
			CheckDestroyed();
			if (!Locked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:Locked");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Locked_Offset), 0, Locked_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Locked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:Locked");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Locked_Offset), 0, Locked_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:StepSize")]
	public float StepSize
	{
		get
		{
			CheckDestroyed();
			if (!StepSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:StepSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StepSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StepSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:StepSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StepSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:IsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:IsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:IsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:OnValueChanged")]
	public FAkOnFloatValueChangedEvent OnValueChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnValueChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:OnValueChanged");
				return new FAkOnFloatValueChangedEvent();
			}
			if (OnValueChanged_DelegateCached == null)
			{
				OnValueChanged_DelegateCached = new FAkOnFloatValueChangedEvent();
				OnValueChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnValueChanged_Offset));
			}
			return OnValueChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:OnItemDropped")]
	public FOnItemDropDetected OnItemDropped
	{
		get
		{
			CheckDestroyed();
			if (!OnItemDropped_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:OnItemDropped");
				return new FOnItemDropDetected();
			}
			if (OnItemDropped_DelegateCached == null)
			{
				OnItemDropped_DelegateCached = new FOnItemDropDetected();
				OnItemDropped_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnItemDropped_Offset));
			}
			return OnItemDropped_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkSlider:OnPropertyDropped")]
	public FOnPropertyDropDetected OnPropertyDropped
	{
		get
		{
			CheckDestroyed();
			if (!OnPropertyDropped_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSlider:OnPropertyDropped");
				return new FOnPropertyDropDetected();
			}
			if (OnPropertyDropped_DelegateCached == null)
			{
				OnPropertyDropped_DelegateCached = new FOnPropertyDropDetected();
				OnPropertyDropped_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPropertyDropped_Offset));
			}
			return OnPropertyDropped_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSlider:SetValue")]
	public unsafe void SetValue(float InValue)
	{
		CheckDestroyed();
		if (!SetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:SetValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetValue_InValue_Offset), 0, SetValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValue_FunctionAddress, intPtr, SetValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSlider:SetStepSize")]
	public unsafe void SetStepSize(float InValue)
	{
		CheckDestroyed();
		if (!SetStepSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:SetStepSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStepSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStepSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStepSize_InValue_Offset), 0, SetStepSize_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStepSize_FunctionAddress, intPtr, SetStepSize_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/AkAudio.AkSlider:SetSliderHandleColor")]
	public unsafe void SetSliderHandleColor(FLinearColor InValue)
	{
		CheckDestroyed();
		if (!SetSliderHandleColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:SetSliderHandleColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSliderHandleColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSliderHandleColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetSliderHandleColor_InValue_Offset), 0, SetSliderHandleColor_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSliderHandleColor_FunctionAddress, intPtr, SetSliderHandleColor_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/AkAudio.AkSlider:SetSliderBarColor")]
	public unsafe void SetSliderBarColor(FLinearColor InValue)
	{
		CheckDestroyed();
		if (!SetSliderBarColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:SetSliderBarColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSliderBarColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSliderBarColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetSliderBarColor_InValue_Offset), 0, SetSliderBarColor_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSliderBarColor_FunctionAddress, intPtr, SetSliderBarColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSlider:SetLocked")]
	public unsafe void SetLocked(bool InValue)
	{
		CheckDestroyed();
		if (!SetLocked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:SetLocked");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocked_InValue_Offset), 0, SetLocked_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocked_FunctionAddress, intPtr, SetLocked_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSlider:SetIndentHandle")]
	public unsafe void SetIndentHandle(bool InValue)
	{
		CheckDestroyed();
		if (!SetIndentHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:SetIndentHandle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIndentHandle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIndentHandle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIndentHandle_InValue_Offset), 0, SetIndentHandle_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIndentHandle_FunctionAddress, intPtr, SetIndentHandle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSlider:SetAkSliderItemProperty")]
	public unsafe void SetAkSliderItemProperty(string ItemProperty)
	{
		CheckDestroyed();
		if (!SetAkSliderItemProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:SetAkSliderItemProperty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAkSliderItemProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAkSliderItemProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetAkSliderItemProperty_ItemProperty_Offset), 0, SetAkSliderItemProperty_ItemProperty_PropertyAddress.Address, ItemProperty);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAkSliderItemProperty_FunctionAddress, intPtr, SetAkSliderItemProperty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAkSliderItemProperty_ItemProperty_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/AkAudio.AkSlider:SetAkSliderItemId")]
	public unsafe void SetAkSliderItemId(Guid ItemId)
	{
		CheckDestroyed();
		if (!SetAkSliderItemId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:SetAkSliderItemId");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAkSliderItemId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAkSliderItemId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, SetAkSliderItemId_ItemId_Offset), 0, SetAkSliderItemId_ItemId_PropertyAddress.Address, ItemId);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAkSliderItemId_FunctionAddress, intPtr, SetAkSliderItemId_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkSlider:GetValue")]
	public unsafe float GetValue()
	{
		CheckDestroyed();
		if (!GetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:GetValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValue_FunctionAddress, intPtr, GetValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetValue_ReturnValue_Offset), 0, GetValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkSlider:GetAkSliderItemProperty")]
	public unsafe string GetAkSliderItemProperty()
	{
		CheckDestroyed();
		if (!GetAkSliderItemProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:GetAkSliderItemProperty");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAkSliderItemProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAkSliderItemProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAkSliderItemProperty_FunctionAddress, intPtr, GetAkSliderItemProperty_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAkSliderItemProperty_ReturnValue_Offset), 0, GetAkSliderItemProperty_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAkSliderItemProperty_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/AkAudio.AkSlider:GetAkSliderItemId")]
	public unsafe Guid GetAkSliderItemId()
	{
		CheckDestroyed();
		if (!GetAkSliderItemId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSlider:GetAkSliderItemId");
			return default(Guid);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAkSliderItemId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAkSliderItemId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAkSliderItemId_FunctionAddress, intPtr, GetAkSliderItemId_ParamsSize);
		return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(intPtr, GetAkSliderItemId_ReturnValue_Offset), 0, GetAkSliderItemId_ReturnValue_PropertyAddress.Address);
	}

	static UAkSlider()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkSlider)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkSlider));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkSlider");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Orientation_PropertyAddress, intPtr, "Orientation");
		Orientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Orientation");
		Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Orientation", Classes.FByteProperty);
		SliderBarColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SliderBarColor");
		SliderBarColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SliderBarColor", Classes.FStructProperty);
		SliderHandleColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SliderHandleColor");
		SliderHandleColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SliderHandleColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IndentHandle_PropertyAddress, intPtr, "IndentHandle");
		IndentHandle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndentHandle");
		IndentHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndentHandle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Locked_PropertyAddress, intPtr, "Locked");
		Locked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Locked");
		Locked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Locked", Classes.FBoolProperty);
		StepSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StepSize");
		StepSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StepSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, intPtr, "IsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsFocusable", Classes.FBoolProperty);
		OnValueChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnValueChanged");
		OnValueChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnValueChanged", Classes.FMulticastDelegateProperty);
		OnItemDropped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnItemDropped");
		OnItemDropped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnItemDropped", Classes.FMulticastDelegateProperty);
		OnPropertyDropped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPropertyDropped");
		OnPropertyDropped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPropertyDropped", Classes.FMulticastDelegateProperty);
		SetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetValue");
		SetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValue_InValue_PropertyAddress, SetValue_FunctionAddress, "InValue");
		SetValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValue_FunctionAddress, "InValue");
		SetValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetValue_IsValid = SetValue_FunctionAddress != IntPtr.Zero && SetValue_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:SetValue", SetValue_IsValid);
		SetStepSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStepSize");
		SetStepSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStepSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStepSize_InValue_PropertyAddress, SetStepSize_FunctionAddress, "InValue");
		SetStepSize_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStepSize_FunctionAddress, "InValue");
		SetStepSize_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStepSize_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetStepSize_IsValid = SetStepSize_FunctionAddress != IntPtr.Zero && SetStepSize_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:SetStepSize", SetStepSize_IsValid);
		SetSliderHandleColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSliderHandleColor");
		SetSliderHandleColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSliderHandleColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSliderHandleColor_InValue_PropertyAddress, SetSliderHandleColor_FunctionAddress, "InValue");
		SetSliderHandleColor_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSliderHandleColor_FunctionAddress, "InValue");
		SetSliderHandleColor_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSliderHandleColor_FunctionAddress, "InValue", Classes.FStructProperty);
		SetSliderHandleColor_IsValid = SetSliderHandleColor_FunctionAddress != IntPtr.Zero && SetSliderHandleColor_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:SetSliderHandleColor", SetSliderHandleColor_IsValid);
		SetSliderBarColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSliderBarColor");
		SetSliderBarColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSliderBarColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSliderBarColor_InValue_PropertyAddress, SetSliderBarColor_FunctionAddress, "InValue");
		SetSliderBarColor_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSliderBarColor_FunctionAddress, "InValue");
		SetSliderBarColor_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSliderBarColor_FunctionAddress, "InValue", Classes.FStructProperty);
		SetSliderBarColor_IsValid = SetSliderBarColor_FunctionAddress != IntPtr.Zero && SetSliderBarColor_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:SetSliderBarColor", SetSliderBarColor_IsValid);
		SetLocked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLocked");
		SetLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocked_InValue_PropertyAddress, SetLocked_FunctionAddress, "InValue");
		SetLocked_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocked_FunctionAddress, "InValue");
		SetLocked_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocked_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetLocked_IsValid = SetLocked_FunctionAddress != IntPtr.Zero && SetLocked_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:SetLocked", SetLocked_IsValid);
		SetIndentHandle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIndentHandle");
		SetIndentHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIndentHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIndentHandle_InValue_PropertyAddress, SetIndentHandle_FunctionAddress, "InValue");
		SetIndentHandle_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetIndentHandle_FunctionAddress, "InValue");
		SetIndentHandle_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIndentHandle_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetIndentHandle_IsValid = SetIndentHandle_FunctionAddress != IntPtr.Zero && SetIndentHandle_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:SetIndentHandle", SetIndentHandle_IsValid);
		SetAkSliderItemProperty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAkSliderItemProperty");
		SetAkSliderItemProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAkSliderItemProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAkSliderItemProperty_ItemProperty_PropertyAddress, SetAkSliderItemProperty_FunctionAddress, "ItemProperty");
		SetAkSliderItemProperty_ItemProperty_Offset = NativeReflectionCached.GetPropertyOffset(SetAkSliderItemProperty_FunctionAddress, "ItemProperty");
		SetAkSliderItemProperty_ItemProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAkSliderItemProperty_FunctionAddress, "ItemProperty", Classes.FStrProperty);
		SetAkSliderItemProperty_IsValid = SetAkSliderItemProperty_FunctionAddress != IntPtr.Zero && SetAkSliderItemProperty_ItemProperty_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:SetAkSliderItemProperty", SetAkSliderItemProperty_IsValid);
		SetAkSliderItemId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAkSliderItemId");
		SetAkSliderItemId_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAkSliderItemId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAkSliderItemId_ItemId_PropertyAddress, SetAkSliderItemId_FunctionAddress, "ItemId");
		SetAkSliderItemId_ItemId_Offset = NativeReflectionCached.GetPropertyOffset(SetAkSliderItemId_FunctionAddress, "ItemId");
		SetAkSliderItemId_ItemId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAkSliderItemId_FunctionAddress, "ItemId", Classes.FStructProperty);
		SetAkSliderItemId_IsValid = SetAkSliderItemId_FunctionAddress != IntPtr.Zero && SetAkSliderItemId_ItemId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:SetAkSliderItemId", SetAkSliderItemId_IsValid);
		GetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetValue");
		GetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValue_ReturnValue_PropertyAddress, GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetValue_IsValid = GetValue_FunctionAddress != IntPtr.Zero && GetValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:GetValue", GetValue_IsValid);
		GetAkSliderItemProperty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAkSliderItemProperty");
		GetAkSliderItemProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAkSliderItemProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAkSliderItemProperty_ReturnValue_PropertyAddress, GetAkSliderItemProperty_FunctionAddress, "ReturnValue");
		GetAkSliderItemProperty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAkSliderItemProperty_FunctionAddress, "ReturnValue");
		GetAkSliderItemProperty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkSliderItemProperty_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAkSliderItemProperty_IsValid = GetAkSliderItemProperty_FunctionAddress != IntPtr.Zero && GetAkSliderItemProperty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:GetAkSliderItemProperty", GetAkSliderItemProperty_IsValid);
		GetAkSliderItemId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAkSliderItemId");
		GetAkSliderItemId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAkSliderItemId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAkSliderItemId_ReturnValue_PropertyAddress, GetAkSliderItemId_FunctionAddress, "ReturnValue");
		GetAkSliderItemId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAkSliderItemId_FunctionAddress, "ReturnValue");
		GetAkSliderItemId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkSliderItemId_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAkSliderItemId_IsValid = GetAkSliderItemId_FunctionAddress != IntPtr.Zero && GetAkSliderItemId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSlider:GetAkSliderItemId", GetAkSliderItemId_IsValid);
	}
}
