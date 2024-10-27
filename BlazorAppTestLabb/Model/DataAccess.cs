namespace BlazorAppTestLabb.Model
{
    public class DataAccess
    {
        public List<Users> GetUsers()
        {
            List<Users> userList = new()
           {
           new Users{Name="William Nylander",Email= "william.nylander@hemsidan.se", ID="88",
                             Street = "Villagatan 3",ZipCode = "11451",City= "Toronto", CompanyName= "Toronto Maple Leafs",CompanyCatchPhrase= "Puck on the net!"},
           new Users{Name="Linus Ullmark",Email= "linus.ullmark@hemsidan.se", ID= "35",
                             Street= "Villagatan 3", ZipCode="11451",City= "Ottawa", CompanyName= "Ottawa Senators", CompanyCatchPhrase="Eyes on the puck!"},
           new Users{Name="Rasmus Dahlin", Email= "rasmus.dahlin@hemsidan.se", ID= "26",
                             Street= "Villagatan 3",ZipCode= "11451",City= "Buffalo", CompanyName="Buffalo Sabres", CompanyCatchPhrase="Score, score, score!"},
           new Users{Name="Mika Zibanejad", Email= "mika.zibanejad@hemsidan.se", ID= "93",
                             Street= "Villagatan 3",ZipCode= "11451", City="New York", CompanyName= "New York Rangers", CompanyCatchPhrase="Hard work pays off!"},
           new Users{Name="Jesper Bratt", Email= "jesper.bratt@hemsidan.se", ID= "63",
                             Street= "Villagatan 3", ZipCode="11451", City="New Jersey", CompanyName= "New Jersey Devils", CompanyCatchPhrase="Pressure them hard!"},
           new Users{Name="William Karlsson", Email= "william.karlsson@hemsidan.se", ID= "71",
                             Street= "Villagatan 3",ZipCode= "11451", City="Las Vegas", CompanyName= "Vegas Golden Knights", CompanyCatchPhrase="Teamwork makes the dream work!"},
           new Users{Name="Victor Hedman", Email= "victor.hedman@hemsidan.se", ID= "77",
                             Street= "Villagatan 3", ZipCode="11451", City="Tampa Bay", CompanyName= "Tampa Bay Lightning", CompanyCatchPhrase="Dump the puck!"},
           new Users{Name="Filip Forsberg", Email= "filip.forsberg@hemsidan.se", ID= "9",
                             Street= "Villagatan 3", ZipCode="11451", City="Nashville", CompanyName= "Nashville Predators", CompanyCatchPhrase="Aim and shoot!"},
           new Users{Name="Leo Carlsson", Email="leo.carlsson@hemsidan.se", ID= "91",
                             Street= "Villagatan 3", ZipCode="11451", City="Anaheim", CompanyName= "Anaheim Ducks", CompanyCatchPhrase="Hockey is life!"},
           new Users{Name="Elias Pettersson", Email= "elias.pettersson@hemsidan.se", ID= "40",
                             Street= "Villagatan 3", ZipCode="11451", City="Vancouver", CompanyName= "Vancouver Canucks", CompanyCatchPhrase="Skate hard, play smart!"},
           new Users{Name="André Burakovsky", Email= "andre.burakovsky@hemsidan.se", ID= "95",
                             Street= "Villagatan 3", ZipCode="11451", City="Seattle", CompanyName= "Seattle Kraken", CompanyCatchPhrase="Make every shot count!"},
           new Users{Name="William Eklund", Email= "william.eklund@hemsidan.se", ID= "72",
                             Street= "Villagatan 3", ZipCode="11451", City="San Jose", CompanyName= "San Jose Sharks", CompanyCatchPhrase="Hockey is life!"},
           new Users{Name="Lucas Raymond", Email= "lucas.raymond@hemsidan.se", ID= "23",
                             Street= "Villagatan 3", ZipCode="11451", City="Detroit", CompanyName= "Detroit Red Wings", CompanyCatchPhrase="Hockey is life!"},
           new Users{Name = "Gustav Forsling", Email = "gustav.forsling@hemsidan.se", ID = "42",
                             Street = "Villagatan 3", ZipCode ="11451", City ="Ft. Lauderdale", CompanyName= "Florida Panthers", CompanyCatchPhrase ="Defense wins championships!"},
           new Users{Name="Samuel Ersson", Email= "samuel.ersson@hemsidan.se", ID= "33",
                             Street= "Villagatan 3", ZipCode="11451", City="Philadelphia", CompanyName= "Philadelphia Flyers", CompanyCatchPhrase="Create your own luck!"}
          };
            return userList;
        }
    }
}
