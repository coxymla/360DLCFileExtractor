using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.ComponentModel;
using System.Drawing;
using System;

namespace wxPirs.Properties
{
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources
{
	private static CultureInfo resourceCulture;

	private static ResourceManager resourceMan;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Resources.resourceCulture;
		}
		set
		{
			Resources.resourceCulture = value;
		}
	}

	internal static Bitmap openHS
	{
		get
		{
			//object obj = Resources.ResourceManager.GetObject("openHS", Resources.resourceCulture);
			//return (Bitmap)obj;
		    return null;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(Resources.resourceMan, null))
			{
				ResourceManager resourceManager = new ResourceManager("wxPirs.Properties.Resources", typeof(Resources).Assembly);
				Resources.resourceMan = resourceManager;
			}
			return Resources.resourceMan;
		}
	}

	internal static Bitmap SaveAllHS
	{
		get
		{
            //object obj = Resources.ResourceManager.GetObject("SaveAllHS", Resources.resourceCulture);
            //return (Bitmap)obj;
            return null;
        }
	}

	internal Resources()
	{
	}
}
}