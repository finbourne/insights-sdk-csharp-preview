![LUSID_by_Finbourne](./resources/Finbourne_Logo_Teal.svg)

# LUSID<sup>®</sup> Insights SDK C# (Preview)

This is the C# SDK (Preview) for the Insights application, part of the [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology) platform. To use it you'll need a LUSID account. [Sign up for free at lusid.com](https://www.lusid.com/app/signup).

The Insights application is a monitoring and troubleshooting service.

For more details on other applications in the LUSID platform, see [Understanding all the applications in the LUSID platform](https://support.lusid.com/knowledgebase/article/KA-01787/en-us).

[C# SDK Extensions](https://github.com/finbourne/insights-sdk-extensions-csharp) to accompany this SDK are available. These provides the user with additional extensions to make it easy to configure and use the API endpoints.

## Installation

The NuGet package for the FINBOURNE Insights service SDK (Preview) can installed from https://www.nuget.org/packages/Finbourne.Insights.Sdk.Preview using the following:

```
$ dotnet add package Finbourne.Insights.Sdk.Preview
```

This C# SDK (Preview) supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints. For more details on API endpoint categories, see [Documentation - Release Lifecycle](https://www.lusid.com/app/resources/documentation/lifecycle). To find out which category an API endpoint falls into, see [FINBOURNE Insights API Documentation](https://www.lusid.com/insights/swagger/index.html).

## Build Status 

| branch | status |
| --- | --- |
| `master` |  ![Nuget](https://img.shields.io/nuget/v/Finbourne.Insights.Sdk.Preview?color=blue) [![Build](https://github.com/finbourne/insights-sdk-csharp-preview/actions/workflows/build.yaml/badge.svg?branch=master)](https://github.com/finbourne/insights-sdk-csharp-preview/actions/workflows/build.yaml) |