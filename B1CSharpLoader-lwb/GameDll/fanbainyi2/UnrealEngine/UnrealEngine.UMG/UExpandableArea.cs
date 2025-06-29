using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ExpandableArea", "UMG", UnrealModuleType.Engine)]
public class UExpandableArea : UWidget, INamedSlotInterface, IInterface
{
	private static bool BorderBrush_IsValid;

	private static int BorderBrush_Offset;

	private static bool BorderColor_IsValid;

	private static int BorderColor_Offset;

	private static bool IsExpanded_IsValid;

	private static FFieldAddress IsExpanded_PropertyAddress;

	private static int IsExpanded_Offset;

	private static bool MaxHeight_IsValid;

	private static int MaxHeight_Offset;

	private static bool HeaderPadding_IsValid;

	private static int HeaderPadding_Offset;

	private static bool AreaPadding_IsValid;

	private static int AreaPadding_Offset;

	private static bool OnExpansionChanged_IsValid;

	private static int OnExpansionChanged_Offset;

	private FOnExpandableAreaExpansionChanged OnExpansionChanged_DelegateCached;

	private static bool SetIsExpanded_Animated_IsValid;

	private static IntPtr SetIsExpanded_Animated_FunctionAddress;

	private static int SetIsExpanded_Animated_ParamsSize;

	private static bool SetIsExpanded_Animated_IsExpanded_IsValid;

	private static FFieldAddress SetIsExpanded_Animated_IsExpanded_PropertyAddress;

	private static int SetIsExpanded_Animated_IsExpanded_Offset;

	private static bool SetIsExpanded_IsValid;

	private static IntPtr SetIsExpanded_FunctionAddress;

	private static int SetIsExpanded_ParamsSize;

	private static bool SetIsExpanded_IsExpanded_IsValid;

	private static FFieldAddress SetIsExpanded_IsExpanded_PropertyAddress;

	private static int SetIsExpanded_IsExpanded_Offset;

	private static bool GetIsExpanded_IsValid;

	private static IntPtr GetIsExpanded_FunctionAddress;

	private static int GetIsExpanded_ParamsSize;

	private static bool GetIsExpanded_ReturnValue_IsValid;

	private static FFieldAddress GetIsExpanded_ReturnValue_PropertyAddress;

