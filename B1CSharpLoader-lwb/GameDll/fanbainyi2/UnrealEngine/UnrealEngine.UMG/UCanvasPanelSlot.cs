using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.CanvasPanelSlot", "UMG", UnrealModuleType.Engine)]
public class UCanvasPanelSlot : UPanelSlot
{
	private static bool LayoutData_IsValid;

	private static int LayoutData_Offset;

	private static bool AutoSize_IsValid;

	private static FFieldAddress AutoSize_PropertyAddress;

	private static int AutoSize_Offset;

	private static bool ZOrder_IsValid;

	private static int ZOrder_Offset;

	private static bool SetZOrder_IsValid;

	private static IntPtr SetZOrder_FunctionAddress;

	private static int SetZOrder_ParamsSize;

	private static bool SetZOrder_InZOrder_IsValid;

	private static FFieldAddress SetZOrder_InZOrder_PropertyAddress;

	private static int SetZOrder_InZOrder_Offset;

	private static bool SetSize_IsValid;

	private static IntPtr SetSize_FunctionAddress;

	private static int SetSize_ParamsSize;

	private static bool SetSize_InSize_IsValid;

	private static FFieldAddress SetSize_InSize_PropertyAddress;

	private static int SetSize_InSize_Offset;

	private static bool SetPosition_IsValid;

	private static IntPtr SetPosition_FunctionAddress;

	private static int SetPosition_ParamsSize;

	private static bool SetPosition_InPosition_IsValid;

	private static FFieldAddress SetPosition_InPosition_PropertyAddress;

	private static int SetPosition_InPosition_Offset;

	private static bool SetOffsets_IsValid;

	private static IntPtr SetOffsets_FunctionAddress;

	private static int SetOffsets_ParamsSize;

	private static bool SetOffsets_InOffset_IsValid;

	private static FFieldAddress SetOffsets_InOffset_PropertyAddress;

	private static int SetOffsets_InOffset_Offset;

	private static bool SetLayout_IsValid;

	private static IntPtr SetLayout_FunctionAddress;

	private static int SetLayout_ParamsSize;

	private static bool SetLayout_InLayoutData_IsValid;

	private static FFieldAddress SetLayout_InLayoutData_PropertyAddress;

	private static int SetLayout_InLayoutData_Offset;

	private static bool SetAutoSize_IsValid;

	private static IntPtr SetAutoSize_FunctionAddress;

	private static int SetAutoSize_ParamsSize;

	private static bool SetAutoSize_InbAutoSize_IsValid;

	private static FFieldAddress SetAutoSize_InbAutoSize_PropertyAddress;

	private static int SetAutoSize_InbAutoSize_Offset;

	private static bool SetAnchors_IsValid;

	private static IntPtr SetAnchors_FunctionAddress;

	private static int SetAnchors_ParamsSize;

	private static bool SetAnchors_InAnchors_IsValid;

	private static FFieldAddress SetAnchors_InAnchors_PropertyAddress;

	private static int SetAnchors_InAnchors_Offset;

	private static bool SetAlignment_IsValid;

	private static IntPtr SetAlignment_FunctionAddress;

	private static int SetAlignment_ParamsSize;

	private static bool SetAlignment_InAlignment_IsValid;

	private static FFieldAddress SetAlignment_InAlignment_PropertyAddress;

	private static int SetAlignment_InAlignment_Offset;

	private static bool GetZOrder_IsValid;

	private static IntPtr GetZOrder_FunctionAddress;

	private static int GetZOrder_ParamsSize;

	private static bool GetZOrder_ReturnValue_IsValid;

	private static FFieldAddress GetZOrder_ReturnValue_PropertyAddress;

	private static int GetZOrder_ReturnValue_Offset;

	private static bool GetSize_IsValid;

	private static IntPtr GetSize_FunctionAddress;

	private static int GetSize_ParamsSize;

	private static bool GetSize_ReturnValue_IsValid;

	private static FFieldAddress GetSize_ReturnValue_PropertyAddress;

	private static int GetSize_ReturnValue_Offset;

	private static bool GetPosition_IsValid;

	private static IntPtr GetPosition_FunctionAddress;

	private static int GetPosition_ParamsSize;

	private static bool GetPosition_ReturnValue_IsValid;

	private static FFieldAddress GetPosition_ReturnValue_PropertyAddress;

