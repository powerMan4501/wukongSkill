using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821047460uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.BillboardComponent", "Engine", UnrealModuleType.Engine)]
public class UBillboardComponent : UPrimitiveComponent
{
	private static bool Sprite_IsValid;

	private static int Sprite_Offset;

	private static bool IsScreenSizeScaled_IsValid;

	private static FFieldAddress IsScreenSizeScaled_PropertyAddress;

	private static int IsScreenSizeScaled_Offset;

	private static bool ScreenSize_IsValid;

	private static int ScreenSize_Offset;

	private static bool U_IsValid;

	private static int U_Offset;

	private static bool UL_IsValid;

	private static int UL_Offset;

	private static bool V_IsValid;

	private static int V_Offset;

	private static bool VL_IsValid;

	private static int VL_Offset;

	private static bool OpacityMaskRefVal_IsValid;

	private static int OpacityMaskRefVal_Offset;

	private static bool UseInEditorScaling_IsValid;

	private static FFieldAddress UseInEditorScaling_PropertyAddress;

	private static int UseInEditorScaling_Offset;

	private static bool SetUV_IsValid;

	private static IntPtr SetUV_FunctionAddress;

	private static int SetUV_ParamsSize;

	private static bool SetUV_NewU_IsValid;

	private static FFieldAddress SetUV_NewU_PropertyAddress;

	private static int SetUV_NewU_Offset;

	private static bool SetUV_NewUL_IsValid;

	private static FFieldAddress SetUV_NewUL_PropertyAddress;

	private static int SetUV_NewUL_Offset;

	private static bool SetUV_NewV_IsValid;

	private static FFieldAddress SetUV_NewV_PropertyAddress;

	private static int SetUV_NewV_Offset;

	private static bool SetUV_NewVL_IsValid;

	private static FFieldAddress SetUV_NewVL_PropertyAddress;

	private static int SetUV_NewVL_Offset;

	private static bool SetSpriteAndUV_IsValid;

	private static IntPtr SetSpriteAndUV_FunctionAddress;

	private static int SetSpriteAndUV_ParamsSize;

	private static bool SetSpriteAndUV_NewSprite_IsValid;

	private static FFieldAddress SetSpriteAndUV_NewSprite_PropertyAddress;

	private static int SetSpriteAndUV_NewSprite_Offset;

	private static bool SetSpriteAndUV_NewU_IsValid;

	private static FFieldAddress SetSpriteAndUV_NewU_PropertyAddress;

	private static int SetSpriteAndUV_NewU_Offset;

	private static bool SetSpriteAndUV_NewUL_IsValid;

	private static FFieldAddress SetSpriteAndUV_NewUL_PropertyAddress;

	private static int SetSpriteAndUV_NewUL_Offset;

	private static bool SetSpriteAndUV_NewV_IsValid;

	private static FFieldAddress SetSpriteAndUV_NewV_PropertyAddress;

	private static int SetSpriteAndUV_NewV_Offset;

	private static bool SetSpriteAndUV_NewVL_IsValid;

	private static FFieldAddress SetSpriteAndUV_NewVL_PropertyAddress;

	private static int SetSpriteAndUV_NewVL_Offset;

	private static bool SetSprite_IsValid;

	private static IntPtr SetSprite_FunctionAddress;

	private static int SetSprite_ParamsSize;

	private static bool SetSprite_NewSprite_IsValid;

	private static FFieldAddress SetSprite_NewSprite_PropertyAddress;

	private static int SetSprite_NewSprite_Offset;

	private static bool SetOpacityMaskRefVal_IsValid;

	private static IntPtr SetOpacityMaskRefVal_FunctionAddress;

	private static int SetOpacityMaskRefVal_ParamsSize;

	private static bool SetOpacityMaskRefVal_RefVal_IsValid;

	private static FFieldAddress SetOpacityMaskRefVal_RefVal_PropertyAddress;

