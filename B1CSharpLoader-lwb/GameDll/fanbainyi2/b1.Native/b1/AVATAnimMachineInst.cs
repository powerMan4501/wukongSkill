using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst", "UnrealExtent", UnrealModuleType.Game)]
public class AVATAnimMachineInst : AActor
{
	private static bool AnimClipsConfig_IsValid;

	private static int AnimClipsConfig_Offset;

	private static bool AnimMachineConfig_IsValid;

	private static int AnimMachineConfig_Offset;

	private static bool DynamicMIs_IsValid;

	private static FFieldAddress DynamicMIs_PropertyAddress;

	private static int DynamicMIs_Offset;

	private TArrayReadWriteMarshaler<UMaterialInstanceDynamic> DynamicMIs_MarshalerCached;

	private static bool DebugAnimProgress_IsValid;

	private static int DebugAnimProgress_Offset;

	private static bool WindParamLerpSpeed_IsValid;

	private static int WindParamLerpSpeed_Offset;

	private static bool LerpWindDirection_IsValid;

	private static FFieldAddress LerpWindDirection_PropertyAddress;

	private static int LerpWindDirection_Offset;

	private static bool LerpWindIntensity_IsValid;

	private static FFieldAddress LerpWindIntensity_PropertyAddress;

	private static int LerpWindIntensity_Offset;

	private static bool UpdateWindIntensity_IsValid;

	private static IntPtr UpdateWindIntensity_FunctionAddress;

	private static int UpdateWindIntensity_ParamsSize;

	private static bool UpdateWindIntensity_InWindIntensity_IsValid;

	private static FFieldAddress UpdateWindIntensity_InWindIntensity_PropertyAddress;

	private static int UpdateWindIntensity_InWindIntensity_Offset;

	private static bool UpdateWindDirection_IsValid;

	private static IntPtr UpdateWindDirection_FunctionAddress;

	private static int UpdateWindDirection_ParamsSize;

	private static bool UpdateWindDirection_InWindDirection_IsValid;

	private static FFieldAddress UpdateWindDirection_InWindDirection_PropertyAddress;

	private static int UpdateWindDirection_InWindDirection_Offset;

	private static bool UpdateBlendRatio_IsValid;

	private static IntPtr UpdateBlendRatio_FunctionAddress;

	private static int UpdateBlendRatio_ParamsSize;

	private static bool UpdateBlendRatio_InBlendRatio_IsValid;

	private static FFieldAddress UpdateBlendRatio_InBlendRatio_PropertyAddress;

	private static int UpdateBlendRatio_InBlendRatio_Offset;

	private static bool UpdateAnimSpeed_IsValid;

	private static IntPtr UpdateAnimSpeed_FunctionAddress;

	private static int UpdateAnimSpeed_ParamsSize;

	private static bool UpdateAnimSpeed_InPlaySpeed_IsValid;

	private static FFieldAddress UpdateAnimSpeed_InPlaySpeed_PropertyAddress;

	private static int UpdateAnimSpeed_InPlaySpeed_Offset;

	private static bool UpdateAnimProgress_IsValid;

	private static IntPtr UpdateAnimProgress_FunctionAddress;

	private static int UpdateAnimProgress_ParamsSize;

	private static bool UpdateAnimProgress_InAnimProgress_IsValid;

	private static FFieldAddress UpdateAnimProgress_InAnimProgress_PropertyAddress;

	private static int UpdateAnimProgress_InAnimProgress_Offset;

	private static bool StopVATAnim_IsValid;

	private static IntPtr StopVATAnim_FunctionAddress;

	private static int StopVATAnim_ParamsSize;

	private static bool PlayVATAnim_IsValid;

	private static IntPtr PlayVATAnim_FunctionAddress;

	private static int PlayVATAnim_ParamsSize;

	private static bool InitVATAnimMachine_IsValid;

	private static IntPtr InitVATAnimMachine_FunctionAddress;

