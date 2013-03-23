using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Select2Example
{
    public class Actor
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static IEnumerable<Actor> SearchActors(string searchTerm)
        {
            var allActors = GetAllActors();
            return allActors.Where(a => a.Name.Contains(searchTerm));
        }

        public static IEnumerable<Actor> GetAllActors()
        {
            return new Actor[] {                                     
                                    new Actor{ ID=1, Name="Arnold Schwarzenegger"},
                                    new Actor{ ID=2, Name="Bruce Willis"},
                                    new Actor{ ID=3, Name="Chuck Norris"},
                                    new Actor{ ID=4, Name="Jean-Claude Van Damme"},
                                    new Actor{ ID=5, Name="Jason Statham"},
                                    new Actor{ ID=6, Name="Sylvester Stallone"},
                                    new Actor{ ID=7, Name="Eddie Murphy"},
                                    new Actor{ ID=8, Name="Ben Stiller"},
                                    new Actor{ ID=9, Name="Adam Sandler"},
                                    new Actor{ ID=10, Name="Chris Rock"},
                                    new Actor{ ID=11, Name="Mike Myers"},
                                    new Actor{ ID=12, Name="Will Ferrell"},
                                    new Actor{ ID=13, Name="Al Pacino"},
                                    new Actor{ ID=14, Name="Tom Hanks"},
                                    new Actor{ ID=15, Name="Robert De Niro"},
                                    new Actor{ ID=16, Name="Morgan Freeman"},
                                    new Actor{ ID=17, Name="Dustin Hoffman"},
                                    new Actor{ ID=18, Name="Jeff Bridges"}
                                               
                                };


        }
    }
}