using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimMontage", "Engine", UnrealModuleType.Engine)]
public class UAnimMontage : UAnimCompositeBase
{
	private static IntPtr classAddress;

	private static bool BlendModeIn_IsValid;

	private static FFieldAddress BlendModeIn_PropertyAddress;

	private static int BlendModeIn_Offset;

	private static bool BlendModeOut_IsValid;

	private static FFieldAddress BlendModeOut_PropertyAddress;

	private static int BlendModeOut_Offset;

	private static bool BlendProfileIn_IsValid;

	private static int BlendProfileIn_Offset;

	private static bool BlendProfileOut_IsValid;

	private static int BlendProfileOut_Offset;

	private static bool IsValidSectionName_IsValid;

	private static IntPtr IsValidSectionName_FunctionAddress;

	private static int IsValidSectionName_ParamsSize;

	private static bool IsValidSectionName_InSectionName_IsValid;

	private static FFieldAddress IsValidSectionName_InSectionName_PropertyAddress;

	private static int IsValidSectionName_InSectionName_Offset;

	private static bool IsValidSectionName_ReturnValue_IsValid;

	private static FFieldAddress IsValidSectionName_ReturnValue_PropertyAddress;

	private static int IsValidSectionName_ReturnValue_Offset;

	private static bool GetDefaultBlendOutTime_IsValid;

	private static IntPtr GetDefaultBlendOutTime_FunctionAddress;

	private static int GetDefaultBlendOutTime_ParamsSize;

	private static bool GetDefaultBlendOutTime_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultBlendOutTime_ReturnValue_PropertyAddress;

	private static int GetDefaultBlendOutTime_ReturnValue_Offset;

	private static bool GetDefaultBlendInTime_IsValid;

	private static IntPtr GetDefaultBlendInTime_FunctionAddress;

	private static int GetDefaultBlendInTime_ParamsSize;

	private static bool GetDefaultBlendInTime_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultBlendInTime_ReturnValue_PropertyAddress;

	private static int GetDefaultBlendInTime_ReturnValue_Offset;

	private static bool GetBlendOutArgs_IsValid;

	private static IntPtr GetBlendOutArgs_FunctionAddress;

	private static int GetBlendOutArgs_ParamsSize;

	private static bool GetBlendOutArgs_ReturnValue_IsValid;

	private static FFieldAddress GetBlendOutArgs_ReturnValue_PropertyAddress;

	private static int GetBlendOutArgs_ReturnValue_Offset;

	private static bool GetBlendInArgs_IsValid;

	private static IntPtr GetBlendInArgs_FunctionAddress;

	private static int GetBlendInArgs_ParamsSize;

	private static bool GetBlendInArgs_ReturnValue_IsValid;

	private static FFieldAddress GetBlendInArgs_ReturnValue_PropertyAddress;

	private static int GetBlendInArgs_ReturnValue_Offset;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_IsValid;

	private static IntPtr CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ParamsSize;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_IsValid;

	private static FFieldAddress CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_PropertyAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_Offset;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_IsValid;

	private static FFieldAddress CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_PropertyAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_Offset;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_IsValid;

	private static FFieldAddress CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_PropertyAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_Offset;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_IsValid;

	private static FFieldAddress CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_PropertyAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_Offset;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_IsValid;

	private static FFieldAddress CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_PropertyAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_Offset;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_IsValid;

	private static FFieldAddress CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_PropertyAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_Offset;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_IsValid;

	private static FFieldAddress CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_PropertyAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_Offset;

	private static bool CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_IsValid;

	private static FFieldAddress CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_PropertyAddress;

