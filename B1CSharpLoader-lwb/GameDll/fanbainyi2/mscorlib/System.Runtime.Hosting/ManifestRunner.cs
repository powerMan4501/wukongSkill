using System.Deployment.Internal.Isolation.Manifest;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Runtime.Hosting;

internal sealed class ManifestRunner
{
	private AppDomain m_domain;

	private string m_path;

	private string[] m_args;

	private ApartmentState m_apt;

	private RuntimeAssembly m_assembly;

	private int m_runResult;

	internal RuntimeAssembly EntryAssembly
	{
		[SecurityCritical]
		[FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
		[SecurityPermission(SecurityAction.Assert, Unrestricted = true)]
		get
		{
			if (m_assembly == null)
			{
				m_assembly = (RuntimeAssembly)Assembly.LoadFrom(m_path);
			}
			return m_assembly;
		}
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Assert, Unrestricted = true)]
	internal ManifestRunner(AppDomain domain, ActivationContext activationContext)
	{
		m_domain = domain;
		CmsUtils.GetEntryPoint(activationContext, out var fileName, out var parameters);
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NoMain"));
		}
		if (string.IsNullOrEmpty(parameters))
		{
			m_args = new string[0];
		}
		else
		{
			m_args = parameters.Split(' ');
		}
		m_apt = ApartmentState.Unknown;
		string applicationDirectory = activationContext.ApplicationDirectory;
		m_path = Path.Combine(applicationDirectory, fileName);
	}

	[SecurityCritical]
	private void NewThreadRunner()
	{
		m_runResult = Run(checkAptModel: false);
	}

	[SecurityCritical]
	private int RunInNewThread()
	{
		Thread thread = new Thread(NewThreadRunner);
		thread.SetApartmentState(m_apt);
		thread.Start();
		thread.Join();
		return m_runResult;
	}

	[SecurityCritical]
	private int Run(bool checkAptModel)
	{
		if (checkAptModel && m_apt != ApartmentState.Unknown)
		{
			if (Thread.CurrentThread.GetApartmentState() != ApartmentState.Unknown && Thread.CurrentThread.GetApartmentState() != m_apt)
			{
				return RunInNewThread();
			}
			Thread.CurrentThread.SetApartmentState(m_apt);
		}
		return m_domain.nExecuteAssembly(EntryAssembly, m_args);
	}

	[SecurityCritical]
	internal int ExecuteAsAssembly()
	{
		object[] customAttributes = EntryAssembly.EntryPoint.GetCustomAttributes(typeof(STAThreadAttribute), inherit: false);
		if (customAttributes.Length != 0)
		{
			m_apt = ApartmentState.STA;
		}
		customAttributes = EntryAssembly.EntryPoint.GetCustomAttributes(typeof(MTAThreadAttribute), inherit: false);
		if (customAttributes.Length != 0)
		{
			if (m_apt == ApartmentState.Unknown)
			{
				m_apt = ApartmentState.MTA;
			}
			else
			{
				m_apt = ApartmentState.Unknown;
			}
		}
		return Run(checkAptModel: true);
	}
}
