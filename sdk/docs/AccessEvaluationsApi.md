# Finbourne.Insights.Sdk.Api.AccessEvaluationsApi

All URIs are relative to *https://www.lusid.com/insights*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccessEvaluationLog**](AccessEvaluationsApi.md#getaccessevaluationlog) | **GET** /api/access/{id} | [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation.  This endpoint will be deprecated in the near future.
[**ListAccessEvaluationLogs**](AccessEvaluationsApi.md#listaccessevaluationlogs) | **GET** /api/access | [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations.


<a name="getaccessevaluationlog"></a>
# **GetAccessEvaluationLog**
> AccessEvaluationLog GetAccessEvaluationLog (string id)

[EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation.  This endpoint will be deprecated in the near future.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class GetAccessEvaluationLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessEvaluationsApi(config);
            var id = id_example;  // string | The identifier of the access evaluation to obtain the log for.

            try
            {
                // [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation.  This endpoint will be deprecated in the near future.
                AccessEvaluationLog result = apiInstance.GetAccessEvaluationLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessEvaluationsApi.GetAccessEvaluationLog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The identifier of the access evaluation to obtain the log for. | 

### Return type

[**AccessEvaluationLog**](AccessEvaluationLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccessevaluationlogs"></a>
# **ListAccessEvaluationLogs**
> ResourceListWithHistogramOfAccessEvaluationLog ListAccessEvaluationLogs (DateTimeOffset? startAt = null, DateTimeOffset? endAt = null, string filter = null, string sortBy = null, int? limit = null, string page = null, string histogramInterval = null)

[EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class ListAccessEvaluationLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessEvaluationsApi(config);
            var startAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Start date from which point to fetch logs. (optional) 
            var endAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | End date to which point to fetch logs. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about <see href=\"https://support.lusid.com/filtering-results-from-lusid\"> filtering results from LUSID</see>. (optional) 
            var sortBy = sortBy_example;  // string | Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional) 
            var page = page_example;  // string | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional) 
            var histogramInterval = histogramInterval_example;  // string | The interval for an included histogram of the logs (optional) 

            try
            {
                // [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations.
                ResourceListWithHistogramOfAccessEvaluationLog result = apiInstance.ListAccessEvaluationLogs(startAt, endAt, filter, sortBy, limit, page, histogramInterval);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessEvaluationsApi.ListAccessEvaluationLogs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startAt** | **DateTimeOffset?**| Start date from which point to fetch logs. | [optional] 
 **endAt** | **DateTimeOffset?**| End date to which point to fetch logs. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. | [optional] 
 **sortBy** | **string**| Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName | [optional] 
 **limit** | **int?**| When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. | [optional] 
 **page** | **string**| Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. | [optional] 
 **histogramInterval** | **string**| The interval for an included histogram of the logs | [optional] 

### Return type

[**ResourceListWithHistogramOfAccessEvaluationLog**](ResourceListWithHistogramOfAccessEvaluationLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