	private static int CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimMontage:BlendModeIn")]
	public EMontageBlendMode BlendModeIn
	{
		get
		{
			CheckDestroyed();
			if (!BlendModeIn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimMontage:BlendModeIn");
				return EMontageBlendMode.Standard;
			}
			return EnumMarshaler<EMontageBlendMode>.FromNative(IntPtr.Add(base.Address, BlendModeIn_Offset), 0, BlendModeIn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendModeIn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimMontage:BlendModeIn");
			}
			else
			{
				EnumMarshaler<EMontageBlendMode>.ToNative(IntPtr.Add(base.Address, BlendModeIn_Offset), 0, BlendModeIn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimMontage:BlendModeOut")]
	public EMontageBlendMode BlendModeOut
	{
		get
		{
			CheckDestroyed();
			if (!BlendModeOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimMontage:BlendModeOut");
				return EMontageBlendMode.Standard;
			}
			return EnumMarshaler<EMontageBlendMode>.FromNative(IntPtr.Add(base.Address, BlendModeOut_Offset), 0, BlendModeOut_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendModeOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimMontage:BlendModeOut");
			}
			else
			{
				EnumMarshaler<EMontageBlendMode>.ToNative(IntPtr.Add(base.Address, BlendModeOut_Offset), 0, BlendModeOut_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.AnimMontage:BlendProfileIn")]
	public UBlendProfile BlendProfileIn
	{
		get
		{
			CheckDestroyed();
			if (!BlendProfileIn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimMontage:BlendProfileIn");
				return null;
			}
			return UObjectMarshaler<UBlendProfile>.FromNative(IntPtr.Add(base.Address, BlendProfileIn_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendProfileIn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimMontage:BlendProfileIn");
			}
			else
			{
				UObjectMarshaler<UBlendProfile>.ToNative(IntPtr.Add(base.Address, BlendProfileIn_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.AnimMontage:BlendProfileOut")]
	public UBlendProfile BlendProfileOut
	{
		get
		{
			CheckDestroyed();
			if (!BlendProfileOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimMontage:BlendProfileOut");
				return null;
			}
			return UObjectMarshaler<UBlendProfile>.FromNative(IntPtr.Add(base.Address, BlendProfileOut_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendProfileOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimMontage:BlendProfileOut");
			}
			else
			{
				UObjectMarshaler<UBlendProfile>.ToNative(IntPtr.Add(base.Address, BlendProfileOut_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.AnimMontage:IsValidSectionName")]
	public unsafe bool IsValidSectionName(FName InSectionName)
	{
		CheckDestroyed();
		if (!IsValidSectionName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimMontage:IsValidSectionName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidSectionName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidSectionName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsValidSectionName_InSectionName_Offset), 0, IsValidSectionName_InSectionName_PropertyAddress.Address, InSectionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValidSectionName_FunctionAddress, intPtr, IsValidSectionName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidSectionName_ReturnValue_Offset), 0, IsValidSectionName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimMontage:GetDefaultBlendOutTime")]
	public unsafe float GetDefaultBlendOutTime()
	{
		CheckDestroyed();
		if (!GetDefaultBlendOutTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimMontage:GetDefaultBlendOutTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultBlendOutTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultBlendOutTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultBlendOutTime_FunctionAddress, intPtr, GetDefaultBlendOutTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDefaultBlendOutTime_ReturnValue_Offset), 0, GetDefaultBlendOutTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimMontage:GetDefaultBlendInTime")]
	public unsafe float GetDefaultBlendInTime()
	{
		CheckDestroyed();
		if (!GetDefaultBlendInTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimMontage:GetDefaultBlendInTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultBlendInTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultBlendInTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultBlendInTime_FunctionAddress, intPtr, GetDefaultBlendInTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDefaultBlendInTime_ReturnValue_Offset), 0, GetDefaultBlendInTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimMontage:GetBlendOutArgs")]
	public unsafe FAlphaBlendArgs GetBlendOutArgs()
	{
		CheckDestroyed();
		if (!GetBlendOutArgs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimMontage:GetBlendOutArgs");
			return default(FAlphaBlendArgs);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlendOutArgs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlendOutArgs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlendOutArgs_FunctionAddress, intPtr, GetBlendOutArgs_ParamsSize);
		return FAlphaBlendArgs.FromNative(IntPtr.Add(intPtr, GetBlendOutArgs_ReturnValue_Offset), 0, GetBlendOutArgs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AnimMontage:GetBlendInArgs")]
	public unsafe FAlphaBlendArgs GetBlendInArgs()
	{
		CheckDestroyed();
		if (!GetBlendInArgs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimMontage:GetBlendInArgs");
			return default(FAlphaBlendArgs);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlendInArgs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlendInArgs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlendInArgs_FunctionAddress, intPtr, GetBlendInArgs_ParamsSize);
		return FAlphaBlendArgs.FromNative(IntPtr.Add(intPtr, GetBlendInArgs_ReturnValue_Offset), 0, GetBlendInArgs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443459u)]
	[UMetaPath("/Script/Engine.AnimMontage:CreateSlotAnimationAsDynamicMontage_WithBlendSettings")]
	public unsafe static UAnimMontage CreateSlotAnimationAsDynamicMontage_WithBlendSettings(UAnimSequenceBase Asset, FName SlotNodeName, FMontageBlendSettings BlendInSettings, FMontageBlendSettings BlendOutSettings, float InPlayRate = 1f, int LoopCount = 1, float InBlendOutTriggerTime = -1f)
	{
		if (!CreateSlotAnimationAsDynamicMontage_WithBlendSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimMontage:CreateSlotAnimationAsDynamicMontage_WithBlendSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_Offset), 0, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_PropertyAddress.Address, Asset);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_Offset), 0, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_PropertyAddress.Address, SlotNodeName);
		NativeReflection.InitializeValue_InContainer(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_PropertyAddress.Address, intPtr);
		FMontageBlendSettings.ToNative(IntPtr.Add(intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_Offset), 0, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_PropertyAddress.Address, BlendInSettings);
		NativeReflection.InitializeValue_InContainer(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_PropertyAddress.Address, intPtr);
		FMontageBlendSettings.ToNative(IntPtr.Add(intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_Offset), 0, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_PropertyAddress.Address, BlendOutSettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_Offset), 0, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_PropertyAddress.Address, InPlayRate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_Offset), 0, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_PropertyAddress.Address, LoopCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_Offset), 0, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_PropertyAddress.Address, InBlendOutTriggerTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ParamsSize);
		return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(intPtr, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_Offset), 0, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_PropertyAddress.Address);
	}

	static UAnimMontage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimMontage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimMontage));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.AnimMontage");
		NativeReflectionCached.GetPropertyRef(ref BlendModeIn_PropertyAddress, classAddress, "BlendModeIn");
		BlendModeIn_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "BlendModeIn");
		BlendModeIn_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "BlendModeIn", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendModeOut_PropertyAddress, classAddress, "BlendModeOut");
		BlendModeOut_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "BlendModeOut");
		BlendModeOut_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "BlendModeOut", Classes.FEnumProperty);
		BlendProfileIn_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "BlendProfileIn");
		BlendProfileIn_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "BlendProfileIn", Classes.FObjectProperty);
		BlendProfileOut_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "BlendProfileOut");
		BlendProfileOut_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "BlendProfileOut", Classes.FObjectProperty);
		IsValidSectionName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidSectionName");
		IsValidSectionName_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidSectionName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidSectionName_InSectionName_PropertyAddress, IsValidSectionName_FunctionAddress, "InSectionName");
		IsValidSectionName_InSectionName_Offset = NativeReflectionCached.GetPropertyOffset(IsValidSectionName_FunctionAddress, "InSectionName");
		IsValidSectionName_InSectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidSectionName_FunctionAddress, "InSectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidSectionName_ReturnValue_PropertyAddress, IsValidSectionName_FunctionAddress, "ReturnValue");
		IsValidSectionName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidSectionName_FunctionAddress, "ReturnValue");
		IsValidSectionName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidSectionName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidSectionName_IsValid = IsValidSectionName_FunctionAddress != IntPtr.Zero && IsValidSectionName_InSectionName_IsValid && IsValidSectionName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimMontage:IsValidSectionName", IsValidSectionName_IsValid);
		GetDefaultBlendOutTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultBlendOutTime");
		GetDefaultBlendOutTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultBlendOutTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultBlendOutTime_ReturnValue_PropertyAddress, GetDefaultBlendOutTime_FunctionAddress, "ReturnValue");
		GetDefaultBlendOutTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultBlendOutTime_FunctionAddress, "ReturnValue");
		GetDefaultBlendOutTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultBlendOutTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDefaultBlendOutTime_IsValid = GetDefaultBlendOutTime_FunctionAddress != IntPtr.Zero && GetDefaultBlendOutTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimMontage:GetDefaultBlendOutTime", GetDefaultBlendOutTime_IsValid);
		GetDefaultBlendInTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultBlendInTime");
		GetDefaultBlendInTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultBlendInTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultBlendInTime_ReturnValue_PropertyAddress, GetDefaultBlendInTime_FunctionAddress, "ReturnValue");
		GetDefaultBlendInTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultBlendInTime_FunctionAddress, "ReturnValue");
		GetDefaultBlendInTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultBlendInTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDefaultBlendInTime_IsValid = GetDefaultBlendInTime_FunctionAddress != IntPtr.Zero && GetDefaultBlendInTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimMontage:GetDefaultBlendInTime", GetDefaultBlendInTime_IsValid);
		GetBlendOutArgs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlendOutArgs");
		GetBlendOutArgs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlendOutArgs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlendOutArgs_ReturnValue_PropertyAddress, GetBlendOutArgs_FunctionAddress, "ReturnValue");
		GetBlendOutArgs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlendOutArgs_FunctionAddress, "ReturnValue");
		GetBlendOutArgs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlendOutArgs_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBlendOutArgs_IsValid = GetBlendOutArgs_FunctionAddress != IntPtr.Zero && GetBlendOutArgs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimMontage:GetBlendOutArgs", GetBlendOutArgs_IsValid);
		GetBlendInArgs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlendInArgs");
		GetBlendInArgs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlendInArgs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlendInArgs_ReturnValue_PropertyAddress, GetBlendInArgs_FunctionAddress, "ReturnValue");
		GetBlendInArgs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlendInArgs_FunctionAddress, "ReturnValue");
		GetBlendInArgs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlendInArgs_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBlendInArgs_IsValid = GetBlendInArgs_FunctionAddress != IntPtr.Zero && GetBlendInArgs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimMontage:GetBlendInArgs", GetBlendInArgs_IsValid);
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateSlotAnimationAsDynamicMontage_WithBlendSettings");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_PropertyAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "Asset");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "Asset");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_PropertyAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "SlotNodeName");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "SlotNodeName");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "SlotNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_PropertyAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "BlendInSettings");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "BlendInSettings");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "BlendInSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_PropertyAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "BlendOutSettings");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "BlendOutSettings");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "BlendOutSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_PropertyAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "InPlayRate");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "InPlayRate");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "InPlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_PropertyAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "LoopCount");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "LoopCount");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "LoopCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_PropertyAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "InBlendOutTriggerTime");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "InBlendOutTriggerTime");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "InBlendOutTriggerTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_PropertyAddress, CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "ReturnValue");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "ReturnValue");
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateSlotAnimationAsDynamicMontage_WithBlendSettings_IsValid = CreateSlotAnimationAsDynamicMontage_WithBlendSettings_FunctionAddress != IntPtr.Zero && CreateSlotAnimationAsDynamicMontage_WithBlendSettings_Asset_IsValid && CreateSlotAnimationAsDynamicMontage_WithBlendSettings_SlotNodeName_IsValid && CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendInSettings_IsValid && CreateSlotAnimationAsDynamicMontage_WithBlendSettings_BlendOutSettings_IsValid && CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InPlayRate_IsValid && CreateSlotAnimationAsDynamicMontage_WithBlendSettings_LoopCount_IsValid && CreateSlotAnimationAsDynamicMontage_WithBlendSettings_InBlendOutTriggerTime_IsValid && CreateSlotAnimationAsDynamicMontage_WithBlendSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimMontage:CreateSlotAnimationAsDynamicMontage_WithBlendSettings", CreateSlotAnimationAsDynamicMontage_WithBlendSettings_IsValid);
	}
}