	private static int GetPosition_ReturnValue_Offset;

	private static bool GetOffsets_IsValid;

	private static IntPtr GetOffsets_FunctionAddress;

	private static int GetOffsets_ParamsSize;

	private static bool GetOffsets_ReturnValue_IsValid;

	private static FFieldAddress GetOffsets_ReturnValue_PropertyAddress;

	private static int GetOffsets_ReturnValue_Offset;

	private static bool GetLayout_IsValid;

	private static IntPtr GetLayout_FunctionAddress;

	private static int GetLayout_ParamsSize;

	private static bool GetLayout_ReturnValue_IsValid;

	private static FFieldAddress GetLayout_ReturnValue_PropertyAddress;

	private static int GetLayout_ReturnValue_Offset;

	private static bool GetAutoSize_IsValid;

	private static IntPtr GetAutoSize_FunctionAddress;

	private static int GetAutoSize_ParamsSize;

	private static bool GetAutoSize_ReturnValue_IsValid;

	private static FFieldAddress GetAutoSize_ReturnValue_PropertyAddress;

	private static int GetAutoSize_ReturnValue_Offset;

	private static bool GetAnchors_IsValid;

	private static IntPtr GetAnchors_FunctionAddress;

	private static int GetAnchors_ParamsSize;

	private static bool GetAnchors_ReturnValue_IsValid;

	private static FFieldAddress GetAnchors_ReturnValue_PropertyAddress;

	private static int GetAnchors_ReturnValue_Offset;

	private static bool GetAlignment_IsValid;

	private static IntPtr GetAlignment_FunctionAddress;

	private static int GetAlignment_ParamsSize;

	private static bool GetAlignment_ReturnValue_IsValid;

	private static FFieldAddress GetAlignment_ReturnValue_PropertyAddress;

