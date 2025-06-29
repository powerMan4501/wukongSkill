using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.TileViewDemoMediator")]
public class TileViewDemoMediator : AActor
{
	private static bool tex0_IsValid;

	private static int tex0_Offset;

	private static bool tex1_IsValid;

	private static int tex1_Offset;

	private static bool tex2_IsValid;

	private static int tex2_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TileViewDemoMediator:tex0")]
	public UTexture2D tex0
	{
		get
		{
			CheckDestroyed();
			if (!tex0_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoMediator:tex0");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, tex0_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!tex0_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoMediator:tex0");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, tex0_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TileViewDemoMediator:tex1")]
	public UTexture2D tex1
	{
		get
		{
			CheckDestroyed();
			if (!tex1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoMediator:tex1");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, tex1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!tex1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoMediator:tex1");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, tex1_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TileViewDemoMediator:tex2")]
	public UTexture2D tex2
	{
		get
		{
			CheckDestroyed();
			if (!tex2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoMediator:tex2");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, tex2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!tex2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoMediator:tex2");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, tex2_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.TileViewDemoMediator");
		tex0_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "tex0");
		tex0_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "tex0", Classes.FObjectProperty);
		tex1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "tex1");
		tex1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "tex1", Classes.FObjectProperty);
		tex2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "tex2");
		tex2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "tex2", Classes.FObjectProperty);
	}

	static TileViewDemoMediator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TileViewDemoMediator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TileViewDemoMediator));
	}
}
