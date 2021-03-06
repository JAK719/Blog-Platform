// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog_template_practice;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20210312175747_UpdatedSeedData")]
    partial class UpdatedSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blog_template_practice.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Food"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Camping"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sports"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Jason Kepic",
                            Body = "I like pizza because it's delicous.  My favorite is Edison's Pizza in Tremont.  Just get me a hot slice of pepperoni from Edison's and I am a happy man.",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 3, 12, 12, 57, 47, 277, DateTimeKind.Local).AddTicks(6497),
                            Title = "I like Pizza"
                        },
                        new
                        {
                            Id = 2,
                            Author = "ShMason ShMepic",
                            Body = "I enjoy watching MMA, the UFC in particular.  I enjoy the dedication the fighters put towards the craft and the problem-solving that goes into picking apart another fighter, as well as watching the adjustments they have to make live in the fight.  There's also incredible sportsmanship.  Sure, there are exceptions when it comes to sportsmanship.  But, for the most part you're always going to see 2 fighters shake hands and hug it out after a beating on each other.",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3167),
                            Title = "I like MMA"
                        },
                        new
                        {
                            Id = 3,
                            Author = "AsonJay EpicKay",
                            Body = "Camping is neat.  I enjoy hanging a hammock in the trees and listening to the sounds of nature.  Fire is cool too, and smells nice.  Renting a boat and cruising the lake is also quite enjoyable.  Hopefully I'll end up making stacks of cash as a software developer and be able to buy my own boat someday, but renting them is fun for now.",
                            CategoryId = 2,
                            PublishDate = new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3287),
                            Title = "I like Camping"
                        },
                        new
                        {
                            Id = 4,
                            Author = "ShMason ShMepic",
                            Body = "Soccer...  What's there to say?  I definitely appreciate the skill and conditioning it takes to play the sport.  I'll never say soccer players aren't exceptional athletes.  But, 90 minutes plus stoppage time added on with a final score of 1-0... No thank you!",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3296),
                            Title = "Soccer..."
                        },
                        new
                        {
                            Id = 5,
                            Author = "AsonJay EpicKay",
                            Body = "Fire pies are delicious.  You get yourself a cast iron pie maker, put 2 buttered pieces of bread in their with whatever toppings you like, I myself am partial to pizza toppings, and stick it in the fire.  Take it out and check it often so you don't burn it.  Once it's ready try to contain yourself and let it cool or else you will burn your mouth pretty bad.  Trust me, I know from experience as I myself am a repeat offender.",
                            CategoryId = 2,
                            PublishDate = new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3303),
                            Title = "Fire Pies"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Jason Kepic",
                            Body = "Pickles are great!  They have been my favorite food since I was just a lil tyke.  I enjoy all types, though as a child I did not like sweet pickles, but they have since grown on me.  I make my own pickles too.  I have a 2 big crocks, a 5-gallon and a 3-gallon.  I bought them from some lady on Craigslist who's mother had passed.  She shared a memory of her mother making sauerkraut in them since she was a girl.  Unfortunately, I'm pretty sure the 3-gallon crock has a crack in it somewhere.  Last time I made pickles in it, they never fermented.  It's not fun throwing away mushy cucumbers that never pickled. I'm going to have to look into getting the crock re-glazed and sealed.  I could buy brand new ones, they're really quite affordable.  But it seems a shame to get rid of the history in those crocks. Fun fact about crocks, Ohio has a rich history in making crocks on the count of all the clay in the Ohio Valley.  East Liverpool, Ohio was known as the Pottery Capital of the World, once being home to over 300 pottery companies at a time.  Now that's a lot of pickles.",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 3, 12, 12, 57, 47, 282, DateTimeKind.Local).AddTicks(3309),
                            Title = "Pickles!"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.HasOne("blog_template_practice.Models.Category", "Category")
                        .WithMany("Content")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
