using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ArrowComponent", "Engine", UnrealModuleType.Engine)]
public class UArrowComponent : UPrimitiveComponent
{
	private static bool ArrowColor_IsValid;

	private static int ArrowColor_Offset;

	private static bool ArrowSize_IsValid;

	private static int ArrowSize_Offset;

	private static bool ArrowLength_IsValid;

	private static int ArrowLength_Offset;

	private static bool ScreenSize_IsValid;

	private static int ScreenSize_Offset;

	private static bool IsScreenSizeScaled_IsValid;

	private static FFieldAddress IsScreenSizeScaled_PropertyAddress;

	private static int IsScreenSizeScaled_Offset;

	private static bool TreatAsASprite_IsValid;

	private static FFieldAddress TreatAsASprite_PropertyAddress;

	private static int TreatAsASprite_Offset;

	private static bool UseInEditorScaling_IsValid;

	private static FFieldAddress UseInEditorScaling_PropertyAddress;

	private static int UseInEditorScaling_Offset;

	private static bool SetArrowColor_IsValid;

	private static IntPtr SetArrowColor_FunctionAddress;

	private static int SetArrowColor_ParamsSize;

	private static bool SetArrowColor_NewColor_IsValid;

	private static FFieldAddress SetArrowColor_NewColor_PropertyAddress;

	private static int SetArrowColor_NewColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ArrowComponent:ArrowColor")]
	public FColor ArrowColor
	{
		get
		{
			CheckDestroyed();
			if (!ArrowColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:ArrowColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, ArrowColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArrowColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:ArrowColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, ArrowColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ArrowComponent:ArrowSize")]
	public float ArrowSize
	{
		get
		{
			CheckDestroyed();
			if (!ArrowSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:ArrowSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ArrowSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArrowSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:ArrowSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ArrowSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ArrowComponent:ArrowLength")]
	public float ArrowLength
	{
		get
		{
			CheckDestroyed();
			if (!ArrowLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:ArrowLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ArrowLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArrowLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:ArrowLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ArrowLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ArrowComponent:ScreenSize")]
	public float ScreenSize
	{
		get
		{
			CheckDestroyed();
			if (!ScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:ScreenSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScreenSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:ScreenSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScreenSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ArrowComponent:bIsScreenSizeScaled")]
	public bool IsScreenSizeScaled
	{
		get
		{
			CheckDestroyed();
			if (!IsScreenSizeScaled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:bIsScreenSizeScaled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsScreenSizeScaled_Offset), 0, IsScreenSizeScaled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsScreenSizeScaled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:bIsScreenSizeScaled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsScreenSizeScaled_Offset), 0, IsScreenSizeScaled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ArrowComponent:bTreatAsASprite")]
	public bool TreatAsASprite
	{
		get
		{
			CheckDestroyed();
			if (!TreatAsASprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:bTreatAsASprite");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TreatAsASprite_Offset), 0, TreatAsASprite_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TreatAsASprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:bTreatAsASprite");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TreatAsASprite_Offset), 0, TreatAsASprite_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.ArrowComponent:bUseInEditorScaling")]
	public bool UseInEditorScaling
	{
		get
		{
			CheckDestroyed();
			if (!UseInEditorScaling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:bUseInEditorScaling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseInEditorScaling_Offset), 0, UseInEditorScaling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseInEditorScaling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ArrowComponent:bUseInEditorScaling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseInEditorScaling_Offset), 0, UseInEditorScaling_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.ArrowComponent:SetArrowColor")]
	public unsafe void SetArrowColor(FLinearColor NewColor)
	{
		CheckDestroyed();
		if (!SetArrowColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ArrowComponent:SetArrowColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetArrowColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetArrowColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetArrowColor_NewColor_Offset), 0, SetArrowColor_NewColor_PropertyAddress.Address, NewColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetArrowColor_FunctionAddress, intPtr, SetArrowColor_ParamsSize);
	}

	static UArrowComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UArrowComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UArrowComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.ArrowComponent");
		ArrowColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrowColor");
		ArrowColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrowColor", Classes.FStructProperty);
		ArrowSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrowSize");
		ArrowSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrowSize", Classes.FFloatProperty);
		ArrowLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrowLength");
		ArrowLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrowLength", Classes.FFloatProperty);
		ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScreenSize");
		ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScreenSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsScreenSizeScaled_PropertyAddress, intPtr, "bIsScreenSizeScaled");
		IsScreenSizeScaled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsScreenSizeScaled");
		IsScreenSizeScaled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsScreenSizeScaled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TreatAsASprite_PropertyAddress, intPtr, "bTreatAsASprite");
		TreatAsASprite_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTreatAsASprite");
		TreatAsASprite_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTreatAsASprite", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseInEditorScaling_PropertyAddress, intPtr, "bUseInEditorScaling");
		UseInEditorScaling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseInEditorScaling");
		UseInEditorScaling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseInEditorScaling", Classes.FBoolProperty);
		SetArrowColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetArrowColor");
		SetArrowColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetArrowColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetArrowColor_NewColor_PropertyAddress, SetArrowColor_FunctionAddress, "NewColor");
		SetArrowColor_NewColor_Offset = NativeReflectionCached.GetPropertyOffset(SetArrowColor_FunctionAddress, "NewColor");
		SetArrowColor_NewColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrowColor_FunctionAddress, "NewColor", Classes.FStructProperty);
		SetArrowColor_IsValid = SetArrowColor_FunctionAddress != IntPtr.Zero && SetArrowColor_NewColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ArrowComponent:SetArrowColor", SetArrowColor_IsValid);
	}
}