	private static int InitVATAnimMachine_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:AnimClipsConfig")]
	public UVATAnimClipsInfoConfig AnimClipsConfig
	{
		get
		{
			CheckDestroyed();
			if (!AnimClipsConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:AnimClipsConfig");
				return null;
			}
			return UObjectMarshaler<UVATAnimClipsInfoConfig>.FromNative(IntPtr.Add(base.Address, AnimClipsConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimClipsConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:AnimClipsConfig");
			}
			else
			{
				UObjectMarshaler<UVATAnimClipsInfoConfig>.ToNative(IntPtr.Add(base.Address, AnimClipsConfig_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:AnimMachineConfig")]
	public FVATAnimMachineConfig AnimMachineConfig
	{
		get
		{
			CheckDestroyed();
			if (!AnimMachineConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:AnimMachineConfig");
				return default(FVATAnimMachineConfig);
			}
			return FVATAnimMachineConfig.FromNative(IntPtr.Add(base.Address, AnimMachineConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimMachineConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:AnimMachineConfig");
			}
			else
			{
				FVATAnimMachineConfig.ToNative(IntPtr.Add(base.Address, AnimMachineConfig_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:DynamicMIs")]
	public TArrayReadWrite<UMaterialInstanceDynamic> DynamicMIs
	{
		get
		{
			CheckDestroyed();
			if (!DynamicMIs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:DynamicMIs");
				return null;
			}
			if (DynamicMIs_MarshalerCached == null)
			{
				DynamicMIs_MarshalerCached = new TArrayReadWriteMarshaler<UMaterialInstanceDynamic>(1, DynamicMIs_PropertyAddress, CachedMarshalingDelegates<UMaterialInstanceDynamic, UObjectMarshaler<UMaterialInstanceDynamic>>.FromNative, CachedMarshalingDelegates<UMaterialInstanceDynamic, UObjectMarshaler<UMaterialInstanceDynamic>>.ToNative);
			}
			return DynamicMIs_MarshalerCached.FromNative(IntPtr.Add(base.Address, DynamicMIs_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:DebugAnimProgress")]
	public float DebugAnimProgress
	{
		get
		{
			CheckDestroyed();
			if (!DebugAnimProgress_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:DebugAnimProgress");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugAnimProgress_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugAnimProgress_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:DebugAnimProgress");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugAnimProgress_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:WindParamLerpSpeed")]
	public float WindParamLerpSpeed
	{
		get
		{
			CheckDestroyed();
			if (!WindParamLerpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:WindParamLerpSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WindParamLerpSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindParamLerpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:WindParamLerpSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WindParamLerpSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:bLerpWindDirection")]
	public bool LerpWindDirection
	{
		get
		{
			CheckDestroyed();
			if (!LerpWindDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:bLerpWindDirection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LerpWindDirection_Offset), 0, LerpWindDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LerpWindDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:bLerpWindDirection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LerpWindDirection_Offset), 0, LerpWindDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:bLerpWindIntensity")]
	public bool LerpWindIntensity
	{
		get
		{
			CheckDestroyed();
			if (!LerpWindIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:bLerpWindIntensity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LerpWindIntensity_Offset), 0, LerpWindIntensity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LerpWindIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimMachineInst:bLerpWindIntensity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LerpWindIntensity_Offset), 0, LerpWindIntensity_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:UpdateWindIntensity")]
	public unsafe void UpdateWindIntensity(float InWindIntensity)
	{
		CheckDestroyed();
		if (!UpdateWindIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATAnimMachineInst:UpdateWindIntensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateWindIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateWindIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateWindIntensity_InWindIntensity_Offset), 0, UpdateWindIntensity_InWindIntensity_PropertyAddress.Address, InWindIntensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateWindIntensity_FunctionAddress, intPtr, UpdateWindIntensity_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:UpdateWindDirection")]
	public unsafe void UpdateWindDirection(FVector2D InWindDirection)
	{
		CheckDestroyed();
		if (!UpdateWindDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATAnimMachineInst:UpdateWindDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateWindDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateWindDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, UpdateWindDirection_InWindDirection_Offset), 0, UpdateWindDirection_InWindDirection_PropertyAddress.Address, InWindDirection);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateWindDirection_FunctionAddress, intPtr, UpdateWindDirection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:UpdateBlendRatio")]
	public unsafe void UpdateBlendRatio(float InBlendRatio)
	{
		CheckDestroyed();
		if (!UpdateBlendRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATAnimMachineInst:UpdateBlendRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateBlendRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateBlendRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateBlendRatio_InBlendRatio_Offset), 0, UpdateBlendRatio_InBlendRatio_PropertyAddress.Address, InBlendRatio);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateBlendRatio_FunctionAddress, intPtr, UpdateBlendRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:UpdateAnimSpeed")]
	public unsafe void UpdateAnimSpeed(float InPlaySpeed)
	{
		CheckDestroyed();
		if (!UpdateAnimSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATAnimMachineInst:UpdateAnimSpeed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateAnimSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateAnimSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateAnimSpeed_InPlaySpeed_Offset), 0, UpdateAnimSpeed_InPlaySpeed_PropertyAddress.Address, InPlaySpeed);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateAnimSpeed_FunctionAddress, intPtr, UpdateAnimSpeed_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:UpdateAnimProgress")]
	public unsafe void UpdateAnimProgress(float InAnimProgress)
	{
		CheckDestroyed();
		if (!UpdateAnimProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATAnimMachineInst:UpdateAnimProgress");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateAnimProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateAnimProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateAnimProgress_InAnimProgress_Offset), 0, UpdateAnimProgress_InAnimProgress_PropertyAddress.Address, InAnimProgress);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateAnimProgress_FunctionAddress, intPtr, UpdateAnimProgress_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:StopVATAnim")]
	public unsafe void StopVATAnim()
	{
		CheckDestroyed();
		if (!StopVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATAnimMachineInst:StopVATAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopVATAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopVATAnim_FunctionAddress, argsSize: StopVATAnim_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:PlayVATAnim")]
	public unsafe void PlayVATAnim()
	{
		CheckDestroyed();
		if (!PlayVATAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATAnimMachineInst:PlayVATAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayVATAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayVATAnim_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayVATAnim_FunctionAddress, argsSize: PlayVATAnim_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.VATAnimMachineInst:InitVATAnimMachine")]
	public unsafe void InitVATAnimMachine()
	{
		CheckDestroyed();
		if (!InitVATAnimMachine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.VATAnimMachineInst:InitVATAnimMachine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitVATAnimMachine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitVATAnimMachine_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitVATAnimMachine_FunctionAddress, argsSize: InitVATAnimMachine_ParamsSize);
	}

	static AVATAnimMachineInst()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AVATAnimMachineInst)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AVATAnimMachineInst));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.VATAnimMachineInst");
		AnimClipsConfig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimClipsConfig");
		AnimClipsConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimClipsConfig", Classes.FObjectProperty);
		AnimMachineConfig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimMachineConfig");
		AnimMachineConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimMachineConfig", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DynamicMIs_PropertyAddress, intPtr, "DynamicMIs");
		DynamicMIs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicMIs");
		DynamicMIs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicMIs", Classes.FArrayProperty);
		DebugAnimProgress_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugAnimProgress");
		DebugAnimProgress_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugAnimProgress", Classes.FFloatProperty);
		WindParamLerpSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindParamLerpSpeed");
		WindParamLerpSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindParamLerpSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LerpWindDirection_PropertyAddress, intPtr, "bLerpWindDirection");
		LerpWindDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLerpWindDirection");
		LerpWindDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLerpWindDirection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LerpWindIntensity_PropertyAddress, intPtr, "bLerpWindIntensity");
		LerpWindIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLerpWindIntensity");
		LerpWindIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLerpWindIntensity", Classes.FBoolProperty);
		UpdateWindIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateWindIntensity");
		UpdateWindIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateWindIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateWindIntensity_InWindIntensity_PropertyAddress, UpdateWindIntensity_FunctionAddress, "InWindIntensity");
		UpdateWindIntensity_InWindIntensity_Offset = NativeReflectionCached.GetPropertyOffset(UpdateWindIntensity_FunctionAddress, "InWindIntensity");
		UpdateWindIntensity_InWindIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateWindIntensity_FunctionAddress, "InWindIntensity", Classes.FFloatProperty);
		UpdateWindIntensity_IsValid = UpdateWindIntensity_FunctionAddress != IntPtr.Zero && UpdateWindIntensity_InWindIntensity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATAnimMachineInst:UpdateWindIntensity", UpdateWindIntensity_IsValid);
		UpdateWindDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateWindDirection");
		UpdateWindDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateWindDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateWindDirection_InWindDirection_PropertyAddress, UpdateWindDirection_FunctionAddress, "InWindDirection");
		UpdateWindDirection_InWindDirection_Offset = NativeReflectionCached.GetPropertyOffset(UpdateWindDirection_FunctionAddress, "InWindDirection");
		UpdateWindDirection_InWindDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateWindDirection_FunctionAddress, "InWindDirection", Classes.FStructProperty);
		UpdateWindDirection_IsValid = UpdateWindDirection_FunctionAddress != IntPtr.Zero && UpdateWindDirection_InWindDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATAnimMachineInst:UpdateWindDirection", UpdateWindDirection_IsValid);
		UpdateBlendRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateBlendRatio");
		UpdateBlendRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateBlendRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateBlendRatio_InBlendRatio_PropertyAddress, UpdateBlendRatio_FunctionAddress, "InBlendRatio");
		UpdateBlendRatio_InBlendRatio_Offset = NativeReflectionCached.GetPropertyOffset(UpdateBlendRatio_FunctionAddress, "InBlendRatio");
		UpdateBlendRatio_InBlendRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateBlendRatio_FunctionAddress, "InBlendRatio", Classes.FFloatProperty);
		UpdateBlendRatio_IsValid = UpdateBlendRatio_FunctionAddress != IntPtr.Zero && UpdateBlendRatio_InBlendRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATAnimMachineInst:UpdateBlendRatio", UpdateBlendRatio_IsValid);
		UpdateAnimSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateAnimSpeed");
		UpdateAnimSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateAnimSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateAnimSpeed_InPlaySpeed_PropertyAddress, UpdateAnimSpeed_FunctionAddress, "InPlaySpeed");
		UpdateAnimSpeed_InPlaySpeed_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAnimSpeed_FunctionAddress, "InPlaySpeed");
		UpdateAnimSpeed_InPlaySpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAnimSpeed_FunctionAddress, "InPlaySpeed", Classes.FFloatProperty);
		UpdateAnimSpeed_IsValid = UpdateAnimSpeed_FunctionAddress != IntPtr.Zero && UpdateAnimSpeed_InPlaySpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATAnimMachineInst:UpdateAnimSpeed", UpdateAnimSpeed_IsValid);
		UpdateAnimProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateAnimProgress");
		UpdateAnimProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateAnimProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateAnimProgress_InAnimProgress_PropertyAddress, UpdateAnimProgress_FunctionAddress, "InAnimProgress");
		UpdateAnimProgress_InAnimProgress_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAnimProgress_FunctionAddress, "InAnimProgress");
		UpdateAnimProgress_InAnimProgress_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAnimProgress_FunctionAddress, "InAnimProgress", Classes.FFloatProperty);
		UpdateAnimProgress_IsValid = UpdateAnimProgress_FunctionAddress != IntPtr.Zero && UpdateAnimProgress_InAnimProgress_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATAnimMachineInst:UpdateAnimProgress", UpdateAnimProgress_IsValid);
		StopVATAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopVATAnim");
		StopVATAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(StopVATAnim_FunctionAddress);
		StopVATAnim_IsValid = StopVATAnim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATAnimMachineInst:StopVATAnim", StopVATAnim_IsValid);
		PlayVATAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayVATAnim");
		PlayVATAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayVATAnim_FunctionAddress);
		PlayVATAnim_IsValid = PlayVATAnim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATAnimMachineInst:PlayVATAnim", PlayVATAnim_IsValid);
		InitVATAnimMachine_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitVATAnimMachine");
		InitVATAnimMachine_ParamsSize = NativeReflection.GetFunctionParamsSize(InitVATAnimMachine_FunctionAddress);
		InitVATAnimMachine_IsValid = InitVATAnimMachine_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.VATAnimMachineInst:InitVATAnimMachine", InitVATAnimMachine_IsValid);
	}
}
