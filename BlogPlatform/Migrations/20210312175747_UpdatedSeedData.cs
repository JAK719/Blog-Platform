using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "I like pizza because it's delicous.  My favorite is Edison's Pizza in Tremont.  Just get me a hot slice of pepperoni from Edison's and I am a happy man.", new DateTime(2021, 3, 12, 12, 57, 47, 277, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "I enjoy watching MMA, the UFC in particular.  I enjoy the dedication the fighters put towards the craft and the problem-solving that goes into picking apart another fighter, as well as watching the adjustments they have to make live in the fight.  There's also incredible sportsmanship.  Sure, there are exceptions when it comes to sportsmanship.  But, for the most part you're always going to see 2 fighters shake hands and hug it out after a beating on each other.", new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Camping is neat.  I enjoy hanging a hammock in the trees and listening to the sounds of nature.  Fire is cool too, and smells nice.  Renting a boat and cruising the lake is also quite enjoyable.  Hopefully I'll end up making stacks of cash as a software developer and be able to buy my own boat someday, but renting them is fun for now.", new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Soccer...  What's there to say?  I definitely appreciate the skill and conditioning it takes to play the sport.  I'll never say soccer players aren't exceptional athletes.  But, 90 minutes plus stoppage time added on with a final score of 1-0... No thank you!", new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3296), "Soccer..." });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3309));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "I like pizza because it's delicous.  My favorite is Edison's Pizza in Tremont.  You should try it out.", new DateTime(2021, 3, 11, 12, 13, 7, 572, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "I enjoy watching MMA, the UFC in particular.  I enjoy the dedication the fighters put towards the craft and the problem-solving that goes into picking apart another fighter, as well as watching the adjustments they have to make live in the fight.  I also enjoy the sportsmanship.  It's incredible to see 2 fighters beat up on each other and then hug it out afterwards.", new DateTime(2021, 3, 11, 12, 13, 7, 577, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Camping is neat.  I enjoy hanging a hammock in the trees and listening to the sounds of nature.  Fire is cool too, and smells nice.  Renting a boat and cruising the lake is also quite enjoyable.  I'd like to get my onw boat someday, but renting them is fun for now.", new DateTime(2021, 3, 11, 12, 13, 7, 577, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "I enjoy watching football.  Tailgating is neat.  Fantasy football is fun too.", new DateTime(2021, 3, 11, 12, 13, 7, 577, DateTimeKind.Local).AddTicks(6614), "I like Football" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2021, 3, 11, 12, 13, 7, 577, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2021, 3, 11, 12, 13, 7, 577, DateTimeKind.Local).AddTicks(6626));
        }
    }
}
