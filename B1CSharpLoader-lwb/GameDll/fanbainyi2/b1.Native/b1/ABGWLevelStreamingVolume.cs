using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWLevelStreamingVolume", "b1", UnrealModuleType.Game)]
public class ABGWLevelStreamingVolume : AVolume
{
	private static bool StreamingLevelNames_IsValid;

	private static FFieldAddress StreamingLevelNames_PropertyAddress;

	private static int StreamingLevelNames_Offset;

	private TArrayReadWriteMarshaler<FName> StreamingLevelNames_MarshalerCached;

	private static bool ForceHideStreamingLevelNames_IsValid;

	private static FFieldAddress ForceHideStreamingLevelNames_PropertyAddress;

	private static int ForceHideStreamingLevelNames_Offset;

	private TArrayReadWriteMarshaler<FName> ForceHideStreamingLevelNames_MarshalerCached;

	private static bool EditorPreVisOnly_IsValid;

	private static FFieldAddress EditorPreVisOnly_PropertyAddress;

	private static int EditorPreVisOnly_Offset;

	private static bool Disabled_IsValid;

	private static FFieldAddress Disabled_PropertyAddress;

	private static int Disabled_Offset;

	private static bool OnStartLoading_IsValid;

	private static FFieldAddress OnStartLoading_PropertyAddress;

	private static int OnStartLoading_Offset;

	private static bool StreamingUsage_IsValid;

	private static FFieldAddress StreamingUsage_PropertyAddress;

	private static int StreamingUsage_Offset;

	private static bool WorldCompositionGroup_IsValid;

	private static FFieldAddress WorldCompositionGroup_PropertyAddress;

	private static int WorldCompositionGroup_Offset;

	private static bool MinTimeBetweenVolumeUnloadRequests_IsValid;

	private static int MinTimeBetweenVolumeUnloadRequests_Offset;

	private static bool SetEnableWorldCompositionGroup_IsValid;

	private static IntPtr SetEnableWorldCompositionGroup_FunctionAddress;

	private static int SetEnableWorldCompositionGroup_ParamsSize;

	private static bool SetEnableWorldCompositionGroup_bEnable_IsValid;

	private static FFieldAddress SetEnableWorldCompositionGroup_bEnable_PropertyAddress;

