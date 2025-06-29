using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/UMG.WidgetNavigation", "UMG", UnrealModuleType.Engine)]
public class UWidgetNavigation : UObject
{
	private static bool Up_IsValid;

	private static int Up_Offset;

	private static bool Down_IsValid;

	private static int Down_Offset;

	private static bool Left_IsValid;

	private static int Left_Offset;

	private static bool Right_IsValid;

	private static int Right_Offset;

	private static bool Next_IsValid;

	private static int Next_Offset;

	private static bool Previous_IsValid;

	private static int Previous_Offset;

	[UProperty(Flags = (PropFlags)4504218102661141uL)]
	[UMetaPath("/Script/UMG.WidgetNavigation:Up")]
	public FWidgetNavigationData Up
	{
		get
		{
			CheckDestroyed();
			if (!Up_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Up");
				return default(FWidgetNavigationData);
			}
			return FWidgetNavigationData.FromNative(IntPtr.Add(base.Address, Up_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Up_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Up");
			}
			else
			{
				FWidgetNavigationData.ToNative(IntPtr.Add(base.Address, Up_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504218102661141uL)]
	[UMetaPath("/Script/UMG.WidgetNavigation:Down")]
	public FWidgetNavigationData Down
	{
		get
		{
			CheckDestroyed();
			if (!Down_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Down");
				return default(FWidgetNavigationData);
			}
			return FWidgetNavigationData.FromNative(IntPtr.Add(base.Address, Down_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Down_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Down");
			}
			else
			{
				FWidgetNavigationData.ToNative(IntPtr.Add(base.Address, Down_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504218102661141uL)]
	[UMetaPath("/Script/UMG.WidgetNavigation:Left")]
	public FWidgetNavigationData Left
	{
		get
		{
			CheckDestroyed();
			if (!Left_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Left");
				return default(FWidgetNavigationData);
			}
			return FWidgetNavigationData.FromNative(IntPtr.Add(base.Address, Left_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Left_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Left");
			}
			else
			{
				FWidgetNavigationData.ToNative(IntPtr.Add(base.Address, Left_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504218102661141uL)]
	[UMetaPath("/Script/UMG.WidgetNavigation:Right")]
	public FWidgetNavigationData Right
	{
		get
		{
			CheckDestroyed();
			if (!Right_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Right");
				return default(FWidgetNavigationData);
			}
			return FWidgetNavigationData.FromNative(IntPtr.Add(base.Address, Right_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Right_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Right");
			}
			else
			{
				FWidgetNavigationData.ToNative(IntPtr.Add(base.Address, Right_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504218102661141uL)]
	[UMetaPath("/Script/UMG.WidgetNavigation:Next")]
	public FWidgetNavigationData Next
	{
		get
		{
			CheckDestroyed();
			if (!Next_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Next");
				return default(FWidgetNavigationData);
			}
			return FWidgetNavigationData.FromNative(IntPtr.Add(base.Address, Next_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Next_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Next");
			}
			else
			{
				FWidgetNavigationData.ToNative(IntPtr.Add(base.Address, Next_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504218102661141uL)]
	[UMetaPath("/Script/UMG.WidgetNavigation:Previous")]
	public FWidgetNavigationData Previous
	{
		get
		{
			CheckDestroyed();
			if (!Previous_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Previous");
				return default(FWidgetNavigationData);
			}
			return FWidgetNavigationData.FromNative(IntPtr.Add(base.Address, Previous_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Previous_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetNavigation:Previous");
			}
			else
			{
				FWidgetNavigationData.ToNative(IntPtr.Add(base.Address, Previous_Offset), value);
			}
		}
	}

	static UWidgetNavigation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWidgetNavigation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWidgetNavigation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UMG.WidgetNavigation");
		Up_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Up");
		Up_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Up", Classes.FStructProperty);
		Down_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Down");
		Down_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Down", Classes.FStructProperty);
		Left_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Left");
		Left_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Left", Classes.FStructProperty);
		Right_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Right");
		Right_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Right", Classes.FStructProperty);
		Next_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Next");
		Next_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Next", Classes.FStructProperty);
		Previous_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Previous");
		Previous_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Previous", Classes.FStructProperty);
	}
}
