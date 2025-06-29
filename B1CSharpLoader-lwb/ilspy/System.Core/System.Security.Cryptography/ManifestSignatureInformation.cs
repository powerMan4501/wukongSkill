using System.Collections.Generic;
using System.Deployment.Internal;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Security.Permissions;
using System.Xml;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManifestSignatureInformation
{
	private ManifestKinds m_manifest;

	private StrongNameSignatureInformation m_strongNameSignature;

	private AuthenticodeSignatureInformation m_authenticodeSignature;

	public AuthenticodeSignatureInformation AuthenticodeSignature => m_authenticodeSignature;

	public ManifestKinds Manifest => m_manifest;

	public StrongNameSignatureInformation StrongNameSignature => m_strongNameSignature;

	internal ManifestSignatureInformation(ManifestKinds manifest, StrongNameSignatureInformation strongNameSignature, AuthenticodeSignatureInformation authenticodeSignature)
	{
		m_manifest = manifest;
		m_strongNameSignature = strongNameSignature;
		m_authenticodeSignature = authenticodeSignature;
	}

	[SecuritySafeCritical]
	private unsafe static XmlDocument GetManifestXml(ActivationContext application, ManifestKinds manifest)
	{
		IStream stream = null;
		switch (manifest)
		{
		case ManifestKinds.Application:
			stream = InternalActivationContextHelper.GetApplicationComponentManifest(application) as IStream;
			break;
		case ManifestKinds.Deployment:
			stream = InternalActivationContextHelper.GetDeploymentComponentManifest(application) as IStream;
			break;
		}
		using MemoryStream memoryStream = new MemoryStream();
		byte[] array = new byte[4096];
		int num = 0;
		do
		{
			stream.Read(array, array.Length, new IntPtr(&num));
			memoryStream.Write(array, 0, num);
		}
		while (num == array.Length);
		memoryStream.Position = 0L;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.PreserveWhitespace = true;
		xmlDocument.Load(memoryStream);
		return xmlDocument;
	}

	public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application)
	{
		return VerifySignature(application, ManifestKinds.ApplicationAndDeployment);
	}

	public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application, ManifestKinds manifests)
	{
		return VerifySignature(application, manifests, X509RevocationFlag.ExcludeRoot, X509RevocationMode.Online);
	}

	[SecuritySafeCritical]
	public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application, ManifestKinds manifests, X509RevocationFlag revocationFlag, X509RevocationMode revocationMode)
	{
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (revocationFlag < X509RevocationFlag.EndCertificateOnly || X509RevocationFlag.ExcludeRoot < revocationFlag)
		{
			throw new ArgumentOutOfRangeException("revocationFlag");
		}
		if (revocationMode < X509RevocationMode.NoCheck || X509RevocationMode.Offline < revocationMode)
		{
			throw new ArgumentOutOfRangeException("revocationMode");
		}
		List<ManifestSignatureInformation> list = new List<ManifestSignatureInformation>();
		if ((manifests & ManifestKinds.Deployment) == ManifestKinds.Deployment)
		{
			XmlDocument manifestXml = GetManifestXml(application, ManifestKinds.Deployment);
			ManifestSignedXml manifestSignedXml = new ManifestSignedXml(manifestXml, ManifestKinds.Deployment);
			list.Add(manifestSignedXml.VerifySignature(revocationFlag, revocationMode));
		}
		if ((manifests & ManifestKinds.Application) == ManifestKinds.Application)
		{
			XmlDocument manifestXml2 = GetManifestXml(application, ManifestKinds.Application);
			ManifestSignedXml manifestSignedXml2 = new ManifestSignedXml(manifestXml2, ManifestKinds.Application);
			list.Add(manifestSignedXml2.VerifySignature(revocationFlag, revocationMode));
		}
		return new ManifestSignatureInformationCollection(list);
	}
}
