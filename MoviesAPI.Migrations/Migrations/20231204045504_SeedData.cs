using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviesAPI.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1830f0c5-ce23-45e1-8aae-b345344f86f5"), "Action & Adventure" },
                    { new Guid("27e7f102-e460-4095-87ba-67e1b2cc5932"), "Drama" },
                    { new Guid("3de1f5c8-ffca-4ee6-92e8-0c9eb9074959"), "Sci-Fi & Fantasy" },
                    { new Guid("41473391-23d1-496d-8cc3-0ea3003fd5db"), "History" },
                    { new Guid("429f6d4e-885b-4607-897a-f3ecbfa7b9e6"), "Horror" },
                    { new Guid("432d1f42-3d1c-44b7-a40c-9b96d3a07aeb"), "Mistery" },
                    { new Guid("6f7daea1-c1e7-4ce6-b0d2-eef87b11fc6d"), "Adventure" },
                    { new Guid("7a9bdf52-bd33-4092-8669-9ded0ef5b704"), "Action" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Picture", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("278490e6-da09-4d49-84a9-cc0f0f4fc6b2"), "The Doctor is a Time Lord: a 900 year old alien with 2 hearts, part of a gifted civilization who mastered time travel. The Doctor saves planets for a living—more of a hobby actually, and the Doctor's very, very good at it.", "Doctor Who", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/4edFyasCrkH4MKs6H4mHqlrxA6b.jpg", "Doctor Who", 2005 },
                    { new Guid("2be04001-c8aa-4f06-a21a-e135c637db35"), "The story of J. Robert Oppenheimer's role in the development of the atomic bomb during World War II.", "Oppenheimer", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg", "Oppenheimer", 2023 },
                    { new Guid("3869f5ef-43a3-44dd-b6fa-fff4057173e9"), "Recently fired and desperate for work, a troubled young man named Mike agrees to take a position as a night security guard at an abandoned theme restaurant: Freddy Fazbear's Pizzeria. But he soon discovers that nothing at Freddy's is what it seems.", "Five Nights at Freddy's", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/j9mH1pr3IahtraTWxVEMANmPSGR.jpg", "Five Nights at Freddy's", 2023 },
                    { new Guid("4db341fb-2490-46c3-bf8f-bc4900ca2f49"), "After stealing the Tesseract during the events of “Avengers: Endgame,” an alternate version of Loki is brought to the mysterious Time Variance Authority, a bureaucratic organization that exists outside of time and space and monitors the timeline. They give Loki a choice: face being erased from existence due to being a “time variant” or help fix the timeline and stop a greater threat.", "Loki", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/voHUmluYmKyleFkTu3lOXQG702u.jpg", "Loki", 2021 },
                    { new Guid("6e54c2e8-f5ab-4fb2-8459-5ce4c728ca08"), "Finding himself in a new era, and approaching retirement, Indy wrestles with fitting into a world that seems to have outgrown him. But as the tentacles of an all-too-familiar evil return in the form of an old rival, Indy must don his hat and pick up his whip once more to make sure an ancient and powerful artifact doesn't fall into the wrong hands.", "Indiana Jones and the Dial of Destiny", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/Af4bXE63pVsb2FtbW8uYIyPBadD.jpg", "Indiana Jones and the Dial of Destiny", 2023 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "Id", "CategoryId", "MovieId" },
                values: new object[,]
                {
                    { 1, new Guid("1830f0c5-ce23-45e1-8aae-b345344f86f5"), new Guid("278490e6-da09-4d49-84a9-cc0f0f4fc6b2") },
                    { 2, new Guid("27e7f102-e460-4095-87ba-67e1b2cc5932"), new Guid("278490e6-da09-4d49-84a9-cc0f0f4fc6b2") },
                    { 3, new Guid("3de1f5c8-ffca-4ee6-92e8-0c9eb9074959"), new Guid("278490e6-da09-4d49-84a9-cc0f0f4fc6b2") },
                    { 4, new Guid("27e7f102-e460-4095-87ba-67e1b2cc5932"), new Guid("2be04001-c8aa-4f06-a21a-e135c637db35") },
                    { 5, new Guid("41473391-23d1-496d-8cc3-0ea3003fd5db"), new Guid("2be04001-c8aa-4f06-a21a-e135c637db35") },
                    { 6, new Guid("429f6d4e-885b-4607-897a-f3ecbfa7b9e6"), new Guid("3869f5ef-43a3-44dd-b6fa-fff4057173e9") },
                    { 7, new Guid("432d1f42-3d1c-44b7-a40c-9b96d3a07aeb"), new Guid("3869f5ef-43a3-44dd-b6fa-fff4057173e9") },
                    { 8, new Guid("27e7f102-e460-4095-87ba-67e1b2cc5932"), new Guid("4db341fb-2490-46c3-bf8f-bc4900ca2f49") },
                    { 9, new Guid("3de1f5c8-ffca-4ee6-92e8-0c9eb9074959"), new Guid("4db341fb-2490-46c3-bf8f-bc4900ca2f49") },
                    { 10, new Guid("6f7daea1-c1e7-4ce6-b0d2-eef87b11fc6d"), new Guid("6e54c2e8-f5ab-4fb2-8459-5ce4c728ca08") },
                    { 11, new Guid("7a9bdf52-bd33-4092-8669-9ded0ef5b704"), new Guid("6e54c2e8-f5ab-4fb2-8459-5ce4c728ca08") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1830f0c5-ce23-45e1-8aae-b345344f86f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27e7f102-e460-4095-87ba-67e1b2cc5932"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3de1f5c8-ffca-4ee6-92e8-0c9eb9074959"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41473391-23d1-496d-8cc3-0ea3003fd5db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("429f6d4e-885b-4607-897a-f3ecbfa7b9e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("432d1f42-3d1c-44b7-a40c-9b96d3a07aeb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f7daea1-c1e7-4ce6-b0d2-eef87b11fc6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a9bdf52-bd33-4092-8669-9ded0ef5b704"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("278490e6-da09-4d49-84a9-cc0f0f4fc6b2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2be04001-c8aa-4f06-a21a-e135c637db35"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3869f5ef-43a3-44dd-b6fa-fff4057173e9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4db341fb-2490-46c3-bf8f-bc4900ca2f49"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6e54c2e8-f5ab-4fb2-8459-5ce4c728ca08"));
        }
    }
}
