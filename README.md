# aspnetcore-httpclient-enumissue
A sample project showing the problems with HttpClient and getting an array from an API controller (see https://github.com/aspnet/Mvc/issues/4257)

The project is just a standard ASP NET Core API project created from VS2015. An xUnit library project has been added for testing. The important files are: The [controller](https://github.com/bragma/aspnetcore-httpclient-enumissue/blob/master/src/EnumerableHttpClientFails/Controllers/ValuesController.cs) providing the enumerable results and the [tests](https://github.com/bragma/aspnetcore-httpclient-enumissue/blob/master/src/Tests/Tests.cs).

In particular, "GetRangeFails_Fails" fails with:

```
Test Name:	Tests.GetRangeFails_Fails
Test FullName:	Tests.Tests.GetRangeFails_Fails
Test Source:	C:\Devel\aspnetcore-httpclient-enumissue\src\Tests\Tests.cs : line 51
Test Outcome:	Failed
Test Duration:	0:00:00,014

Result StackTrace:	
in Xunit.Assert.Equal[T](T expected, T actual, IEqualityComparer`1 comparer) in C:\BuildAgent\work\cb37e9acf085d108\src\xunit.assert\Asserts\EqualityAsserts.cs:riga 35
   in Xunit.Assert.Equal[T](T expected, T actual) in C:\BuildAgent\work\cb37e9acf085d108\src\xunit.assert\Asserts\EqualityAsserts.cs:riga 19
   in Tests.Tests.<GetRangeFails_Fails>d__5.MoveNext() in C:\Devel\aspnetcore-httpclient-enumissue\src\Tests\Tests.cs:riga 57
--- Fine traccia dello stack da posizione precedente dove è stata generata l'eccezione ---
   in System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   in System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   in Xunit.Sdk.TestInvoker`1.<>c__DisplayClass46_1.<<InvokeTestMethodAsync>b__1>d.MoveNext() in C:\BuildAgent\work\cb37e9acf085d108\src\xunit.execution\Sdk\Frameworks\Runners\TestInvoker.cs:riga 227
--- Fine traccia dello stack da posizione precedente dove è stata generata l'eccezione ---
   in System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   in System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   in Xunit.Sdk.ExecutionTimer.<AggregateAsync>d__4.MoveNext() in C:\BuildAgent\work\cb37e9acf085d108\src\xunit.execution\Sdk\Frameworks\ExecutionTimer.cs:riga 48
--- Fine traccia dello stack da posizione precedente dove è stata generata l'eccezione ---
   in System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   in System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   in Xunit.Sdk.ExceptionAggregator.<RunAsync>d__9.MoveNext() in C:\BuildAgent\work\cb37e9acf085d108\src\xunit.core\Sdk\ExceptionAggregator.cs:riga 90
Result Message:	
Assert.Equal() Failure
Expected: 1000
Actual:   79
```
