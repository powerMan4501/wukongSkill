using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemEOS;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemEOS.ArtifactSettings", "OnlineSubsystemEOS", UnrealModuleType.EnginePlugin)]
public struct FArtifactSettings
{
	private static bool ArtifactName_IsValid;

	private static int ArtifactName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.ArtifactSettings:ArtifactName")]
	public string ArtifactName;

	private static bool ClientId_IsValid;

	private static int ClientId_Offset;

	[UProperty(Flags = (PropFlags)6755399441072661uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.ArtifactSettings:ClientId")]
	public string ClientId;

	private static bool ClientSecret_IsValid;

	private static int ClientSecret_Offset;

	[UProperty(Flags = (PropFlags)6755399441072661uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.ArtifactSettings:ClientSecret")]
	public string ClientSecret;

	private static bool ProductId_IsValid;

	private static int ProductId_Offset;

	[UProperty(Flags = (PropFlags)6755399441072661uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.ArtifactSettings:ProductId")]
	public string ProductId;

	private static bool SandboxId_IsValid;

	private static int SandboxId_Offset;

	[UProperty(Flags = (PropFlags)6755399441072661uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.ArtifactSettings:SandboxId")]
	public string SandboxId;

	private static bool DeploymentId_IsValid;

	private static int DeploymentId_Offset;

	[UProperty(Flags = (PropFlags)6755399441072661uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.ArtifactSettings:DeploymentId")]
	public string DeploymentId;

	private static bool EncryptionKey_IsValid;

	private static int EncryptionKey_Offset;

	[UProperty(Flags = (PropFlags)6755399441072661uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.ArtifactSettings:EncryptionKey")]
	public string EncryptionKey;

	private static bool FArtifactSettings_IsValid;

	private static int FArtifactSettings_StructSize;

	public FArtifactSettings Copy()
	{
		return this;
	}

	public static FArtifactSettings FromNative(IntPtr nativeBuffer)
	{
		return new FArtifactSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FArtifactSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FArtifactSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FArtifactSettings(nativeBuffer + arrayIndex * FArtifactSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FArtifactSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FArtifactSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FArtifactSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemEOS.ArtifactSettings");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ArtifactName_Offset), ArtifactName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ClientId_Offset), ClientId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ClientSecret_Offset), ClientSecret);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ProductId_Offset), ProductId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SandboxId_Offset), SandboxId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DeploymentId_Offset), DeploymentId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, EncryptionKey_Offset), EncryptionKey);
	}

	public FArtifactSettings(IntPtr nativeStruct)
	{
		if (!FArtifactSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemEOS.ArtifactSettings");
			ArtifactName = FStringMarshaler.DefaultString;
			ClientId = FStringMarshaler.DefaultString;
			ClientSecret = FStringMarshaler.DefaultString;
			ProductId = FStringMarshaler.DefaultString;
			SandboxId = FStringMarshaler.DefaultString;
			DeploymentId = FStringMarshaler.DefaultString;
			EncryptionKey = FStringMarshaler.DefaultString;
		}
		else
		{
			ArtifactName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ArtifactName_Offset));
			ClientId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ClientId_Offset));
			ClientSecret = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ClientSecret_Offset));
			ProductId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ProductId_Offset));
			SandboxId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SandboxId_Offset));
			DeploymentId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DeploymentId_Offset));
			EncryptionKey = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, EncryptionKey_Offset));
		}
	}

	static FArtifactSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FArtifactSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FArtifactSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystemEOS.ArtifactSettings");
		FArtifactSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		ArtifactName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArtifactName");
		ArtifactName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArtifactName", Classes.FStrProperty);
		ClientId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClientId");
		ClientId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClientId", Classes.FStrProperty);
		ClientSecret_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClientSecret");
		ClientSecret_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClientSecret", Classes.FStrProperty);
		ProductId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProductId");
		ProductId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProductId", Classes.FStrProperty);
		SandboxId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SandboxId");
		SandboxId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SandboxId", Classes.FStrProperty);
		DeploymentId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeploymentId");
		DeploymentId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeploymentId", Classes.FStrProperty);
		EncryptionKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EncryptionKey");
		EncryptionKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EncryptionKey", Classes.FStrProperty);
		FArtifactSettings_IsValid = intPtr != IntPtr.Zero && ArtifactName_IsValid && ClientId_IsValid && ClientSecret_IsValid && ProductId_IsValid && SandboxId_IsValid && DeploymentId_IsValid && EncryptionKey_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystemEOS.ArtifactSettings", FArtifactSettings_IsValid);
	}
}
