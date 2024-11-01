namespace BlazorAppTestLabb.Components.Pages
{
    public partial class NewUser
    {
        UsersComponent userOne = new();
        private string? _name;
		private string? _email;
		private string? _numberID;
		private string? _street;
		private string? _zipCode;
		private string? _city;
        private string? _company;
        private string? _companyCatchPhrase;

        private bool _isSubmitted = false;
        public void HandleNewUserInput()
        {
            _isSubmitted = true;
		}

        private int randomNumber;
        public void RandomGeneratedNumberID()
        {
            Random random = new Random();
            randomNumber = random.Next(1,101);
        }
		protected override void OnInitialized()
		{
			RandomGeneratedNumberID();
		}
	}
}
