﻿using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Configuration;

namespace wxPirs.Properties
{
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	public static Settings Default
	{
		get
		{
			return Settings.defaultInstance;
		}
	}

	static Settings()
	{
		Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}

	public Settings()
	{
	}
}
}