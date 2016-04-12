using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EnumerableHttpClientFails;
using Microsoft.AspNet.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace Tests
{
	// This project can output the Class library as a NuGet Package.
	// To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
	public class Tests
	{
		private readonly TestServer _server;
		private readonly HttpClient _client;


		public Tests()
		{
			_server = new TestServer(TestServer.CreateBuilder().UseStartup<Startup>());
			_client = _server.CreateClient();
		}

		[Fact]
		public async Task GetRangeToList_Passes()
		{
			var getResponse = await _client.GetAsync("/api/values/rangetolist");
			var fetchedData = await getResponse.Content.ReadAsStringAsync();

			var results = JsonConvert.DeserializeObject<IEnumerable<string>>(fetchedData);

			Assert.Equal(1000, results.Count());
		}

		[Fact]
		public async Task GetRangeCount_Passes()
		{
			var getResponse = await _client.GetAsync("/api/values/rangecount");
			var fetchedData = await getResponse.Content.ReadAsStringAsync();

			var results = JsonConvert.DeserializeObject<IEnumerable<string>>(fetchedData);

			Assert.Equal(1000, results.Count());
		}

		[Fact]
		public async Task GetRangeFails_Fails()
		{
			var getResponse = await _client.GetAsync("/api/values/rangefails");
			var fetchedData = await getResponse.Content.ReadAsStringAsync();

			var results = JsonConvert.DeserializeObject<IEnumerable<string>>(fetchedData);

			Assert.Equal(1000, results.Count());
		}
	}
}
