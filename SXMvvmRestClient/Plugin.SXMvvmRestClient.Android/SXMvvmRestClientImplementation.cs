using Plugin.SXMvvmRestClient.Abstractions;
using System;


namespace Plugin.SXMvvmRestClient
{
  /// <summary>
  /// Implementation for Feature
  /// </summary>
  public class SXMvvmRestClientImplementation : ISXMvvmRestClient
  {
        /// <summary>
        /// Log a message
        /// </summary>
        public void Log(string text)
        {
            throw new NotImplementedException("Called Log on Android");
        }
    }
}