	private static int GetAlignment_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:LayoutData")]
	public FAnchorData LayoutData
	{
		get
		{
			CheckDestroyed();
			if (!LayoutData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CanvasPanelSlot:LayoutData");
				return default(FAnchorData);
			}
			return FAnchorData.FromNative(IntPtr.Add(base.Address, LayoutData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayoutData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CanvasPanelSlot:LayoutData");
			}
			else
			{
				FAnchorData.ToNative(IntPtr.Add(base.Address, LayoutData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:bAutoSize")]
	public bool AutoSize
	{
		get
		{
			CheckDestroyed();
			if (!AutoSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CanvasPanelSlot:bAutoSize");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoSize_Offset), 0, AutoSize_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CanvasPanelSlot:bAutoSize");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoSize_Offset), 0, AutoSize_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:ZOrder")]
	public int ZOrder
	{
		get
		{
			CheckDestroyed();
			if (!ZOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CanvasPanelSlot:ZOrder");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ZOrder_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ZOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CanvasPanelSlot:ZOrder");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ZOrder_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:SetZOrder")]
	public unsafe void SetZOrder(int InZOrder)
	{
		CheckDestroyed();
		if (!SetZOrder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:SetZOrder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetZOrder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetZOrder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetZOrder_InZOrder_Offset), 0, SetZOrder_InZOrder_PropertyAddress.Address, InZOrder);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetZOrder_FunctionAddress, intPtr, SetZOrder_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:SetSize")]
	public unsafe void SetSize(FVector2D InSize)
	{
		CheckDestroyed();
		if (!SetSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:SetSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetSize_InSize_Offset), 0, SetSize_InSize_PropertyAddress.Address, InSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSize_FunctionAddress, intPtr, SetSize_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:SetPosition")]
	public unsafe void SetPosition(FVector2D InPosition)
	{
		CheckDestroyed();
		if (!SetPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:SetPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetPosition_InPosition_Offset), 0, SetPosition_InPosition_PropertyAddress.Address, InPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPosition_FunctionAddress, intPtr, SetPosition_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:SetOffsets")]
	public unsafe void SetOffsets(FMargin InOffset)
	{
		CheckDestroyed();
		if (!SetOffsets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:SetOffsets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOffsets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOffsets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, SetOffsets_InOffset_Offset), 0, SetOffsets_InOffset_PropertyAddress.Address, InOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOffsets_FunctionAddress, intPtr, SetOffsets_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:SetLayout")]
	public unsafe void SetLayout(FAnchorData InLayoutData)
	{
		CheckDestroyed();
		if (!SetLayout_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:SetLayout");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLayout_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLayout_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLayout_InLayoutData_PropertyAddress.Address, intPtr);
		FAnchorData.ToNative(IntPtr.Add(intPtr, SetLayout_InLayoutData_Offset), 0, SetLayout_InLayoutData_PropertyAddress.Address, InLayoutData);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLayout_FunctionAddress, intPtr, SetLayout_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:SetAutoSize")]
	public unsafe void SetAutoSize(bool InbAutoSize)
	{
		CheckDestroyed();
		if (!SetAutoSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:SetAutoSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAutoSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAutoSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAutoSize_InbAutoSize_Offset), 0, SetAutoSize_InbAutoSize_PropertyAddress.Address, InbAutoSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAutoSize_FunctionAddress, intPtr, SetAutoSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:SetAnchors")]
	public unsafe void SetAnchors(FAnchors InAnchors)
	{
		CheckDestroyed();
		if (!SetAnchors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:SetAnchors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnchors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnchors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAnchors_InAnchors_PropertyAddress.Address, intPtr);
		FAnchors.ToNative(IntPtr.Add(intPtr, SetAnchors_InAnchors_Offset), 0, SetAnchors_InAnchors_PropertyAddress.Address, InAnchors);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnchors_FunctionAddress, intPtr, SetAnchors_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:SetAlignment")]
	public unsafe void SetAlignment(FVector2D InAlignment)
	{
		CheckDestroyed();
		if (!SetAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:SetAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetAlignment_InAlignment_Offset), 0, SetAlignment_InAlignment_PropertyAddress.Address, InAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAlignment_FunctionAddress, intPtr, SetAlignment_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:GetZOrder")]
	public unsafe int GetZOrder()
	{
		CheckDestroyed();
		if (!GetZOrder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:GetZOrder");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetZOrder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetZOrder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetZOrder_FunctionAddress, intPtr, GetZOrder_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetZOrder_ReturnValue_Offset), 0, GetZOrder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:GetSize")]
	public unsafe FVector2D GetSize()
	{
		CheckDestroyed();
		if (!GetSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:GetSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSize_FunctionAddress, intPtr, GetSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetSize_ReturnValue_Offset), 0, GetSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:GetPosition")]
	public unsafe FVector2D GetPosition()
	{
		CheckDestroyed();
		if (!GetPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:GetPosition");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPosition_FunctionAddress, intPtr, GetPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPosition_ReturnValue_Offset), 0, GetPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:GetOffsets")]
	public unsafe FMargin GetOffsets()
	{
		CheckDestroyed();
		if (!GetOffsets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:GetOffsets");
			return default(FMargin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOffsets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOffsets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOffsets_FunctionAddress, intPtr, GetOffsets_ParamsSize);
		return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(intPtr, GetOffsets_ReturnValue_Offset), 0, GetOffsets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:GetLayout")]
	public unsafe FAnchorData GetLayout()
	{
		CheckDestroyed();
		if (!GetLayout_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:GetLayout");
			return default(FAnchorData);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLayout_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLayout_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLayout_FunctionAddress, intPtr, GetLayout_ParamsSize);
		return FAnchorData.FromNative(IntPtr.Add(intPtr, GetLayout_ReturnValue_Offset), 0, GetLayout_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:GetAutoSize")]
	public unsafe bool GetAutoSize()
	{
		CheckDestroyed();
		if (!GetAutoSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:GetAutoSize");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAutoSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAutoSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAutoSize_FunctionAddress, intPtr, GetAutoSize_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAutoSize_ReturnValue_Offset), 0, GetAutoSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:GetAnchors")]
	public unsafe FAnchors GetAnchors()
	{
		CheckDestroyed();
		if (!GetAnchors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:GetAnchors");
			return default(FAnchors);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnchors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnchors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnchors_FunctionAddress, intPtr, GetAnchors_ParamsSize);
		return FAnchors.FromNative(IntPtr.Add(intPtr, GetAnchors_ReturnValue_Offset), 0, GetAnchors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.CanvasPanelSlot:GetAlignment")]
	public unsafe FVector2D GetAlignment()
	{
		CheckDestroyed();
		if (!GetAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CanvasPanelSlot:GetAlignment");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAlignment_FunctionAddress, intPtr, GetAlignment_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetAlignment_ReturnValue_Offset), 0, GetAlignment_ReturnValue_PropertyAddress.Address);
	}

	static UCanvasPanelSlot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCanvasPanelSlot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCanvasPanelSlot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.CanvasPanelSlot");
		LayoutData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LayoutData");
		LayoutData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LayoutData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoSize_PropertyAddress, intPtr, "bAutoSize");
		AutoSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoSize");
		AutoSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoSize", Classes.FBoolProperty);
		ZOrder_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ZOrder");
		ZOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ZOrder", Classes.FIntProperty);
		SetZOrder_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetZOrder");
		SetZOrder_ParamsSize = NativeReflection.GetFunctionParamsSize(SetZOrder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetZOrder_InZOrder_PropertyAddress, SetZOrder_FunctionAddress, "InZOrder");
		SetZOrder_InZOrder_Offset = NativeReflectionCached.GetPropertyOffset(SetZOrder_FunctionAddress, "InZOrder");
		SetZOrder_InZOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(SetZOrder_FunctionAddress, "InZOrder", Classes.FIntProperty);
		SetZOrder_IsValid = SetZOrder_FunctionAddress != IntPtr.Zero && SetZOrder_InZOrder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:SetZOrder", SetZOrder_IsValid);
		SetSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSize");
		SetSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSize_InSize_PropertyAddress, SetSize_FunctionAddress, "InSize");
		SetSize_InSize_Offset = NativeReflectionCached.GetPropertyOffset(SetSize_FunctionAddress, "InSize");
		SetSize_InSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSize_FunctionAddress, "InSize", Classes.FStructProperty);
		SetSize_IsValid = SetSize_FunctionAddress != IntPtr.Zero && SetSize_InSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:SetSize", SetSize_IsValid);
		SetPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPosition");
		SetPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPosition_InPosition_PropertyAddress, SetPosition_FunctionAddress, "InPosition");
		SetPosition_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetPosition_FunctionAddress, "InPosition");
		SetPosition_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPosition_FunctionAddress, "InPosition", Classes.FStructProperty);
		SetPosition_IsValid = SetPosition_FunctionAddress != IntPtr.Zero && SetPosition_InPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:SetPosition", SetPosition_IsValid);
		SetOffsets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOffsets");
		SetOffsets_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOffsets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOffsets_InOffset_PropertyAddress, SetOffsets_FunctionAddress, "InOffset");
		SetOffsets_InOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetOffsets_FunctionAddress, "InOffset");
		SetOffsets_InOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOffsets_FunctionAddress, "InOffset", Classes.FStructProperty);
		SetOffsets_IsValid = SetOffsets_FunctionAddress != IntPtr.Zero && SetOffsets_InOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:SetOffsets", SetOffsets_IsValid);
		SetLayout_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLayout");
		SetLayout_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLayout_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLayout_InLayoutData_PropertyAddress, SetLayout_FunctionAddress, "InLayoutData");
		SetLayout_InLayoutData_Offset = NativeReflectionCached.GetPropertyOffset(SetLayout_FunctionAddress, "InLayoutData");
		SetLayout_InLayoutData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayout_FunctionAddress, "InLayoutData", Classes.FStructProperty);
		SetLayout_IsValid = SetLayout_FunctionAddress != IntPtr.Zero && SetLayout_InLayoutData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:SetLayout", SetLayout_IsValid);
		SetAutoSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAutoSize");
		SetAutoSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAutoSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAutoSize_InbAutoSize_PropertyAddress, SetAutoSize_FunctionAddress, "InbAutoSize");
		SetAutoSize_InbAutoSize_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoSize_FunctionAddress, "InbAutoSize");
		SetAutoSize_InbAutoSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoSize_FunctionAddress, "InbAutoSize", Classes.FBoolProperty);
		SetAutoSize_IsValid = SetAutoSize_FunctionAddress != IntPtr.Zero && SetAutoSize_InbAutoSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:SetAutoSize", SetAutoSize_IsValid);
		SetAnchors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnchors");
		SetAnchors_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnchors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnchors_InAnchors_PropertyAddress, SetAnchors_FunctionAddress, "InAnchors");
		SetAnchors_InAnchors_Offset = NativeReflectionCached.GetPropertyOffset(SetAnchors_FunctionAddress, "InAnchors");
		SetAnchors_InAnchors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnchors_FunctionAddress, "InAnchors", Classes.FStructProperty);
		SetAnchors_IsValid = SetAnchors_FunctionAddress != IntPtr.Zero && SetAnchors_InAnchors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:SetAnchors", SetAnchors_IsValid);
		SetAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAlignment");
		SetAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAlignment_InAlignment_PropertyAddress, SetAlignment_FunctionAddress, "InAlignment");
		SetAlignment_InAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetAlignment_FunctionAddress, "InAlignment");
		SetAlignment_InAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlignment_FunctionAddress, "InAlignment", Classes.FStructProperty);
		SetAlignment_IsValid = SetAlignment_FunctionAddress != IntPtr.Zero && SetAlignment_InAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:SetAlignment", SetAlignment_IsValid);
		GetZOrder_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetZOrder");
		GetZOrder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetZOrder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetZOrder_ReturnValue_PropertyAddress, GetZOrder_FunctionAddress, "ReturnValue");
		GetZOrder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetZOrder_FunctionAddress, "ReturnValue");
		GetZOrder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetZOrder_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetZOrder_IsValid = GetZOrder_FunctionAddress != IntPtr.Zero && GetZOrder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:GetZOrder", GetZOrder_IsValid);
		GetSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSize");
		GetSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSize_ReturnValue_PropertyAddress, GetSize_FunctionAddress, "ReturnValue");
		GetSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSize_FunctionAddress, "ReturnValue");
		GetSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSize_IsValid = GetSize_FunctionAddress != IntPtr.Zero && GetSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:GetSize", GetSize_IsValid);
		GetPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPosition");
		GetPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPosition_ReturnValue_PropertyAddress, GetPosition_FunctionAddress, "ReturnValue");
		GetPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPosition_FunctionAddress, "ReturnValue");
		GetPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPosition_IsValid = GetPosition_FunctionAddress != IntPtr.Zero && GetPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:GetPosition", GetPosition_IsValid);
		GetOffsets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOffsets");
		GetOffsets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOffsets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOffsets_ReturnValue_PropertyAddress, GetOffsets_FunctionAddress, "ReturnValue");
		GetOffsets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOffsets_FunctionAddress, "ReturnValue");
		GetOffsets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOffsets_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetOffsets_IsValid = GetOffsets_FunctionAddress != IntPtr.Zero && GetOffsets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:GetOffsets", GetOffsets_IsValid);
		GetLayout_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLayout");
		GetLayout_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLayout_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLayout_ReturnValue_PropertyAddress, GetLayout_FunctionAddress, "ReturnValue");
		GetLayout_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLayout_FunctionAddress, "ReturnValue");
		GetLayout_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLayout_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLayout_IsValid = GetLayout_FunctionAddress != IntPtr.Zero && GetLayout_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:GetLayout", GetLayout_IsValid);
		GetAutoSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAutoSize");
		GetAutoSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAutoSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAutoSize_ReturnValue_PropertyAddress, GetAutoSize_FunctionAddress, "ReturnValue");
		GetAutoSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAutoSize_FunctionAddress, "ReturnValue");
		GetAutoSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAutoSize_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAutoSize_IsValid = GetAutoSize_FunctionAddress != IntPtr.Zero && GetAutoSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:GetAutoSize", GetAutoSize_IsValid);
		GetAnchors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnchors");
		GetAnchors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnchors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnchors_ReturnValue_PropertyAddress, GetAnchors_FunctionAddress, "ReturnValue");
		GetAnchors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnchors_FunctionAddress, "ReturnValue");
		GetAnchors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnchors_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAnchors_IsValid = GetAnchors_FunctionAddress != IntPtr.Zero && GetAnchors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:GetAnchors", GetAnchors_IsValid);
		GetAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAlignment");
		GetAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAlignment_ReturnValue_PropertyAddress, GetAlignment_FunctionAddress, "ReturnValue");
		GetAlignment_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAlignment_FunctionAddress, "ReturnValue");
		GetAlignment_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlignment_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAlignment_IsValid = GetAlignment_FunctionAddress != IntPtr.Zero && GetAlignment_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CanvasPanelSlot:GetAlignment", GetAlignment_IsValid);
	}
}
