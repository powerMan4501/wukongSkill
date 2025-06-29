using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)819990688uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSInput.GSInputDisplayWidget", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputDisplayWidget : UUserWidget
{
	private static bool InputDisplayType_IsValid;

	private static FFieldAddress InputDisplayType_PropertyAddress;

	private static int InputDisplayType_Offset;

	private static bool BindButtonKey_IsValid;

	private static int BindButtonKey_Offset;

	private static bool BindXKey_IsValid;

	private static int BindXKey_Offset;

	private static bool BindYKey_IsValid;

	private static int BindYKey_Offset;

	private static bool ShowText_1_IsValid;

	private static int ShowText_1_Offset;

	private static bool ShowText_2_IsValid;

	private static int ShowText_2_Offset;

	private static bool JoystickMoveLength_IsValid;

	private static int JoystickMoveLength_Offset;

	private static bool SetMousePos_IsValid;

	private static IntPtr SetMousePos_FunctionAddress;

	private static int SetMousePos_ParamsSize;

	private static bool SetMousePos_InMousePos_IsValid;

	private static FFieldAddress SetMousePos_InMousePos_PropertyAddress;

	private static int SetMousePos_InMousePos_Offset;

	private static bool SetIsPress_IsValid;

	private static IntPtr SetIsPress_FunctionAddress;

	private static int SetIsPress_ParamsSize;

	private static bool SetIsPress_InIsPress_IsValid;

	private static FFieldAddress SetIsPress_InIsPress_PropertyAddress;

	private static int SetIsPress_InIsPress_Offset;

	private static bool SetAxisValue_IsValid;

	private static IntPtr SetAxisValue_FunctionAddress;

	private static int SetAxisValue_ParamsSize;

	private static bool SetAxisValue_InKey_IsValid;

	private static FFieldAddress SetAxisValue_InKey_PropertyAddress;

	private static int SetAxisValue_InKey_Offset;

	private static bool SetAxisValue_InAxisValue_IsValid;

	private static FFieldAddress SetAxisValue_InAxisValue_PropertyAddress;

	private static int SetAxisValue_InAxisValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:InputDisplayType")]
	public EInputDisplayType InputDisplayType
	{
		get
		{
			CheckDestroyed();
			if (!InputDisplayType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:InputDisplayType");
				return EInputDisplayType.NORNAL_BUTTON;
			}
			return EnumMarshaler<EInputDisplayType>.FromNative(IntPtr.Add(base.Address, InputDisplayType_Offset), 0, InputDisplayType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InputDisplayType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:InputDisplayType");
			}
			else
			{
				EnumMarshaler<EInputDisplayType>.ToNative(IntPtr.Add(base.Address, InputDisplayType_Offset), 0, InputDisplayType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:BindButtonKey")]
	public FKey BindButtonKey
	{
		get
		{
			CheckDestroyed();
			if (!BindButtonKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:BindButtonKey");
				return default(FKey);
			}
			return FKey.FromNative(IntPtr.Add(base.Address, BindButtonKey_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindButtonKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:BindButtonKey");
			}
			else
			{
				FKey.ToNative(IntPtr.Add(base.Address, BindButtonKey_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:BindXKey")]
	public FKey BindXKey
	{
		get
		{
			CheckDestroyed();
			if (!BindXKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:BindXKey");
				return default(FKey);
			}
			return FKey.FromNative(IntPtr.Add(base.Address, BindXKey_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindXKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:BindXKey");
			}
			else
			{
				FKey.ToNative(IntPtr.Add(base.Address, BindXKey_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:BindYKey")]
	public FKey BindYKey
	{
		get
		{
			CheckDestroyed();
			if (!BindYKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:BindYKey");
				return default(FKey);
			}
			return FKey.FromNative(IntPtr.Add(base.Address, BindYKey_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindYKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:BindYKey");
			}
			else
			{
				FKey.ToNative(IntPtr.Add(base.Address, BindYKey_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:ShowText_1")]
	public string ShowText_1
	{
		get
		{
			CheckDestroyed();
			if (!ShowText_1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:ShowText_1");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ShowText_1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShowText_1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:ShowText_1");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ShowText_1_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:ShowText_2")]
	public string ShowText_2
	{
		get
		{
			CheckDestroyed();
			if (!ShowText_2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:ShowText_2");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ShowText_2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShowText_2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:ShowText_2");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ShowText_2_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:JoystickMoveLength")]
	public float JoystickMoveLength
	{
		get
		{
			CheckDestroyed();
			if (!JoystickMoveLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:JoystickMoveLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JoystickMoveLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JoystickMoveLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayWidget:JoystickMoveLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JoystickMoveLength_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629576u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:SetMousePos")]
	public unsafe void SetMousePos(FVector2D InMousePos)
	{
		CheckDestroyed();
		if (!SetMousePos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayWidget:SetMousePos");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMousePos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMousePos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetMousePos_InMousePos_Offset), 0, SetMousePos_InMousePos_PropertyAddress.Address, InMousePos);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMousePos_FunctionAddress, intPtr, SetMousePos_ParamsSize);
	}

	[UFunction(Flags = 67240968u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:SetIsPress")]
	public unsafe void SetIsPress(bool InIsPress)
	{
		CheckDestroyed();
		if (!SetIsPress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayWidget:SetIsPress");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsPress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsPress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsPress_InIsPress_Offset), 0, SetIsPress_InIsPress_PropertyAddress.Address, InIsPress);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsPress_FunctionAddress, intPtr, SetIsPress_ParamsSize);
	}

	[UFunction(Flags = 67240968u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayWidget:SetAxisValue")]
	public unsafe void SetAxisValue(FKey InKey, float InAxisValue)
	{
		CheckDestroyed();
		if (!SetAxisValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayWidget:SetAxisValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAxisValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAxisValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAxisValue_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, SetAxisValue_InKey_Offset), 0, SetAxisValue_InKey_PropertyAddress.Address, InKey);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAxisValue_InAxisValue_Offset), 0, SetAxisValue_InAxisValue_PropertyAddress.Address, InAxisValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAxisValue_FunctionAddress, intPtr, SetAxisValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAxisValue_InKey_PropertyAddress.Address, intPtr);
	}

	static UGSInputDisplayWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputDisplayWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputDisplayWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSInput.GSInputDisplayWidget");
		NativeReflectionCached.GetPropertyRef(ref InputDisplayType_PropertyAddress, intPtr, "InputDisplayType");
		InputDisplayType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputDisplayType");
		InputDisplayType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputDisplayType", Classes.FEnumProperty);
		BindButtonKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BindButtonKey");
		BindButtonKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BindButtonKey", Classes.FStructProperty);
		BindXKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BindXKey");
		BindXKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BindXKey", Classes.FStructProperty);
		BindYKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BindYKey");
		BindYKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BindYKey", Classes.FStructProperty);
		ShowText_1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowText_1");
		ShowText_1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowText_1", Classes.FStrProperty);
		ShowText_2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowText_2");
		ShowText_2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowText_2", Classes.FStrProperty);
		JoystickMoveLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JoystickMoveLength");
		JoystickMoveLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JoystickMoveLength", Classes.FFloatProperty);
		SetMousePos_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMousePos");
		SetMousePos_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMousePos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMousePos_InMousePos_PropertyAddress, SetMousePos_FunctionAddress, "InMousePos");
		SetMousePos_InMousePos_Offset = NativeReflectionCached.GetPropertyOffset(SetMousePos_FunctionAddress, "InMousePos");
		SetMousePos_InMousePos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMousePos_FunctionAddress, "InMousePos", Classes.FStructProperty);
		SetMousePos_IsValid = SetMousePos_FunctionAddress != IntPtr.Zero && SetMousePos_InMousePos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayWidget:SetMousePos", SetMousePos_IsValid);
		SetIsPress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsPress");
		SetIsPress_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsPress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsPress_InIsPress_PropertyAddress, SetIsPress_FunctionAddress, "InIsPress");
		SetIsPress_InIsPress_Offset = NativeReflectionCached.GetPropertyOffset(SetIsPress_FunctionAddress, "InIsPress");
		SetIsPress_InIsPress_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsPress_FunctionAddress, "InIsPress", Classes.FBoolProperty);
		SetIsPress_IsValid = SetIsPress_FunctionAddress != IntPtr.Zero && SetIsPress_InIsPress_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayWidget:SetIsPress", SetIsPress_IsValid);
		SetAxisValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAxisValue");
		SetAxisValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAxisValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAxisValue_InKey_PropertyAddress, SetAxisValue_FunctionAddress, "InKey");
		SetAxisValue_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetAxisValue_FunctionAddress, "InKey");
		SetAxisValue_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAxisValue_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAxisValue_InAxisValue_PropertyAddress, SetAxisValue_FunctionAddress, "InAxisValue");
		SetAxisValue_InAxisValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAxisValue_FunctionAddress, "InAxisValue");
		SetAxisValue_InAxisValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAxisValue_FunctionAddress, "InAxisValue", Classes.FFloatProperty);
		SetAxisValue_IsValid = SetAxisValue_FunctionAddress != IntPtr.Zero && SetAxisValue_InKey_IsValid && SetAxisValue_InAxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayWidget:SetAxisValue", SetAxisValue_IsValid);
	}
}
