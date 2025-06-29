using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.DocumentationActor", "Engine", UnrealModuleType.Engine)]
public class ADocumentationActor : AActor
{
	private static bool DocumentLink_IsValid;

	private static int DocumentLink_Offset;

	private static bool Billboard_IsValid;

	private static int Billboard_Offset;

	[UProperty(Flags = (PropFlags)6759831847305733uL)]
	[UMetaPath("/Script/Engine.DocumentationActor:DocumentLink")]
	public string DocumentLink
	{
		get
		{
			CheckDestroyed();
			if (!DocumentLink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DocumentationActor:DocumentLink");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DocumentLink_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DocumentLink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DocumentationActor:DocumentLink");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DocumentLink_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392202383622685uL)]
	[UMetaPath("/Script/Engine.DocumentationActor:Billboard")]
	public UMaterialBillboardComponent Billboard
	{
		get
		{
			CheckDestroyed();
			if (!Billboard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DocumentationActor:Billboard");
				return null;
			}
			return UObjectMarshaler<UMaterialBillboardComponent>.FromNative(IntPtr.Add(base.Address, Billboard_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Billboard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DocumentationActor:Billboard");
			}
			else
			{
				UObjectMarshaler<UMaterialBillboardComponent>.ToNative(IntPtr.Add(base.Address, Billboard_Offset), value);
			}
		}
	}

	static ADocumentationActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADocumentationActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADocumentationActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.DocumentationActor");
		DocumentLink_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DocumentLink");
		DocumentLink_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DocumentLink", Classes.FStrProperty);
		Billboard_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Billboard");
		Billboard_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Billboard", Classes.FObjectProperty);
	}
}
