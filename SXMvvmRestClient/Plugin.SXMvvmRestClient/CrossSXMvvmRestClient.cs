using Plugin.SXMvvmRestClient.Abstractions;
using System;

namespace Plugin.SXMvvmRestClient
{
  /// <summary>
  /// Cross platform SXMvvmRestClient implemenations
  /// </summary>
  public class CrossSXMvvmRestClient
  {
    static Lazy<ISXMvvmRestClient> Implementation = new Lazy<ISXMvvmRestClient>(() => CreateSXMvvmRestClient(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Current settings to use
    /// </summary>
    public static ISXMvvmRestClient Current
    {
      get
      {
        var ret = Implementation.Value;
        if (ret == null)
        {
          throw NotImplementedInReferenceAssembly();
        }
        return ret;
      }
    }

    static ISXMvvmRestClient CreateSXMvvmRestClient()
    {
#if PORTABLE
        return null;
#else
        return new SXMvvmRestClientImplementation();
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly()
    {
      return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
  }
}
