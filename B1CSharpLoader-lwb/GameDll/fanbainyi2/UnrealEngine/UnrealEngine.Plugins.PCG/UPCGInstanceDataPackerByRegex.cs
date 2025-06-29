using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGInstanceDataPackerByRegex", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGInstanceDataPackerByRegex : UPCGInstanceDataPackerBase
{
	private static bool RegexPatterns_IsValid;

	private static FFieldAddress RegexPatterns_PropertyAddress;

	private static int RegexPatterns_Offset;

	private TArrayReadWriteMarshaler<string> RegexPatterns_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGInstanceDataPackerByRegex:RegexPatterns")]
	public TArrayReadWrite<string> RegexPatterns
	{
		get
		{
			CheckDestroyed();
			if (!RegexPatterns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGInstanceDataPackerByRegex:RegexPatterns");
				return null;
			}
			if (RegexPatterns_MarshalerCached == null)
			{
				RegexPatterns_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, RegexPatterns_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return RegexPatterns_MarshalerCached.FromNative(IntPtr.Add(base.Address, RegexPatterns_Offset));
		}
	}

	static UPCGInstanceDataPackerByRegex()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGInstanceDataPackerByRegex)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGInstanceDataPackerByRegex));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGInstanceDataPackerByRegex");
		NativeReflectionCached.GetPropertyRef(ref RegexPatterns_PropertyAddress, unrealStruct, "RegexPatterns");
		RegexPatterns_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RegexPatterns");
		RegexPatterns_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RegexPatterns", Classes.FArrayProperty);
	}
}