	private static int SetOpacityMaskRefVal_RefVal_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:Sprite")]
	public UTexture2D Sprite
	{
		get
		{
			CheckDestroyed();
			if (!Sprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:Sprite");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, Sprite_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:Sprite");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, Sprite_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:bIsScreenSizeScaled")]
	public bool IsScreenSizeScaled
	{
		get
		{
			CheckDestroyed();
			if (!IsScreenSizeScaled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:bIsScreenSizeScaled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsScreenSizeScaled_Offset), 0, IsScreenSizeScaled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsScreenSizeScaled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:bIsScreenSizeScaled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsScreenSizeScaled_Offset), 0, IsScreenSizeScaled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:ScreenSize")]
	public float ScreenSize
	{
		get
		{
			CheckDestroyed();
			if (!ScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:ScreenSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScreenSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:ScreenSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScreenSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:U")]
	public float U
	{
		get
		{
			CheckDestroyed();
			if (!U_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:U");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, U_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!U_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:U");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, U_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:UL")]
	public float UL
	{
		get
		{
			CheckDestroyed();
			if (!UL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:UL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:UL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UL_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:V")]
	public float V
	{
		get
		{
			CheckDestroyed();
			if (!V_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:V");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, V_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!V_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:V");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, V_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:VL")]
	public float VL
	{
		get
		{
			CheckDestroyed();
			if (!VL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:VL");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:VL");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VL_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:OpacityMaskRefVal")]
	public float OpacityMaskRefVal
	{
		get
		{
			CheckDestroyed();
			if (!OpacityMaskRefVal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:OpacityMaskRefVal");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OpacityMaskRefVal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OpacityMaskRefVal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:OpacityMaskRefVal");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OpacityMaskRefVal_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.BillboardComponent:bUseInEditorScaling")]
	public bool UseInEditorScaling
	{
		get
		{
			CheckDestroyed();
			if (!UseInEditorScaling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:bUseInEditorScaling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseInEditorScaling_Offset), 0, UseInEditorScaling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseInEditorScaling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.BillboardComponent:bUseInEditorScaling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseInEditorScaling_Offset), 0, UseInEditorScaling_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.BillboardComponent:SetUV")]
	public unsafe void SetUV(int NewU, int NewUL, int NewV, int NewVL)
	{
		CheckDestroyed();
		if (!SetUV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BillboardComponent:SetUV");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUV_NewU_Offset), 0, SetUV_NewU_PropertyAddress.Address, NewU);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUV_NewUL_Offset), 0, SetUV_NewUL_PropertyAddress.Address, NewUL);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUV_NewV_Offset), 0, SetUV_NewV_PropertyAddress.Address, NewV);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUV_NewVL_Offset), 0, SetUV_NewVL_PropertyAddress.Address, NewVL);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUV_FunctionAddress, intPtr, SetUV_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.BillboardComponent:SetSpriteAndUV")]
	public unsafe void SetSpriteAndUV(UTexture2D NewSprite, int NewU, int NewUL, int NewV, int NewVL)
	{
		CheckDestroyed();
		if (!SetSpriteAndUV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BillboardComponent:SetSpriteAndUV");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpriteAndUV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpriteAndUV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetSpriteAndUV_NewSprite_Offset), 0, SetSpriteAndUV_NewSprite_PropertyAddress.Address, NewSprite);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSpriteAndUV_NewU_Offset), 0, SetSpriteAndUV_NewU_PropertyAddress.Address, NewU);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSpriteAndUV_NewUL_Offset), 0, SetSpriteAndUV_NewUL_PropertyAddress.Address, NewUL);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSpriteAndUV_NewV_Offset), 0, SetSpriteAndUV_NewV_PropertyAddress.Address, NewV);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSpriteAndUV_NewVL_Offset), 0, SetSpriteAndUV_NewVL_PropertyAddress.Address, NewVL);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpriteAndUV_FunctionAddress, intPtr, SetSpriteAndUV_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.BillboardComponent:SetSprite")]
	public unsafe void SetSprite(UTexture2D NewSprite)
	{
		CheckDestroyed();
		if (!SetSprite_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BillboardComponent:SetSprite");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSprite_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSprite_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetSprite_NewSprite_Offset), 0, SetSprite_NewSprite_PropertyAddress.Address, NewSprite);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSprite_FunctionAddress, intPtr, SetSprite_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.BillboardComponent:SetOpacityMaskRefVal")]
	public unsafe void SetOpacityMaskRefVal(float RefVal)
	{
		CheckDestroyed();
		if (!SetOpacityMaskRefVal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BillboardComponent:SetOpacityMaskRefVal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOpacityMaskRefVal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOpacityMaskRefVal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOpacityMaskRefVal_RefVal_Offset), 0, SetOpacityMaskRefVal_RefVal_PropertyAddress.Address, RefVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOpacityMaskRefVal_FunctionAddress, intPtr, SetOpacityMaskRefVal_ParamsSize);
	}

	static UBillboardComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBillboardComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBillboardComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.BillboardComponent");
		Sprite_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Sprite");
		Sprite_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Sprite", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsScreenSizeScaled_PropertyAddress, intPtr, "bIsScreenSizeScaled");
		IsScreenSizeScaled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsScreenSizeScaled");
		IsScreenSizeScaled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsScreenSizeScaled", Classes.FBoolProperty);
		ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScreenSize");
		ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScreenSize", Classes.FFloatProperty);
		U_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "U");
		U_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "U", Classes.FFloatProperty);
		UL_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UL");
		UL_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UL", Classes.FFloatProperty);
		V_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "V");
		V_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "V", Classes.FFloatProperty);
		VL_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VL");
		VL_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VL", Classes.FFloatProperty);
		OpacityMaskRefVal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OpacityMaskRefVal");
		OpacityMaskRefVal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OpacityMaskRefVal", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseInEditorScaling_PropertyAddress, intPtr, "bUseInEditorScaling");
		UseInEditorScaling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseInEditorScaling");
		UseInEditorScaling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseInEditorScaling", Classes.FBoolProperty);
		SetUV_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUV");
		SetUV_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUV_NewU_PropertyAddress, SetUV_FunctionAddress, "NewU");
		SetUV_NewU_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "NewU");
		SetUV_NewU_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "NewU", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUV_NewUL_PropertyAddress, SetUV_FunctionAddress, "NewUL");
		SetUV_NewUL_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "NewUL");
		SetUV_NewUL_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "NewUL", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUV_NewV_PropertyAddress, SetUV_FunctionAddress, "NewV");
		SetUV_NewV_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "NewV");
		SetUV_NewV_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "NewV", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUV_NewVL_PropertyAddress, SetUV_FunctionAddress, "NewVL");
		SetUV_NewVL_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "NewVL");
		SetUV_NewVL_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "NewVL", Classes.FIntProperty);
		SetUV_IsValid = SetUV_FunctionAddress != IntPtr.Zero && SetUV_NewU_IsValid && SetUV_NewUL_IsValid && SetUV_NewV_IsValid && SetUV_NewVL_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BillboardComponent:SetUV", SetUV_IsValid);
		SetSpriteAndUV_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpriteAndUV");
		SetSpriteAndUV_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpriteAndUV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpriteAndUV_NewSprite_PropertyAddress, SetSpriteAndUV_FunctionAddress, "NewSprite");
		SetSpriteAndUV_NewSprite_Offset = NativeReflectionCached.GetPropertyOffset(SetSpriteAndUV_FunctionAddress, "NewSprite");
		SetSpriteAndUV_NewSprite_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpriteAndUV_FunctionAddress, "NewSprite", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSpriteAndUV_NewU_PropertyAddress, SetSpriteAndUV_FunctionAddress, "NewU");
		SetSpriteAndUV_NewU_Offset = NativeReflectionCached.GetPropertyOffset(SetSpriteAndUV_FunctionAddress, "NewU");
		SetSpriteAndUV_NewU_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpriteAndUV_FunctionAddress, "NewU", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSpriteAndUV_NewUL_PropertyAddress, SetSpriteAndUV_FunctionAddress, "NewUL");
		SetSpriteAndUV_NewUL_Offset = NativeReflectionCached.GetPropertyOffset(SetSpriteAndUV_FunctionAddress, "NewUL");
		SetSpriteAndUV_NewUL_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpriteAndUV_FunctionAddress, "NewUL", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSpriteAndUV_NewV_PropertyAddress, SetSpriteAndUV_FunctionAddress, "NewV");
		SetSpriteAndUV_NewV_Offset = NativeReflectionCached.GetPropertyOffset(SetSpriteAndUV_FunctionAddress, "NewV");
		SetSpriteAndUV_NewV_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpriteAndUV_FunctionAddress, "NewV", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSpriteAndUV_NewVL_PropertyAddress, SetSpriteAndUV_FunctionAddress, "NewVL");
		SetSpriteAndUV_NewVL_Offset = NativeReflectionCached.GetPropertyOffset(SetSpriteAndUV_FunctionAddress, "NewVL");
		SetSpriteAndUV_NewVL_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpriteAndUV_FunctionAddress, "NewVL", Classes.FIntProperty);
		SetSpriteAndUV_IsValid = SetSpriteAndUV_FunctionAddress != IntPtr.Zero && SetSpriteAndUV_NewSprite_IsValid && SetSpriteAndUV_NewU_IsValid && SetSpriteAndUV_NewUL_IsValid && SetSpriteAndUV_NewV_IsValid && SetSpriteAndUV_NewVL_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BillboardComponent:SetSpriteAndUV", SetSpriteAndUV_IsValid);
		SetSprite_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSprite");
		SetSprite_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSprite_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSprite_NewSprite_PropertyAddress, SetSprite_FunctionAddress, "NewSprite");
		SetSprite_NewSprite_Offset = NativeReflectionCached.GetPropertyOffset(SetSprite_FunctionAddress, "NewSprite");
		SetSprite_NewSprite_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSprite_FunctionAddress, "NewSprite", Classes.FObjectProperty);
		SetSprite_IsValid = SetSprite_FunctionAddress != IntPtr.Zero && SetSprite_NewSprite_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BillboardComponent:SetSprite", SetSprite_IsValid);
		SetOpacityMaskRefVal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOpacityMaskRefVal");
		SetOpacityMaskRefVal_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOpacityMaskRefVal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOpacityMaskRefVal_RefVal_PropertyAddress, SetOpacityMaskRefVal_FunctionAddress, "RefVal");
		SetOpacityMaskRefVal_RefVal_Offset = NativeReflectionCached.GetPropertyOffset(SetOpacityMaskRefVal_FunctionAddress, "RefVal");
		SetOpacityMaskRefVal_RefVal_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOpacityMaskRefVal_FunctionAddress, "RefVal", Classes.FFloatProperty);
		SetOpacityMaskRefVal_IsValid = SetOpacityMaskRefVal_FunctionAddress != IntPtr.Zero && SetOpacityMaskRefVal_RefVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BillboardComponent:SetOpacityMaskRefVal", SetOpacityMaskRefVal_IsValid);
	}
}
