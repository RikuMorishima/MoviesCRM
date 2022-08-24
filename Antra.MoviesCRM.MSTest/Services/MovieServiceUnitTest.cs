using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Antra.MoviesCRM.MSTest.Services
{
    [TestClass]
    public class MovieServiceUnitTest
    {
        private IMovieService _movieService;

        private static List<Movie> _movies;
        private static List<MovieModel> _movieModels;
        private static Movie _movieInsert;
        private static MovieModel _movieModelInsert;
        private Mock<IMovieRepository> _mockMovieRepository;

        [ClassInitialize] // [OneTimeSetup] in nUnit
        public static void OneTimeSetup(TestContext context)
        {
            _movies = new List<Movie>()
            {
                new Movie() { Id=1, Title="Title 1",  },
                new Movie() { Id=2, Title="Title 2",  },
                new Movie() { Id=3, Title="Title 3",  },
                new Movie() { Id=4, Title="Title 4",  },
                new Movie() { Id=5, Title="Title 5",  },
                new Movie() { Id=6, Title="Title 6",  },
                new Movie() { Id=7, Title="Title 7",  },
                new Movie() { Id=8, Title="Title 8",  },
                new Movie() { Id=9, Title="Title 9",  },
                new Movie() { Id=10, Title="Title 10",  },
                new Movie() { Id=11, Title="Title 11",  },
                new Movie() { Id=12, Title="Title 12",  },
                new Movie() { Id=13, Title="Title 13",  },
                new Movie() { Id=14, Title="Title 14",  },
                new Movie() { Id=15, Title="Title 15",  },
                new Movie() { Id=16, Title="Title 16",  },
                new Movie() { Id=17, Title="Title 17",  },
                new Movie() { Id=18, Title="Title 18",  },
                new Movie() { Id=19, Title="Title 19",  },
                new Movie() { Id=20, Title="Title 20",  },
                new Movie() { Id=21, Title="Title 21",  },

            };
            _movieModels = new List<MovieModel>()
            {
                new MovieModel() { Id=1, Title="Title 1",  },
                new MovieModel() { Id=2, Title="Title 2",  },
                new MovieModel() { Id=3, Title="Title 3",  },
                new MovieModel() { Id=4, Title="Title 4",  },
                new MovieModel() { Id=5, Title="Title 5",  },
                new MovieModel() { Id=6, Title="Title 6",  },
                new MovieModel() { Id=7, Title="Title 7",  },
                new MovieModel() { Id=8, Title="Title 8",  },
                new MovieModel() { Id=9, Title="Title 9",  },
                new MovieModel() { Id=10, Title="Title 10",  },
                new MovieModel() { Id=11, Title="Title 11",  },
                new MovieModel() { Id=12, Title="Title 12",  },
                new MovieModel() { Id=13, Title="Title 13",  },
                new MovieModel() { Id=14, Title="Title 14",  },
                new MovieModel() { Id=15, Title="Title 15",  },
                new MovieModel() { Id=16, Title="Title 16",  },
                new MovieModel() { Id=17, Title="Title 17",  },
                new MovieModel() { Id=18, Title="Title 18",  },
                new MovieModel() { Id=19, Title="Title 19",  },
                new MovieModel() { Id=20, Title="Title 20",  },
                new MovieModel() { Id=21, Title="Title 21",  },
            };
            _movieInsert = new Movie()
            {
                Id = 22,
                Title = "Title 22"
            };
            _movieModelInsert = new MovieModel()
            {
                Id = 22,
                Title = "Title 22"
            };
        }

        [TestInitialize]
        public void Setup()
        {
            _mockMovieRepository = new Mock<IMovieRepository>();
            _mockMovieRepository.Setup(expression: m => m.GetAllAsync()).ReturnsAsync(_movies);
            _mockMovieRepository.Setup(expression: m => m.GetByIdAsync(2)).ReturnsAsync(_movies[1]);
            _mockMovieRepository.Setup(expression: m => m.InsertAsync(It.IsAny<Movie>())).ReturnsAsync(1);
            _mockMovieRepository.Setup(expression: m => m.DeleteAsync(1)).ReturnsAsync(1);
            _mockMovieRepository.Setup(expression: m => m.UpdateAsync(It.IsAny<Movie>())).ReturnsAsync(1);
            for (int i  = 0; i < _movieModels.Count(); i+=10)
                _mockMovieRepository.Setup(expression: m => m.GetAllByGenreIdPaginatedAsync(1, 10, i/10 + 1))
                    .ReturnsAsync(_movieModels.GetRange(i, Math.Min(10,_movieModels.Count()-i)));
            _movieService = new MovieService(_mockMovieRepository.Object);
        }

        [TestMethod]
        public async Task GetAllListMockTest()
        {
            var movies = await _movieService.GetAllModelAsync();
            Assert.IsNotNull(movies);
            Assert.IsInstanceOfType(movies, typeof(IEnumerable<MovieModel>));
            Assert.AreEqual(_movieModels.Count(), movies.Count());
            //return movies;
        }

        [TestMethod]
        public async Task GetByIdMockTest()
        {
            var movies = await _movieService.GetModelByIdAsync(2);
            Assert.IsNotNull(movies);
            Assert.IsInstanceOfType(movies, typeof(MovieModel));
            Assert.AreEqual(movies.Title, _movieModels[1].Title);
            //return movies;
        }

        [TestMethod]
        public async Task InsertMockTest()
        {
            var movies = await _movieService.InsertModelAsync(_movieModelInsert);
            Assert.IsNotNull(movies);
            Assert.IsInstanceOfType(movies, typeof(int));
            Assert.AreEqual(movies, 1);
        }

        [TestMethod]
        public async Task DeleteMockTest()
        {
            var movies = await _movieService.DeleteModelAsync(1);
            Assert.IsNotNull(movies);
            Assert.IsInstanceOfType(movies, typeof(int));
            Assert.AreEqual(movies, 1);
        }

        [TestMethod]
        public async Task UpdateMockTest()
        {
            var movies = await _movieService.UpdateModelAsync(new MovieModel()
            {
                Id=1,
                Title="ModifiedTitle"
            });
            Assert.IsNotNull(movies);
            Assert.IsInstanceOfType(movies, typeof(int));
            Assert.AreEqual(movies, 1);
        }

        [TestMethod]
        public async Task GetMoviesByGenreMockTest()
        {
            var movies1 = await _movieService.GetMoviesByGenre(1, 10, 1);
            var movies2 = await _movieService.GetMoviesByGenre(1, 10, 2);
            var movies3 = await _movieService.GetMoviesByGenre(1, 10, 3);
            Assert.IsNotNull(movies1);
            Assert.IsInstanceOfType(movies1, typeof(PaginationModel<IEnumerable<MovieModel>>));
            Assert.IsNotNull(movies2);
            Assert.IsInstanceOfType(movies2, typeof(PaginationModel<IEnumerable<MovieModel>>));
            Assert.IsNotNull(movies3);
            Assert.IsInstanceOfType(movies3, typeof(PaginationModel<IEnumerable<MovieModel>>));
            Assert.AreEqual(_movies.Count(), movies1.Value.Count()+ movies2.Value.Count()+movies3.Value.Count());
        }
    }
}