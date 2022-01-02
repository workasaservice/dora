﻿using Ardalis.HttpClientTestExtensions;
using System.Net.Http;
using System.Threading.Tasks;
using waas.doro.Web;
using waas.doro.Web.Endpoints.ProjectEndpoints;
using Xunit;

namespace waas.doro.FunctionalTests.ApiEndpoints
{
    [Collection("Sequential")]
    public class ProjectGetById : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ProjectGetById(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsSeedProjectGivenId1()
        {
            var result = await _client.GetAndDeserialize<GetProjectByIdResponse>(GetProjectByIdRequest.BuildRoute(1));

            Assert.Equal(1, result.Id);
            Assert.Equal(SeedData.TestProject1.Name, result.Name);
            Assert.Equal(3, result.Items.Count);
        }

        [Fact]
        public async Task ReturnsNotFoundGivenId0()
        {
            string route = GetProjectByIdRequest.BuildRoute(0);
            _ = await _client.GetAndEnsureNotFound(route);
        }
    }
}
