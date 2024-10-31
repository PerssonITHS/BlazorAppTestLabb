namespace BlazorAppTestLabb.Model
{
    public class DataAccess
    {
        public List<User> GetUsers()
        {
            List<User> userList = new ()
           {
           new User{Name="William Nylander",Email= "william.nylander@hemsidan.se", ID="88",
                             Street = "40 Bay Street",ZipCode = "11451",City= "Toronto", CompanyName= "Toronto Maple Leafs",CompanyCatchPhrase= "Puck on the net!"},
           new User{Name="Linus Ullmark",Email= "linus.ullmark@hemsidan.se", ID= "35",
                             Street= "1000 Palladium Drive", ZipCode="11451",City= "Ottawa", CompanyName= "Ottawa Senators", CompanyCatchPhrase="Eyes on the puck!"},
           new User{Name="Rasmus Dahlin", Email= "rasmus.dahlin@hemsidan.se", ID= "26",
                             Street= "1 Seymour H Knoxville III Plaza",ZipCode= "11451",City= "Buffalo", CompanyName="Buffalo Sabres", CompanyCatchPhrase="Score, score, score!"},
           new User{Name="Mika Zibanejad", Email= "mika.zibanejad@hemsidan.se", ID= "93",
                             Street= "4 Pennsylvania Plaza",ZipCode= "11451", City="New York", CompanyName= "New York Rangers", CompanyCatchPhrase="Hard work pays off!"},
           new User{Name="Jesper Bratt", Email= "jesper.bratt@hemsidan.se", ID= "63",
                             Street= "25 Lafayette Street", ZipCode="11451", City="New Jersey", CompanyName= "New Jersey Devils", CompanyCatchPhrase="Pressure them hard!"},
           new User{Name="William Karlsson", Email= "william.karlsson@hemsidan.se", ID= "71",
                             Street= "3780 South Las Vegas Boulevard",ZipCode= "11451", City="Las Vegas", CompanyName= "Vegas Golden Knights", CompanyCatchPhrase="Teamwork makes the dream work!"},
           new User{Name="Victor Hedman", Email= "victor.hedman@hemsidan.se", ID= "77",
                             Street= "401 Channelside Drive", ZipCode="11451", City="Tampa Bay", CompanyName= "Tampa Bay Lightning", CompanyCatchPhrase="Dump the puck!"},
           new User{Name="Filip Forsberg", Email= "filip.forsberg@hemsidan.se", ID= "9",
                             Street= "501 Broadway", ZipCode="11451", City="Nashville", CompanyName= "Nashville Predators", CompanyCatchPhrase="Aim and shoot!"},
           new User{Name="Leo Carlsson", Email="leo.carlsson@hemsidan.se", ID= "91",
                             Street= "2695 East Katella Avenue", ZipCode="11451", City="Anaheim", CompanyName= "Anaheim Ducks", CompanyCatchPhrase="Hockey is life!"},
           new User{Name="Elias Pettersson", Email= "elias.pettersson@hemsidan.se", ID= "40",
                             Street= "800 Griffiths Way", ZipCode="11451", City="Vancouver", CompanyName= "Vancouver Canucks", CompanyCatchPhrase="Skate hard, play smart!"},
           new User{Name="André Burakovsky", Email= "andre.burakovsky@hemsidan.se", ID= "95",
                             Street= "334 1st Avenue North", ZipCode="11451", City="Seattle", CompanyName= "Seattle Kraken", CompanyCatchPhrase="Make every shot count!"},
           new User{Name="William Eklund", Email= "william.eklund@hemsidan.se", ID= "72",
                             Street= "525 West Santa Clara Street", ZipCode="11451", City="San Jose", CompanyName= "San Jose Sharks", CompanyCatchPhrase="Hockey is life!"},
           new User{Name="Lucas Raymond", Email= "lucas.raymond@hemsidan.se", ID= "23",
                             Street= "2645 Woodward Avenue", ZipCode="11451", City="Detroit", CompanyName= "Detroit Red Wings", CompanyCatchPhrase="Hockey is life!"},
           new User{Name = "Gustav Forsling", Email = "gustav.forsling@hemsidan.se", ID = "42",
                             Street = "1 Panther Parkway", ZipCode ="11451", City ="Ft. Lauderdale", CompanyName= "Florida Panthers", CompanyCatchPhrase ="Defense wins championships!"},
           new User{Name="Samuel Ersson", Email= "samuel.ersson@hemsidan.se", ID= "33",
                             Street= "3601 South Broad Street", ZipCode="11451", City="Philadelphia", CompanyName= "Philadelphia Flyers", CompanyCatchPhrase="Create your own luck!"}
          };
            return userList;
        }
    }
}
