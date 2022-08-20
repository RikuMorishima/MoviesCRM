using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Services;
using Antra.MoviesCRM.MSTest.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Antra.MoviesCRM.MSTest
{
    [TestClass]
    public class MovieServiceUnitTest
    {
        private IMovieService _movieService;

        private List<Movie> _movies;
        private Mock<IMovieRepository> _mockMovieRepository;

        [TestInitialize] // [OneTimeSetup] in nUnit
        public void OneTimeSetup()
        {
            _movies= new List<Movie>()
            {

            };
        }

        [ClassInitialize]
        public void Setup(TestContext context)
        {
            _mockMovieRepository = new Mock<IMovieRepository>();
            _mockMovieRepository.Setup(expression: m=>m.GetAllAsync()).ReturnsAsync(_movies);
            _movieService = new MovieService(_mockMovieRepository.Object);
        }

        [TestMethod]
        public async Task ListOfMoviesByGenreMockTest()
        {
            var _movieServiceNormal = new MovieService(new MovieMockRepository());
            var movies = await _movieServiceNormal.GetMoviesByGenre(1);

            Assert.IsNotNull(movies);
        }

        [TestMethod]
        public async Task GetAllListMockTest()
        {
            var movies = await _movieService.GetAllModelAsync();
            Assert.IsNotNull(movies);
            Assert.IsInstanceOfType(movies, typeof(MovieModel));
            Assert.AreEqual(10, movies.Count());
        }
    }
}