using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPointMatchAndSetSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPointMatchAndSetSettings : UPCGSettings
{
	private static bool MatchAndSetType_IsValid;

	private static int MatchAndSetType_Offset;

	private static bool MatchAndSetInstance_IsValid;

	private static int MatchAndSetInstance_Offset;

	private static bool SetTarget_IsValid;

	private static int SetTarget_Offset;

	private static bool SetTargetType_IsValid;

	private static FFieldAddress SetTargetType_PropertyAddress;

	private static int SetTargetType_Offset;

	private static bool SetTargetStringMode_IsValid;

	private static FFieldAddress SetTargetStringMode_PropertyAddress;

	private static int SetTargetStringMode_Offset;

	private static bool SetMatchAndSetType_IsValid;

	private static IntPtr SetMatchAndSetType_FunctionAddress;

	private static int SetMatchAndSetType_ParamsSize;

	private static bool SetMatchAndSetType_InMatchAndSetType_IsValid;

	private static FFieldAddress SetMatchAndSetType_InMatchAndSetType_PropertyAddress;

	private static int SetMatchAndSetType_InMatchAndSetType_Offset;

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/PCG.PCGPointMatchAndSetSettings:MatchAndSetType")]
	public TSubclassOf<UPCGMatchAndSetBase> MatchAndSetType
	{
		get
		{
			CheckDestroyed();
			if (!MatchAndSetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:MatchAndSetType");
				return default(TSubclassOf<UPCGMatchAndSetBase>);
			}
			return TSubclassOfMarshaler<UPCGMatchAndSetBase>.FromNative(IntPtr.Add(base.Address, MatchAndSetType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatchAndSetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:MatchAndSetType");
			}
			else
			{
				TSubclassOfMarshaler<UPCGMatchAndSetBase>.ToNative(IntPtr.Add(base.Address, MatchAndSetType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095194141uL)]
	[UMetaPath("/Script/PCG.PCGPointMatchAndSetSettings:MatchAndSetInstance")]
	public UPCGMatchAndSetBase MatchAndSetInstance
	{
		get
		{
			CheckDestroyed();
			if (!MatchAndSetInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:MatchAndSetInstance");
				return null;
			}
			return UObjectMarshaler<UPCGMatchAndSetBase>.FromNative(IntPtr.Add(base.Address, MatchAndSetInstance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatchAndSetInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:MatchAndSetInstance");
			}
			else
			{
				UObjectMarshaler<UPCGMatchAndSetBase>.ToNative(IntPtr.Add(base.Address, MatchAndSetInstance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointMatchAndSetSettings:SetTarget")]
	public FPCGAttributePropertyOutputSelector SetTarget
	{
		get
		{
			CheckDestroyed();
			if (!SetTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:SetTarget");
				return default(FPCGAttributePropertyOutputSelector);
			}
			return FPCGAttributePropertyOutputSelector.FromNative(IntPtr.Add(base.Address, SetTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SetTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:SetTarget");
			}
			else
			{
				FPCGAttributePropertyOutputSelector.ToNative(IntPtr.Add(base.Address, SetTarget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointMatchAndSetSettings:SetTargetType")]
	public EPCGMetadataTypes SetTargetType
	{
		get
		{
			CheckDestroyed();
			if (!SetTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:SetTargetType");
				return EPCGMetadataTypes.Float;
			}
			return EnumMarshaler<EPCGMetadataTypes>.FromNative(IntPtr.Add(base.Address, SetTargetType_Offset), 0, SetTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SetTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:SetTargetType");
			}
			else
			{
				EnumMarshaler<EPCGMetadataTypes>.ToNative(IntPtr.Add(base.Address, SetTargetType_Offset), 0, SetTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointMatchAndSetSettings:SetTargetStringMode")]
	public EPCGMetadataTypesConstantStructStringMode SetTargetStringMode
	{
		get
		{
			CheckDestroyed();
			if (!SetTargetStringMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:SetTargetStringMode");
				return EPCGMetadataTypesConstantStructStringMode.String;
			}
			return EnumMarshaler<EPCGMetadataTypesConstantStructStringMode>.FromNative(IntPtr.Add(base.Address, SetTargetStringMode_Offset), 0, SetTargetStringMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SetTargetStringMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointMatchAndSetSettings:SetTargetStringMode");
			}
			else
			{
				EnumMarshaler<EPCGMetadataTypesConstantStructStringMode>.ToNative(IntPtr.Add(base.Address, SetTargetStringMode_Offset), 0, SetTargetStringMode_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGPointMatchAndSetSettings:SetMatchAndSetType")]
	public unsafe void SetMatchAndSetType(TSubclassOf<UPCGMatchAndSetBase> InMatchAndSetType)
	{
		CheckDestroyed();
		if (!SetMatchAndSetType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPointMatchAndSetSettings:SetMatchAndSetType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMatchAndSetType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMatchAndSetType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UPCGMatchAndSetBase>.ToNative(IntPtr.Add(intPtr, SetMatchAndSetType_InMatchAndSetType_Offset), 0, SetMatchAndSetType_InMatchAndSetType_PropertyAddress.Address, InMatchAndSetType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMatchAndSetType_FunctionAddress, intPtr, SetMatchAndSetType_ParamsSize);
	}

	static UPCGPointMatchAndSetSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPointMatchAndSetSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPointMatchAndSetSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGPointMatchAndSetSettings");
		MatchAndSetType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatchAndSetType");
		MatchAndSetType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatchAndSetType", Classes.FClassProperty);
		MatchAndSetInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatchAndSetInstance");
		MatchAndSetInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatchAndSetInstance", Classes.FObjectProperty);
		SetTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SetTarget");
		SetTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SetTarget", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTargetType_PropertyAddress, intPtr, "SetTargetType");
		SetTargetType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SetTargetType");
		SetTargetType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SetTargetType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTargetStringMode_PropertyAddress, intPtr, "SetTargetStringMode");
		SetTargetStringMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SetTargetStringMode");
		SetTargetStringMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SetTargetStringMode", Classes.FEnumProperty);
		SetMatchAndSetType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMatchAndSetType");
		SetMatchAndSetType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMatchAndSetType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMatchAndSetType_InMatchAndSetType_PropertyAddress, SetMatchAndSetType_FunctionAddress, "InMatchAndSetType");
		SetMatchAndSetType_InMatchAndSetType_Offset = NativeReflectionCached.GetPropertyOffset(SetMatchAndSetType_FunctionAddress, "InMatchAndSetType");
		SetMatchAndSetType_InMatchAndSetType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMatchAndSetType_FunctionAddress, "InMatchAndSetType", Classes.FClassProperty);
		SetMatchAndSetType_IsValid = SetMatchAndSetType_FunctionAddress != IntPtr.Zero && SetMatchAndSetType_InMatchAndSetType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPointMatchAndSetSettings:SetMatchAndSetType", SetMatchAndSetType_IsValid);
	}
}