	private static int SetEnableWorldCompositionGroup_bEnable_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:StreamingLevelNames")]
	public TArrayReadWrite<FName> StreamingLevelNames
	{
		get
		{
			CheckDestroyed();
			if (!StreamingLevelNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:StreamingLevelNames");
				return null;
			}
			if (StreamingLevelNames_MarshalerCached == null)
			{
				StreamingLevelNames_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, StreamingLevelNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return StreamingLevelNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, StreamingLevelNames_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:ForceHideStreamingLevelNames")]
	public TArrayReadWrite<FName> ForceHideStreamingLevelNames
	{
		get
		{
			CheckDestroyed();
			if (!ForceHideStreamingLevelNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:ForceHideStreamingLevelNames");
				return null;
			}
			if (ForceHideStreamingLevelNames_MarshalerCached == null)
			{
				ForceHideStreamingLevelNames_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, ForceHideStreamingLevelNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return ForceHideStreamingLevelNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, ForceHideStreamingLevelNames_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:bEditorPreVisOnly")]
	public bool EditorPreVisOnly
	{
		get
		{
			CheckDestroyed();
			if (!EditorPreVisOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:bEditorPreVisOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorPreVisOnly_Offset), 0, EditorPreVisOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorPreVisOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:bEditorPreVisOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorPreVisOnly_Offset), 0, EditorPreVisOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:bDisabled")]
	public bool Disabled
	{
		get
		{
			CheckDestroyed();
			if (!Disabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:bDisabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Disabled_Offset), 0, Disabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Disabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:bDisabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Disabled_Offset), 0, Disabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:bOnStartLoading")]
	public bool OnStartLoading
	{
		get
		{
			CheckDestroyed();
			if (!OnStartLoading_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:bOnStartLoading");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnStartLoading_Offset), 0, OnStartLoading_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnStartLoading_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:bOnStartLoading");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnStartLoading_Offset), 0, OnStartLoading_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:StreamingUsage")]
	public EBGWStreamingVolumeUsage StreamingUsage
	{
		get
		{
			CheckDestroyed();
			if (!StreamingUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:StreamingUsage");
				return EBGWStreamingVolumeUsage.Loading;
			}
			return EnumMarshaler<EBGWStreamingVolumeUsage>.FromNative(IntPtr.Add(base.Address, StreamingUsage_Offset), 0, StreamingUsage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StreamingUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:StreamingUsage");
			}
			else
			{
				EnumMarshaler<EBGWStreamingVolumeUsage>.ToNative(IntPtr.Add(base.Address, StreamingUsage_Offset), 0, StreamingUsage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:bWorldCompositionGroup")]
	public bool WorldCompositionGroup
	{
		get
		{
			CheckDestroyed();
			if (!WorldCompositionGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:bWorldCompositionGroup");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WorldCompositionGroup_Offset), 0, WorldCompositionGroup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WorldCompositionGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:bWorldCompositionGroup");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WorldCompositionGroup_Offset), 0, WorldCompositionGroup_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:MinTimeBetweenVolumeUnloadRequests")]
	public float MinTimeBetweenVolumeUnloadRequests
	{
		get
		{
			CheckDestroyed();
			if (!MinTimeBetweenVolumeUnloadRequests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:MinTimeBetweenVolumeUnloadRequests");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinTimeBetweenVolumeUnloadRequests_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinTimeBetweenVolumeUnloadRequests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWLevelStreamingVolume:MinTimeBetweenVolumeUnloadRequests");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinTimeBetweenVolumeUnloadRequests_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWLevelStreamingVolume:SetEnableWorldCompositionGroup")]
	public unsafe void SetEnableWorldCompositionGroup(bool bEnable)
	{
		CheckDestroyed();
		if (!SetEnableWorldCompositionGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWLevelStreamingVolume:SetEnableWorldCompositionGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableWorldCompositionGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableWorldCompositionGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableWorldCompositionGroup_bEnable_Offset), 0, SetEnableWorldCompositionGroup_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableWorldCompositionGroup_FunctionAddress, intPtr, SetEnableWorldCompositionGroup_ParamsSize);
	}

	static ABGWLevelStreamingVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWLevelStreamingVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWLevelStreamingVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGWLevelStreamingVolume");
		NativeReflectionCached.GetPropertyRef(ref StreamingLevelNames_PropertyAddress, intPtr, "StreamingLevelNames");
		StreamingLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingLevelNames");
		StreamingLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingLevelNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceHideStreamingLevelNames_PropertyAddress, intPtr, "ForceHideStreamingLevelNames");
		ForceHideStreamingLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForceHideStreamingLevelNames");
		ForceHideStreamingLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForceHideStreamingLevelNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorPreVisOnly_PropertyAddress, intPtr, "bEditorPreVisOnly");
		EditorPreVisOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEditorPreVisOnly");
		EditorPreVisOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEditorPreVisOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Disabled_PropertyAddress, intPtr, "bDisabled");
		Disabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisabled");
		Disabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnStartLoading_PropertyAddress, intPtr, "bOnStartLoading");
		OnStartLoading_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOnStartLoading");
		OnStartLoading_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOnStartLoading", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StreamingUsage_PropertyAddress, intPtr, "StreamingUsage");
		StreamingUsage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingUsage");
		StreamingUsage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingUsage", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldCompositionGroup_PropertyAddress, intPtr, "bWorldCompositionGroup");
		WorldCompositionGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWorldCompositionGroup");
		WorldCompositionGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWorldCompositionGroup", Classes.FBoolProperty);
		MinTimeBetweenVolumeUnloadRequests_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinTimeBetweenVolumeUnloadRequests");
		MinTimeBetweenVolumeUnloadRequests_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinTimeBetweenVolumeUnloadRequests", Classes.FFloatProperty);
		SetEnableWorldCompositionGroup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableWorldCompositionGroup");
		SetEnableWorldCompositionGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableWorldCompositionGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableWorldCompositionGroup_bEnable_PropertyAddress, SetEnableWorldCompositionGroup_FunctionAddress, "bEnable");
		SetEnableWorldCompositionGroup_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableWorldCompositionGroup_FunctionAddress, "bEnable");
		SetEnableWorldCompositionGroup_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableWorldCompositionGroup_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetEnableWorldCompositionGroup_IsValid = SetEnableWorldCompositionGroup_FunctionAddress != IntPtr.Zero && SetEnableWorldCompositionGroup_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWLevelStreamingVolume:SetEnableWorldCompositionGroup", SetEnableWorldCompositionGroup_IsValid);
	}
}
