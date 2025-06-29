using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AutoMoveMonitorConfigItem")]
public struct FAutoMoveMonitorConfigItem
{
	[Tooltip("资源路径")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AutoMoveMonitorConfigItem:AssetPath")]
	public string AssetPath;

	[Tooltip("别名, 对应于 Atp 配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoMoveMonitorConfigItem:Desc")]
	public string Desc;

	private static int AutoMoveMonitorConfigItem_StructSize;

	private static int AutoMoveMonitorConfigItem_IsValid;

	private static bool AssetPath_IsValid;

	private static int AssetPath_Offset;

	private static bool Desc_IsValid;

	private static int Desc_Offset;

	public FAutoMoveMonitorConfigItem Copy()
	{
		return this;
	}

	public static FAutoMoveMonitorConfigItem FromNative(IntPtr nativeBuffer)
	{
		return new FAutoMoveMonitorConfigItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAutoMoveMonitorConfigItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAutoMoveMonitorConfigItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAutoMoveMonitorConfigItem(IntPtr.Add(nativeBuffer, arrayIndex * AutoMoveMonitorConfigItem_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAutoMoveMonitorConfigItem value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AutoMoveMonitorConfigItem_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AutoMoveMonitorConfigItem_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AutoMoveMonitorConfigItem");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AssetPath_Offset), AssetPath);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Desc_Offset), Desc);
	}

	public FAutoMoveMonitorConfigItem(IntPtr nativeStruct)
	{
		if (AutoMoveMonitorConfigItem_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AutoMoveMonitorConfigItem");
			AssetPath = null;
			Desc = null;
		}
		else
		{
			AssetPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AssetPath_Offset));
			Desc = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Desc_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AutoMoveMonitorConfigItem");
		AutoMoveMonitorConfigItem_StructSize = NativeReflection.GetStructSize(intPtr);
		AssetPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "AssetPath");
		AssetPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AssetPath", Classes.FStrProperty);
		Desc_Offset = NativeReflection.GetPropertyOffset(intPtr, "Desc");
		Desc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Desc", Classes.FStrProperty);
		AutoMoveMonitorConfigItem_IsValid = ((intPtr != IntPtr.Zero && AssetPath_IsValid && Desc_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AutoMoveMonitorConfigItem", (byte)AutoMoveMonitorConfigItem_IsValid != 0);
	}

	static FAutoMoveMonitorConfigItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAutoMoveMonitorConfigItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAutoMoveMonitorConfigItem));
	}
}
