using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MoviesAPI.Models;
using MoviesAPI.Models.Models;

namespace MoviesAPI.Persistence.DbContexts
{
    public static class SeedData
    {
        #region Categories
        public readonly static Category ActionAndAdventure = new() { Id = new Guid("1830f0c5-ce23-45e1-8aae-b345344f86f5"), Name = "Action & Adventure" };
        public readonly static Category Drama = new() { Id = new Guid("27e7f102-e460-4095-87ba-67e1b2cc5932"), Name = "Drama" };
        public readonly static Category Fantasy = new() { Id = new Guid("3de1f5c8-ffca-4ee6-92e8-0c9eb9074959"), Name = "Sci-Fi & Fantasy" };
        public readonly static Category History = new() { Id = new Guid("41473391-23d1-496d-8cc3-0ea3003fd5db"), Name = "History" };
        public readonly static Category Horror = new() { Id = new Guid("429f6d4e-885b-4607-897a-f3ecbfa7b9e6"), Name = "Horror" };
        public readonly static Category Mistery = new() { Id = new Guid("432d1f42-3d1c-44b7-a40c-9b96d3a07aeb"), Name = "Mistery" };
        public readonly static Category Adventure = new() { Id = new Guid("6f7daea1-c1e7-4ce6-b0d2-eef87b11fc6d"), Name = "Adventure" };
        public readonly static Category Action = new() { Id = new Guid("7a9bdf52-bd33-4092-8669-9ded0ef5b704"), Name = "Action" };
        public readonly static Category Animation = new() { Id = new Guid("a9c1cd9f-5455-4e4f-a306-227e4b025c4b"), Name = "Animation" };
        public readonly static Category Family = new() { Id = new Guid("59264f1c-47df-4a7a-a010-0345c9760c07"), Name = "Family" };
        public readonly static Category Music = new() { Id = new Guid("dae4d0f4-297f-4f48-ab85-2e9fb2be0c5d"), Name = "Music" };
        public readonly static Category Comedy = new() { Id = new Guid("ef1b71c3-4d41-474f-8740-15844bc4f190"), Name = "Comedy" };
        #endregion

