//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.SXMvvmRestClient.RestClientHandler
{
    public class MyRestClient<T>
    {
        //// Put your api link details here
        //private const string MyWebServiceAddress = ""; // e.g. "http://www.mywebsiteurl.com/" (always ends with /)
        //private const string MyControllerName = ""; // put your api controller name here

        //private const string MyWebServiceUrl = MyWebServiceAddress + "api/" + MyControllerName + "/";

        //HttpClient _httpClient = new HttpClient();
        //private HttpContent _httpContent;

        //// Get All Details
        //public async Task<List<T>> GetAsync()
        //{
        //    var json = await _httpClient.GetStringAsync(MyWebServiceUrl);

        //    var taskModels = JsonConvert.DeserializeObject<List<T>>(json);

        //    return taskModels;
        //}

        //// Insert New Details
        //public async Task<bool> PostAsync(T t)
        //{
        //    var json = JsonConvert.SerializeObject(t);

        //    _httpContent = new StringContent(json);

        //    _httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var postDataAsync = await _httpClient.PostAsync(MyWebServiceUrl, _httpContent);

        //    return postDataAsync.IsSuccessStatusCode;
        //}

        //// Update Existing Details
        //public async Task<bool> PutAsync(int id, T t)
        //{
        //    var json = JsonConvert.SerializeObject(t);

        //    _httpContent = new StringContent(json);

        //    _httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var putDataAsync = await _httpClient.PutAsync(MyWebServiceUrl + id, _httpContent);

        //    return putDataAsync.IsSuccessStatusCode;
        //}

        //// Delete Existing Details
        //public async Task<bool> DeleteAsync(int id, T t)
        //{
        //    var deleteDataAsync = await _httpClient.DeleteAsync(MyWebServiceUrl + id);

        //    return deleteDataAsync.IsSuccessStatusCode;
        //}

        //// How to test my api if it's working?
        //#region
        //// Instructions
        //// In order to test your api, you can install the Advanced REST Client.
        //// #1 Download this one -> https://chrome.google.com/webstore/detail/advanced-rest-client/hgmloofddffdnphfgcellkdfbfbjeloo
        //// #2 Lauch the Advanced REST Client App in your pc
        //// #3 Copy your link url with corresponding api url.(ex. http://www.mywebsiteurl.com/api/MyControllerName/)
        //// #4 Choose what method you're trying to check. The basic operations are Get, Post, Put & Delete
        //// #5 Click send
        //#endregion
    }
}
