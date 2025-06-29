using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDebug", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScriptDebug : UObject
{
	private static bool Messages_IsValid;

	private static FFieldAddress Messages_PropertyAddress;

	private static int Messages_Offset;

	private TArrayReadWriteMarshaler<FGeometryScriptDebugMessage> Messages_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDebug:Messages")]
	public TArrayReadWrite<FGeometryScriptDebugMessage> Messages
	{
		get
		{
			CheckDestroyed();
			if (!Messages_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryScriptingCore.GeometryScriptDebug:Messages");
				return null;
			}
			if (Messages_MarshalerCached == null)
			{
				Messages_MarshalerCached = new TArrayReadWriteMarshaler<FGeometryScriptDebugMessage>(1, Messages_PropertyAddress, CachedMarshalingDelegates<FGeometryScriptDebugMessage, FGeometryScriptDebugMessage>.FromNative, CachedMarshalingDelegates<FGeometryScriptDebugMessage, FGeometryScriptDebugMessage>.ToNative);
			}
			return Messages_MarshalerCached.FromNative(IntPtr.Add(base.Address, Messages_Offset));
		}
	}

	static UGeometryScriptDebug()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScriptDebug)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScriptDebug));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptDebug");
		NativeReflectionCached.GetPropertyRef(ref Messages_PropertyAddress, unrealStruct, "Messages");
		Messages_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Messages");
		Messages_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Messages", Classes.FArrayProperty);
	}
}
