using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoMoveMonitorsConfig")]
public class BGWDataAsset_AutoMoveMonitorsConfig : UBGWDataAsset
{
	private static bool AutoMoveCaptureModes_IsValid;

	private static int AutoMoveCaptureModes_Offset;

	private static FFieldAddress AutoMoveCaptureModes_PropertyAddress;

	private TArrayReadWriteMarshaler<FAutoMoveMonitorConfigItem> AutoMoveCaptureModes_Marshaler;

	private static bool AutoMoveMotionPatterns_IsValid;

	private static int AutoMoveMotionPatterns_Offset;

	private static FFieldAddress AutoMoveMotionPatterns_PropertyAddress;

	private TArrayReadWriteMarshaler<FAutoMoveMonitorConfigItem> AutoMoveMotionPatterns_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("跑图实例(纯跑图/抓取纹理信息/抓取性能信息/...)")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoMoveMonitorsConfig:AutoMoveCaptureModes")]
	public TArrayReadWrite<FAutoMoveMonitorConfigItem> AutoMoveCaptureModes
	{
		get
		{
			CheckDestroyed();
			if (!AutoMoveCaptureModes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoMoveMonitorsConfig:AutoMoveCaptureModes");
				return null;
			}
			if (AutoMoveCaptureModes_Marshaler == null)
			{
				AutoMoveCaptureModes_Marshaler = new TArrayReadWriteMarshaler<FAutoMoveMonitorConfigItem>(1, AutoMoveCaptureModes_PropertyAddress, CachedMarshalingDelegates<FAutoMoveMonitorConfigItem, FAutoMoveMonitorConfigItem>.FromNative, CachedMarshalingDelegates<FAutoMoveMonitorConfigItem, FAutoMoveMonitorConfigItem>.ToNative);
			}
			return AutoMoveCaptureModes_Marshaler.FromNative(IntPtr.Add(base.Address, AutoMoveCaptureModes_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("跑图行为配置(包括路径点、视角、速度等")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoMoveMonitorsConfig:AutoMoveMotionPatterns")]
	public TArrayReadWrite<FAutoMoveMonitorConfigItem> AutoMoveMotionPatterns
	{
		get
		{
			CheckDestroyed();
			if (!AutoMoveMotionPatterns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoMoveMonitorsConfig:AutoMoveMotionPatterns");
				return null;
			}
			if (AutoMoveMotionPatterns_Marshaler == null)
			{
				AutoMoveMotionPatterns_Marshaler = new TArrayReadWriteMarshaler<FAutoMoveMonitorConfigItem>(1, AutoMoveMotionPatterns_PropertyAddress, CachedMarshalingDelegates<FAutoMoveMonitorConfigItem, FAutoMoveMonitorConfigItem>.FromNative, CachedMarshalingDelegates<FAutoMoveMonitorConfigItem, FAutoMoveMonitorConfigItem>.ToNative);
			}
			return AutoMoveMotionPatterns_Marshaler.FromNative(IntPtr.Add(base.Address, AutoMoveMotionPatterns_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AutoMoveMonitorsConfig");
		NativeReflection.GetPropertyRef(ref AutoMoveCaptureModes_PropertyAddress, unrealStruct, "AutoMoveCaptureModes");
		AutoMoveCaptureModes_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoMoveCaptureModes");
		AutoMoveCaptureModes_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoMoveCaptureModes", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AutoMoveMotionPatterns_PropertyAddress, unrealStruct, "AutoMoveMotionPatterns");
		AutoMoveMotionPatterns_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoMoveMotionPatterns");
		AutoMoveMotionPatterns_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoMoveMotionPatterns", Classes.FArrayProperty);
	}

	static BGWDataAsset_AutoMoveMonitorsConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AutoMoveMonitorsConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AutoMoveMonitorsConfig));
	}
}
