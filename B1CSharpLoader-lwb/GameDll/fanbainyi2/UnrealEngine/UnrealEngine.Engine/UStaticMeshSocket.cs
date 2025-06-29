using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/Engine.StaticMeshSocket", "Engine", UnrealModuleType.Engine)]
public class UStaticMeshSocket : UObject
{
	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool RelativeLocation_IsValid;

	private static int RelativeLocation_Offset;

	private static bool RelativeRotation_IsValid;

	private static int RelativeRotation_Offset;

	private static bool RelativeScale_IsValid;

	private static int RelativeScale_Offset;

	private static bool Tag_IsValid;

	private static int Tag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.StaticMeshSocket:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StaticMeshSocket:RelativeLocation")]
	public FVector RelativeLocation
	{
		get
		{
			CheckDestroyed();
			if (!RelativeLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:RelativeLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RelativeLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:RelativeLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RelativeLocation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/Engine.StaticMeshSocket:RelativeRotation")]
	public FRotator RelativeRotation
	{
		get
		{
			CheckDestroyed();
			if (!RelativeRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:RelativeRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RelativeRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:RelativeRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RelativeRotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.StaticMeshSocket:RelativeScale")]
	public FVector RelativeScale
	{
		get
		{
			CheckDestroyed();
			if (!RelativeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:RelativeScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RelativeScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:RelativeScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RelativeScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759797487567365uL)]
	[UMetaPath("/Script/Engine.StaticMeshSocket:Tag")]
	public string Tag
	{
		get
		{
			CheckDestroyed();
			if (!Tag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:Tag");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Tag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Tag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshSocket:Tag");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Tag_Offset), value);
			}
		}
	}

	static UStaticMeshSocket()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStaticMeshSocket)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStaticMeshSocket));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.StaticMeshSocket");
		SocketName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SocketName");
		SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SocketName", Classes.FNameProperty);
		RelativeLocation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RelativeLocation");
		RelativeLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RelativeLocation", Classes.FStructProperty);
		RelativeRotation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RelativeRotation");
		RelativeRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RelativeRotation", Classes.FStructProperty);
		RelativeScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RelativeScale");
		RelativeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RelativeScale", Classes.FStructProperty);
		Tag_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Tag");
		Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Tag", Classes.FStrProperty);
	}
}
