using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass(Flags = (ClassFlags)818938021uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWVolumeBase", "b1", UnrealModuleType.Game)]
public class ABGWVolumeBase : AVolume
{
	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool BlendLength_IsValid;

	private static int BlendLength_Offset;

	private static bool BlendTime_IsValid;

	private static int BlendTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWVolumeBase:Priority")]
	public int Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWVolumeBase:Priority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWVolumeBase:Priority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWVolumeBase:BlendLength")]
	public int BlendLength
	{
		get
		{
			CheckDestroyed();
			if (!BlendLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWVolumeBase:BlendLength");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BlendLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWVolumeBase:BlendLength");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BlendLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BGWVolumeBase:BlendTime")]
	public float BlendTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWVolumeBase:BlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWVolumeBase:BlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendTime_Offset), value);
			}
		}
	}

	static ABGWVolumeBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWVolumeBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWVolumeBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGWVolumeBase");
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Priority", Classes.FIntProperty);
		BlendLength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendLength");
		BlendLength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendLength", Classes.FIntProperty);
		BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendTime");
		BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendTime", Classes.FFloatProperty);
	}
}