        #region Movies
        //public readonly static Movie Blank = new() { Id = Guid.NewGuid(), Name = "Blank", Title = "Blank", Year = 2023, Picture = "", Description = "" };
        public readonly static Movie DoctorWho = new() { Id = new Guid("278490e6-da09-4d49-84a9-cc0f0f4fc6b2"), Name = "Doctor Who", Title = "Doctor Who", Year = 2005, Picture = "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/4edFyasCrkH4MKs6H4mHqlrxA6b.jpg", Description = "The Doctor is a Time Lord: a 900 year old alien with 2 hearts, part of a gifted civilization who mastered time travel. The Doctor saves planets for a living—more of a hobby actually, and the Doctor's very, very good at it." };
        public readonly static Movie Oppenheimer = new() { Id = new Guid("2be04001-c8aa-4f06-a21a-e135c637db35"), Name = "Oppenheimer", Title = "Oppenheimer", Year = 2023, Picture = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg", Description = "The story of J. Robert Oppenheimer's role in the development of the atomic bomb during World War II." };
        public readonly static Movie FiveNightsAtFreddys = new() { Id = new Guid("3869f5ef-43a3-44dd-b6fa-fff4057173e9"), Name = "Five Nights at Freddy's", Title = "Five Nights at Freddy's", Year = 2023, Picture = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/j9mH1pr3IahtraTWxVEMANmPSGR.jpg", Description = "Recently fired and desperate for work, a troubled young man named Mike agrees to take a position as a night security guard at an abandoned theme restaurant: Freddy Fazbear's Pizzeria. But he soon discovers that nothing at Freddy's is what it seems." };
        public readonly static Movie Loki = new() { Id = new Guid("4db341fb-2490-46c3-bf8f-bc4900ca2f49"), Name = "Loki", Title = "Loki", Year = 2021, Picture = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/voHUmluYmKyleFkTu3lOXQG702u.jpg", Description = "After stealing the Tesseract during the events of “Avengers: Endgame,” an alternate version of Loki is brought to the mysterious Time Variance Authority, a bureaucratic organization that exists outside of time and space and monitors the timeline. They give Loki a choice: face being erased from existence due to being a “time variant” or help fix the timeline and stop a greater threat." };
        public readonly static Movie IndianaJones = new() { Id = new Guid("6e54c2e8-f5ab-4fb2-8459-5ce4c728ca08"), Name = "Indiana Jones and the Dial of Destiny", Title = "Indiana Jones and the Dial of Destiny", Year = 2023, Picture = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/Af4bXE63pVsb2FtbW8uYIyPBadD.jpg", Description = "Finding himself in a new era, and approaching retirement, Indy wrestles with fitting into a world that seems to have outgrown him. But as the tentacles of an all-too-familiar evil return in the form of an old rival, Indy must don his hat and pick up his whip once more to make sure an ancient and powerful artifact doesn't fall into the wrong hands." };
        public readonly static Movie TrollsBandTogether = new() { Id = new Guid("4e2809d5-7bc0-429c-8785-0fc243e9f439"), Name = "Trolls Band Together", Title = "Trolls Band Together", Year = 2023, Picture = "", Description = "" };
        #endregion

        #region Movie Category
        public readonly static MovieCategory DoctorWhoCategory1 = new() { Id = 1, MovieId = DoctorWho.Id, CategoryId = ActionAndAdventure.Id };
        public readonly static MovieCategory DoctorWhoCategory2 = new() { Id = 2, MovieId = DoctorWho.Id, CategoryId = Drama.Id };
        public readonly static MovieCategory DoctorWhoCategory3 = new() { Id = 3, MovieId = DoctorWho.Id, CategoryId = Fantasy.Id };

        public readonly static MovieCategory OppenheimerCategory1 = new() { Id = 4, MovieId = Oppenheimer.Id, CategoryId = Drama.Id };
        public readonly static MovieCategory OppenheimerCategory2 = new() { Id = 5, MovieId = Oppenheimer.Id, CategoryId = History.Id };

        public readonly static MovieCategory FiveNightsAtFreddysCategory1 = new() { Id = 6, MovieId = FiveNightsAtFreddys.Id, CategoryId = Horror.Id };
        public readonly static MovieCategory FiveNightsAtFreddysCategory2 = new() { Id = 7, MovieId = FiveNightsAtFreddys.Id, CategoryId = Mistery.Id };

        public readonly static MovieCategory LokiCategory1 = new() { Id = 8, MovieId = Loki.Id, CategoryId = Drama.Id };
        public readonly static MovieCategory LokiCategory2 = new() { Id = 9, MovieId = Loki.Id, CategoryId = Fantasy.Id };

        public readonly static MovieCategory IndianaJonesCategory1 = new() { Id = 10, MovieId = IndianaJones.Id, CategoryId = Adventure.Id };
        public readonly static MovieCategory IndianaJonesCategory2 = new() { Id = 11, MovieId = IndianaJones.Id, CategoryId = Action.Id };

        public readonly static MovieCategory TrollsBandTogetherCategory1 = new() { Id = 12, MovieId = TrollsBandTogether.Id, CategoryId = Animation.Id };
        public readonly static MovieCategory TrollsBandTogetherCategory2 = new() { Id = 13, MovieId = TrollsBandTogether.Id, CategoryId = Family.Id };
        public readonly static MovieCategory TrollsBandTogetherCategory3 = new() { Id = 14, MovieId = TrollsBandTogether.Id, CategoryId = Music.Id };
        public readonly static MovieCategory TrollsBandTogetherCategory4 = new() { Id = 15, MovieId = TrollsBandTogether.Id, CategoryId = Fantasy.Id };
        public readonly static MovieCategory TrollsBandTogetherCategory5 = new() { Id = 16, MovieId = TrollsBandTogether.Id, CategoryId = Comedy.Id };
        #endregion

        #region Summary
        public readonly static List<Category> Categories = new()
        {
            ActionAndAdventure, Drama, Fantasy, History, Horror, Mistery,Adventure, Action
        };

        public readonly static List<Movie> Movies = new()
        {
            DoctorWho, Oppenheimer, FiveNightsAtFreddys, Loki, IndianaJones
        };

        public readonly static List<MovieCategory> MovieCategories = new()
        {
            DoctorWhoCategory1,
            DoctorWhoCategory2,
            DoctorWhoCategory3,
            OppenheimerCategory1,
            OppenheimerCategory2,
            FiveNightsAtFreddysCategory1,
            FiveNightsAtFreddysCategory2,
            LokiCategory1,
            LokiCategory2,
            IndianaJonesCategory1,
            IndianaJonesCategory2
        };
        #endregion
    }
}
