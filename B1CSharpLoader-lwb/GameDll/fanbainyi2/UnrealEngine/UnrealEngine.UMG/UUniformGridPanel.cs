using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.UniformGridPanel", "UMG", UnrealModuleType.Engine)]
public class UUniformGridPanel : UPanelWidget
{
	private static bool SlotPadding_IsValid;

	private static int SlotPadding_Offset;

	private static bool MinDesiredSlotWidth_IsValid;

	private static int MinDesiredSlotWidth_Offset;

	private static bool MinDesiredSlotHeight_IsValid;

	private static int MinDesiredSlotHeight_Offset;

	private static bool SetSlotPadding_IsValid;

	private static IntPtr SetSlotPadding_FunctionAddress;

	private static int SetSlotPadding_ParamsSize;

	private static bool SetSlotPadding_InSlotPadding_IsValid;

	private static FFieldAddress SetSlotPadding_InSlotPadding_PropertyAddress;

	private static int SetSlotPadding_InSlotPadding_Offset;

	private static bool SetMinDesiredSlotWidth_IsValid;

	private static IntPtr SetMinDesiredSlotWidth_FunctionAddress;

	private static int SetMinDesiredSlotWidth_ParamsSize;

	private static bool SetMinDesiredSlotWidth_InMinDesiredSlotWidth_IsValid;

	private static FFieldAddress SetMinDesiredSlotWidth_InMinDesiredSlotWidth_PropertyAddress;

	private static int SetMinDesiredSlotWidth_InMinDesiredSlotWidth_Offset;

	private static bool SetMinDesiredSlotHeight_IsValid;

	private static IntPtr SetMinDesiredSlotHeight_FunctionAddress;

	private static int SetMinDesiredSlotHeight_ParamsSize;

	private static bool SetMinDesiredSlotHeight_InMinDesiredSlotHeight_IsValid;

	private static FFieldAddress SetMinDesiredSlotHeight_InMinDesiredSlotHeight_PropertyAddress;

	private static int SetMinDesiredSlotHeight_InMinDesiredSlotHeight_Offset;

	private static bool AddChildToUniformGrid_IsValid;

	private static IntPtr AddChildToUniformGrid_FunctionAddress;

	private static int AddChildToUniformGrid_ParamsSize;

	private static bool AddChildToUniformGrid_Content_IsValid;

	private static FFieldAddress AddChildToUniformGrid_Content_PropertyAddress;

	private static int AddChildToUniformGrid_Content_Offset;

	private static bool AddChildToUniformGrid_InRow_IsValid;

	private static FFieldAddress AddChildToUniformGrid_InRow_PropertyAddress;

	private static int AddChildToUniformGrid_InRow_Offset;

	private static bool AddChildToUniformGrid_InColumn_IsValid;

	private static FFieldAddress AddChildToUniformGrid_InColumn_PropertyAddress;

	private static int AddChildToUniformGrid_InColumn_Offset;

	private static bool AddChildToUniformGrid_ReturnValue_IsValid;

	private static FFieldAddress AddChildToUniformGrid_ReturnValue_PropertyAddress;

