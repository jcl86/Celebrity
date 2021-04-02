using Celebrity.Shared;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
using Microsoft.AspNetCore.TestHost;

namespace Celebrity.FunctionalTests
{
    [Collection(nameof(ServerFixtureCollection))]
    public class CategoryShould
    {
        private readonly ServerFixture Given;

        public CategoryShould(ServerFixture fixture)
        {
            Given = fixture ?? throw new ArgumentNullException(nameof(fixture));
        }

        [Fact]
        public async Task Be_found()
        {
            var subcategory = await Given.SubcategoryInDatabase();

            var response = await Given
               .Server
               .CreateRequest(CategoryEndpoints.GetCategory((int)subcategory.Category))
               .WithIdentity(Identities.Administrator)
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<Category>();

            result.Subcategories.Should().ContainEquivalentOf(subcategory.AsBaseObject());
            result.Value.Should().Be(subcategory.Category);
        }

        [Fact]
        public async Task Be_all_found()
        {
            var subcategory = await Given.SubcategoryInDatabase();

            var response = await Given
               .Server
               .CreateRequest(CategoryEndpoints.GetCategories())
               .WithIdentity(Identities.Administrator)
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<IEnumerable<Category>>();

            result.Should().Contain(x => x.Value == subcategory.Category);
            result.First(x => x.Value == subcategory.Category).Subcategories
                .Should().ContainEquivalentOf(subcategory.AsBaseObject());
        }

        [Fact]
        public async Task Fail_to_be_found_when_user_is_not_admin()
        {
            var subcategory = await Given.SubcategoryInDatabase();

            var response = await Given
               .Server
               .CreateRequest(CategoryEndpoints.GetCategory((int)subcategory.Category))
               .GetAsync();

            await response.ShouldBe(StatusCodes.Status401Unauthorized);
        }

    }
}
