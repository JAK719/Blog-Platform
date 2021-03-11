using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Camping" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Sports" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Jason Kepic", "I like pizza because it's delicous.  My favorite is Edison's Pizza in Tremont.  You should try it out.", 1, new DateTime(2021, 3, 9, 20, 58, 49, 767, DateTimeKind.Local).AddTicks(9575), "I like Pizza" },
                    { 6, "Jason Kepic", "Pickles are great!  They have been my favorite food since I was just a lil tyke.  I enjoy all types, though as a child I did not like sweet pickles, but they have since grown on me.  I make my own pickles too.  I have a 2 big crocks, a 5-gallon and a 3-gallon.  I bought them from some lady on Craigslist who's mother had passed.  She shared a memory of her mother making sauerkraut in them since she was a girl.  Unfortunately, I'm pretty sure the 3-gallon crock has a crack in it somewhere.  Last time I made pickles in it, they never fermented.  It's not fun throwing away mushy cucumbers that never pickled. I'm going to have to look into getting the crock re-glazed and sealed.  I could buy brand new ones, they're really quite affordable.  But it seems a shame to get rid of the history in those crocks. Fun fact about crocks, Ohio has a rich history in making crocks on the count of all the clay in the Ohio Valley.  East Liverpool, Ohio was known as the Pottery Capital of the World, once being home to over 300 pottery companies at a time.  Now that's a lot of pickles.", 1, new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1767), "Pickles!" },
                    { 3, "AsonJay EpicKay", "Camping is neat.  I enjoy hanging a hammock in the trees and listening to the sounds of nature.  Fire is cool too, and smells nice.  Renting a boat and cruising the lake is also quite enjoyable.  I'd like to get my onw boat someday, but renting them is fun for now.", 2, new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1746), "I like Camping" },
                    { 5, "AsonJay EpicKay", "Fire pies are delicious.  You get yourself a cast iron pie maker, put 2 buttered pieces of bread in their with whatever toppings you like, I myself am partial to pizza toppings, and stick it in the fire.  Take it out and check it often so you don't burn it.  Once it's ready try to contain yourself and let it cool or else you will burn your mouth pretty bad.  Trust me, I know from experience as I myself am a repeat offender.", 2, new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1761), "Fire Pies" },
                    { 2, "ShMason ShMepic", "I enjoy watching MMA, the UFC in particular.  I enjoy the dedication the fighters put towards the craft and the problem-solving that goes into picking apart another fighter, as well as watching the adjustments they have to make live in the fight.  I also enjoy the sportsmanship.  It's incredible to see 2 fighters beat up on each other and then hug it out afterwards.", 3, new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1622), "I like MMA" },
                    { 4, "ShMason ShMepic", "I enjoy watching football.  Tailgating is neat.  Fantasy football is fun too.", 3, new DateTime(2021, 3, 9, 20, 58, 49, 773, DateTimeKind.Local).AddTicks(1755), "I like Football" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