	private static int AddChildToUniformGrid_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.UniformGridPanel:SlotPadding")]
	public FMargin SlotPadding
	{
		get
		{
			CheckDestroyed();
			if (!SlotPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridPanel:SlotPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, SlotPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlotPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridPanel:SlotPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, SlotPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.UniformGridPanel:MinDesiredSlotWidth")]
	public float MinDesiredSlotWidth
	{
		get
		{
			CheckDestroyed();
			if (!MinDesiredSlotWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridPanel:MinDesiredSlotWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDesiredSlotWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDesiredSlotWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridPanel:MinDesiredSlotWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDesiredSlotWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.UniformGridPanel:MinDesiredSlotHeight")]
	public float MinDesiredSlotHeight
	{
		get
		{
			CheckDestroyed();
			if (!MinDesiredSlotHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridPanel:MinDesiredSlotHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDesiredSlotHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDesiredSlotHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridPanel:MinDesiredSlotHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDesiredSlotHeight_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UniformGridPanel:SetSlotPadding")]
	public unsafe void SetSlotPadding(FMargin InSlotPadding)
	{
		CheckDestroyed();
		if (!SetSlotPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UniformGridPanel:SetSlotPadding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSlotPadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSlotPadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, SetSlotPadding_InSlotPadding_Offset), 0, SetSlotPadding_InSlotPadding_PropertyAddress.Address, InSlotPadding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSlotPadding_FunctionAddress, intPtr, SetSlotPadding_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UniformGridPanel:SetMinDesiredSlotWidth")]
	public unsafe void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth)
	{
		CheckDestroyed();
		if (!SetMinDesiredSlotWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UniformGridPanel:SetMinDesiredSlotWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinDesiredSlotWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinDesiredSlotWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinDesiredSlotWidth_InMinDesiredSlotWidth_Offset), 0, SetMinDesiredSlotWidth_InMinDesiredSlotWidth_PropertyAddress.Address, InMinDesiredSlotWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinDesiredSlotWidth_FunctionAddress, intPtr, SetMinDesiredSlotWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UniformGridPanel:SetMinDesiredSlotHeight")]
	public unsafe void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight)
	{
		CheckDestroyed();
		if (!SetMinDesiredSlotHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UniformGridPanel:SetMinDesiredSlotHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinDesiredSlotHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinDesiredSlotHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinDesiredSlotHeight_InMinDesiredSlotHeight_Offset), 0, SetMinDesiredSlotHeight_InMinDesiredSlotHeight_PropertyAddress.Address, InMinDesiredSlotHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinDesiredSlotHeight_FunctionAddress, intPtr, SetMinDesiredSlotHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UniformGridPanel:AddChildToUniformGrid")]
	public unsafe UUniformGridSlot AddChildToUniformGrid(UWidget Content, int InRow = 0, int InColumn = 0)
	{
		CheckDestroyed();
		if (!AddChildToUniformGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UniformGridPanel:AddChildToUniformGrid");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildToUniformGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildToUniformGrid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChildToUniformGrid_Content_Offset), 0, AddChildToUniformGrid_Content_PropertyAddress.Address, Content);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddChildToUniformGrid_InRow_Offset), 0, AddChildToUniformGrid_InRow_PropertyAddress.Address, InRow);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddChildToUniformGrid_InColumn_Offset), 0, AddChildToUniformGrid_InColumn_PropertyAddress.Address, InColumn);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChildToUniformGrid_FunctionAddress, intPtr, AddChildToUniformGrid_ParamsSize);
		return UObjectMarshaler<UUniformGridSlot>.FromNative(IntPtr.Add(intPtr, AddChildToUniformGrid_ReturnValue_Offset), 0, AddChildToUniformGrid_ReturnValue_PropertyAddress.Address);
	}

	static UUniformGridPanel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUniformGridPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUniformGridPanel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.UniformGridPanel");
		SlotPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SlotPadding");
		SlotPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SlotPadding", Classes.FStructProperty);
		MinDesiredSlotWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinDesiredSlotWidth");
		MinDesiredSlotWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinDesiredSlotWidth", Classes.FFloatProperty);
		MinDesiredSlotHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinDesiredSlotHeight");
		MinDesiredSlotHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinDesiredSlotHeight", Classes.FFloatProperty);
		SetSlotPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSlotPadding");
		SetSlotPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSlotPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSlotPadding_InSlotPadding_PropertyAddress, SetSlotPadding_FunctionAddress, "InSlotPadding");
		SetSlotPadding_InSlotPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetSlotPadding_FunctionAddress, "InSlotPadding");
		SetSlotPadding_InSlotPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSlotPadding_FunctionAddress, "InSlotPadding", Classes.FStructProperty);
		SetSlotPadding_IsValid = SetSlotPadding_FunctionAddress != IntPtr.Zero && SetSlotPadding_InSlotPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UniformGridPanel:SetSlotPadding", SetSlotPadding_IsValid);
		SetMinDesiredSlotWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinDesiredSlotWidth");
		SetMinDesiredSlotWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinDesiredSlotWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinDesiredSlotWidth_InMinDesiredSlotWidth_PropertyAddress, SetMinDesiredSlotWidth_FunctionAddress, "InMinDesiredSlotWidth");
		SetMinDesiredSlotWidth_InMinDesiredSlotWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetMinDesiredSlotWidth_FunctionAddress, "InMinDesiredSlotWidth");
		SetMinDesiredSlotWidth_InMinDesiredSlotWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinDesiredSlotWidth_FunctionAddress, "InMinDesiredSlotWidth", Classes.FFloatProperty);
		SetMinDesiredSlotWidth_IsValid = SetMinDesiredSlotWidth_FunctionAddress != IntPtr.Zero && SetMinDesiredSlotWidth_InMinDesiredSlotWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UniformGridPanel:SetMinDesiredSlotWidth", SetMinDesiredSlotWidth_IsValid);
		SetMinDesiredSlotHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinDesiredSlotHeight");
		SetMinDesiredSlotHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinDesiredSlotHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinDesiredSlotHeight_InMinDesiredSlotHeight_PropertyAddress, SetMinDesiredSlotHeight_FunctionAddress, "InMinDesiredSlotHeight");
		SetMinDesiredSlotHeight_InMinDesiredSlotHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetMinDesiredSlotHeight_FunctionAddress, "InMinDesiredSlotHeight");
		SetMinDesiredSlotHeight_InMinDesiredSlotHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinDesiredSlotHeight_FunctionAddress, "InMinDesiredSlotHeight", Classes.FFloatProperty);
		SetMinDesiredSlotHeight_IsValid = SetMinDesiredSlotHeight_FunctionAddress != IntPtr.Zero && SetMinDesiredSlotHeight_InMinDesiredSlotHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UniformGridPanel:SetMinDesiredSlotHeight", SetMinDesiredSlotHeight_IsValid);
		AddChildToUniformGrid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddChildToUniformGrid");
		AddChildToUniformGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildToUniformGrid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildToUniformGrid_Content_PropertyAddress, AddChildToUniformGrid_FunctionAddress, "Content");
		AddChildToUniformGrid_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToUniformGrid_FunctionAddress, "Content");
		AddChildToUniformGrid_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToUniformGrid_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToUniformGrid_InRow_PropertyAddress, AddChildToUniformGrid_FunctionAddress, "InRow");
		AddChildToUniformGrid_InRow_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToUniformGrid_FunctionAddress, "InRow");
		AddChildToUniformGrid_InRow_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToUniformGrid_FunctionAddress, "InRow", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToUniformGrid_InColumn_PropertyAddress, AddChildToUniformGrid_FunctionAddress, "InColumn");
		AddChildToUniformGrid_InColumn_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToUniformGrid_FunctionAddress, "InColumn");
		AddChildToUniformGrid_InColumn_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToUniformGrid_FunctionAddress, "InColumn", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToUniformGrid_ReturnValue_PropertyAddress, AddChildToUniformGrid_FunctionAddress, "ReturnValue");
		AddChildToUniformGrid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToUniformGrid_FunctionAddress, "ReturnValue");
		AddChildToUniformGrid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToUniformGrid_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChildToUniformGrid_IsValid = AddChildToUniformGrid_FunctionAddress != IntPtr.Zero && AddChildToUniformGrid_Content_IsValid && AddChildToUniformGrid_InRow_IsValid && AddChildToUniformGrid_InColumn_IsValid && AddChildToUniformGrid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UniformGridPanel:AddChildToUniformGrid", AddChildToUniformGrid_IsValid);
	}
}
