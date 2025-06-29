using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)821039264uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSInput.GSInputDisplayUI", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputDisplayUI : UUserWidget
{
	private static bool IsCanSetting_IsValid;

	private static FFieldAddress IsCanSetting_PropertyAddress;

	private static int IsCanSetting_Offset;

	private static bool NormalSize_IsValid;

	private static int NormalSize_Offset;

	private static bool ChangeScaleSpeed_IsValid;

	private static int ChangeScaleSpeed_Offset;

	private static bool MaxScaleRate_IsValid;

	private static int MaxScaleRate_Offset;

	private static bool MinScaleRate_IsValid;

	private static int MinScaleRate_Offset;

	private static bool PosCon_IsValid;

	private static int PosCon_Offset;

	private static bool GamepadCon_IsValid;

	private static int GamepadCon_Offset;

	private static bool KeyboardCon_IsValid;

	private static int KeyboardCon_Offset;

	private static bool SetIsShow_IsValid;

	private static IntPtr SetIsShow_FunctionAddress;

	private static int SetIsShow_ParamsSize;

	private static bool SetIsShow_IsShow_IsValid;

	private static FFieldAddress SetIsShow_IsShow_PropertyAddress;

	private static int SetIsShow_IsShow_Offset;

	private static bool ResetSetting_IsValid;

	private static IntPtr ResetSetting_FunctionAddress;

	private static int ResetSetting_ParamsSize;

	private static bool OnInputMouseWheelOrGesture_IsValid;

	private IntPtr OnInputMouseWheelOrGesture_InstanceFunctionAddress;

	private static IntPtr OnInputMouseWheelOrGesture_FunctionAddress;

	private static int OnInputMouseWheelOrGesture_ParamsSize;

	private static bool OnInputMouseWheelOrGesture_InWheelDelta_IsValid;

	private static FFieldAddress OnInputMouseWheelOrGesture_InWheelDelta_PropertyAddress;

	private static int OnInputMouseWheelOrGesture_InWheelDelta_Offset;

	private static bool OnInputMouseMove_IsValid;

	private IntPtr OnInputMouseMove_InstanceFunctionAddress;

	private static IntPtr OnInputMouseMove_FunctionAddress;

	private static int OnInputMouseMove_ParamsSize;

	private static bool OnInputMouseMove_InMousePos_IsValid;

	private static FFieldAddress OnInputMouseMove_InMousePos_PropertyAddress;

	private static int OnInputMouseMove_InMousePos_Offset;

	private static bool OnInputMouseButtonUp_IsValid;

	private IntPtr OnInputMouseButtonUp_InstanceFunctionAddress;

	private static IntPtr OnInputMouseButtonUp_FunctionAddress;

	private static int OnInputMouseButtonUp_ParamsSize;

	private static bool OnInputMouseButtonUp_InKey_IsValid;

	private static FFieldAddress OnInputMouseButtonUp_InKey_PropertyAddress;

	private static int OnInputMouseButtonUp_InKey_Offset;

	private static bool OnInputMouseButtonDown_IsValid;

	private IntPtr OnInputMouseButtonDown_InstanceFunctionAddress;

	private static IntPtr OnInputMouseButtonDown_FunctionAddress;

	private static int OnInputMouseButtonDown_ParamsSize;

	private static bool OnInputMouseButtonDown_InKey_IsValid;

	private static FFieldAddress OnInputMouseButtonDown_InKey_PropertyAddress;

	private static int OnInputMouseButtonDown_InKey_Offset;

	private static bool OnInputMouseButtonDoubleClick_IsValid;

	private IntPtr OnInputMouseButtonDoubleClick_InstanceFunctionAddress;

	private static IntPtr OnInputMouseButtonDoubleClick_FunctionAddress;

	private static int OnInputMouseButtonDoubleClick_ParamsSize;

	private static bool OnInputMouseButtonDoubleClick_InKey_IsValid;

	private static FFieldAddress OnInputMouseButtonDoubleClick_InKey_PropertyAddress;

	private static int OnInputMouseButtonDoubleClick_InKey_Offset;

	private static bool OnInputKeyUp_IsValid;

	private IntPtr OnInputKeyUp_InstanceFunctionAddress;

	private static IntPtr OnInputKeyUp_FunctionAddress;

	private static int OnInputKeyUp_ParamsSize;

	private static bool OnInputKeyUp_InKey_IsValid;

	private static FFieldAddress OnInputKeyUp_InKey_PropertyAddress;

	private static int OnInputKeyUp_InKey_Offset;

	private static bool OnInputKeyDown_IsValid;

	private IntPtr OnInputKeyDown_InstanceFunctionAddress;

	private static IntPtr OnInputKeyDown_FunctionAddress;

	private static int OnInputKeyDown_ParamsSize;

	private static bool OnInputKeyDown_InKey_IsValid;

	private static FFieldAddress OnInputKeyDown_InKey_PropertyAddress;

	private static int OnInputKeyDown_InKey_Offset;

	private static bool OnInputAxisChange_IsValid;

	private IntPtr OnInputAxisChange_InstanceFunctionAddress;

	private static IntPtr OnInputAxisChange_FunctionAddress;

	private static int OnInputAxisChange_ParamsSize;

	private static bool OnInputAxisChange_InKey_IsValid;

	private static FFieldAddress OnInputAxisChange_InKey_PropertyAddress;

	private static int OnInputAxisChange_InKey_Offset;

	private static bool OnInputAxisChange_InAxisValue_IsValid;

	private static FFieldAddress OnInputAxisChange_InAxisValue_PropertyAddress;

	private static int OnInputAxisChange_InAxisValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:IsCanSetting")]
	public bool IsCanSetting
	{
		get
		{
			CheckDestroyed();
			if (!IsCanSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:IsCanSetting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCanSetting_Offset), 0, IsCanSetting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCanSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:IsCanSetting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCanSetting_Offset), 0, IsCanSetting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:NormalSize")]
	public FVector2D NormalSize
	{
		get
		{
			CheckDestroyed();
			if (!NormalSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:NormalSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, NormalSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:NormalSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, NormalSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:ChangeScaleSpeed")]
	public float ChangeScaleSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ChangeScaleSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:ChangeScaleSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ChangeScaleSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChangeScaleSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:ChangeScaleSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ChangeScaleSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:MaxScaleRate")]
	public float MaxScaleRate
	{
		get
		{
			CheckDestroyed();
			if (!MaxScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:MaxScaleRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxScaleRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:MaxScaleRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxScaleRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:MinScaleRate")]
	public float MinScaleRate
	{
		get
		{
			CheckDestroyed();
			if (!MinScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:MinScaleRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinScaleRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:MinScaleRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinScaleRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799116uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:PosCon")]
	public UCanvasPanel PosCon
	{
		get
		{
			CheckDestroyed();
			if (!PosCon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:PosCon");
				return null;
			}
			return UObjectMarshaler<UCanvasPanel>.FromNative(IntPtr.Add(base.Address, PosCon_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PosCon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:PosCon");
			}
			else
			{
				UObjectMarshaler<UCanvasPanel>.ToNative(IntPtr.Add(base.Address, PosCon_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799116uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:GamepadCon")]
	public UCanvasPanel GamepadCon
	{
		get
		{
			CheckDestroyed();
			if (!GamepadCon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:GamepadCon");
				return null;
			}
			return UObjectMarshaler<UCanvasPanel>.FromNative(IntPtr.Add(base.Address, GamepadCon_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GamepadCon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:GamepadCon");
			}
			else
			{
				UObjectMarshaler<UCanvasPanel>.ToNative(IntPtr.Add(base.Address, GamepadCon_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799116uL)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:KeyboardCon")]
	public UCanvasPanel KeyboardCon
	{
		get
		{
			CheckDestroyed();
			if (!KeyboardCon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:KeyboardCon");
				return null;
			}
			return UObjectMarshaler<UCanvasPanel>.FromNative(IntPtr.Add(base.Address, KeyboardCon_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KeyboardCon_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputDisplayUI:KeyboardCon");
			}
			else
			{
				UObjectMarshaler<UCanvasPanel>.ToNative(IntPtr.Add(base.Address, KeyboardCon_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:SetIsShow")]
	public unsafe void SetIsShow(bool IsShow)
	{
		CheckDestroyed();
		if (!SetIsShow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:SetIsShow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsShow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsShow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsShow_IsShow_Offset), 0, SetIsShow_IsShow_PropertyAddress.Address, IsShow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsShow_FunctionAddress, intPtr, SetIsShow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:ResetSetting")]
	public unsafe void ResetSetting()
	{
		CheckDestroyed();
		if (!ResetSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:ResetSetting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetSetting_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetSetting_FunctionAddress, argsSize: ResetSetting_ParamsSize);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:OnInputMouseWheelOrGesture")]
	public unsafe void OnInputMouseWheelOrGesture(float InWheelDelta)
	{
		CheckDestroyed();
		if (!OnInputMouseWheelOrGesture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseWheelOrGesture");
			return;
		}
		if (OnInputMouseWheelOrGesture_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputMouseWheelOrGesture_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputMouseWheelOrGesture");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseWheelOrGesture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseWheelOrGesture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputMouseWheelOrGesture_InWheelDelta_Offset), 0, OnInputMouseWheelOrGesture_InWheelDelta_PropertyAddress.Address, InWheelDelta);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseWheelOrGesture_InstanceFunctionAddress, intPtr, OnInputMouseWheelOrGesture_ParamsSize);
	}

	protected unsafe virtual void OnInputMouseWheelOrGesture_Implementation(float InWheelDelta)
	{
		CheckDestroyed();
		if (!OnInputMouseWheelOrGesture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseWheelOrGesture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseWheelOrGesture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseWheelOrGesture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputMouseWheelOrGesture_InWheelDelta_Offset), 0, OnInputMouseWheelOrGesture_InWheelDelta_PropertyAddress.Address, InWheelDelta);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseWheelOrGesture_FunctionAddress, intPtr, OnInputMouseWheelOrGesture_ParamsSize);
	}

	[UFunction(Flags = 142740488u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:OnInputMouseMove")]
	public unsafe void OnInputMouseMove(FVector2D InMousePos)
	{
		CheckDestroyed();
		if (!OnInputMouseMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseMove");
			return;
		}
		if (OnInputMouseMove_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputMouseMove_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputMouseMove");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, OnInputMouseMove_InMousePos_Offset), 0, OnInputMouseMove_InMousePos_PropertyAddress.Address, InMousePos);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseMove_InstanceFunctionAddress, intPtr, OnInputMouseMove_ParamsSize);
	}

	protected unsafe virtual void OnInputMouseMove_Implementation(FVector2D InMousePos)
	{
		CheckDestroyed();
		if (!OnInputMouseMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseMove");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, OnInputMouseMove_InMousePos_Offset), 0, OnInputMouseMove_InMousePos_PropertyAddress.Address, InMousePos);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseMove_FunctionAddress, intPtr, OnInputMouseMove_ParamsSize);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonUp")]
	public unsafe void OnInputMouseButtonUp(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputMouseButtonUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonUp");
			return;
		}
		if (OnInputMouseButtonUp_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputMouseButtonUp_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputMouseButtonUp");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseButtonUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseButtonUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputMouseButtonUp_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputMouseButtonUp_InKey_Offset), 0, OnInputMouseButtonUp_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseButtonUp_InstanceFunctionAddress, intPtr, OnInputMouseButtonUp_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputMouseButtonUp_InKey_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnInputMouseButtonUp_Implementation(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputMouseButtonUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonUp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseButtonUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseButtonUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputMouseButtonUp_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputMouseButtonUp_InKey_Offset), 0, OnInputMouseButtonUp_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseButtonUp_FunctionAddress, intPtr, OnInputMouseButtonUp_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputMouseButtonUp_InKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonDown")]
	public unsafe void OnInputMouseButtonDown(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonDown");
			return;
		}
		if (OnInputMouseButtonDown_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputMouseButtonDown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputMouseButtonDown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputMouseButtonDown_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputMouseButtonDown_InKey_Offset), 0, OnInputMouseButtonDown_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseButtonDown_InstanceFunctionAddress, intPtr, OnInputMouseButtonDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputMouseButtonDown_InKey_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnInputMouseButtonDown_Implementation(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonDown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputMouseButtonDown_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputMouseButtonDown_InKey_Offset), 0, OnInputMouseButtonDown_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseButtonDown_FunctionAddress, intPtr, OnInputMouseButtonDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputMouseButtonDown_InKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonDoubleClick")]
	public unsafe void OnInputMouseButtonDoubleClick(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputMouseButtonDoubleClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonDoubleClick");
			return;
		}
		if (OnInputMouseButtonDoubleClick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputMouseButtonDoubleClick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputMouseButtonDoubleClick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseButtonDoubleClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseButtonDoubleClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputMouseButtonDoubleClick_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputMouseButtonDoubleClick_InKey_Offset), 0, OnInputMouseButtonDoubleClick_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseButtonDoubleClick_InstanceFunctionAddress, intPtr, OnInputMouseButtonDoubleClick_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputMouseButtonDoubleClick_InKey_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnInputMouseButtonDoubleClick_Implementation(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputMouseButtonDoubleClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonDoubleClick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputMouseButtonDoubleClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputMouseButtonDoubleClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputMouseButtonDoubleClick_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputMouseButtonDoubleClick_InKey_Offset), 0, OnInputMouseButtonDoubleClick_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputMouseButtonDoubleClick_FunctionAddress, intPtr, OnInputMouseButtonDoubleClick_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputMouseButtonDoubleClick_InKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:OnInputKeyUp")]
	public unsafe void OnInputKeyUp(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputKeyUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputKeyUp");
			return;
		}
		if (OnInputKeyUp_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputKeyUp_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputKeyUp");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputKeyUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputKeyUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputKeyUp_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputKeyUp_InKey_Offset), 0, OnInputKeyUp_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputKeyUp_InstanceFunctionAddress, intPtr, OnInputKeyUp_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputKeyUp_InKey_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnInputKeyUp_Implementation(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputKeyUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputKeyUp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputKeyUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputKeyUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputKeyUp_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputKeyUp_InKey_Offset), 0, OnInputKeyUp_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputKeyUp_FunctionAddress, intPtr, OnInputKeyUp_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputKeyUp_InKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:OnInputKeyDown")]
	public unsafe void OnInputKeyDown(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputKeyDown");
			return;
		}
		if (OnInputKeyDown_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputKeyDown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputKeyDown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputKeyDown_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputKeyDown_InKey_Offset), 0, OnInputKeyDown_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputKeyDown_InstanceFunctionAddress, intPtr, OnInputKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputKeyDown_InKey_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnInputKeyDown_Implementation(FKey InKey)
	{
		CheckDestroyed();
		if (!OnInputKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputKeyDown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputKeyDown_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputKeyDown_InKey_Offset), 0, OnInputKeyDown_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputKeyDown_FunctionAddress, intPtr, OnInputKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputKeyDown_InKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/GSInput.GSInputDisplayUI:OnInputAxisChange")]
	public unsafe void OnInputAxisChange(FKey InKey, float InAxisValue)
	{
		CheckDestroyed();
		if (!OnInputAxisChange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputAxisChange");
			return;
		}
		if (OnInputAxisChange_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputAxisChange_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputAxisChange");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputAxisChange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputAxisChange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputAxisChange_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputAxisChange_InKey_Offset), 0, OnInputAxisChange_InKey_PropertyAddress.Address, InKey);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputAxisChange_InAxisValue_Offset), 0, OnInputAxisChange_InAxisValue_PropertyAddress.Address, InAxisValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputAxisChange_InstanceFunctionAddress, intPtr, OnInputAxisChange_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputAxisChange_InKey_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnInputAxisChange_Implementation(FKey InKey, float InAxisValue)
	{
		CheckDestroyed();
		if (!OnInputAxisChange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputDisplayUI:OnInputAxisChange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputAxisChange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputAxisChange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnInputAxisChange_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, OnInputAxisChange_InKey_Offset), 0, OnInputAxisChange_InKey_PropertyAddress.Address, InKey);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputAxisChange_InAxisValue_Offset), 0, OnInputAxisChange_InAxisValue_PropertyAddress.Address, InAxisValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputAxisChange_FunctionAddress, intPtr, OnInputAxisChange_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnInputAxisChange_InKey_PropertyAddress.Address, intPtr);
	}

	static UGSInputDisplayUI()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputDisplayUI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputDisplayUI));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSInput.GSInputDisplayUI");
		NativeReflectionCached.GetPropertyRef(ref IsCanSetting_PropertyAddress, intPtr, "IsCanSetting");
		IsCanSetting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsCanSetting");
		IsCanSetting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsCanSetting", Classes.FBoolProperty);
		NormalSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalSize");
		NormalSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalSize", Classes.FStructProperty);
		ChangeScaleSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChangeScaleSpeed");
		ChangeScaleSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChangeScaleSpeed", Classes.FFloatProperty);
		MaxScaleRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxScaleRate");
		MaxScaleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxScaleRate", Classes.FFloatProperty);
		MinScaleRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinScaleRate");
		MinScaleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinScaleRate", Classes.FFloatProperty);
		PosCon_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PosCon");
		PosCon_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PosCon", Classes.FObjectProperty);
		GamepadCon_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GamepadCon");
		GamepadCon_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GamepadCon", Classes.FObjectProperty);
		KeyboardCon_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeyboardCon");
		KeyboardCon_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeyboardCon", Classes.FObjectProperty);
		SetIsShow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsShow");
		SetIsShow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsShow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsShow_IsShow_PropertyAddress, SetIsShow_FunctionAddress, "IsShow");
		SetIsShow_IsShow_Offset = NativeReflectionCached.GetPropertyOffset(SetIsShow_FunctionAddress, "IsShow");
		SetIsShow_IsShow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsShow_FunctionAddress, "IsShow", Classes.FBoolProperty);
		SetIsShow_IsValid = SetIsShow_FunctionAddress != IntPtr.Zero && SetIsShow_IsShow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:SetIsShow", SetIsShow_IsValid);
		ResetSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetSetting");
		ResetSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetSetting_FunctionAddress);
		ResetSetting_IsValid = ResetSetting_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:ResetSetting", ResetSetting_IsValid);
		OnInputMouseWheelOrGesture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInputMouseWheelOrGesture");
		OnInputMouseWheelOrGesture_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputMouseWheelOrGesture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputMouseWheelOrGesture_InWheelDelta_PropertyAddress, OnInputMouseWheelOrGesture_FunctionAddress, "InWheelDelta");
		OnInputMouseWheelOrGesture_InWheelDelta_Offset = NativeReflectionCached.GetPropertyOffset(OnInputMouseWheelOrGesture_FunctionAddress, "InWheelDelta");
		OnInputMouseWheelOrGesture_InWheelDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputMouseWheelOrGesture_FunctionAddress, "InWheelDelta", Classes.FFloatProperty);
		OnInputMouseWheelOrGesture_IsValid = OnInputMouseWheelOrGesture_FunctionAddress != IntPtr.Zero && OnInputMouseWheelOrGesture_InWheelDelta_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:OnInputMouseWheelOrGesture", OnInputMouseWheelOrGesture_IsValid);
		OnInputMouseMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInputMouseMove");
		OnInputMouseMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputMouseMove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputMouseMove_InMousePos_PropertyAddress, OnInputMouseMove_FunctionAddress, "InMousePos");
		OnInputMouseMove_InMousePos_Offset = NativeReflectionCached.GetPropertyOffset(OnInputMouseMove_FunctionAddress, "InMousePos");
		OnInputMouseMove_InMousePos_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputMouseMove_FunctionAddress, "InMousePos", Classes.FStructProperty);
		OnInputMouseMove_IsValid = OnInputMouseMove_FunctionAddress != IntPtr.Zero && OnInputMouseMove_InMousePos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:OnInputMouseMove", OnInputMouseMove_IsValid);
		OnInputMouseButtonUp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInputMouseButtonUp");
		OnInputMouseButtonUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputMouseButtonUp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputMouseButtonUp_InKey_PropertyAddress, OnInputMouseButtonUp_FunctionAddress, "InKey");
		OnInputMouseButtonUp_InKey_Offset = NativeReflectionCached.GetPropertyOffset(OnInputMouseButtonUp_FunctionAddress, "InKey");
		OnInputMouseButtonUp_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputMouseButtonUp_FunctionAddress, "InKey", Classes.FStructProperty);
		OnInputMouseButtonUp_IsValid = OnInputMouseButtonUp_FunctionAddress != IntPtr.Zero && OnInputMouseButtonUp_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonUp", OnInputMouseButtonUp_IsValid);
		OnInputMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInputMouseButtonDown");
		OnInputMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputMouseButtonDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputMouseButtonDown_InKey_PropertyAddress, OnInputMouseButtonDown_FunctionAddress, "InKey");
		OnInputMouseButtonDown_InKey_Offset = NativeReflectionCached.GetPropertyOffset(OnInputMouseButtonDown_FunctionAddress, "InKey");
		OnInputMouseButtonDown_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputMouseButtonDown_FunctionAddress, "InKey", Classes.FStructProperty);
		OnInputMouseButtonDown_IsValid = OnInputMouseButtonDown_FunctionAddress != IntPtr.Zero && OnInputMouseButtonDown_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonDown", OnInputMouseButtonDown_IsValid);
		OnInputMouseButtonDoubleClick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInputMouseButtonDoubleClick");
		OnInputMouseButtonDoubleClick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputMouseButtonDoubleClick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputMouseButtonDoubleClick_InKey_PropertyAddress, OnInputMouseButtonDoubleClick_FunctionAddress, "InKey");
		OnInputMouseButtonDoubleClick_InKey_Offset = NativeReflectionCached.GetPropertyOffset(OnInputMouseButtonDoubleClick_FunctionAddress, "InKey");
		OnInputMouseButtonDoubleClick_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputMouseButtonDoubleClick_FunctionAddress, "InKey", Classes.FStructProperty);
		OnInputMouseButtonDoubleClick_IsValid = OnInputMouseButtonDoubleClick_FunctionAddress != IntPtr.Zero && OnInputMouseButtonDoubleClick_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:OnInputMouseButtonDoubleClick", OnInputMouseButtonDoubleClick_IsValid);
		OnInputKeyUp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInputKeyUp");
		OnInputKeyUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputKeyUp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputKeyUp_InKey_PropertyAddress, OnInputKeyUp_FunctionAddress, "InKey");
		OnInputKeyUp_InKey_Offset = NativeReflectionCached.GetPropertyOffset(OnInputKeyUp_FunctionAddress, "InKey");
		OnInputKeyUp_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputKeyUp_FunctionAddress, "InKey", Classes.FStructProperty);
		OnInputKeyUp_IsValid = OnInputKeyUp_FunctionAddress != IntPtr.Zero && OnInputKeyUp_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:OnInputKeyUp", OnInputKeyUp_IsValid);
		OnInputKeyDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInputKeyDown");
		OnInputKeyDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputKeyDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputKeyDown_InKey_PropertyAddress, OnInputKeyDown_FunctionAddress, "InKey");
		OnInputKeyDown_InKey_Offset = NativeReflectionCached.GetPropertyOffset(OnInputKeyDown_FunctionAddress, "InKey");
		OnInputKeyDown_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputKeyDown_FunctionAddress, "InKey", Classes.FStructProperty);
		OnInputKeyDown_IsValid = OnInputKeyDown_FunctionAddress != IntPtr.Zero && OnInputKeyDown_InKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:OnInputKeyDown", OnInputKeyDown_IsValid);
		OnInputAxisChange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInputAxisChange");
		OnInputAxisChange_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputAxisChange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputAxisChange_InKey_PropertyAddress, OnInputAxisChange_FunctionAddress, "InKey");
		OnInputAxisChange_InKey_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxisChange_FunctionAddress, "InKey");
		OnInputAxisChange_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxisChange_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnInputAxisChange_InAxisValue_PropertyAddress, OnInputAxisChange_FunctionAddress, "InAxisValue");
		OnInputAxisChange_InAxisValue_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxisChange_FunctionAddress, "InAxisValue");
		OnInputAxisChange_InAxisValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxisChange_FunctionAddress, "InAxisValue", Classes.FFloatProperty);
		OnInputAxisChange_IsValid = OnInputAxisChange_FunctionAddress != IntPtr.Zero && OnInputAxisChange_InKey_IsValid && OnInputAxisChange_InAxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputDisplayUI:OnInputAxisChange", OnInputAxisChange_IsValid);
	}
}
