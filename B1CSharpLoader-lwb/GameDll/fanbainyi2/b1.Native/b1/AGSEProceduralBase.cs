using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSEProceduralBase", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSEProceduralBase : AActor
{
	private static bool SMComp_IsValid;

	private static int SMComp_Offset;

	private static bool TagList_IsValid;

	private static FFieldAddress TagList_PropertyAddress;

	private static int TagList_Offset;

	private TArrayReadWriteMarshaler<string> TagList_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEProceduralBase:SMComp")]
	public UStaticMeshComponent SMComp
	{
		get
		{
			CheckDestroyed();
			if (!SMComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEProceduralBase:SMComp");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, SMComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SMComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEProceduralBase:SMComp");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, SMComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEProceduralBase:TagList")]
	public TArrayReadWrite<string> TagList
	{
		get
		{
			CheckDestroyed();
			if (!TagList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEProceduralBase:TagList");
				return null;
			}
			if (TagList_MarshalerCached == null)
			{
				TagList_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, TagList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return TagList_MarshalerCached.FromNative(IntPtr.Add(base.Address, TagList_Offset));
		}
	}

	static AGSEProceduralBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSEProceduralBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSEProceduralBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/FuncLibEditor.GSEProceduralBase");
		SMComp_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SMComp");
		SMComp_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SMComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TagList_PropertyAddress, unrealStruct, "TagList");
		TagList_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TagList");
		TagList_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TagList", Classes.FArrayProperty);
	}
}
