using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGBlueprintSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGBlueprintSettings : UPCGSettings
{
	private static bool BlueprintElementType_IsValid;

	private static int BlueprintElementType_Offset;

	private static bool BlueprintElementInstance_IsValid;

	private static int BlueprintElementInstance_Offset;

	private static bool TrackedActorTags_IsValid;

	private static FFieldAddress TrackedActorTags_PropertyAddress;

	private static int TrackedActorTags_Offset;

	private TArrayReadWriteMarshaler<FName> TrackedActorTags_MarshalerCached;

	private static bool TrackActorsOnlyWithinBounds_IsValid;

	private static FFieldAddress TrackActorsOnlyWithinBounds_PropertyAddress;

	private static int TrackActorsOnlyWithinBounds_Offset;

	private static bool SetElementType_IsValid;

	private static IntPtr SetElementType_FunctionAddress;

	private static int SetElementType_ParamsSize;

	private static bool SetElementType_InElementType_IsValid;

	private static FFieldAddress SetElementType_InElementType_PropertyAddress;

	private static int SetElementType_InElementType_Offset;

	private static bool SetElementType_ElementInstance_IsValid;

	private static FFieldAddress SetElementType_ElementInstance_PropertyAddress;

	private static int SetElementType_ElementInstance_Offset;

	private static bool GetElementType_IsValid;

	private static IntPtr GetElementType_FunctionAddress;

	private static int GetElementType_ParamsSize;

	private static bool GetElementType_ReturnValue_IsValid;

	private static FFieldAddress GetElementType_ReturnValue_PropertyAddress;

	private static int GetElementType_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintSettings:BlueprintElementType")]
	protected TSubclassOf<UPCGBlueprintElement> BlueprintElementType
	{
		get
		{
			CheckDestroyed();
			if (!BlueprintElementType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintSettings:BlueprintElementType");
				return default(TSubclassOf<UPCGBlueprintElement>);
			}
			return TSubclassOfMarshaler<UPCGBlueprintElement>.FromNative(IntPtr.Add(base.Address, BlueprintElementType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlueprintElementType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintSettings:BlueprintElementType");
			}
			else
			{
				TSubclassOfMarshaler<UPCGBlueprintElement>.ToNative(IntPtr.Add(base.Address, BlueprintElementType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12956714815586845uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintSettings:BlueprintElementInstance")]
	protected UPCGBlueprintElement BlueprintElementInstance
	{
		get
		{
			CheckDestroyed();
			if (!BlueprintElementInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintSettings:BlueprintElementInstance");
				return null;
			}
			return UObjectMarshaler<UPCGBlueprintElement>.FromNative(IntPtr.Add(base.Address, BlueprintElementInstance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlueprintElementInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintSettings:BlueprintElementInstance");
			}
			else
			{
				UObjectMarshaler<UPCGBlueprintElement>.ToNative(IntPtr.Add(base.Address, BlueprintElementInstance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9016029707502085uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintSettings:TrackedActorTags")]
	protected TArrayReadWrite<FName> TrackedActorTags
	{
		get
		{
			CheckDestroyed();
			if (!TrackedActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintSettings:TrackedActorTags");
				return null;
			}
			if (TrackedActorTags_MarshalerCached == null)
			{
				TrackedActorTags_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, TrackedActorTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return TrackedActorTags_MarshalerCached.FromNative(IntPtr.Add(base.Address, TrackedActorTags_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)11267899314405909uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintSettings:bTrackActorsOnlyWithinBounds")]
	protected bool TrackActorsOnlyWithinBounds
	{
		get
		{
			CheckDestroyed();
			if (!TrackActorsOnlyWithinBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintSettings:bTrackActorsOnlyWithinBounds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TrackActorsOnlyWithinBounds_Offset), 0, TrackActorsOnlyWithinBounds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TrackActorsOnlyWithinBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintSettings:bTrackActorsOnlyWithinBounds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TrackActorsOnlyWithinBounds_Offset), 0, TrackActorsOnlyWithinBounds_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGBlueprintSettings:SetElementType")]
	public unsafe void SetElementType(TSubclassOf<UPCGBlueprintElement> InElementType, out UPCGBlueprintElement ElementInstance)
	{
		CheckDestroyed();
		if (!SetElementType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintSettings:SetElementType");
			ElementInstance = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetElementType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetElementType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UPCGBlueprintElement>.ToNative(IntPtr.Add(intPtr, SetElementType_InElementType_Offset), 0, SetElementType_InElementType_PropertyAddress.Address, InElementType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetElementType_FunctionAddress, intPtr, SetElementType_ParamsSize);
		ElementInstance = UObjectMarshaler<UPCGBlueprintElement>.FromNative(IntPtr.Add(intPtr, SetElementType_ElementInstance_Offset), 0, SetElementType_ElementInstance_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGBlueprintSettings:GetElementType")]
	public unsafe TSubclassOf<UPCGBlueprintElement> GetElementType()
	{
		CheckDestroyed();
		if (!GetElementType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintSettings:GetElementType");
			return default(TSubclassOf<UPCGBlueprintElement>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetElementType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetElementType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetElementType_FunctionAddress, intPtr, GetElementType_ParamsSize);
		return TSubclassOfMarshaler<UPCGBlueprintElement>.FromNative(IntPtr.Add(intPtr, GetElementType_ReturnValue_Offset), 0, GetElementType_ReturnValue_PropertyAddress.Address);
	}

	static UPCGBlueprintSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGBlueprintSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGBlueprintSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGBlueprintSettings");
		BlueprintElementType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlueprintElementType");
		BlueprintElementType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlueprintElementType", Classes.FClassProperty);
		BlueprintElementInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlueprintElementInstance");
		BlueprintElementInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlueprintElementInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TrackedActorTags_PropertyAddress, intPtr, "TrackedActorTags");
		TrackedActorTags_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TrackedActorTags");
		TrackedActorTags_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TrackedActorTags", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TrackActorsOnlyWithinBounds_PropertyAddress, intPtr, "bTrackActorsOnlyWithinBounds");
		TrackActorsOnlyWithinBounds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTrackActorsOnlyWithinBounds");
		TrackActorsOnlyWithinBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTrackActorsOnlyWithinBounds", Classes.FBoolProperty);
		SetElementType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetElementType");
		SetElementType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetElementType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetElementType_InElementType_PropertyAddress, SetElementType_FunctionAddress, "InElementType");
		SetElementType_InElementType_Offset = NativeReflectionCached.GetPropertyOffset(SetElementType_FunctionAddress, "InElementType");
		SetElementType_InElementType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetElementType_FunctionAddress, "InElementType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SetElementType_ElementInstance_PropertyAddress, SetElementType_FunctionAddress, "ElementInstance");
		SetElementType_ElementInstance_Offset = NativeReflectionCached.GetPropertyOffset(SetElementType_FunctionAddress, "ElementInstance");
		SetElementType_ElementInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetElementType_FunctionAddress, "ElementInstance", Classes.FObjectProperty);
		SetElementType_IsValid = SetElementType_FunctionAddress != IntPtr.Zero && SetElementType_InElementType_IsValid && SetElementType_ElementInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintSettings:SetElementType", SetElementType_IsValid);
		GetElementType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetElementType");
		GetElementType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetElementType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetElementType_ReturnValue_PropertyAddress, GetElementType_FunctionAddress, "ReturnValue");
		GetElementType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetElementType_FunctionAddress, "ReturnValue");
		GetElementType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetElementType_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetElementType_IsValid = GetElementType_FunctionAddress != IntPtr.Zero && GetElementType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintSettings:GetElementType", GetElementType_IsValid);
	}
}
