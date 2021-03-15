using blog_template_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB;Trusted_Connection=True;MultipleActiveResultSets=true;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add seed data for CategoryId model:
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Food"
                    
                },
                new Category()
                {
                    Id = 2,
                    Name = "Camping"                   
                },
                new Category()
                {
                    Id = 3,
                    Name = "Sports"
                    
                }
             );

            // Add seed data for Content model:
            modelBuilder.Entity<Content>().HasData(
                new Content()
                {
                   Id = 1,
                   Title = "I like Pizza",
                   Author = "AsonJay EpicKay",
                    PublishDate = DateTime.Now,
                    CategoryId = 1,
                   Body = "I like pizza because it's delicous.  My favorite is Edison's Pizza in Tremont.  Just get me a hot slice of pepperoni from Edison's and I am a happy man."
                },
                new Content()
                {
                   Id = 2,
                   Title = "I like MMA",
                   Author = "ShMason ShMepic",
                    PublishDate = DateTime.Now,
                    CategoryId = 3,
                   Body = "I enjoy watching MMA, the UFC in particular.  I enjoy the dedication the fighters put towards the craft and the problem-solving that goes into picking apart another fighter, as well as watching the adjustments they have to make live in the fight.  There's also incredible sportsmanship.  Sure, there are exceptions when it comes to sportsmanship.  But, for the most part you're always going to see 2 fighters shake hands and hug it out after a beating on each other."
                },
                new Content()
                {
                   Id = 3,
                   Title = "I like Camping",
                   Author = "Jason Kepic",
                    PublishDate = DateTime.Now,
                    CategoryId = 2,
                   Body = "Camping is neat.  I enjoy hanging a hammock in the trees and listening to the sounds of nature.  Fire is cool too, and smells nice.  Renting a boat and cruising the lake is also quite enjoyable.  Hopefully I'll end up making stacks of cash as a software developer and be able to buy my own boat someday, but renting them is fun for now."
                },
                new Content()
                {
                   Id = 4,
                   Title = "Soccer...",
                   Author = "ShMason ShMepic",
                    PublishDate = DateTime.Now,
                    CategoryId = 3,
                   Body = "Soccer...  What's there to say?  I definitely appreciate the skill and conditioning it takes to play the sport.  I'll never say soccer players aren't exceptional athletes.  But, 90 minutes plus stoppage time added on with a final score of 1-0... No thank you!"
                },
                new Content()
                {
                   Id = 5,
                   Title = "Fire Pies",
                   Author = "AsonJay EpicKay",
                    PublishDate = DateTime.Now,
                    CategoryId = 2,
                   Body = "Fire pies are delicious.  You get yourself a cast iron pie maker, put 2 buttered pieces of bread in their with whatever toppings you like, I myself am partial to pizza toppings, and stick it in the fire.  Take it out and check it often so you don't burn it.  Once it's ready try to contain yourself and let it cool or else you will burn your mouth pretty bad.  Trust me, I know from experience as I myself am a repeat offender."
                },
                new Content()
                {
                   Id = 6,
                   Title = "Pickles!",
                   Author = "Jason Kepic",
                    PublishDate = DateTime.Now,
                    CategoryId = 1,
                   Body = "Pickles are great!  They have been my favorite food since I was just a lil tyke.  I enjoy all types, though as a child I did not like sweet pickles, but they have since grown on me.  I make my own pickles too.  I have a 2 big crocks, a 5-gallon and a 3-gallon.  I bought them from some lady on Craigslist who's mother had passed.  She shared a memory of her mother making sauerkraut in them since she was a girl.  Unfortunately, I'm pretty sure the 3-gallon crock has a crack in it somewhere.  Last time I made pickles in it, they never fermented.  It's not fun throwing away mushy cucumbers that never pickled. I'm going to have to look into getting the crock re-glazed and sealed.  I could buy brand new ones, they're really quite affordable.  But it seems a shame to get rid of the history in those crocks. Fun fact about crocks, Ohio has a rich history in making crocks on the count of all the clay in the Ohio Valley.  East Liverpool, Ohio was known as the Pottery Capital of the World, once being home to over 300 pottery companies at a time.  Now that's a lot of pickles."
                }
             );

            base.OnModelCreating(modelBuilder);
        }
    }
}