	private static int GetIsExpanded_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.ExpandableArea:BorderBrush")]
	public FSlateBrush BorderBrush
	{
		get
		{
			CheckDestroyed();
			if (!BorderBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:BorderBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, BorderBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BorderBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:BorderBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, BorderBrush_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.ExpandableArea:BorderColor")]
	public FSlateColor BorderColor
	{
		get
		{
			CheckDestroyed();
			if (!BorderColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:BorderColor");
				return default(FSlateColor);
			}
			return FSlateColor.FromNative(IntPtr.Add(base.Address, BorderColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BorderColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:BorderColor");
			}
			else
			{
				FSlateColor.ToNative(IntPtr.Add(base.Address, BorderColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ExpandableArea:bIsExpanded")]
	public bool IsExpanded
	{
		get
		{
			CheckDestroyed();
			if (!IsExpanded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:bIsExpanded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsExpanded_Offset), 0, IsExpanded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsExpanded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:bIsExpanded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsExpanded_Offset), 0, IsExpanded_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ExpandableArea:MaxHeight")]
	public float MaxHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:MaxHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:MaxHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.ExpandableArea:HeaderPadding")]
	public FMargin HeaderPadding
	{
		get
		{
			CheckDestroyed();
			if (!HeaderPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:HeaderPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, HeaderPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeaderPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:HeaderPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, HeaderPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.ExpandableArea:AreaPadding")]
	public FMargin AreaPadding
	{
		get
		{
			CheckDestroyed();
			if (!AreaPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:AreaPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, AreaPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:AreaPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, AreaPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.ExpandableArea:OnExpansionChanged")]
	public FOnExpandableAreaExpansionChanged OnExpansionChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnExpansionChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ExpandableArea:OnExpansionChanged");
				return new FOnExpandableAreaExpansionChanged();
			}
			if (OnExpansionChanged_DelegateCached == null)
			{
				OnExpansionChanged_DelegateCached = new FOnExpandableAreaExpansionChanged();
				OnExpansionChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnExpansionChanged_Offset));
			}
			return OnExpansionChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ExpandableArea:SetIsExpanded_Animated")]
	public unsafe void SetIsExpanded_Animated(bool IsExpanded)
	{
		CheckDestroyed();
		if (!SetIsExpanded_Animated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ExpandableArea:SetIsExpanded_Animated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsExpanded_Animated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsExpanded_Animated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsExpanded_Animated_IsExpanded_Offset), 0, SetIsExpanded_Animated_IsExpanded_PropertyAddress.Address, IsExpanded);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsExpanded_Animated_FunctionAddress, intPtr, SetIsExpanded_Animated_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ExpandableArea:SetIsExpanded")]
	public unsafe void SetIsExpanded(bool IsExpanded)
	{
		CheckDestroyed();
		if (!SetIsExpanded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ExpandableArea:SetIsExpanded");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsExpanded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsExpanded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsExpanded_IsExpanded_Offset), 0, SetIsExpanded_IsExpanded_PropertyAddress.Address, IsExpanded);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsExpanded_FunctionAddress, intPtr, SetIsExpanded_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.ExpandableArea:GetIsExpanded")]
	public unsafe bool GetIsExpanded()
	{
		CheckDestroyed();
		if (!GetIsExpanded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ExpandableArea:GetIsExpanded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsExpanded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsExpanded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIsExpanded_FunctionAddress, intPtr, GetIsExpanded_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsExpanded_ReturnValue_Offset), 0, GetIsExpanded_ReturnValue_PropertyAddress.Address);
	}

	static UExpandableArea()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UExpandableArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UExpandableArea));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ExpandableArea");
		BorderBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BorderBrush");
		BorderBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BorderBrush", Classes.FStructProperty);
		BorderColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BorderColor");
		BorderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BorderColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsExpanded_PropertyAddress, intPtr, "bIsExpanded");
		IsExpanded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsExpanded");
		IsExpanded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsExpanded", Classes.FBoolProperty);
		MaxHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxHeight");
		MaxHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxHeight", Classes.FFloatProperty);
		HeaderPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeaderPadding");
		HeaderPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeaderPadding", Classes.FStructProperty);
		AreaPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AreaPadding");
		AreaPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AreaPadding", Classes.FStructProperty);
		OnExpansionChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnExpansionChanged");
		OnExpansionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnExpansionChanged", Classes.FMulticastDelegateProperty);
		SetIsExpanded_Animated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsExpanded_Animated");
		SetIsExpanded_Animated_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsExpanded_Animated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsExpanded_Animated_IsExpanded_PropertyAddress, SetIsExpanded_Animated_FunctionAddress, "IsExpanded");
		SetIsExpanded_Animated_IsExpanded_Offset = NativeReflectionCached.GetPropertyOffset(SetIsExpanded_Animated_FunctionAddress, "IsExpanded");
		SetIsExpanded_Animated_IsExpanded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsExpanded_Animated_FunctionAddress, "IsExpanded", Classes.FBoolProperty);
		SetIsExpanded_Animated_IsValid = SetIsExpanded_Animated_FunctionAddress != IntPtr.Zero && SetIsExpanded_Animated_IsExpanded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ExpandableArea:SetIsExpanded_Animated", SetIsExpanded_Animated_IsValid);
		SetIsExpanded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsExpanded");
		SetIsExpanded_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsExpanded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsExpanded_IsExpanded_PropertyAddress, SetIsExpanded_FunctionAddress, "IsExpanded");
		SetIsExpanded_IsExpanded_Offset = NativeReflectionCached.GetPropertyOffset(SetIsExpanded_FunctionAddress, "IsExpanded");
		SetIsExpanded_IsExpanded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsExpanded_FunctionAddress, "IsExpanded", Classes.FBoolProperty);
		SetIsExpanded_IsValid = SetIsExpanded_FunctionAddress != IntPtr.Zero && SetIsExpanded_IsExpanded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ExpandableArea:SetIsExpanded", SetIsExpanded_IsValid);
		GetIsExpanded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIsExpanded");
		GetIsExpanded_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsExpanded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsExpanded_ReturnValue_PropertyAddress, GetIsExpanded_FunctionAddress, "ReturnValue");
		GetIsExpanded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsExpanded_FunctionAddress, "ReturnValue");
		GetIsExpanded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsExpanded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsExpanded_IsValid = GetIsExpanded_FunctionAddress != IntPtr.Zero && GetIsExpanded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ExpandableArea:GetIsExpanded", GetIsExpanded_IsValid);
	}
}
