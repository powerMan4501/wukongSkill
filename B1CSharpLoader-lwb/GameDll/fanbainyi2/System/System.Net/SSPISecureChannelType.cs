using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net;

internal class SSPISecureChannelType : SSPIInterface
{
	private static readonly SecurDll Library;

	private static volatile SecurityPackageInfoClass[] m_SecurityPackages;

	public SecurityPackageInfoClass[] SecurityPackages
	{
		get
		{
			return m_SecurityPackages;
		}
		set
		{
			m_SecurityPackages = value;
		}
	}

	public int EnumerateSecurityPackages(out int pkgnum, out SafeFreeContextBuffer pkgArray)
	{
		return SafeFreeContextBuffer.EnumeratePackages(Library, out pkgnum, out pkgArray);
	}

	public int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref AuthIdentity authdata, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireCredentialsHandle(Library, moduleName, usage, ref authdata, out outCredential);
	}

	public int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SafeSspiAuthDataHandle authdata, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireCredentialsHandle(moduleName, usage, ref authdata, out outCredential);
	}

	public int AcquireDefaultCredential(string moduleName, CredentialUse usage, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireDefaultCredential(Library, moduleName, usage, out outCredential);
	}

	public int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SecureCredential authdata, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireCredentialsHandle(Library, moduleName, usage, ref authdata, out outCredential);
	}

	public int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SecureCredential2 authdata, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireCredentialsHandle(Library, moduleName, usage, ref authdata, out outCredential);
	}

	public int AcceptSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer inputBuffer, ContextFlags inFlags, Endianness endianness, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		return SafeDeleteContext.AcceptSecurityContext(Library, ref credential, ref context, inFlags, endianness, inputBuffer, null, outputBuffer, ref outFlags);
	}

	public int AcceptSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers, ContextFlags inFlags, Endianness endianness, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		return SafeDeleteContext.AcceptSecurityContext(Library, ref credential, ref context, inFlags, endianness, null, inputBuffers, outputBuffer, ref outFlags);
	}

	public int InitializeSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlags inFlags, Endianness endianness, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		return SafeDeleteContext.InitializeSecurityContext(Library, ref credential, ref context, targetName, inFlags, endianness, inputBuffer, null, outputBuffer, ref outFlags);
	}

	public int InitializeSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlags inFlags, Endianness endianness, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		return SafeDeleteContext.InitializeSecurityContext(Library, ref credential, ref context, targetName, inFlags, endianness, null, inputBuffers, outputBuffer, ref outFlags);
	}

	public int EncryptMessage(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber)
	{
		int result = -2146893055;
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			context.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				context.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				result = UnsafeNclNativeMethods.NativeNTSSPI.EncryptMessage(ref context._handle, 0u, inputOutput, sequenceNumber);
				context.DangerousRelease();
			}
		}
		return result;
	}

	public unsafe int DecryptMessage(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber)
	{
		int result = -2146893055;
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			context.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				context.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				result = UnsafeNclNativeMethods.NativeNTSSPI.DecryptMessage(ref context._handle, inputOutput, sequenceNumber, null);
				context.DangerousRelease();
			}
		}
		return result;
	}

	public int MakeSignature(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber)
	{
		throw ExceptionHelper.MethodNotSupportedException;
	}

	public int VerifySignature(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber)
	{
		throw ExceptionHelper.MethodNotSupportedException;
	}

	public unsafe int QueryContextChannelBinding(SafeDeleteContext phContext, ContextAttribute attribute, out SafeFreeContextBufferChannelBinding refHandle)
	{
		refHandle = SafeFreeContextBufferChannelBinding.CreateEmptyHandle(Library);
		Bindings bindings = default(Bindings);
		return SafeFreeContextBufferChannelBinding.QueryContextChannelBinding(Library, phContext, attribute, &bindings, refHandle);
	}

	public unsafe int QueryContextAttributes(SafeDeleteContext phContext, ContextAttribute attribute, byte[] buffer, Type handleType, out SafeHandle refHandle)
	{
		refHandle = null;
		if (handleType != null)
		{
			if (handleType == typeof(SafeFreeContextBuffer))
			{
				refHandle = SafeFreeContextBuffer.CreateEmptyHandle(Library);
			}
			else
			{
				if (!(handleType == typeof(SafeFreeCertContext)))
				{
					throw new ArgumentException(SR.GetString("SSPIInvalidHandleType", handleType.FullName), "handleType");
				}
				refHandle = new SafeFreeCertContext();
			}
		}
		fixed (byte* buffer2 = buffer)
		{
			return SafeFreeContextBuffer.QueryContextAttributes(Library, phContext, attribute, buffer2, refHandle);
		}
	}

	public int SetContextAttributes(SafeDeleteContext phContext, ContextAttribute attribute, byte[] buffer)
	{
		return SafeFreeContextBuffer.SetContextAttributes(Library, phContext, attribute, buffer);
	}

	public int QuerySecurityContextToken(SafeDeleteContext phContext, out SafeCloseHandle phToken)
	{
		throw new NotSupportedException();
	}

	public int CompleteAuthToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers)
	{
		throw new NotSupportedException();
	}

	public int ApplyControlToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers)
	{
		return SafeDeleteContext.ApplyControlToken(Library, ref refContext, inputBuffers);
	}
}
